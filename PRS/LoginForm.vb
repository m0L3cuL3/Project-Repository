Public Class LoginForm

    'to make form draggable'
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    'Sample Users'
    Dim student As String = "student"
    Dim instructor As String = "instructor"
    Dim headOfDepartment As String = "headofdepartment"
    Dim admin As String = "admin"

    'Sample Passwords'
    Dim studentPass As String = "student"
    Dim instructorPass As String = "instructor"
    Dim headOfDepartmentPass As String = "headofdepartment"
    Dim adminPass As String = "admin"


    Private Sub draggablePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles draggablePanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub draggablePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles draggablePanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub draggablePanel_MouseUp(sender As Object, e As MouseEventArgs) Handles draggablePanel.MouseUp
        draggable = False
    End Sub

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

    Private Sub minimizeBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles minimizeBtn.MouseClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub loginBtn_MouseEnter(sender As Object, e As EventArgs) Handles loginBtn.MouseEnter
        loginBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub loginBtn_MouseLeave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtn.Image = My.Resources.generalBtn
    End Sub

    'closes form'
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    'show form on login'
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        If userTb.Text = "" And passTb.Text = "" Then
            MessageBox.Show("Please enter Username and Password.")
        ElseIf userTb.Text = "" Then
            MessageBox.Show("Please enter Username")
        ElseIf passTb.Text = "" Then
            MessageBox.Show("Please enter Password.")
        ElseIf userTb.Text = admin And passTb.Text = adminPass Then
            AdminForm.Show()
            Me.Hide()
        ElseIf userTb.Text = student And passTb.Text = studentPass Then
            StudentForm.Show()
            Me.Hide()
        ElseIf userTb.Text = instructor And passTb.Text = instructorPass Then
            InstructorForm.Show()
            Me.Hide()
        ElseIf userTb.Text = headOfDepartment And passTb.Text = headOfDepartmentPass Then
            HeadOfDepartmentForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Credentials entered, please try again.")
        End If
    End Sub

End Class