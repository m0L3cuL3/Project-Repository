﻿Public Class StudentForm
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim isHide As Boolean

    'Dynamic Components'
    Dim flowPanel As New FlowLayoutPanel
    Dim repo As New myRepositories

    'executes code on form load'
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this is for the sliding feature.
        isHide = False
        profilePanel.Width = 0
        LoadLayoutProject()

    End Sub

    Private Sub profileButton_Click(sender As Object, e As EventArgs) Handles profileButton.Click
        sliderTMR.Start()
    End Sub

    Private Sub profilebackBtn_Click(sender As Object, e As EventArgs) Handles profilebackBtn.Click
        sliderTMR.Start()
    End Sub

    Private Sub sliderTMR_Tick(sender As Object, e As EventArgs) Handles sliderTMR.Tick
        If isHide Then
            profilePanel.Width = profilePanel.Width + 15
            If profilePanel.Width >= 280 Then
                sliderTMR.Stop()
                isHide = False
                Refresh()
            End If
        Else
            profilePanel.Width = profilePanel.Width - 20
            If profilePanel.Width <= 0 Then
                sliderTMR.Stop()
                isHide = True
                Refresh()
            End If
        End If
    End Sub

    Private Sub Dashboard_MouseDown(sender As Object, e As MouseEventArgs) Handles Dashboard.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Dashboard_MouseMove(sender As Object, e As MouseEventArgs) Handles Dashboard.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Dashboard_MouseUp(sender As Object, e As MouseEventArgs) Handles Dashboard.MouseUp
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

    Private Sub settingsBtn_MouseEnter(sender As Object, e As EventArgs) Handles settingsBtn.MouseEnter
        settingsBtn.Image = My.Resources.settingsBtnHover
    End Sub

    Private Sub settingsBtn_MouseLeave(sender As Object, e As EventArgs) Handles settingsBtn.MouseLeave
        settingsBtn.Image = My.Resources.settingsBtn
    End Sub

    Private Sub searchBtn_MouseEnter(sender As Object, e As EventArgs) Handles searchBtn.MouseEnter
        searchBtn.Image = My.Resources.neutralBtnHover
    End Sub

    Private Sub searchBtn_MouseLeave(sender As Object, e As EventArgs) Handles searchBtn.MouseLeave
        searchBtn.Image = My.Resources.neutralBtn
    End Sub

    Private Sub downloadBtn_MouseEnter(sender As Object, e As EventArgs) Handles downloadBtn.MouseEnter
        downloadBtn.Image = My.Resources.generalBtnHover
        downloadBtn.ForeColor = Color.White
    End Sub

    Private Sub downloadBtn_MouseLeave(sender As Object, e As EventArgs) Handles downloadBtn.MouseLeave
        downloadBtn.Image = My.Resources.neutralBtn
    End Sub

    Private Sub homeBtn_MouseEnter(sender As Object, e As EventArgs) Handles homeBtn.MouseEnter
        homeBtn.BackgroundImage = My.Resources.homeBtnHover
    End Sub

    Private Sub homeBtn_MouseLeave(sender As Object, e As EventArgs) Handles homeBtn.MouseLeave
        homeBtn.BackgroundImage = My.Resources.homeBtn
    End Sub

    Private Sub myprojectsBtn_MouseEnter(sender As Object, e As EventArgs) Handles myprojectsBtn.MouseEnter
        myprojectsBtn.BackgroundImage = My.Resources.myProjectsBtnHover
    End Sub

    Private Sub myprojectsBtn_MouseLeave(sender As Object, e As EventArgs) Handles myprojectsBtn.MouseLeave
        myprojectsBtn.BackgroundImage = My.Resources.myProjectsBtn
    End Sub

    Private Sub profilebackBtn_MouseEnter(sender As Object, e As EventArgs) Handles profilebackBtn.MouseEnter
        profilebackBtn.Image = My.Resources.backBtnHover
    End Sub

    Private Sub profilebackBtn_MouseLeave(sender As Object, e As EventArgs) Handles profilebackBtn.MouseLeave
        profilebackBtn.Image = My.Resources.backBtn
    End Sub

    Private Sub logoutBtn_MouseEnter(sender As Object, e As EventArgs) Handles logoutBtn.MouseEnter
        logoutBtn.Image = My.Resources.logoutBtnHover
    End Sub

    Private Sub logoutBtn_MouseLeave(sender As Object, e As EventArgs) Handles logoutBtn.MouseLeave
        logoutBtn.Image = My.Resources.logoutBtn
    End Sub

    Private Sub profileButton_MouseEnter(sender As Object, e As EventArgs) Handles profileButton.MouseEnter
        profileButton.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub profileButton_MouseLeave(sender As Object, e As EventArgs) Handles profileButton.MouseLeave
        profileButton.Image = My.Resources.generalBtn
    End Sub

    'close current form'
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
        LoginForm.Show()
    End Sub

    'for testing purposes only'
    Private Sub testBtn_Click(sender As Object, e As EventArgs) Handles testBtn.Click
        AddProject()
    End Sub

    'home button'
    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        mainLabel.Text = "Home"
        ShowLayout()
    End Sub

    'my repositories button'
    Private Sub myprojectsBtn_Click(sender As Object, e As EventArgs) Handles myprojectsBtn.Click
        mainLabel.Text = "My Repositories"
        DisplayRepository()
    End Sub

    'creates flow layout panel for adding components'
    Public Sub LoadLayoutProject()
        flowPanel.Dock = DockStyle.Fill

        flowPanel.AutoScroll = True
        mainPanel.Controls.Add(flowPanel)

    End Sub

    'shows layout panel'
    Public Sub ShowLayout()
        'removal of other components when in use'
        mainPanel.Controls.Remove(repo)

        LoadLayoutProject()
    End Sub

    'adds project panel to flow layout
    Public Sub AddProject()
        'removal of other component when in use'
        mainPanel.Controls.Remove(repo)

        LoadLayoutProject()

        Dim pp As New projectPanel
        pp.PictureBox1.Image = My.Resources.checkMark
        flowPanel.Controls.Add(pp)
    End Sub

    Public Sub DisplayRepository()
        'removal of other components when in use'
        mainPanel.Controls.Remove(flowPanel)

        repo.Dock = DockStyle.Fill

        mainPanel.Controls.Add(repo)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Close()
        LoginForm.Show()
    End Sub
End Class
