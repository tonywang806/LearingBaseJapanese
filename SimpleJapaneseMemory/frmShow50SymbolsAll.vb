Public Class frmShow50SymbolsAll
    Private Sub frmShow50SymbolsAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '参照資料：http://www.crossdrive.net/wp/tips/vb_each_swf
        'swfファイルの場所をフルパスに変換する。
        Dim pathStr_Sound As String = System.IO.Path.GetFullPath("./Resources/50Symbols_S.dll")
        Dim pathStr_Write As String = System.IO.Path.GetFullPath("./Resources/50Symbols_W.dll")

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
End Class