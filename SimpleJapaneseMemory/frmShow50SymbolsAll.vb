Public Class frmShow50SymbolsAll
    Private Sub frmShow50SymbolsAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'swfファイルの場所をフルパスに変換する。
        Dim pathStr_Sound As String = System.IO.Path.GetFullPath("./Resources/wushiyin_fayin.swf")
        Dim pathStr_Write As String = System.IO.Path.GetFullPath("./Resources/wushiyin_bishun.swf")

        'windowsフォーム上のshockwaveflashにswfファイルの設定をする。
        Me.asfPlaySound.LoadMovie(0, pathStr_Sound)
        Me.asfWriteOrder.LoadMovie(0, pathStr_Write)
    End Sub

    Private Sub btnFormClose_Click(sender As Object, e As EventArgs) Handles btnFormClose.Click
        Me.Close()
    End Sub

    Private Sub pnlProviderLogo_Click(sender As Object, e As EventArgs) Handles pnlProviderLogo.Click
        System.Diagnostics.Process.Start(pnlProviderLogo.Tag)
    End Sub
    Private Sub lblReferenceUrl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReferenceUrl.LinkClicked
        lblReferenceUrl.LinkVisited = True
        'ブラウザで開く
        System.Diagnostics.Process.Start(lblReferenceUrl.Text)
    End Sub
End Class