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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlFavoriteIcon.SuspendLayout()
        Me.grpDisplayOrderSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(16, 231)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(124, 44)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "五十音図"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.Location = New System.Drawing.Point(357, 282)
        Me.btnSecond.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(124, 44)
        Me.btnSecond.TabIndex = 0
        Me.btnSecond.Tag = "Date"
        Me.btnSecond.Text = "日付"
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(185, 231)
        Me.btnThird.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(124, 44)
        Me.btnThird.TabIndex = 0
        Me.btnThird.Tag = "Numberic"
        Me.btnThird.Text = "数値"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'btnSixth
        '
        Me.btnSixth.Location = New System.Drawing.Point(185, 334)
        Me.btnSixth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSixth.Name = "btnSixth"
        Me.btnSixth.Size = New System.Drawing.Size(124, 44)
        Me.btnSixth.TabIndex = 0
        Me.btnSixth.Tag = "Place"
        Me.btnSixth.Text = "地名"
        Me.btnSixth.UseVisualStyleBackColor = True
        '
        'btnForth
        '
        Me.btnForth.Location = New System.Drawing.Point(357, 334)
        Me.btnForth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnForth.Name = "btnForth"
        Me.btnForth.Size = New System.Drawing.Size(124, 44)
        Me.btnForth.TabIndex = 0
        Me.btnForth.Tag = "Weeks"
        Me.btnForth.Text = "曜日"
        Me.btnForth.UseVisualStyleBackColor = True
        '
        'btnFifth
        '
        Me.btnFifth.Location = New System.Drawing.Point(357, 231)
        Me.btnFifth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFifth.Name = "btnFifth"
        Me.btnFifth.Size = New System.Drawing.Size(124, 44)
        Me.btnFifth.TabIndex = 0
        Me.btnFifth.Tag = "Month"
        Me.btnFifth.Text = "月"
        Me.btnFifth.UseVisualStyleBackColor = True
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Checked = True
        Me.rdoRandom.Location = New System.Drawing.Point(15, 59)
        Me.rdoRandom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(72, 19)
        Me.rdoRandom.TabIndex = 0
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Text = "ランダム"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFixed
        '
        Me.rdoFixed.AutoSize = True
        Me.rdoFixed.Location = New System.Drawing.Point(15, 26)
        Me.rdoFixed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoFixed.Name = "rdoFixed"
        Me.rdoFixed.Size = New System.Drawing.Size(78, 19)
        Me.rdoFixed.TabIndex = 0
        Me.rdoFixed.Text = "フィクスト"
        Me.rdoFixed.UseVisualStyleBackColor = True
        '
        'btnEigth
        '
        Me.btnEigth.Location = New System.Drawing.Point(185, 282)
        Me.btnEigth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEigth.Name = "btnEigth"
        Me.btnEigth.Size = New System.Drawing.Size(124, 44)
        Me.btnEigth.TabIndex = 3
        Me.btnEigth.Tag = "Orientation"
        Me.btnEigth.Text = "方位"
        Me.btnEigth.UseVisualStyleBackColor = True
        '
        'btnSeventh
        '
        Me.btnSeventh.Location = New System.Drawing.Point(16, 282)
        Me.btnSeventh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSeventh.Name = "btnSeventh"
        Me.btnSeventh.Size = New System.Drawing.Size(124, 44)
        Me.btnSeventh.TabIndex = 4
        Me.btnSeventh.Tag = "Direction"
        Me.btnSeventh.Text = "方向"
        Me.btnSeventh.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(348, 15)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(133, 29)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Ver.0.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNinth
        '
        Me.btnNinth.Location = New System.Drawing.Point(16, 334)
        Me.btnNinth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNinth.Name = "btnNinth"
        Me.btnNinth.Size = New System.Drawing.Size(124, 44)
        Me.btnNinth.TabIndex = 3
        Me.btnNinth.Tag = "Color"
        Me.btnNinth.Text = "色"
        Me.btnNinth.UseVisualStyleBackColor = True
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.LinkVisited = True
        Me.lblGithubLink.Location = New System.Drawing.Point(19, 416)
        Me.lblGithubLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(425, 15)
        Me.lblGithubLink.TabIndex = 7
        Me.lblGithubLink.TabStop = True
        Me.lblGithubLink.Text = "https://github.com/tonywang806/LearingBaseJapanese/releases"
        '
        'pnlFavoriteIcon
        '
        Me.pnlFavoriteIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlFavoriteIcon.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.黄道十二宫
        Me.pnlFavoriteIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlFavoriteIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFavoriteIcon.Controls.Add(Me.Label1)
        Me.pnlFavoriteIcon.Location = New System.Drawing.Point(16, 15)
        Me.pnlFavoriteIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFavoriteIcon.Name = "pnlFavoriteIcon"
        Me.pnlFavoriteIcon.Size = New System.Drawing.Size(293, 197)
        Me.pnlFavoriteIcon.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click me"
        '
        'grpDisplayOrderSetting
        '
        Me.grpDisplayOrderSetting.Controls.Add(Me.rdoRandom)
        Me.grpDisplayOrderSetting.Controls.Add(Me.rdoFixed)
        Me.grpDisplayOrderSetting.Location = New System.Drawing.Point(317, 55)
        Me.grpDisplayOrderSetting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDisplayOrderSetting.Name = "grpDisplayOrderSetting"
        Me.grpDisplayOrderSetting.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDisplayOrderSetting.Size = New System.Drawing.Size(164, 90)
        Me.grpDisplayOrderSetting.TabIndex = 8
        Me.grpDisplayOrderSetting.TabStop = False
        Me.grpDisplayOrderSetting.Text = "表示順位"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(317, 152)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(164, 60)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "モード"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 398)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Github:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(16, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 1)
        Me.Label3.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(499, 446)
        Me.Controls.Add(Me.Label3)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "基本日本語"
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
    Friend WithEvents Label3 As Label
End Class
