Public Class frmPayments
    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Payment received for XYZ order/Invoice")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cbxPaymentMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPaymentMode.SelectedIndexChanged
        If cbxPaymentMode.SelectedText = "M-Pesa" Then
            MsgBox("Remember to record the M-Pesa Message ID at the beginning of the message.")
            txtTransactionID.Enabled = True
            Me.Refresh()
        End If
    End Sub
End Class