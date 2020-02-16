Public Class projectPanel
    Dim isToggled As Boolean = False

    Private Sub projectPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'approve button
    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        Dim fuid As New Guid(guidLabel.Text)
        Me.FileDataTableAdapter.ApproveFile("approved", fuid)
    End Sub
End Class
