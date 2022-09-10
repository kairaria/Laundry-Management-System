Public Class frmWorkOrder
    Private Sub cbxAddNewCust_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddNewCust.CheckedChanged
        If cbxAddNewCust.Checked Then
            txtCustName.Enabled = True
            txtCustPhoneNum.Enabled = True
        Else
            txtCustName.Enabled = False
            txtCustPhoneNum.Enabled = False
        End If
    End Sub

    Private Sub frmWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        Me.Refresh()
        If NewWorkOrder.Equals(True) Then
            btnSaveWorkOrder.Text = "Save WorkOrder"
        Else
            If WorkOrderPickup.Equals(True) Then
                pnWorkOrderItem.Hide()
                cbxAddNewCust.Text = "Partial Collection?"
                btnSaveWorkOrder.Text = "Confirm Collection By Client"
            Else
                btnSaveWorkOrder.Text = "Edit WorkOrder"
            End If

        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        MsgBox("Item Added to Workorder XYZ")
    End Sub

    Private Sub btnDeleteWorkItem_Click(sender As Object, e As EventArgs) Handles btnDeleteWorkItem.Click
        MsgBox("Item deleted from workorder xyz")
    End Sub

    Private Sub btnSaveWorkOrder_Click(sender As Object, e As EventArgs) Handles btnSaveWorkOrder.Click
        MsgBox("WorkOrder Saved. Proceed to receive payment for the laundry order?", MsgBoxStyle.YesNo, "Exit / Void Workorder")
        If MsgBoxResult.Yes Then
            MsgBox("WorkOrder Slip Printed")
            frmPayments.Show()
            Me.Close()
        Else
            MsgBox("WorkOrder Slip Printed")
            Me.Close()
        End If
    End Sub

    Private Sub btnVoidWorkOrder_Click(sender As Object, e As EventArgs) Handles btnVoidWorkOrder.Click
        MsgBox("Do you want to void this Workorder?", MsgBoxStyle.YesNo, "Exit / Void Workorder")
        If MsgBoxResult.Yes Then
            MsgBox("Workorder has been Voided.")
            Me.Close()
        ElseIf MsgBoxResult.No Then
            Me.Close()
        End If

    End Sub


End Class