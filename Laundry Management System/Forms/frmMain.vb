Public Class frmMain

    Private WithEvents mdiContainer As MdiClient

    Sub MDIBGColor()
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Controls
            Try

                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIBGColor()
        For Each ctl As Control In Controls
            If TypeOf ctl Is MdiClient Then
                mdiContainer = DirectCast(ctl, MdiClient)
                Exit For
            End If
        Next
        LogOutToolStripMenuItem.Enabled = False
        AdminMode = False
        NewWorkOrder = False
        WorkOrderPickup = False

    End Sub

    Private Sub NewWorkOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWorkOrderToolStripMenuItem.Click
        CheckCustomer = True
        NewWorkOrder = True
        NewWorkOrderItem = True
        frmWorkOrder.Show()
        frmWorkOrder.Activate()
    End Sub

    Private Sub EditWorkOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditWorkOrderToolStripMenuItem.Click
        CheckCustomer = True
        NewWorkOrder = False
        NewWorkOrderItem = False
        frmWorkOrder.Show()
        frmWorkOrder.Activate()
    End Sub

    Private Sub RegisterPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterPaymentToolStripMenuItem.Click
        frmPayments.Show()
        frmPayments.Activate()
    End Sub

    Private Sub RegisterExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterExpenseToolStripMenuItem.Click
        frmExpenses.Show()
        frmExpenses.Activate()
    End Sub

    Private Sub WorkOrderPickupDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkOrderPickupDeliveryToolStripMenuItem.Click
        CheckCustomer = True
        NewWorkOrder = False
        NewWorkOrderItem = False
        WorkOrderPickup = True
        frmWorkOrder.Show()
        frmWorkOrder.Activate()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        If AdminMode = False Then
            frmLogin.Show()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If AdminMode = True Then
            MsgBox("Confirm you want to log off Admin/Reportviewer Mode.", MsgBoxStyle.YesNo, "Exit Admin/ReportViewer Mode")
            If MsgBoxResult.Yes Then
                SetAdminMode(False)
                LogOutToolStripMenuItem.Enabled = False
            ElseIf MsgBoxResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        If ReportViewer = False Then
            frmLogin.Show()
        End If
    End Sub
End Class