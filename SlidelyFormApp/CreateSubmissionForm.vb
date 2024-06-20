Imports Newtonsoft.Json
Imports SlidelyFormApp.ViewSubmissionsForm
Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private stopwatchOffset As TimeSpan = TimeSpan.Zero
    Private _submission As Submission


    Public Sub New(Optional ByVal submission As Submission = Nothing)
        InitializeComponent()


        If submission IsNot Nothing Then
            PopulateFormFields(submission)
        End If
    End Sub


    Private Sub PopulateFormFields(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.githubLink
        Dim timeSpan As TimeSpan
        If TimeSpan.TryParse(submission.stopwatchTime, timeSpan) Then
            stopwatchOffset = timeSpan
            UpdateStopwatchLabel()
        Else
            txtStopwatch.Text = "00:00:00"
        End If
    End Sub


    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            stopwatchOffset = stopwatch.Elapsed
        Else
            stopwatch.Start()
        End If
    End Sub


    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub


    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButton.RoundButtonCorners(btnStopwatch, 15)
        RoundedButton.RoundButtonCorners(btnSubmit, 15)
        timerStopwatch.Start()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithub.Text
        Dim totalElapsedTime As TimeSpan = stopwatch.Elapsed + stopwatchOffset
        Dim stopwatchTime As String = totalElapsedTime.ToString("hh\:mm\:ss")


        If Not ValidateInputs(name, email, phone) Then
            MessageBox.Show("Please provide valid inputs.")
            Return
        End If


        Dim submission As New With {
        .name = name,
        .email = email,
        .phone = phone,
        .githubLink = githubLink,
        .stopwatchTime = stopwatchTime
    }


        Dim json As String = JsonConvert.SerializeObject(submission)

        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Form Submitted Successfully!")
                ClearFormFields()
                UpdateStopwatchLabel()
            Else
                MessageBox.Show("Failed to submit form.")
            End If
        End Using


    End Sub


    Private Sub ClearFormFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        txtStopwatch.Clear()
        stopwatch.Reset()

    End Sub

    Private Function ValidateInputs(name As String, email As String, phone As String) As Boolean

        If Not Regex.IsMatch(name, "^[a-zA-Z\s]+$") Then Return False

        If Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then Return False

        If Not Regex.IsMatch(phone, "^\d+$") Then Return False

        Return True
    End Function

    Private Sub UpdateStopwatchLabel()
        Dim currentTime As TimeSpan = stopwatch.Elapsed + stopwatchOffset
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        If stopwatch.IsRunning Then
            UpdateStopwatchLabel()
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
    End Sub
End Class