Imports System.Reflection
Imports System.Deployment.Application
Public Class frmMain
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim frmDisplay As New frmShow50Symbols
        frmDisplay.InitalizedFirst(rdoRandom.Checked)
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As EventArgs) Handles btnSecond.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Date", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnThird_Click(sender As Object, e As EventArgs) Handles btnThird.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Numberic", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnForth_Click(sender As Object, e As EventArgs) Handles btnForth.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Weeks", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnFifth_Click(sender As Object, e As EventArgs) Handles btnFifth.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Month", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnSixth_Click(sender As Object, e As EventArgs) Handles btnSixth.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Place", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnSeventh_Click(sender As Object, e As EventArgs) Handles btnSeventh.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Orientation", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnEigth_Click(sender As Object, e As EventArgs) Handles btnEigth.Click
        Dim frmDisplay As New frmShowOthers
        frmDisplay.InitalizedFirst("Direction", rdoRandom.Checked)
        frmDisplay.Text = CType(sender, Button).Text
        frmDisplay.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim assem As Assembly = GetType(frmMain).Assembly
        Dim strPrefix As String = "Ver"
        Dim strVersion As String = String.Empty
        strVersion = assem.GetName.Version.ToString
        lblVersion.Text = String.Format("{0}.{1}", strPrefix, strVersion)
    End Sub
End Class
