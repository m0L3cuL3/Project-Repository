Imports System.Data.SqlClient

Public Class HeadOfDepartmentForm
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim isHide As Boolean

    Dim approvedPanel, pendingPanel As New FlowLayoutPanel

    'executes code in form load'
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this is for the sliding feature.
        isHide = False
        profilePanel.Width = 0

        LoadApprovedProject() 'shows all approved projects

        idNumberLabel.Text = GetUserID()
        nameLabel.Text = GetUsername()
        titleLabel.Text = GetTitle()

    End Sub

    Private Sub profileButton_Click(sender As Object, e As EventArgs) Handles profileButton.Click
        sliderTMR.Start()
    End Sub

    Private Sub profilebackBtn_Click(sender As Object, e As EventArgs) Handles profilebackBtn.Click
        sliderTMR.Start()
    End Sub

    Private Sub sliderTMR_Tick(sender As Object, e As EventArgs) Handles sliderTMR.Tick
        If isHide Then
            profilePanel.Width = profilePanel.Width + 10
            If profilePanel.Width >= 280 Then
                sliderTMR.Stop()
                isHide = False
                Refresh()
            End If
        Else
            profilePanel.Width = profilePanel.Width - 25
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

    Private Sub homeBtn_MouseEnter(sender As Object, e As EventArgs) Handles homeBtn.MouseEnter
        homeBtn.BackgroundImage = My.Resources.homeBtnHover
    End Sub

    Private Sub homeBtn_MouseLeave(sender As Object, e As EventArgs) Handles homeBtn.MouseLeave
        homeBtn.BackgroundImage = My.Resources.homeBtn
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

    Private Sub pendingProjectsBtn_MouseEnter(sender As Object, e As EventArgs) Handles pendingProjectsBtn.MouseEnter
        pendingProjectsBtn.BackgroundImage = My.Resources.pendingProjectsBtnHover
    End Sub

    Private Sub pendingProjectsBtn_MouseLeave(sender As Object, e As EventArgs) Handles pendingProjectsBtn.MouseLeave
        pendingProjectsBtn.BackgroundImage = My.Resources.pendingProjectsBtn
    End Sub


    'home button'
    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        mainLabel.Text = "Home"
        LoadApprovedProject() 'loads approved projects
        ShowFilterComponent() 'shows filter functions
    End Sub

    'pending projects button'
    Private Sub pendingProjectsBtn_Click(sender As Object, e As EventArgs) Handles pendingProjectsBtn.Click
        mainLabel.Text = "Pending Projects"
        HideFilterComponent() 'hides filter functions
        LoadPendingProject() 'loads pending projects
    End Sub

    'search button
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If searchBar.Text = "" Then
            MsgBox("Please enter repository name")
        End If
        SearchRepository(searchBar.Text)
    End Sub

    'closes the form'
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
        LoginForm.Show()
    End Sub

    'creates flow layout panel for approved projects'
    Public Sub LoadApprovedLayoutProject()
        approvedPanel.Dock = DockStyle.Fill

        approvedPanel.AutoScroll = True
        mainPanel.Controls.Add(approvedPanel)

    End Sub

    'creates flow layout panel for pending projects'
    Public Sub LoadPendingLayoutProject()
        pendingPanel.Dock = DockStyle.Fill

        pendingPanel.AutoScroll = True
        mainPanel.Controls.Add(pendingPanel)

    End Sub

    'loads pending projects'
    Public Sub LoadPendingProject()

        pendingPanel.Controls.Clear()

        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
        conn.Open()

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM [Table] WHERE isApproved = 'pending'"

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        'removal of other component when in use'
        mainPanel.Controls.Remove(approvedPanel)

        LoadPendingLayoutProject()

        While dr.Read()
            Dim pp As New projectPanel
            pp.PictureBox1.Image = My.Resources.pendingMark2
            pp.approveBtn.Enabled = True
            pp.approveBtn.Visible = True
            pp.guidLabel.Text = dr.Item("file_id").ToString
            pp.uploaderLabel.Text = "Uploaded by " & "[" & dr.Item("file_uploader_name") & "]" & " on " & dr.Item("file_update")
            pp.projectTitle.Text = dr.Item("file_name")
            pendingPanel.Controls.Add(pp)
            Refresh()
        End While
    End Sub

    'loads approved projects'
    Public Sub LoadApprovedProject()
        approvedPanel.Controls.Clear()

        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
        conn.Open()

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM [Table] WHERE isApproved = 'approved'"

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        'removal of other component when in use'
        mainPanel.Controls.Remove(pendingPanel)

        LoadApprovedLayoutProject()

        While dr.Read()
            Dim pp As New projectPanel
            pp.downloadBtn.Enabled = True
            pp.downloadBtn.Visible = True
            pp.PictureBox1.Image = My.Resources.checkMark
            pp.guidLabel.Text = dr.Item("file_id").ToString
            pp.uploaderLabel.Text = "Uploaded by " & "[" & dr.Item("file_uploader_name") & "]" & " on " & dr.Item("file_update")
            pp.projectTitle.Text = dr.Item("file_name")
            approvedPanel.Controls.Add(pp)
        End While
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Close()
        LoginForm.Show()
    End Sub

    Private Sub FilterBtn_Click(sender As Object, e As EventArgs) Handles FilterBtn.Click
        Filter()
    End Sub

    'filter system
    Private Sub Filter()
        Dim dateFilter As DateTime = DateFilterCb.Value

        approvedPanel.Controls.Clear()
        If courseFilter.SelectedItem = "Instructor" Then
            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] INNER JOIN dbo.[InstructorData] ON dbo.[Table].file_uploader = dbo.[InstructorData].instructor_id WHERE file_update = @date AND isApproved = 'approved'"
                cmd.Parameters.AddWithValue("@date", DateFilterCb.Value)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                'removal of other component when in use'
                mainPanel.Controls.Remove(pendingPanel)

                LoadApprovedLayoutProject()

                While dr.Read()
                    Dim pp As New projectPanel
                    pp.downloadBtn.Enabled = True
                    pp.downloadBtn.Visible = True
                    pp.PictureBox1.Image = My.Resources.checkMark
                    pp.guidLabel.Text = dr.Item("file_id").ToString
                    pp.uploaderLabel.Text = "Uploaded by " & "[" & dr.Item("file_uploader_name") & "]" & " on " & dr.Item("file_update")
                    pp.projectTitle.Text = dr.Item("file_name")
                    approvedPanel.Controls.Add(pp)
                End While
            Catch ex As Exception
                MessageBox.Show("Please complete the filter settings.", "Incomplete Data Provided", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] INNER JOIN dbo.[StudentData] ON dbo.[Table].file_uploader = dbo.[StudentData].student_id WHERE student_level = @year AND student_course = @course AND file_update = @date AND isApproved = 'approved'"
                cmd.Parameters.AddWithValue("@year", yearlevelFilter.SelectedItem)
                cmd.Parameters.AddWithValue("@course", courseFilter.SelectedItem)
                cmd.Parameters.AddWithValue("@date", DateFilterCb.Value)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                'removal of other component when in use'
                mainPanel.Controls.Remove(pendingPanel)

                LoadApprovedLayoutProject()

                While dr.Read()
                    Dim pp As New projectPanel
                    pp.downloadBtn.Enabled = True
                    pp.downloadBtn.Visible = True
                    pp.PictureBox1.Image = My.Resources.checkMark
                    pp.guidLabel.Text = dr.Item("file_id").ToString
                    pp.uploaderLabel.Text = "Uploaded by " & "[" & dr.Item("file_uploader_name") & "]" & " on " & dr.Item("file_update")
                    pp.projectTitle.Text = dr.Item("file_name")
                    approvedPanel.Controls.Add(pp)
                End While
            Catch ex As Exception
                MessageBox.Show("Please complete the filter settings.", "Incomplete Data Provided", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'hides the global filter components
    Private Sub HideFilterComponent()
        coursefilterLabel.Visible = False
        yearlevelfilterLabel.Visible = False
        datefilterLabel.Visible = False
        DateFilterCb.Visible = False
        yearlevelFilter.Visible = False
        courseFilter.Visible = False
        FilterBtn.Visible = False
    End Sub

    'shows the global filter components
    Private Sub ShowFilterComponent()
        coursefilterLabel.Visible = True
        yearlevelfilterLabel.Visible = True
        datefilterLabel.Visible = True
        DateFilterCb.Visible = True
        yearlevelFilter.Visible = True
        courseFilter.Visible = True
        FilterBtn.Visible = True
    End Sub

    'searches through the database for user inputted repository
    Private Sub SearchRepository(repoName As String)
        approvedPanel.Controls.Clear()

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [Table] WHERE file_name = @filename AND isApproved = 'approved'"
            cmd.Parameters.AddWithValue("@filename", searchBar.Text)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            'removal of other component when in use'
            pendingPanel.Controls.Remove(pendingPanel)

            LoadApprovedLayoutProject()

            While dr.Read()
                Dim pp As New projectPanel
                pp.downloadBtn.Enabled = True
                pp.downloadBtn.Visible = True
                pp.PictureBox1.Image = My.Resources.checkMark
                pp.guidLabel.Text = dr.Item("file_id").ToString
                pp.uploaderLabel.Text = "Uploaded by " & "[" & dr.Item("file_uploader_name") & "]" & " on " & dr.Item("file_update")
                pp.projectTitle.Text = dr.Item("file_name")
                approvedPanel.Controls.Add(pp)
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    'changes user password
    Private Sub changePasswordLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles changePasswordLabel.LinkClicked
        Dim newPass As String
        newPass = InputBox("Please enter a new password." & vbCrLf & "Make sure you remember it.", "Change Password")

        If DialogResult.OK Then
            MessageBox.Show("Are you sure you want to use this password?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult.Yes Then
                Try
                    Dim conn As New SqlConnection
                    conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                    conn.Open()

                    Dim cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd.CommandText = "UPDATE [HeadData] SET head_pass = @pass WHERE head_id = @id"
                    cmd.Parameters.AddWithValue("@pass", newPass)
                    cmd.Parameters.AddWithValue("@id", GetUserID)

                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    MessageBox.Show("Password change successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub
End Class