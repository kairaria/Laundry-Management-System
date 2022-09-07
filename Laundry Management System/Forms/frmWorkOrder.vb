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
End Class