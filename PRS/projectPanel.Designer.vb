﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class projectPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.projectTitle = New System.Windows.Forms.Label()
        Me.uploadedByLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'projectTitle
        '
        Me.projectTitle.AutoSize = True
        Me.projectTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectTitle.Location = New System.Drawing.Point(5, 9)
        Me.projectTitle.Name = "projectTitle"
        Me.projectTitle.Size = New System.Drawing.Size(207, 24)
        Me.projectTitle.TabIndex = 0
        Me.projectTitle.Text = "Sample Project Title"
        '
        'uploadedByLabel
        '
        Me.uploadedByLabel.AutoSize = True
        Me.uploadedByLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadedByLabel.Location = New System.Drawing.Point(6, 33)
        Me.uploadedByLabel.Name = "uploadedByLabel"
        Me.uploadedByLabel.Size = New System.Drawing.Size(160, 17)
        Me.uploadedByLabel.TabIndex = 1
        Me.uploadedByLabel.Text = "by Sean Myko C. Baang"
        '
        'projectPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.uploadedByLabel)
        Me.Controls.Add(Me.projectTitle)
        Me.Name = "projectPanel"
        Me.Size = New System.Drawing.Size(800, 60)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents projectTitle As Label
    Friend WithEvents uploadedByLabel As Label
End Class