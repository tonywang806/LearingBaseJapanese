Imports System.Reflection
Imports System.Deployment.Application
Public Class frmMain
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim frmDisplay As New frmShow50Symbols
        frmDisplay.InitalizedFirst(rdoRandom.Checked)
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnSecond.Click, btnThird.Click, btnSixth.Click, btnSeventh.Click, btnNinth.Click, btnForth.Click, btnFifth.Click, btnEigth.Click
        With CType(sender, Button)
            Dim frmDisplay As New frmShowOthers
            frmDisplay.InitalizedFirst(.Tag, rdoRandom.Checked)
            frmDisplay.Text = .Text
            frmDisplay.ShowDialog()
        End With
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim assem As Assembly = GetType(frmMain).Assembly
        Dim strPrefix As String = "Ver"
        Dim strVersion As String = String.Empty
        strVersion = assem.GetName.Version.ToString
        lblVersion.Text = String.Format("{0}.{1}", strPrefix, strVersion)
    End Sub

    Private Sub lblGithubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGithubLink.LinkClicked
        lblGithubLink.LinkVisited = True
        'ブラウザで開く
        System.Diagnostics.Process.Start(lblGithubLink.Text)
    End Sub
    Private Sub pnlFavoriteIcon_Click(sender As Object, e As EventArgs) Handles pnlFavoriteIcon.Click
        Dim frmDisplay As New frmShow50SymbolsAll
        frmDisplay.ShowDialog()
    End Sub
End Class
