Imports System.IO.Directory

Module DataHandler

    'USERS'
    Dim uid As Long 'userid
    Dim username As String 'user
    Dim program As String 'course and year level
    Dim title As String

    'FILES'
    Dim file_id As Guid '

    'FILTERS'
    Dim dt As DateTime '

    'sets user id
    Public Sub SetUserID(userid As Long)
        uid = userid
    End Sub

    'get user id
    Public Function GetUserID()
        Return uid
    End Function

    'sets user name
    Public Sub SetUsername(user As String)
        username = user
    End Sub

    'get user name
    Public Function GetUsername()
        Return username
    End Function

    'sets course and year level
    Public Sub SetStudentProgram(s_course As String, s_level As String)
        program = s_course & "-" & s_level
    End Sub

    'sets title of instructor and head of department
    Public Sub SetTitle(mTitle As String)
        title = mTitle
    End Sub

    'get title of instructor/head of department
    Public Function GetTitle()
        Return title
    End Function

    'get course and year level
    Public Function GetStudentProgram()
        Return program
    End Function

    'sets file id
    Public Sub SetFileID(fid As Guid)
        file_id = fid
    End Sub

    'get file id
    Public Function GetFileID()
        Return file_id
    End Function

    'create directory if not exists (Main Storage Directory for Repositories)
    Public Sub MainDirectory()
        Dim directory As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories"
        If Not Exists(directory) Then
            CreateDirectory(directory)
        End If
    End Sub

    'create directory if not exists (Individual Storage Directory for Repositories)
    Public Sub SecondaryDirectory(folderName As String)
        Dim directory As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories\" & folderName
        If Not Exists(directory) Then
            CreateDirectory(directory)
        Else
            MsgBox("Repository already exists, Please create a new one.")
        End If
    End Sub

    Public Function CheckDirectory(folderName As String)
        Dim directory As String = "C:\Users\" & Environment.UserName & "\Documents\Repositories\" & folderName
        If Not Exists(directory) Then
            Return True 'if file does NOT exist
        Else
            Return False 'if file DOES exist
        End If
    End Function

    Public Sub ClearTextBoxes(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBoxes(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
End Module
