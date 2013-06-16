<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.radreal = New System.Windows.Forms.RadioButton()
        Me.btndownload = New System.Windows.Forms.Button()
        Me.btnjoin = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.SplitContainer1.Panel1.BackgroundImage = Global.kana2011th.relauncher.My.Resources.Resource1.splash1
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(284, 261)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RadioButton2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.radreal)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btndownload)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnjoin)
        Me.SplitContainer2.Size = New System.Drawing.Size(284, 54)
        Me.SplitContainer2.SplitterDistance = 116
        Me.SplitContainer2.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(4, 27)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "ไม่มีไอดีแท้"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'radreal
        '
        Me.radreal.AutoSize = True
        Me.radreal.Checked = True
        Me.radreal.Location = New System.Drawing.Point(4, 4)
        Me.radreal.Name = "radreal"
        Me.radreal.Size = New System.Drawing.Size(66, 17)
        Me.radreal.TabIndex = 0
        Me.radreal.TabStop = True
        Me.radreal.Text = "มีไอดีแท้"
        Me.radreal.UseVisualStyleBackColor = True
        '
        'btndownload
        '
        Me.btndownload.Location = New System.Drawing.Point(3, 27)
        Me.btndownload.Name = "btndownload"
        Me.btndownload.Size = New System.Drawing.Size(158, 23)
        Me.btndownload.TabIndex = 1
        Me.btndownload.Text = "อัพเดทตัวเกม"
        Me.btndownload.UseVisualStyleBackColor = True
        '
        'btnjoin
        '
        Me.btnjoin.Location = New System.Drawing.Point(3, 4)
        Me.btnjoin.Name = "btnjoin"
        Me.btnjoin.Size = New System.Drawing.Size(158, 23)
        Me.btnjoin.TabIndex = 0
        Me.btnjoin.Text = "เข้าสู่ระบบ"
        Me.btnjoin.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC ROCKERGER | Login"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radreal As System.Windows.Forms.RadioButton
    Friend WithEvents btndownload As System.Windows.Forms.Button
    Friend WithEvents btnjoin As System.Windows.Forms.Button
End Class
