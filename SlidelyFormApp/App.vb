Public Class App

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButton.RoundButtonCorners(btnViewSubmissions, 15)
        RoundedButton.RoundButtonCorners(btnCreateNewSubmission, 15)


    End Sub






    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm
        createForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm
        viewForm.Show()
    End Sub

    Private Sub App_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub
End Class
