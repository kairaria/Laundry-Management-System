Public Class frmExpenses
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox(SaveNewExpense() & " expense recorded and saved.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cbxPaymentMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPaymentMode.SelectedIndexChanged
        If cbxPaymentMode.SelectedText = "M-Pesa" Then
            MsgBox("Remember to record the M-Pesa Message ID at the beginning of the message.")
            txtTransactionID.Enabled = True
            Me.Refresh()
        Else
            txtTransactionID.Enabled = False
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "[^ 0-9]") Then
            txtAmount.Text = ""
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Function SaveNewExpense() As String
        Try
            Return UpdateRecord("INSERT INTO expense_made (description,mode,reference,amount) VALUES ('" & txtExpenseDesc.Text & "', '" & cbxPaymentMode.Text & "', '" & txtTransactionID.Text & "','" & txtAmount.Text & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function
End Class