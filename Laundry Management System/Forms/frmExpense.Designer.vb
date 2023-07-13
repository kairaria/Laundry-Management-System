<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.pnPayments = New System.Windows.Forms.Panel()
        Me.txtExpenseDesc = New System.Windows.Forms.TextBox()
        Me.lblExpense = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.cbxPaymentMode = New System.Windows.Forms.ComboBox()
        Me.pnPayments.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnPayments
        '
        Me.pnPayments.BackColor = System.Drawing.Color.MediumAquamarine
        Me.pnPayments.Controls.Add(Me.txtExpenseDesc)
        Me.pnPayments.Controls.Add(Me.lblExpense)
        Me.pnPayments.Controls.Add(Me.btnClose)
        Me.pnPayments.Controls.Add(Me.btnSave)
        Me.pnPayments.Controls.Add(Me.txtTransactionID)
        Me.pnPayments.Controls.Add(Me.lblTransactionID)
        Me.pnPayments.Controls.Add(Me.txtAmount)
        Me.pnPayments.Controls.Add(Me.lblAmount)
        Me.pnPayments.Controls.Add(Me.cbxPaymentMode)
        Me.pnPayments.Location = New System.Drawing.Point(12, 12)
        Me.pnPayments.Name = "pnPayments"
        Me.pnPayments.Size = New System.Drawing.Size(331, 350)
        Me.pnPayments.TabIndex = 2
        '
        'txtExpenseDesc
        '
        Me.txtExpenseDesc.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpenseDesc.Location = New System.Drawing.Point(16, 43)
        Me.txtExpenseDesc.Multiline = True
        Me.txtExpenseDesc.Name = "txtExpenseDesc"
        Me.txtExpenseDesc.Size = New System.Drawing.Size(297, 73)
        Me.txtExpenseDesc.TabIndex = 12
        '
        'lblExpense
        '
        Me.lblExpense.AutoSize = True
        Me.lblExpense.Location = New System.Drawing.Point(13, 13)
        Me.lblExpense.Name = "lblExpense"
        Me.lblExpense.Size = New System.Drawing.Size(176, 21)
        Me.lblExpense.TabIndex = 11
        Me.lblExpense.Text = "Expense Description"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(30, 273)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 57)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Exit"
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
        Me.btnSave.Location = New System.Drawing.Point(170, 273)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 57)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Enabled = False
        Me.txtTransactionID.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionID.Location = New System.Drawing.Point(159, 166)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(154, 24)
        Me.txtTransactionID.TabIndex = 8
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.Location = New System.Drawing.Point(8, 169)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(129, 21)
        Me.lblTransactionID.TabIndex = 7
        Me.lblTransactionID.Text = "Transaction ID"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(159, 218)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 28)
        Me.txtAmount.TabIndex = 6
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(13, 221)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(76, 21)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "Amount"
        '
        'cbxPaymentMode
        '
        Me.cbxPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbxPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxPaymentMode.FormattingEnabled = True
        Me.cbxPaymentMode.Items.AddRange(New Object() {"Cash", "Mpesa"})
        Me.cbxPaymentMode.Location = New System.Drawing.Point(16, 122)
        Me.cbxPaymentMode.Name = "cbxPaymentMode"
        Me.cbxPaymentMode.Size = New System.Drawing.Size(295, 29)
        Me.cbxPaymentMode.TabIndex = 4
        Me.cbxPaymentMode.Text = "Select Payment Mode"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 381)
        Me.Controls.Add(Me.pnPayments)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmExpenses"
        Me.Text = "frmExpense"
        Me.pnPayments.ResumeLayout(False)
        Me.pnPayments.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnPayments As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents cbxPaymentMode As ComboBox
    Friend WithEvents txtExpenseDesc As TextBox
    Friend WithEvents lblExpense As Label
End Class
