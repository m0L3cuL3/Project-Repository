Public Class StudentForm

    ' for movable window (formless) '
    Public mouseX As Integer = 0
    Public mouseY As Integer = 0
    Public mouseInX As Integer
    Public mouseInY As Integer
    Public mouseDown As Boolean

    ' for sliding panel '
    Public isHide As Boolean

    ' executes code on form load '
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isHide = True 'True
        slidingPanel.Width = 0 '28

    End Sub

    ' closes this form '
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

    Private Sub slidingTimer_Tick(sender As Object, e As EventArgs) Handles slidingTimer.Tick
        If isHide = False Then
            slidingPanel.Width = slidingPanel.Width + 10
            If slidingPanel.Width >= 124 Then
                slidingTimer.Stop()
                isHide = True
                Refresh()
            End If
        Else
            slidingPanel.Width = slidingPanel.Width - 10
            If slidingPanel.Width <= 0 Then
                slidingTimer.Stop()
                isHide = False
                Refresh()
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        slidingTimer.Start()
    End Sub

    Private Sub slidingPanel_Paint(sender As Object, e As PaintEventArgs) Handles slidingPanel.Paint

    End Sub
End Class