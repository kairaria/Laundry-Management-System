Imports MySql.Data.MySqlClient

Public Class frmPayments

    Public WorkOrderIdFromWorkOrder As Integer
    Private WorkOrderId As Integer

    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain

        If WorkOrderIdFromWorkOrder <> 0 Then
            txtSearch.Text = WorkOrderIdFromWorkOrder
            LoadPaymentDetails(WorkOrderIdFromWorkOrder)
            txtWorkOrder.Text = WorkOrderIdFromWorkOrder
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case WorkOrderIdFromWorkOrder
            Case Is <> 0
                WorkOrderId = WorkOrderIdFromWorkOrder
                MsgBox(SaveNewPayment(WorkOrderId) & " payment recorded.", MsgBoxStyle.Information)
            Case Else
                WorkOrderId = CInt(txtWorkOrder.Text)
                MsgBox(SaveNewPayment(WorkOrderId) & " payment recorded.", MsgBoxStyle.Information)
        End Select

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cbxPaymentMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPaymentMode.SelectedIndexChanged
        Select Case cbxPaymentMode.Text
            Case "M-Pesa"
                MsgBox("Remember to record the M-Pesa Message ID at the beginning of the message.")
                txtTransactionID.Enabled = True
                Refresh()
            Case Else
                txtTransactionID.Enabled = False
        End Select
    End Sub

    Sub LoadPaymentDetails(searchString As String)
        'Clear the Datagrid first
        dgvPayments.DataSource = Nothing
        dgvPayments.Rows.Clear()

        Dim query As String
        Try
            searchString = searchString.ToLower
            'query = "Select custID ID,name 'Name',phone 'Phone Number' from customer where (phone like '%" & searchString & "%' OR lower(name) like lower('%" & searchString & "%') OR custId = '" & searchString & "') AND valid = 1 order by name ASC"
            query = "Select w.workorderId 'Order Num.', w.datecreated 'Order Date', c.name 'Name', c.phone 'Phone',SUM(wi.charge) 'Total Charge', i.invoice_no 'Invoice No', i.datecreated 'Invoice Date', i.amount 'Invoice Amount', pr.`mode` 'Payment Mode', pr.reference 'Transaction ID', pr.amount 'Payment Amount', SUM(wi.charge) - SUM(pr.amount) 'Amount Due'
                from workorder w
                LEFT JOIN invoice i ON (i.workorderId = w.workorderId) AND (i.valid = 1)
                LEFT JOIN customer c ON (c.custID = w.customerid) AND (c.valid = 1)
                LEFT JOIN payment_received pr ON (pr.workorderid = w.workorderId) OR (pr.invoice_no = i.invoice_no) AND (pr.valid = 1)
                LEFT JOIN workorderitem wi ON (wi.workorderId = w.workorderId) AND (wi.valid = 1)
                where (c.phone like '%" & searchString & "%' OR lower(c.name) like '%" & searchString & "%' OR w.workorderId = '" & searchString & "' OR i.invoice_no like '%" & searchString & "%') AND w.valid = 1 
                    GROUP BY w.workorderId
                order by w.workorderId, i.invoiceId, c.custID, pr.payId ASC;"

            Dim da As New MySqlDataAdapter(query, connection)
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvPayments.DataSource = ds.Tables(0)

            Else
                MsgBox("Please SEARCH WITH A DIFFERENT name OR phone number OR invoice no. OR work order no. .", MsgBoxStyle.Exclamation)
            End If

            'Clean Up
            ds.Dispose()
            da.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            connection.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchString As String = txtSearch.Text
        LoadPaymentDetails(searchString)
    End Sub

    Function SaveNewPayment(WorkOrderID As String) As String
        Try
            Return UpdateRecord("INSERT INTO payment_received (workorderid,mode,reference,amount,invoice_no) VALUES ('" & WorkOrderID & "', '" & cbxPaymentMode.Text & "', '" & txtTransactionID.Text & "','" & txtAmount.Text & "','" & txtInvoiceNum.Text & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Private Sub txtWorkOrder_TextChanged(sender As Object, e As EventArgs) Handles txtWorkOrder.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtWorkOrder.Text, "[^ 0-9]") Then
            txtWorkOrder.Text = ""
        End If
    End Sub

    Private Sub txtWorkOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWorkOrder.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "[^ 0-9]") Then
            txtAmount.Text = ""
        End If
    End Sub

    Private Sub dgvPayments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayments.CellContentClick
        txtSearch.Text = ""
        txtWorkOrder.Text = IIf(dgvPayments.CurrentRow.Cells(0).Value.ToString.Length = 0, 0, CInt(dgvPayments.CurrentRow.Cells(0).Value))
        WorkOrderId = CInt(txtWorkOrder.Text)
        txtInvoiceNum.Text = IIf(dgvPayments.CurrentRow.Cells(5).Value.ToString.Length = 0, String.Empty, CInt(dgvPayments.CurrentRow.Cells(5).Value))
        cbxPaymentMode.SelectedText = IIf(dgvPayments.CurrentRow.Cells(8).Value.ToString.Length = 0, cbxPaymentMode.Items(0).ToString, dgvPayments.CurrentRow.Cells(8).Value.ToString)
        txtTransactionID = IIf(dgvPayments.CurrentRow.Cells(9).Value.ToString.Length = 0, String.Empty, dgvPayments.CurrentRow.Cells(9).Value.ToString)
        txtAmount = IIf(dgvPayments.CurrentRow.Cells(4).Value.ToString.Length = 0, 0, CInt(dgvPayments.CurrentRow.Cells(4).Value))
    End Sub
End Class