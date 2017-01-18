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
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblReadMethod = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblReadMethod)
        Me.Panel1.Controls.Add(Me.lblDisplayArea)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 283)
        Me.Panel1.TabIndex = 0
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDisplayArea.Location = New System.Drawing.Point(0, 0)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(478, 283)
        Me.lblDisplayArea.TabIndex = 0
        Me.lblDisplayArea.Text = "東西南北"
        Me.lblDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReStart
        '
        Me.btnReStart.Enabled = False
        Me.btnReStart.Location = New System.Drawing.Point(12, 301)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(114, 34)
        Me.btnReStart.TabIndex = 4
        Me.btnReStart.Text = "もう一度"
        Me.btnReStart.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(378, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 34)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "次へ"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblReadMethod
        '
        Me.lblReadMethod.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReadMethod.Location = New System.Drawing.Point(3, 215)
        Me.lblReadMethod.Name = "lblReadMethod"
        Me.lblReadMethod.Size = New System.Drawing.Size(472, 23)
        Me.lblReadMethod.TabIndex = 1
        Me.lblReadMethod.Text = "Label1"
        Me.lblReadMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmShowOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 344)
        Me.Controls.Add(Me.btnReStart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
End Class
