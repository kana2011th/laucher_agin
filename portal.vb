Imports System
Imports System.Net

Public Class portal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            player.URL = "http://202.162.78.200:8048/;"
            player.Ctlcontrols.play()
            player.settings.volume = "10"
            Label2.Text = Application.ProductVersion
        Catch ex As Exception
            Debug.Close()
        End Try
    End Sub
    Private Sub btnjoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjoin.MouseCaptureChanged
        Form3.Show()
        Me.Hide()
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

        If (player.Ctlcontrols.isAvailable("stop")) Then
            player.Ctlcontrols.stop()
            btnrstop.Text = "เปิดเพลง"
            btnopenvol.Hide()
            Return
        ElseIf (player.Ctlcontrols.isAvailable("play")) Then
            player.Ctlcontrols.play()
            btnopenvol.Show()
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
    Private Sub status_change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player.StatusChange
        If (player.status.Contains("Mikudayo")) Then
            Dim dayo As String = player.status.Replace("Mikudayo", "AutoDJ")
            status1.Text = dayo
        Else
            status1.Text = player.status
        End If
    End Sub
End Class
