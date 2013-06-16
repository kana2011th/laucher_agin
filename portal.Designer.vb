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
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnopenvol = New System.Windows.Forms.Button()
        Me.btntopup = New System.Windows.Forms.Button()
        Me.btnrstop = New System.Windows.Forms.Button()
        Me.btnwlink = New System.Windows.Forms.Button()
        Me.btnjoin = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.player)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnopenvol)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btntopup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnrstop)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnwlink)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnjoin)
        Me.SplitContainer1.Panel1.Margin = New System.Windows.Forms.Padding(4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 281)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(3, 168)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(122, 38)
        Me.player.TabIndex = 10
        Me.player.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.kana2011th.relauncher.My.Resources.Resource1.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 209)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 50)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
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
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(355, 190)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://get.rockerger.com/?m=launcher", System.UriKind.Absolute)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowMerge = False
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status1, Me.Label2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 259)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status1
        '
        Me.status1.BackColor = System.Drawing.SystemColors.Control
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(0, 17)
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 17)
        Me.Label2.Spring = True
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'portal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 281)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 320)
        Me.MinimumSize = New System.Drawing.Size(500, 320)
        Me.Name = "portal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC ROCKERGER | Portal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnjoin As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnwlink As System.Windows.Forms.Button
    Friend WithEvents btnrstop As System.Windows.Forms.Button
    Friend WithEvents btntopup As System.Windows.Forms.Button
    Friend WithEvents btnopenvol As System.Windows.Forms.Button
    Friend WithEvents status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer

End Class
