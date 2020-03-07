Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class AdminForm
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim Properties As IPGlobalProperties
    Dim StatV4 As IPGlobalStatistics

    'form load
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMSSQLVersion() 'loads database version
        LoadStudentData() 'default loads student data
        LoadInstructorData() 'default loads instructor data
        LoadHeadData() 'default loads head of department data
        LoadFileData() 'default loads file data

        HideStudentPass() 'default hides student password components
        HideInstructorPass() 'default hides instructor password components
        HideHeadPass() 'default hides head of department password components

        NetworkTimer.Start() 'starts network monitoring
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

    Private Sub minimizeBtn_Click(sender As Object, e As EventArgs) Handles minimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_MouseEnter(sender As Object, e As EventArgs) Handles closeBtn.MouseEnter
        closeBtn.Image = My.Resources.closeBtnHover
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.Image = My.Resources.closeAdminBtn
    End Sub

    Private Sub minimizeBtn_MouseEnter(sender As Object, e As EventArgs) Handles minimizeBtn.MouseEnter
        minimizeBtn.Image = My.Resources.minimizeBtnHover
    End Sub

    Private Sub minimizeBtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizeBtn.MouseLeave
        minimizeBtn.Image = My.Resources.minimizeAdminBtn
    End Sub

    'when click display data in textbox (STUDENT)
    Private Sub StudentView_SelectedIndexChanged(sender As Object, e As EventArgs)
        If StudentView.SelectedItems.Count > 0 Then
            Student_idTextBox.Text = StudentView.SelectedItems(0).SubItems(0).Text
            Student_nameTextBox.Text = StudentView.SelectedItems(0).SubItems(1).Text
            Student_levelTextBox.Text = StudentView.SelectedItems(0).SubItems(2).Text
            Student_courseTextBox.Text = StudentView.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    'when click display data in textbox (INSTRUCTOR)
    Private Sub InstructorView_SelectedIndexChanged(sender As Object, e As EventArgs)
        If InstructorView.SelectedItems.Count > 0 Then
            Instructor_idTextBox.Text = InstructorView.SelectedItems(0).SubItems(0).Text
            Instructor_userTextBox.Text = InstructorView.SelectedItems(0).SubItems(1).Text
            Instructor_titleTextBox.Text = InstructorView.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    'when click display data in textbox (HEAD OF DEPARTMENT)
    Private Sub HeadView_SelectedIndexChanged(sender As Object, e As EventArgs)
        If HeadView.SelectedItems.Count > 0 Then
            Head_idTextBox.Text = HeadView.SelectedItems(0).SubItems(0).Text
            Head_nameTextBox.Text = HeadView.SelectedItems(0).SubItems(1).Text
            Head_titleTextBox.Text = HeadView.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    'when click display data in textbox (FILES)
    Private Sub FileView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileView.SelectedIndexChanged
        If FileView.SelectedItems.Count > 0 Then
            File_idTextBox.Text = FileView.SelectedItems(0).SubItems(0).Text
            File_nameTextBox.Text = FileView.SelectedItems(0).SubItems(1).Text
            IsApprovedTextBox.Text = FileView.SelectedItems(0).SubItems(4).Text
            File_uploaderTextBox.Text = FileView.SelectedItems(0).SubItems(3).Text
            File_uploader_nameTextBox.Text = FileView.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    'logout button
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    'execute query button (STUDENT)
    Private Sub executeStudentBtn_Click(sender As Object, e As EventArgs)
        ExecuteStudentQuery()
        ClearTextBoxes(Me)
    End Sub

    'execute query button (INSTRUCTOR)
    Private Sub executeInstructorBtn_Click(sender As Object, e As EventArgs)
        ExecuteInstructorQuery()
        ClearTextBoxes(Me)
    End Sub

    'execute query button (HEAD OF DEPARTMENT)
    Private Sub executeHeadBtn_Click(sender As Object, e As EventArgs)
        ExecuteHeadQuery()
        ClearTextBoxes(Me)
    End Sub

    'execute query button (FILES)
    Private Sub executeFileBtn_Click(sender As Object, e As EventArgs) Handles executeFileBtn.Click
        ExecuteFileQuery()
        ClearTextBoxes(Me)
    End Sub

    'loads student data
    Private Sub LoadStudentData()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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

    'loads instructor data
    Private Sub LoadInstructorData()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [InstructorData]"

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                Item.SubItems.Add(dr.Item("instructor_user").ToString)
                Item.SubItems.Add(dr.Item("instructor_title").ToString)
                InstructorView.Items.Add(Item)

            End While
        Catch ex As Exception
            ' Do nothing
        End Try
    End Sub

    'loads head of department data
    Private Sub LoadHeadData()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [HeadData]"

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                Item.SubItems.Add(dr.Item("head_name").ToString)
                Item.SubItems.Add(dr.Item("head_title").ToString)
                HeadView.Items.Add(Item)

            End While
        Catch ex As Exception
            ' Do nothing
        End Try
    End Sub

    'loads file data
    Private Sub LoadFileData()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [Table]"

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                Item.SubItems.Add(dr.Item("file_name").ToString)
                Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                Item.SubItems.Add(dr.Item("file_uploader").ToString)
                Item.SubItems.Add(dr.Item("isApproved").ToString)
                Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                FileView.Items.Add(Item)
            End While
        Catch ex As Exception
            'Do Nothing
        End Try
    End Sub

    'execute sql queries (STUDENT)
    Private Sub ExecuteStudentQuery()

        If SqlStudentComboBox.SelectedItem = "SHOW ALL DATA" Then 'shows all student data
            HideStudentPass()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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
        ElseIf SqlStudentComboBox.SelectedItem = "SELECT (By ID)" Then ' selects student data by ID

            HideStudentPass()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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
        ElseIf SqlStudentComboBox.SelectedItem = "INSERT" Then 'inserts a new student

            ShowStudentPass()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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
        ElseIf SqlStudentComboBox.SelectedItem = "UPDATE" Then 'updates selected student
            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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

                LoadStudentData() 'reloads student data after update

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
        ElseIf SqlStudentComboBox.SelectedItem = "DELETE (By ID)" Then 'deletes student by id
            HideStudentPass()

            StudentView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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

    'execute sql queries (INSTRUCTOR)
    Private Sub ExecuteInstructorQuery()

        If SqlInstructorComboBox.SelectedItem = "SHOW ALL DATA" Then 'shows all instructor data
            HideInstructorPass()

            InstructorView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [InstructorData]"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                    Item.SubItems.Add(dr.Item("instructor_user").ToString)
                    Item.SubItems.Add(dr.Item("instructor_title").ToString)
                    InstructorView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadInstructorData()
            End Try
        ElseIf SqlInstructorComboBox.SelectedItem = "SELECT (By ID)" Then ' selects instructor data by ID

            HideInstructorPass()

            InstructorView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [InstructorData] WHERE instructor_id = @id"
                cmd.Parameters.AddWithValue("@id", Instructor_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                    Item.SubItems.Add(dr.Item("instructor_user").ToString)
                    Item.SubItems.Add(dr.Item("instructor_title").ToString)
                    InstructorView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadInstructorData()
            End Try
        ElseIf SqlInstructorComboBox.SelectedItem = "INSERT" Then 'inserts a new student

            ShowInstructorPass()

            InstructorView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO [InstructorData](instructor_id, instructor_user, instructor_pass, instructor_title) VALUES (@id, @name, @pass, @title)"
                cmd.Parameters.AddWithValue("@id", Instructor_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Instructor_userTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Instructor_passTextBox.Text)
                cmd.Parameters.AddWithValue("@title", Instructor_titleTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadInstructorData() 'reloads instructor data after insertion

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                    Item.SubItems.Add(dr.Item("instructor_user").ToString)
                    Item.SubItems.Add(dr.Item("instructor_title").ToString)
                    InstructorView.Items.Add(Item)
                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadInstructorData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadInstructorData()
            End Try
        ElseIf SqlInstructorComboBox.SelectedItem = "UPDATE" Then 'updates selected instrucor
            InstructorView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE [InstructorData] SET instructor_user = @name, instructor_pass = @pass, instructor_title = @title WHERE instructor_id = @id"
                cmd.Parameters.AddWithValue("@id", Instructor_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Instructor_userTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Instructor_passTextBox.Text)
                cmd.Parameters.AddWithValue("@title", Instructor_titleTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadInstructorData() 'reloads student data after update

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                    Item.SubItems.Add(dr.Item("instructor_user").ToString)
                    Item.SubItems.Add(dr.Item("instructor_title").ToString)
                    InstructorView.Items.Add(Item)

                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadInstructorData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadInstructorData()
            End Try
        ElseIf SqlInstructorComboBox.SelectedItem = "DELETE (By ID)" Then 'deletes instructor by id
            HideInstructorPass()

            InstructorView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM [InstructorData] WHERE instructor_id = @id"
                cmd.Parameters.AddWithValue("@id", Instructor_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadInstructorData() 'reloads instructor data after deletion.

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("instructor_id").ToString))
                    Item.SubItems.Add(dr.Item("instructor_user").ToString)
                    Item.SubItems.Add(dr.Item("instructor_title").ToString)
                    InstructorView.Items.Add(Item)

                End While
            Catch ex As Exception
                LoadInstructorData()
            End Try
        End If
    End Sub

    'execute sql queries (HEAD OF DEPARTMENT)
    Private Sub ExecuteHeadQuery()
        If SqlHeadComboBox.SelectedItem = "SHOW ALL DATA" Then 'shows all head of department data
            HideHeadPass()

            HeadView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [HeadData]"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                    Item.SubItems.Add(dr.Item("head_name").ToString)
                    Item.SubItems.Add(dr.Item("head_title").ToString)
                    HeadView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadHeadData()
            End Try
        ElseIf SqlHeadComboBox.SelectedItem = "SELECT (By ID)" Then ' selects instructor data by ID

            HideHeadPass()

            HeadView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [HeadData] WHERE head_id = @id"
                cmd.Parameters.AddWithValue("@id", Head_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                    Item.SubItems.Add(dr.Item("head_name").ToString)
                    Item.SubItems.Add(dr.Item("head_title").ToString)
                    HeadView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadHeadData()
            End Try
        ElseIf SqlHeadComboBox.SelectedItem = "INSERT" Then 'inserts a new student

            ShowHeadPass()

            HeadView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO [HeadData](head_id, head_name, head_pass, head_title) VALUES (@id, @name, @pass, @title)"
                cmd.Parameters.AddWithValue("@id", Head_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Head_nameTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Head_passTextBox.Text)
                cmd.Parameters.AddWithValue("@title", Head_titleTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadHeadData() 'reloads instructor data after insertion

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                    Item.SubItems.Add(dr.Item("head_name").ToString)
                    Item.SubItems.Add(dr.Item("head_title").ToString)
                    HeadView.Items.Add(Item)
                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadHeadData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadHeadData()
            End Try
        ElseIf SqlHeadComboBox.SelectedItem = "UPDATE" Then 'updates selected instrucor
            HeadView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE [HeadData] SET head_name = @name, head_pass = @pass, head_title = @title WHERE head_id = @id"
                cmd.Parameters.AddWithValue("@id", Head_idTextBox.Text)
                cmd.Parameters.AddWithValue("@name", Head_nameTextBox.Text)
                cmd.Parameters.AddWithValue("@pass", Head_passTextBox.Text)
                cmd.Parameters.AddWithValue("@title", Head_titleTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadHeadData() 'reloads student data after update

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                    Item.SubItems.Add(dr.Item("head_name").ToString)
                    Item.SubItems.Add(dr.Item("head_title").ToString)
                    HeadView.Items.Add(Item)

                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadHeadData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadHeadData()
            End Try
        ElseIf SqlHeadComboBox.SelectedItem = "DELETE (By ID)" Then 'deletes instructor by id
            HideHeadPass()

            HeadView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM [HeadData] WHERE head_id = @id"
                cmd.Parameters.AddWithValue("@id", Head_idTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadHeadData() 'reloads instructor data after deletion.

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("head_id").ToString))
                    Item.SubItems.Add(dr.Item("head_name").ToString)
                    Item.SubItems.Add(dr.Item("head_title").ToString)
                    HeadView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadHeadData()
            End Try
        End If
    End Sub

    'execute sql queries (FILES)
    Private Sub ExecuteFileQuery()
        If SqlFileComboBox.SelectedItem = "SHOW ALL DATA" Then 'shows all file data

            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table]"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "SELECT (By User ID)" Then ' selects files by user id

            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] WHERE file_uploader = @id"
                cmd.Parameters.AddWithValue("@id", File_uploaderTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "SELECT (By Username)" Then 'selects files by username
            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] WHERE file_uploader_name = @name"
                cmd.Parameters.AddWithValue("@name", File_uploader_nameTextBox.Text)

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadFileData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "SELECT (Approved)" Then 'selects approved files only
            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] WHERE isApproved = 'approved'"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)

                End While
            Catch ex As SqlException
                MessageBox.Show(ex.ToString, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadFileData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "SELECT (Pending)" Then 'selects pending files only
            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT * FROM [Table] WHERE isApproved = 'pending'"

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "UPDATE (Only Filename)" Then
            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE [Table] SET file_name = @filename WHERE file_id = @id"
                cmd.Parameters.AddWithValue("@filename", File_nameTextBox.Text)
                cmd.Parameters.AddWithValue("@id", Guid.Parse(File_idTextBox.Text))

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadFileData()

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
                LoadFileData()
            End Try
        ElseIf SqlFileComboBox.SelectedItem = "DELETE (By File ID)" Then
            FileView.Items.Clear()

            Try
                Dim conn As New SqlConnection
                conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
                conn.Open()

                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM [Table] WHERE file_id = @id"
                cmd.Parameters.AddWithValue("@id", Guid.Parse(File_idTextBox.Text))

                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                LoadFileData()

                While dr.Read()
                    Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                    Item.SubItems.Add(dr.Item("file_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader_name").ToString)
                    Item.SubItems.Add(dr.Item("file_uploader").ToString)
                    Item.SubItems.Add(dr.Item("isApproved").ToString)
                    Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                    FileView.Items.Add(Item)
                End While
            Catch ex As Exception
                LoadFileData()
            End Try
        End If
    End Sub

    'hide password components (STUDENT)
    Private Sub HideStudentPass()
        'student
        Student_passLabel.Visible = False 'hide passLabel
        Student_passTextBox.Visible = False 'hides passTb
    End Sub

    'show password components (STUDENT)
    Private Sub ShowStudentPass()
        'student
        Student_passLabel.Visible = True 'show passLabel
        Student_passTextBox.Visible = True 'show passTb
    End Sub

    'hide password components (INSTRUCTOR)
    Private Sub HideInstructorPass()
        'instructor
        Instructor_passLabel.Visible = False 'hide passLabel
        Instructor_passTextBox.Visible = False 'hides passTb
    End Sub

    'show password components (INSTRUCTOR)
    Private Sub ShowInstructorPass()
        'instructor
        Instructor_passLabel.Visible = True 'show passLabel
        Instructor_passTextBox.Visible = True 'show passTb
    End Sub

    'hide password components (HEAD OF DEPARTMENT)
    Private Sub HideHeadPass()
        'head of department
        Head_passLabel.Visible = False 'hide passLabel
        Head_passTextBox.Visible = False 'hides passTb
    End Sub

    'show password components (HEAD OF DEPARTMENT)
    Private Sub ShowHeadPass()
        'head of department
        Head_passLabel.Visible = True 'hide passLabel
        Head_passTextBox.Visible = True 'hides passTb
    End Sub

    'student combo box query filter selector
    Private Sub SqlStudentComboBox_SelectedValueChanged(sender As Object, e As EventArgs)
        If SqlStudentComboBox.SelectedItem = "SHOW ALL DATA" Then
            HideStudentPass()
        ElseIf SqlStudentComboBox.SelectedItem = "SELECT (By ID)" Then
            HideStudentPass()
        ElseIf SqlStudentComboBox.SelectedItem = "INSERT" Then
            ShowStudentPass()
        ElseIf SqlStudentComboBox.SelectedItem = "UPDATE" Then
            ShowStudentPass()
        ElseIf SqlStudentComboBox.SelectedItem = "DELETE (By ID)" Then
            HideStudentPass()
        End If
    End Sub

    'instructor combo box query filter selector
    Private Sub SqlInstructorComboBox_SelectedValueChanged(sender As Object, e As EventArgs)
        If SqlInstructorComboBox.SelectedItem = "SHOW ALL DATA" Then
            HideInstructorPass()
        ElseIf SqlInstructorComboBox.SelectedItem = "SELECT (By ID)" Then
            HideInstructorPass()
        ElseIf SqlInstructorComboBox.SelectedItem = "INSERT" Then
            ShowInstructorPass()
        ElseIf SqlInstructorComboBox.SelectedItem = "UPDATE" Then
            ShowInstructorPass()
        ElseIf SqlInstructorComboBox.SelectedItem = "DELETE (By ID)" Then
            HideInstructorPass()
        End If
    End Sub

    'head of department combo box query filter selector
    Private Sub SqlHeadComboBox_SelectedValueChanged(sender As Object, e As EventArgs)
        If SqlHeadComboBox.SelectedItem = "SHOW ALL DATA" Then
            HideHeadPass()
        ElseIf SqlHeadComboBox.SelectedItem = "SELECT (By ID)" Then
            HideHeadPass()
        ElseIf SqlHeadComboBox.SelectedItem = "INSERT" Then
            ShowHeadPass()
        ElseIf SqlHeadComboBox.SelectedItem = "UPDATE" Then
            ShowHeadPass()
        ElseIf SqlHeadComboBox.SelectedItem = "DELETE (By ID)" Then
            HideHeadPass()
        End If
    End Sub

    'load MSSQL Version
    Private Sub LoadMSSQLVersion()
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ceon Rodriguez\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
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

    'network monitor (HOME)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles NetworkTimer.Tick
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