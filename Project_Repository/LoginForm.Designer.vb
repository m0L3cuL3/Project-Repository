<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.userTb = New System.Windows.Forms.TextBox()
        Me.passTb = New System.Windows.Forms.TextBox()
        Me.projectLbl = New System.Windows.Forms.Label()
        Me.userLbl = New System.Windows.Forms.Label()
        Me.passLbl = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.topBarPanel = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Label()
        Me.userTypeCb = New System.Windows.Forms.ComboBox()
        Me.topBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'userTb
        '
        Me.userTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userTb.Location = New System.Drawing.Point(51, 182)
        Me.userTb.Multiline = True
        Me.userTb.Name = "userTb"
        Me.userTb.Size = New System.Drawing.Size(236, 23)
        Me.userTb.TabIndex = 0
        '
        'passTb
        '
        Me.passTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passTb.Location = New System.Drawing.Point(51, 239)
        Me.passTb.Multiline = True
        Me.passTb.Name = "passTb"
        Me.passTb.Size = New System.Drawing.Size(236, 23)
        Me.passTb.TabIndex = 1
        '
        'projectLbl
        '
        Me.projectLbl.AutoSize = True
        Me.projectLbl.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectLbl.ForeColor = System.Drawing.Color.White
        Me.projectLbl.Location = New System.Drawing.Point(27, 76)
        Me.projectLbl.Name = "projectLbl"
        Me.projectLbl.Size = New System.Drawing.Size(283, 39)
        Me.projectLbl.TabIndex = 2
        Me.projectLbl.Text = "PROJECT REPOSITORY"
        '
        'userLbl
        '
        Me.userLbl.AutoSize = True
        Me.userLbl.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLbl.ForeColor = System.Drawing.Color.White
        Me.userLbl.Location = New System.Drawing.Point(48, 163)
        Me.userLbl.Name = "userLbl"
        Me.userLbl.Size = New System.Drawing.Size(59, 16)
        Me.userLbl.TabIndex = 3
        Me.userLbl.Text = "USERNAME"
        '
        'passLbl
        '
        Me.passLbl.AutoSize = True
        Me.passLbl.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLbl.ForeColor = System.Drawing.Color.White
        Me.passLbl.Location = New System.Drawing.Point(48, 220)
        Me.passLbl.Name = "passLbl"
        Me.passLbl.Size = New System.Drawing.Size(62, 16)
        Me.passLbl.TabIndex = 4
        Me.passLbl.Text = "PASSWORD"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(51, 317)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(236, 39)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'topBarPanel
        '
        Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topBarPanel.Controls.Add(Me.closeBtn)
        Me.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.topBarPanel.Name = "topBarPanel"
        Me.topBarPanel.Size = New System.Drawing.Size(340, 26)
        Me.topBarPanel.TabIndex = 6
        '
        'closeBtn
        '
        Me.closeBtn.AutoSize = True
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.Location = New System.Drawing.Point(320, 6)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(14, 13)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'userTypeCb
        '
        Me.userTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userTypeCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.userTypeCb.FormattingEnabled = True
        Me.userTypeCb.Items.AddRange(New Object() {"Student", "Instructor", "Head Of Department"})
        Me.userTypeCb.Location = New System.Drawing.Point(51, 268)
        Me.userTypeCb.Name = "userTypeCb"
        Me.userTypeCb.Size = New System.Drawing.Size(236, 21)
        Me.userTypeCb.TabIndex = 7
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(340, 430)
        Me.Controls.Add(Me.userTypeCb)
        Me.Controls.Add(Me.topBarPanel)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passLbl)
        Me.Controls.Add(Me.userLbl)
        Me.Controls.Add(Me.projectLbl)
        Me.Controls.Add(Me.passTb)
        Me.Controls.Add(Me.userTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.topBarPanel.ResumeLayout(False)
        Me.topBarPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userTb As TextBox
    Friend WithEvents passTb As TextBox
    Friend WithEvents projectLbl As Label
    Friend WithEvents userLbl As Label
    Friend WithEvents passLbl As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents topBarPanel As Panel
    Friend WithEvents closeBtn As Label
    Friend WithEvents userTypeCb As ComboBox
End Class
