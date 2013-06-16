Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Public Class rLoginForm

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        MyBase.Hide()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim webClient As New System.Net.WebClient
        Dim sessUrl As String = "https://login.minecraft.net/?user=" + Me.username.Text + "&password=" + Me.password.Text + "&version=13"
        Dim result As String = webClient.DownloadString(sessUrl)
        Dim resu As String = result
        Dim res = result.Split(":")
        If result.ToString = "Bad login" Then
            Me.isstatus.Text = "กรุณาตรวจสอบชื่อด้วยครับ"
            'Dim Minecraft As Minecraft = New Minecraft
            'Minecraft.rLogin(Me.username.Text, Me.password.Text)
        ElseIf result.ToString = "Bad request" Then
            Me.isstatus.Text = "กรุณาเรียกทีมงานเพื่อแก้ไขครับ"
        Else
            Me.isstatus.Text = "ยินดีต้อรับครับ " + res(2)
            System.Threading.Thread.Sleep(2000)
            Me.isstatus.Text = "กำลังตรวจสอบเวอรชั่น"
            Me.mclaunch()
        End If
    End Sub
    Private Sub mclaunch()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://get.rockerger.com/launcher/last/lc-Version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim mclauncher As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.mc-re"
            Dim currentversion As StreamReader = New StreamReader(mclauncher & "\bin\")
            Dim versionnow As String = currentversion.ReadToEnd()
            If newestversion.Contains(versionnow) Then
                Class2.launch()
            Else
                MsgBox("ตัวเกมไม่ตรงกับเวอร์ชั่น กรุณาไปกด อัพเดทตัวเกม", MsgBoxStyle.OkOnly)
            End If
        Catch

        End Try
    End Sub
End Class