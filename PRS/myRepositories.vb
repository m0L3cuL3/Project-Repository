Imports System.Data.SqlClient
Imports System.IO

Public Class myRepositories

    'executes code on form load'
    Private Sub myRepositories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainDirectory()
        LoadUserRepository()
    End Sub

    Private Sub CreateRepoBtn_MouseEnter(sender As Object, e As EventArgs) Handles CreateRepoBtn.MouseEnter
        CreateRepoBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub CreateRepoBtn_MouseLeave(sender As Object, e As EventArgs) Handles CreateRepoBtn.MouseLeave
        CreateRepoBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub browseFileBtn_MouseEnter(sender As Object, e As EventArgs) Handles browseFileBtn.MouseEnter
        browseFileBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub browseFileBtn_MouseLeave(sender As Object, e As EventArgs) Handles browseFileBtn.MouseLeave
        browseFileBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub FilterBtn_MouseEnter(sender As Object, e As EventArgs) Handles FilterBtn.MouseEnter
        FilterBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub FilterBtn_MouseLeave(sender As Object, e As EventArgs) Handles FilterBtn.MouseLeave
        FilterBtn.Image = My.Resources.generalBtn
    End Sub

    'load current user repositories
    Sub LoadUserRepository()
        folderListView.Items.Clear()
        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
        conn.Open()

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM [Table] WHERE file_uploader = @uploader"
        cmd.Parameters.AddWithValue("@uploader", GetUserID())

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader



        While dr.Read()
            Dim Item As New ListViewItem((dr.Item("file_id").ToString))
            Item.SubItems.Add(dr.Item("file_name").ToString)
            Item.SubItems.Add(dr.Item("isApproved").ToString)
            Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
            folderListView.Items.Add(Item)

        End While
    End Sub

    'filters approved/pending
    Private Sub FilterProjectStatus(status As String)
        Dim dateFilter As DateTime = DateFilterCb.Value

        folderListView.Items.Clear()

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\" & Environment.UserName & "\Desktop\Project-Repository\PRS\repoDB.mdf;Integrated Security=True"
            conn.Open()

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [Table] WHERE file_uploader = @uploader AND isApproved = @pStatus AND file_update = @date"
            cmd.Parameters.AddWithValue("@uploader", GetUserID())
            cmd.Parameters.AddWithValue("@pStatus", status)
            cmd.Parameters.AddWithValue("@date", dateFilter)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader



            While dr.Read()
                Dim Item As New ListViewItem((dr.Item("file_id").ToString))
                Item.SubItems.Add(dr.Item("file_name").ToString)
                Item.SubItems.Add(dr.Item("isApproved").ToString)
                Item.SubItems.Add(dr.Item("file_update").ToShortDateString)
                folderListView.Items.Add(Item)

            End While
        Catch ex As Exception
            ' DO Nothing when error
        End Try

    End Sub

    Private Sub CreateRepoBtn_Click(sender As Object, e As EventArgs) Handles CreateRepoBtn.Click
        Dim dt As Date = Date.UtcNow
        Dim fuid As Guid = Guid.NewGuid

        If fileBar.Text = "" Then
            MessageBox.Show("Please enter a respository name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf CheckDirectory(fileBar.Text) = False Then
            MessageBox.Show("Repository already exists, please create a new one.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LoadUserRepository()
        Else
            Me.FileDataTableAdapter.UploadFile(fuid, fileBar.Text, dt, GetUserID(), "pending", GetUsername())
            LoadUserRepository()
            SecondaryDirectory(fileBar.Text) 'create directory inside C:\Documents\Repositories
            fileBar.Clear()
        End If
    End Sub

    Private Sub FilterStatusBtn_Click(sender As Object, e As EventArgs) Handles FilterBtn.Click
        FilterProjectStatus(projectStatusFilter.SelectedItem)
    End Sub

    Private Sub browseFileBtn_Click(sender As Object, e As EventArgs) Handles browseFileBtn.Click
        Dim dir As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories"
        Dim repoDir As String = existRepoTb.Text
        If repoDir = "" Then
            MessageBox.Show("Please select an existing repository", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Directory.Exists(dir & "\" & repoDir) Then
                If Not File.Exists(dir & "\" & repoDir & "\README.md") = True Then
                    Dim file As FileStream
                    file = IO.File.Create(dir & "\" & repoDir & "\README.md")
                    file.Close()
                    MessageBox.Show("README.md file added in " & dir & "\" & repoDir, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                File.WriteAllText(dir & "\" & repoDir & "\README.md", "[Project-Repository] - SemiFinal Project")
            Else
                MessageBox.Show(dir & "\" & repoDir & " does not exists! " & vbCrLf & "Want me to create a new one?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If DialogResult.Yes Then
                    Directory.CreateDirectory(dir & "\" & repoDir)
                End If
            End If
        End If

    End Sub

    Private Sub folderListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles folderListView.SelectedIndexChanged
        If folderListView.SelectedItems.Count > 0 Then
            existRepoTb.Text = folderListView.SelectedItems(0).SubItems(1).Text
        End If
    End Sub
End Class
