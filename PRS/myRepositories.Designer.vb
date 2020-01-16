<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myRepositories
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.MRtreeView = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MRuploadBtn = New System.Windows.Forms.Button()
        Me.MRsearchBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sdLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MRdeleteBtn = New System.Windows.Forms.Button()
        Me.MRcopyBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchBar
        '
        Me.searchBar.Location = New System.Drawing.Point(10, 270)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(178, 20)
        Me.searchBar.TabIndex = 16
        '
        'MRtreeView
        '
        Me.MRtreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MRtreeView.Location = New System.Drawing.Point(10, 0)
        Me.MRtreeView.Name = "MRtreeView"
        Me.MRtreeView.Size = New System.Drawing.Size(178, 263)
        Me.MRtreeView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.MRuploadBtn)
        Me.Panel2.Controls.Add(Me.MRsearchBtn)
        Me.Panel2.Controls.Add(Me.searchBar)
        Me.Panel2.Controls.Add(Me.MRtreeView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 341)
        Me.Panel2.TabIndex = 4
        '
        'MRuploadBtn
        '
        Me.MRuploadBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRuploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MRuploadBtn.FlatAppearance.BorderSize = 0
        Me.MRuploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRuploadBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRuploadBtn.ForeColor = System.Drawing.Color.White
        Me.MRuploadBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRuploadBtn.Location = New System.Drawing.Point(10, 296)
        Me.MRuploadBtn.Name = "MRuploadBtn"
        Me.MRuploadBtn.Size = New System.Drawing.Size(86, 34)
        Me.MRuploadBtn.TabIndex = 23
        Me.MRuploadBtn.Text = "Upload"
        Me.MRuploadBtn.UseVisualStyleBackColor = True
        '
        'MRsearchBtn
        '
        Me.MRsearchBtn.BackColor = System.Drawing.Color.Silver
        Me.MRsearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MRsearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.MRsearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRsearchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRsearchBtn.ForeColor = System.Drawing.Color.Black
        Me.MRsearchBtn.Location = New System.Drawing.Point(102, 296)
        Me.MRsearchBtn.Name = "MRsearchBtn"
        Me.MRsearchBtn.Size = New System.Drawing.Size(86, 34)
        Me.MRsearchBtn.TabIndex = 22
        Me.MRsearchBtn.Text = "Search"
        Me.MRsearchBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.sdLabel)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.MRdeleteBtn)
        Me.Panel3.Controls.Add(Me.MRcopyBtn)
        Me.Panel3.Location = New System.Drawing.Point(200, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 79)
        Me.Panel3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Custom Directory"
        '
        'sdLabel
        '
        Me.sdLabel.AutoSize = True
        Me.sdLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdLabel.Location = New System.Drawing.Point(6, 9)
        Me.sdLabel.Name = "sdLabel"
        Me.sdLabel.Size = New System.Drawing.Size(135, 20)
        Me.sdLabel.TabIndex = 24
        Me.sdLabel.Text = "Current Directory"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(420, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(147, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(256, 20)
        Me.TextBox1.TabIndex = 22
        '
        'MRdeleteBtn
        '
        Me.MRdeleteBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRdeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MRdeleteBtn.FlatAppearance.BorderSize = 0
        Me.MRdeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRdeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRdeleteBtn.ForeColor = System.Drawing.Color.White
        Me.MRdeleteBtn.Image = Global.PRS.My.Resources.Resources.logoutBtn
        Me.MRdeleteBtn.Location = New System.Drawing.Point(507, 34)
        Me.MRdeleteBtn.Name = "MRdeleteBtn"
        Me.MRdeleteBtn.Size = New System.Drawing.Size(81, 34)
        Me.MRdeleteBtn.TabIndex = 21
        Me.MRdeleteBtn.Text = "Delete"
        Me.MRdeleteBtn.UseVisualStyleBackColor = True
        '
        'MRcopyBtn
        '
        Me.MRcopyBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRcopyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MRcopyBtn.FlatAppearance.BorderSize = 0
        Me.MRcopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRcopyBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRcopyBtn.ForeColor = System.Drawing.Color.White
        Me.MRcopyBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRcopyBtn.Location = New System.Drawing.Point(420, 34)
        Me.MRcopyBtn.Name = "MRcopyBtn"
        Me.MRcopyBtn.Size = New System.Drawing.Size(81, 34)
        Me.MRcopyBtn.TabIndex = 20
        Me.MRcopyBtn.Text = "Copy"
        Me.MRcopyBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(200, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(588, 263)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'myRepositories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "myRepositories"
        Me.Size = New System.Drawing.Size(800, 341)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchBar As TextBox
    Friend WithEvents MRtreeView As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MRdeleteBtn As Button
    Friend WithEvents MRcopyBtn As Button
    Friend WithEvents MRuploadBtn As Button
    Friend WithEvents MRsearchBtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sdLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
End Class
