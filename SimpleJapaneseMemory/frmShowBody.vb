Public Class frmShowBody
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs) Handles Panel9.MouseEnter, Panel8.MouseEnter, Panel7.MouseEnter, Panel6.MouseEnter, Panel5.MouseEnter, Panel4.MouseEnter, Panel3.MouseEnter, Panel2.MouseEnter, Panel15.MouseEnter, Panel14.MouseEnter, Panel13.MouseEnter, Panel12.MouseEnter, Panel11.MouseEnter, Panel10.MouseEnter, Panel1.MouseEnter
        CType(sender, Panel).BackColor = Color.Transparent
    End Sub

    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs) Handles Panel9.MouseLeave, Panel8.MouseLeave, Panel7.MouseLeave, Panel6.MouseLeave, Panel5.MouseLeave, Panel4.MouseLeave, Panel3.MouseLeave, Panel2.MouseLeave, Panel15.MouseLeave, Panel14.MouseLeave, Panel13.MouseLeave, Panel12.MouseLeave, Panel11.MouseLeave, Panel10.MouseLeave, Panel1.MouseLeave
        CType(sender, Panel).BackColor = Color.White
    End Sub
End Class