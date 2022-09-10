Module gaillard

    Public uname As String = ""
    Public sql As String
    Public cmd As OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public con As New OleDb.OleDbConnection
    Public xpos As New Integer
    Public ypos As New Integer
    Public pos As New Point
    Public datefrom As Date
    Public dateto As Date
    Public appstart As String = Application.StartupPath & "\img\"
    Public NewWorkOrder As Boolean
    Public WorkOrderPickup As Boolean


End Module
