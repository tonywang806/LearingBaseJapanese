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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubDisplayArea = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplayArea, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSubDisplayArea, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(480, 283)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDisplayArea.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDisplayArea.Location = New System.Drawing.Point(3, 20)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(234, 263)
        Me.lblDisplayArea.TabIndex = 1
        Me.lblDisplayArea.Text = "あ"
        Me.lblDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ひらかな"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(243, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "カタカナ"
        '
        'lblSubDisplayArea
        '
        Me.lblSubDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubDisplayArea.Font = New System.Drawing.Font("MS UI Gothic", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSubDisplayArea.ForeColor = System.Drawing.Color.Orange
        Me.lblSubDisplayArea.Location = New System.Drawing.Point(243, 20)
        Me.lblSubDisplayArea.Name = "lblSubDisplayArea"
        Me.lblSubDisplayArea.Size = New System.Drawing.Size(234, 263)
        Me.lblSubDisplayArea.TabIndex = 2
        Me.lblSubDisplayArea.Text = "ア"
        Me.lblSubDisplayArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(378, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 34)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "次へ"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 283)
        Me.Panel2.TabIndex = 1
        '
        'btnReStart
        '
        Me.btnReStart.Enabled = False
        Me.btnReStart.Location = New System.Drawing.Point(12, 301)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(114, 34)
        Me.btnReStart.TabIndex = 2
        Me.btnReStart.Text = "もう一度"
        Me.btnReStart.UseVisualStyleBackColor = True
        '
        'frmShow50Symbols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 344)
        Me.Controls.Add(Me.btnReStart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShow50Symbols"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "五十音図の書き取り"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDisplayArea As Label
    Friend WithEvents lblSubDisplayArea As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReStart As Button
End Class
