Imports System.Runtime.InteropServices
Imports PRS.Types
Imports PRS.Win32api
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports System.Collections.ObjectModel

Public Class AdminForm
    Dim valuesY As New List(Of Double)
    Dim timer As Timer
    Dim si As _SYSTEM_INFO
    Const VAL_NUM As Integer = 100
    Const PROC_NUM As Integer = 2000
    Dim ProcMap(PROC_NUM) As _PROCESSENTRY32

    Private Sub ChartInit()
        For i = 1 To VAL_NUM
            valuesY.Add(0)
        Next
    End Sub

    'execute on form load'
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChartInit()
        Dim ms = New _MEMORYSTATUSEX()
        ms.dwLength = Marshal.SizeOf(ms)
        GlobalMemoryStatusEx(ms)
        si = New _SYSTEM_INFO()
        GetSystemInfo(si)
        minLbl.Text = "Minimum Application Address:" + CType(si.lpMinimumApplicationAddress, UInt32).ToString("X")
        maxLbl.Text = "Maximum Application Address:" + CType(si.lpMaximumApplicationAddress, UInt32).ToString("X")

        Dim autoEvent As New AutoResetEvent(False)
        timer = New Timer(AddressOf TimerCallBack, autoEvent, 0, 500)

        Dim chartArea

        chartArea = MemoryChart.ChartAreas(0)
        chartArea.AxisX.Minimum = 0
        chartArea.AxisX.Maximum = 100
        chartArea.AxisY.Minimum = 0
        chartArea.AxisY.Maximum = ms.ullTotalPhys / 1024 / 1024
        chartArea.AxisY.Interval = 2048
        chartArea.AxisX.LabelStyle.Enabled = False
        chartArea.AxisY.LabelStyle.ForeColor = Color.White
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray

        MemoryChart.Series(0).ChartType = SeriesChartType.Spline
        MemoryChart.Series(0).BorderWidth = 2
        MemoryChart.Series(0).Name = "Memory in use"
    End Sub

    Private Sub minimizeBtn_MouseEnter(sender As Object, e As EventArgs) Handles minimizeBtn.MouseEnter
        minimizeBtn.Image = My.Resources.minimizeAdminBtnHover
    End Sub

    Private Sub minimizeBtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizeBtn.MouseLeave
        minimizeBtn.Image = My.Resources.minimizeAdminBtn
    End Sub

    Private Sub closeBtn_MouseEnter(sender As Object, e As EventArgs) Handles closeBtn.MouseEnter
        closeBtn.Image = My.Resources.closeBtnHover
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.Image = My.Resources.closeAdminBtn
    End Sub

    Private Sub TimerCallBack(stateInfo As Object)
        Dim ms = New _MEMORYSTATUSEX()
        ms.dwLength = Marshal.SizeOf(ms)
        GlobalMemoryStatusEx(ms)
        valuesY.Add((ms.ullTotalPhys - ms.ullAvailPhys) / 1024 / 1024)
        valuesY.RemoveAt(0)
        Invoke(New Action(AddressOf Chart_Update))
        Invoke(New Action(Of _MEMORYSTATUSEX)(AddressOf Label_MemUsage_Update), ms)
    End Sub

    Private Sub Label_MemUsage_Update(ms As _MEMORYSTATUSEX)
        Dim gb = 1024 * 1024 * 1024
        Dim now = (ms.ullTotalPhys - ms.ullAvailPhys) / gb
        Dim tot = (ms.ullTotalPhys) / gb
        memLbl.Text = "Memory " + now.ToString("0.0") + "/" + tot.ToString("0.0") + " GB " + ms.dwMemoryLoad.ToString() + "%"
    End Sub

    Private Sub Chart_Update()
        MemoryChart.Series(0).Points.DataBindY(valuesY)
    End Sub

End Class