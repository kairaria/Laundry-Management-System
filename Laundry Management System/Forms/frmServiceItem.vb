Imports MySql.Data.MySqlClient
Public Class frmServiceItem
    Private NewServiceItem As Boolean
    Private Sub frmServiceItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewServiceItem = 1
        MdiParent = frmMain
        LoadServiceItemDetails()
    End Sub
    Sub LoadServiceItemDetails()
        'Clear the Datagrid first
        dgvServiceItem.DataSource = Nothing
        dgvServiceItem.Rows.Clear()

        Dim query As String
        Try
            query = "Select si.serviceItemID 'ID',si.serviceitemName 'Service Item Name',si.price 'Price' from serviceitem si where si.valid = 1;"

            Dim da As New MySqlDataAdapter(query, connection)
            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                'Load the Datagrid with the new dataset
                dgvServiceItem.DataSource = ds.Tables(0)

            Else
                MsgBox("No service Items Configured yet.", MsgBoxStyle.Exclamation)
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


    Function SaveNewServiceItem() As String
        Try
            Return UpdateRecord("INSERT INTO serviceitem (serviceitemName,price) VALUES ('" & txtServiceItem.Text & "', '" & txtPrice.Text & "')")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function UpdateServiceItem() As String
        Try
            Return UpdateRecord("Update serviceitem si SET si.serviceitemName = '" & txtServiceItem.Text & "', si.price = '" & txtPrice.Text & "' WHERE si.serviceItemID = '" & dgvServiceItem.CurrentRow.Cells(0).Value & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Function ArchiveServiceItem() As String
        Try
            Return UpdateRecord("Update serviceitem si SET si.valid = 0 WHERE si.serviceItemID = '" & dgvServiceItem.CurrentRow.Cells(0).Value & "'")
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If NewServiceItem = 0 Then
            MsgBox(ArchiveServiceItem() & " service item archived.", MsgBoxStyle.Information)
        Else
            Close()
        End If
    End Sub

    Private Sub dgvServiceItem_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceItem.CellContentClick
        If dgvServiceItem.CurrentRow.Cells(0).Value > 0 Then
            NewServiceItem = 0
            txtServiceItem.Text = dgvServiceItem.CurrentRow.Cells(1).Value
            txtPrice.Text = dgvServiceItem.CurrentRow.Cells(2).Value
            btnClose.Text = "Archive"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If NewServiceItem = 1 Then
            MsgBox(SaveNewServiceItem() & " service item saved.", MsgBoxStyle.Information)
        Else
            MsgBox(UpdateServiceItem() & " service item updated.", MsgBoxStyle.Information)
        End If
    End Sub
End Class