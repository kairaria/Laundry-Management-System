Imports MySql.Data.MySqlClient


Module ConnDb

    Public connStr As String = "Database=gaillard_woms;Data Source=127.0.0.1;User Id=root;Password=Allblacks@7;Allow User Variables=True;"
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

End Module

