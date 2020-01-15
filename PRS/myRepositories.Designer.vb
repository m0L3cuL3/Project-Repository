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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.MRdownloadBtn = New System.Windows.Forms.Button()
        Me.selectBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchBar
        '
        Me.searchBar.Location = New System.Drawing.Point(10, 321)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(178, 20)
        Me.searchBar.TabIndex = 16
        '
        'MRtreeView
        '
        Me.MRtreeView.Dock = System.Windows.Forms.DockStyle.Top
        Me.MRtreeView.Location = New System.Drawing.Point(0, 0)
        Me.MRtreeView.Name = "MRtreeView"
        Me.MRtreeView.Size = New System.Drawing.Size(200, 314)
        Me.MRtreeView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.selectBtn)
        Me.Panel2.Controls.Add(Me.cancelBtn)
        Me.Panel2.Controls.Add(Me.searchBar)
        Me.Panel2.Controls.Add(Me.MRtreeView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 388)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.deleteBtn)
        Me.Panel3.Controls.Add(Me.MRdownloadBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(200, 341)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 47)
        Me.Panel3.TabIndex = 5
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Silver
        Me.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelBtn.Location = New System.Drawing.Point(102, 347)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(86, 34)
        Me.cancelBtn.TabIndex = 22
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Image = Global.PRS.My.Resources.Resources.logoutBtn
        Me.deleteBtn.Location = New System.Drawing.Point(507, 7)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(81, 34)
        Me.deleteBtn.TabIndex = 21
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'MRdownloadBtn
        '
        Me.MRdownloadBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRdownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MRdownloadBtn.FlatAppearance.BorderSize = 0
        Me.MRdownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRdownloadBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRdownloadBtn.ForeColor = System.Drawing.Color.White
        Me.MRdownloadBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.MRdownloadBtn.Location = New System.Drawing.Point(418, 7)
        Me.MRdownloadBtn.Name = "MRdownloadBtn"
        Me.MRdownloadBtn.Size = New System.Drawing.Size(81, 34)
        Me.MRdownloadBtn.TabIndex = 20
        Me.MRdownloadBtn.Text = "Download"
        Me.MRdownloadBtn.UseVisualStyleBackColor = True
        '
        'selectBtn
        '
        Me.selectBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.selectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selectBtn.FlatAppearance.BorderSize = 0
        Me.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectBtn.ForeColor = System.Drawing.Color.White
        Me.selectBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.selectBtn.Location = New System.Drawing.Point(10, 347)
        Me.selectBtn.Name = "selectBtn"
        Me.selectBtn.Size = New System.Drawing.Size(86, 34)
        Me.selectBtn.TabIndex = 23
        Me.selectBtn.Text = "Select"
        Me.selectBtn.UseVisualStyleBackColor = True
        '
        'myRepositories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "myRepositories"
        Me.Size = New System.Drawing.Size(800, 388)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchBar As TextBox
    Friend WithEvents MRtreeView As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents deleteBtn As Button
    Friend WithEvents MRdownloadBtn As Button
    Friend WithEvents selectBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
