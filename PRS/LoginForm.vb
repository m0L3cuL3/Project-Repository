Public Class LoginForm

    Private Sub closeBtn_MouseEnter(sender As Object, e As EventArgs) Handles closeBtn.MouseEnter
        closeBtn.Image = My.Resources.closeBtnHover
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.Image = My.Resources.closeBtn
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub minimizeBtn_MouseEnter(sender As Object, e As EventArgs) Handles minimizeBtn.MouseEnter
        minimizeBtn.Image = My.Resources.minimizeBtnHover
    End Sub

    Private Sub minimizeBtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizeBtn.MouseLeave
        minimizeBtn.Image = My.Resources.minimizeBtn

    End Sub

    Private Sub minimizeBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles minimizeBtn.MouseClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub loginBtn_MouseEnter(sender As Object, e As EventArgs) Handles loginBtn.MouseEnter
        loginBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub loginBtn_MouseLeave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtn.Image = My.Resources.generalBtn
    End Sub

End Class