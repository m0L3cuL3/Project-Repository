<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.topBarPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.minimizeBtn = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.fileListView = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MemoryChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.minLbl = New System.Windows.Forms.Label()
        Me.maxLbl = New System.Windows.Forms.Label()
        Me.memLbl = New System.Windows.Forms.Label()
        Me.topBarPanel.SuspendLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoryChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topBarPanel
        '
        Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topBarPanel.Controls.Add(Me.Label3)
        Me.topBarPanel.Controls.Add(Me.minimizeBtn)
        Me.topBarPanel.Controls.Add(Me.closeBtn)
        Me.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.topBarPanel.Name = "topBarPanel"
        Me.topBarPanel.Size = New System.Drawing.Size(842, 29)
        Me.topBarPanel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Admin Form"
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.Image = Global.PRS.My.Resources.Resources.minimizeAdminBtn
        Me.minimizeBtn.Location = New System.Drawing.Point(742, 0)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.Size = New System.Drawing.Size(50, 29)
        Me.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizeBtn.TabIndex = 3
        Me.minimizeBtn.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.PRS.My.Resources.Resources.closeAdminBtn
        Me.closeBtn.Location = New System.Drawing.Point(792, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 29)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.TabStop = False
        '
        'fileListView
        '
        Me.fileListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.fileListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fileListView.HideSelection = False
        Me.fileListView.Location = New System.Drawing.Point(25, 89)
        Me.fileListView.Name = "fileListView"
        Me.fileListView.Size = New System.Drawing.Size(196, 338)
        Me.fileListView.TabIndex = 8
        Me.fileListView.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(324, 89)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(196, 338)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRS.My.Resources.Resources.archiveBtn
        Me.PictureBox1.Location = New System.Drawing.Point(245, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PRS.My.Resources.Resources.restoreBtn
        Me.PictureBox2.Location = New System.Drawing.Point(245, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(382, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Archives"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Repositories"
        '
        'MemoryChart
        '
        Me.MemoryChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MemoryChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.MemoryChart.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.MemoryChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.MemoryChart.Legends.Add(Legend1)
        Me.MemoryChart.Location = New System.Drawing.Point(530, 89)
        Me.MemoryChart.Name = "MemoryChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.MemoryChart.Series.Add(Series1)
        Me.MemoryChart.Size = New System.Drawing.Size(300, 156)
        Me.MemoryChart.TabIndex = 15
        Me.MemoryChart.Text = "Chart1"
        '
        'minLbl
        '
        Me.minLbl.AutoSize = True
        Me.minLbl.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minLbl.ForeColor = System.Drawing.Color.White
        Me.minLbl.Location = New System.Drawing.Point(527, 267)
        Me.minLbl.Name = "minLbl"
        Me.minLbl.Size = New System.Drawing.Size(169, 16)
        Me.minLbl.TabIndex = 16
        Me.minLbl.Text = "Minimum Application Address:"
        '
        'maxLbl
        '
        Me.maxLbl.AutoSize = True
        Me.maxLbl.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxLbl.ForeColor = System.Drawing.Color.White
        Me.maxLbl.Location = New System.Drawing.Point(527, 286)
        Me.maxLbl.Name = "maxLbl"
        Me.maxLbl.Size = New System.Drawing.Size(174, 16)
        Me.maxLbl.TabIndex = 17
        Me.maxLbl.Text = "Maximum Application Address:"
        '
        'memLbl
        '
        Me.memLbl.AutoSize = True
        Me.memLbl.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memLbl.ForeColor = System.Drawing.Color.White
        Me.memLbl.Location = New System.Drawing.Point(527, 248)
        Me.memLbl.Name = "memLbl"
        Me.memLbl.Size = New System.Drawing.Size(52, 16)
        Me.memLbl.TabIndex = 18
        Me.memLbl.Text = "Memory"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 452)
        Me.Controls.Add(Me.memLbl)
        Me.Controls.Add(Me.maxLbl)
        Me.Controls.Add(Me.minLbl)
        Me.Controls.Add(Me.MemoryChart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.fileListView)
        Me.Controls.Add(Me.topBarPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.topBarPanel.ResumeLayout(False)
        Me.topBarPanel.PerformLayout()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoryChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents topBarPanel As Panel
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents fileListView As ListView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MemoryChart As DataVisualization.Charting.Chart
    Friend WithEvents minLbl As Label
    Friend WithEvents maxLbl As Label
    Friend WithEvents memLbl As Label
End Class
