Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Web
Public Class Form3
    Private Sub btnjoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjoin.Click
        Dim mclauncher As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.mc-re"
        If radreal.Checked = True Then
            Try
                rLoginForm.show()
            Catch
            End Try
        End If
        If radreal.Checked = False Then
            Try
                Shell(mclauncher & "\MinecraftSP.jar")
                GoTo C3
            Catch
                GoTo C1
            End Try
C1:         Try
                Shell(mclauncher & "\MinecraftSP.exe")
            Catch
                MsgBox("ไม่พบตัวเกม MineCraftSP", vbExclamation)
                GoTo C3
            End Try
        End If
C3:
    End Sub
    Public Sub CheckForUpdates()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://get.rockerger.com/launcher/last/lc-Version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim mclauncher As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.mc-re"
            Dim currentversion As StreamReader = New StreamReader(mclauncher & "\lc-Version.txt")
            Dim versionnow As String = currentversion.ReadToEnd()
            If newestversion.Contains(versionnow) Then
                MsgBox("ตัวเกมตรงเวอร์ชั่นแล้ว")
            ElseIf newestversion.Contains(Nothing) Then
                Try
                    Dim client As WebClient = New WebClient
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/lc-Version.txt"), mclauncher & "\lc-Version.txt")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/minecraft.jar"), mclauncher & "\bin\minecraft.jar")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/jinput.jar"), mclauncher & "\bin\jinput.jar")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/lwjgl.jar"), mclauncher & "\bin\lwjgl.jar")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/lwjgl_util.jar"), mclauncher & "\bin\lwjgl_util.jar")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesjinput-dx8.dll"), mclauncher & "\bin\natives\jinput-dx8.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesjinput-dx8_64.dll"), mclauncher & "\bin\natives\jinput-dx8_64.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesjinput-raw.dll"), mclauncher & "\bin\natives\jinput-raw.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesjinput-raw_64.dll"), mclauncher & "\bin\natives\jinput-raw_64.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativeslwjgl.dll"), mclauncher & "\bin\natives\lwjgl.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativeslwjgl64.dll"), mclauncher & "\bin\natives\lwjgl64.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesOpenAL32.dll"), mclauncher & "\bin\natives\OpenAL32.dll")
                    client.DownloadFileAsync(New Uri("http://get.rockerger.com/launcher/last/bin/nativesOpenAL64.dll"), mclauncher & "\bin\natives\OpenAL64.dll")
                Catch

                End Try

            End If
        Catch
            Dim mclauncher As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.mc-re"
            MsgBox("ระบบยังไม่พร้อมให้ใช้ครับ กรุณาลองภายหลัง" + mclauncher, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btndownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndownload.Click
        CheckForUpdates()
    End Sub
End Class