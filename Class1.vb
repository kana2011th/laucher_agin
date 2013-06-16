Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Public Class Minecraft
    Public Shared Sub getVersion(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Shared Sub getJavaPath(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Shared Sub rLogin(ByVal user As System.Object, ByVal pass As System.Object)

    End Sub
    Public Shared Sub fLogin(ByVal user As System.Object, ByVal pass As System.Object)
        Dim webClient As New System.Net.WebClient
        Try
            Dim sessUrl As String = "https://login.minecraft.net/?user=" + user + "&password=" + pass + "&version=13"
            Dim result As String = webClient.DownloadString(sessUrl)
            rLoginForm.isstatus.Text = result
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub mclaunch()
        Dim webClient As New System.Net.WebClient
        Dim sessUrl As String = "https://login.minecraft.net/?user=" + rLoginForm.username.Text + "&password=" + rLoginForm.password.Text + "&version=13"
        Dim result As String = webClient.DownloadString(sessUrl)
        Dim res = result.Split(":")
        Dim startup As String = "java -Xms512m -Xmx1g -Djava.library.path=\bin\natives -cp " + Chr(34) + "minecraft.jar;lwjgl.jar;lwjgl_util.jar" + Chr(34) + " net.minecraft.client.Minecraft " + res(2) + " " + res(0) + ""
        System.Diagnostics.Process.Start(startup)
    End Sub
    Public Sub CheckForUpdates()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://get.rockerger.com/launcher/last/lc-Version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim mclauncher As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.mc-re"
            Dim currentversion As StreamReader = New StreamReader(mclauncher & "\bin\")
            Dim versionnow As String = currentversion.ReadToEnd()
            If newestversion.Contains(versionnow) Then
                MsgBox("ตัวเกมตรงเวอร์ชั่นแล้ว")
            Else
                MsgBox("ตัวเกมไม่ตรงกับเวอร์ชั่น จะทำการดาวโหลดให้.", MsgBoxStyle.OkOnly)
            End If
        Catch
            MsgBox("ระบบยังไม่พร้อมให้ใช้ครับ กรุณาลองภายหลัง", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class