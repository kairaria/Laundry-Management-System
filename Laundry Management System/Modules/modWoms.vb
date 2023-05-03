Module modWoms
    Public CheckCustomer, NewWorkOrder, NewWorkOrderItem, WorkOrderPickup, AdminMode, ReportViewer As Boolean
    Public connStr As String = "Database=gaillard_woms;Data Source=127.0.0.1;User Id=root;Password=Allblacks@7;Allow User Variables=True;"


    Public Function SetAdminMode(b As Boolean) As Boolean
        If b Then
            AdminMode = True
            ReportViewer = True
            frmMain.EditWorkOrderToolStripMenuItem.Enabled = True
            Return True
        Else
            AdminMode = False
            ReportViewer = False
            frmMain.EditWorkOrderToolStripMenuItem.Enabled = False
            Return False
        End If
    End Function
End Module
