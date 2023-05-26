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
                MsgBox(SaveNewPayment(WorkOrderId) & " payment recorded.", MsgBoxStyle.Information)
        End Select
        LoadPaymentDetails(WorkOrderId)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        connection.Close()
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

            getAmountDue(WorkOrderId)

            query = "SELECT w.workorderId 'Order Num.', w.datecreated 'Order Date', c.name 'Name', c.phone 'Phone',p.datecreated 'Payment Date',p.`mode` 'Payment Mode',p.reference 'Mpesa Code', p.amount 'Payment Amount' FROM payment_received p
            LEFT JOIN workorder w ON w.workorderId = p.workorderid
            LEFT JOIN customer c ON c.custID = w.customerId
            WHERE (w.workorderId = '" & searchString & "') AND w.valid = 1;"

            Dim da As New MySqlDataAdapter(query, connection)
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvPayments.DataSource = ds.Tables(0)
                WorkOrderId = IIf(dgvPayments.Rows(0).Cells(0).Value.ToString.Length = 0, 0, CInt(dgvPayments.Rows(0).Cells(0).Value))

            Else
                MsgBox("No payment received for this work order no. .", MsgBoxStyle.Exclamation)
            End If

            'Clean Up
            ds.Dispose()
            da.Dispose()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub getAmountDue(woId As Integer)
        If WorkOrderId < 1 Then
            woId = txtSearch.Text 'IIf(dgvPayments.CurrentRow.Cells(0).Value.ToString.Length = 0, 0, CInt(dgvPayments.CurrentRow.Cells(0).Value))
        Else
            woId = WorkOrderId
        End If

        Dim query As String = "SELECT IFNULL(SUM(wi.charge),0)-IFNULL(px.TP,0) 'Amount Due' FROM workorderitem wi
                LEFT JOIN (SELECT DISTINCT p.workorderid, SUM(p.amount) 'TP' FROM payment_received p WHERE p.workorderid = '" & woId & "') px ON px.workorderid = wi.workorderId
                    WHERE wi.workorderId =  '" & woId & "';"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                txtAmountDue.Text = IIf(readah.IsDBNull(0), 0, readah.GetDouble(0))
            End While
            readah.Close()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchString As String = txtSearch.Text
        If searchString = "Enter WorkOrder ID here" Then MsgBox("Please SEARCH WITH A DIFFERENT work order no. .", MsgBoxStyle.Exclamation)
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