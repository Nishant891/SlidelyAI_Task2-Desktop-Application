Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add any initialization code here
    End Sub

    Private Sub buttonCreateSubmission_Click(sender As Object, e As EventArgs) Handles buttonCreateSubmission.Click
        OpenSubmissionForm()
    End Sub

    Private Sub buttonViewSubmission_Click(sender As Object, e As EventArgs) Handles buttonViewSubmission.Click
        OpenViewForm()
    End Sub

    Private Sub OpenSubmissionForm()
        Dim submissionForm As New SubmissionForm()
        submissionForm.Show()
    End Sub

    Private Sub OpenViewForm()
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.N) Then
            OpenSubmissionForm()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.V) Then
            OpenViewForm()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
