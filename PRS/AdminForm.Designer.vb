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
        Me.topBarPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.filterPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.filterLabel = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.fileDataBtn = New System.Windows.Forms.Panel()
        Me.studentBtn = New System.Windows.Forms.Panel()
        Me.instructorBtn = New System.Windows.Forms.Panel()
        Me.hodBtn = New System.Windows.Forms.Panel()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.topBarPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.filterPanel.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.filterPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(842, 438)
        Me.SplitContainer1.SplitterDistance = 295
        Me.SplitContainer1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.fileDataBtn)
        Me.Panel1.Controls.Add(Me.studentBtn)
        Me.Panel1.Controls.Add(Me.instructorBtn)
        Me.Panel1.Controls.Add(Me.hodBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 438)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 385)
        Me.Panel2.TabIndex = 1
        '
        'filterPanel
        '
        Me.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filterPanel.Controls.Add(Me.searchBtn)
        Me.filterPanel.Controls.Add(Me.TextBox1)
        Me.filterPanel.Controls.Add(Me.filterLabel)
        Me.filterPanel.Controls.Add(Me.ComboBox2)
        Me.filterPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterPanel.Location = New System.Drawing.Point(0, 0)
        Me.filterPanel.Name = "filterPanel"
        Me.filterPanel.Size = New System.Drawing.Size(543, 53)
        Me.filterPanel.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 20)
        Me.TextBox1.TabIndex = 16
        '
        'filterLabel
        '
        Me.filterLabel.AutoSize = True
        Me.filterLabel.BackColor = System.Drawing.Color.Transparent
        Me.filterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterLabel.ForeColor = System.Drawing.Color.White
        Me.filterLabel.Location = New System.Drawing.Point(3, 6)
        Me.filterLabel.Name = "filterLabel"
        Me.filterLabel.Size = New System.Drawing.Size(37, 17)
        Me.filterLabel.TabIndex = 15
        Me.filterLabel.Text = "Filter"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 25)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'fileDataBtn
        '
        Me.fileDataBtn.BackgroundImage = Global.PRS.My.Resources.Resources.pendingProjectsBtn
        Me.fileDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.fileDataBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fileDataBtn.Location = New System.Drawing.Point(0, 256)
        Me.fileDataBtn.Name = "fileDataBtn"
        Me.fileDataBtn.Size = New System.Drawing.Size(290, 55)
        Me.fileDataBtn.TabIndex = 16
        '
        'studentBtn
        '
        Me.studentBtn.BackgroundImage = Global.PRS.My.Resources.Resources.studentsBtn
        Me.studentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.studentBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.studentBtn.Location = New System.Drawing.Point(0, 91)
        Me.studentBtn.Name = "studentBtn"
        Me.studentBtn.Size = New System.Drawing.Size(290, 55)
        Me.studentBtn.TabIndex = 13
        '
        'instructorBtn
        '
        Me.instructorBtn.BackgroundImage = Global.PRS.My.Resources.Resources.myProjectsBtn
        Me.instructorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.instructorBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.instructorBtn.Location = New System.Drawing.Point(0, 146)
        Me.instructorBtn.Name = "instructorBtn"
        Me.instructorBtn.Size = New System.Drawing.Size(290, 55)
        Me.instructorBtn.TabIndex = 14
        '
        'hodBtn
        '
        Me.hodBtn.BackgroundImage = Global.PRS.My.Resources.Resources.pendingProjectsBtn
        Me.hodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.hodBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hodBtn.Location = New System.Drawing.Point(0, 201)
        Me.hodBtn.Name = "hodBtn"
        Me.hodBtn.Size = New System.Drawing.Size(290, 55)
        Me.hodBtn.TabIndex = 15
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
        Me.searchBtn.Location = New System.Drawing.Point(451, 25)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(86, 22)
        Me.searchBtn.TabIndex = 20
        Me.searchBtn.Text = "Enter"
        Me.searchBtn.UseVisualStyleBackColor = True
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
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 467)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.topBarPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.topBarPanel.ResumeLayout(False)
        Me.topBarPanel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.filterPanel.ResumeLayout(False)
        Me.filterPanel.PerformLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topBarPanel As Panel
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fileDataBtn As Panel
    Friend WithEvents studentBtn As Panel
    Friend WithEvents instructorBtn As Panel
    Friend WithEvents hodBtn As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents filterPanel As Panel
    Friend WithEvents searchBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents filterLabel As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class
