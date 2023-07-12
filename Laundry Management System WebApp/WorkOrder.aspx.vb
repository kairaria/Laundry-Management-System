Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class frmWorkOrder
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoadCboServiceItem()
        txtSearchCustomer.Enabled = True

        If NewWorkOrder Then
            btnSaveWorkOrder.Text = "Save and Print WorkOrder"
        ElseIf NewWorkOrder = False And WorkOrderPickup = False Then
            btnSaveWorkOrder.Text = "Update and Print WorkOrder"
            cbxAddNewCust.Enabled = False
        ElseIf WorkOrderPickup Then
            Dim WorkOrderItemPanel As Control = FindControl("pnWorkOrderItem")
            If WorkOrderItemPanel.Visible Then
                WorkOrderItemPanel.Visible = False
            End If
            cbxAddNewCust.Text = "Partial Collection?"
                btnSaveWorkOrder.Text = "Confirm Collection By Client"
            End If
            txtSearchCustomer.Focus()
    End Sub
    Private CustomerID, WorkOrderID, WorkOrderItemID, longpaper As Integer

    Private Sub CbxAddNewCust_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddNewCust.CheckedChanged
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Dispose()

        If Not cbxAddNewCust.Checked Then
            txtCustName.Enabled = False
            txtCustPhoneNum.Enabled = False
            txtSearchCustomer.Enabled = True
            btnAddCustomer.Visible = False
            btnSearchCustomer.Visible = True
            txtSearchCustomer.Text = "Search By Name or Phone Number"
            CheckCustomer = False
        Else
            txtCustName.Enabled = True
            txtCustPhoneNum.Enabled = True
            txtSearchCustomer.Enabled = False
            btnAddCustomer.Visible = True
            btnSearchCustomer.Visible = False
            txtSearchCustomer.Text = ""
            CheckCustomer = True
        End If
    End Sub

    Sub LoadCboServiceItem()
        Dim query As String = "SELECT serviceitemName,price,serviceItemID from serviceitem WHERE valid = 1;"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read
                cboServiceItem.Items.Add(New cboServiceItemValues(
                                         IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0)),
                                         IIf(readah.IsDBNull(1), 0, readah.GetDouble(1)),
                                         IIf(readah.IsDBNull(2), 0, readah.GetDouble(2))))
            End While
            readah.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            connection.Close()
            Exit Sub
        End Try

    End Sub
    Function AddNewCustomer(name As String, phone As String)
        Dim query As String = "SELECT custId from customer WHERE phone like '" & txtCustPhoneNum.Text & "'"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader

            Dim dt As DataTable = New DataTable()
            dt.Load(readah)
            Dim readahRows As Integer = dt.Rows.Count
            readah.Close()
            connection.Close()

            If readahRows > 0 Then
                MsgBox("There exists a customer with this Phone number. ", MsgBoxStyle.Information)
                Return 0
                Exit Function
            Else
                If txtCustName.Text IsNot "" And txtCustPhoneNum.Text IsNot "" Then
                    Return UpdateRecord("Insert INTO customer (name,phone) VALUES('" & name & "', '" & phone & "')")
                Else
                    Return 0
                    MsgBox("Customer Name or Phone Number Missing", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
            Exit Function
        End Try

    End Function

    Function SaveNewWorkOrder() As String
        Try
            Return UpdateRecord("INSERT INTO workorder (customerId) VALUES ('" & CustomerID & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try

    End Function

    Function SaveNewWorkOrderItem() As String
        Dim servicechargefactor As Integer
        Dim chargeFactor As Double

        If rdbRegular.Checked Then
            chargeFactor = 1
            servicechargefactor = 1
        ElseIf rdbPress.Checked Then
            chargeFactor = 0.5
            servicechargefactor = 2
        ElseIf rdbRepeatRegular.Checked Then
            chargeFactor = 0
            servicechargefactor = 3
        ElseIf rdbRepeatPress.Checked Then
            chargeFactor = 0
            servicechargefactor = 4
        End If

        Try
            Return UpdateRecord("INSERT INTO workorderitem (workorderid,serviceitemid,quantity,charge,comments,colour,servicechargefactor) VALUES ('" & WorkOrderID & "', '" & cboServiceItem.Items(cboServiceItem.SelectedIndex).ServiceItemID & "', '" & CInt(txtQuantity.Text) & "','" & CDbl(cboServiceItem.Items(cboServiceItem.SelectedIndex).ServiceItemPrice) * txtQuantity.Text * chargeFactor & "','" & txtComments.Text & "','" & txtColour.BackColor.ToArgb & "','" & servicechargefactor & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function UpdateWorkOrderItem(WorkOrderItemId As Integer) As String
        Dim chargeFactor, servicechargefactor As Integer

        If rdbRegular.Checked Then
            chargeFactor = 1
            servicechargefactor = 1
        ElseIf rdbPress.Checked Then
            chargeFactor = 0.5
            servicechargefactor = 2
        ElseIf rdbRepeatRegular.Checked Then
            chargeFactor = 0
            servicechargefactor = 3
        ElseIf rdbRepeatPress.Checked Then
            chargeFactor = 0
            servicechargefactor = 4
        End If

        Try
            Return UpdateRecord("UPDATE workorderitem SET serviceitemid = '" & cboServiceItem.Items(cboServiceItem.SelectedIndex).ServiceItemID & "',quantity = '" & txtQuantity.Text & "',charge = '" & CDbl(cboServiceItem.Items(cboServiceItem.SelectedIndex).ServiceItemPrice) * txtQuantity.Text * chargeFactor & "',comments = '" & txtComments.Text & "',colour='" & txtColour.BackColor.ToArgb & "',servicechargefactor='" & servicechargefactor & "' WHERE workorderitemid = '" & WorkOrderItemId & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Sub CollectWorkOrder(WorkOrderID As Integer)
        Try
            UpdateRecord("UPDATE workorder SET datecollected = now(), valid = 0 WHERE workorderid = '" & WorkOrderID & "'")
            MsgBox("Workorder: " & WorkOrderID & " has been collected by the client.")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Function ArchiveWorkOrderItem(WorkOrderItemId As Integer) As String
        Try
            Return UpdateRecord("UPDATE workorderitem SET valid = 0 WHERE workorderitemid = '" & WorkOrderItemId & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function ArchiveWorkOrder(WorkOrderId As Integer) As String
        Try
            Return UpdateRecord("UPDATE workorder SET valid = 0 WHERE workorderid = '" & WorkOrderId & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Sub ClearCustomerFields()
        txtCustName.Text = ""
        txtCustPhoneNum.Text = ""
        txtSearchCustomer.Text = ""
        CustomerID = 0
    End Sub

    Sub ClearWorkOrderItemFields()
        cboServiceItem.Text = ""
        txtQuantity.Text = ""
        txtComments.Text = ""
        WorkOrderItemID = 0
        txtColour.BackColor = Color.White
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        Dim SavedWorkOrderCount As Integer
        If WorkOrderID = 0 And NewWorkOrder = True Then 'Create new work order and assign items to it.
            SaveNewWorkOrder()
            WorkOrderID = GetMaxWorkOrderID(CustomerID) 'Because it will be the most lates WorkOrder cretaed for the client. However, as system grows what if the client has orders being input by several people at once?
            lblWorkOrderID.Text = "Order No: " & WorkOrderID
            SavedWorkOrderCount = SaveNewWorkOrderItem()
            If SavedWorkOrderCount > 0 Then
                MsgBox(SavedWorkOrderCount & " work order and service item Added.", MsgBoxStyle.Information)
            Else
                cboServiceItem.Select()
                Exit Sub
            End If

        ElseIf NewWorkOrderItem = True Then 'add a new service item to an existing order
            SavedWorkOrderCount = SaveNewWorkOrderItem()
            If SavedWorkOrderCount > 0 Then
                MsgBox(SavedWorkOrderCount & " service item Added.", MsgBoxStyle.Information)
            Else
                cboServiceItem.Select()
                Exit Sub
            End If
        ElseIf NewWorkOrderItem = False And WorkOrderItemID <> 0 Then 'Update the service item selected
            SavedWorkOrderCount = UpdateWorkOrderItem(WorkOrderItemID)
            If SavedWorkOrderCount > 0 Then
                MsgBox(SavedWorkOrderCount & " service item Updated.", MsgBoxStyle.Information)
                btnAddItem.Text = "Add WorkOrder Item"
            Else
                cboServiceItem.Select()
                Exit Sub
            End If
        End If

        NewWorkOrder = True
        NewWorkOrderItem = True
        ClearWorkOrderItemFields()
        LoadWorkOrderDetails(WorkOrderID)

    End Sub

    Private Function GetMaxWorkOrderID(CustomerID) As Integer
        Dim query As String = "SELECT Max(workorderId) FROM workorder WHERE customerId like '" & CustomerID & "' AND valid = 1"
        Dim command As New MySqlCommand(query, connection)
        Dim MaxWorkorderId As String = ""
        command.CommandTimeout = 0
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                MaxWorkorderId = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0))
            End While
            readah.Close()
            connection.Close()

            Return MaxWorkorderId

        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return 0
        End Try

    End Function

    Function getAmountDue(woId) As Integer
        Dim AmountDue As Double
        If WorkOrderID < 1 Then
            MsgBox("Select a WorkOrder.", MsgBoxStyle.Information)
            Exit Function
        Else
            woId = WorkOrderID
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
                AmountDue = IIf(readah.IsDBNull(0), 0, readah.GetDouble(0))
            End While
            readah.Close()
            connection.Close()
            Return AmountDue
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Exit Function
        End Try
    End Function


    Private Sub BtnDeleteWorkItem_Click(sender As Object, e As EventArgs) Handles btnDeleteWorkItem.Click
        If NewWorkOrderItem = False And WorkOrderItemID <> 0 Then 'Delete the service item selected
            MsgBox(ArchiveWorkOrderItem(WorkOrderItemID) & " service item deleted.", MsgBoxStyle.Information)
        End If

        NewWorkOrder = True
        NewWorkOrderItem = True
        ClearWorkOrderItemFields()
        LoadWorkOrderDetails(WorkOrderID)
    End Sub

    Private Sub BtnSaveWorkOrder_Click(sender As Object, e As EventArgs) Handles btnSaveWorkOrder.Click
        If WorkOrderPickup Then
            If getAmountDue(WorkOrderID) > 0 Then
                MsgBox("The workOrder still has pending Payment. Proceed to Capture payment.")
                frmPayments.WorkOrderIdFromWorkOrder = WorkOrderID
                frmPayments.Show()
            Else
                CollectWorkOrder(WorkOrderID)
            End If
            WorkOrderPickup = False
            Close()
            frmMain.Refresh()
        Else
            If WorkOrderID <> 0 Then
                If MsgBox("Proceed to receive payment for the laundry order?", MsgBoxStyle.YesNo, "Workorder No." & WorkOrderID & " has been recorded.") = vbYes Then
                    MsgBox("Proceed to Capture payment. WorkOrder Slip Printed")
                    frmPayments.WorkOrderIdFromWorkOrder = WorkOrderID
                    frmPayments.Show()
                Else
                    MsgBox("WorkOrder Slip Printed")
                End If
                Close()
                frmMain.Refresh()
                WorkOrderID = 0
                WorkOrderItemID = 0
            Else
                MsgBox("No workorder ID selected to save/print", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub BtnVoidWorkOrder_Click(sender As Object, e As EventArgs) Handles btnVoidWorkOrder.Click

        If WorkOrderID <> 0 And MsgBox("Do you want to cancel/delete this Laundry Workorder?", MsgBoxStyle.YesNo, "Cancel/Delete Workorder") = vbYes Then
            ArchiveWorkOrder(WorkOrderID)
            MsgBox("Workorder No. " & WorkOrderID & " has been Cancelled.")
        End If

        WorkOrderID = 0
        WorkOrderItemID = 0
        Close()
        frmMain.Refresh()
    End Sub

    Sub LoadCustomerDetails(searchString As String)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Dispose()

        Dim query As String
        Try
            searchString = searchString.ToLower
            query = "Select custID ID,name 'Name',phone 'Phone Number' from customer where (phone like '%" & searchString & "%' OR lower(name) like lower('%" & searchString & "%') OR custId = '" & searchString & "') AND valid = 1 order by name ASC"

            Dim da As New MySqlDataAdapter(query, connection)
            connection.Open()
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvWorkOrderItems.DataSource = ds.Tables(0)
                'dgvWorkOrderItems.Columns(0).Visible = False
                CheckCustomer = True
            Else
                MsgBox("The customer record does not exist in the database. Please SEARCH WITH A DIFFERENT name or phone number OR ADD THE CUSTOMER record to the database.", MsgBoxStyle.Exclamation)
            End If

            'Clean Up
            ds.Dispose()
            da.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try
        connection.Close()
    End Sub

    Sub LoadWorkOrders(custId As Integer)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Dispose()

        Dim query As String
        Try
            'If NewWorkOrderItem = False Then
            query = "Select workorderId 'Order Num.',datecreated 'Order Date' from workorder where customerId = '" & custId & "' AND valid = 1 order by workorderId ASC"
            Dim da As New MySqlDataAdapter(query, connection)
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvWorkOrderItems.DataSource = ds.Tables(0)

            Else
                MsgBox("The Work Order record does not exist in the database. Please review the search string used OR add the Work Order record to the database.", MsgBoxStyle.Exclamation)
            End If

            'Clean Up
            ds.Dispose()
            da.Dispose()
            connection.Close()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            connection.Close()
        End Try
    End Sub

    Sub LoadWorkOrderDetails(workorderId As Integer)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Dispose()

        Dim query As String
        Try
            If NewWorkOrderItem = True Or NewWorkOrderItem = False Then
                query = "SELECT woi.workorderid 'WorkOrder ID',woi.workorderitemid 'WorkOrderItem ID.',si.serviceitemName 'Service Item',woi.charge 'Charge',woi.quantity 'Quantity',woi.comments 'Comments',woi.colour 'Colour' from workorderitem woi LEFT JOIN serviceitem si ON si.serviceItemID = woi.serviceitemID WHERE woi.workorderid like '" & workorderId & "' AND woi.valid = 1 order by si.serviceitemName ASC;"
                Dim da As New MySqlDataAdapter(query, connection)
                da.GetFillParameters()
                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    'Load the Datagrid with the new dataset
                    dgvWorkOrderItems.DataSource = ds.Tables(0)
                    For i = 0 To dgvWorkOrderItems.Rows.Count - 1
                        dgvWorkOrderItems.Rows(i).Cells(6).Style.BackColor = Color.FromArgb(CInt(dgvWorkOrderItems.Rows(i).Cells(6).Value))
                        dgvWorkOrderItems.Rows(i).Cells(6).Style.ForeColor = Color.FromArgb(CInt(dgvWorkOrderItems.Rows(i).Cells(6).Value))
                    Next
                    'dgvWorkOrderItems.Columns(0).Visible = False
                    'dgvWorkOrderItems.Columns(1).Visible = False

                Else
                    MsgBox("The Work Order Item record does not exist in the database. Please review the search string used OR add the Work Order Item record to the database.", MsgBoxStyle.Exclamation)
                End If

                'Clean Up
                ds.Dispose()
                da.Dispose()
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            connection.Close()
        End Try
    End Sub

    Sub PopulateCustomerFields(recID As Integer)
        'Populate the CustName and Phone Number Fields
        Dim query As String = "SELECT custId,name,phone from customer WHERE custId like '" & recID & "' AND valid = 1"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                CustomerID = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0))
                txtCustName.Text = IIf(readah.IsDBNull(1), String.Empty, readah.GetString(1))
                txtCustPhoneNum.Text = IIf(readah.IsDBNull(2), String.Empty, readah.GetString(2))
                EndCustomerSelection()
            End While
            readah.Close()
            connection.Close()

            dgvWorkOrderItems.DataSource = Nothing
            dgvWorkOrderItems.Dispose()

        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Sub PopulateWorkOrderItemFields(workOrderItemId As Integer)
        Dim query As String = "SELECT woi.workorderid,woi.workorderitemid,si.serviceitemName,woi.charge,woi.quantity,woi.comments,woi.colour,woi.servicechargefactor from workorderitem woi LEFT JOIN serviceitem si ON si.serviceItemID = woi.serviceitemID WHERE woi.workorderitemid like '" & workOrderItemId & "' AND woi.valid = 1;"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            Dim servicechargefactor As Integer
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                WorkOrderID = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0))
                workOrderItemId = IIf(readah.IsDBNull(1), String.Empty, readah.GetString(1))
                cboServiceItem.Text = IIf(readah.IsDBNull(2), String.Empty, readah.GetString(2))
                txtQuantity.Text = IIf(readah.IsDBNull(4), String.Empty, readah.GetString(4))
                txtComments.Text = IIf(readah.IsDBNull(5), String.Empty, readah.GetString(5))
                lblWorkOrderID.Text = "Order No: " & WorkOrderID
                txtColour.BackColor = IIf(readah.IsDBNull(6), String.Empty, Color.FromArgb(readah.GetInt32(6)))
                servicechargefactor = IIf(readah.IsDBNull(7), 1, readah.GetInt32(7))

                If servicechargefactor = 1 Then
                    rdbRegular.Checked = True
                ElseIf servicechargefactor = 2 Then
                    rdbPress.Checked = True
                ElseIf servicechargefactor = 3 Then
                    rdbRepeatRegular.Checked = True
                ElseIf servicechargefactor = 4 Then
                    rdbRepeatPress.Checked = True
                End If

            End While
            readah.Close()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub BgvWorkOrderItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorkOrderItems.CellDoubleClick
        WorkOrderID = 0
        WorkOrderItemID = 0

        If CheckCustomer = True Then
            Dim currRecId As Integer = dgvWorkOrderItems.CurrentRow.Cells(0).Value
            PopulateCustomerFields(currRecId)
            'Now we are done with selecting/adding the customer. Switch the Grids Use to WorkOrder Items

            If NewWorkOrder = False Then
                LoadWorkOrders(CustomerID)
            Else
                pnWorkOrderItem.Enabled = True
            End If
        ElseIf NewWorkOrder = False Then
            WorkOrderID = CInt(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            LoadWorkOrderDetails(WorkOrderID)
            lblWorkOrderID.Text = "Order No: " & WorkOrderID
            NewWorkOrder = True
            NewWorkOrderItem = True
        ElseIf NewWorkOrder = True Then
            pnWorkOrderItem.Enabled = True
            WorkOrderID = CInt(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            WorkOrderItemID = CInt(dgvWorkOrderItems.CurrentRow.Cells(1).Value)
            PopulateWorkOrderItemFields(WorkOrderItemID)
            btnAddItem.Text = "Edit WorkOrder Item"
            NewWorkOrderItem = False
        End If

    End Sub
    Sub EndCustomerSelection()
        CheckCustomer = False
        'txtSearchCustomer.Enabled = False
        txtSearchCustomer.Visible = False
        btnSearchCustomer.Visible = False
        'cbxAddNewCust.Enabled = False
        cbxAddNewCust.Visible = False
        btnAddCustomer.Visible = False
        txtCustName.Enabled = False
        txtCustPhoneNum.Enabled = False
        txtSearchCustomer.Text = ""
        txtSearchCustomer.Visible = False

    End Sub

    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        LoadCustomerDetails(txtSearchCustomer.Text)
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Try
            Dim CustName, CustPhoneNumber As String
            CustName = txtCustName.Text
            CustPhoneNumber = txtCustPhoneNum.Text
            Dim NewCustCount As Integer = AddNewCustomer(CustName, CustPhoneNumber)
            If NewCustCount > 0 Then
                MsgBox(NewCustCount & " Customer added.", MsgBoxStyle.Information)
                LoadCustomerDetails(CustPhoneNumber)
                CustomerID = CInt(dgvWorkOrderItems.Rows(0).Cells(0).Value)
                PopulateCustomerFields(CustomerID)
                pnWorkOrderItem.Enabled = True
            Else
                txtCustPhoneNum.Text = ""
                txtCustPhoneNum.Select()
            End If


        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub TxtSearchCustomer_Enter(sender As Object, e As EventArgs) Handles txtSearchCustomer.Enter
        If txtSearchCustomer.Enabled = True AndAlso txtSearchCustomer.Text = "Search By Name or Phone Number" Then
            txtSearchCustomer.Text = ""
        End If
    End Sub

    Private Sub txtCustPhoneNum_TextChanged(sender As Object, e As EventArgs) Handles txtCustPhoneNum.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtCustPhoneNum.Text, "[^ 0-9]") Then
            txtCustPhoneNum.Text = ""
        End If
    End Sub

    Private Sub txtCustPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustPhoneNum.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^ 0-9]") Then
            txtQuantity.Text = ""
        End If
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgvWorkOrderItems.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub


    Sub Print_WorkOrder()
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub cboServiceItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServiceItem.SelectedIndexChanged
        If cboServiceItem.SelectedIndex = -1 Then Exit Sub
        If txtQuantity.Text = "" Then
            txtQuantity.Text = 1
        End If
    End Sub

    Private Sub rdbRepeatRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRepeatRegular.CheckedChanged
        If rdbRepeatRegular.Checked Then
            txtComments.AppendText(" Repeat Regular Service for an item from WorkOrder: ")
        End If
    End Sub

    Private Sub rdbRepeatPress_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRepeatPress.CheckedChanged
        If rdbRepeatPress.Checked Then
            txtComments.AppendText(" Repeat Press for an item from WorkOrder: ")
        End If
    End Sub


    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To dgvWorkOrderItems.RowCount - 1
            countprice = countprice + Val(dgvWorkOrderItems.Rows(rowitem).Cells(2).Value * dgvWorkOrderItems.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice
        Dim countqty As Long = 0
        For rowitem As Long = 0 To dgvWorkOrderItems.RowCount - 1
            countqty = countqty + dgvWorkOrderItems.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub

    'Private Sub BTREFRESH_Click(sender As Object, e As EventArgs) Handles BTREFRESH.Click
    '   dgvWorkOrderItems.AllowUserToAddRows = True
    'End Sub

End Class

Public Class cboServiceItemValues

    Private sItemName As String
    Private sPrice As Integer
    Private sId As Integer

    Public Sub New()
        sItemName = ""
        sPrice = 0
        sId = 0
    End Sub

    Public Sub New(ByVal s As String, ByVal p As Integer, ByVal i As Integer)
        sItemName = s
        sPrice = p
        sId = i
    End Sub

    Public Property ServiceItemName() As String
        Get
            Return sItemName
        End Get
        Set(ByVal sValue As String)
            sItemName = sValue
        End Set
    End Property

    Public Property ServiceItemPrice() As Integer
        Get
            Return sPrice
        End Get
        Set(ByVal iValue As Integer)
            sPrice = iValue
        End Set
    End Property

    Public Property ServiceItemID() As Integer
        Get
            Return sId
        End Get
        Set(ByVal iValue As Integer)
            sId = iValue
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return sItemName
    End Function

End Class