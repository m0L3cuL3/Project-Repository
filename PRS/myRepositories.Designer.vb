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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.existRepoTb = New System.Windows.Forms.TextBox()
        Me.browseFileBtn = New System.Windows.Forms.Button()
        Me.projectStatusFilter = New System.Windows.Forms.ComboBox()
        Me.approveFilterLabel = New System.Windows.Forms.Label()
        Me.FilterBtn = New System.Windows.Forms.Button()
        Me.datefilterLabel = New System.Windows.Forms.Label()
        Me.DateFilterCb = New System.Windows.Forms.DateTimePicker()
        Me.folderListView = New System.Windows.Forms.ListView()
        Me.FileIDHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileTitleHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApproveHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LastModifiedHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fileBar = New System.Windows.Forms.TextBox()
        Me.CreateRepoBtn = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New PRS.repoDBDataSetTableAdapters.TableAdapterManager()
        Me.FileDataTableAdapter = New PRS.repoDBDataSetTableAdapters.FileDataTableAdapter()
        Me.RepoDBDataSet = New PRS.repoDBDataSet()
        Me.Panel3.SuspendLayout()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.existRepoTb)
        Me.Panel3.Controls.Add(Me.browseFileBtn)
        Me.Panel3.Controls.Add(Me.projectStatusFilter)
        Me.Panel3.Controls.Add(Me.approveFilterLabel)
        Me.Panel3.Controls.Add(Me.FilterBtn)
        Me.Panel3.Controls.Add(Me.datefilterLabel)
        Me.Panel3.Controls.Add(Me.DateFilterCb)
        Me.Panel3.Location = New System.Drawing.Point(200, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 79)
        Me.Panel3.TabIndex = 5
        '
        'existRepoTb
        '
        Me.existRepoTb.Location = New System.Drawing.Point(3, 8)
        Me.existRepoTb.Name = "existRepoTb"
        Me.existRepoTb.Size = New System.Drawing.Size(249, 20)
        Me.existRepoTb.TabIndex = 28
        '
        'browseFileBtn
        '
        Me.browseFileBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.browseFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.browseFileBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.browseFileBtn.FlatAppearance.BorderSize = 0
        Me.browseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browseFileBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browseFileBtn.ForeColor = System.Drawing.Color.White
        Me.browseFileBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.browseFileBtn.Location = New System.Drawing.Point(3, 34)
        Me.browseFileBtn.Name = "browseFileBtn"
        Me.browseFileBtn.Size = New System.Drawing.Size(249, 22)
        Me.browseFileBtn.TabIndex = 38
        Me.browseFileBtn.Text = "Add file in existing repository"
        Me.browseFileBtn.UseVisualStyleBackColor = True
        '
        'projectStatusFilter
        '
        Me.projectStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.projectStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.projectStatusFilter.FormattingEnabled = True
        Me.projectStatusFilter.Items.AddRange(New Object() {"approved", "pending"})
        Me.projectStatusFilter.Location = New System.Drawing.Point(459, 25)
        Me.projectStatusFilter.Name = "projectStatusFilter"
        Me.projectStatusFilter.Size = New System.Drawing.Size(129, 21)
        Me.projectStatusFilter.TabIndex = 35
        '
        'approveFilterLabel
        '
        Me.approveFilterLabel.AutoSize = True
        Me.approveFilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.approveFilterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approveFilterLabel.Location = New System.Drawing.Point(456, 4)
        Me.approveFilterLabel.Name = "approveFilterLabel"
        Me.approveFilterLabel.Size = New System.Drawing.Size(132, 17)
        Me.approveFilterLabel.TabIndex = 34
        Me.approveFilterLabel.Text = "Approved/Pending"
        '
        'FilterBtn
        '
        Me.FilterBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.FilterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FilterBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FilterBtn.FlatAppearance.BorderSize = 0
        Me.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterBtn.ForeColor = System.Drawing.Color.White
        Me.FilterBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.FilterBtn.Location = New System.Drawing.Point(333, 53)
        Me.FilterBtn.Name = "FilterBtn"
        Me.FilterBtn.Size = New System.Drawing.Size(255, 22)
        Me.FilterBtn.TabIndex = 33
        Me.FilterBtn.Text = "Filter"
        Me.FilterBtn.UseVisualStyleBackColor = True
        '
        'datefilterLabel
        '
        Me.datefilterLabel.AutoSize = True
        Me.datefilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.datefilterLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datefilterLabel.Location = New System.Drawing.Point(333, 4)
        Me.datefilterLabel.Name = "datefilterLabel"
        Me.datefilterLabel.Size = New System.Drawing.Size(40, 17)
        Me.datefilterLabel.TabIndex = 32
        Me.datefilterLabel.Text = "Date"
        '
        'DateFilterCb
        '
        Me.DateFilterCb.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFilterCb.CustomFormat = "MM/dd/yyyy"
        Me.DateFilterCb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateFilterCb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateFilterCb.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilterCb.Location = New System.Drawing.Point(333, 24)
        Me.DateFilterCb.Name = "DateFilterCb"
        Me.DateFilterCb.Size = New System.Drawing.Size(120, 23)
        Me.DateFilterCb.TabIndex = 31
        Me.DateFilterCb.Value = New Date(2020, 2, 16, 0, 0, 0, 0)
        '
        'folderListView
        '
        Me.folderListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.folderListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileIDHeader, Me.FileTitleHeader, Me.ApproveHeader, Me.LastModifiedHeader})
        Me.folderListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.folderListView.FullRowSelect = True
        Me.folderListView.GridLines = True
        Me.folderListView.HideSelection = False
        Me.folderListView.Location = New System.Drawing.Point(11, 0)
        Me.folderListView.Name = "folderListView"
        Me.folderListView.Size = New System.Drawing.Size(777, 263)
        Me.folderListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.folderListView.TabIndex = 6
        Me.folderListView.TileSize = New System.Drawing.Size(200, 30)
        Me.folderListView.UseCompatibleStateImageBehavior = False
        Me.folderListView.View = System.Windows.Forms.View.Details
        '
        'FileIDHeader
        '
        Me.FileIDHeader.Text = "UUID"
        Me.FileIDHeader.Width = 212
        '
        'FileTitleHeader
        '
        Me.FileTitleHeader.Text = "Title"
        Me.FileTitleHeader.Width = 263
        '
        'ApproveHeader
        '
        Me.ApproveHeader.Text = "Is Approved"
        Me.ApproveHeader.Width = 140
        '
        'LastModifiedHeader
        '
        Me.LastModifiedHeader.Text = "Last Modified"
        Me.LastModifiedHeader.Width = 162
        '
        'fileBar
        '
        Me.fileBar.Location = New System.Drawing.Point(12, 270)
        Me.fileBar.Name = "fileBar"
        Me.fileBar.Size = New System.Drawing.Size(178, 20)
        Me.fileBar.TabIndex = 24
        '
        'CreateRepoBtn
        '
        Me.CreateRepoBtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CreateRepoBtn.BackgroundImage = Global.PRS.My.Resources.Resources.generalBtn
        Me.CreateRepoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateRepoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateRepoBtn.FlatAppearance.BorderSize = 0
        Me.CreateRepoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateRepoBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateRepoBtn.ForeColor = System.Drawing.Color.White
        Me.CreateRepoBtn.Image = Global.PRS.My.Resources.Resources.generalBtn
        Me.CreateRepoBtn.Location = New System.Drawing.Point(12, 296)
        Me.CreateRepoBtn.Name = "CreateRepoBtn"
        Me.CreateRepoBtn.Size = New System.Drawing.Size(178, 34)
        Me.CreateRepoBtn.TabIndex = 27
        Me.CreateRepoBtn.Text = "Create Repository"
        Me.CreateRepoBtn.UseVisualStyleBackColor = False
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
        'myRepositories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.fileBar)
        Me.Controls.Add(Me.CreateRepoBtn)
        Me.Controls.Add(Me.folderListView)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "myRepositories"
        Me.Size = New System.Drawing.Size(800, 341)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.RepoDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents folderListView As ListView
    Friend WithEvents FileIDHeader As ColumnHeader
    Friend WithEvents FileTitleHeader As ColumnHeader
    Friend WithEvents ApproveHeader As ColumnHeader
    Friend WithEvents LastModifiedHeader As ColumnHeader
    Friend WithEvents TableAdapterManager As repoDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileDataTableAdapter As repoDBDataSetTableAdapters.FileDataTableAdapter
    Friend WithEvents RepoDBDataSet As repoDBDataSet
    Friend WithEvents fileBar As TextBox
    Friend WithEvents CreateRepoBtn As Button
    Friend WithEvents DateFilterCb As DateTimePicker
    Friend WithEvents datefilterLabel As Label
    Friend WithEvents approveFilterLabel As Label
    Friend WithEvents FilterBtn As Button
    Friend WithEvents projectStatusFilter As ComboBox
    Friend WithEvents browseFileBtn As Button
    Friend WithEvents existRepoTb As TextBox
End Class
