<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFilesForm
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.downloadBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Dashboard = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.searchBarLabel = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.viewFileBtn = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Dashboard.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(9, 187)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(218, 312)
        Me.TreeView1.TabIndex = 23
        '
        'downloadBtn
        '
        Me.downloadBtn.FlatAppearance.BorderSize = 0
        Me.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadBtn.ForeColor = System.Drawing.Color.White
        Me.downloadBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.downloadBtn.Location = New System.Drawing.Point(592, 0)
        Me.downloadBtn.Name = "downloadBtn"
        Me.downloadBtn.Size = New System.Drawing.Size(158, 45)
        Me.downloadBtn.TabIndex = 1
        Me.downloadBtn.Text = "Download File"
        Me.downloadBtn.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.viewFileBtn)
        Me.Panel4.Controls.Add(Me.downloadBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(750, 47)
        Me.Panel4.TabIndex = 24
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(231, 187)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(511, 312)
        Me.RichTextBox1.TabIndex = 25
        Me.RichTextBox1.Text = ""
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
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(750, 182)
        Me.Dashboard.TabIndex = 26
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
        Me.Label2.Size = New System.Drawing.Size(118, 60)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Files"
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
        Me.searchBarLabel.Location = New System.Drawing.Point(9, 130)
        Me.searchBarLabel.Name = "searchBarLabel"
        Me.searchBarLabel.Size = New System.Drawing.Size(51, 17)
        Me.searchBarLabel.TabIndex = 17
        Me.searchBarLabel.Text = "Search"
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.Image = Global.PRS.My.Resources.Resources.minimizeBtn
        Me.minimizeBtn.Location = New System.Drawing.Point(650, 0)
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
        Me.closeBtn.Location = New System.Drawing.Point(700, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 29)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.TabStop = False
        '
        'viewFileBtn
        '
        Me.viewFileBtn.FlatAppearance.BorderSize = 0
        Me.viewFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewFileBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewFileBtn.ForeColor = System.Drawing.Color.White
        Me.viewFileBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.viewFileBtn.Location = New System.Drawing.Point(428, 0)
        Me.viewFileBtn.Name = "viewFileBtn"
        Me.viewFileBtn.Size = New System.Drawing.Size(158, 45)
        Me.viewFileBtn.TabIndex = 2
        Me.viewFileBtn.Text = "View File"
        Me.viewFileBtn.UseVisualStyleBackColor = True
        '
        'ViewFilesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 552)
        Me.Controls.Add(Me.Dashboard)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ViewFilesForm"
        Me.Text = "ViewFilesForm"
        Me.Panel4.ResumeLayout(False)
        Me.Dashboard.ResumeLayout(False)
        Me.Dashboard.PerformLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents downloadBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Dashboard As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchBtn As Button
    Friend WithEvents searchBarLabel As Label
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents searchBar As TextBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents viewFileBtn As Button
End Class
