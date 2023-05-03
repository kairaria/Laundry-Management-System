Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Module gaillard
    Public ImgFilePath As String
    Public uname As String = ""
    Public xpos As New Integer
    Public ypos As New Integer
    Public pos As New Point
    Public datefrom, dateto As Date
    'Public appstart As String = Application.StartupPath & "\img\"
    Public connection As New MySqlConnection(connStr)

    Public Function UpdateRecord(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()
            cmd.CommandType = CommandType.Text
            rowsEffected = cmd.ExecuteNonQuery()
            connection.Close()
            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
         Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Public Function GetFileName(ByVal ImgFilePath As String) As String
        Dim slashindex As Integer = ImgFilePath.LastIndexOf("\")
        Dim dotindex As Integer = ImgFilePath.LastIndexOf(".")
        GetFileName = ImgFilePath.Substring(slashindex + 1, dotindex - slashindex - 1)
    End Function
    Public Function GetVersion() As String
        Dim reader As XmlTextReader = New XmlTextReader("Negative Scanning.exe.manifest")
        Try
            Do While (reader.Read())
                Select Case reader.NodeType
                    Case XmlNodeType.Element 'Display beginning of element.
                        If reader.HasAttributes Then 'If attributes exist
                            While reader.MoveToNextAttribute()
                                If reader.Name = "version" Then
                                    Return "Ver. " & reader.Value
                                End If
                            End While
                        Else
                            Return "Could not Identify version"
                        End If
                End Select
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Could not Identify version"
        End Try
        Return "Ver. " & reader.Value
    End Function
    Public Function GetDirectoryName(ByVal ImgFilePath As String) As String
        Dim directoryPath As String = Path.GetDirectoryName(ImgFilePath)
        Dim parentName As String = Path.GetFileName(directoryPath)
        GetDirectoryName = parentName
    End Function
    Public Function GetDirectoryPath(ByVal ImgFilePath As String) As String
        Dim directoryName As String = Path.GetDirectoryName(ImgFilePath)
        GetDirectoryPath = directoryName
    End Function

End Module
