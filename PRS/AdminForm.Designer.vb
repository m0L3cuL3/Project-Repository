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
        Dim Student_courseLabel As System.Windows.Forms.Label
        Dim Student_levelLabel As System.Windows.Forms.Label
        Dim Student_nameLabel As System.Windows.Forms.Label
        Dim Student_idLabel As System.Windows.Forms.Label
        Dim Instructor_titleLabel As System.Windows.Forms.Label
        Dim Instructor_userLabel As System.Windows.Forms.Label
        Dim Instructor_idLabel As System.Windows.Forms.Label
        Dim Head_titleLabel As System.Windows.Forms.Label
        Dim Head_nameLabel As System.Windows.Forms.Label
        Dim Head_idLabel As System.Windows.Forms.Label
        Dim File_uploader_nameLabel As System.Windows.Forms.Label
        Dim File_uploaderLabel As System.Windows.Forms.Label
        Dim IsApprovedLabel As System.Windows.Forms.Label
        Dim File_nameLabel As System.Windows.Forms.Label
        Dim File_idLabel As System.Windows.Forms.Label
        Me.topBarPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.FileDataTableAdapter = New PRS.repoDBDataSetTableAdapters.FileDataTableAdapter()
        Me.HeadDataTableAdapter = New PRS.repoDBDataSetTableAdapters.HeadDataTableAdapter()
        Me.InstructorDataTableAdapter = New PRS.repoDBDataSetTableAdapters.InstructorDataTableAdapter()
        Me.StudentDataTableAdapter = New PRS.repoDBDataSetTableAdapters.StudentDataTableAdapter()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoDBDataSet = New PRS.repoDBDataSet()
        Me.InstructorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PRS.repoDBDataSetTableAdapters.TableAdapterManager()
        Me.NetworkTimer = New System.Windows.Forms.Timer(Me.components)
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
        Me.Student_passLabel = New System.Windows.Forms.Label()
        Me.Student_passTextBox = New System.Windows.Forms.TextBox()
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
        Me.InstructorDataManager = New System.Windows.Forms.GroupBox()
        Me.Instructor_passLabel = New System.Windows.Forms.Label()
        Me.Instructor_passTextBox = New System.Windows.Forms.TextBox()
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
        Me.HeadSubTabControl = New PRS.DotNetBarTabcontrol()
        Me.HeadDataTab = New System.Windows.Forms.TabPage()
        Me.HeadDataManager = New System.Windows.Forms.GroupBox()
        Me.Head_titleTextBox = New System.Windows.Forms.TextBox()
        Me.Head_passLabel = New System.Windows.Forms.Label()
        Me.Head_passTextBox = New System.Windows.Forms.TextBox()
        Me.Head_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Head_idTextBox = New System.Windows.Forms.TextBox()
        Me.SqlHeadComboBox = New System.Windows.Forms.ComboBox()
        Me.executeHeadBtn = New System.Windows.Forms.Button()
        Me.HeadView = New System.Windows.Forms.ListView()
        Me.HeadIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeadNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeadTitleHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileTab = New System.Windows.Forms.TabPage()
        Me.FileDataManager = New System.Windows.Forms.GroupBox()
        Me.File_uploader_nameTextBox = New System.Windows.Forms.TextBox()
        Me.File_uploaderTextBox = New System.Windows.Forms.TextBox()
        Me.IsApprovedTextBox = New System.Windows.Forms.TextBox()
        Me.File_nameTextBox = New System.Windows.Forms.TextBox()
        Me.File_idTextBox = New System.Windows.Forms.TextBox()
        Me.SqlFileComboBox = New System.Windows.Forms.ComboBox()
        Me.executeFileBtn = New System.Windows.Forms.Button()
        Me.FileView = New System.Windows.Forms.ListView()
        Me.FileIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileStatusHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Student_courseLabel = New System.Windows.Forms.Label()
        Student_levelLabel = New System.Windows.Forms.Label()
        Student_nameLabel = New System.Windows.Forms.Label()
        Student_idLabel = New System.Windows.Forms.Label()
        Instructor_titleLabel = New System.Windows.Forms.Label()
        Instructor_userLabel = New System.Windows.Forms.Label()
        Instructor_idLabel = New System.Windows.Forms.Label()
        Head_titleLabel = New System.Windows.Forms.Label()
        Head_nameLabel = New System.Windows.Forms.Label()
        Head_idLabel = New System.Windows.Forms.Label()
        File_uploader_nameLabel = New System.Windows.Forms.Label()
        File_uploaderLabel = New System.Windows.Forms.Label()
        IsApprovedLabel = New System.Windows.Forms.Label()
        File_nameLabel = New System.Windows.Forms.Label()
        File_idLabel = New System.Windows.Forms.Label()
        Me.topBarPanel.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DNBTabControl.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DatabaseGroup.SuspendLayout()
        Me.StudentTab.SuspendLayout()
        Me.StudentSubTabControl.SuspendLayout()
        Me.StudentDataTab.SuspendLayout()
        Me.StudentDataManager.SuspendLayout()
        Me.InstructorTab.SuspendLayout()
        Me.InstructorSubTabControl.SuspendLayout()
        Me.InstructorDataTab.SuspendLayout()
        Me.InstructorDataManager.SuspendLayout()
        Me.HeadTab.SuspendLayout()
        Me.HeadSubTabControl.SuspendLayout()
        Me.HeadDataTab.SuspendLayout()
        Me.HeadDataManager.SuspendLayout()
        Me.FileTab.SuspendLayout()
        Me.FileDataManager.SuspendLayout()
        Me.SuspendLayout()
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
        Me.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        'InstructorDataBindingSource
        '
        Me.InstructorDataBindingSource.DataMember = "InstructorData"
        Me.InstructorDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'HeadDataBindingSource
        '
        Me.HeadDataBindingSource.DataMember = "HeadData"
        Me.HeadDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'FileDataBindingSource
        '
        Me.FileDataBindingSource.DataMember = "FileData"
        Me.FileDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminDataTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.FileDataTableAdapter = Nothing
        Me.TableAdapterManager.HeadDataTableAdapter = Nothing
        Me.TableAdapterManager.InstructorDataTableAdapter = Nothing
        Me.TableAdapterManager.StudentDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRS.repoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NetworkTimer
        '
        Me.NetworkTimer.Enabled = True
        Me.NetworkTimer.Interval = 5
        '
        'DNBTabControl
        '
        Me.DNBTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DNBTabControl.Controls.Add(Me.HomeTab)
        Me.DNBTabControl.Controls.Add(Me.StudentTab)
        Me.DNBTabControl.Controls.Add(Me.InstructorTab)
        Me.DNBTabControl.Controls.Add(Me.HeadTab)
        Me.DNBTabControl.Controls.Add(Me.FileTab)
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
        'Student_passTextBox
        '
        Me.Student_passTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_pass", True))
        Me.Student_passTextBox.Location = New System.Drawing.Point(335, 97)
        Me.Student_passTextBox.Name = "Student_passTextBox"
        Me.Student_passTextBox.Size = New System.Drawing.Size(155, 21)
        Me.Student_passTextBox.TabIndex = 36
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
        'Student_courseTextBox
        '
        Me.Student_courseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_course", True))
        Me.Student_courseTextBox.Location = New System.Drawing.Point(111, 97)
        Me.Student_courseTextBox.Name = "Student_courseTextBox"
        Me.Student_courseTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_courseTextBox.TabIndex = 7
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
        'Student_levelTextBox
        '
        Me.Student_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_level", True))
        Me.Student_levelTextBox.Location = New System.Drawing.Point(111, 71)
        Me.Student_levelTextBox.Name = "Student_levelTextBox"
        Me.Student_levelTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_levelTextBox.TabIndex = 5
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
        'Student_nameTextBox
        '
        Me.Student_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentDataBindingSource, "student_name", True))
        Me.Student_nameTextBox.Location = New System.Drawing.Point(111, 45)
        Me.Student_nameTextBox.Name = "Student_nameTextBox"
        Me.Student_nameTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Student_nameTextBox.TabIndex = 3
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
        Me.InstructorDataTab.Controls.Add(Me.InstructorDataManager)
        Me.InstructorDataTab.Controls.Add(Me.InstructorView)
        Me.InstructorDataTab.Location = New System.Drawing.Point(140, 4)
        Me.InstructorDataTab.Name = "InstructorDataTab"
        Me.InstructorDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InstructorDataTab.Size = New System.Drawing.Size(548, 416)
        Me.InstructorDataTab.TabIndex = 0
        Me.InstructorDataTab.Text = "Instructor Data"
        '
        'InstructorDataManager
        '
        Me.InstructorDataManager.Controls.Add(Me.Instructor_passLabel)
        Me.InstructorDataManager.Controls.Add(Me.Instructor_passTextBox)
        Me.InstructorDataManager.Controls.Add(Instructor_titleLabel)
        Me.InstructorDataManager.Controls.Add(Me.Instructor_titleTextBox)
        Me.InstructorDataManager.Controls.Add(Instructor_userLabel)
        Me.InstructorDataManager.Controls.Add(Me.Instructor_userTextBox)
        Me.InstructorDataManager.Controls.Add(Instructor_idLabel)
        Me.InstructorDataManager.Controls.Add(Me.Instructor_idTextBox)
        Me.InstructorDataManager.Controls.Add(Me.SqlInstructorComboBox)
        Me.InstructorDataManager.Controls.Add(Me.executeInstructorBtn)
        Me.InstructorDataManager.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.InstructorDataManager.Location = New System.Drawing.Point(3, 271)
        Me.InstructorDataManager.Name = "InstructorDataManager"
        Me.InstructorDataManager.Size = New System.Drawing.Size(542, 142)
        Me.InstructorDataManager.TabIndex = 3
        Me.InstructorDataManager.TabStop = False
        Me.InstructorDataManager.Text = "Instructor Data Manager"
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
        'Instructor_passTextBox
        '
        Me.Instructor_passTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_pass", True))
        Me.Instructor_passTextBox.Location = New System.Drawing.Point(127, 101)
        Me.Instructor_passTextBox.Name = "Instructor_passTextBox"
        Me.Instructor_passTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_passTextBox.TabIndex = 39
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
        'Instructor_titleTextBox
        '
        Me.Instructor_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_title", True))
        Me.Instructor_titleTextBox.Location = New System.Drawing.Point(127, 74)
        Me.Instructor_titleTextBox.Name = "Instructor_titleTextBox"
        Me.Instructor_titleTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_titleTextBox.TabIndex = 38
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
        'Instructor_userTextBox
        '
        Me.Instructor_userTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorDataBindingSource, "instructor_user", True))
        Me.Instructor_userTextBox.Location = New System.Drawing.Point(127, 47)
        Me.Instructor_userTextBox.Name = "Instructor_userTextBox"
        Me.Instructor_userTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Instructor_userTextBox.TabIndex = 37
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
        Me.HeadTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.HeadTab.Controls.Add(Me.HeadSubTabControl)
        Me.HeadTab.Location = New System.Drawing.Point(140, 4)
        Me.HeadTab.Name = "HeadTab"
        Me.HeadTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HeadTab.Size = New System.Drawing.Size(698, 430)
        Me.HeadTab.TabIndex = 3
        Me.HeadTab.Text = "Head of Department"
        '
        'HeadSubTabControl
        '
        Me.HeadSubTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.HeadSubTabControl.Controls.Add(Me.HeadDataTab)
        Me.HeadSubTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeadSubTabControl.ItemSize = New System.Drawing.Size(44, 136)
        Me.HeadSubTabControl.Location = New System.Drawing.Point(3, 3)
        Me.HeadSubTabControl.Multiline = True
        Me.HeadSubTabControl.Name = "HeadSubTabControl"
        Me.HeadSubTabControl.SelectedIndex = 0
        Me.HeadSubTabControl.Size = New System.Drawing.Size(692, 424)
        Me.HeadSubTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.HeadSubTabControl.TabIndex = 0
        '
        'HeadDataTab
        '
        Me.HeadDataTab.AutoScroll = True
        Me.HeadDataTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.HeadDataTab.Controls.Add(Me.HeadDataManager)
        Me.HeadDataTab.Controls.Add(Me.HeadView)
        Me.HeadDataTab.Location = New System.Drawing.Point(140, 4)
        Me.HeadDataTab.Name = "HeadDataTab"
        Me.HeadDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HeadDataTab.Size = New System.Drawing.Size(548, 416)
        Me.HeadDataTab.TabIndex = 0
        Me.HeadDataTab.Text = "HoD Data"
        '
        'HeadDataManager
        '
        Me.HeadDataManager.Controls.Add(Head_titleLabel)
        Me.HeadDataManager.Controls.Add(Me.Head_titleTextBox)
        Me.HeadDataManager.Controls.Add(Me.Head_passLabel)
        Me.HeadDataManager.Controls.Add(Me.Head_passTextBox)
        Me.HeadDataManager.Controls.Add(Head_nameLabel)
        Me.HeadDataManager.Controls.Add(Me.Head_nameTextBox)
        Me.HeadDataManager.Controls.Add(Head_idLabel)
        Me.HeadDataManager.Controls.Add(Me.Head_idTextBox)
        Me.HeadDataManager.Controls.Add(Me.SqlHeadComboBox)
        Me.HeadDataManager.Controls.Add(Me.executeHeadBtn)
        Me.HeadDataManager.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.HeadDataManager.Location = New System.Drawing.Point(3, 271)
        Me.HeadDataManager.Name = "HeadDataManager"
        Me.HeadDataManager.Size = New System.Drawing.Size(542, 142)
        Me.HeadDataManager.TabIndex = 4
        Me.HeadDataManager.TabStop = False
        Me.HeadDataManager.Text = "Head of Department Data Manager"
        '
        'Head_titleLabel
        '
        Head_titleLabel.AutoSize = True
        Head_titleLabel.Location = New System.Drawing.Point(6, 75)
        Head_titleLabel.Name = "Head_titleLabel"
        Head_titleLabel.Size = New System.Drawing.Size(65, 16)
        Head_titleLabel.TabIndex = 38
        Head_titleLabel.Text = "Head Title:"
        '
        'Head_titleTextBox
        '
        Me.Head_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadDataBindingSource, "head_title", True))
        Me.Head_titleTextBox.Location = New System.Drawing.Point(108, 72)
        Me.Head_titleTextBox.Name = "Head_titleTextBox"
        Me.Head_titleTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Head_titleTextBox.TabIndex = 38
        '
        'Head_passLabel
        '
        Me.Head_passLabel.AutoSize = True
        Me.Head_passLabel.Location = New System.Drawing.Point(6, 102)
        Me.Head_passLabel.Name = "Head_passLabel"
        Me.Head_passLabel.Size = New System.Drawing.Size(96, 16)
        Me.Head_passLabel.TabIndex = 37
        Me.Head_passLabel.Text = "Head Password:"
        '
        'Head_passTextBox
        '
        Me.Head_passTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadDataBindingSource, "head_pass", True))
        Me.Head_passTextBox.Location = New System.Drawing.Point(108, 99)
        Me.Head_passTextBox.Name = "Head_passTextBox"
        Me.Head_passTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Head_passTextBox.TabIndex = 39
        '
        'Head_nameLabel
        '
        Head_nameLabel.AutoSize = True
        Head_nameLabel.Location = New System.Drawing.Point(6, 48)
        Head_nameLabel.Name = "Head_nameLabel"
        Head_nameLabel.Size = New System.Drawing.Size(78, 16)
        Head_nameLabel.TabIndex = 36
        Head_nameLabel.Text = "Head Name:"
        '
        'Head_nameTextBox
        '
        Me.Head_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadDataBindingSource, "head_name", True))
        Me.Head_nameTextBox.Location = New System.Drawing.Point(108, 45)
        Me.Head_nameTextBox.Name = "Head_nameTextBox"
        Me.Head_nameTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Head_nameTextBox.TabIndex = 37
        '
        'Head_idLabel
        '
        Head_idLabel.AutoSize = True
        Head_idLabel.Location = New System.Drawing.Point(6, 22)
        Head_idLabel.Name = "Head_idLabel"
        Head_idLabel.Size = New System.Drawing.Size(56, 16)
        Head_idLabel.TabIndex = 35
        Head_idLabel.Text = "Head ID:"
        '
        'Head_idTextBox
        '
        Me.Head_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HeadDataBindingSource, "head_id", True))
        Me.Head_idTextBox.Location = New System.Drawing.Point(108, 19)
        Me.Head_idTextBox.Name = "Head_idTextBox"
        Me.Head_idTextBox.Size = New System.Drawing.Size(181, 21)
        Me.Head_idTextBox.TabIndex = 36
        '
        'SqlHeadComboBox
        '
        Me.SqlHeadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlHeadComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SqlHeadComboBox.FormattingEnabled = True
        Me.SqlHeadComboBox.Items.AddRange(New Object() {"SHOW ALL DATA", "SELECT (By ID)", "INSERT", "UPDATE", "DELETE (By ID)"})
        Me.SqlHeadComboBox.Location = New System.Drawing.Point(335, 19)
        Me.SqlHeadComboBox.Name = "SqlHeadComboBox"
        Me.SqlHeadComboBox.Size = New System.Drawing.Size(155, 24)
        Me.SqlHeadComboBox.TabIndex = 35
        '
        'executeHeadBtn
        '
        Me.executeHeadBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeHeadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.executeHeadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.executeHeadBtn.FlatAppearance.BorderSize = 0
        Me.executeHeadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.executeHeadBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.executeHeadBtn.ForeColor = System.Drawing.Color.White
        Me.executeHeadBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeHeadBtn.Location = New System.Drawing.Point(335, 46)
        Me.executeHeadBtn.Name = "executeHeadBtn"
        Me.executeHeadBtn.Size = New System.Drawing.Size(155, 20)
        Me.executeHeadBtn.TabIndex = 34
        Me.executeHeadBtn.Text = "Execute Query"
        Me.executeHeadBtn.UseVisualStyleBackColor = True
        '
        'HeadView
        '
        Me.HeadView.BackColor = System.Drawing.Color.Silver
        Me.HeadView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HeadView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HeadIDHeader, Me.HeadNameHeader, Me.HeadTitleHeader})
        Me.HeadView.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeadView.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.HeadView.ForeColor = System.Drawing.Color.Black
        Me.HeadView.FullRowSelect = True
        Me.HeadView.GridLines = True
        Me.HeadView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HeadView.Location = New System.Drawing.Point(3, 3)
        Me.HeadView.Name = "HeadView"
        Me.HeadView.Size = New System.Drawing.Size(542, 262)
        Me.HeadView.TabIndex = 3
        Me.HeadView.UseCompatibleStateImageBehavior = False
        Me.HeadView.View = System.Windows.Forms.View.Details
        '
        'HeadIDHeader
        '
        Me.HeadIDHeader.Text = "Head of Department ID"
        Me.HeadIDHeader.Width = 142
        '
        'HeadNameHeader
        '
        Me.HeadNameHeader.Text = "Head of Department Name"
        Me.HeadNameHeader.Width = 248
        '
        'HeadTitleHeader
        '
        Me.HeadTitleHeader.Text = "Head of Department Title"
        Me.HeadTitleHeader.Width = 152
        '
        'FileTab
        '
        Me.FileTab.AutoScroll = True
        Me.FileTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FileTab.Controls.Add(Me.FileDataManager)
        Me.FileTab.Controls.Add(Me.FileView)
        Me.FileTab.Location = New System.Drawing.Point(140, 4)
        Me.FileTab.Name = "FileTab"
        Me.FileTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FileTab.Size = New System.Drawing.Size(698, 430)
        Me.FileTab.TabIndex = 4
        Me.FileTab.Text = "User Files"
        '
        'FileDataManager
        '
        Me.FileDataManager.Controls.Add(File_uploader_nameLabel)
        Me.FileDataManager.Controls.Add(Me.File_uploader_nameTextBox)
        Me.FileDataManager.Controls.Add(File_uploaderLabel)
        Me.FileDataManager.Controls.Add(Me.File_uploaderTextBox)
        Me.FileDataManager.Controls.Add(IsApprovedLabel)
        Me.FileDataManager.Controls.Add(Me.IsApprovedTextBox)
        Me.FileDataManager.Controls.Add(File_nameLabel)
        Me.FileDataManager.Controls.Add(Me.File_nameTextBox)
        Me.FileDataManager.Controls.Add(File_idLabel)
        Me.FileDataManager.Controls.Add(Me.File_idTextBox)
        Me.FileDataManager.Controls.Add(Me.SqlFileComboBox)
        Me.FileDataManager.Controls.Add(Me.executeFileBtn)
        Me.FileDataManager.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.FileDataManager.Location = New System.Drawing.Point(6, 271)
        Me.FileDataManager.Name = "FileDataManager"
        Me.FileDataManager.Size = New System.Drawing.Size(686, 151)
        Me.FileDataManager.TabIndex = 6
        Me.FileDataManager.TabStop = False
        Me.FileDataManager.Text = "File Data Manager"
        '
        'File_uploader_nameLabel
        '
        File_uploader_nameLabel.AutoSize = True
        File_uploader_nameLabel.Location = New System.Drawing.Point(6, 129)
        File_uploader_nameLabel.Name = "File_uploader_nameLabel"
        File_uploader_nameLabel.Size = New System.Drawing.Size(65, 16)
        File_uploader_nameLabel.TabIndex = 39
        File_uploader_nameLabel.Text = "Username:"
        '
        'File_uploader_nameTextBox
        '
        Me.File_uploader_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileDataBindingSource, "file_uploader_name", True))
        Me.File_uploader_nameTextBox.Location = New System.Drawing.Point(107, 126)
        Me.File_uploader_nameTextBox.Name = "File_uploader_nameTextBox"
        Me.File_uploader_nameTextBox.Size = New System.Drawing.Size(175, 21)
        Me.File_uploader_nameTextBox.TabIndex = 40
        '
        'File_uploaderLabel
        '
        File_uploaderLabel.AutoSize = True
        File_uploaderLabel.Location = New System.Drawing.Point(6, 102)
        File_uploaderLabel.Name = "File_uploaderLabel"
        File_uploaderLabel.Size = New System.Drawing.Size(47, 16)
        File_uploaderLabel.TabIndex = 38
        File_uploaderLabel.Text = "User ID:"
        '
        'File_uploaderTextBox
        '
        Me.File_uploaderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileDataBindingSource, "file_uploader", True))
        Me.File_uploaderTextBox.Location = New System.Drawing.Point(107, 99)
        Me.File_uploaderTextBox.Name = "File_uploaderTextBox"
        Me.File_uploaderTextBox.Size = New System.Drawing.Size(175, 21)
        Me.File_uploaderTextBox.TabIndex = 39
        '
        'IsApprovedLabel
        '
        IsApprovedLabel.AutoSize = True
        IsApprovedLabel.Location = New System.Drawing.Point(6, 75)
        IsApprovedLabel.Name = "IsApprovedLabel"
        IsApprovedLabel.Size = New System.Drawing.Size(63, 16)
        IsApprovedLabel.TabIndex = 37
        IsApprovedLabel.Text = "File Status:"
        '
        'IsApprovedTextBox
        '
        Me.IsApprovedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileDataBindingSource, "isApproved", True))
        Me.IsApprovedTextBox.Location = New System.Drawing.Point(107, 72)
        Me.IsApprovedTextBox.Name = "IsApprovedTextBox"
        Me.IsApprovedTextBox.ReadOnly = True
        Me.IsApprovedTextBox.Size = New System.Drawing.Size(175, 21)
        Me.IsApprovedTextBox.TabIndex = 38
        '
        'File_nameLabel
        '
        File_nameLabel.AutoSize = True
        File_nameLabel.Location = New System.Drawing.Point(6, 48)
        File_nameLabel.Name = "File_nameLabel"
        File_nameLabel.Size = New System.Drawing.Size(63, 16)
        File_nameLabel.TabIndex = 36
        File_nameLabel.Text = "File Name:"
        '
        'File_nameTextBox
        '
        Me.File_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileDataBindingSource, "file_name", True))
        Me.File_nameTextBox.Location = New System.Drawing.Point(107, 45)
        Me.File_nameTextBox.Name = "File_nameTextBox"
        Me.File_nameTextBox.Size = New System.Drawing.Size(175, 21)
        Me.File_nameTextBox.TabIndex = 37
        '
        'File_idLabel
        '
        File_idLabel.AutoSize = True
        File_idLabel.Location = New System.Drawing.Point(6, 21)
        File_idLabel.Name = "File_idLabel"
        File_idLabel.Size = New System.Drawing.Size(41, 16)
        File_idLabel.TabIndex = 35
        File_idLabel.Text = "File ID:"
        '
        'File_idTextBox
        '
        Me.File_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileDataBindingSource, "file_id", True))
        Me.File_idTextBox.Location = New System.Drawing.Point(107, 18)
        Me.File_idTextBox.Name = "File_idTextBox"
        Me.File_idTextBox.ReadOnly = True
        Me.File_idTextBox.Size = New System.Drawing.Size(175, 21)
        Me.File_idTextBox.TabIndex = 36
        '
        'SqlFileComboBox
        '
        Me.SqlFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SqlFileComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SqlFileComboBox.FormattingEnabled = True
        Me.SqlFileComboBox.Items.AddRange(New Object() {"SHOW ALL DATA", "SELECT (By User ID)", "SELECT (By Username)", "SELECT (Approved)", "SELECT (Pending)", "UPDATE (Only Filename)", "DELETE (By File ID)"})
        Me.SqlFileComboBox.Location = New System.Drawing.Point(391, 18)
        Me.SqlFileComboBox.Name = "SqlFileComboBox"
        Me.SqlFileComboBox.Size = New System.Drawing.Size(206, 24)
        Me.SqlFileComboBox.TabIndex = 35
        '
        'executeFileBtn
        '
        Me.executeFileBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.executeFileBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.executeFileBtn.FlatAppearance.BorderSize = 0
        Me.executeFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.executeFileBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.executeFileBtn.ForeColor = System.Drawing.Color.White
        Me.executeFileBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.executeFileBtn.Location = New System.Drawing.Point(391, 45)
        Me.executeFileBtn.Name = "executeFileBtn"
        Me.executeFileBtn.Size = New System.Drawing.Size(206, 21)
        Me.executeFileBtn.TabIndex = 34
        Me.executeFileBtn.Text = "Execute Query"
        Me.executeFileBtn.UseVisualStyleBackColor = True
        '
        'FileView
        '
        Me.FileView.BackColor = System.Drawing.Color.Silver
        Me.FileView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileIDHeader, Me.FileNameHeader, Me.UserNameHeader, Me.UserIDHeader, Me.FileStatusHeader, Me.DateHeader})
        Me.FileView.Dock = System.Windows.Forms.DockStyle.Top
        Me.FileView.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.FileView.ForeColor = System.Drawing.Color.Black
        Me.FileView.FullRowSelect = True
        Me.FileView.GridLines = True
        Me.FileView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.FileView.Location = New System.Drawing.Point(3, 3)
        Me.FileView.Name = "FileView"
        Me.FileView.Size = New System.Drawing.Size(692, 262)
        Me.FileView.TabIndex = 5
        Me.FileView.UseCompatibleStateImageBehavior = False
        Me.FileView.View = System.Windows.Forms.View.Details
        '
        'FileIDHeader
        '
        Me.FileIDHeader.Text = "UUID"
        Me.FileIDHeader.Width = 195
        '
        'FileNameHeader
        '
        Me.FileNameHeader.Text = "File Name"
        Me.FileNameHeader.Width = 126
        '
        'UserNameHeader
        '
        Me.UserNameHeader.Text = "Username"
        Me.UserNameHeader.Width = 99
        '
        'UserIDHeader
        '
        Me.UserIDHeader.Text = "User ID"
        Me.UserIDHeader.Width = 86
        '
        'FileStatusHeader
        '
        Me.FileStatusHeader.Text = "File Status"
        Me.FileStatusHeader.Width = 79
        '
        'DateHeader
        '
        Me.DateHeader.Text = "Upload Date"
        Me.DateHeader.Width = 105
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
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.InstructorTab.ResumeLayout(False)
        Me.InstructorSubTabControl.ResumeLayout(False)
        Me.InstructorDataTab.ResumeLayout(False)
        Me.InstructorDataManager.ResumeLayout(False)
        Me.InstructorDataManager.PerformLayout()
        Me.HeadTab.ResumeLayout(False)
        Me.HeadSubTabControl.ResumeLayout(False)
        Me.HeadDataTab.ResumeLayout(False)
        Me.HeadDataManager.ResumeLayout(False)
        Me.HeadDataManager.PerformLayout()
        Me.FileTab.ResumeLayout(False)
        Me.FileDataManager.ResumeLayout(False)
        Me.FileDataManager.PerformLayout()
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
    Friend WithEvents NetworkTimer As Timer
    Friend WithEvents InstructorSubTabControl As DotNetBarTabcontrol
    Friend WithEvents InstructorDataTab As TabPage
    Friend WithEvents InstructorDataManager As GroupBox
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
    Friend WithEvents HeadSubTabControl As DotNetBarTabcontrol
    Friend WithEvents HeadDataTab As TabPage
    Friend WithEvents HeadDataManager As GroupBox
    Friend WithEvents Head_titleTextBox As TextBox
    Friend WithEvents HeadDataBindingSource As BindingSource
    Friend WithEvents Head_passTextBox As TextBox
    Friend WithEvents Head_nameTextBox As TextBox
    Friend WithEvents Head_idTextBox As TextBox
    Friend WithEvents SqlHeadComboBox As ComboBox
    Friend WithEvents executeHeadBtn As Button
    Friend WithEvents HeadView As ListView
    Friend WithEvents HeadIDHeader As ColumnHeader
    Friend WithEvents HeadNameHeader As ColumnHeader
    Friend WithEvents HeadTitleHeader As ColumnHeader
    Friend WithEvents Head_passLabel As Label
    Friend WithEvents FileTab As TabPage
    Friend WithEvents FileDataManager As GroupBox
    Friend WithEvents IsApprovedTextBox As TextBox
    Friend WithEvents FileDataBindingSource As BindingSource
    Friend WithEvents File_nameTextBox As TextBox
    Friend WithEvents File_idTextBox As TextBox
    Friend WithEvents SqlFileComboBox As ComboBox
    Friend WithEvents executeFileBtn As Button
    Friend WithEvents FileView As ListView
    Friend WithEvents FileIDHeader As ColumnHeader
    Friend WithEvents FileNameHeader As ColumnHeader
    Friend WithEvents UserNameHeader As ColumnHeader
    Friend WithEvents UserIDHeader As ColumnHeader
    Friend WithEvents FileStatusHeader As ColumnHeader
    Friend WithEvents DateHeader As ColumnHeader
    Friend WithEvents File_uploaderTextBox As TextBox
    Friend WithEvents File_uploader_nameTextBox As TextBox
End Class
