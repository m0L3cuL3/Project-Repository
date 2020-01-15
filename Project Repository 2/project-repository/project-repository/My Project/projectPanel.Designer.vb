<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projectPanel
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.projectTitle = New System.Windows.Forms.Label()
        Me.uploadedBy = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.project_repository.My.Resources.Resources.downloadBtn
        Me.PictureBox1.Location = New System.Drawing.Point(700, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'projectTitle
        '
        Me.projectTitle.AutoSize = True
        Me.projectTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectTitle.Location = New System.Drawing.Point(3, 3)
        Me.projectTitle.Name = "projectTitle"
        Me.projectTitle.Size = New System.Drawing.Size(246, 30)
        Me.projectTitle.TabIndex = 1
        Me.projectTitle.Text = "Sample Project Title"
        '
        'uploadedBy
        '
        Me.uploadedBy.AutoSize = True
        Me.uploadedBy.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.uploadedBy.Location = New System.Drawing.Point(4, 34)
        Me.uploadedBy.Name = "uploadedBy"
        Me.uploadedBy.Size = New System.Drawing.Size(114, 19)
        Me.uploadedBy.TabIndex = 2
        Me.uploadedBy.Text = "By Sean Baang"
        '
        'projectPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.uploadedBy)
        Me.Controls.Add(Me.projectTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "projectPanel"
        Me.Size = New System.Drawing.Size(794, 57)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents projectTitle As Label
    Friend WithEvents uploadedBy As Label
End Class
