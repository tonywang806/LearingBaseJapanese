<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnThird = New System.Windows.Forms.Button()
        Me.btnSixth = New System.Windows.Forms.Button()
        Me.btnForth = New System.Windows.Forms.Button()
        Me.btnFifth = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFixed = New System.Windows.Forms.RadioButton()
        Me.btnEigth = New System.Windows.Forms.Button()
        Me.btnSeventh = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 185)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(272, 35)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "五十音図の書き取り"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.Location = New System.Drawing.Point(202, 53)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(204, 35)
        Me.btnSecond.TabIndex = 0
        Me.btnSecond.Text = "日付の書き取り"
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(202, 137)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(204, 33)
        Me.btnThird.TabIndex = 0
        Me.btnThird.Text = "数値の書き取り"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'btnSixth
        '
        Me.btnSixth.Location = New System.Drawing.Point(12, 229)
        Me.btnSixth.Name = "btnSixth"
        Me.btnSixth.Size = New System.Drawing.Size(272, 35)
        Me.btnSixth.TabIndex = 0
        Me.btnSixth.Text = "地名の書き取り"
        Me.btnSixth.UseVisualStyleBackColor = True
        '
        'btnForth
        '
        Me.btnForth.Location = New System.Drawing.Point(202, 96)
        Me.btnForth.Name = "btnForth"
        Me.btnForth.Size = New System.Drawing.Size(204, 33)
        Me.btnForth.TabIndex = 0
        Me.btnForth.Text = "曜日の書き取り"
        Me.btnForth.UseVisualStyleBackColor = True
        '
        'btnFifth
        '
        Me.btnFifth.Location = New System.Drawing.Point(202, 12)
        Me.btnFifth.Name = "btnFifth"
        Me.btnFifth.Size = New System.Drawing.Size(204, 33)
        Me.btnFifth.TabIndex = 0
        Me.btnFifth.Text = "月の書き取り"
        Me.btnFifth.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rdoRandom)
        Me.Panel1.Controls.Add(Me.rdoFixed)
        Me.Panel1.Location = New System.Drawing.Point(310, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 157)
        Me.Panel1.TabIndex = 1
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Checked = True
        Me.rdoRandom.Location = New System.Drawing.Point(10, 40)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(59, 16)
        Me.rdoRandom.TabIndex = 0
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Text = "ランダム"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFixed
        '
        Me.rdoFixed.AutoSize = True
        Me.rdoFixed.Location = New System.Drawing.Point(10, 17)
        Me.rdoFixed.Name = "rdoFixed"
        Me.rdoFixed.Size = New System.Drawing.Size(63, 16)
        Me.rdoFixed.TabIndex = 0
        Me.rdoFixed.Text = "フィクスト"
        Me.rdoFixed.UseVisualStyleBackColor = True
        '
        'btnEigth
        '
        Me.btnEigth.Location = New System.Drawing.Point(12, 309)
        Me.btnEigth.Name = "btnEigth"
        Me.btnEigth.Size = New System.Drawing.Size(272, 35)
        Me.btnEigth.TabIndex = 3
        Me.btnEigth.Text = "方位の書き取り"
        Me.btnEigth.UseVisualStyleBackColor = True
        '
        'btnSeventh
        '
        Me.btnSeventh.Location = New System.Drawing.Point(12, 268)
        Me.btnSeventh.Name = "btnSeventh"
        Me.btnSeventh.Size = New System.Drawing.Size(272, 35)
        Me.btnSeventh.TabIndex = 4
        Me.btnSeventh.Text = "方向の書き取り"
        Me.btnSeventh.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.黄道十二宫
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 158)
        Me.Panel2.TabIndex = 2
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(306, 348)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(100, 23)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Ver.1.0.2.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(420, 380)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnEigth)
        Me.Controls.Add(Me.btnSeventh)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSixth)
        Me.Controls.Add(Me.btnFifth)
        Me.Controls.Add(Me.btnThird)
        Me.Controls.Add(Me.btnForth)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.btnFirst)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "基本の日本語を書き取り"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSecond As Button
    Friend WithEvents btnThird As Button
    Friend WithEvents btnSixth As Button
    Friend WithEvents btnForth As Button
    Friend WithEvents btnFifth As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFixed As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEigth As Button
    Friend WithEvents btnSeventh As Button
    Friend WithEvents lblVersion As Label
End Class
