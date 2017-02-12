<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowFamily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowFamily))
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblGrandMother = New System.Windows.Forms.Label()
        Me.lblGrandFather = New System.Windows.Forms.Label()
        Me.pnlSister = New System.Windows.Forms.Panel()
        Me.pnlBrother = New System.Windows.Forms.Panel()
        Me.pnlLittleSister = New System.Windows.Forms.Panel()
        Me.pnlLittleBrother = New System.Windows.Forms.Panel()
        Me.pnlOldSister = New System.Windows.Forms.Panel()
        Me.pnlOldBrother = New System.Windows.Forms.Panel()
        Me.pnlUnant = New System.Windows.Forms.Panel()
        Me.pnlUncle = New System.Windows.Forms.Panel()
        Me.pnlMother = New System.Windows.Forms.Panel()
        Me.pnlFather = New System.Windows.Forms.Panel()
        Me.pnlGrandMother = New System.Windows.Forms.Panel()
        Me.pnlGrandFather = New System.Windows.Forms.Panel()
        Me.lblSister = New System.Windows.Forms.Label()
        Me.lblBrother = New System.Windows.Forms.Label()
        Me.lblLittleSister = New System.Windows.Forms.Label()
        Me.lblLittleBrother = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblOldSister = New System.Windows.Forms.Label()
        Me.lblOldBrother = New System.Windows.Forms.Label()
        Me.lblUnant = New System.Windows.Forms.Label()
        Me.lblUncle = New System.Windows.Forms.Label()
        Me.lblMother = New System.Windows.Forms.Label()
        Me.lblFather = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblBigShow = New System.Windows.Forms.Label()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.BackColor = System.Drawing.Color.Transparent
        Me.pnlBody.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.FamilyWithoutPronouce
        Me.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlBody.Controls.Add(Me.lblBigShow)
        Me.pnlBody.Controls.Add(Me.lblGrandMother)
        Me.pnlBody.Controls.Add(Me.lblGrandFather)
        Me.pnlBody.Controls.Add(Me.pnlSister)
        Me.pnlBody.Controls.Add(Me.pnlBrother)
        Me.pnlBody.Controls.Add(Me.pnlLittleSister)
        Me.pnlBody.Controls.Add(Me.pnlLittleBrother)
        Me.pnlBody.Controls.Add(Me.pnlOldSister)
        Me.pnlBody.Controls.Add(Me.pnlOldBrother)
        Me.pnlBody.Controls.Add(Me.pnlUnant)
        Me.pnlBody.Controls.Add(Me.pnlUncle)
        Me.pnlBody.Controls.Add(Me.pnlMother)
        Me.pnlBody.Controls.Add(Me.pnlFather)
        Me.pnlBody.Controls.Add(Me.pnlGrandMother)
        Me.pnlBody.Controls.Add(Me.pnlGrandFather)
        Me.pnlBody.Controls.Add(Me.lblSister)
        Me.pnlBody.Controls.Add(Me.lblBrother)
        Me.pnlBody.Controls.Add(Me.lblLittleSister)
        Me.pnlBody.Controls.Add(Me.lblLittleBrother)
        Me.pnlBody.Controls.Add(Me.Label9)
        Me.pnlBody.Controls.Add(Me.lblOldSister)
        Me.pnlBody.Controls.Add(Me.lblOldBrother)
        Me.pnlBody.Controls.Add(Me.lblUnant)
        Me.pnlBody.Controls.Add(Me.lblUncle)
        Me.pnlBody.Controls.Add(Me.lblMother)
        Me.pnlBody.Controls.Add(Me.lblFather)
        Me.pnlBody.Location = New System.Drawing.Point(301, 73)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(742, 544)
        Me.pnlBody.TabIndex = 0
        '
        'lblGrandMother
        '
        Me.lblGrandMother.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandMother.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGrandMother.ForeColor = System.Drawing.Color.White
        Me.lblGrandMother.Location = New System.Drawing.Point(441, 152)
        Me.lblGrandMother.Name = "lblGrandMother"
        Me.lblGrandMother.Size = New System.Drawing.Size(80, 20)
        Me.lblGrandMother.TabIndex = 8
        Me.lblGrandMother.Tag = "おばあさん"
        Me.lblGrandMother.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrandFather
        '
        Me.lblGrandFather.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandFather.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGrandFather.ForeColor = System.Drawing.Color.White
        Me.lblGrandFather.Location = New System.Drawing.Point(322, 152)
        Me.lblGrandFather.Name = "lblGrandFather"
        Me.lblGrandFather.Size = New System.Drawing.Size(69, 20)
        Me.lblGrandFather.TabIndex = 8
        Me.lblGrandFather.Tag = "おじいさん"
        Me.lblGrandFather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSister
        '
        Me.pnlSister.Location = New System.Drawing.Point(634, 419)
        Me.pnlSister.Name = "pnlSister"
        Me.pnlSister.Size = New System.Drawing.Size(83, 84)
        Me.pnlSister.TabIndex = 9
        '
        'pnlBrother
        '
        Me.pnlBrother.Location = New System.Drawing.Point(531, 419)
        Me.pnlBrother.Name = "pnlBrother"
        Me.pnlBrother.Size = New System.Drawing.Size(83, 84)
        Me.pnlBrother.TabIndex = 9
        '
        'pnlLittleSister
        '
        Me.pnlLittleSister.Location = New System.Drawing.Point(418, 419)
        Me.pnlLittleSister.Name = "pnlLittleSister"
        Me.pnlLittleSister.Size = New System.Drawing.Size(83, 84)
        Me.pnlLittleSister.TabIndex = 9
        '
        'pnlLittleBrother
        '
        Me.pnlLittleBrother.Location = New System.Drawing.Point(314, 419)
        Me.pnlLittleBrother.Name = "pnlLittleBrother"
        Me.pnlLittleBrother.Size = New System.Drawing.Size(83, 84)
        Me.pnlLittleBrother.TabIndex = 9
        '
        'pnlOldSister
        '
        Me.pnlOldSister.Location = New System.Drawing.Point(99, 419)
        Me.pnlOldSister.Name = "pnlOldSister"
        Me.pnlOldSister.Size = New System.Drawing.Size(83, 84)
        Me.pnlOldSister.TabIndex = 9
        '
        'pnlOldBrother
        '
        Me.pnlOldBrother.Location = New System.Drawing.Point(9, 419)
        Me.pnlOldBrother.Name = "pnlOldBrother"
        Me.pnlOldBrother.Size = New System.Drawing.Size(83, 84)
        Me.pnlOldBrother.TabIndex = 9
        '
        'pnlUnant
        '
        Me.pnlUnant.Location = New System.Drawing.Point(656, 238)
        Me.pnlUnant.Name = "pnlUnant"
        Me.pnlUnant.Size = New System.Drawing.Size(83, 84)
        Me.pnlUnant.TabIndex = 9
        '
        'pnlUncle
        '
        Me.pnlUncle.Location = New System.Drawing.Point(516, 238)
        Me.pnlUncle.Name = "pnlUncle"
        Me.pnlUncle.Size = New System.Drawing.Size(83, 84)
        Me.pnlUncle.TabIndex = 9
        '
        'pnlMother
        '
        Me.pnlMother.Location = New System.Drawing.Point(269, 233)
        Me.pnlMother.Name = "pnlMother"
        Me.pnlMother.Size = New System.Drawing.Size(83, 84)
        Me.pnlMother.TabIndex = 9
        '
        'pnlFather
        '
        Me.pnlFather.Location = New System.Drawing.Point(131, 233)
        Me.pnlFather.Name = "pnlFather"
        Me.pnlFather.Size = New System.Drawing.Size(83, 84)
        Me.pnlFather.TabIndex = 9
        '
        'pnlGrandMother
        '
        Me.pnlGrandMother.Location = New System.Drawing.Point(438, 68)
        Me.pnlGrandMother.Name = "pnlGrandMother"
        Me.pnlGrandMother.Size = New System.Drawing.Size(83, 82)
        Me.pnlGrandMother.TabIndex = 9
        '
        'pnlGrandFather
        '
        Me.pnlGrandFather.Location = New System.Drawing.Point(318, 67)
        Me.pnlGrandFather.Name = "pnlGrandFather"
        Me.pnlGrandFather.Size = New System.Drawing.Size(79, 82)
        Me.pnlGrandFather.TabIndex = 9
        '
        'lblSister
        '
        Me.lblSister.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSister.ForeColor = System.Drawing.Color.White
        Me.lblSister.Location = New System.Drawing.Point(651, 506)
        Me.lblSister.Name = "lblSister"
        Me.lblSister.Size = New System.Drawing.Size(52, 20)
        Me.lblSister.TabIndex = 8
        Me.lblSister.Tag = "いとこ"
        '
        'lblBrother
        '
        Me.lblBrother.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBrother.ForeColor = System.Drawing.Color.White
        Me.lblBrother.Location = New System.Drawing.Point(546, 506)
        Me.lblBrother.Name = "lblBrother"
        Me.lblBrother.Size = New System.Drawing.Size(52, 20)
        Me.lblBrother.TabIndex = 8
        Me.lblBrother.Tag = "いとこ"
        '
        'lblLittleSister
        '
        Me.lblLittleSister.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLittleSister.ForeColor = System.Drawing.Color.White
        Me.lblLittleSister.Location = New System.Drawing.Point(427, 506)
        Me.lblLittleSister.Name = "lblLittleSister"
        Me.lblLittleSister.Size = New System.Drawing.Size(65, 20)
        Me.lblLittleSister.TabIndex = 8
        Me.lblLittleSister.Tag = "いもうと"
        '
        'lblLittleBrother
        '
        Me.lblLittleBrother.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLittleBrother.ForeColor = System.Drawing.Color.White
        Me.lblLittleBrother.Location = New System.Drawing.Point(324, 506)
        Me.lblLittleBrother.Name = "lblLittleBrother"
        Me.lblLittleBrother.Size = New System.Drawing.Size(64, 20)
        Me.lblLittleBrother.TabIndex = 8
        Me.lblLittleBrother.Tag = "おとうと"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(208, 506)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "わたし/ぼく"
        '
        'lblOldSister
        '
        Me.lblOldSister.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOldSister.ForeColor = System.Drawing.Color.White
        Me.lblOldSister.Location = New System.Drawing.Point(102, 506)
        Me.lblOldSister.Name = "lblOldSister"
        Me.lblOldSister.Size = New System.Drawing.Size(86, 20)
        Me.lblOldSister.TabIndex = 8
        Me.lblOldSister.Tag = "おねえさん"
        '
        'lblOldBrother
        '
        Me.lblOldBrother.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOldBrother.ForeColor = System.Drawing.Color.White
        Me.lblOldBrother.Location = New System.Drawing.Point(4, 506)
        Me.lblOldBrother.Name = "lblOldBrother"
        Me.lblOldBrother.Size = New System.Drawing.Size(89, 20)
        Me.lblOldBrother.TabIndex = 8
        Me.lblOldBrother.Tag = "おにいさん"
        '
        'lblUnant
        '
        Me.lblUnant.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnant.ForeColor = System.Drawing.Color.White
        Me.lblUnant.Location = New System.Drawing.Point(665, 325)
        Me.lblUnant.Name = "lblUnant"
        Me.lblUnant.Size = New System.Drawing.Size(74, 20)
        Me.lblUnant.TabIndex = 8
        Me.lblUnant.Tag = "おばさん"
        '
        'lblUncle
        '
        Me.lblUncle.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUncle.ForeColor = System.Drawing.Color.White
        Me.lblUncle.Location = New System.Drawing.Point(518, 325)
        Me.lblUncle.Name = "lblUncle"
        Me.lblUncle.Size = New System.Drawing.Size(70, 20)
        Me.lblUncle.TabIndex = 8
        Me.lblUncle.Tag = "おじさん"
        '
        'lblMother
        '
        Me.lblMother.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMother.ForeColor = System.Drawing.Color.White
        Me.lblMother.Location = New System.Drawing.Point(268, 325)
        Me.lblMother.Name = "lblMother"
        Me.lblMother.Size = New System.Drawing.Size(90, 20)
        Me.lblMother.TabIndex = 8
        Me.lblMother.Tag = "おかあさん"
        '
        'lblFather
        '
        Me.lblFather.Font = New System.Drawing.Font("有澤太楷書P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFather.ForeColor = System.Drawing.Color.White
        Me.lblFather.Location = New System.Drawing.Point(131, 324)
        Me.lblFather.Name = "lblFather"
        Me.lblFather.Size = New System.Drawing.Size(82, 20)
        Me.lblFather.TabIndex = 8
        Me.lblFather.Tag = "おとうさん"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(1137, 571)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 60)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblBigShow
        '
        Me.lblBigShow.BackColor = System.Drawing.Color.Transparent
        Me.lblBigShow.Font = New System.Drawing.Font("有澤太楷書P", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBigShow.ForeColor = System.Drawing.Color.White
        Me.lblBigShow.Location = New System.Drawing.Point(31, 68)
        Me.lblBigShow.Name = "lblBigShow"
        Me.lblBigShow.Size = New System.Drawing.Size(183, 73)
        Me.lblBigShow.TabIndex = 8
        Me.lblBigShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmShowFamily
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.BlackBoard
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1354, 721)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlBody)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShowFamily"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowBody"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblGrandFather As Label
    Friend WithEvents lblSister As Label
    Friend WithEvents lblBrother As Label
    Friend WithEvents lblLittleSister As Label
    Friend WithEvents lblLittleBrother As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblOldSister As Label
    Friend WithEvents lblOldBrother As Label
    Friend WithEvents lblUnant As Label
    Friend WithEvents lblUncle As Label
    Friend WithEvents lblMother As Label
    Friend WithEvents lblFather As Label
    Friend WithEvents pnlSister As Panel
    Friend WithEvents pnlBrother As Panel
    Friend WithEvents pnlLittleSister As Panel
    Friend WithEvents pnlLittleBrother As Panel
    Friend WithEvents pnlOldSister As Panel
    Friend WithEvents pnlOldBrother As Panel
    Friend WithEvents pnlUnant As Panel
    Friend WithEvents pnlUncle As Panel
    Friend WithEvents pnlMother As Panel
    Friend WithEvents pnlFather As Panel
    Friend WithEvents pnlGrandFather As Panel
    Friend WithEvents pnlGrandMother As Panel
    Friend WithEvents lblGrandMother As Label
    Friend WithEvents lblBigShow As Label
End Class
