Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Sub Login()
        If Not txtUname.Text = "" Then
            Panel1.Visible = False
            txtPword.Text = ""
            uname = txtUname.Text
            lblWelcome.Text = "WELCOME " & uname.ToUpper
            tmrLogin.Start()
        Else
            lblValidate.Visible = True
            Exit Sub
        End If
    End Sub
    Dim ctr As Integer
    Private Sub tmrLogin_Tick(sender As Object, e As EventArgs) Handles tmrLogin.Tick
        ctr += 1
        If ctr >= 3 Then
            tmrLogin.Stop()
            frmMain.Show()
            Me.Hide()
            ctr = 0
            Panel1.Visible = True
            lblWelcome.Text = ""
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class