<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.headBoardPanel = New System.Windows.Forms.Panel()
        Me.logoPB = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.draggablePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.userTb = New System.Windows.Forms.TextBox()
        Me.passTb = New System.Windows.Forms.TextBox()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.RepoDBDataSet = New PRS.repoDBDataSet()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataTableAdapter = New PRS.repoDBDataSetTableAdapters.StudentDataTableAdapter()
        Me.TableAdapterManager = New PRS.repoDBDataSetTableAdapters.TableAdapterManager()
        Me.FileDataTableAdapter = New PRS.repoDBDataSetTableAdapters.FileDataTableAdapter()
        Me.InstructorDataTableAdapter = New PRS.repoDBDataSetTableAdapters.InstructorDataTableAdapter()
        Me.headBoardPanel.SuspendLayout()
        CType(Me.logoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.draggablePanel.SuspendLayout()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headBoardPanel
        '
        Me.headBoardPanel.BackgroundImage = Global.PRS.My.Resources.Resources.loginHeader
        Me.headBoardPanel.Controls.Add(Me.logoPB)
        Me.headBoardPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headBoardPanel.Location = New System.Drawing.Point(0, 30)
        Me.headBoardPanel.Name = "headBoardPanel"
        Me.headBoardPanel.Size = New System.Drawing.Size(301, 175)
        Me.headBoardPanel.TabIndex = 0
        '
        'logoPB
        '
        Me.logoPB.BackColor = System.Drawing.Color.Transparent
        Me.logoPB.Image = Global.PRS.My.Resources.Resources.logo
        Me.logoPB.Location = New System.Drawing.Point(0, 0)
        Me.logoPB.Name = "logoPB"
        Me.logoPB.Size = New System.Drawing.Size(300, 175)
        Me.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoPB.TabIndex = 4
        Me.logoPB.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.PRS.My.Resources.Resources.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(250, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 29)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.TabStop = False
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.Image = Global.PRS.My.Resources.Resources.minimizeBtn
        Me.minimizeBtn.Location = New System.Drawing.Point(200, 0)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.Size = New System.Drawing.Size(50, 29)
        Me.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizeBtn.TabIndex = 3
        Me.minimizeBtn.TabStop = False
        '
        'draggablePanel
        '
        Me.draggablePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.draggablePanel.Controls.Add(Me.closeBtn)
        Me.draggablePanel.Controls.Add(Me.minimizeBtn)
        Me.draggablePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.draggablePanel.Location = New System.Drawing.Point(0, 0)
        Me.draggablePanel.Name = "draggablePanel"
        Me.draggablePanel.Size = New System.Drawing.Size(301, 30)
        Me.draggablePanel.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 31)
        Me.Panel2.TabIndex = 5
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(47, 223)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(71, 17)
        Me.userLabel.TabIndex = 6
        Me.userLabel.Text = "Username"
        '
        'userTb
        '
        Me.userTb.Location = New System.Drawing.Point(50, 243)
        Me.userTb.Name = "userTb"
        Me.userTb.Size = New System.Drawing.Size(200, 20)
        Me.userTb.TabIndex = 7
        '
        'passTb
        '
        Me.passTb.Location = New System.Drawing.Point(50, 298)
        Me.passTb.Name = "passTb"
        Me.passTb.Size = New System.Drawing.Size(200, 20)
        Me.passTb.TabIndex = 8
        Me.passTb.UseSystemPasswordChar = True
        '
        'passLabel
        '
        Me.passLabel.AutoSize = True
        Me.passLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLabel.Location = New System.Drawing.Point(48, 278)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(69, 17)
        Me.passLabel.TabIndex = 9
        Me.passLabel.Text = "Password"
        '
        'loginBtn
        '
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.loginBtn.Location = New System.Drawing.Point(50, 346)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(200, 42)
        Me.loginBtn.TabIndex = 10
        Me.loginBtn.Text = "Log In"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'RepoDBDataSet
        '
        Me.RepoDBDataSet.DataSetName = "repoDBDataSet"
        Me.RepoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentDataBindingSource
        '
        Me.StudentDataBindingSource.DataMember = "StudentData"
        Me.StudentDataBindingSource.DataSource = Me.RepoDBDataSet
        '
        'StudentDataTableAdapter
        '
        Me.StudentDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FileDataTableAdapter = Nothing
        Me.TableAdapterManager.HeadDataTableAdapter = Nothing
        Me.TableAdapterManager.InstructorDataTableAdapter = Nothing
        Me.TableAdapterManager.StudentDataTableAdapter = Me.StudentDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = PRS.repoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FileDataTableAdapter
        '
        Me.FileDataTableAdapter.ClearBeforeFill = True
        '
        'InstructorDataTableAdapter
        '
        Me.InstructorDataTableAdapter.ClearBeforeFill = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 497)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.passTb)
        Me.Controls.Add(Me.userTb)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.headBoardPanel)
        Me.Controls.Add(Me.draggablePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.headBoardPanel.ResumeLayout(False)
        CType(Me.logoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.draggablePanel.ResumeLayout(False)
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headBoardPanel As Panel
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents draggablePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents userLabel As Label
    Friend WithEvents userTb As TextBox
    Friend WithEvents passTb As TextBox
    Friend WithEvents passLabel As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents logoPB As PictureBox
    Friend WithEvents RepoDBDataSet As repoDBDataSet
    Friend WithEvents StudentDataBindingSource As BindingSource
    Friend WithEvents StudentDataTableAdapter As repoDBDataSetTableAdapters.StudentDataTableAdapter
    Friend WithEvents TableAdapterManager As repoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileDataTableAdapter As repoDBDataSetTableAdapters.FileDataTableAdapter
    Friend WithEvents InstructorDataTableAdapter As repoDBDataSetTableAdapters.InstructorDataTableAdapter
End Class
