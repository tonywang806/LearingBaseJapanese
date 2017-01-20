Public Class frmShowOthers

    Private strType As String

    Private intDisplayMax As Integer

    Private ListIndex As New List(Of Integer)
    Private iCurrent As Integer

    Private displaysStringArray As String()
    Private displaysStringArray_r As String()

    Private s0 As String() = {"1日", "2日", "3日", "4日", "5日", "6日", "7日", "8日", "9日",
                              "10日", "11日", "12日", "13日", "14日", "15日", "16日", "17日",
                              "18日", "19日", "20日", "21日", "22日", "23日", "24日", "25日",
                              "26日", "27日", "28日", "29日", "30日", "31日"}
    Private s0_r As String() = {"ついたち", "ふつか", "みっか", "よっか",
                                "いつか", "むいか", "なのか", "ようか", "ここのか",
                              "とおか", "じゅういちにち", "じゅうににち", "じゅうさんにち",
                              "じゅうよんにち", "じゅうごにち", "じゅうろくにち", "じゅうななにち",
                              "じゅうはちにち", "じゅうくにち", "はつか", "にじゅういちにち",
                              "にじゅうににち", "にじゅうさんにち", "にじゅうよんにち", "にじゅうごにち",
                              "にじゅうろくにち", "にじゅうななにち", "にじゅうはちにち",
                              "にじゅうくにち", "さんじゅうにち、みそか", "さんじゅういちにち"}

    Private s1 As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                              "10", "11", "12", "13", "14", "15", "16", "17",
                              "18", "19", "20", "100", "300", "600", "1000"}

    Private s1_r As String() = {"ぜろ", "いち", "に", "さん", "し", "ご", "ろく", "しち、なな", "はち", "きゅう",
                              "じゅう", "じゅういち", "じゅうに", "じゅうさん", "じゅうよん", "じゅうご", "じゅうろく", "じゅうなな",
                              "じゅうはち", "じゅうきゅう", "にじゅう", "ひゃく", "さんびゃく", "ろっぴゃく", "せん"}

    Private s2 As String() = {"月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日", "日曜日"}
    Private s2_r As String() = {"げつようび", "かようび", "すいようび", "もくようび", "きんようび", "どようび", "にちようび"}

    Private s3 As String() = {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"}
    Private s3_r As String() = {"いちがつ", "にがつ", "さんがつ", "しがつ", "ごがつ", "ろくがつ",
                                "しちがつ", "はちがつ", "くがつ", "じゅうがつ", "じゅういちがつ", "じゅうにがつ"}

    Private s4 As String() = {"日本", "東京都", "江東区", "大島", "亀戸", "南砂町", "北砂", "上野"}
    Private s4_r As String() = {"にほん", "とうきょうと", "こうとうく", "おおじま", "かめいど", "みなみすなまち", "きたすな", "うえの"}

    Private s5 As String() = {"方位", "東", "西", "南", "北", "南北", "東西", "東西南北"}
    Private s5_r As String() = {"ほうい", "ひがし", "にし", "みなみ", "きた", "なんぼく", "とうざい", "とうざいなんぼく"}

    Private s6 As String() = {"方向", "上", "下", "左", "右", "中央", "前", "後", "前後", "左右", "外", "奥"}
    Private s6_r As String() = {"ほうこう", "うえ", "した", "ひだり", "みぎ", "ちゅうおう",
                                "まえ", "うしろ", "ぜんご", "さゆう", "そと", "おく"}

    Private s7 As String() = {"色", "赤色", "青色", "黄色", "緑色", "白色", "茶色",
                              "青い", "赤い", "白い", "黒い"}
    Private s7_r As String() = {"いろ", "あかいろ", "あおいろ",
                               "きいろ", "りょくしょく", "はくしょく", "ちゃいろ", "あおい", "あかい", "しろい", "くろい"}
    Private s7_c As Color() = {Color.Black, Color.Red, Color.Blue,
                               Color.Yellow, Color.Green, Color.White, Color.Brown, Color.Blue, Color.Red, Color.White, Color.Black}

    Public Sub InitalizedFirst(ByVal type As String, Optional ByVal isRandom As Boolean = True)

        lblDisplayArea.Text = String.Empty
        lblReadMethod.Text = String.Empty

        strType = type

        Select Case strType
            Case "Date"
                displaysStringArray = s0
                displaysStringArray_r = s0_r
            Case "Numberic"
                displaysStringArray = s1
                displaysStringArray_r = s1_r
            Case "Weeks"
                displaysStringArray = s2
                displaysStringArray_r = s2_r
            Case "Month"
                displaysStringArray = s3
                displaysStringArray_r = s3_r
            Case "Place"
                displaysStringArray = s4
                displaysStringArray_r = s4_r
            Case "Orientation"
                displaysStringArray = s5
                displaysStringArray_r = s5_r
            Case "Direction"
                displaysStringArray = s6
                displaysStringArray_r = s6_r
            Case "Color"
                displaysStringArray = s7
                displaysStringArray_r = s7_r
        End Select

        For i As Integer = 0 To displaysStringArray.Length - 1
            ListIndex.Add(i)
        Next

        If isRandom Then
            ListIndex = RandomSort(ListIndex)
            intDisplayMax = 9
        Else
            intDisplayMax = ListIndex.Count - 1
        End If

        If ListIndex.Count > 0 Then
            btnNext.Enabled = True
            btnReStart.Enabled = False

            iCurrent = 0
            SetDisplayText()
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
            SetDisplayText()
        End If

        If iCurrent = ListIndex.Count - 1 OrElse iCurrent = intDisplayMax Then
            btnNext.Enabled = False
            btnReStart.Enabled = True
        End If
    End Sub

    Private Sub btnReStart_Click(sender As Object, e As EventArgs) Handles btnReStart.Click
        btnNext.Enabled = True
        btnReStart.Enabled = False

        iCurrent = 0
        SetDisplayText()
    End Sub
    Private Sub SetDisplayText()
        lblDisplayArea.Text = displaysStringArray(ListIndex(iCurrent))
        lblReadMethod.Text = displaysStringArray_r(ListIndex(iCurrent))
    End Sub

    Private Sub lblDisplayArea_Paint(sender As Object, e As PaintEventArgs) Handles lblDisplayArea.Paint
        If strType = "Color" Then

            'Dim g As Graphics = e.Graphics
            ''黒い場合、文字色を変更することが中止
            'If s7_c(ListIndex(iCurrent)) = Color.Black Then
            '    Return
            'End If
            ''上記以外、文字色を変更する
            'Dim brushColor As New SolidBrush(s7_c(ListIndex(iCurrent)))
            'Dim strFormat As New StringFormat(StringFormatFlags.NoClip)
            'strFormat.Alignment = StringAlignment.Center
            'strFormat.LineAlignment = StringAlignment.Center

            'g.DrawString(lblDisplayArea.Text, lblDisplayArea.Font, brushColor, lblDisplayArea.Bounds, strFormat)

            lblDisplayArea.ForeColor = s7_c(ListIndex(iCurrent))
            'lblDisplayArea.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnShowReadMethod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShowReadMethod.MouseDown
        lblReadMethod.Visible = True
    End Sub

    Private Sub btnShowReadMethod_MouseUp(sender As Object, e As MouseEventArgs) Handles btnShowReadMethod.MouseUp
        lblReadMethod.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class