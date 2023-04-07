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
            SelectCustomer = False
            AddCustomer = True
        Else
            txtCustName.Enabled = False
            txtCustPhoneNum.Enabled = False
            txtSearchCustomer.Enabled = True
            btnAddCustomer.Visible = False
            btnSearchCustomer.Visible = True
            txtSearchCustomer.Text = "Search By Name or Phone Number"
            SelectCustomer = True
            AddCustomer = False
        End If
    End Sub

    Private Sub FrmWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        txtSearchCustomer.Enabled = True
        Me.Refresh()
        If EditWorkOrder.Equals(False) And EditWorkOrderItem.Equals(False) Then
            btnSaveWorkOrder.Text = "Save and Print WorkOrder"
        Else
            If WorkOrderPickup.Equals(True) Then
                pnWorkOrderItem.Hide()
                cbxAddNewCust.Text = "Partial Collection?"
                btnSaveWorkOrder.Text = "Confirm Collection By Client"
            Else
                btnSaveWorkOrder.Text = "Update and Print WorkOrder"
            End If
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        Try
            If (IsNothing(WorkOrderID) Or lblWorkOrderID.Text = "WorkOrder ID" Or lblWorkOrderID.Text = "0") And AddWorkOrder = True Then
                UpdateRecord("INSERT INTO workorder (customerId,datecreated,datemodified) VALUES ('" & CustomerID & "', now(),now())")
                WorkOrderID = GetMaxWorkOrderID(CustomerID) 'Because it will be the most lates WorkOrder cretaed for the client. However, as system grows what if the client has orders being input by several people at once?
                lblWorkOrderID.Text = WorkOrderID
                MsgBox(UpdateRecord("INSERT INTO workorderitem (workorderid,serviceitem,quantity,comments,datecreated,datemodified) VALUES ('" & lblWorkOrderID.Text & "', '" & txtServiceItem.Text & "', '" & CInt(txtQuantity.Text) & "','" & txtComments.Text & "', now(), now())") & " Work Order Created and Work Order Item Added.", MsgBoxStyle.Information)
                AddWorkOrder = False
                AddWorkOrderItem = True
                EditWorkOrderItem = True
            ElseIf AddWorkOrderItem = True And EditWorkOrderItem = False Then
                MsgBox(UpdateRecord("INSERT INTO workorderitem (workorderid,serviceitem,quantity,comments,datecreated,datemodified) VALUES ('" & lblWorkOrderID.Text & "', '" & txtServiceItem.Text & "', '" & CInt(txtQuantity.Text) & "','" & txtComments.Text & "', now(), now())") & " WorkOrder Item Added.", MsgBoxStyle.Information)
            ElseIf EditWorkOrderItem = True And IsNothing(WorkOrderItemID) = False Then
                MsgBox(UpdateRecord("UPDATE workorderitem SET serviceitem = '" & txtServiceItem.Text & "',quantity = '" & txtQuantity.Text & "',comments = '" & txtComments.Text & "',datemodified = now() WHERE workorderitemid = '" & WorkOrderItemID & "'") & " WorkOrder Item Updated.", MsgBoxStyle.Information)
                AddWorkOrderItem = True
            End If
            LoadWorkOrderDetails(WorkOrderID)
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetMaxWorkOrderID(CustomerID) As Integer
        Dim query As String = "SELECT Max(workorderId) FROM workorder WHERE customerId like '" & CustomerID & "'"
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
        MsgBox("Item deleted from workorder xyz")
    End Sub

    Private Sub BtnSaveWorkOrder_Click(sender As Object, e As EventArgs) Handles btnSaveWorkOrder.Click
        MsgBox("WorkOrder Saved. Proceed to receive payment for the laundry order?", MsgBoxStyle.YesNo, "Exit / Void Workorder")
        If MsgBoxResult.Yes Then

            MsgBox("WorkOrder Slip Printed")
            frmPayments.Show()
            Me.Close()
        Else
            MsgBox("WorkOrder Slip Printed")
            Me.Close()
        End If
        WorkOrderID = Nothing
        WorkOrderItemID = Nothing
    End Sub

    Private Sub BtnVoidWorkOrder_Click(sender As Object, e As EventArgs) Handles btnVoidWorkOrder.Click
        MsgBox("Do you want to void this Workorder?", MsgBoxStyle.YesNo, "Exit / Void Workorder")
        If MsgBoxResult.Yes Then

            MsgBox("Workorder has been Voided.")
            Me.Close()
        ElseIf MsgBoxResult.No Then
            Me.Close()
        End If
        WorkOrderID = Nothing
        WorkOrderItemID = Nothing
    End Sub

    Sub LoadCustomerDetails(searchString As String)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

        Dim query As String
        Try
            If SelectCustomer = True Then
                searchString = "%" & searchString & "%"
                query = "Select custID ID,name Customer_Name,phone Customer_PhoneNumber from customer where phone like '" & searchString & "' OR lower(name) like lower('" & searchString & "') order by name ASC"
            ElseIf AddCustomer = True Then
                query = "Select custID ID,name Customer_Name,phone Customer_PhoneNumber from customer where custId = '" & CInt(searchString) & "' OR phone like '%" & searchString & "%' order by name ASC"
            Else
                query = "Select custID ID,name Customer_Name,phone Customer_PhoneNumber from customer where custId = '" & CInt(searchString) & "' OR phone like '%" & searchString & "%' OR lower(name) like lower('%" & searchString & "%') order by name ASC"
            End If
            Dim da As New MySqlDataAdapter(query, connection)
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvWorkOrderItems.DataSource = ds.Tables(0)
            Else
                MsgBox("The customer record does not exist in the database. Please review the search string used OR add the customer record to the database.", MsgBoxStyle.Exclamation)
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

    Sub LoadWorkOrderDetails(workorderId As Integer)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

        Dim query As String
        Try
            If AddWorkOrderItem = True Or EditWorkOrderItem = True Then
                query = "Select workorderId 'Order ID',serviceitem 'Service Item',quantity 'Quantity',comments 'Comments' from workorderitem where workorderId = '" & workorderId & "' order by serviceitem ASC"
                Dim da As New MySqlDataAdapter(query, connection)
                da.GetFillParameters()
                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    'Load the Datagrid with the new dataset
                    dgvWorkOrderItems.DataSource = ds.Tables(0)
                    EditWorkOrderItem = True
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

    Sub LoadWorkOrders(custId As Integer)
        'Clear the Datagrid first
        dgvWorkOrderItems.DataSource = Nothing
        dgvWorkOrderItems.Rows.Clear()

        Dim query As String
        Try
            'If EditWorkOrderItem = True Then
            query = "Select workorderId 'Order ID',datecreated 'Date' from workorder where customerId = '" & custId & "' order by workorderId ASC"
            Dim da As New MySqlDataAdapter(query, connection)
                da.GetFillParameters()
                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvWorkOrderItems.DataSource = ds.Tables(0)
                EditWorkOrder = True
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

    Sub PopulateCustomerFields(recID As Integer)
        'Populate the CustName and Phone Number Fields
        Dim query As String = "SELECT custId,name,phone from customer WHERE custId like '" & recID & "'"
        Dim command As New MySqlCommand(query, connection) With {
            .CommandTimeout = 0
        }
        Dim readah As MySqlDataReader
        Try
            connection.Open()
            readah = command.ExecuteReader
            While readah.Read()
                CustomerID = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(0))
                txtCustName.Text = IIf(readah.IsDBNull(0), String.Empty, readah.GetString(1))
                txtCustPhoneNum.Text = IIf(readah.IsDBNull(1), String.Empty, readah.GetString(2))
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
        Dim query As String = "SELECT workorderid,workorderitemid,serviceitem,quantity,comments from workorderitem WHERE workorderitemid like '" & workOrderItemId & "'"
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
                lblWorkOrderID.Text = WorkOrderID
            End While
            readah.Close()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub
    Sub AddNewCustomer(name As String, phone As String)

        Try
            MsgBox(UpdateRecord("Insert INTO customer (name,phone) VALUES('" & name & "', '" & phone & "')") & " records saved!", MsgBoxStyle.Information)

        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub BgvWorkOrderItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorkOrderItems.CellDoubleClick
        If SelectCustomer = True Or AddCustomer = True Then
            PopulateCustomerFields(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            'Now we are done with selecting/adding the customer. Switch the Grids Use to WorkOrder Items
            EndCustomerSelection()
            If EditWorkOrder = True Then
                LoadWorkOrders(CustomerID)
            End If
        ElseIf EditWorkOrder = True And (EditWorkOrderItem = True Or AddWorkOrderItem = True) Then
            WorkOrderID = CInt(dgvWorkOrderItems.CurrentRow.Cells(0).Value)
            LoadWorkOrderDetails(WorkOrderID)
            lblWorkOrderID.Text = WorkOrderID

            EditWorkOrder = False
            AddWorkOrderItem = True
            EditWorkOrderItem = False
        ElseIf EditWorkOrder = False And (EditWorkOrderItem = True Or AddWorkOrderItem = True) Then
            WorkOrderItemID = CInt(dgvWorkOrderItems.CurrentRow.Cells(1).Value)
            PopulateWorkOrderItemFields(WorkOrderItemID)
            btnAddItem.Text = "Edit WorkOrder Item"

            AddWorkOrderItem = False
            EditWorkOrderItem = True
        End If

    End Sub
    Sub EndCustomerSelection()
        SelectCustomer = False
        AddCustomer = False
        txtSearchCustomer.Text = ""
        txtSearchCustomer.Enabled = False
        cbxAddNewCust.Enabled = False
        btnSearchCustomer.Visible = False
        btnAddCustomer.Visible = False
        txtCustName.Enabled = False
        txtCustPhoneNum.Enabled = False
    End Sub
    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        LoadCustomerDetails(txtSearchCustomer.Text)
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        AddNewCustomer(txtCustName.Text, txtCustPhoneNum.Text)
        LoadCustomerDetails(txtCustPhoneNum.Text)
        PopulateCustomerFields(CInt(dgvWorkOrderItems.Rows(0).Cells(0).Value))
        EndCustomerSelection()

    End Sub

    Private Sub TxtSearchCustomer_Enter(sender As Object, e As EventArgs) Handles txtSearchCustomer.Enter
        If txtSearchCustomer.Enabled = True AndAlso txtSearchCustomer.Text = "Search By Name or Phone Number" Then
            txtSearchCustomer.Text = ""
        End If
    End Sub
End Class