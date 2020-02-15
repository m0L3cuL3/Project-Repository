Public Class AdminForm
    Private Sub studentBtn_MouseEnter(sender As Object, e As EventArgs) Handles studentBtn.MouseEnter
        studentBtn.BackgroundImage = My.Resources.studentsBtnHover
    End Sub

    Private Sub studentBtn_MouseLeave(sender As Object, e As EventArgs) Handles studentBtn.MouseLeave
        studentBtn.BackgroundImage = My.Resources.studentsBtn
    End Sub
End Class