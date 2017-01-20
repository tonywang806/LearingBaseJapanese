<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShow50SymbolsAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShow50SymbolsAll))
        Me.tbl50List = New System.Windows.Forms.TabControl()
        Me.tpSound = New System.Windows.Forms.TabPage()
        Me.asfPlaySound = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.tpWrite = New System.Windows.Forms.TabPage()
        Me.asfWriteOrder = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.lblReferenceUrlTitle = New System.Windows.Forms.Label()
        Me.lblReferenceUrl = New System.Windows.Forms.LinkLabel()
        Me.lblFlashProviderTitle = New System.Windows.Forms.Label()
        Me.pnlProviderLogo = New System.Windows.Forms.Panel()
        Me.tblPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlUrlLink = New System.Windows.Forms.Panel()
        Me.btnFormClose = New System.Windows.Forms.Button()
        Me.tbl50List.SuspendLayout()
        Me.tpSound.SuspendLayout()
        CType(Me.asfPlaySound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpWrite.SuspendLayout()
        CType(Me.asfWriteOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblPanel.SuspendLayout()
        Me.pnlUrlLink.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl50List
        '
        Me.tbl50List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbl50List.Controls.Add(Me.tpSound)
        Me.tbl50List.Controls.Add(Me.tpWrite)
        Me.tbl50List.Location = New System.Drawing.Point(3, 3)
        Me.tbl50List.Name = "tbl50List"
        Me.tbl50List.SelectedIndex = 0
        Me.tbl50List.Size = New System.Drawing.Size(832, 606)
        Me.tbl50List.TabIndex = 0
        '
        'tpSound
        '
        Me.tpSound.Controls.Add(Me.asfPlaySound)
        Me.tpSound.Location = New System.Drawing.Point(4, 22)
        Me.tpSound.Name = "tpSound"
        Me.tpSound.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSound.Size = New System.Drawing.Size(824, 580)
        Me.tpSound.TabIndex = 0
        Me.tpSound.Text = "発音"
        Me.tpSound.UseVisualStyleBackColor = True
        '
        'asfPlaySound
        '
        Me.asfPlaySound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.asfPlaySound.Enabled = True
        Me.asfPlaySound.Location = New System.Drawing.Point(3, 3)
        Me.asfPlaySound.Name = "asfPlaySound"
        Me.asfPlaySound.OcxState = CType(resources.GetObject("asfPlaySound.OcxState"), System.Windows.Forms.AxHost.State)
        Me.asfPlaySound.Size = New System.Drawing.Size(818, 574)
        Me.asfPlaySound.TabIndex = 0
        '
        'tpWrite
        '
        Me.tpWrite.Controls.Add(Me.asfWriteOrder)
        Me.tpWrite.Location = New System.Drawing.Point(4, 22)
        Me.tpWrite.Name = "tpWrite"
        Me.tpWrite.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWrite.Size = New System.Drawing.Size(824, 621)
        Me.tpWrite.TabIndex = 1
        Me.tpWrite.Text = "書き方"
        Me.tpWrite.UseVisualStyleBackColor = True
        '
        'asfWriteOrder
        '
        Me.asfWriteOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.asfWriteOrder.Enabled = True
        Me.asfWriteOrder.Location = New System.Drawing.Point(3, 3)
        Me.asfWriteOrder.Name = "asfWriteOrder"
        Me.asfWriteOrder.OcxState = CType(resources.GetObject("asfWriteOrder.OcxState"), System.Windows.Forms.AxHost.State)
        Me.asfWriteOrder.Size = New System.Drawing.Size(818, 615)
        Me.asfWriteOrder.TabIndex = 0
        '
        'lblReferenceUrlTitle
        '
        Me.lblReferenceUrlTitle.AutoSize = True
        Me.lblReferenceUrlTitle.Location = New System.Drawing.Point(9, 21)
        Me.lblReferenceUrlTitle.Name = "lblReferenceUrlTitle"
        Me.lblReferenceUrlTitle.Size = New System.Drawing.Size(59, 12)
        Me.lblReferenceUrlTitle.TabIndex = 1
        Me.lblReferenceUrlTitle.Text = "参照資料："
        '
        'lblReferenceUrl
        '
        Me.lblReferenceUrl.AutoSize = True
        Me.lblReferenceUrl.Location = New System.Drawing.Point(74, 21)
        Me.lblReferenceUrl.Name = "lblReferenceUrl"
        Me.lblReferenceUrl.Size = New System.Drawing.Size(249, 12)
        Me.lblReferenceUrl.TabIndex = 2
        Me.lblReferenceUrl.TabStop = True
        Me.lblReferenceUrl.Text = "http://www.crossdrive.net/wp/tips/vb_each_swf"
        '
        'lblFlashProviderTitle
        '
        Me.lblFlashProviderTitle.AutoSize = True
        Me.lblFlashProviderTitle.Location = New System.Drawing.Point(352, 21)
        Me.lblFlashProviderTitle.Name = "lblFlashProviderTitle"
        Me.lblFlashProviderTitle.Size = New System.Drawing.Size(72, 12)
        Me.lblFlashProviderTitle.TabIndex = 1
        Me.lblFlashProviderTitle.Text = "flash版权方："
        '
        'pnlProviderLogo
        '
        Me.pnlProviderLogo.BackgroundImage = Global.SimpleJapaneseMemory.My.Resources.Resources.logo_jp
        Me.pnlProviderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlProviderLogo.Location = New System.Drawing.Point(423, 15)
        Me.pnlProviderLogo.Name = "pnlProviderLogo"
        Me.pnlProviderLogo.Size = New System.Drawing.Size(101, 24)
        Me.pnlProviderLogo.TabIndex = 3
        Me.pnlProviderLogo.Tag = "http://jp.hjenglish.com/"
        '
        'tblPanel
        '
        Me.tblPanel.ColumnCount = 1
        Me.tblPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPanel.Controls.Add(Me.tbl50List, 0, 0)
        Me.tblPanel.Controls.Add(Me.pnlUrlLink, 0, 1)
        Me.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPanel.Location = New System.Drawing.Point(0, 0)
        Me.tblPanel.Name = "tblPanel"
        Me.tblPanel.RowCount = 2
        Me.tblPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblPanel.Size = New System.Drawing.Size(838, 672)
        Me.tblPanel.TabIndex = 4
        '
        'pnlUrlLink
        '
        Me.pnlUrlLink.Controls.Add(Me.btnFormClose)
        Me.pnlUrlLink.Controls.Add(Me.lblReferenceUrl)
        Me.pnlUrlLink.Controls.Add(Me.pnlProviderLogo)
        Me.pnlUrlLink.Controls.Add(Me.lblReferenceUrlTitle)
        Me.pnlUrlLink.Controls.Add(Me.lblFlashProviderTitle)
        Me.pnlUrlLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUrlLink.Location = New System.Drawing.Point(3, 615)
        Me.pnlUrlLink.Name = "pnlUrlLink"
        Me.pnlUrlLink.Size = New System.Drawing.Size(832, 54)
        Me.pnlUrlLink.TabIndex = 1
        '
        'btnFormClose
        '
        Me.btnFormClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFormClose.BackColor = System.Drawing.Color.DarkRed
        Me.btnFormClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFormClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFormClose.Location = New System.Drawing.Point(727, 6)
        Me.btnFormClose.Name = "btnFormClose"
        Me.btnFormClose.Size = New System.Drawing.Size(96, 42)
        Me.btnFormClose.TabIndex = 4
        Me.btnFormClose.Text = "Close"
        Me.btnFormClose.UseVisualStyleBackColor = False
        '
        'frmShow50SymbolsAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 672)
        Me.Controls.Add(Me.tblPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(854, 710)
        Me.Name = "frmShow50SymbolsAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "五十音図一覧"
        Me.tbl50List.ResumeLayout(False)
        Me.tpSound.ResumeLayout(False)
        CType(Me.asfPlaySound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpWrite.ResumeLayout(False)
        CType(Me.asfWriteOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblPanel.ResumeLayout(False)
        Me.pnlUrlLink.ResumeLayout(False)
        Me.pnlUrlLink.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbl50List As TabControl
    Friend WithEvents tpSound As TabPage
    Friend WithEvents tpWrite As TabPage
    Friend WithEvents asfPlaySound As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents lblReferenceUrlTitle As Label
    Friend WithEvents lblReferenceUrl As LinkLabel
    Friend WithEvents lblFlashProviderTitle As Label
    Friend WithEvents asfWriteOrder As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents pnlProviderLogo As Panel
    Friend WithEvents tblPanel As TableLayoutPanel
    Friend WithEvents pnlUrlLink As Panel
    Friend WithEvents btnFormClose As Button
End Class
