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
        Me.lblReadMethod = New System.Windows.Forms.Label()
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnShowReadMethod = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblReadMethod)
        Me.Panel1.Controls.Add(Me.lblDisplayArea)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 354)
        Me.Panel1.TabIndex = 0
        '
        'lblReadMethod
        '
        Me.lblReadMethod.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReadMethod.Location = New System.Drawing.Point(1, 269)
        Me.lblReadMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReadMethod.Name = "lblReadMethod"
        Me.lblReadMethod.Size = New System.Drawing.Size(635, 29)
        Me.lblReadMethod.TabIndex = 1
        Me.lblReadMethod.Text = "Label1"
        Me.lblReadMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReadMethod.Visible = False
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.BackColor = System.Drawing.Color.LightGray
        Me.lblDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDisplayArea.Location = New System.Drawing.Point(0, 0)
        Me.lblDisplayArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(637, 354)
        Me.lblDisplayArea.TabIndex = 0
        Me.lblDisplayArea.Text = "東西南北"
        Me.lblDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReStart
        '
        Me.btnReStart.Enabled = False
        Me.btnReStart.Location = New System.Drawing.Point(16, 384)
        Me.btnReStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(152, 60)
        Me.btnReStart.TabIndex = 4
        Me.btnReStart.Text = "もう一度"
        Me.btnReStart.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(504, 384)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(152, 60)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "次へ"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnShowReadMethod
        '
        Me.btnShowReadMethod.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.eyes
        Me.btnShowReadMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowReadMethod.Location = New System.Drawing.Point(306, 384)
        Me.btnShowReadMethod.Name = "btnShowReadMethod"
        Me.btnShowReadMethod.Size = New System.Drawing.Size(60, 60)
        Me.btnShowReadMethod.TabIndex = 5
        Me.btnShowReadMethod.UseVisualStyleBackColor = True
        '
        'frmShowOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 455)
        Me.Controls.Add(Me.btnShowReadMethod)
        Me.Controls.Add(Me.btnReStart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmShowOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowOthers"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDisplayArea As Label
    Friend WithEvents btnReStart As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblReadMethod As Label
    Friend WithEvents btnShowReadMethod As Button
End Class
