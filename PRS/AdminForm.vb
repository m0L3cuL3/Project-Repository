Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class AdminForm
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim Properties As IPGlobalProperties
    Dim StatV4 As IPGlobalStatistics

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDatabaseStatus()
        LoadStudentData()
        HidePasswordComponent() 'default hides password components
        Timer1.Start()
    End Sub

    Private Sub topBarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub topBarPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseUp
        draggable = False
    End Sub

    Private Sub topBarPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles topBarPanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub StudentView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentView.SelectedIndexChanged
        If StudentView.SelectedItems.Count > 0 Then
            Student_idTextBox.Text = StudentView.SelectedItems(0).SubItems(0).Text
            Student_nameTextBox.Text = StudentView.SelectedItems(0).SubItems(1).Text
            Student_levelTextBox.Text = StudentView.SelectedItems(0).SubItems(2).Text
            Student_courseTextBox.Text = StudentView.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub executeStudentBtn_Click(sender As Object, e As EventArgs) Handles executeStudentBtn.Click
        ExecuteStudentQuery()
    End Sub

    'loads student data
    Private Sub LoadStudentData()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [StudentData]"

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                Item.SubItems.Add(dr.Item("student_name").ToString)
                Item.SubItems.Add(dr.Item("student_level").ToString)
                Item.SubItems.Add(dr.Item("student_course").ToString)
                StudentView.Items.Add(Item)

            End While
        Catch ex As Exception
            ' Do nothing
        End Try
    End Sub

    'execute sql queries
    'SELECT (By ID)
    'INSERT
    'UPDATE
    'DELETE (By ID)
    Private Sub ExecuteStudentQuery()

        If SqlComboBox.SelectedItem = "SHOW ALL DATA" Then
            HidePasswordComponent()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [StudentData]"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                    Item.SubItems.Add(dr.Item("student_name").ToString)
                    Item.SubItems.Add(dr.Item("student_level").ToString)
                    Item.SubItems.Add(dr.Item("student_course").ToString)
                    StudentView.Items.Add(Item)

                End While
            Catch ex As Exception
                LoadStudentData()
            End Try
        ElseIf SqlComboBox.SelectedItem = "SELECT (By ID)" Then ' selects student data by ID

            HidePasswordComponent()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [StudentData] WHERE student_id = @id"
                cmd.Parameters.AddWithValue("@id", Student_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                    Item.SubItems.Add(dr.Item("student_name").ToString)
                    Item.SubItems.Add(dr.Item("student_level").ToString)
                    Item.SubItems.Add(dr.Item("student_course").ToString)
                    StudentView.Items.Add(Item)

                End While
            Catch ex As Exception
                LoadStudentData()
            End Try
        ElseIf SqlComboBox.SelectedItem = "INSERT" Then 'inserts a new student

            ShowPasswordComponent()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO [StudentData](student_id, student_name, student_pass, student_course, student_level) VALUES (@id, @name, @pass, @course, @level)"
                cmd.Parameters.AddWithValue("@id", Student_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Student_nameTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Student_passTextBox.Text)
                cmd.Parameters.AddWithValue("@course", Student_courseTextBox.Text)
                cmd.Parameters.AddWithValue("@level", Student_levelTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadStudentData() 'reloads student data after insertion

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                    Item.SubItems.Add(dr.Item("student_name").ToString)
                    Item.SubItems.Add(dr.Item("student_level").ToString)
                    Item.SubItems.Add(dr.Item("student_course").ToString)
                    StudentView.Items.Add(Item)

                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadStudentData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadStudentData()
            End Try
        ElseIf SqlComboBox.SelectedItem = "UPDATE" Then 'updates selected student
            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE [StudentData] SET student_name = @name, student_pass = @pass, student_level = @level, student_course = @course WHERE student_id = @id"
                cmd.Parameters.AddWithValue("@id", Student_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Student_nameTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Student_passTextBox.Text)
                cmd.Parameters.AddWithValue("@course", Student_courseTextBox.Text)
                cmd.Parameters.AddWithValue("@level", Student_levelTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadStudentData() 'reloads student data after insertion

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                    Item.SubItems.Add(dr.Item("student_name").ToString)
                    Item.SubItems.Add(dr.Item("student_level").ToString)
                    Item.SubItems.Add(dr.Item("student_course").ToString)
                    StudentView.Items.Add(Item)

                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadStudentData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadStudentData()
            End Try
        ElseIf SqlComboBox.SelectedItem = "DELETE (By ID)" Then 'deletes student by id
            HidePasswordComponent()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM [StudentData] WHERE student_id = @id"
                cmd.Parameters.AddWithValue("@id", Student_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadStudentData() 'reloads student data after deletion.

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("student_id").ToString))
                    Item.SubItems.Add(dr.Item("student_name").ToString)
                    Item.SubItems.Add(dr.Item("student_level").ToString)
                    Item.SubItems.Add(dr.Item("student_course").ToString)
                    StudentView.Items.Add(Item)

                End While
            Catch ex As Exception
                LoadStudentData()
            End Try
        End If
    End Sub

    Private Sub HidePasswordComponent()
        Student_passLabel.Visible = False 'hide passLabel
        Student_passTextBox.Visible = False 'hides passTb
    End Sub

    Private Sub ShowPasswordComponent()
        Student_passLabel.Visible = True 'show passLabel
        Student_passTextBox.Visible = True 'show passTb
    End Sub

    Private Sub SqlComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SqlComboBox.SelectedValueChanged
        If SqlComboBox.SelectedItem = "SHOW ALL DATA" Then
            HidePasswordComponent()
        ElseIf SqlComboBox.SelectedItem = "SELECT (By ID)" Then
            HidePasswordComponent()
        ElseIf SqlComboBox.SelectedItem = "INSERT" Then
            ShowPasswordComponent()
        ElseIf SqlComboBox.SelectedItem = "UPDATE" Then
            ShowPasswordComponent()
        ElseIf SqlComboBox.SelectedItem = "DELETE (By ID)" Then
            HidePasswordComponent()
        End If
    End Sub

    'loads all status of mssql database
    Private Sub LoadDatabaseStatus()
        LoadMSSQLVersion()
    End Sub

    'load MSSQL Version
    Private Sub LoadMSSQLVersion()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT @@VERSION"

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                SqlVersionLabel.Text = dr(0).ToString
            End While
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = ("")
        Label4.Text = ("")
        Label5.Text = ("")
        Label6.Text = ("")
        Properties = IPGlobalProperties.GetIPGlobalProperties
        StatV4 = Properties.GetIPv4GlobalStatistics
        Label2.Text &= "Received: " & StatV4.ReceivedPackets & vbNewLine
        Label4.Text &= "Delivered: " & StatV4.ReceivedPacketsDelivered & vbNewLine
        Label5.Text &= "Discarded: " & StatV4.ReceivedPacketsDiscarded & vbNewLine
        Label6.Text &= "Forwarded: " & StatV4.ReceivedPacketsForwarded & vbNewLine
    End Sub
End Class