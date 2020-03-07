Public Class ViewFilesForm
    Private Sub closeBtn_MouseEnter(sender As Object, e As EventArgs) Handles closeBtn.MouseEnter
        closeBtn.Image = My.Resources.closeBtnHover
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.Image = My.Resources.closeBtn
    End Sub

    Private Sub minimizeBtn_MouseEnter(sender As Object, e As EventArgs) Handles minimizeBtn.MouseEnter
        minimizeBtn.Image = My.Resources.minimizeBtnHover
    End Sub

    Private Sub minimizeBtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizeBtn.MouseLeave
        minimizeBtn.Image = My.Resources.minimizeBtn
    End Sub
End Class