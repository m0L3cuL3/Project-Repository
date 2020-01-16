Public Class myRepositories
    Private Sub selectBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRuploadBtn.MouseEnter
        MRuploadBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub selectBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRuploadBtn.MouseLeave
        MRuploadBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub MRcopyBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRcopyBtn.MouseEnter
        MRcopyBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub MRcopyBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRcopyBtn.MouseLeave
        MRcopyBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub MRdeleteBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRdeleteBtn.MouseEnter
        MRdeleteBtn.Image = My.Resources.logoutBtnHover 'i use log out button because iz red. communism
    End Sub

    Private Sub MRdeleteBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRdeleteBtn.MouseLeave
        MRdeleteBtn.Image = My.Resources.logoutBtn 'i use log out button because iz red. communism
    End Sub

End Class
