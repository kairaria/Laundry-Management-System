Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Sub Login()
        If (txtUname.Text = "Admin" And txtPword.Text = "Allblacks@7") Then
            SetAdminMode(True)
            Panel1.Visible = False
            'txtPword.Text = ""
            uname = txtUname.Text
            lblWelcome.Text = "WELCOME " & uname.ToUpper
            tmrLogin.Start()
            frmMain.LogOutToolStripMenuItem.Enabled = True
        ElseIf (txtUname.Text = "Report" And txtPword.Text = "Hillside2023") Then
            ReportViewer = True
            Panel1.Visible = False
                'txtPword.Text = ""
                uname = txtUname.Text
                lblWelcome.Text = "WELCOME " & uname.ToUpper
                tmrLogin.Start()
            frmMain.LogOutToolStripMenuItem.Enabled = True
        Else
            lblValidate.Visible = True
            txtUname.Text = ""
            txtPword.Text = ""
            'AdminMode = False
            'ReportViewer = False
            Exit Sub
        End If
    End Sub
    Dim ctr As Integer
    Private Sub tmrLogin_Tick(sender As Object, e As EventArgs) Handles tmrLogin.Tick
        ctr += 1
        If ctr >= 3 Then
            tmrLogin.Stop()
            frmMain.Show()
            ctr = 0
            Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        AdminMode = False
    End Sub
End Class