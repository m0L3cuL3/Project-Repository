<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.projectIdHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.testBtn = New System.Windows.Forms.Button()
        Me.deptCb = New System.Windows.Forms.ComboBox()
        Me.yearLvlCb = New System.Windows.Forms.ComboBox()
        Me.nameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.projectNameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deptHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yearLvlHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lastModifiedHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.filterBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.projectIdHeader, Me.projectNameHeader, Me.deptHeader, Me.yearLvlHeader, Me.lastModifiedHeader})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(445, 217)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'projectIdHeader
        '
        Me.projectIdHeader.Text = "Project ID"
        '
        'testBtn
        '
        Me.testBtn.Location = New System.Drawing.Point(83, 337)
        Me.testBtn.Name = "testBtn"
        Me.testBtn.Size = New System.Drawing.Size(141, 23)
        Me.testBtn.TabIndex = 1
        Me.testBtn.Text = "Push Repository"
        Me.testBtn.UseVisualStyleBackColor = True
        '
        'deptCb
        '
        Me.deptCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deptCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.deptCb.FormattingEnabled = True
        Me.deptCb.Items.AddRange(New Object() {"Computer Science", "Information Technology", "Information Systems"})
        Me.deptCb.Location = New System.Drawing.Point(83, 283)
        Me.deptCb.Name = "deptCb"
        Me.deptCb.Size = New System.Drawing.Size(141, 21)
        Me.deptCb.TabIndex = 2
        '
        'yearLvlCb
        '
        Me.yearLvlCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearLvlCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.yearLvlCb.FormattingEnabled = True
        Me.yearLvlCb.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.yearLvlCb.Location = New System.Drawing.Point(83, 310)
        Me.yearLvlCb.Name = "yearLvlCb"
        Me.yearLvlCb.Size = New System.Drawing.Size(141, 21)
        Me.yearLvlCb.TabIndex = 3
        '
        'nameTb
        '
        Me.nameTb.Location = New System.Drawing.Point(83, 257)
        Me.nameTb.Name = "nameTb"
        Me.nameTb.Size = New System.Drawing.Size(141, 20)
        Me.nameTb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year Level"
        '
        'projectNameHeader
        '
        Me.projectNameHeader.Text = "Project Name"
        '
        'deptHeader
        '
        Me.deptHeader.Text = "Department"
        '
        'yearLvlHeader
        '
        Me.yearLvlHeader.Text = "Year Level"
        '
        'lastModifiedHeader
        '
        Me.lastModifiedHeader.Text = "Last Modified"
        '
        'filterBtn
        '
        Me.filterBtn.Location = New System.Drawing.Point(270, 255)
        Me.filterBtn.Name = "filterBtn"
        Me.filterBtn.Size = New System.Drawing.Size(141, 23)
        Me.filterBtn.TabIndex = 9
        Me.filterBtn.Text = "Test Filter"
        Me.filterBtn.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.filterBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameTb)
        Me.Controls.Add(Me.yearLvlCb)
        Me.Controls.Add(Me.deptCb)
        Me.Controls.Add(Me.testBtn)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "HomePage"
        Me.Size = New System.Drawing.Size(445, 427)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents projectIdHeader As ColumnHeader
    Friend WithEvents testBtn As Button
    Friend WithEvents deptCb As ComboBox
    Friend WithEvents yearLvlCb As ComboBox
    Friend WithEvents nameTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents projectNameHeader As ColumnHeader
    Friend WithEvents deptHeader As ColumnHeader
    Friend WithEvents yearLvlHeader As ColumnHeader
    Friend WithEvents lastModifiedHeader As ColumnHeader
    Friend WithEvents filterBtn As Button
End Class
