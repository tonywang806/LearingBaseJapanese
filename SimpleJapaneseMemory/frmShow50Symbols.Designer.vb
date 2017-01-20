<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShow50Symbols
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShow50Symbols))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.lblSubDisplayArea = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(887, 421)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(152, 60)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "次へ"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnReStart
        '
        Me.btnReStart.BackColor = System.Drawing.Color.Transparent
        Me.btnReStart.Enabled = False
        Me.btnReStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnReStart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReStart.Location = New System.Drawing.Point(727, 421)
        Me.btnReStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(152, 60)
        Me.btnReStart.TabIndex = 2
        Me.btnReStart.Text = "もう一度"
        Me.btnReStart.UseVisualStyleBackColor = False
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDisplayArea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplayArea.Location = New System.Drawing.Point(354, 65)
        Me.lblDisplayArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(359, 329)
        Me.lblDisplayArea.TabIndex = 1
        Me.lblDisplayArea.Text = "あ"
        Me.lblDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubDisplayArea
        '
        Me.lblSubDisplayArea.BackColor = System.Drawing.Color.Transparent
        Me.lblSubDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSubDisplayArea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubDisplayArea.Location = New System.Drawing.Point(734, 205)
        Me.lblSubDisplayArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubDisplayArea.Name = "lblSubDisplayArea"
        Me.lblSubDisplayArea.Size = New System.Drawing.Size(127, 133)
        Me.lblSubDisplayArea.TabIndex = 2
        Me.lblSubDisplayArea.Text = "ア"
        Me.lblSubDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.BlackBoard
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblSubDisplayArea)
        Me.Panel1.Controls.Add(Me.btnReStart)
        Me.Panel1.Controls.Add(Me.lblDisplayArea)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 537)
        Me.Panel1.TabIndex = 3
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
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "終わり"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmShow50Symbols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 537)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmShow50Symbols"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "五十音図"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents lblDisplayArea As Label
    Friend WithEvents lblSubDisplayArea As Label
    Friend WithEvents btnReStart As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
End Class
