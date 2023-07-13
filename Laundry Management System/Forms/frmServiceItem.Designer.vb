<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceItem
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtServiceItem = New System.Windows.Forms.TextBox()
        Me.lblServiceItem = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.dgvServiceItem = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvServiceItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvServiceItem)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtServiceItem)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblServiceItem)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPrice)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblPrice)
        Me.SplitContainer1.Size = New System.Drawing.Size(648, 310)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(524, 36)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 57)
        Me.btnClose.TabIndex = 22
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
        Me.btnSave.Location = New System.Drawing.Point(378, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 57)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtServiceItem
        '
        Me.txtServiceItem.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceItem.Location = New System.Drawing.Point(163, 12)
        Me.txtServiceItem.Name = "txtServiceItem"
        Me.txtServiceItem.Size = New System.Drawing.Size(154, 24)
        Me.txtServiceItem.TabIndex = 20
        '
        'lblServiceItem
        '
        Me.lblServiceItem.AutoSize = True
        Me.lblServiceItem.Location = New System.Drawing.Point(12, 15)
        Me.lblServiceItem.Name = "lblServiceItem"
        Me.lblServiceItem.Size = New System.Drawing.Size(85, 17)
        Me.lblServiceItem.TabIndex = 19
        Me.lblServiceItem.Text = "Service Item"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(163, 64)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 18
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(17, 67)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(54, 17)
        Me.lblPrice.TabIndex = 17
        Me.lblPrice.Text = "Charge"
        '
        'dgvServiceItem
        '
        Me.dgvServiceItem.AllowUserToAddRows = False
        Me.dgvServiceItem.AllowUserToDeleteRows = False
        Me.dgvServiceItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiceItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvServiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServiceItem.Location = New System.Drawing.Point(0, 0)
        Me.dgvServiceItem.Name = "dgvServiceItem"
        Me.dgvServiceItem.ReadOnly = True
        Me.dgvServiceItem.RowTemplate.Height = 24
        Me.dgvServiceItem.Size = New System.Drawing.Size(648, 193)
        Me.dgvServiceItem.TabIndex = 0
        '
        'frmServiceItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 310)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmServiceItem"
        Me.Text = "Service Item"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvServiceItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvServiceItem As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtServiceItem As TextBox
    Friend WithEvents lblServiceItem As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
End Class
