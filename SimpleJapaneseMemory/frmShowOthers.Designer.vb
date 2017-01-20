<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowOthers
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowOthers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShowReadMethod = New System.Windows.Forms.Button()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.lblReadMethod = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.BlackBoard
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnShowReadMethod)
        Me.Panel1.Controls.Add(Me.btnReStart)
        Me.Panel1.Controls.Add(Me.lblReadMethod)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.lblDisplayArea)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 537)
        Me.Panel1.TabIndex = 0
        '
        'btnShowReadMethod
        '
        Me.btnShowReadMethod.BackColor = System.Drawing.Color.Transparent
        Me.btnShowReadMethod.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.eyes_w
        Me.btnShowReadMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowReadMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowReadMethod.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnShowReadMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShowReadMethod.Location = New System.Drawing.Point(820, 421)
        Me.btnShowReadMethod.Name = "btnShowReadMethod"
        Me.btnShowReadMethod.Size = New System.Drawing.Size(60, 60)
        Me.btnShowReadMethod.TabIndex = 5
        Me.btnShowReadMethod.UseVisualStyleBackColor = False
        '
        'btnReStart
        '
        Me.btnReStart.BackColor = System.Drawing.Color.Transparent
        Me.btnReStart.Enabled = False
        Me.btnReStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnReStart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReStart.Location = New System.Drawing.Point(661, 421)
        Me.btnReStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(152, 60)
        Me.btnReStart.TabIndex = 4
        Me.btnReStart.Text = "もう一度"
        Me.btnReStart.UseVisualStyleBackColor = False
        '
        'lblReadMethod
        '
        Me.lblReadMethod.BackColor = System.Drawing.Color.Transparent
        Me.lblReadMethod.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReadMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReadMethod.Location = New System.Drawing.Point(54, 104)
        Me.lblReadMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReadMethod.Name = "lblReadMethod"
        Me.lblReadMethod.Size = New System.Drawing.Size(998, 29)
        Me.lblReadMethod.TabIndex = 1
        Me.lblReadMethod.Text = "Label1"
        Me.lblReadMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReadMethod.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(887, 421)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(152, 60)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "次へ"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDisplayArea.ForeColor = System.Drawing.Color.Transparent
        Me.lblDisplayArea.Location = New System.Drawing.Point(0, 24)
        Me.lblDisplayArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(1100, 405)
        Me.lblDisplayArea.TabIndex = 0
        Me.lblDisplayArea.Text = "東西南北"
        Me.lblDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(887, 354)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 60)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "終わり"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmShowOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 537)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmShowOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowOthers"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDisplayArea As Label
    Friend WithEvents btnReStart As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblReadMethod As Label
    Friend WithEvents btnShowReadMethod As Button
    Friend WithEvents btnClose As Button
End Class
