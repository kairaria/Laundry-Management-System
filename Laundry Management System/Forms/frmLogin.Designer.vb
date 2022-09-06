<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.txtPword = New System.Windows.Forms.TextBox()
        Me.lblValidate = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.tmrLogin = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblValidate)
        Me.Panel1.Controls.Add(Me.txtPword)
        Me.Panel1.Controls.Add(Me.txtUname)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.pnTitle)
        Me.Panel1.Location = New System.Drawing.Point(276, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 440)
        Me.Panel1.TabIndex = 0
        '
        'pnTitle
        '
        Me.pnTitle.BackColor = System.Drawing.Color.Teal
        Me.pnTitle.Controls.Add(Me.lblTitle)
        Me.pnTitle.Location = New System.Drawing.Point(0, 1)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(644, 59)
        Me.pnTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(256, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(103, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Login"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUsername.Location = New System.Drawing.Point(89, 121)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(173, 38)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Location = New System.Drawing.Point(102, 234)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(160, 38)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUname.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.txtUname.Location = New System.Drawing.Point(101, 166)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(415, 46)
        Me.txtUname.TabIndex = 1
        '
        'txtPword
        '
        Me.txtPword.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPword.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.txtPword.Location = New System.Drawing.Point(101, 275)
        Me.txtPword.Name = "txtPword"
        Me.txtPword.Size = New System.Drawing.Size(415, 46)
        Me.txtPword.TabIndex = 2
        '
        'lblValidate
        '
        Me.lblValidate.AutoSize = True
        Me.lblValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValidate.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblValidate.Location = New System.Drawing.Point(92, 87)
        Me.lblValidate.Name = "lblValidate"
        Me.lblValidate.Size = New System.Drawing.Size(435, 23)
        Me.lblValidate.TabIndex = 5
        Me.lblValidate.Text = "*Missing/Invalid Username and/or Password"
        Me.lblValidate.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(137, 342)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 54)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Lime
        Me.btnLogin.Location = New System.Drawing.Point(321, 342)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 54)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1168, 59)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrLogin
        '
        Me.tmrLogin.Interval = 1000
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(1168, 714)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTitle.ResumeLayout(False)
        Me.pnTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblValidate As Label
    Friend WithEvents txtPword As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents tmrLogin As Timer
End Class
