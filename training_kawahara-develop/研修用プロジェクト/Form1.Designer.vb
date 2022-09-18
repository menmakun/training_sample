<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Me.TextBoxCircleX = New System.Windows.Forms.TextBox()
        Me.TextBoxCircleRadius = New System.Windows.Forms.TextBox()
        Me.TextBoxCircleY = New System.Windows.Forms.TextBox()
        Me.TextBoxLineX1 = New System.Windows.Forms.TextBox()
        Me.TextBoxLineY1 = New System.Windows.Forms.TextBox()
        Me.TextBoxLineX2 = New System.Windows.Forms.TextBox()
        Me.TextBoxLineY2 = New System.Windows.Forms.TextBox()
        Me.TextBoxRectangleX1 = New System.Windows.Forms.TextBox()
        Me.TextBoxRectangleY1 = New System.Windows.Forms.TextBox()
        Me.TextBoxRectangleX2 = New System.Windows.Forms.TextBox()
        Me.TextBoxRectangleY2 = New System.Windows.Forms.TextBox()
        Me.RadioButtonCircleBK = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCircleClear = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSquareBK = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSquareClear = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButtonCircleBK2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSquareBK2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCircleClear2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSquareClear2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCircleDiameter = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBoxAnchor = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBoxAnchor2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNone2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxLineWidth = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLineType = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownB = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownG = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownR = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDraw = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxAnchor.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxAnchor2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.NumericUpDownB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(56, 39)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(44, 18)
        Label21.TabIndex = 21
        Label21.Text = "線幅"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(272, 39)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(44, 18)
        Label22.TabIndex = 45
        Label22.Text = "線種"
        '
        'TextBoxCircleX
        '
        Me.TextBoxCircleX.Location = New System.Drawing.Point(126, 24)
        Me.TextBoxCircleX.Name = "TextBoxCircleX"
        Me.TextBoxCircleX.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxCircleX.TabIndex = 0
        '
        'TextBoxCircleRadius
        '
        Me.TextBoxCircleRadius.Location = New System.Drawing.Point(342, 24)
        Me.TextBoxCircleRadius.Name = "TextBoxCircleRadius"
        Me.TextBoxCircleRadius.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxCircleRadius.TabIndex = 1
        '
        'TextBoxCircleY
        '
        Me.TextBoxCircleY.Location = New System.Drawing.Point(126, 70)
        Me.TextBoxCircleY.Name = "TextBoxCircleY"
        Me.TextBoxCircleY.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxCircleY.TabIndex = 2
        '
        'TextBoxLineX1
        '
        Me.TextBoxLineX1.Location = New System.Drawing.Point(1101, 204)
        Me.TextBoxLineX1.Name = "TextBoxLineX1"
        Me.TextBoxLineX1.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxLineX1.TabIndex = 4
        '
        'TextBoxLineY1
        '
        Me.TextBoxLineY1.Location = New System.Drawing.Point(1317, 204)
        Me.TextBoxLineY1.Name = "TextBoxLineY1"
        Me.TextBoxLineY1.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxLineY1.TabIndex = 5
        '
        'TextBoxLineX2
        '
        Me.TextBoxLineX2.Location = New System.Drawing.Point(1101, 252)
        Me.TextBoxLineX2.Name = "TextBoxLineX2"
        Me.TextBoxLineX2.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxLineX2.TabIndex = 6
        '
        'TextBoxLineY2
        '
        Me.TextBoxLineY2.Location = New System.Drawing.Point(1317, 252)
        Me.TextBoxLineY2.Name = "TextBoxLineY2"
        Me.TextBoxLineY2.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxLineY2.TabIndex = 7
        '
        'TextBoxRectangleX1
        '
        Me.TextBoxRectangleX1.Location = New System.Drawing.Point(1101, 470)
        Me.TextBoxRectangleX1.Name = "TextBoxRectangleX1"
        Me.TextBoxRectangleX1.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxRectangleX1.TabIndex = 8
        '
        'TextBoxRectangleY1
        '
        Me.TextBoxRectangleY1.Location = New System.Drawing.Point(1317, 470)
        Me.TextBoxRectangleY1.Name = "TextBoxRectangleY1"
        Me.TextBoxRectangleY1.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxRectangleY1.TabIndex = 9
        '
        'TextBoxRectangleX2
        '
        Me.TextBoxRectangleX2.Location = New System.Drawing.Point(1101, 515)
        Me.TextBoxRectangleX2.Name = "TextBoxRectangleX2"
        Me.TextBoxRectangleX2.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxRectangleX2.TabIndex = 10
        '
        'TextBoxRectangleY2
        '
        Me.TextBoxRectangleY2.Location = New System.Drawing.Point(1317, 515)
        Me.TextBoxRectangleY2.Name = "TextBoxRectangleY2"
        Me.TextBoxRectangleY2.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxRectangleY2.TabIndex = 11
        '
        'RadioButtonCircleBK
        '
        Me.RadioButtonCircleBK.AutoSize = True
        Me.RadioButtonCircleBK.Location = New System.Drawing.Point(103, 24)
        Me.RadioButtonCircleBK.Name = "RadioButtonCircleBK"
        Me.RadioButtonCircleBK.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonCircleBK.TabIndex = 12
        Me.RadioButtonCircleBK.Text = "●"
        Me.RadioButtonCircleBK.UseVisualStyleBackColor = True
        '
        'RadioButtonCircleClear
        '
        Me.RadioButtonCircleClear.AutoSize = True
        Me.RadioButtonCircleClear.Location = New System.Drawing.Point(221, 24)
        Me.RadioButtonCircleClear.Name = "RadioButtonCircleClear"
        Me.RadioButtonCircleClear.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonCircleClear.TabIndex = 13
        Me.RadioButtonCircleClear.Text = "○"
        Me.RadioButtonCircleClear.UseVisualStyleBackColor = True
        '
        'RadioButtonSquareBK
        '
        Me.RadioButtonSquareBK.AutoSize = True
        Me.RadioButtonSquareBK.Location = New System.Drawing.Point(103, 53)
        Me.RadioButtonSquareBK.Name = "RadioButtonSquareBK"
        Me.RadioButtonSquareBK.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonSquareBK.TabIndex = 14
        Me.RadioButtonSquareBK.Text = "■"
        Me.RadioButtonSquareBK.UseVisualStyleBackColor = True
        '
        'RadioButtonSquareClear
        '
        Me.RadioButtonSquareClear.AutoSize = True
        Me.RadioButtonSquareClear.Location = New System.Drawing.Point(221, 53)
        Me.RadioButtonSquareClear.Name = "RadioButtonSquareClear"
        Me.RadioButtonSquareClear.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonSquareClear.TabIndex = 15
        Me.RadioButtonSquareClear.Text = "□"
        Me.RadioButtonSquareClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "半径"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "直径"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1076, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1292, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Y"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1076, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1292, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1076, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1076, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1292, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Y"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1292, 518)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 18)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Y"
        '
        'RadioButtonCircleBK2
        '
        Me.RadioButtonCircleBK2.AutoSize = True
        Me.RadioButtonCircleBK2.Location = New System.Drawing.Point(1101, 603)
        Me.RadioButtonCircleBK2.Name = "RadioButtonCircleBK2"
        Me.RadioButtonCircleBK2.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonCircleBK2.TabIndex = 28
        Me.RadioButtonCircleBK2.TabStop = True
        Me.RadioButtonCircleBK2.Text = "●"
        Me.RadioButtonCircleBK2.UseVisualStyleBackColor = True
        '
        'RadioButtonSquareBK2
        '
        Me.RadioButtonSquareBK2.AutoSize = True
        Me.RadioButtonSquareBK2.Location = New System.Drawing.Point(103, 47)
        Me.RadioButtonSquareBK2.Name = "RadioButtonSquareBK2"
        Me.RadioButtonSquareBK2.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonSquareBK2.TabIndex = 29
        Me.RadioButtonSquareBK2.Text = "■"
        Me.RadioButtonSquareBK2.UseVisualStyleBackColor = True
        '
        'RadioButtonCircleClear2
        '
        Me.RadioButtonCircleClear2.AutoSize = True
        Me.RadioButtonCircleClear2.Location = New System.Drawing.Point(221, 19)
        Me.RadioButtonCircleClear2.Name = "RadioButtonCircleClear2"
        Me.RadioButtonCircleClear2.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonCircleClear2.TabIndex = 30
        Me.RadioButtonCircleClear2.Text = "○"
        Me.RadioButtonCircleClear2.UseVisualStyleBackColor = True
        '
        'RadioButtonSquareClear2
        '
        Me.RadioButtonSquareClear2.AutoSize = True
        Me.RadioButtonSquareClear2.Location = New System.Drawing.Point(221, 47)
        Me.RadioButtonSquareClear2.Name = "RadioButtonSquareClear2"
        Me.RadioButtonSquareClear2.Size = New System.Drawing.Size(51, 22)
        Me.RadioButtonSquareClear2.TabIndex = 31
        Me.RadioButtonSquareClear2.Text = "□"
        Me.RadioButtonSquareClear2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxCircleDiameter)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBoxCircleY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCircleX)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxCircleRadius)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(975, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 110)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "円"
        '
        'TextBoxCircleDiameter
        '
        Me.TextBoxCircleDiameter.Location = New System.Drawing.Point(342, 73)
        Me.TextBoxCircleDiameter.Name = "TextBoxCircleDiameter"
        Me.TextBoxCircleDiameter.ReadOnly = True
        Me.TextBoxCircleDiameter.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxCircleDiameter.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "中心座標"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.GroupBoxAnchor)
        Me.GroupBox2.Location = New System.Drawing.Point(975, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 246)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "線"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 18)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "終点"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 18)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "始点"
        '
        'GroupBoxAnchor
        '
        Me.GroupBoxAnchor.Controls.Add(Me.RadioButtonNone)
        Me.GroupBoxAnchor.Controls.Add(Me.RadioButtonCircleBK)
        Me.GroupBoxAnchor.Controls.Add(Me.RadioButtonSquareBK)
        Me.GroupBoxAnchor.Controls.Add(Me.RadioButtonCircleClear)
        Me.GroupBoxAnchor.Controls.Add(Me.RadioButtonSquareClear)
        Me.GroupBoxAnchor.Location = New System.Drawing.Point(23, 123)
        Me.GroupBoxAnchor.Name = "GroupBoxAnchor"
        Me.GroupBoxAnchor.Size = New System.Drawing.Size(436, 103)
        Me.GroupBoxAnchor.TabIndex = 35
        Me.GroupBoxAnchor.TabStop = False
        Me.GroupBoxAnchor.Text = "端点形状"
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Checked = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(319, 53)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(61, 22)
        Me.RadioButtonNone.TabIndex = 16
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "なし"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.GroupBoxAnchor2)
        Me.GroupBox3.Location = New System.Drawing.Point(975, 443)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 256)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "矩形"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 18)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "座標２"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "座標１"
        '
        'GroupBoxAnchor2
        '
        Me.GroupBoxAnchor2.Controls.Add(Me.RadioButtonNone2)
        Me.GroupBoxAnchor2.Controls.Add(Me.RadioButtonSquareClear2)
        Me.GroupBoxAnchor2.Controls.Add(Me.RadioButtonSquareBK2)
        Me.GroupBoxAnchor2.Controls.Add(Me.RadioButtonCircleClear2)
        Me.GroupBoxAnchor2.Location = New System.Drawing.Point(23, 141)
        Me.GroupBoxAnchor2.Name = "GroupBoxAnchor2"
        Me.GroupBoxAnchor2.Size = New System.Drawing.Size(436, 94)
        Me.GroupBoxAnchor2.TabIndex = 36
        Me.GroupBoxAnchor2.TabStop = False
        Me.GroupBoxAnchor2.Text = "端点形状"
        '
        'RadioButtonNone2
        '
        Me.RadioButtonNone2.AutoSize = True
        Me.RadioButtonNone2.Checked = True
        Me.RadioButtonNone2.Location = New System.Drawing.Point(319, 47)
        Me.RadioButtonNone2.Name = "RadioButtonNone2"
        Me.RadioButtonNone2.Size = New System.Drawing.Size(61, 22)
        Me.RadioButtonNone2.TabIndex = 17
        Me.RadioButtonNone2.TabStop = True
        Me.RadioButtonNone2.Text = "なし"
        Me.RadioButtonNone2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComboBoxLineWidth)
        Me.GroupBox6.Controls.Add(Me.ComboBoxLineType)
        Me.GroupBox6.Controls.Add(Label22)
        Me.GroupBox6.Controls.Add(Label21)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(975, 714)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(475, 187)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "線プロパティ"
        '
        'ComboBoxLineWidth
        '
        Me.ComboBoxLineWidth.FormattingEnabled = True
        Me.ComboBoxLineWidth.Location = New System.Drawing.Point(106, 36)
        Me.ComboBoxLineWidth.Name = "ComboBoxLineWidth"
        Me.ComboBoxLineWidth.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxLineWidth.TabIndex = 47
        '
        'ComboBoxLineType
        '
        Me.ComboBoxLineType.FormattingEnabled = True
        Me.ComboBoxLineType.Location = New System.Drawing.Point(322, 36)
        Me.ComboBoxLineType.Name = "ComboBoxLineType"
        Me.ComboBoxLineType.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxLineType.TabIndex = 46
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NumericUpDownB)
        Me.GroupBox7.Controls.Add(Me.NumericUpDownG)
        Me.GroupBox7.Controls.Add(Me.NumericUpDownR)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Location = New System.Drawing.Point(18, 68)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(451, 94)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "線色"
        '
        'NumericUpDownB
        '
        Me.NumericUpDownB.Location = New System.Drawing.Point(324, 38)
        Me.NumericUpDownB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownB.Name = "NumericUpDownB"
        Me.NumericUpDownB.Size = New System.Drawing.Size(120, 25)
        Me.NumericUpDownB.TabIndex = 45
        '
        'NumericUpDownG
        '
        Me.NumericUpDownG.Location = New System.Drawing.Point(178, 37)
        Me.NumericUpDownG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownG.Name = "NumericUpDownG"
        Me.NumericUpDownG.Size = New System.Drawing.Size(120, 25)
        Me.NumericUpDownG.TabIndex = 44
        '
        'NumericUpDownR
        '
        Me.NumericUpDownR.Location = New System.Drawing.Point(31, 38)
        Me.NumericUpDownR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownR.Name = "NumericUpDownR"
        Me.NumericUpDownR.Size = New System.Drawing.Size(120, 25)
        Me.NumericUpDownR.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(304, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 18)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "B"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(157, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 18)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "G"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 18)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "R"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(1170, 907)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(121, 32)
        Me.ButtonClear.TabIndex = 40
        Me.ButtonClear.Text = "全消し"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDraw
        '
        Me.ButtonDraw.Location = New System.Drawing.Point(1308, 907)
        Me.ButtonDraw.Name = "ButtonDraw"
        Me.ButtonDraw.Size = New System.Drawing.Size(121, 32)
        Me.ButtonDraw.TabIndex = 41
        Me.ButtonDraw.Text = "描画"
        Me.ButtonDraw.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(23, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(936, 916)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 985)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonDraw)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.RadioButtonCircleBK2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxRectangleY2)
        Me.Controls.Add(Me.TextBoxRectangleX2)
        Me.Controls.Add(Me.TextBoxRectangleY1)
        Me.Controls.Add(Me.TextBoxRectangleX1)
        Me.Controls.Add(Me.TextBoxLineY2)
        Me.Controls.Add(Me.TextBoxLineX2)
        Me.Controls.Add(Me.TextBoxLineY1)
        Me.Controls.Add(Me.TextBoxLineX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxAnchor.ResumeLayout(False)
        Me.GroupBoxAnchor.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBoxAnchor2.ResumeLayout(False)
        Me.GroupBoxAnchor2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.NumericUpDownB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCircleX As TextBox
    Friend WithEvents TextBoxCircleRadius As TextBox
    Friend WithEvents TextBoxCircleY As TextBox
    Friend WithEvents TextBoxLineX1 As TextBox
    Friend WithEvents TextBoxLineY1 As TextBox
    Friend WithEvents TextBoxLineX2 As TextBox
    Friend WithEvents TextBoxLineY2 As TextBox
    Friend WithEvents TextBoxRectangleX1 As TextBox
    Friend WithEvents TextBoxRectangleY1 As TextBox
    Friend WithEvents TextBoxRectangleX2 As TextBox
    Friend WithEvents TextBoxRectangleY2 As TextBox
    Friend WithEvents RadioButtonCircleBK As RadioButton
    Friend WithEvents RadioButtonCircleClear As RadioButton
    Friend WithEvents RadioButtonSquareBK As RadioButton
    Friend WithEvents RadioButtonSquareClear As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RadioButtonCircleBK2 As RadioButton
    Friend WithEvents RadioButtonSquareBK2 As RadioButton
    Friend WithEvents RadioButtonCircleClear2 As RadioButton
    Friend WithEvents RadioButtonSquareClear2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBoxAnchor As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBoxAnchor2 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDraw As Button
    Friend WithEvents RadioButtonNone As RadioButton
    Friend WithEvents RadioButtonNone2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxLineType As ComboBox
    Friend WithEvents ComboBoxLineWidth As ComboBox
    Friend WithEvents TextBoxCircleDiameter As TextBox
    Friend WithEvents NumericUpDownB As NumericUpDown
    Friend WithEvents NumericUpDownG As NumericUpDown
    Friend WithEvents NumericUpDownR As NumericUpDown
End Class
