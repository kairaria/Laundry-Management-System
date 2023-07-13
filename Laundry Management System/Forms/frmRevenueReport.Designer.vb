<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRevenueReport
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
        Me.spcRevenueReport = New System.Windows.Forms.SplitContainer()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crRevenueReport1 = New Laundry_Management_System.crRevenueReport()
        CType(Me.spcRevenueReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcRevenueReport.Panel2.SuspendLayout()
        Me.spcRevenueReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcRevenueReport
        '
        Me.spcRevenueReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcRevenueReport.Location = New System.Drawing.Point(0, 0)
        Me.spcRevenueReport.Name = "spcRevenueReport"
        Me.spcRevenueReport.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcRevenueReport.Panel2
        '
        Me.spcRevenueReport.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.spcRevenueReport.Size = New System.Drawing.Size(800, 450)
        Me.spcRevenueReport.SplitterDistance = 61
        Me.spcRevenueReport.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.crRevenueReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 385)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmRevenueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.spcRevenueReport)
        Me.Name = "frmRevenueReport"
        Me.Text = "Revenue Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spcRevenueReport.Panel2.ResumeLayout(False)
        CType(Me.spcRevenueReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcRevenueReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spcRevenueReport As SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crRevenueReport1 As crRevenueReport
End Class
