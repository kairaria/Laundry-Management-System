Public Class frmMain
    Sub MDIBGColor()
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try

                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIBGColor()
        tmrSysDateTime.Start()
    End Sub

    Private Sub tmrSysDateTime_Tick(sender As Object, e As EventArgs) Handles tmrSysDateTime.Tick
        lblSysDate.Text = Format(Now, "long date")
        lblSystemTime.Text = TimeOfDay
    End Sub
End Class