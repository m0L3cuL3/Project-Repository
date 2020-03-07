<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewFilesForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.viewTextFileBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dashboard = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.viewFileBtn = New System.Windows.Forms.Button()
        Me.downloadBtn = New System.Windows.Forms.Button()
        Me.FileView = New System.Windows.Forms.ListView()
        Me.FileNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileTypeHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileSizeHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.openDirBtn = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Dashboard.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'viewTextFileBox
        '
        Me.viewTextFileBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.viewTextFileBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.viewTextFileBox.Location = New System.Drawing.Point(365, 207)
        Me.viewTextFileBox.Margin = New System.Windows.Forms.Padding(2)
        Me.viewTextFileBox.Name = "viewTextFileBox"
        Me.viewTextFileBox.ReadOnly = True
        Me.viewTextFileBox.Size = New System.Drawing.Size(377, 292)
        Me.viewTextFileBox.TabIndex = 25
        Me.viewTextFileBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Files"
        '
        'Dashboard
        '
        Me.Dashboard.BackgroundImage = Global.PRS.My.Resources.Resources.Dashboard
        Me.Dashboard.Controls.Add(Me.Label3)
        Me.Dashboard.Controls.Add(Me.Label2)
        Me.Dashboard.Controls.Add(Me.minimizeBtn)
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
        Me.Label2.Location = New System.Drawing.Point(24, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 60)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Files"
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
        'FileView
        '
        Me.FileView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameHeader, Me.FileTypeHeader, Me.FileSizeHeader})
        Me.FileView.FullRowSelect = True
        Me.FileView.GridLines = True
        Me.FileView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.FileView.Location = New System.Drawing.Point(12, 207)
        Me.FileView.MultiSelect = False
        Me.FileView.Name = "FileView"
        Me.FileView.Size = New System.Drawing.Size(348, 250)
        Me.FileView.TabIndex = 27
        Me.FileView.UseCompatibleStateImageBehavior = False
        Me.FileView.View = System.Windows.Forms.View.Details
        '
        'FileNameHeader
        '
        Me.FileNameHeader.Text = "File Name"
        Me.FileNameHeader.Width = 148
        '
        'FileTypeHeader
        '
        Me.FileTypeHeader.Text = "Type"
        Me.FileTypeHeader.Width = 103
        '
        'FileSizeHeader
        '
        Me.FileSizeHeader.Text = "File Size"
        Me.FileSizeHeader.Width = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "File Viewer"
        '
        'openDirBtn
        '
        Me.openDirBtn.FlatAppearance.BorderSize = 0
        Me.openDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openDirBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.openDirBtn.ForeColor = System.Drawing.Color.White
        Me.openDirBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.openDirBtn.Location = New System.Drawing.Point(12, 463)
        Me.openDirBtn.Name = "openDirBtn"
        Me.openDirBtn.Size = New System.Drawing.Size(348, 36)
        Me.openDirBtn.TabIndex = 3
        Me.openDirBtn.Text = "Open Directory"
        Me.openDirBtn.UseVisualStyleBackColor = True
        '
        'ViewFilesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 552)
        Me.Controls.Add(Me.openDirBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FileView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dashboard)
        Me.Controls.Add(Me.viewTextFileBox)
        Me.Controls.Add(Me.Panel4)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents downloadBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents viewTextFileBox As RichTextBox
    Friend WithEvents Dashboard As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents viewFileBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FileView As ListView
    Friend WithEvents FileNameHeader As ColumnHeader
    Friend WithEvents FileTypeHeader As ColumnHeader
    Friend WithEvents FileSizeHeader As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents openDirBtn As Button
End Class
