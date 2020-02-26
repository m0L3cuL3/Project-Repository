<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.guidLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.approveBtn = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New PRS.repoDBDataSetTableAdapters.TableAdapterManager()
        Me.FileDataTableAdapter = New PRS.repoDBDataSetTableAdapters.FileDataTableAdapter()
        Me.RepoDBDataSet = New PRS.repoDBDataSet()
        Me.uploaderLabel = New System.Windows.Forms.Label()
        Me.downloadBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'projectTitle
        '
        Me.projectTitle.AutoSize = True
        Me.projectTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectTitle.Location = New System.Drawing.Point(3, 3)
        Me.projectTitle.Name = "projectTitle"
        Me.projectTitle.Size = New System.Drawing.Size(52, 21)
        Me.projectTitle.TabIndex = 0
        Me.projectTitle.Text = "pTitle"
        '
        'guidLabel
        '
        Me.guidLabel.AutoSize = True
        Me.guidLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guidLabel.Location = New System.Drawing.Point(4, 42)
        Me.guidLabel.Name = "guidLabel"
        Me.guidLabel.Size = New System.Drawing.Size(32, 16)
        Me.guidLabel.TabIndex = 1
        Me.guidLabel.Text = "guid"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PRS.My.Resources.Resources.pendingMark2
        Me.PictureBox1.Location = New System.Drawing.Point(712, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'approveBtn
        '
        Me.approveBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.approveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.approveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.approveBtn.Enabled = False
        Me.approveBtn.FlatAppearance.BorderSize = 0
        Me.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.approveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approveBtn.ForeColor = System.Drawing.Color.White
        Me.approveBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.approveBtn.Location = New System.Drawing.Point(576, 28)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.Size = New System.Drawing.Size(130, 24)
        Me.approveBtn.TabIndex = 25
        Me.approveBtn.Text = "Approve"
        Me.approveBtn.UseVisualStyleBackColor = True
        Me.approveBtn.Visible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminDataTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FileDataTableAdapter = Me.FileDataTableAdapter
        Me.TableAdapterManager.HeadDataTableAdapter = Nothing
        Me.TableAdapterManager.InstructorDataTableAdapter = Nothing
        Me.TableAdapterManager.StudentDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRS.repoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FileDataTableAdapter
        '
        Me.FileDataTableAdapter.ClearBeforeFill = True
        '
        'RepoDBDataSet
        '
        Me.RepoDBDataSet.DataSetName = "repoDBDataSet"
        Me.RepoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uploaderLabel
        '
        Me.uploaderLabel.AutoSize = True
        Me.uploaderLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploaderLabel.Location = New System.Drawing.Point(4, 27)
        Me.uploaderLabel.Name = "uploaderLabel"
        Me.uploaderLabel.Size = New System.Drawing.Size(25, 16)
        Me.uploaderLabel.TabIndex = 26
        Me.uploaderLabel.Text = "uid"
        '
        'downloadBtn
        '
        Me.downloadBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.downloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.downloadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.downloadBtn.Enabled = False
        Me.downloadBtn.FlatAppearance.BorderSize = 0
        Me.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadBtn.ForeColor = System.Drawing.Color.White
        Me.downloadBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.downloadBtn.Location = New System.Drawing.Point(576, 28)
        Me.downloadBtn.Name = "downloadBtn"
        Me.downloadBtn.Size = New System.Drawing.Size(130, 24)
        Me.downloadBtn.TabIndex = 27
        Me.downloadBtn.Text = "Download"
        Me.downloadBtn.UseVisualStyleBackColor = True
        Me.downloadBtn.Visible = False
        '
        'projectPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.downloadBtn)
        Me.Controls.Add(Me.uploaderLabel)
        Me.Controls.Add(Me.approveBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.guidLabel)
        Me.Controls.Add(Me.projectTitle)
        Me.Name = "projectPanel"
        Me.Size = New System.Drawing.Size(775, 60)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents projectTitle As Label
    Friend WithEvents guidLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents approveBtn As Button
    Friend WithEvents TableAdapterManager As repoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileDataTableAdapter As repoDBDataSetTableAdapters.FileDataTableAdapter
    Friend WithEvents RepoDBDataSet As repoDBDataSet
    Friend WithEvents uploaderLabel As Label
    Friend WithEvents downloadBtn As Button
End Class
