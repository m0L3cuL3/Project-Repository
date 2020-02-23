<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Student_idLabel As System.Windows.Forms.Label
        Dim Student_nameLabel As System.Windows.Forms.Label
        Dim Student_levelLabel As System.Windows.Forms.Label
        Dim Student_courseLabel As System.Windows.Forms.Label
        Dim Instructor_idLabel As System.Windows.Forms.Label
        Dim Instructor_userLabel As System.Windows.Forms.Label
        Dim Instructor_titleLabel As System.Windows.Forms.Label
        Me.Instructor_passLabel = New System.Windows.Forms.Label()
        Me.Student_passLabel = New System.Windows.Forms.Label()
        Me.topBarPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.FileDataTableAdapter = New PRS.repoDBDataSetTableAdapters.FileDataTableAdapter()
        Me.HeadDataTableAdapter = New PRS.repoDBDataSetTableAdapters.HeadDataTableAdapter()
        Me.InstructorDataTableAdapter = New PRS.repoDBDataSetTableAdapters.InstructorDataTableAdapter()
        Me.StudentDataTableAdapter = New PRS.repoDBDataSetTableAdapters.StudentDataTableAdapter()
        Me.DNBTabControl = New PRS.DotNetBarTabcontrol()
        Me.HomeTab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DatabaseGroup = New System.Windows.Forms.GroupBox()
        Me.SqlVersionLabel = New System.Windows.Forms.Label()
        Me.StudentTab = New System.Windows.Forms.TabPage()
        Me.StudentSubTabControl = New PRS.DotNetBarTabcontrol()
        Me.StudentDataTab = New System.Windows.Forms.TabPage()
        Me.StudentDataManager = New System.Windows.Forms.GroupBox()
        Me.Student_passTextBox = New System.Windows.Forms.TextBox()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoDBDataSet = New PRS.repoDBDataSet()
        Me.SqlStudentComboBox = New System.Windows.Forms.ComboBox()
        Me.executeStudentBtn = New System.Windows.Forms.Button()
        Me.Student_courseTextBox = New System.Windows.Forms.TextBox()
        Me.Student_levelTextBox = New System.Windows.Forms.TextBox()
        Me.Student_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Student_idTextBox = New System.Windows.Forms.TextBox()
        Me.StudentView = New System.Windows.Forms.ListView()
        Me.StudentIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StudentNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StudentLevelHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StudentCourseHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InstructorTab = New System.Windows.Forms.TabPage()
        Me.InstructorSubTabControl = New PRS.DotNetBarTabcontrol()
        Me.InstructorDataTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Instructor_passTextBox = New System.Windows.Forms.TextBox()
        Me.InstructorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Instructor_titleTextBox = New System.Windows.Forms.TextBox()
        Me.Instructor_userTextBox = New System.Windows.Forms.TextBox()
        Me.Instructor_idTextBox = New System.Windows.Forms.TextBox()
        Me.SqlInstructorComboBox = New System.Windows.Forms.ComboBox()
        Me.executeInstructorBtn = New System.Windows.Forms.Button()
        Me.InstructorView = New System.Windows.Forms.ListView()
        Me.InstructorIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InstructorNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InstructorTitleHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeadTab = New System.Windows.Forms.TabPage()
        Me.TableAdapterManager = New PRS.repoDBDataSetTableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Student_idLabel = New System.Windows.Forms.Label()
        Student_nameLabel = New System.Windows.Forms.Label()
        Student_levelLabel = New System.Windows.Forms.Label()
        Student_courseLabel = New System.Windows.Forms.Label()
        Instructor_idLabel = New System.Windows.Forms.Label()
        Instructor_userLabel = New System.Windows.Forms.Label()
        Instructor_titleLabel = New System.Windows.Forms.Label()
        Me.topBarPanel.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DNBTabControl.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DatabaseGroup.SuspendLayout()
        Me.StudentTab.SuspendLayout()
        Me.StudentSubTabControl.SuspendLayout()
        Me.StudentDataTab.SuspendLayout()
        Me.StudentDataManager.SuspendLayout()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InstructorTab.SuspendLayout()
        Me.InstructorSubTabControl.SuspendLayout()
        Me.InstructorDataTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.InstructorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_idLabel
        '
        Student_idLabel.AutoSize = True
        Student_idLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Student_idLabel.Location = New System.Drawing.Point(12, 22)
        Student_idLabel.Name = "Student_idLabel"
        Student_idLabel.Size = New System.Drawing.Size(68, 16)
        Student_idLabel.TabIndex = 0
        Student_idLabel.Text = "Student ID:"
        '
        'Student_nameLabel
        '
        Student_nameLabel.AutoSize = True
        Student_nameLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Student_nameLabel.Location = New System.Drawing.Point(12, 48)
        Student_nameLabel.Name = "Student_nameLabel"
        Student_nameLabel.Size = New System.Drawing.Size(90, 16)
        Student_nameLabel.TabIndex = 2
        Student_nameLabel.Text = "Student Name:"
        '
        'Student_levelLabel
        '
        Student_levelLabel.AutoSize = True
        Student_levelLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Student_levelLabel.Location = New System.Drawing.Point(12, 74)
        Student_levelLabel.Name = "Student_levelLabel"
        Student_levelLabel.Size = New System.Drawing.Size(86, 16)
        Student_levelLabel.TabIndex = 4
        Student_levelLabel.Text = "Student Level:"
        '
        'Student_courseLabel
        '
        Student_courseLabel.AutoSize = True
        Student_courseLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Student_courseLabel.Location = New System.Drawing.Point(12, 100)
        Student_courseLabel.Name = "Student_courseLabel"
        Student_courseLabel.Size = New System.Drawing.Size(94, 16)
        Student_courseLabel.TabIndex = 6
        Student_courseLabel.Text = "Student Course:"
        '
        'Instructor_idLabel
        '
        Instructor_idLabel.AutoSize = True
        Instructor_idLabel.Location = New System.Drawing.Point(7, 25)
        Instructor_idLabel.Name = "Instructor_idLabel"
        Instructor_idLabel.Size = New System.Drawing.Size(74, 16)
        Instructor_idLabel.TabIndex = 35
        Instructor_idLabel.Text = "Instructor ID:"
        '
        'Instructor_userLabel
        '
        Instructor_userLabel.AutoSize = True
        Instructor_userLabel.Location = New System.Drawing.Point(7, 50)
        Instructor_userLabel.Name = "Instructor_userLabel"
        Instructor_userLabel.Size = New System.Drawing.Size(85, 16)
        Instructor_userLabel.TabIndex = 36
        Instructor_userLabel.Text = "Instructor User:"
        '
        'Instructor_titleLabel
        '
        Instructor_titleLabel.AutoSize = True
        Instructor_titleLabel.Location = New System.Drawing.Point(7, 77)
        Instructor_titleLabel.Name = "Instructor_titleLabel"
        Instructor_titleLabel.Size = New System.Drawing.Size(83, 16)
        Instructor_titleLabel.TabIndex = 37
        Instructor_titleLabel.Text = "Instructor Title:"
        '
        'Instructor_passLabel
        '
        Me.Instructor_passLabel.AutoSize = True
        Me.Instructor_passLabel.Location = New System.Drawing.Point(7, 104)
        Me.Instructor_passLabel.Name = "Instructor_passLabel"
        Me.Instructor_passLabel.Size = New System.Drawing.Size(114, 16)
        Me.Instructor_passLabel.TabIndex = 38
        Me.Instructor_passLabel.Text = "Instructor Password:"
        '
        'Student_passLabel
        '
        Me.Student_passLabel.AutoSize = True
        Me.Student_passLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Student_passLabel.Location = New System.Drawing.Point(332, 78)
        Me.Student_passLabel.Name = "Student_passLabel"
        Me.Student_passLabel.Size = New System.Drawing.Size(108, 16)
        Me.Student_passLabel.TabIndex = 35
        Me.Student_passLabel.Text = "Student Password:"
        '
        'topBarPanel
        '
        Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.topBarPanel.Controls.Add(Me.Label3)
        Me.topBarPanel.Controls.Add(Me.minimizeBtn)
        Me.topBarPanel.Controls.Add(Me.closeBtn)
        Me.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.topBarPanel.Name = "topBarPanel"
        Me.topBarPanel.Size = New System.Drawing.Size(842, 29)
        Me.topBarPanel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Admin Form"
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.Image = Global.PRS.My.Resources.Resources.minimizeAdminBtn
        Me.minimizeBtn.Location = New System.Drawing.Point(742, 0)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.Size = New System.Drawing.Size(50, 29)
        Me.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizeBtn.TabIndex = 3
        Me.minimizeBtn.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.PRS.My.Resources.Resources.closeAdminBtn
        Me.closeBtn.Location = New System.Drawing.Point(792, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 29)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.TabStop = False
        '
        'FileDataTableAdapter
        '
        Me.FileDataTableAdapter.ClearBeforeFill = True
        '
        'HeadDataTableAdapter
        '
        Me.HeadDataTableAdapter.ClearBeforeFill = True
        '
        'InstructorDataTableAdapter
        '
        Me.InstructorDataTableAdapter.ClearBeforeFill = True
        '
        'StudentDataTableAdapter
        '
        Me.StudentDataTableAdapter.ClearBeforeFill = True
        '
        'DNBTabControl
        '
        Me.DNBTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DNBTabControl.Controls.Add(Me.HomeTab)
        Me.DNBTabControl.Controls.Add(Me.StudentTab)
        Me.DNBTabControl.Controls.Add(Me.InstructorTab)
        Me.DNBTabControl.Controls.Add(Me.HeadTab)
        Me.DNBTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DNBTabControl.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.DNBTabControl.HotTrack = True
        Me.DNBTabControl.ItemSize = New System.Drawing.Size(44, 136)
        Me.DNBTabControl.Location = New System.Drawing.Point(0, 29)
        Me.DNBTabControl.Multiline = True
        Me.DNBTabControl.Name = "DNBTabControl"
        Me.DNBTabControl.SelectedIndex = 0
        Me.DNBTabControl.Size = New System.Drawing.Size(842, 438)
        Me.DNBTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DNBTabControl.TabIndex = 8
        '
        'HomeTab
        '
        Me.HomeTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.HomeTab.Controls.Add(Me.GroupBox1)
        Me.HomeTab.Controls.Add(Me.DatabaseGroup)
        Me.HomeTab.Location = New System.Drawing.Point(140, 4)
        Me.HomeTab.Name = "HomeTab"
        Me.HomeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HomeTab.Size = New System.Drawing.Size(698, 430)
        Me.HomeTab.TabIndex = 0
        Me.HomeTab.Text = "Home"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(396, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 106)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Monitor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "forwarded"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "discarded"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "delivered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "received"
        '
        'DatabaseGroup
        '
        Me.DatabaseGroup.Controls.Add(Me.SqlVersionLabel)
        Me.DatabaseGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DatabaseGroup.Location = New System.Drawing.Point(6, 6)
        Me.DatabaseGroup.Name = "DatabaseGroup"
        Me.DatabaseGroup.Size = New System.Drawing.Size(384, 106)
        Me.DatabaseGroup.TabIndex = 0
        Me.DatabaseGroup.TabStop = False
        Me.DatabaseGroup.Text = "MSSQL Server Version"
        '
        'SqlVersionLabel
        '
        Me.SqlVersionLabel.AutoSize = True
        Me.SqlVersionLabel.Location = New System.Drawing.Point(14, 27)
        Me.SqlVersionLabel.Name = "SqlVersionLabel"
        Me.SqlVersionLabel.Size = New System.Drawing.Size(73, 16)
        Me.SqlVersionLabel.TabIndex = 0
        Me.SqlVersionLabel.Text = "mssqlVersion"
        '
        'StudentTab
        '
        Me.StudentTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.StudentTab.Controls.Add(Me.StudentSubTabControl)
        Me.StudentTab.Location = New System.Drawing.Point(140, 4)
        Me.StudentTab.Name = "StudentTab"
        Me.StudentTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentTab.Size = New System.Drawing.Size(698, 430)
        Me.StudentTab.TabIndex = 1
        Me.StudentTab.Text = "Student"
        '
        'StudentSubTabControl
        '
        Me.StudentSubTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.StudentSubTabControl.Controls.Add(Me.StudentDataTab)
        Me.StudentSubTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentSubTabControl.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.StudentSubTabControl.ItemSize = New System.Drawing.Size(44, 136)
        Me.StudentSubTabControl.Location = New System.Drawing.Point(3, 3)
        Me.StudentSubTabControl.Multiline = True
        Me.StudentSubTabControl.Name = "StudentSubTabControl"
        Me.StudentSubTabControl.SelectedIndex = 0
        Me.StudentSubTabControl.Size = New System.Drawing.Size(692, 424)
        Me.StudentSubTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.StudentSubTabControl.TabIndex = 2
        '
        'StudentDataTab
        '
        Me.StudentDataTab.AutoScroll = True
        Me.StudentDataTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.StudentDataTab.Controls.Add(Me.StudentDataManager)
        Me.StudentDataTab.Controls.Add(Me.StudentView)
        Me.StudentDataTab.Location = New System.Drawing.Point(140, 4)
        Me.StudentDataTab.Name = "StudentDataTab"
        Me.StudentDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentDataTab.Size = New System.Drawing.Size(548, 416)
        Me.StudentDataTab.TabIndex = 0
        Me.StudentDataTab.Text = "Student Data"
        '
        'StudentDataManager
        '
        Me.StudentDataManager.Controls.Add(Me.Student_passLabel)
        Me.StudentDataManager.Controls.Add(Me.Student_passTextBox)
        Me.StudentDataManager.Controls.Add(Me.SqlStudentComboBox)
        Me.StudentDataManager.Controls.Add(Me.executeStudentBtn)
        Me.StudentDataManager.Controls.Add(Student_courseLabel)
        Me.StudentDataManager.Controls.Add(Me.Student_courseTextBox)
        Me.StudentDataManager.Controls.Add(Student_levelLabel)
        Me.StudentDataManager.Controls.Add(Me.Student_levelTextBox)
        Me.StudentDataManager.Controls.Add(Student_nameLabel)
        Me.StudentDataManager.Controls.Add(Me.Student_nameTextBox)
        Me.StudentDataManager.Controls.Add(Student_idLabel)
        Me.StudentDataManager.Controls.Add(Me.Student_idTextBox)
        Me.StudentDataManager.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.StudentDataManager.Location = New System.Drawing.Point(3, 271)
        Me.StudentDataManager.Name = "StudentDataManager"
        Me.StudentDataManager.Size = New System.Drawing.Size(542, 142)
        Me.StudentDataManager.TabIndex = 2
        Me.StudentDataManager.TabStop = False
        Me.StudentDataManager.Text = "Student Data Manager"
        '
        'Student_passTextBox
        '
        Me.Student_passTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_pass", True))
        Me.Student_passTextBox.Location = New System.Drawing.Point(335, 97)
        Me.Student_passTextBox.Name = "Student_passTextBox"
        Me.Student_passTextBox.Size = New System.Drawing.Size(155, 21)
        Me.Student_passTextBox.TabIndex = 36
        '
        'StudentDataBindingSource
        '
        Me.StudentDataBindingSource.DataMember = "StudentData"
        Me.StudentDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'RepoDBDataSet
        '
        Me.RepoDBDataSet.DataSetName = "repoDBDataSet"
        Me.RepoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlStudentComboBox
        '
        Me.SqlStudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlStudentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SqlStudentComboBox.FormattingEnabled = True
        Me.SqlStudentComboBox.Items.AddRange(New Object() {"SHOW ALL DATA", "SELECT (By ID)", "INSERT", "UPDATE", "DELETE (By ID)"})
        Me.SqlStudentComboBox.Location = New System.Drawing.Point(335, 19)
        Me.SqlStudentComboBox.Name = "SqlStudentComboBox"
        Me.SqlStudentComboBox.Size = New System.Drawing.Size(155, 24)
        Me.SqlStudentComboBox.TabIndex = 35
        '
        'executeStudentBtn
        '
        Me.executeStudentBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeStudentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.executeStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.executeStudentBtn.FlatAppearance.BorderSize = 0
        Me.executeStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.executeStudentBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.executeStudentBtn.ForeColor = System.Drawing.Color.White
        Me.executeStudentBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeStudentBtn.Location = New System.Drawing.Point(335, 46)
        Me.executeStudentBtn.Name = "executeStudentBtn"
        Me.executeStudentBtn.Size = New System.Drawing.Size(155, 20)
        Me.executeStudentBtn.TabIndex = 34
        Me.executeStudentBtn.Text = "Execute Query"
        Me.executeStudentBtn.UseVisualStyleBackColor = True
        '
        'Student_courseTextBox
        '
        Me.Student_courseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_course", True))
        Me.Student_courseTextBox.Location = New System.Drawing.Point(111, 97)
        Me.Student_courseTextBox.Name = "Student_courseTextBox"
        Me.Student_courseTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_courseTextBox.TabIndex = 7
        '
        'Student_levelTextBox
        '
        Me.Student_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_level", True))
        Me.Student_levelTextBox.Location = New System.Drawing.Point(111, 71)
        Me.Student_levelTextBox.Name = "Student_levelTextBox"
        Me.Student_levelTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_levelTextBox.TabIndex = 5
        '
        'Student_nameTextBox
        '
        Me.Student_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_name", True))
        Me.Student_nameTextBox.Location = New System.Drawing.Point(111, 45)
        Me.Student_nameTextBox.Name = "Student_nameTextBox"
        Me.Student_nameTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_nameTextBox.TabIndex = 3
        '
        'Student_idTextBox
        '
        Me.Student_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_id", True))
        Me.Student_idTextBox.Location = New System.Drawing.Point(111, 19)
        Me.Student_idTextBox.Name = "Student_idTextBox"
        Me.Student_idTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_idTextBox.TabIndex = 1
        '
        'StudentView
        '
        Me.StudentView.BackColor = System.Drawing.Color.Silver
        Me.StudentView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StudentIDHeader, Me.StudentNameHeader, Me.StudentLevelHeader, Me.StudentCourseHeader})
        Me.StudentView.Dock = System.Windows.Forms.DockStyle.Top
        Me.StudentView.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.StudentView.ForeColor = System.Drawing.Color.Black
        Me.StudentView.FullRowSelect = True
        Me.StudentView.GridLines = True
        Me.StudentView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.StudentView.Location = New System.Drawing.Point(3, 3)
        Me.StudentView.Name = "StudentView"
        Me.StudentView.Size = New System.Drawing.Size(542, 262)
        Me.StudentView.TabIndex = 1
        Me.StudentView.UseCompatibleStateImageBehavior = False
        Me.StudentView.View = System.Windows.Forms.View.Details
        '
        'StudentIDHeader
        '
        Me.StudentIDHeader.Text = "Student ID"
        Me.StudentIDHeader.Width = 137
        '
        'StudentNameHeader
        '
        Me.StudentNameHeader.Text = "Student Name"
        Me.StudentNameHeader.Width = 275
        '
        'StudentLevelHeader
        '
        Me.StudentLevelHeader.Text = "Year"
        Me.StudentLevelHeader.Width = 47
        '
        'StudentCourseHeader
        '
        Me.StudentCourseHeader.Text = "Course"
        Me.StudentCourseHeader.Width = 83
        '
        'InstructorTab
        '
        Me.InstructorTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.InstructorTab.Controls.Add(Me.InstructorSubTabControl)
        Me.InstructorTab.Location = New System.Drawing.Point(140, 4)
        Me.InstructorTab.Name = "InstructorTab"
        Me.InstructorTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InstructorTab.Size = New System.Drawing.Size(698, 430)
        Me.InstructorTab.TabIndex = 2
        Me.InstructorTab.Text = "Instructor"
        '
        'InstructorSubTabControl
        '
        Me.InstructorSubTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.InstructorSubTabControl.Controls.Add(Me.InstructorDataTab)
        Me.InstructorSubTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InstructorSubTabControl.ItemSize = New System.Drawing.Size(44, 136)
        Me.InstructorSubTabControl.Location = New System.Drawing.Point(3, 3)
        Me.InstructorSubTabControl.Multiline = True
        Me.InstructorSubTabControl.Name = "InstructorSubTabControl"
        Me.InstructorSubTabControl.SelectedIndex = 0
        Me.InstructorSubTabControl.Size = New System.Drawing.Size(692, 424)
        Me.InstructorSubTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.InstructorSubTabControl.TabIndex = 0
        '
        'InstructorDataTab
        '
        Me.InstructorDataTab.AutoScroll = True
        Me.InstructorDataTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.InstructorDataTab.Controls.Add(Me.GroupBox2)
        Me.InstructorDataTab.Controls.Add(Me.InstructorView)
        Me.InstructorDataTab.Location = New System.Drawing.Point(140, 4)
        Me.InstructorDataTab.Name = "InstructorDataTab"
        Me.InstructorDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InstructorDataTab.Size = New System.Drawing.Size(548, 416)
        Me.InstructorDataTab.TabIndex = 0
        Me.InstructorDataTab.Text = "Instructor Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Instructor_passLabel)
        Me.GroupBox2.Controls.Add(Me.Instructor_passTextBox)
        Me.GroupBox2.Controls.Add(Instructor_titleLabel)
        Me.GroupBox2.Controls.Add(Me.Instructor_titleTextBox)
        Me.GroupBox2.Controls.Add(Instructor_userLabel)
        Me.GroupBox2.Controls.Add(Me.Instructor_userTextBox)
        Me.GroupBox2.Controls.Add(Instructor_idLabel)
        Me.GroupBox2.Controls.Add(Me.Instructor_idTextBox)
        Me.GroupBox2.Controls.Add(Me.SqlInstructorComboBox)
        Me.GroupBox2.Controls.Add(Me.executeInstructorBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 142)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Data Manager"
        '
        'Instructor_passTextBox
        '
        Me.Instructor_passTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_pass", True))
        Me.Instructor_passTextBox.Location = New System.Drawing.Point(127, 101)
        Me.Instructor_passTextBox.Name = "Instructor_passTextBox"
        Me.Instructor_passTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_passTextBox.TabIndex = 39
        '
        'InstructorDataBindingSource
        '
        Me.InstructorDataBindingSource.DataMember = "InstructorData"
        Me.InstructorDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'Instructor_titleTextBox
        '
        Me.Instructor_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_title", True))
        Me.Instructor_titleTextBox.Location = New System.Drawing.Point(127, 74)
        Me.Instructor_titleTextBox.Name = "Instructor_titleTextBox"
        Me.Instructor_titleTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_titleTextBox.TabIndex = 38
        '
        'Instructor_userTextBox
        '
        Me.Instructor_userTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_user", True))
        Me.Instructor_userTextBox.Location = New System.Drawing.Point(127, 47)
        Me.Instructor_userTextBox.Name = "Instructor_userTextBox"
        Me.Instructor_userTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_userTextBox.TabIndex = 37
        '
        'Instructor_idTextBox
        '
        Me.Instructor_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_id", True))
        Me.Instructor_idTextBox.Location = New System.Drawing.Point(127, 22)
        Me.Instructor_idTextBox.Name = "Instructor_idTextBox"
        Me.Instructor_idTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_idTextBox.TabIndex = 36
        '
        'SqlInstructorComboBox
        '
        Me.SqlInstructorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlInstructorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SqlInstructorComboBox.FormattingEnabled = True
        Me.SqlInstructorComboBox.Items.AddRange(New Object() {"SHOW ALL DATA", "SELECT (By ID)", "INSERT", "UPDATE", "DELETE (By ID)"})
        Me.SqlInstructorComboBox.Location = New System.Drawing.Point(335, 19)
        Me.SqlInstructorComboBox.Name = "SqlInstructorComboBox"
        Me.SqlInstructorComboBox.Size = New System.Drawing.Size(155, 24)
        Me.SqlInstructorComboBox.TabIndex = 35
        '
        'executeInstructorBtn
        '
        Me.executeInstructorBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeInstructorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.executeInstructorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.executeInstructorBtn.FlatAppearance.BorderSize = 0
        Me.executeInstructorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.executeInstructorBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.executeInstructorBtn.ForeColor = System.Drawing.Color.White
        Me.executeInstructorBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeInstructorBtn.Location = New System.Drawing.Point(335, 46)
        Me.executeInstructorBtn.Name = "executeInstructorBtn"
        Me.executeInstructorBtn.Size = New System.Drawing.Size(155, 20)
        Me.executeInstructorBtn.TabIndex = 34
        Me.executeInstructorBtn.Text = "Execute Query"
        Me.executeInstructorBtn.UseVisualStyleBackColor = True
        '
        'InstructorView
        '
        Me.InstructorView.BackColor = System.Drawing.Color.Silver
        Me.InstructorView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InstructorView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.InstructorIDHeader, Me.InstructorNameHeader, Me.InstructorTitleHeader})
        Me.InstructorView.Dock = System.Windows.Forms.DockStyle.Top
        Me.InstructorView.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.InstructorView.ForeColor = System.Drawing.Color.Black
        Me.InstructorView.FullRowSelect = True
        Me.InstructorView.GridLines = True
        Me.InstructorView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.InstructorView.Location = New System.Drawing.Point(3, 3)
        Me.InstructorView.Name = "InstructorView"
        Me.InstructorView.Size = New System.Drawing.Size(542, 262)
        Me.InstructorView.TabIndex = 2
        Me.InstructorView.UseCompatibleStateImageBehavior = False
        Me.InstructorView.View = System.Windows.Forms.View.Details
        '
        'InstructorIDHeader
        '
        Me.InstructorIDHeader.Text = "Instructor ID"
        Me.InstructorIDHeader.Width = 137
        '
        'InstructorNameHeader
        '
        Me.InstructorNameHeader.Text = "Instructor Name"
        Me.InstructorNameHeader.Width = 275
        '
        'InstructorTitleHeader
        '
        Me.InstructorTitleHeader.Text = "Instructor Title"
        Me.InstructorTitleHeader.Width = 129
        '
        'HeadTab
        '
        Me.HeadTab.BackColor = System.Drawing.Color.White
        Me.HeadTab.Location = New System.Drawing.Point(140, 4)
        Me.HeadTab.Name = "HeadTab"
        Me.HeadTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HeadTab.Size = New System.Drawing.Size(698, 430)
        Me.HeadTab.TabIndex = 3
        Me.HeadTab.Text = "Head of Department"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.FileDataTableAdapter = Nothing
        Me.TableAdapterManager.HeadDataTableAdapter = Nothing
        Me.TableAdapterManager.InstructorDataTableAdapter = Nothing
        Me.TableAdapterManager.StudentDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRS.repoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 467)
        Me.Controls.Add(Me.DNBTabControl)
        Me.Controls.Add(Me.topBarPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.topBarPanel.ResumeLayout(False)
        Me.topBarPanel.PerformLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DNBTabControl.ResumeLayout(False)
        Me.HomeTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DatabaseGroup.ResumeLayout(False)
        Me.DatabaseGroup.PerformLayout()
        Me.StudentTab.ResumeLayout(False)
        Me.StudentSubTabControl.ResumeLayout(False)
        Me.StudentDataTab.ResumeLayout(False)
        Me.StudentDataManager.ResumeLayout(False)
        Me.StudentDataManager.PerformLayout()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InstructorTab.ResumeLayout(False)
        Me.InstructorSubTabControl.ResumeLayout(False)
        Me.InstructorDataTab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.InstructorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topBarPanel As Panel
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DNBTabControl As DotNetBarTabcontrol
    Friend WithEvents HomeTab As TabPage
    Friend WithEvents StudentTab As TabPage
    Friend WithEvents InstructorTab As TabPage
    Friend WithEvents HeadTab As TabPage
    Friend WithEvents TableAdapterManager As repoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileDataTableAdapter As repoDBDataSetTableAdapters.FileDataTableAdapter
    Friend WithEvents HeadDataTableAdapter As repoDBDataSetTableAdapters.HeadDataTableAdapter
    Friend WithEvents InstructorDataTableAdapter As repoDBDataSetTableAdapters.InstructorDataTableAdapter
    Friend WithEvents StudentDataTableAdapter As repoDBDataSetTableAdapters.StudentDataTableAdapter
    Friend WithEvents StudentView As ListView
    Friend WithEvents StudentIDHeader As ColumnHeader
    Friend WithEvents StudentNameHeader As ColumnHeader
    Friend WithEvents StudentLevelHeader As ColumnHeader
    Friend WithEvents StudentCourseHeader As ColumnHeader
    Friend WithEvents RepoDBDataSet As repoDBDataSet
    Friend WithEvents StudentDataBindingSource As BindingSource
    Friend WithEvents StudentDataBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StudentSubTabControl As DotNetBarTabcontrol
    Friend WithEvents StudentDataTab As TabPage
    Friend WithEvents StudentDataManager As GroupBox
    Friend WithEvents Student_idTextBox As TextBox
    Friend WithEvents Student_nameTextBox As TextBox
    Friend WithEvents Student_levelTextBox As TextBox
    Friend WithEvents Student_courseTextBox As TextBox
    Friend WithEvents SqlStudentComboBox As ComboBox
    Friend WithEvents executeStudentBtn As Button
    Friend WithEvents Student_passTextBox As TextBox
    Friend WithEvents Student_passLabel As Label
    Friend WithEvents DatabaseGroup As GroupBox
    Friend WithEvents SqlVersionLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents InstructorSubTabControl As DotNetBarTabcontrol
    Friend WithEvents InstructorDataTab As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Instructor_passTextBox As TextBox
    Friend WithEvents InstructorDataBindingSource As BindingSource
    Friend WithEvents Instructor_titleTextBox As TextBox
    Friend WithEvents Instructor_userTextBox As TextBox
    Friend WithEvents Instructor_idTextBox As TextBox
    Friend WithEvents SqlInstructorComboBox As ComboBox
    Friend WithEvents executeInstructorBtn As Button
    Friend WithEvents InstructorView As ListView
    Friend WithEvents InstructorIDHeader As ColumnHeader
    Friend WithEvents InstructorNameHeader As ColumnHeader
    Friend WithEvents InstructorTitleHeader As ColumnHeader
    Friend WithEvents Instructor_passLabel As Label
End Class
