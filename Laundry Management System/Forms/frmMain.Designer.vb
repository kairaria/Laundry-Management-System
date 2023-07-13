<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LaundryOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWorkOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditWorkOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkOrderPickupDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterExpenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkOrderStatusReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BizProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaundryOrdersToolStripMenuItem, Me.AccountingToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1898, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LaundryOrdersToolStripMenuItem
        '
        Me.LaundryOrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWorkOrderToolStripMenuItem, Me.EditWorkOrderToolStripMenuItem, Me.WorkOrderPickupDeliveryToolStripMenuItem})
        Me.LaundryOrdersToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaundryOrdersToolStripMenuItem.Name = "LaundryOrdersToolStripMenuItem"
        Me.LaundryOrdersToolStripMenuItem.Size = New System.Drawing.Size(170, 27)
        Me.LaundryOrdersToolStripMenuItem.Text = "Laundry Orders"
        '
        'NewWorkOrderToolStripMenuItem
        '
        Me.NewWorkOrderToolStripMenuItem.Name = "NewWorkOrderToolStripMenuItem"
        Me.NewWorkOrderToolStripMenuItem.Size = New System.Drawing.Size(346, 28)
        Me.NewWorkOrderToolStripMenuItem.Text = "New WorkOrder"
        '
        'EditWorkOrderToolStripMenuItem
        '
        Me.EditWorkOrderToolStripMenuItem.Enabled = False
        Me.EditWorkOrderToolStripMenuItem.Name = "EditWorkOrderToolStripMenuItem"
        Me.EditWorkOrderToolStripMenuItem.Size = New System.Drawing.Size(346, 28)
        Me.EditWorkOrderToolStripMenuItem.Text = "Edit WorkOrder"
        '
        'WorkOrderPickupDeliveryToolStripMenuItem
        '
        Me.WorkOrderPickupDeliveryToolStripMenuItem.Name = "WorkOrderPickupDeliveryToolStripMenuItem"
        Me.WorkOrderPickupDeliveryToolStripMenuItem.Size = New System.Drawing.Size(346, 28)
        Me.WorkOrderPickupDeliveryToolStripMenuItem.Text = "WorkOrder Pickup/Delivery"
        '
        'AccountingToolStripMenuItem
        '
        Me.AccountingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterPaymentToolStripMenuItem, Me.RegisterExpenseToolStripMenuItem, Me.GenerateInvoiceToolStripMenuItem})
        Me.AccountingToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountingToolStripMenuItem.Name = "AccountingToolStripMenuItem"
        Me.AccountingToolStripMenuItem.Size = New System.Drawing.Size(135, 27)
        Me.AccountingToolStripMenuItem.Text = "Accounting"
        '
        'RegisterPaymentToolStripMenuItem
        '
        Me.RegisterPaymentToolStripMenuItem.Name = "RegisterPaymentToolStripMenuItem"
        Me.RegisterPaymentToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.RegisterPaymentToolStripMenuItem.Text = "Register Payment"
        '
        'RegisterExpenseToolStripMenuItem
        '
        Me.RegisterExpenseToolStripMenuItem.Name = "RegisterExpenseToolStripMenuItem"
        Me.RegisterExpenseToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.RegisterExpenseToolStripMenuItem.Text = "Register Expense"
        '
        'GenerateInvoiceToolStripMenuItem
        '
        Me.GenerateInvoiceToolStripMenuItem.Name = "GenerateInvoiceToolStripMenuItem"
        Me.GenerateInvoiceToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.GenerateInvoiceToolStripMenuItem.Text = "Generate Invoice"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevenueReportToolStripMenuItem, Me.ExpensesReportToolStripMenuItem, Me.WorkOrderStatusReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(95, 27)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'RevenueReportToolStripMenuItem
        '
        Me.RevenueReportToolStripMenuItem.Name = "RevenueReportToolStripMenuItem"
        Me.RevenueReportToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.RevenueReportToolStripMenuItem.Text = "Revenue Report"
        '
        'ExpensesReportToolStripMenuItem
        '
        Me.ExpensesReportToolStripMenuItem.Name = "ExpensesReportToolStripMenuItem"
        Me.ExpensesReportToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ExpensesReportToolStripMenuItem.Text = "Expenses Report"
        '
        'WorkOrderStatusReportToolStripMenuItem
        '
        Me.WorkOrderStatusReportToolStripMenuItem.Name = "WorkOrderStatusReportToolStripMenuItem"
        Me.WorkOrderStatusReportToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.WorkOrderStatusReportToolStripMenuItem.Text = "WorkOrder Status Report"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BizProfileToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ServiceItemsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 27)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BizProfileToolStripMenuItem
        '
        Me.BizProfileToolStripMenuItem.Name = "BizProfileToolStripMenuItem"
        Me.BizProfileToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.BizProfileToolStripMenuItem.Text = "Biz Profile"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ServiceItemsToolStripMenuItem
        '
        Me.ServiceItemsToolStripMenuItem.Name = "ServiceItemsToolStripMenuItem"
        Me.ServiceItemsToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.ServiceItemsToolStripMenuItem.Text = "Service Items"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(216, 28)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laundry Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LaundryOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWorkOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditWorkOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterExpenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BizProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkOrderPickupDeliveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevenueReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpensesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkOrderStatusReportToolStripMenuItem As ToolStripMenuItem
End Class
