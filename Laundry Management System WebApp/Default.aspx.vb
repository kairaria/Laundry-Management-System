Imports System.Windows.Forms

Public Class _Default
    Inherits Page

    Private WithEvents mdiContainer As MdiClient

    Sub MDIBGColor()
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.

        For Each ctl In Controls.OfType(Of MdiClient)
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)
                mdiContainer = DirectCast(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = ctl.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MDIBGColor()

        'LogOutToolStripMenuItem.Enabled = False
        AdminMode = False
        NewWorkOrder = False
        WorkOrderPickup = False
    End Sub
End Class