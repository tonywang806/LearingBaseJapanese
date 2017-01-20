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
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFixed = New System.Windows.Forms.RadioButton()
        Me.btnEigth = New System.Windows.Forms.Button()
        Me.btnSeventh = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnNinth = New System.Windows.Forms.Button()
        Me.lblGithubLink = New System.Windows.Forms.LinkLabel()
        Me.pnlFavoriteIcon = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDisplayOrderSetting = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlFavoriteIcon.SuspendLayout()
        Me.grpDisplayOrderSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 185)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(154, 35)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "五十音図の書き取り"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.Location = New System.Drawing.Point(291, 53)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(204, 35)
        Me.btnSecond.TabIndex = 0
        Me.btnSecond.Tag = "Date"
        Me.btnSecond.Text = "日付の書き取り"
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(291, 137)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(204, 33)
        Me.btnThird.TabIndex = 0
        Me.btnThird.Tag = "Numberic"
        Me.btnThird.Text = "数値の書き取り"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'btnSixth
        '
        Me.btnSixth.Location = New System.Drawing.Point(184, 185)
        Me.btnSixth.Name = "btnSixth"
        Me.btnSixth.Size = New System.Drawing.Size(91, 35)
        Me.btnSixth.TabIndex = 0
        Me.btnSixth.Tag = "Place"
        Me.btnSixth.Text = "地名の書き取り"
        Me.btnSixth.UseVisualStyleBackColor = True
        '
        'btnForth
        '
        Me.btnForth.Location = New System.Drawing.Point(291, 96)
        Me.btnForth.Name = "btnForth"
        Me.btnForth.Size = New System.Drawing.Size(204, 33)
        Me.btnForth.TabIndex = 0
        Me.btnForth.Tag = "Weeks"
        Me.btnForth.Text = "曜日の書き取り"
        Me.btnForth.UseVisualStyleBackColor = True
        '
        'btnFifth
        '
        Me.btnFifth.Location = New System.Drawing.Point(291, 12)
        Me.btnFifth.Name = "btnFifth"
        Me.btnFifth.Size = New System.Drawing.Size(204, 33)
        Me.btnFifth.TabIndex = 0
        Me.btnFifth.Tag = "Month"
        Me.btnFifth.Text = "月の書き取り"
        Me.btnFifth.UseVisualStyleBackColor = True
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Checked = True
        Me.rdoRandom.Location = New System.Drawing.Point(106, 21)
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
        Me.rdoFixed.Location = New System.Drawing.Point(11, 21)
        Me.rdoFixed.Name = "rdoFixed"
        Me.rdoFixed.Size = New System.Drawing.Size(63, 16)
        Me.rdoFixed.TabIndex = 0
        Me.rdoFixed.Text = "フィクスト"
        Me.rdoFixed.UseVisualStyleBackColor = True
        '
        'btnEigth
        '
        Me.btnEigth.Location = New System.Drawing.Point(125, 226)
        Me.btnEigth.Name = "btnEigth"
        Me.btnEigth.Size = New System.Drawing.Size(150, 35)
        Me.btnEigth.TabIndex = 3
        Me.btnEigth.Tag = "Orientation"
        Me.btnEigth.Text = "方位の書き取り"
        Me.btnEigth.UseVisualStyleBackColor = True
        '
        'btnSeventh
        '
        Me.btnSeventh.Location = New System.Drawing.Point(12, 226)
        Me.btnSeventh.Name = "btnSeventh"
        Me.btnSeventh.Size = New System.Drawing.Size(93, 35)
        Me.btnSeventh.TabIndex = 4
        Me.btnSeventh.Tag = "Direction"
        Me.btnSeventh.Text = "方向の書き取り"
        Me.btnSeventh.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(395, 316)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(100, 23)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Ver.0.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNinth
        '
        Me.btnNinth.Location = New System.Drawing.Point(12, 267)
        Me.btnNinth.Name = "btnNinth"
        Me.btnNinth.Size = New System.Drawing.Size(263, 35)
        Me.btnNinth.TabIndex = 3
        Me.btnNinth.Tag = "Color"
        Me.btnNinth.Text = "色の書き取り"
        Me.btnNinth.UseVisualStyleBackColor = True
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.LinkVisited = True
        Me.lblGithubLink.Location = New System.Drawing.Point(58, 321)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(252, 12)
        Me.lblGithubLink.TabIndex = 7
        Me.lblGithubLink.TabStop = True
        Me.lblGithubLink.Text = "https://github.com/tonywang806/BaseJapanese"
        '
        'pnlFavoriteIcon
        '
        Me.pnlFavoriteIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlFavoriteIcon.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.黄道十二宫
        Me.pnlFavoriteIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlFavoriteIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFavoriteIcon.Controls.Add(Me.Label1)
        Me.pnlFavoriteIcon.Location = New System.Drawing.Point(12, 12)
        Me.pnlFavoriteIcon.Name = "pnlFavoriteIcon"
        Me.pnlFavoriteIcon.Size = New System.Drawing.Size(263, 158)
        Me.pnlFavoriteIcon.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "点我有惊喜！"
        '
        'grpDisplayOrderSetting
        '
        Me.grpDisplayOrderSetting.Controls.Add(Me.rdoRandom)
        Me.grpDisplayOrderSetting.Controls.Add(Me.rdoFixed)
        Me.grpDisplayOrderSetting.Location = New System.Drawing.Point(291, 185)
        Me.grpDisplayOrderSetting.Name = "grpDisplayOrderSetting"
        Me.grpDisplayOrderSetting.Size = New System.Drawing.Size(204, 51)
        Me.grpDisplayOrderSetting.TabIndex = 8
        Me.grpDisplayOrderSetting.TabStop = False
        Me.grpDisplayOrderSetting.Text = "表示順位"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(291, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 48)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "grpPlayMode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Github:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(509, 342)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDisplayOrderSetting)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnNinth)
        Me.Controls.Add(Me.btnEigth)
        Me.Controls.Add(Me.btnSeventh)
        Me.Controls.Add(Me.pnlFavoriteIcon)
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
        Me.pnlFavoriteIcon.ResumeLayout(False)
        Me.pnlFavoriteIcon.PerformLayout()
        Me.grpDisplayOrderSetting.ResumeLayout(False)
        Me.grpDisplayOrderSetting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSecond As Button
    Friend WithEvents btnThird As Button
    Friend WithEvents btnSixth As Button
    Friend WithEvents btnForth As Button
    Friend WithEvents btnFifth As Button
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFixed As RadioButton
    Friend WithEvents pnlFavoriteIcon As Panel
    Friend WithEvents btnEigth As Button
    Friend WithEvents btnSeventh As Button
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnNinth As Button
    Friend WithEvents lblGithubLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents grpDisplayOrderSetting As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
End Class
