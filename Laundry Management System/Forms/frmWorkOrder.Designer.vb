<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.spltCWorkOrder = New System.Windows.Forms.SplitContainer()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.txtCustPhoneNum = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.cbxAddNewCust = New System.Windows.Forms.CheckBox()
        Me.spltCWorkOrderItem = New System.Windows.Forms.SplitContainer()
        Me.dgvWorkOrderItems = New System.Windows.Forms.DataGridView()
        Me.pnWorkOrderItem = New System.Windows.Forms.Panel()
        Me.cboServiceItem = New System.Windows.Forms.ComboBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.lblWorkOrderID = New System.Windows.Forms.Label()
        Me.btnDeleteWorkItem = New System.Windows.Forms.Button()
        Me.lblServiceItem = New System.Windows.Forms.Label()
        Me.txtServiceItem = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.pnSaveWorkOrder = New System.Windows.Forms.Panel()
        Me.btnVoidWorkOrder = New System.Windows.Forms.Button()
        Me.btnSaveWorkOrder = New System.Windows.Forms.Button()
        Me.clrDgItemColor = New System.Windows.Forms.ColorDialog()
        CType(Me.spltCWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCWorkOrder.Panel1.SuspendLayout()
        Me.spltCWorkOrder.Panel2.SuspendLayout()
        Me.spltCWorkOrder.SuspendLayout()
        CType(Me.spltCWorkOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCWorkOrderItem.Panel1.SuspendLayout()
        Me.spltCWorkOrderItem.Panel2.SuspendLayout()
        Me.spltCWorkOrderItem.SuspendLayout()
        CType(Me.dgvWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnWorkOrderItem.SuspendLayout()
        Me.pnSaveWorkOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'spltCWorkOrder
        '
        Me.spltCWorkOrder.BackColor = System.Drawing.Color.MediumAquamarine
        Me.spltCWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltCWorkOrder.Location = New System.Drawing.Point(10, 10)
        Me.spltCWorkOrder.Name = "spltCWorkOrder"
        Me.spltCWorkOrder.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltCWorkOrder.Panel1
        '
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.btnAddCustomer)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.btnSearchCustomer)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.txtSearchCustomer)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.txtCustPhoneNum)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.lblPhoneNumber)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.txtCustName)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.lblCustName)
        Me.spltCWorkOrder.Panel1.Controls.Add(Me.cbxAddNewCust)
        Me.spltCWorkOrder.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'spltCWorkOrder.Panel2
        '
        Me.spltCWorkOrder.Panel2.Controls.Add(Me.spltCWorkOrderItem)
        Me.spltCWorkOrder.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.spltCWorkOrder.Size = New System.Drawing.Size(1126, 617)
        Me.spltCWorkOrder.SplitterDistance = 96
        Me.spltCWorkOrder.TabIndex = 0
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(997, 44)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(116, 29)
        Me.btnAddCustomer.TabIndex = 9
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        Me.btnAddCustomer.Visible = False
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(629, 9)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(127, 32)
        Me.btnSearchCustomer.TabIndex = 8
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchCustomer.Location = New System.Drawing.Point(22, 9)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(593, 32)
        Me.txtSearchCustomer.TabIndex = 7
        Me.txtSearchCustomer.Text = "Search By Name or Phone Number"
        '
        'txtCustPhoneNum
        '
        Me.txtCustPhoneNum.Enabled = False
        Me.txtCustPhoneNum.Location = New System.Drawing.Point(676, 44)
        Me.txtCustPhoneNum.Name = "txtCustPhoneNum"
        Me.txtCustPhoneNum.Size = New System.Drawing.Size(296, 32)
        Me.txtCustPhoneNum.TabIndex = 5
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(515, 47)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(155, 23)
        Me.lblPhoneNumber.TabIndex = 4
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtCustName
        '
        Me.txtCustName.Enabled = False
        Me.txtCustName.Location = New System.Drawing.Point(194, 44)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(284, 32)
        Me.txtCustName.TabIndex = 3
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(18, 47)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(170, 23)
        Me.lblCustName.TabIndex = 2
        Me.lblCustName.Text = "Customer Name"
        '
        'cbxAddNewCust
        '
        Me.cbxAddNewCust.AutoSize = True
        Me.cbxAddNewCust.Location = New System.Drawing.Point(882, 11)
        Me.cbxAddNewCust.Name = "cbxAddNewCust"
        Me.cbxAddNewCust.Size = New System.Drawing.Size(231, 27)
        Me.cbxAddNewCust.TabIndex = 1
        Me.cbxAddNewCust.Text = "Add New Customer"
        Me.cbxAddNewCust.UseVisualStyleBackColor = True
        '
        'spltCWorkOrderItem
        '
        Me.spltCWorkOrderItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltCWorkOrderItem.Location = New System.Drawing.Point(10, 10)
        Me.spltCWorkOrderItem.Name = "spltCWorkOrderItem"
        Me.spltCWorkOrderItem.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltCWorkOrderItem.Panel1
        '
        Me.spltCWorkOrderItem.Panel1.Controls.Add(Me.dgvWorkOrderItems)
        '
        'spltCWorkOrderItem.Panel2
        '
        Me.spltCWorkOrderItem.Panel2.Controls.Add(Me.pnWorkOrderItem)
        Me.spltCWorkOrderItem.Panel2.Controls.Add(Me.pnSaveWorkOrder)
        Me.spltCWorkOrderItem.Size = New System.Drawing.Size(1106, 497)
        Me.spltCWorkOrderItem.SplitterDistance = 202
        Me.spltCWorkOrderItem.TabIndex = 0
        '
        'dgvWorkOrderItems
        '
        Me.dgvWorkOrderItems.AllowUserToAddRows = False
        Me.dgvWorkOrderItems.AllowUserToDeleteRows = False
        Me.dgvWorkOrderItems.AllowUserToResizeColumns = False
        Me.dgvWorkOrderItems.AllowUserToResizeRows = False
        Me.dgvWorkOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvWorkOrderItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvWorkOrderItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWorkOrderItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWorkOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkOrderItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvWorkOrderItems.Location = New System.Drawing.Point(0, 0)
        Me.dgvWorkOrderItems.MultiSelect = False
        Me.dgvWorkOrderItems.Name = "dgvWorkOrderItems"
        Me.dgvWorkOrderItems.ReadOnly = True
        Me.dgvWorkOrderItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWorkOrderItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvWorkOrderItems.RowTemplate.Height = 28
        Me.dgvWorkOrderItems.Size = New System.Drawing.Size(1106, 202)
        Me.dgvWorkOrderItems.TabIndex = 0
        '
        'pnWorkOrderItem
        '
        Me.pnWorkOrderItem.Controls.Add(Me.cboServiceItem)
        Me.pnWorkOrderItem.Controls.Add(Me.lblColour)
        Me.pnWorkOrderItem.Controls.Add(Me.txtColour)
        Me.pnWorkOrderItem.Controls.Add(Me.lblWorkOrderID)
        Me.pnWorkOrderItem.Controls.Add(Me.btnDeleteWorkItem)
        Me.pnWorkOrderItem.Controls.Add(Me.lblServiceItem)
        Me.pnWorkOrderItem.Controls.Add(Me.txtServiceItem)
        Me.pnWorkOrderItem.Controls.Add(Me.btnAddItem)
        Me.pnWorkOrderItem.Controls.Add(Me.lblQty)
        Me.pnWorkOrderItem.Controls.Add(Me.txtComments)
        Me.pnWorkOrderItem.Controls.Add(Me.txtQuantity)
        Me.pnWorkOrderItem.Controls.Add(Me.lblComments)
        Me.pnWorkOrderItem.Enabled = False
        Me.pnWorkOrderItem.Location = New System.Drawing.Point(0, 3)
        Me.pnWorkOrderItem.Name = "pnWorkOrderItem"
        Me.pnWorkOrderItem.Padding = New System.Windows.Forms.Padding(10)
        Me.pnWorkOrderItem.Size = New System.Drawing.Size(1077, 165)
        Me.pnWorkOrderItem.TabIndex = 10
        '
        'cboServiceItem
        '
        Me.cboServiceItem.FormattingEnabled = True
        Me.cboServiceItem.Location = New System.Drawing.Point(162, 42)
        Me.cboServiceItem.Name = "cboServiceItem"
        Me.cboServiceItem.Size = New System.Drawing.Size(390, 31)
        Me.cboServiceItem.TabIndex = 11
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblColour.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour.Location = New System.Drawing.Point(22, 86)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(75, 23)
        Me.lblColour.TabIndex = 10
        Me.lblColour.Text = "Colour"
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(160, 80)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(64, 32)
        Me.txtColour.TabIndex = 3
        '
        'lblWorkOrderID
        '
        Me.lblWorkOrderID.AutoSize = True
        Me.lblWorkOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWorkOrderID.Location = New System.Drawing.Point(22, 18)
        Me.lblWorkOrderID.Name = "lblWorkOrderID"
        Me.lblWorkOrderID.Size = New System.Drawing.Size(138, 23)
        Me.lblWorkOrderID.TabIndex = 0
        Me.lblWorkOrderID.Text = "WorkOrder ID"
        '
        'btnDeleteWorkItem
        '
        Me.btnDeleteWorkItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeleteWorkItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteWorkItem.FlatAppearance.BorderSize = 2
        Me.btnDeleteWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteWorkItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteWorkItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteWorkItem.Location = New System.Drawing.Point(844, 86)
        Me.btnDeleteWorkItem.Name = "btnDeleteWorkItem"
        Me.btnDeleteWorkItem.Size = New System.Drawing.Size(180, 51)
        Me.btnDeleteWorkItem.TabIndex = 7
        Me.btnDeleteWorkItem.Text = "Delete Item"
        Me.btnDeleteWorkItem.UseVisualStyleBackColor = False
        '
        'lblServiceItem
        '
        Me.lblServiceItem.AutoSize = True
        Me.lblServiceItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblServiceItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceItem.Location = New System.Drawing.Point(22, 47)
        Me.lblServiceItem.Name = "lblServiceItem"
        Me.lblServiceItem.Size = New System.Drawing.Size(131, 23)
        Me.lblServiceItem.TabIndex = 1
        Me.lblServiceItem.Text = "Service Item"
        '
        'txtServiceItem
        '
        Me.txtServiceItem.Location = New System.Drawing.Point(600, 29)
        Me.txtServiceItem.Name = "txtServiceItem"
        Me.txtServiceItem.Size = New System.Drawing.Size(393, 32)
        Me.txtServiceItem.TabIndex = 2
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnAddItem.FlatAppearance.BorderSize = 2
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.Yellow
        Me.btnAddItem.Location = New System.Drawing.Point(619, 86)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(180, 51)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQty.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(246, 86)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(93, 23)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Quantity"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(160, 115)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(393, 34)
        Me.txtComments.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(345, 80)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(76, 32)
        Me.txtQuantity.TabIndex = 4
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblComments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(22, 118)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(117, 23)
        Me.lblComments.TabIndex = 5
        Me.lblComments.Text = "Comments"
        '
        'pnSaveWorkOrder
        '
        Me.pnSaveWorkOrder.Controls.Add(Me.btnVoidWorkOrder)
        Me.pnSaveWorkOrder.Controls.Add(Me.btnSaveWorkOrder)
        Me.pnSaveWorkOrder.Location = New System.Drawing.Point(3, 174)
        Me.pnSaveWorkOrder.Name = "pnSaveWorkOrder"
        Me.pnSaveWorkOrder.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.pnSaveWorkOrder.Size = New System.Drawing.Size(1074, 122)
        Me.pnSaveWorkOrder.TabIndex = 8
        '
        'btnVoidWorkOrder
        '
        Me.btnVoidWorkOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVoidWorkOrder.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVoidWorkOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVoidWorkOrder.FlatAppearance.BorderSize = 5
        Me.btnVoidWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoidWorkOrder.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidWorkOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVoidWorkOrder.Location = New System.Drawing.Point(559, 10)
        Me.btnVoidWorkOrder.Name = "btnVoidWorkOrder"
        Me.btnVoidWorkOrder.Size = New System.Drawing.Size(500, 102)
        Me.btnVoidWorkOrder.TabIndex = 1
        Me.btnVoidWorkOrder.Text = "Cancel/Delete Work Order"
        Me.btnVoidWorkOrder.UseVisualStyleBackColor = False
        '
        'btnSaveWorkOrder
        '
        Me.btnSaveWorkOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSaveWorkOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSaveWorkOrder.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveWorkOrder.FlatAppearance.BorderSize = 5
        Me.btnSaveWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveWorkOrder.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWorkOrder.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveWorkOrder.Location = New System.Drawing.Point(15, 10)
        Me.btnSaveWorkOrder.Name = "btnSaveWorkOrder"
        Me.btnSaveWorkOrder.Size = New System.Drawing.Size(507, 102)
        Me.btnSaveWorkOrder.TabIndex = 0
        Me.btnSaveWorkOrder.Text = "Save WorkOrder"
        Me.btnSaveWorkOrder.UseVisualStyleBackColor = False
        '
        'clrDgItemColor
        '
        Me.clrDgItemColor.AnyColor = True
        '
        'frmWorkOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1146, 637)
        Me.Controls.Add(Me.spltCWorkOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmWorkOrder"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laundry Work Order"
        Me.spltCWorkOrder.Panel1.ResumeLayout(False)
        Me.spltCWorkOrder.Panel1.PerformLayout()
        Me.spltCWorkOrder.Panel2.ResumeLayout(False)
        CType(Me.spltCWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCWorkOrder.ResumeLayout(False)
        Me.spltCWorkOrderItem.Panel1.ResumeLayout(False)
        Me.spltCWorkOrderItem.Panel2.ResumeLayout(False)
        CType(Me.spltCWorkOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCWorkOrderItem.ResumeLayout(False)
        CType(Me.dgvWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnWorkOrderItem.ResumeLayout(False)
        Me.pnWorkOrderItem.PerformLayout()
        Me.pnSaveWorkOrder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spltCWorkOrder As SplitContainer
    Friend WithEvents txtCustPhoneNum As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents cbxAddNewCust As CheckBox
    Friend WithEvents spltCWorkOrderItem As SplitContainer
    Friend WithEvents dgvWorkOrderItems As DataGridView
    Friend WithEvents pnSaveWorkOrder As Panel
    Friend WithEvents btnSaveWorkOrder As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblComments As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents txtServiceItem As TextBox
    Friend WithEvents lblServiceItem As Label
    Friend WithEvents lblWorkOrderID As Label
    Friend WithEvents btnDeleteWorkItem As Button
    Friend WithEvents btnVoidWorkOrder As Button
    Friend WithEvents pnWorkOrderItem As Panel
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents lblColour As Label
    Friend WithEvents txtColour As TextBox
    Friend WithEvents clrDgItemColor As ColorDialog
    Friend WithEvents cboServiceItem As ComboBox
End Class
