Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Public Class rLoginForm
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        MyBase.Hide()
        portal.Show()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        Minecraft.rLogin(Me.username.Text, Me.password.Text)
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
    Public Sub Wait(ByVal seconds As Single)
        Dim newDate As Date
        newDate = Now.AddSeconds(seconds)

        While Now.Ticks <= New Date().Ticks

            Application.DoEvents()

        End While

    End Sub
End Class