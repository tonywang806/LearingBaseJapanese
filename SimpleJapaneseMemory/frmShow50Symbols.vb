Public Class frmShow50Symbols

    Private ListIndex As New List(Of Integer)
    Private iCurrent As Integer

    Private s1 As String = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん"
    Private s2 As String = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲン"

    Public Sub InitalizedFirst(Optional ByVal isRandom As Boolean = True)

        lblDisplayArea.Text = String.Empty
        lblSubDisplayArea.Text = String.Empty

        For i As Integer = 0 To s1.Length - 1
            ListIndex.Add(i)
        Next

        If isRandom Then
            ListIndex = RandomSort(ListIndex)
        End If

        If ListIndex.Count > 0 Then
            btnNext.Enabled = True
            btnReStart.Enabled = False

            iCurrent = 0
            lblDisplayArea.Text = s1.Substring(ListIndex(iCurrent), 1)
            lblSubDisplayArea.Text = s2.Substring(ListIndex(iCurrent), 1)
        End If

    End Sub


    Public Function RandomSort(ByVal ListStr As IList(Of Integer)) As IList(Of Integer)
        Dim rand As Random = New Random()
        Dim iTarget As Integer = 0
        Dim iStrIndex As Integer = -1
        For i As Integer = 0 To ListStr.Count - 1
            iTarget = rand.Next(0, ListStr.Count)
            iStrIndex = ListStr(i)
            ListStr(i) = ListStr(iTarget)
            ListStr(iTarget) = iStrIndex
        Next
        Return ListStr
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        iCurrent += 1
        If iCurrent < ListIndex.Count Then
            lblDisplayArea.Text = s1.Substring(ListIndex(iCurrent), 1)
            lblSubDisplayArea.Text = s2.Substring(ListIndex(iCurrent), 1)
        End If

        If iCurrent = ListIndex.Count - 1 Then
            btnNext.Enabled = False
            btnReStart.Enabled = True
        End If
    End Sub

    Private Sub btnReStart_Click(sender As Object, e As EventArgs) Handles btnReStart.Click
        btnNext.Enabled = True
        btnReStart.Enabled = False

        iCurrent = 0
        lblDisplayArea.Text = s1.Substring(ListIndex(iCurrent), 1)
        lblSubDisplayArea.Text = s2.Substring(ListIndex(iCurrent), 1)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class