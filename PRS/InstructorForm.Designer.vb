﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstructorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.sliderTMR = New System.Windows.Forms.Timer(Me.components)
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.declineBtn = New System.Windows.Forms.Button()
        Me.approveBtn = New System.Windows.Forms.Button()
        Me.profileButton = New System.Windows.Forms.Button()
        Me.downloadBtn = New System.Windows.Forms.Button()
        Me.bottomBar = New System.Windows.Forms.Panel()
        Me.settingsBtn = New System.Windows.Forms.PictureBox()
        Me.profilePanel = New System.Windows.Forms.Panel()
        Me.pendingProjectsBtn = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.myprojectsBtn = New System.Windows.Forms.Panel()
        Me.homeBtn = New System.Windows.Forms.Panel()
        Me.changePasswordLabel = New System.Windows.Forms.LinkLabel()
        Me.idNumberLabel = New System.Windows.Forms.Label()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.profilebackBtn = New System.Windows.Forms.PictureBox()
        Me.profileLabel = New System.Windows.Forms.Label()
        Me.profilePicture = New System.Windows.Forms.PictureBox()
        Me.Dashboard = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.searchBarLabel = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.datefilterLabel = New System.Windows.Forms.Label()
        Me.courseFilter = New System.Windows.Forms.ComboBox()
        Me.yearlevelfilterLabel = New System.Windows.Forms.Label()
        Me.dateFilter = New System.Windows.Forms.ComboBox()
        Me.coursefilterLabel = New System.Windows.Forms.Label()
        Me.yearlevelFilter = New System.Windows.Forms.ComboBox()
        Me.Panel4.SuspendLayout()
        Me.bottomBar.SuspendLayout()
        CType(Me.settingsBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.profilePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.profilebackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dashboard.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sliderTMR
        '
        Me.sliderTMR.Interval = 1
        '
        'mainPanel
        '
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 182)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(800, 341)
        Me.mainPanel.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.declineBtn)
        Me.Panel4.Controls.Add(Me.approveBtn)
        Me.Panel4.Controls.Add(Me.profileButton)
        Me.Panel4.Controls.Add(Me.downloadBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 523)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 47)
        Me.Panel4.TabIndex = 6
        '
        'declineBtn
        '
        Me.declineBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.declineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.declineBtn.Enabled = False
        Me.declineBtn.FlatAppearance.BorderSize = 0
        Me.declineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.declineBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.declineBtn.ForeColor = System.Drawing.Color.Black
        Me.declineBtn.Image = Global.PRS.My.Resources.Resources.neutralBtn
        Me.declineBtn.Location = New System.Drawing.Point(475, 4)
        Me.declineBtn.Name = "declineBtn"
        Me.declineBtn.Size = New System.Drawing.Size(153, 38)
        Me.declineBtn.TabIndex = 24
        Me.declineBtn.Text = "Decline"
        Me.declineBtn.UseVisualStyleBackColor = True
        '
        'approveBtn
        '
        Me.approveBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.approveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.approveBtn.Enabled = False
        Me.approveBtn.FlatAppearance.BorderSize = 0
        Me.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.approveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approveBtn.ForeColor = System.Drawing.Color.Black
        Me.approveBtn.Image = Global.PRS.My.Resources.Resources.neutralBtn
        Me.approveBtn.Location = New System.Drawing.Point(316, 4)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.Size = New System.Drawing.Size(153, 38)
        Me.approveBtn.TabIndex = 23
        Me.approveBtn.Text = "Approve"
        Me.approveBtn.UseVisualStyleBackColor = True
        '
        'profileButton
        '
        Me.profileButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.profileButton.FlatAppearance.BorderSize = 0
        Me.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profileButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileButton.ForeColor = System.Drawing.Color.White
        Me.profileButton.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.profileButton.Location = New System.Drawing.Point(0, 0)
        Me.profileButton.Name = "profileButton"
        Me.profileButton.Size = New System.Drawing.Size(200, 45)
        Me.profileButton.TabIndex = 1
        Me.profileButton.Text = "My Profile"
        Me.profileButton.UseVisualStyleBackColor = True
        '
        'downloadBtn
        '
        Me.downloadBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.downloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.downloadBtn.Enabled = False
        Me.downloadBtn.FlatAppearance.BorderSize = 0
        Me.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadBtn.ForeColor = System.Drawing.Color.Black
        Me.downloadBtn.Image = Global.PRS.My.Resources.Resources.neutralBtn
        Me.downloadBtn.Location = New System.Drawing.Point(634, 4)
        Me.downloadBtn.Name = "downloadBtn"
        Me.downloadBtn.Size = New System.Drawing.Size(153, 38)
        Me.downloadBtn.TabIndex = 20
        Me.downloadBtn.Text = "Download"
        Me.downloadBtn.UseVisualStyleBackColor = True
        '
        'bottomBar
        '
        Me.bottomBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bottomBar.Controls.Add(Me.settingsBtn)
        Me.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomBar.Location = New System.Drawing.Point(0, 570)
        Me.bottomBar.Name = "bottomBar"
        Me.bottomBar.Size = New System.Drawing.Size(800, 30)
        Me.bottomBar.TabIndex = 10
        '
        'settingsBtn
        '
        Me.settingsBtn.BackColor = System.Drawing.Color.Transparent
        Me.settingsBtn.Image = Global.PRS.My.Resources.Resources.settingsBtn
        Me.settingsBtn.Location = New System.Drawing.Point(751, 3)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(46, 24)
        Me.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.settingsBtn.TabIndex = 0
        Me.settingsBtn.TabStop = False
        '
        'profilePanel
        '
        Me.profilePanel.BackColor = System.Drawing.SystemColors.Control
        Me.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profilePanel.Controls.Add(Me.pendingProjectsBtn)
        Me.profilePanel.Controls.Add(Me.logoutBtn)
        Me.profilePanel.Controls.Add(Me.myprojectsBtn)
        Me.profilePanel.Controls.Add(Me.homeBtn)
        Me.profilePanel.Controls.Add(Me.changePasswordLabel)
        Me.profilePanel.Controls.Add(Me.idNumberLabel)
        Me.profilePanel.Controls.Add(Me.courseLabel)
        Me.profilePanel.Controls.Add(Me.nameLabel)
        Me.profilePanel.Controls.Add(Me.Panel2)
        Me.profilePanel.Controls.Add(Me.profilePicture)
        Me.profilePanel.Location = New System.Drawing.Point(0, 0)
        Me.profilePanel.Name = "profilePanel"
        Me.profilePanel.Size = New System.Drawing.Size(290, 600)
        Me.profilePanel.TabIndex = 11
        '
        'pendingProjectsBtn
        '
        Me.pendingProjectsBtn.BackgroundImage = Global.PRS.My.Resources.Resources.pendingProjectsBtn
        Me.pendingProjectsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pendingProjectsBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pendingProjectsBtn.Location = New System.Drawing.Point(0, 333)
        Me.pendingProjectsBtn.Name = "pendingProjectsBtn"
        Me.pendingProjectsBtn.Size = New System.Drawing.Size(290, 55)
        Me.pendingProjectsBtn.TabIndex = 8
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.logoutBtn.FlatAppearance.BorderSize = 0
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.Image = Global.PRS.My.Resources.Resources.logoutBtn
        Me.logoutBtn.Location = New System.Drawing.Point(0, 560)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(288, 38)
        Me.logoutBtn.TabIndex = 8
        Me.logoutBtn.Text = "LOG OUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'myprojectsBtn
        '
        Me.myprojectsBtn.BackgroundImage = Global.PRS.My.Resources.Resources.myProjectsBtn
        Me.myprojectsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.myprojectsBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.myprojectsBtn.Location = New System.Drawing.Point(0, 278)
        Me.myprojectsBtn.Name = "myprojectsBtn"
        Me.myprojectsBtn.Size = New System.Drawing.Size(290, 55)
        Me.myprojectsBtn.TabIndex = 7
        '
        'homeBtn
        '
        Me.homeBtn.BackgroundImage = Global.PRS.My.Resources.Resources.homeBtn
        Me.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.homeBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.homeBtn.Location = New System.Drawing.Point(0, 223)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(290, 55)
        Me.homeBtn.TabIndex = 6
        '
        'changePasswordLabel
        '
        Me.changePasswordLabel.AutoSize = True
        Me.changePasswordLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.changePasswordLabel.LinkColor = System.Drawing.Color.SteelBlue
        Me.changePasswordLabel.Location = New System.Drawing.Point(119, 143)
        Me.changePasswordLabel.Name = "changePasswordLabel"
        Me.changePasswordLabel.Size = New System.Drawing.Size(113, 17)
        Me.changePasswordLabel.TabIndex = 5
        Me.changePasswordLabel.TabStop = True
        Me.changePasswordLabel.Text = "Change Password"
        '
        'idNumberLabel
        '
        Me.idNumberLabel.AutoSize = True
        Me.idNumberLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idNumberLabel.Location = New System.Drawing.Point(119, 78)
        Me.idNumberLabel.Name = "idNumberLabel"
        Me.idNumberLabel.Size = New System.Drawing.Size(131, 23)
        Me.idNumberLabel.TabIndex = 4
        Me.idNumberLabel.Text = "20180014812"
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(119, 118)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(159, 16)
        Me.courseLabel.TabIndex = 3
        Me.courseLabel.Text = "CCS Department Instructor"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(119, 102)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(129, 16)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "Sean Myko C. Baang"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.profilebackBtn)
        Me.Panel2.Controls.Add(Me.profileLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 64)
        Me.Panel2.TabIndex = 1
        '
        'profilebackBtn
        '
        Me.profilebackBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.profilebackBtn.Image = Global.PRS.My.Resources.Resources.backBtn
        Me.profilebackBtn.Location = New System.Drawing.Point(224, 0)
        Me.profilebackBtn.Name = "profilebackBtn"
        Me.profilebackBtn.Size = New System.Drawing.Size(62, 62)
        Me.profilebackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profilebackBtn.TabIndex = 1
        Me.profilebackBtn.TabStop = False
        '
        'profileLabel
        '
        Me.profileLabel.AutoSize = True
        Me.profileLabel.BackColor = System.Drawing.Color.Transparent
        Me.profileLabel.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileLabel.ForeColor = System.Drawing.Color.White
        Me.profileLabel.Location = New System.Drawing.Point(10, 18)
        Me.profileLabel.Name = "profileLabel"
        Me.profileLabel.Size = New System.Drawing.Size(68, 23)
        Me.profileLabel.TabIndex = 0
        Me.profileLabel.Text = "Profile"
        '
        'profilePicture
        '
        Me.profilePicture.Image = Global.PRS.My.Resources.Resources.instructorPP
        Me.profilePicture.Location = New System.Drawing.Point(12, 70)
        Me.profilePicture.Name = "profilePicture"
        Me.profilePicture.Size = New System.Drawing.Size(101, 100)
        Me.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profilePicture.TabIndex = 0
        Me.profilePicture.TabStop = False
        '
        'Dashboard
        '
        Me.Dashboard.BackgroundImage = Global.PRS.My.Resources.Resources.Dashboard
        Me.Dashboard.Controls.Add(Me.Label3)
        Me.Dashboard.Controls.Add(Me.Label2)
        Me.Dashboard.Controls.Add(Me.searchBtn)
        Me.Dashboard.Controls.Add(Me.searchBarLabel)
        Me.Dashboard.Controls.Add(Me.minimizeBtn)
        Me.Dashboard.Controls.Add(Me.searchBar)
        Me.Dashboard.Controls.Add(Me.closeBtn)
        Me.Dashboard.Controls.Add(Me.datefilterLabel)
        Me.Dashboard.Controls.Add(Me.courseFilter)
        Me.Dashboard.Controls.Add(Me.yearlevelfilterLabel)
        Me.Dashboard.Controls.Add(Me.dateFilter)
        Me.Dashboard.Controls.Add(Me.coursefilterLabel)
        Me.Dashboard.Controls.Add(Me.yearlevelFilter)
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(800, 182)
        Me.Dashboard.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Project Repository System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 60)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Home"
        '
        'searchBtn
        '
        Me.searchBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchBtn.FlatAppearance.BorderSize = 0
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.Black
        Me.searchBtn.Image = Global.PRS.My.Resources.Resources.neutralBtn
        Me.searchBtn.Location = New System.Drawing.Point(183, 149)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(69, 22)
        Me.searchBtn.TabIndex = 19
        Me.searchBtn.Text = "Enter"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'searchBarLabel
        '
        Me.searchBarLabel.AutoSize = True
        Me.searchBarLabel.BackColor = System.Drawing.Color.Transparent
        Me.searchBarLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBarLabel.Location = New System.Drawing.Point(12, 130)
        Me.searchBarLabel.Name = "searchBarLabel"
        Me.searchBarLabel.Size = New System.Drawing.Size(51, 17)
        Me.searchBarLabel.TabIndex = 17
        Me.searchBarLabel.Text = "Search"
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.Image = Global.PRS.My.Resources.Resources.minimizeBtn
        Me.minimizeBtn.Location = New System.Drawing.Point(700, 0)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.Size = New System.Drawing.Size(50, 29)
        Me.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizeBtn.TabIndex = 1
        Me.minimizeBtn.TabStop = False
        '
        'searchBar
        '
        Me.searchBar.Location = New System.Drawing.Point(12, 150)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(164, 20)
        Me.searchBar.TabIndex = 16
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.PRS.My.Resources.Resources.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(750, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 29)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.TabStop = False
        '
        'datefilterLabel
        '
        Me.datefilterLabel.AutoSize = True
        Me.datefilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.datefilterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datefilterLabel.Location = New System.Drawing.Point(632, 130)
        Me.datefilterLabel.Name = "datefilterLabel"
        Me.datefilterLabel.Size = New System.Drawing.Size(40, 17)
        Me.datefilterLabel.TabIndex = 15
        Me.datefilterLabel.Text = "Date"
        '
        'courseFilter
        '
        Me.courseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseFilter.FormattingEnabled = True
        Me.courseFilter.Items.AddRange(New Object() {"Computer Science", "Information Technology", "Information Systems"})
        Me.courseFilter.Location = New System.Drawing.Point(317, 149)
        Me.courseFilter.Name = "courseFilter"
        Me.courseFilter.Size = New System.Drawing.Size(153, 21)
        Me.courseFilter.TabIndex = 12
        '
        'yearlevelfilterLabel
        '
        Me.yearlevelfilterLabel.AutoSize = True
        Me.yearlevelfilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.yearlevelfilterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearlevelfilterLabel.Location = New System.Drawing.Point(473, 129)
        Me.yearlevelfilterLabel.Name = "yearlevelfilterLabel"
        Me.yearlevelfilterLabel.Size = New System.Drawing.Size(73, 17)
        Me.yearlevelfilterLabel.TabIndex = 14
        Me.yearlevelfilterLabel.Text = "Year Level"
        '
        'dateFilter
        '
        Me.dateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dateFilter.FormattingEnabled = True
        Me.dateFilter.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010"})
        Me.dateFilter.Location = New System.Drawing.Point(635, 149)
        Me.dateFilter.Name = "dateFilter"
        Me.dateFilter.Size = New System.Drawing.Size(153, 21)
        Me.dateFilter.TabIndex = 10
        '
        'coursefilterLabel
        '
        Me.coursefilterLabel.AutoSize = True
        Me.coursefilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.coursefilterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursefilterLabel.Location = New System.Drawing.Point(317, 130)
        Me.coursefilterLabel.Name = "coursefilterLabel"
        Me.coursefilterLabel.Size = New System.Drawing.Size(53, 17)
        Me.coursefilterLabel.TabIndex = 13
        Me.coursefilterLabel.Text = "Course"
        '
        'yearlevelFilter
        '
        Me.yearlevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearlevelFilter.FormattingEnabled = True
        Me.yearlevelFilter.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.yearlevelFilter.Location = New System.Drawing.Point(476, 149)
        Me.yearlevelFilter.Name = "yearlevelFilter"
        Me.yearlevelFilter.Size = New System.Drawing.Size(153, 21)
        Me.yearlevelFilter.TabIndex = 11
        '
        'InstructorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.profilePanel)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.bottomBar)
        Me.Controls.Add(Me.Dashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InstructorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstructorForm"
        Me.Panel4.ResumeLayout(False)
        Me.bottomBar.ResumeLayout(False)
        CType(Me.settingsBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.profilePanel.ResumeLayout(False)
        Me.profilePanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.profilebackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dashboard.ResumeLayout(False)
        Me.Dashboard.PerformLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dashboard As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchBtn As Button
    Friend WithEvents searchBarLabel As Label
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents searchBar As TextBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents datefilterLabel As Label
    Friend WithEvents courseFilter As ComboBox
    Friend WithEvents yearlevelfilterLabel As Label
    Friend WithEvents dateFilter As ComboBox
    Friend WithEvents coursefilterLabel As Label
    Friend WithEvents yearlevelFilter As ComboBox
    Friend WithEvents sliderTMR As Timer
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents profileButton As Button
    Friend WithEvents downloadBtn As Button
    Friend WithEvents bottomBar As Panel
    Friend WithEvents settingsBtn As PictureBox
    Friend WithEvents profilePanel As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents myprojectsBtn As Panel
    Friend WithEvents homeBtn As Panel
    Friend WithEvents changePasswordLabel As LinkLabel
    Friend WithEvents idNumberLabel As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents profilebackBtn As PictureBox
    Friend WithEvents profileLabel As Label
    Friend WithEvents profilePicture As PictureBox
    Friend WithEvents pendingProjectsBtn As Panel
    Friend WithEvents declineBtn As Button
    Friend WithEvents approveBtn As Button
End Class