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
        Me.headBoardPanel = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.logoPB = New System.Windows.Forms.PictureBox()
        Me.headBoardPanel.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.logoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headBoardPanel
        '
        Me.headBoardPanel.BackgroundImage = Global.PRS.My.Resources.Resources.loginHeader
        Me.headBoardPanel.Controls.Add(Me.logoPB)
        Me.headBoardPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headBoardPanel.Location = New System.Drawing.Point(0, 30)
        Me.headBoardPanel.Name = "headBoardPanel"
        Me.headBoardPanel.Size = New System.Drawing.Size(300, 175)
        Me.headBoardPanel.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.minimizeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 30)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 419)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 31)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 243)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(50, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 8
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
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 450)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.headBoardPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.headBoardPanel.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.logoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headBoardPanel As Panel
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents userLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents passLabel As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents logoPB As PictureBox
End Class
