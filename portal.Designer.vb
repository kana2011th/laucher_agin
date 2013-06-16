<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class portal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(portal))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnopenvol = New System.Windows.Forms.Button()
        Me.btntopup = New System.Windows.Forms.Button()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnrstop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnwlink = New System.Windows.Forms.Button()
        Me.btnjoin = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnopenvol)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btntopup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.player)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnrstop)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnwlink)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnjoin)
        Me.SplitContainer1.Panel1.Margin = New System.Windows.Forms.Padding(4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 281)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'btnopenvol
        '
        Me.btnopenvol.Location = New System.Drawing.Point(0, 132)
        Me.btnopenvol.Margin = New System.Windows.Forms.Padding(0)
        Me.btnopenvol.Name = "btnopenvol"
        Me.btnopenvol.Padding = New System.Windows.Forms.Padding(4)
        Me.btnopenvol.Size = New System.Drawing.Size(128, 33)
        Me.btnopenvol.TabIndex = 6
        Me.btnopenvol.Text = "ปรับเสียง"
        Me.btnopenvol.UseVisualStyleBackColor = True
        '
        'btntopup
        '
        Me.btntopup.Location = New System.Drawing.Point(0, 66)
        Me.btntopup.Margin = New System.Windows.Forms.Padding(0)
        Me.btntopup.Name = "btntopup"
        Me.btntopup.Padding = New System.Windows.Forms.Padding(4)
        Me.btntopup.Size = New System.Drawing.Size(128, 33)
        Me.btntopup.TabIndex = 5
        Me.btntopup.Text = "เติมเงิน"
        Me.btntopup.UseVisualStyleBackColor = True
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(0, 222)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(128, 34)
        Me.player.TabIndex = 4
        Me.player.Visible = False
        '
        'btnrstop
        '
        Me.btnrstop.Location = New System.Drawing.Point(0, 99)
        Me.btnrstop.Margin = New System.Windows.Forms.Padding(0)
        Me.btnrstop.Name = "btnrstop"
        Me.btnrstop.Padding = New System.Windows.Forms.Padding(4)
        Me.btnrstop.Size = New System.Drawing.Size(128, 33)
        Me.btnrstop.TabIndex = 4
        Me.btnrstop.Text = "ปิดเพลง"
        Me.btnrstop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "by FIG STUDIO"
        '
        'btnwlink
        '
        Me.btnwlink.Location = New System.Drawing.Point(0, 33)
        Me.btnwlink.Margin = New System.Windows.Forms.Padding(0)
        Me.btnwlink.Name = "btnwlink"
        Me.btnwlink.Padding = New System.Windows.Forms.Padding(4)
        Me.btnwlink.Size = New System.Drawing.Size(128, 33)
        Me.btnwlink.TabIndex = 2
        Me.btnwlink.Text = "เข้าเว็บเซิฟ"
        Me.btnwlink.UseVisualStyleBackColor = True
        '
        'btnjoin
        '
        Me.btnjoin.Location = New System.Drawing.Point(0, 0)
        Me.btnjoin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnjoin.Name = "btnjoin"
        Me.btnjoin.Padding = New System.Windows.Forms.Padding(4)
        Me.btnjoin.Size = New System.Drawing.Size(128, 33)
        Me.btnjoin.TabIndex = 1
        Me.btnjoin.Text = "เข้าสู่ระบบ"
        Me.btnjoin.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(355, 281)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://get.rockerger.com/?m=launcher", System.UriKind.Absolute)
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(484, 281)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 320)
        Me.MinimumSize = New System.Drawing.Size(500, 320)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC ROCKERGER | Portal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnjoin As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnwlink As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnrstop As System.Windows.Forms.Button
    Friend WithEvents btntopup As System.Windows.Forms.Button
    Friend WithEvents btnopenvol As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
