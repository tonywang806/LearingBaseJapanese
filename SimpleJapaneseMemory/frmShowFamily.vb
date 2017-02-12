Public Class frmShowFamily
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.Transparent
    End Sub

    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.White
    End Sub


    Private Sub pnlGrandFather_MouseEnter(sender As Object, e As EventArgs) Handles pnlGrandFather.MouseEnter
        With lblGrandFather
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlGrandFather_MouseLeave(sender As Object, e As EventArgs) Handles pnlGrandFather.MouseLeave
        With lblGrandFather
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlGrandMother_MouseEnter(sender As Object, e As EventArgs) Handles pnlGrandMother.MouseEnter
        With lblGrandMother
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlGrandMother_MouseLeave(sender As Object, e As EventArgs) Handles pnlGrandMother.MouseLeave
        With lblGrandMother
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlFather_MouseEnter(sender As Object, e As EventArgs) Handles pnlFather.MouseEnter
        With lblFather
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlFather_MouseLeave(sender As Object, e As EventArgs) Handles pnlFather.MouseLeave
        With lblFather
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlMother_MouseEnter(sender As Object, e As EventArgs) Handles pnlMother.MouseEnter
        With lblMother
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlMother_MouseLeave(sender As Object, e As EventArgs) Handles pnlMother.MouseLeave
        With lblMother
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlUncle_MouseEnter(sender As Object, e As EventArgs) Handles pnlUncle.MouseEnter
        With lblUncle
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlUnant_MouseEnter(sender As Object, e As EventArgs) Handles pnlUnant.MouseEnter
        With lblUnant
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlOldBrother_MouseEnter(sender As Object, e As EventArgs) Handles pnlOldBrother.MouseEnter
        With lblOldBrother
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlOldSister_MouseEnter(sender As Object, e As EventArgs) Handles pnlOldSister.MouseEnter
        With lblOldSister
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlLittleBrother_MouseEnter(sender As Object, e As EventArgs) Handles pnlLittleBrother.MouseEnter
        With lblLittleBrother
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlLittleSister_MouseEnter(sender As Object, e As EventArgs) Handles pnlLittleSister.MouseEnter
        With lblLittleSister
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlBrother_MouseEnter(sender As Object, e As EventArgs) Handles pnlBrother.MouseEnter
        With lblBrother
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlSister_MouseEnter(sender As Object, e As EventArgs) Handles pnlSister.MouseEnter
        With lblSister
            .Text = .Tag
            lblBigShow.Text = .Tag
        End With
    End Sub

    Private Sub pnlUncle_MouseLeave(sender As Object, e As EventArgs) Handles pnlUncle.MouseLeave
        With lblUncle
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlUnant_MouseLeave(sender As Object, e As EventArgs) Handles pnlUnant.MouseLeave
        With lblUnant
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlOldBrother_MouseLeave(sender As Object, e As EventArgs) Handles pnlOldBrother.MouseLeave
        With lblOldBrother
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlOldSister_MouseLeave(sender As Object, e As EventArgs) Handles pnlOldSister.MouseLeave
        With lblOldSister
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlLittleBrother_MouseLeave(sender As Object, e As EventArgs) Handles pnlLittleBrother.MouseLeave
        With lblLittleBrother
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlLittleSister_MouseLeave(sender As Object, e As EventArgs) Handles pnlLittleSister.MouseLeave
        With lblLittleSister
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlBrother_MouseLeave(sender As Object, e As EventArgs) Handles pnlBrother.MouseLeave
        With lblBrother
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub

    Private Sub pnlSister_MouseLeave(sender As Object, e As EventArgs) Handles pnlSister.MouseLeave
        With lblSister
            .Text = String.Empty
            lblBigShow.Text = String.Empty
        End With
    End Sub
End Class