Public Class frmShowBody
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.Transparent
    End Sub

    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.White
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label15.MouseLeave, Label14.MouseLeave, Label13.MouseLeave, Label12.MouseLeave, Label11.MouseLeave, Label10.MouseLeave, Label1.MouseLeave
        With CType(sender, Label)
            .Text = String.Empty
        End With
    End Sub

    Private Sub Label_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        With CType(sender, Label)
            .Text = .Tag
        End With
    End Sub
End Class