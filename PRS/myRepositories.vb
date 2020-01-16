Imports System.IO

Public Class myRepositories

    'executes code on form load'
    Private Sub myRepositories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrives()
        customDirTb.ReadOnly = True
        MessageBox.Show(SystemInformation.UserName)
    End Sub

    Private Sub selectBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRuploadBtn.MouseEnter
        MRuploadBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub selectBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRuploadBtn.MouseLeave
        MRuploadBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub MRcopyBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRcopyBtn.MouseEnter
        MRcopyBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub MRcopyBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRcopyBtn.MouseLeave
        MRcopyBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub MRdeleteBtn_MouseEnter(sender As Object, e As EventArgs) Handles MRdeleteBtn.MouseEnter
        MRdeleteBtn.Image = My.Resources.logoutBtnHover 'i use log out button because iz red. communism
    End Sub

    Private Sub MRdeleteBtn_MouseLeave(sender As Object, e As EventArgs) Handles MRdeleteBtn.MouseLeave
        MRdeleteBtn.Image = My.Resources.logoutBtn 'i use log out button because iz red. communism
    End Sub

    'loads main drives of the system
    Public Sub LoadDrives()
        For Each drive As DriveInfo In DriveInfo.GetDrives
            Dim node As New TreeNode(drive.Name)
            With node
                .Tag = drive.Name
                .ImageKey = "folder"
                .ImageIndex = 4
                .SelectedImageKey = "folder"
                .Nodes.Add("Empty")
            End With

            MRtreeView.Nodes.Add(node)
        Next
    End Sub

    'loads subfolders of main drives'
    Public Sub LoadChildren(nd As TreeNode, dir As String)
        Dim DirectoryInformation As New DirectoryInfo(dir)

        folderListView.Items.Clear()
        Dim SubItems() As ListViewItem.ListViewSubItem
        Dim Item As ListViewItem = Nothing

        Try
            'load all subfolders into node'
            For Each d As DirectoryInfo In DirectoryInformation.GetDirectories
                If Not (d.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    If Not (d.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                        Dim folder As New TreeNode(d.Name)

                        With folder
                            .Tag = d.FullName
                            .ImageKey = "folder"
                            .SelectedImageKey = "folder"
                            .Nodes.Add("*Empty*")
                        End With

                        nd.Nodes.Add(folder)

                        Item = New ListViewItem(d.Name, 4)
                        SubItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(Item, 0), New ListViewItem.ListViewSubItem(Item, "Directory"), New ListViewItem.ListViewSubItem(Item, d.LastAccessTime.ToShortDateString())}

                        Item.SubItems.AddRange(SubItems)
                        folderListView.Items.Add(Item)
                    End If
                End If
            Next

            'load all files in child nodes'
            For Each file As FileInfo In DirectoryInformation.GetFiles
                If Not (file.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    Dim FN As New TreeNode(file.Name)
                    With FN
                        .Tag = file.FullName
                        .ImageKey = "file"
                        .SelectedImageKey = "file"
                    End With
                    nd.Nodes.Add(FN)

                    Dim file_type As String = "File"

                    Select Case file.FullName.Split(".").LastOrDefault().ToLower()
                        'System Files
                        Case "dll"
                            file_type = "Dynamic Link Library"
                        Case "sys"
                            file_type = "System File"
                        Case "exe"
                            file_type = "Executable"
                        Case "jar"
                            file_type = "Executable"
                        Case "dat"
                            file_type = "Data File"

                        Case "ini"
                            file_type = "INI File"
                        Case "bat"
                            file_type = "Batch File"
                        Case "cmd"
                            file_type = "Command File"

                        'Text Files
                        Case "txt"
                            file_type = "Document"
                        Case "html"
                            file_type = "Document"
                        Case "css"
                            file_type = "Document"
                        Case "rtf"
                            file_type = "Document"
                        Case "text"
                            file_type = "Document"
                        Case "log"
                            file_type = "Document"
                        Case "yml"
                            file_type = "Document"
                        Case "xml"
                            file_type = "Document"

                        'Compression Formats
                        Case "zip"
                            file_type = "Compressed File"
                        Case "rar"
                            file_type = "Compressed File"
                        Case "7z"
                            file_type = "Compressed File"
                        Case "pak"
                            file_type = "Compressed File"
                        Case "rpf"
                            file_type = "Compressed File"

                        'Image Formats
                        Case "bin"
                            file_type = "System Image"
                        Case "iso"
                            file_type = "System Image"
                        Case "img"
                            file_type = "System Image"
                        Case "dmg"
                            file_type = "System Image"

                        'Picture Formats
                        Case "bmp"
                            file_type = "Image"
                        Case "jpg"
                            file_type = "Image"
                        Case "png"
                            file_type = "Image"
                        Case "gif"
                            file_type = "Image"
                        Case "tiff"
                            file_type = "Image"
                        Case "jpeg"
                            file_type = "Image"
                        Case "ico"
                            file_type = "Image"
                        Case "jfif"
                            file_type = "Image"

                        'Video Formats
                        Case "mp4"
                            file_type = "Video"
                        Case "webm"
                            file_type = "Video"
                        Case "3gp"
                            file_type = "Video"
                        Case "m4v"
                            file_type = "Video"
                        Case "flv"
                            file_type = "Video"
                        Case "mpeg"
                            file_type = "Video"
                        Case "mpe"
                            file_type = "Video"
                        Case "mov"
                            file_type = "Video"
                        Case "swf"
                            file_type = "Video"
                        Case "wmv"
                            file_type = "video"

                        'Music Formats
                        Case "mp1"
                            file_type = "Music"
                        Case "mp2"
                            file_type = "Music"
                        Case "mp3"
                            file_type = "Music"
                        Case "mp4"
                            file_type = "Music"
                        Case "wav"
                            file_type = "Music"
                        Case "m4a"
                            file_type = "Music"
                        Case "flac"
                            file_type = "Music"
                        Case "wma"
                            file_type = "Music"
                        Case "ogg"
                            file_type = "Music"

                        'Font Formats
                        Case "ttf"
                            file_type = "Font File"
                        Case "ufo"
                            file_type = "Font File"
                        Case "fnt"
                            file_type = "Font File"
                        Case Else
                            file_type = "File"
                    End Select

                    Item = New ListViewItem(file.Name)

                    Dim filesize As String = (file.Length / 1000000).ToString("N0") + " Mb"

                    SubItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(Item, filesize.ToString), New ListViewItem.ListViewSubItem(Item, file_type.ToString()), New ListViewItem.ListViewSubItem(Item, file.LastAccessTime.ToShortDateString())}

                    Item.SubItems.AddRange(SubItems)
                    folderListView.Items.Add(Item)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub MRtreeView_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles MRtreeView.BeforeExpand
        Dim IsDriveReady As Boolean = (From d As DriveInfo In DriveInfo.GetDrives Where d.Name = e.Node.Tag Select d.IsReady).FirstOrDefault()

        If (e.Node.Tag <> "Desktop" AndAlso Not e.Node.Tag.Contains(":\")) OrElse IsDriveReady OrElse Directory.Exists(e.Node.Tag) Then
            e.Node.Nodes.Clear()
            LoadChildren(e.Node, e.Node.Tag.ToString)

        ElseIf e.Node.ImageKey = "Desktop" Then
            e.Node.Nodes.Clear()

            Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)
            Dim UserDesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            LoadChildren(e.Node, UserDesktopFolder)
            LoadChildren(e.Node, DesktopFolder)
        Else
            e.Cancel = True
            MessageBox.Show("Error drive is empty, " + e.Node.ImageKey.ToString())
        End If
    End Sub

    Private Sub MRtreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MRtreeView.AfterSelect
        currDirTb.Text = e.Node.Tag.ToString()
    End Sub

    Private Sub MRtreeView_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles MRtreeView.AfterCollapse
        e.Node.Nodes.Clear()
        e.Node.Nodes.Add("Empty")
    End Sub

    Private Sub MRtreeView_DoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles MRtreeView.NodeMouseDoubleClick
        If e.Button = MouseButtons.Left AndAlso File.Exists(e.Node.Tag.ToString) Then
            Try
                Process.Start(e.Node.Tag.ToString())
            Catch ex As Exception
                ex = Nothing
            End Try
        End If
    End Sub

    Private Sub MRtreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles MRtreeView.NodeMouseClick
        Dim DirectoryInformation As New DirectoryInfo(e.Node.Tag.ToString())

        folderListView.Items.Clear()
        Dim SubItems() As ListViewItem.ListViewSubItem
        Dim Item As ListViewItem = Nothing

        Try
            'Load all sub folders into the node
            For Each d As DirectoryInfo In DirectoryInformation.GetDirectories

                If Not (d.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    Item = New ListViewItem(d.Name, 4)
                    SubItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(Item, 0), New ListViewItem.ListViewSubItem(Item, "Directory"), New ListViewItem.ListViewSubItem(Item, d.LastAccessTime.ToShortDateString())}

                    Item.SubItems.AddRange(SubItems)
                    folderListView.Items.Add(Item)
                End If

            Next

            'load all files into the child nodes
            For Each file As FileInfo In DirectoryInformation.GetFiles
                If Not (file.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    Dim file_type As String = "File"

                    Select Case file.FullName.Split(".").LastOrDefault().ToLower()
                        'System Files
                        Case "dll"
                            file_type = "Dynamic Link Library"
                        Case "sys"
                            file_type = "System File"
                        Case "exe"
                            file_type = "Executable"
                        Case "jar"
                            file_type = "Executable"
                        Case "dat"
                            file_type = "Data File"

                        Case "ini"
                            file_type = "INI File"
                        Case "bat"
                            file_type = "Batch File"
                        Case "cmd"
                            file_type = "Command File"

                        'Text Files
                        Case "txt"
                            file_type = "Document"
                        Case "html"
                            file_type = "Document"
                        Case "css"
                            file_type = "Document"
                        Case "rtf"
                            file_type = "Document"
                        Case "text"
                            file_type = "Document"
                        Case "log"
                            file_type = "Document"
                        Case "yml"
                            file_type = "Document"
                        Case "xml"
                            file_type = "Document"

                        'Compression Formats
                        Case "zip"
                            file_type = "Compressed File"
                        Case "rar"
                            file_type = "Compressed File"
                        Case "7z"
                            file_type = "Compressed File"
                        Case "pak"
                            file_type = "Compressed File"
                        Case "rpf"
                            file_type = "Compressed File"

                        'Image Formats
                        Case "bin"
                            file_type = "System Image"
                        Case "iso"
                            file_type = "System Image"
                        Case "img"
                            file_type = "System Image"
                        Case "dmg"
                            file_type = "System Image"

                        'Picture Formats
                        Case "bmp"
                            file_type = "Image"
                        Case "jpg"
                            file_type = "Image"
                        Case "png"
                            file_type = "Image"
                        Case "gif"
                            file_type = "Image"
                        Case "tiff"
                            file_type = "Image"
                        Case "jpeg"
                            file_type = "Image"
                        Case "ico"
                            file_type = "Image"
                        Case "jfif"
                            file_type = "Image"

                        'Video Formats
                        Case "mp4"
                            file_type = "Video"
                        Case "webm"
                            file_type = "Video"
                        Case "3gp"
                            file_type = "Video"
                        Case "m4v"
                            file_type = "Video"
                        Case "flv"
                            file_type = "Video"
                        Case "mpeg"
                            file_type = "Video"
                        Case "mpe"
                            file_type = "Video"
                        Case "mov"
                            file_type = "Video"
                        Case "swf"
                            file_type = "Video"
                        Case "wmv"
                            file_type = "video"

                        'Music Formats
                        Case "mp1"
                            file_type = "Music"
                        Case "mp2"
                            file_type = "Music"
                        Case "mp3"
                            file_type = "Music"
                        Case "mp4"
                            file_type = "Music"
                        Case "wav"
                            file_type = "Music"
                        Case "m4a"
                            file_type = "Music"
                        Case "flac"
                            file_type = "Music"
                        Case "wma"
                            file_type = "Music"
                        Case "ogg"
                            file_type = "Music"

                        'Font Formats
                        Case "ttf"
                            file_type = "Font File"
                        Case "ufo"
                            file_type = "Font File"
                        Case "fnt"
                            file_type = "Font File"
                        Case Else
                            file_type = "File"
                    End Select

                    Item = New ListViewItem(file.Name)

                    Dim filesize As String = (file.Length / 1000000).ToString("N0") + " Mb"

                    SubItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(Item, filesize.ToString), New ListViewItem.ListViewSubItem(Item, file_type.ToString()), New ListViewItem.ListViewSubItem(Item, file.LastAccessTime.ToShortDateString())}

                    Item.SubItems.AddRange(SubItems)
                    folderListView.Items.Add(Item)
                End If
            Next
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    'for copying file to different location'
    Private Sub MRcopyBtn_Click(sender As Object, e As EventArgs) Handles MRcopyBtn.Click
        Try
            If presetCb.SelectedItem = Nothing Then
                MessageBox.Show("Please select preset destinations.")
            ElseIf presetCb.SelectedItem = "C:/Desktop" Then
                customDirTb.ReadOnly = True
                Dim result As Integer = MessageBox.Show("Are you sure you would like to copy this file or folder in " & presetCb.SelectedItem.ToString & "?", "Are you sure?", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.CopyDirectory(MRtreeView.SelectedNode.ImageKey.ToString(), "C:/User/" & SystemInformation.UserName & "/Desktop")
                End If

            ElseIf presetCb.SelectedItem = "C:/My Documents" Then
                customDirTb.ReadOnly = True
                Dim result As Integer = MessageBox.Show("Are you sure you would like to copy this file or folder in " & presetCb.SelectedItem.ToString & "?", "Are you sure?", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.CopyDirectory(MRtreeView.SelectedNode.ImageKey.ToString(), "C:/User/" & SystemInformation.UserName & "/Documents")
                End If
            ElseIf presetCb.SelectedItem = "- Use Custom Directory -" Then
                customDirTb.ReadOnly = False
                If customDirTb.Text = "" Then
                    MessageBox.Show("Enter file destination please.")
                Else
                    My.Computer.FileSystem.CopyDirectory(MRtreeView.SelectedNode.ImageKey.ToString(), customDirTb.Text)
                End If
            End If
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub
End Class
