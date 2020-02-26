Imports System.IO

Public Class projectPanel

    Private Sub projectPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub downloadBtn_MouseEnter(sender As Object, e As EventArgs) Handles downloadBtn.MouseEnter
        downloadBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub downloadBtn_MouseLeave(sender As Object, e As EventArgs) Handles downloadBtn.MouseLeave
        downloadBtn.Image = My.Resources.generalBtn
    End Sub

    Private Sub approveBtn_MouseEnter(sender As Object, e As EventArgs) Handles approveBtn.MouseEnter
        approveBtn.Image = My.Resources.generalBtnHover
    End Sub

    Private Sub approveBtn_MouseLeave(sender As Object, e As EventArgs) Handles approveBtn.MouseLeave
        approveBtn.Image = My.Resources.generalBtn
    End Sub

    'approve button
    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        Dim fuid As New Guid(guidLabel.Text)
        Me.FileDataTableAdapter.ApproveFile("approved", fuid)
    End Sub

    Private Sub downloadBtn_Click(sender As Object, e As EventArgs) Handles downloadBtn.Click '
        Dim mainDir As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories"
        Dim downloadDir As String = "C:\Users\" & Environment.UserName & "\Documents\DownloadedRepositories"
        Dim repoDir As String = projectTitle.Text
        Dim newDir As String = downloadDir & "\" & repoDir
        Try
            If Directory.Exists(downloadDir) Then
                If Directory.Exists(newDir) Then
                    My.Computer.FileSystem.CopyDirectory(mainDir & "\" & repoDir, newDir)
                Else
                    MessageBox.Show(newDir & " does not exists!" & vbCrLf & "Want me to create one and store it there?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If DialogResult.Yes Then
                        Directory.CreateDirectory(newDir)
                    End If
                    My.Computer.FileSystem.CopyDirectory(mainDir & "\" & repoDir, newDir)
                End If
            Else
                MessageBox.Show(downloadDir & "\" & " does not exists!" & vbCrLf & "Want me to create " & downloadDir & "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If DialogResult.Yes Then
                    Directory.CreateDirectory(downloadDir)
                End If
            End If
        Catch ex As Exception
            MsgBox("Repository already exists!")
        End Try

    End Sub
End Class
