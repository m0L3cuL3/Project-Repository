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
        MessageBox.Show("File approved. Please refresh the page", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class
