Imports MySql.Data.MySqlClient

Public Class frmWorkOrder


    Private CustomerID, WorkOrderID, WorkOrderItemID As Integer

    Private Sub CbxAddNewCust_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddNewCust.CheckedChanged
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

        If cbxAddNewCust.Checked Then
            txtCustName.Enabled = True
            txtCustPhoneNum.Enabled = True
            txtSearchCustomer.Enabled = False
            btnAddCustomer.Visible = True
            btnSearchCustomer.Visible = False
            txtSearchCustomer.Text = ""
            CheckCustomer = True
        Else
            txtCustName.Enabled = False
            txtCustPhoneNum.Enabled = False
            txtSearchCustomer.Enabled = True
            btnAddCustomer.Visible = False
            btnSearchCustomer.Visible = True
            txtSearchCustomer.Text = "Search By Name or Phone Number"
            CheckCustomer = False
        End If
    End Sub

    Private Sub FrmWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        txtSearchCustomer.Enabled = True
        Me.Refresh()
        If NewWorkOrder Then
            btnSaveWorkOrder.Text = "Save and Print WorkOrder"
        ElseIf NewWorkOrder = False Then
            btnSaveWorkOrder.Text = "Update and Print WorkOrder"
            cbxAddNewCust.Enabled = False
        ElseIf WorkOrderPickup Then
            pnWorkOrderItem.Hide()
            cbxAddNewCust.Text = "Partial Collection?"
            btnSaveWorkOrder.Text = "Confirm Collection By Client"
        End If
    End Sub
    Function AddNewCustomer(name As String, phone As String)
        Try
            Return UpdateRecord("Insert INTO customer (name,phone) VALUES('" & name & "', '" & phone & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function SaveNewWorkOrder() As String
        Try
            Return UpdateRecord("INSERT INTO workorder (customerId,datecreated,datemodified) VALUES ('" & CustomerID & "', now(),now())")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try

    End Function

    Function SaveNewWorkOrderItem() As String
        Try
            Return UpdateRecord("INSERT INTO workorderitem (workorderid,serviceitem,quantity,comments,datecreated,datemodified) VALUES ('" & WorkOrderID & "', '" & txtServiceItem.Text & "', '" & CInt(txtQuantity.Text) & "','" & txtComments.Text & "', now(), now())")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function UpdateWorkOrderItem(WorkOrderItemId As Integer) As String
        Try
            Return UpdateRecord("UPDATE workorderitem SET serviceitem = '" & txtServiceItem.Text & "',quantity = '" & txtQuantity.Text & "',comments = '" & txtComments.Text & "',datemodified = now() WHERE workorderitemid = '" & WorkOrderItemId & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function ArchiveWorkOrderItem(WorkOrderItemId As Integer) As String
        Try
            Return UpdateRecord("UPDATE workorderitem SET valid = 0, datemodified = now() WHERE workorderitemid = '" & WorkOrderItemId & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function ArchiveWorkOrder(WorkOrderId As Integer) As String
        Try
            Return UpdateRecord("UPDATE workorder SET valid = 0, datemodified = now() WHERE workorderid = '" & WorkOrderId & "'")
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
        txtServiceItem.Text = ""
        txtQuantity.Text = ""
        txtComments.Text = ""
        WorkOrderItemID = 0
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        If WorkOrderID = 0 And NewWorkOrder = True Then 'Create new work order and assign items to it.
            SaveNewWorkOrder()
            WorkOrderID = GetMaxWorkOrderID(CustomerID) 'Because it will be the most lates WorkOrder cretaed for the client. However, as system grows what if the client has orders being input by several people at once?
            lblWorkOrderID.Text = "Order No: " & WorkOrderID
            MsgBox(SaveNewWorkOrderItem() & " work order and service item Added.", MsgBoxStyle.Information)
        ElseIf NewWorkOrderItem = True Then 'add a new service item to an existing order
            MsgBox(SaveNewWorkOrderItem() & " service item added.", MsgBoxStyle.Information)
        ElseIf NewWorkOrderItem = False And WorkOrderItemID <> 0 Then 'Update the service item selected
            MsgBox(UpdateWorkOrderItem(WorkOrderItemID) & " service item updated.", MsgBoxStyle.Information)
            btnAddItem.Text = "Add WorkOrder Item"
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
        MsgBox("Proceed to receive payment for the laundry order?", MsgBoxStyle.YesNo, "Workorder No." & WorkOrderID & " has been recorded.")
        If MsgBoxResult.Yes Then
            MsgBox("WorkOrder Slip Printed")
            frmPayments.Show()
            Me.Close()
        Else
            MsgBox("WorkOrder Slip Printed")
            Me.Close()
        End If
        WorkOrderID = 0
        WorkOrderItemID = 0
    End Sub

    Private Sub BtnVoidWorkOrder_Click(sender As Object, e As EventArgs) Handles btnVoidWorkOrder.Click
        MsgBox("Do you want to cancel/delete this Laundry Workorder?", MsgBoxStyle.YesNo, "Cancel/Delete Workorder")
        If MsgBoxResult.Yes Then
            ArchiveWorkOrder(WorkOrderID)
            MsgBox("Workorder No. " & WorkOrderID & " has been Cancelled.")
            Me.Close()
        End If
        WorkOrderID = 0
        WorkOrderItemID = 0
    End Sub

    Sub LoadCustomerDetails(searchString As String)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

        Dim query As String
        Try
            searchString = searchString.ToLower
            query = "Select custID ID,name 'Name',phone 'Phone Number' from customer where (phone like '%" & searchString & "%' OR lower(name) like lower('%" & searchString & "%') OR custId = '" & searchString & "') AND valid = 1 order by name ASC"

            Dim da As New MySqlDataAdapter(query, connection)
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
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            connection.Close()
        End Try
    End Sub

    Sub LoadWorkOrders(custId As Integer)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

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
        dgvWorkOrderItems.Rows.Clear()

        Dim query As String
        Try
            If NewWorkOrderItem = True Or NewWorkOrderItem = False Then
                query = "Select workorderitemid 'Service Item ID',  workorderId 'Order ID',serviceitem 'Service Item',quantity 'Quantity',comments 'Comments' from workorderitem where workorderId = '" & workorderId & "' AND valid = 1 order by serviceitem ASC"
                Dim da As New MySqlDataAdapter(query, connection)
                da.GetFillParameters()
                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    'Load the Datagrid with the new dataset
                    dgvWorkOrderItems.DataSource = ds.Tables(0)
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
            dgvWorkOrderItems.Rows.Clear()

        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Sub PopulateWorkOrderItemFields(workOrderItemId As Integer)
        Dim query As String = "SELECT workorderid,workorderitemid,serviceitem,quantity,comments from workorderitem WHERE workorderitemid like '" & workOrderItemId & "' AND valid = 1"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                WorkOrderID = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0))
                workOrderItemId = IIf(readah.IsDBNull(1), String.Empty, readah.GetString(1))
                txtServiceItem.Text = IIf(readah.IsDBNull(2), String.Empty, readah.GetString(2))
                txtQuantity.Text = IIf(readah.IsDBNull(3), String.Empty, readah.GetString(3))
                txtComments.Text = IIf(readah.IsDBNull(4), String.Empty, readah.GetString(4))
                lblWorkOrderID.Text = "Order No: " & WorkOrderID

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
        WorkOrderID = Nothing
        WorkOrderItemID = Nothing

        If CheckCustomer = True Then
            Dim currRecId As Integer = dgvWorkOrderItems.CurrentRow.Cells(0).Value
            PopulateCustomerFields(currRecId)
            'Now we are done with selecting/adding the customer. Switch the Grids Use to WorkOrder Items

            If NewWorkOrder = False Then
                LoadWorkOrders(CustomerID)
            End If
        ElseIf NewWorkOrder = False Then
            WorkOrderID = CInt(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            LoadWorkOrderDetails(WorkOrderID)
            lblWorkOrderID.Text = "Order No: " & WorkOrderID
            NewWorkOrder = True
            NewWorkOrderItem = True
        ElseIf NewWorkOrder = True Then
            WorkOrderItemID = CInt(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            WorkOrderID = CInt(dgvWorkOrderItems.CurrentRow.Cells(1).Value)
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
            MsgBox(AddNewCustomer(CustName, CustPhoneNumber) & " Customer added.", MsgBoxStyle.Information)
            LoadCustomerDetails(CustPhoneNumber)
            CustomerID = CInt(dgvWorkOrderItems.Rows(0).Cells(0).Value)
            PopulateCustomerFields(CustomerID)

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
End Class