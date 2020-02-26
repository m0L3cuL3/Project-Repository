Public Class LoginForm

    'to make form draggable'
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    'Sample Users'
    Dim admin As String = "admin"

    'Sample Passwords'
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

        Try
            If userTb.Text = "" And passTb.Text = "" Then
                MessageBox.Show("Please enter Username and Password.")
            ElseIf userTb.Text = "" Then
                MessageBox.Show("Please enter Username")
            ElseIf passTb.Text = "" Then
                MessageBox.Show("Please enter Password.")
            ElseIf Me.AdminDataTableAdapter.CheckAdmin(userTb.Text, passTb.Text) = 1 Then
                AdminForm.Show()
                Me.Hide()
            ElseIf Me.StudentDataTableAdapter.CheckStudent(userTb.Text, passTb.Text) = 1 Then

                'for student verification
                SetUserID(Me.StudentDataTableAdapter.SelectStudentID(userTb.Text, passTb.Text)) 'sets user id
                SetUsername(Me.StudentDataTableAdapter.SelectStudentName(userTb.Text, passTb.Text)) 'sets user name
                SetStudentProgram(Me.StudentDataTableAdapter.SelectStudentCourse(userTb.Text, passTb.Text), Me.StudentDataTableAdapter.SelectStudentLevel(userTb.Text, passTb.Text)) 'sets course and year
                StudentForm.Show()
                Me.Hide()

            ElseIf Me.InstructorDataTableAdapter.CheckInstructor(userTb.Text, passTb.Text) = 1 Then

                'for instructor verification
                SetUserID(Me.InstructorDataTableAdapter.SelectInstructorID(userTb.Text, passTb.Text)) 'sets user id
                SetUsername(Me.InstructorDataTableAdapter.SelectInstructorName(userTb.Text, passTb.Text)) 'sets user name
                SetTitle(Me.InstructorDataTableAdapter.SelectInstructorTitle(userTb.Text, passTb.Text)) 'sets user title
                InstructorForm.Show()
                Me.Hide()

            ElseIf Me.HeadDataTableAdapter.CheckHead(userTb.Text, passTb.Text) = 1 Then

                'for head of department verification
                SetUserID(Me.HeadDataTableAdapter.SelectHeadID(userTb.Text, passTb.Text)) 'sets user id
                SetUsername(Me.HeadDataTableAdapter.SelectHeadName(userTb.Text, passTb.Text)) 'sets user name
                SetTitle(Me.HeadDataTableAdapter.SelectHeadTitle(userTb.Text, passTb.Text)) 'sets user title
                HeadOfDepartmentForm.Show()
                Me.Hide()

            Else
                MessageBox.Show("Incorrect Credentials entered, please try again.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Incorrect Credentials entered, please try again.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ClearTextBoxes(Me)

    End Sub

    Private Sub passTb_KeyDown(sender As Object, e As KeyEventArgs) Handles passTb.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginBtn.PerformClick()
        End If
    End Sub

    Private Sub userTb_KeyDown(sender As Object, e As KeyEventArgs) Handles userTb.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginBtn.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepoDBDataSet.StudentData' table. You can move, or remove it, as needed.
        'Me.StudentDataTableAdapter.Fill(Me.RepoDBDataSet.StudentData)
    End Sub
End Class