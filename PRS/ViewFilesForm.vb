Imports System.IO

Public Class ViewFilesForm

    Dim dirInfo As New DirectoryInfo("C:\Users\" & Environment.UserName & "\Documents\Repositories\" & GetFolderName())
    Dim fileInfo As FileInfo
    Dim arr(3) As String

    'execute code on form load'
    Private Sub ViewFilesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFiles()

    End Sub

#Region "Button Animations"
    Private Sub closeBtn_MouseEnter(sender As Object, e As EventArgs) Handles closeBtn.MouseEnter
        closeBtn.Image = My.Resources.closeBtnHover
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.Image = My.Resources.closeBtn
    End Sub

    Private Sub minimizeBtn_MouseEnter(sender As Object, e As EventArgs) Handles minimizeBtn.MouseEnter
        minimizeBtn.Image = My.Resources.minimizeBtnHover
    End Sub

    Private Sub minimizeBtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizeBtn.MouseLeave
        minimizeBtn.Image = My.Resources.minimizeBtn
    End Sub
#End Region

#Region "Function Buttons"
    Private Sub viewFileBtn_Click(sender As Object, e As EventArgs) Handles viewFileBtn.Click
        Try
            Dim file As String = FileView.SelectedItems(0).SubItems(0).Text
            Dim dir As String = dirInfo.ToString & "\"

            viewTextFileBox.Text = My.Computer.FileSystem.ReadAllText(dir & file)
        Catch ex As Exception
            MessageBox.Show("Item is not readable!" & vbCrLf & "Possible cause of error:" & vbCrLf & "1) No item was selected" & vbCrLf & "2) Item selected is a directory" & vbCrLf & "3) Item selected is not a readable file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub downloadBtn_Click(sender As Object, e As EventArgs) Handles downloadBtn.Click
        Dim mainDir As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories"
        Dim downloadDir As String = "C:\Users\" & Environment.UserName & "\Documents\DownloadedRepositories"
        Dim repoDir As String = GetFolderName()
        Dim newDir As String = downloadDir & "\" & repoDir
        Try
            If Directory.Exists(downloadDir) Then
                If Directory.Exists(newDir) Then
                    My.Computer.FileSystem.CopyDirectory(mainDir & "\" & repoDir, newDir)
                    MessageBox.Show("File Downloaded.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    My.Computer.FileSystem.CopyDirectory(mainDir & "\" & repoDir, newDir)
                    MessageBox.Show("File Downloaded.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(downloadDir & "\" & " does not exists!" & vbCrLf & "Want me to create " & downloadDir & "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If DialogResult.Yes Then
                    Directory.CreateDirectory(downloadDir)
                ElseIf DialogResult.No Then

                End If
            End If
        Catch ex As Exception
            MsgBox("File Updated.")
        End Try
    End Sub

    Private Sub openDirBtn_Click(sender As Object, e As EventArgs) Handles openDirBtn.Click

        Try
            Dim fdir As String = FileView.SelectedItems(0).SubItems(0).Text
            Dim subInfo As New DirectoryInfo(dirInfo.ToString & "\" & fdir)
            Dim isDir As String = FileView.SelectedItems(0).SubItems(1).Text

            If isDir = "Directory" Then

                FileView.Items.Clear()

                arr(0) = ".."
                arr(1) = ""
                arr(2) = ""
                Dim backDir As New ListViewItem(arr)
                FileView.Items.Add(backDir)

                For Each folderInfo In subInfo.GetDirectories()

                    arr(0) = folderInfo.Name
                    arr(1) = "Directory"

                    Dim li As New ListViewItem(arr)

                    FileView.Items.Add(li)
                Next

                For Each fileInfo In subInfo.GetFiles("*.*")

                    Dim fSize As Long = fileInfo.Length

                    arr(0) = fileInfo.Name
                    arr(1) = fileInfo.Extension
                    arr(2) = fSize & " Bytes"

                    Dim li As New ListViewItem(arr)

                    FileView.Items.Add(li)
                Next
            ElseIf fdir = ".." Then
                FileView.Items.Clear()

                LoadFiles()
            Else
                MessageBox.Show("Item selected is not a directory", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("No directory was selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#Region "Methods"
    Private Sub LoadFiles()
        Label2.Text = GetFolderName()

        For Each folderInfo In dirInfo.GetDirectories()

            arr(0) = folderInfo.Name
            arr(1) = "Directory"

            Dim li As New ListViewItem(arr)

            FileView.Items.Add(li)
        Next

        For Each fileInfo In dirInfo.GetFiles("*.*")

            Dim fSize As Long = fileInfo.Length

            arr(0) = fileInfo.Name
            arr(1) = fileInfo.Extension
            arr(2) = fSize & " Bytes"

            Dim li As New ListViewItem(arr)

            FileView.Items.Add(li)
        Next
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub
#End Region

End Class