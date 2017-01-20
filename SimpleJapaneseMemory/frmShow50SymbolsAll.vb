Public Class frmShow50SymbolsAll
    Private Sub frmShow50SymbolsAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'swfファイルの場所をフルパスに変換する。
        Dim pathStr_Sound As String = System.IO.Path.GetFullPath("./Resources/wushiyin_fayin.swf")
        Dim pathStr_Write As String = System.IO.Path.GetFullPath("./Resources/wushiyin_bishun.swf")

        'windowsフォーム上のshockwaveflashにswfファイルの設定をする。
        Me.asfPlaySound.LoadMovie(0, pathStr_Sound)
        Me.asfWriteOrder.LoadMovie(0, pathStr_Write)
    End Sub
End Class