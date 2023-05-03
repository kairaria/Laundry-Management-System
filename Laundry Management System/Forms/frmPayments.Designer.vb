<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.spltCPayments = New System.Windows.Forms.SplitContainer()
        Me.pnPayments = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.cbxPaymentMode = New System.Windows.Forms.ComboBox()
        Me.txtInvoiceNum = New System.Windows.Forms.TextBox()
        Me.lblInvoiceNum = New System.Windows.Forms.Label()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.lblWorkOrderID = New System.Windows.Forms.Label()
        Me.gbxSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.spltCPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCPayments.Panel1.SuspendLayout()
        Me.spltCPayments.Panel2.SuspendLayout()
        Me.spltCPayments.SuspendLayout()
        Me.pnPayments.SuspendLayout()
        Me.gbxSearch.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'spltCPayments
        '
        Me.spltCPayments.BackColor = System.Drawing.Color.MediumAquamarine
        Me.spltCPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltCPayments.Location = New System.Drawing.Point(10, 10)
        Me.spltCPayments.Name = "spltCPayments"
        '
        'spltCPayments.Panel1
        '
        Me.spltCPayments.Panel1.Controls.Add(Me.pnPayments)
        Me.spltCPayments.Panel1.Controls.Add(Me.gbxSearch)
        '
        'spltCPayments.Panel2
        '
        Me.spltCPayments.Panel2.Controls.Add(Me.dgvPayments)
        Me.spltCPayments.Panel2.Controls.Add(Me.pnlTitle)
        Me.spltCPayments.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.spltCPayments.Size = New System.Drawing.Size(1345, 500)
        Me.spltCPayments.SplitterDistance = 351
        Me.spltCPayments.TabIndex = 0
        '
        'pnPayments
        '
        Me.pnPayments.Controls.Add(Me.btnClose)
        Me.pnPayments.Controls.Add(Me.btnSave)
        Me.pnPayments.Controls.Add(Me.txtTransactionID)
        Me.pnPayments.Controls.Add(Me.lblTransactionID)
        Me.pnPayments.Controls.Add(Me.txtAmount)
        Me.pnPayments.Controls.Add(Me.lblAmount)
        Me.pnPayments.Controls.Add(Me.cbxPaymentMode)
        Me.pnPayments.Controls.Add(Me.txtInvoiceNum)
        Me.pnPayments.Controls.Add(Me.lblInvoiceNum)
        Me.pnPayments.Controls.Add(Me.txtWorkOrder)
        Me.pnPayments.Controls.Add(Me.lblWorkOrderID)
        Me.pnPayments.Location = New System.Drawing.Point(12, 154)
        Me.pnPayments.Name = "pnPayments"
        Me.pnPayments.Size = New System.Drawing.Size(331, 350)
        Me.pnPayments.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(32, 266)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 57)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Blue
        Me.btnSave.Location = New System.Drawing.Point(172, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 57)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionID.Location = New System.Drawing.Point(161, 159)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(154, 27)
        Me.txtTransactionID.TabIndex = 8
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.Location = New System.Drawing.Point(9, 162)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(138, 23)
        Me.lblTransactionID.TabIndex = 7
        Me.lblTransactionID.Text = "Mpesa Code"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(192, 210)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 32)
        Me.txtAmount.TabIndex = 6
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(14, 214)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(88, 23)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "Amount"
        '
        'cbxPaymentMode
        '
        Me.cbxPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbxPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxPaymentMode.FormattingEnabled = True
        Me.cbxPaymentMode.Items.AddRange(New Object() {"Cash", "M-Pesa"})
        Me.cbxPaymentMode.Location = New System.Drawing.Point(18, 115)
        Me.cbxPaymentMode.Name = "cbxPaymentMode"
        Me.cbxPaymentMode.Size = New System.Drawing.Size(295, 31)
        Me.cbxPaymentMode.TabIndex = 4
        Me.cbxPaymentMode.Text = "Select Payment Mode"
        '
        'txtInvoiceNum
        '
        Me.txtInvoiceNum.Enabled = False
        Me.txtInvoiceNum.Location = New System.Drawing.Point(192, 60)
        Me.txtInvoiceNum.Name = "txtInvoiceNum"
        Me.txtInvoiceNum.Size = New System.Drawing.Size(122, 32)
        Me.txtInvoiceNum.TabIndex = 3
        '
        'lblInvoiceNum
        '
        Me.lblInvoiceNum.AutoSize = True
        Me.lblInvoiceNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInvoiceNum.Location = New System.Drawing.Point(14, 63)
        Me.lblInvoiceNum.Name = "lblInvoiceNum"
        Me.lblInvoiceNum.Size = New System.Drawing.Size(139, 23)
        Me.lblInvoiceNum.TabIndex = 2
        Me.lblInvoiceNum.Text = "Invoice Num:"
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Enabled = False
        Me.txtWorkOrder.Location = New System.Drawing.Point(192, 14)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(122, 32)
        Me.txtWorkOrder.TabIndex = 1
        '
        'lblWorkOrderID
        '
        Me.lblWorkOrderID.AutoSize = True
        Me.lblWorkOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWorkOrderID.Location = New System.Drawing.Point(14, 17)
        Me.lblWorkOrderID.Name = "lblWorkOrderID"
        Me.lblWorkOrderID.Size = New System.Drawing.Size(169, 23)
        Me.lblWorkOrderID.TabIndex = 0
        Me.lblWorkOrderID.Text = "WorkOrder Num:"
        '
        'gbxSearch
        '
        Me.gbxSearch.Controls.Add(Me.btnSearch)
        Me.gbxSearch.Controls.Add(Me.txtSearch)
        Me.gbxSearch.Location = New System.Drawing.Point(12, 12)
        Me.gbxSearch.Name = "gbxSearch"
        Me.gbxSearch.Size = New System.Drawing.Size(332, 136)
        Me.gbxSearch.TabIndex = 0
        Me.gbxSearch.TabStop = False
        Me.gbxSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(185, 86)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 37)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(18, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 27)
        Me.txtSearch.TabIndex = 1
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPayments.Location = New System.Drawing.Point(11, 69)
        Me.dgvPayments.MultiSelect = False
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowTemplate.Height = 28
        Me.dgvPayments.Size = New System.Drawing.Size(966, 425)
        Me.dgvPayments.TabIndex = 1
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTitle.Location = New System.Drawing.Point(11, 9)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlTitle.Size = New System.Drawing.Size(966, 54)
        Me.pnlTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.lblTitle.Location = New System.Drawing.Point(347, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Receive Payments"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1365, 520)
        Me.Controls.Add(Me.spltCPayments)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPayments"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frmPayments"
        Me.spltCPayments.Panel1.ResumeLayout(False)
        Me.spltCPayments.Panel2.ResumeLayout(False)
        CType(Me.spltCPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCPayments.ResumeLayout(False)
        Me.pnPayments.ResumeLayout(False)
        Me.pnPayments.PerformLayout()
        Me.gbxSearch.ResumeLayout(False)
        Me.gbxSearch.PerformLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spltCPayments As SplitContainer
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnPayments As Panel
    Friend WithEvents cbxPaymentMode As ComboBox
    Friend WithEvents txtInvoiceNum As TextBox
    Friend WithEvents lblInvoiceNum As Label
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents lblWorkOrderID As Label
    Friend WithEvents gbxSearch As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents btnSearch As Button
End Class
