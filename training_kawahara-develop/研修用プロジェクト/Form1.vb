Imports 研修用プロジェクト
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles ButtonDraw.Click
        'ピクチャボックスを設定
        Dim objectGroup As Graphics = PictureBox1.CreateGraphics
        '左下へ原点変更
        'ワールド変換行列で座標系の原点を左下に平行移動
        objectGroup.TranslateTransform(0, PictureBox1.Size.Height)
        'Y軸方向を反転させる。上方向をプラスに
        objectGroup.ScaleTransform(1, -1)
        '線プロパティの作成 
        '線の色
        Dim colorR As Integer = CInt(NumericUpDownR.Value)
        Dim colorG As Integer = CInt(NumericUpDownG.Value)
        Dim colorB As Integer = CInt(NumericUpDownB.Value)
        '線幅の数値をComboBox2から取得
        Dim value As Integer = CInt(ComboBoxLineWidth.SelectedItem)
        'ペンの色・太さ
        Dim pen As Pen = New Pen(Color.FromArgb(colorR, colorG, colorB), value)
        '線の形状
        Select Case ComboBoxLineType.SelectedValue.ToString()
            Case "Solid"
                pen.DashStyle = Drawing2D.DashStyle.Solid
            Case Else
                pen.DashStyle = Drawing2D.DashStyle.Dash
        End Select
        '端点の半径
        Const AnchorRadius As Double = 15
        '端点の直径
        Const AnchorDiameter As Double = 30
        '直線の作成
        '該当テキストボックス空白の場合
        If String.IsNullOrEmpty(TextBoxLineX1.Text) _
        OrElse String.IsNullOrEmpty(TextBoxLineY1.Text) _
        OrElse String.IsNullOrEmpty(TextBoxLineX2.Text) _
        OrElse String.IsNullOrEmpty(TextBoxLineY2.Text) _
        Then
        Else
            '直線を引く
            Dim lineStartX As Double = CDec(TextBoxLineX1.Text)
            Dim lineStartY As Double = CDec(TextBoxLineY1.Text)
            Dim lineLastX As Double = CDec(TextBoxLineX2.Text)
            Dim lineLastY As Double = CDec(TextBoxLineY2.Text)
            '始点の指定
            Dim point1 As New Point(CInt(lineStartX), CInt(lineStartY))
            '終点の指定
            Dim point2 As New Point(CInt(lineLastX), CInt(lineLastY))
            '端点（円形）の半径
            Const pointCircleRadius As Double = 12.5
            '端点（矩形）の半径
            Const pointSquareRadius As Double = 13.5
            Dim pointCircleStart As New Point(CInt(lineStartX + pointCircleRadius),
                                              CInt(lineStartY + pointCircleRadius))
            Dim pointCircleLast As New Point(CInt(lineLastX - pointCircleRadius),
                                             CInt(lineLastY - pointCircleRadius))
            Dim pointSquareStart As New Point(CInt(lineStartX + pointSquareRadius),
                                              CInt(lineStartY + pointSquareRadius))
            Dim pointSquareLast As New Point(CInt(lineLastX - pointSquareRadius),
                                             CInt(lineLastY - pointSquareRadius))
            '線の端点形状の選択
            Select Case True
                Case RadioButtonCircleBK.Checked
                    Dim newBrush As New SolidBrush(Color.FromArgb(colorR, colorG, colorB))
                    objectGroup.FillEllipse(newBrush,
                                            CInt(lineStartX - AnchorRadius),
                                            CInt(lineStartY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(lineStartX - AnchorRadius),
                                            CInt(lineStartY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.FillEllipse(newBrush,
                                            CInt(lineLastX - AnchorRadius),
                                            CInt(lineLastY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(lineLastX - AnchorRadius),
                                            CInt(lineLastY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    'スクリーンに線を描画
                    objectGroup.DrawLine(pen, point1, point2)
                Case RadioButtonCircleClear.Checked
                    objectGroup.DrawEllipse(pen,
                                            CInt(lineStartX - AnchorRadius),
                                            CInt(lineStartY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(lineLastX - AnchorRadius),
                                            CInt(lineLastY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    'スクリーンに線を描画
                    objectGroup.DrawLine(pen, pointCircleStart, pointCircleLast)
                Case RadioButtonSquareBK.Checked
                    Dim newBrush As New SolidBrush(Color.FromArgb(colorR, colorG, colorB))
                    objectGroup.FillRectangle(newBrush,
                                              CInt(lineStartX - AnchorRadius),
                                              CInt(lineStartY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(lineStartX - AnchorRadius),
                                              CInt(lineStartY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.FillRectangle(newBrush,
                                              CInt(lineLastX - AnchorRadius),
                                              CInt(lineLastY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(lineLastX - AnchorRadius),
                                              CInt(lineLastY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    'スクリーンに線を描画
                    objectGroup.DrawLine(pen, point1, point2)
                Case RadioButtonSquareClear.Checked
                    objectGroup.DrawRectangle(pen,
                                              CInt(lineStartX - AnchorRadius),
                                              CInt(lineStartY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(lineLastX - AnchorRadius),
                                              CInt(lineLastY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    'スクリーンに線を描画
                    objectGroup.DrawLine(pen, pointSquareStart, pointSquareLast)
                Case RadioButtonNone.Checked
                    'スクリーンに線を描画
                    objectGroup.DrawLine(pen, point1, point2)
            End Select
        End If
        '円の作成
        '該当テキストボックス空白の場合
        If String.IsNullOrEmpty(TextBoxCircleX.Text) _
        OrElse String.IsNullOrEmpty(TextBoxCircleY.Text) _
        OrElse String.IsNullOrEmpty(TextBoxCircleRadius.Text) _
        Then
        Else
            '円を描く
            Dim circleX As Integer = CInt(TextBoxCircleX.Text)
            Dim circleY As Integer = CInt(TextBoxCircleY.Text)
            Dim circleRadius As Integer = CInt(TextBoxCircleRadius.Text)
            '半径*2をテキストボックスに反映
            TextBoxCircleDiameter.ReadOnly = True
            TextBoxCircleDiameter.Text = CType(circleRadius * 2, String)
            ' 円を作成
            Dim rect As New Rectangle(circleX - circleRadius,
                                      circleY - circleRadius,
                                      circleRadius * 2,
                                      circleRadius * 2)
            ' スクリーンに円を描画
            objectGroup.DrawEllipse(pen, rect)
        End If
        '矩形の作成
        '該当テキストボックス空白の場合
        If String.IsNullOrEmpty(TextBoxRectangleX1.Text) _
        OrElse String.IsNullOrEmpty(TextBoxRectangleY1.Text) _
        OrElse String.IsNullOrEmpty(TextBoxRectangleX2.Text) _
        OrElse String.IsNullOrEmpty(TextBoxRectangleY2.Text) _
        Then
        Else
            '矩形を描く
            Dim rectangleX1 As Integer = CInt(TextBoxRectangleX1.Text)
            Dim rectangleY1 As Integer = CInt(TextBoxRectangleY1.Text)
            Dim rectangleX2 As Integer = CInt(TextBoxRectangleX2.Text)
            Dim rectangleY2 As Integer = CInt(TextBoxRectangleY2.Text)
            '座標最大値最小値を比較
            Dim rectangleMinX As Integer = Math.Min(rectangleX1, rectangleX2)
            Dim rectangleMinY As Integer = Math.Min(rectangleX1, rectangleX2)
            Dim rectangleMaxX As Integer = Math.Max(rectangleX1, rectangleX2)
            Dim rectangleMaxY As Integer = Math.Max(rectangleX1, rectangleX2)
            '幅
            Dim rectangleWidth As Integer = rectangleMaxX - rectangleMinX
            '高さ
            Dim rectangleHeight As Integer = rectangleMaxY - rectangleMinY
            '矩形の端点形状の選択
            Select Case True
                Case RadioButtonCircleBK2.Checked
                    Dim newBrush As New SolidBrush(Color.FromArgb(colorR, colorG, colorB))
                    objectGroup.FillEllipse(newBrush,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.FillEllipse(newBrush,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.FillEllipse(newBrush,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.FillEllipse(newBrush,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    'スクリーンに矩形を描画
                    objectGroup.DrawRectangle(pen,
                                              rectangleMinX,
                                              rectangleMinY,
                                              rectangleWidth,
                                              rectangleHeight)
                Case RadioButtonCircleClear2.Checked
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMinX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMinY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawEllipse(pen,
                                            CInt(rectangleMaxX - AnchorRadius),
                                            CInt(rectangleMaxY - AnchorRadius),
                                            AnchorDiameter, AnchorDiameter)
                    'スクリーンに矩形を描画
                    objectGroup.DrawRectangle(pen,
                                              rectangleMinX,
                                              rectangleMinY,
                                              rectangleWidth,
                                              rectangleHeight)
                Case RadioButtonSquareBK2.Checked
                    Dim newBrush As New SolidBrush(Color.FromArgb(colorR, colorG, colorB))
                    objectGroup.FillRectangle(newBrush,
                                              CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen, CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.FillRectangle(newBrush,
                                              CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.FillRectangle(newBrush,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.FillRectangle(newBrush,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    'スクリーンに矩形を描画
                    objectGroup.DrawRectangle(pen,
                                              rectangleMinX,
                                              rectangleMinY,
                                              rectangleWidth,
                                              rectangleHeight)
                Case RadioButtonSquareClear2.Checked
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMinX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMinY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    objectGroup.DrawRectangle(pen,
                                              CInt(rectangleMaxX - AnchorRadius),
                                              CInt(rectangleMaxY - AnchorRadius),
                                              AnchorDiameter, AnchorDiameter)
                    'スクリーンに矩形を描画
                    objectGroup.DrawRectangle(pen,
                                              rectangleMinX,
                                              rectangleMinY,
                                              rectangleWidth,
                                              rectangleHeight)
                Case RadioButtonNone2.Checked
                    'スクリーンに矩形を描画
                    objectGroup.DrawRectangle(pen,
                                              rectangleMinX,
                                              rectangleMinY,
                                              rectangleWidth,
                                              rectangleHeight)
            End Select
        End If
        objectGroup.Dispose()
    End Sub
    Private Sub From1ComboBox_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        '1つめのコンボボックス
        'コンボボックス初期化
        ComboBoxLineWidth.Items.Clear()
        ComboBoxLineWidth.Text = String.Empty
        'テキストボックス部分は編集不可にする
        ComboBoxLineWidth.DropDownStyle = ComboBoxStyle.DropDownList
        '要素追加
        ComboBoxLineWidth.Items.Add("1")
        ComboBoxLineWidth.Items.Add("2")
        ComboBoxLineWidth.Items.Add("3")
        ComboBoxLineWidth.Items.Add("4")
        ComboBoxLineWidth.Items.Add("5")
        'データ選択
        ComboBoxLineWidth.SelectedIndex = 0
        '2つめのコンボボックス
        'コンボボックス初期化
        ComboBoxLineType.Items.Clear()
        ComboBoxLineType.Text = String.Empty
        ' テキストボックス部分は編集不可にする
        ComboBoxLineType.DropDownStyle = ComboBoxStyle.DropDownList
        'データテーブル作成
        Dim dt As New DataTable
        dt.Columns.Add("HabaId")
        dt.Columns.Add("HabaNm")
        Dim dtrow As DataRow
        '実線
        dtrow = dt.NewRow
        dtrow("HabaId") = "Solid"
        dtrow("HabaNm") = "NORMAL"
        dt.Rows.Add(dtrow)
        '破線
        dtrow = dt.NewRow
        dtrow("HabaId") = "Dash"
        dtrow("HabaNm") = "DASH"
        dt.Rows.Add(dtrow)
        'コンボボックス設定
        ComboBoxLineType.DataSource = dt
        ComboBoxLineType.DisplayMember = "HabaNm"
        ComboBoxLineType.ValueMember = "HabaId"
        '初期データ選択
        ComboBoxLineType.SelectedValue = "Solid"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles ButtonClear.Click
        'ピクチャボックスの図形を消去
        PictureBox1.Image = Nothing
        'テキストボックス内をクリア
        TextBoxCircleX.Clear()
        TextBoxCircleRadius.Clear()
        TextBoxCircleY.Clear()
        TextBoxCircleDiameter.Clear()
        TextBoxLineX1.Clear()
        TextBoxLineY1.Clear()
        TextBoxLineX2.Clear()
        TextBoxLineY2.Clear()
        TextBoxRectangleX1.Clear()
        TextBoxRectangleY1.Clear()
        TextBoxRectangleX2.Clear()
        TextBoxRectangleY2.Clear()
        'RGBを初期値0に変更
        NumericUpDownR.Value = 0
        NumericUpDownG.Value = 0
        NumericUpDownB.Value = 0
        'コンボボックスを初期値に
        ComboBoxLineType.SelectedValue = "Solid"
        ComboBoxLineWidth.SelectedIndex = 0
        'RadioButtonをクリア
        RadioButtonCircleBK.Checked = False
        RadioButtonCircleClear.Checked = False
        RadioButtonSquareBK.Checked = False
        RadioButtonSquareClear.Checked = False
        RadioButtonCircleBK2.Checked = False
        RadioButtonSquareBK2.Checked = False
        RadioButtonCircleClear2.Checked = False
        RadioButtonSquareClear2.Checked = False
        RadioButtonNone.Checked = True
        RadioButtonNone2.Checked = True
    End Sub
    'テキストボックス内が数値以外の場合クリア
    Private Sub TextBoxCircleX_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxCircleX.Leave
        If Not IsNumeric(TextBoxCircleX.Text) Then TextBoxCircleX.Clear()
    End Sub

    Private Sub TextBoxCircleY_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxCircleY.Leave
        If Not IsNumeric(TextBoxCircleY.Text) Then TextBoxCircleY.Clear()
    End Sub

    Private Sub TextBoxCircleRadius_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxCircleRadius.Leave
        If Not IsNumeric(TextBoxCircleRadius.Text) Then TextBoxCircleDiameter.Clear()
    End Sub

    Private Sub TextBoxLineX1_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxLineX1.Leave
        If Not IsNumeric(TextBoxLineX1.Text) Then TextBoxLineX1.Clear()
    End Sub

    Private Sub TextBoxLineY1_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxLineY1.Leave
        If Not IsNumeric(TextBoxLineY1.Text) Then TextBoxLineY1.Clear()
    End Sub

    Private Sub TextBoxLineX2_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxLineX2.Leave
        If Not IsNumeric(TextBoxLineX2.Text) Then TextBoxLineX2.Clear()
    End Sub

    Private Sub TextBoxLineY2_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxLineY2.Leave
        If Not IsNumeric(TextBoxLineY2.Text) Then TextBoxLineY2.Clear()
    End Sub

    Private Sub TextBoxRectangleX1_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxRectangleX1.Leave
        If Not IsNumeric(TextBoxRectangleX1.Text) Then TextBoxRectangleX1.Clear()
    End Sub

    Private Sub TextBoxRectangleY1_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxRectangleY1.Leave
        If Not IsNumeric(TextBoxRectangleY1.Text) Then TextBoxRectangleY1.Clear()
    End Sub

    Private Sub TextBoxRectangleX2_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxRectangleX2.Leave
        If Not IsNumeric(TextBoxRectangleX2.Text) Then TextBoxRectangleX2.Clear()
    End Sub

    Private Sub TextBoxRectangleY2_Leave(sender As Object, e As EventArgs) _
        Handles TextBoxRectangleY2.Leave
        If Not IsNumeric(TextBoxRectangleY2.Text) Then TextBoxRectangleY2.Clear()
    End Sub
End Class
