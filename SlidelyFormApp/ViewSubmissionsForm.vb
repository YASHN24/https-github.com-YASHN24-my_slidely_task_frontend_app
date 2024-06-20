Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private allSubmissions As List(Of Submission)

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButton.RoundButtonCorners(btnPrevious, 15)
        RoundedButton.RoundButtonCorners(btnNext, 15)
        RoundedButton.RoundButtonCorners(btnDelete, 15)
        RoundedButton.RoundButtonCorners(btnEdit, 15)
        RoundedButton.RoundButtonCorners(btnSearch, 15)
        RoundedButton.RoundButtonCorners(btnReset, 15)

        Dim success As Boolean = Await FetchAllSubmissions()
        If success AndAlso submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("Failed to fetch submissions or no submissions available.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim submission = submissions(currentIndex)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{submission.Name}/{submission.Email}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!")
                submissions.RemoveAt(currentIndex)
                If submissions.Count > 0 Then
                    If currentIndex >= submissions.Count Then
                        currentIndex -= 1
                    End If
                    DisplaySubmission(currentIndex)
                Else
                    ClearSubmissionFields()
                    MessageBox.Show("No more submissions available.")
                End If
            Else
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to delete submission. Response: {responseContent}")
            End If
        End Using
    End Sub


    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearchEmail.Text
        If Not String.IsNullOrWhiteSpace(email) Then
            Dim success As Boolean = Await SearchSubmissionsByEmail(email)
            If success AndAlso submissions.Count > 0 Then
                currentIndex = 0
                DisplaySubmission(currentIndex)
            Else
                MessageBox.Show("No submissions found for the provided email.")
            End If
        End If
    End Sub

    Private Async Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Await ResetSubmissions()
        If submissions.Count > 0 Then
            currentIndex = 0
            DisplaySubmission(currentIndex)
        Else
            ClearSubmissionFields()
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.M Then
            btnSearch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.R Then
            btnReset.PerformClick()
        End If
    End Sub

    Private Async Function FetchAllSubmissions() As Task(Of Boolean)
        allSubmissions = New List(Of Submission)()
        Dim index As Integer = 0
        Dim continueFetching As Boolean = True

        Using client As New HttpClient()
            While continueFetching
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                    If submission IsNot Nothing Then
                        allSubmissions.Add(submission)
                        index += 1
                    Else
                        continueFetching = False
                    End If
                Else
                    continueFetching = False
                End If
            End While
        End Using

        submissions = New List(Of Submission)(allSubmissions)
        Return submissions.Count > 0
    End Function

    Private Async Function SearchSubmissionsByEmail(email As String) As Task(Of Boolean)
        submissions = New List(Of Submission)()

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
            End If
        End Using

        Return submissions.Count > 0
    End Function

    Private Sub btnEdit_Click(submission As Submission)
        Dim createForm As New CreateSubmissionForm(submission)
        createForm.ShowDialog()
    End Sub

    Private Async Function ResetSubmissions() As Task
        submissions = New List(Of Submission)(allSubmissions)
        Await Task.CompletedTask
    End Function

    Private Sub DisplaySubmission(index As Integer)
        Dim submission = submissions(index)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.githubLink
        txtStopwatch.Text = submission.stopwatchTime
    End Sub

    Private Sub ClearSubmissionFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithub.Clear()
        txtStopwatch.Clear()
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property githubLink As String
        Public Property stopwatchTime As String
    End Class
End Class
