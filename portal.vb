Imports System
Imports System.Net
Imports WMPLib
Public Class portal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            player.URL = "http://202.162.78.200:8048/;"
            player.Ctlcontrols.play()
            player.settings.volume = "10"
            Label2.Text = Application.ProductVersion
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnjoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjoin.MouseCaptureChanged
        Form3.Show()
    End Sub
    Private Sub btnwlink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwlink.MouseCaptureChanged
        Dim theWebSite As String
        theWebSite = "http://rockerger.com/"
        'Call Shell("explorer.exe" & theWebSite, vbNormalFocus)
        System.Diagnostics.Process.Start(theWebSite)
    End Sub

    Private Sub btnjoin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjoin.Click

    End Sub

    Private Sub btnrstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrstop.Click
        Dim controls As WMPLib.IWMPControls3 = player.Ctlcontrols
        If (controls.isAvailable("stop")) Then
            controls.stop()
            btnrstop.Text = "เปิดเพลง"
            Return
        ElseIf (controls.isAvailable("play")) Then
            controls.play()
            btnrstop.Text = "ปิดเพลง"
        Else

        End If
    End Sub

    Private Sub btntopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntopup.Click
        Dim theWebSite As String
        theWebSite = "https://www.tmtopup.com/topup/?uid=24518"
        System.Diagnostics.Process.Start(theWebSite)
    End Sub

    Private Sub btnopenvol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopenvol.Click
        VolForm.Show()
    End Sub
End Class
