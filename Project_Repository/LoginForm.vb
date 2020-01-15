Public Class LoginForm

    ' for movable window (formless) '
    Public mouseX As Integer = 0
    Public mouseY As Integer = 0
    Public mouseInX As Integer
    Public mouseInY As Integer
    Public mouseDown As Boolean

    'sample users (student)'
    Dim studentUser As String = "sample"
    Dim studentPass As String = "password123"
    Dim studentType As String = "Student"

    'sample users (instructor)'
    Dim instructorUser As String = "sample"
    Dim instructorPass As String = "password123"
    Dim instructorType As String = "Instructor"

    'sample users (head of department)'
    Dim hodUser As String = "sample"
    Dim hodPass As String = "password123"
    Dim hodType As String = "Head Of Department"

    ' executes code on form load '
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' closes the form '
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    ' when top bar panel is released '
    Private Sub topBarPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseUp
        mouseDown = False
    End Sub

    ' when top bar panel is clicked '
    Private Sub topBarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseDown
        mouseDown = True
        mouseInX = MousePosition.X - Bounds.X
        mouseInY = MousePosition.Y - Bounds.Y
    End Sub

    ' setting application desktop location (to make it movable) '
    Private Sub topBarPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseMove
        If (mouseDown) Then
            mouseX = MousePosition.X - mouseInX
            mouseY = MousePosition.Y - mouseInY
            Me.SetDesktopLocation(mouseX, mouseY)
        End If
    End Sub

    ' opens a new form when user logged in '
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If userTb.Text = "" And passTb.Text = "" Then
            MessageBox.Show("Enter Data Please")
        ElseIf userTypeCb.SelectedItem = Nothing Then
            MessageBox.Show("Enter User Type Please")
        ElseIf userTb.Text = studentUser And passTb.Text = studentPass And userTypeCb.SelectedItem.ToString = studentType Then
            StudentForm.Show()
        ElseIf userTb.Text = instructorUser And passTb.Text = instructorPass And userTypeCb.SelectedItem = instructorType Then
            MessageBox.Show("Debug: " + userTb.Text + ", " + passTb.Text + ", " + userTypeCb.SelectedItem.ToString)
        ElseIf userTb.Text = hodUser And passTb.Text = hodPass And userTypeCb.SelectedItem.ToString = hodType Then
            MessageBox.Show("Debug: " + userTb.Text + ", " + passTb.Text + ", " + userTypeCb.SelectedItem.ToString)
        Else
            MessageBox.Show("Incorrect Credentials. Please Try Again.")
        End If
    End Sub
End Class
