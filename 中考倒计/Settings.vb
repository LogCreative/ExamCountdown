
Public Class SettingsForm
    Dim open As Boolean

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxWidth.Text = 205
            TextBoxHeight.Text = 109
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBoxWidth.Text = 400
            TextBoxHeight.Text = 300
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBoxWidth.Text = 660
            TextBoxHeight.Text = 450
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBoxWidth.Text = 967
            TextBoxHeight.Text = 623
        End If
    End Sub

    Private Sub TextBoxWidth_TextChanged(sender As Object, e As EventArgs) Handles TextBoxWidth.TextChanged
        Call check()
    End Sub

    Private Sub check()
        Dim x, m, fsl, s As Double
        Dim xv As Boolean
        Dim xvs As String
        x = Screen.PrimaryScreen.Bounds.Width.ToString
        m = x - 100
        Try
            s = Val(TextBoxWidth.Text) * Val(TextBoxHeight.Text)
            If Val(TextBoxWidth.Text) <> 205 Or Val(TextBoxHeight.Text) <> 109 Then
                RadioButton1.Checked = False
            ElseIf Val(TextBoxWidth.Text) = 205 And Val(TextBoxHeight.Text) = 109 Then
                RadioButton1.Checked = True
            End If
            If Val(TextBoxWidth.Text) <> 400 Or Val(TextBoxHeight.Text) <> 300 Then
                RadioButton2.Checked = False
            ElseIf Val(TextBoxWidth.Text) = 400 And Val(TextBoxHeight.Text) = 300 Then
                RadioButton2.Checked = True
            End If
            If Val(TextBoxWidth.Text) <> 660 Or Val(TextBoxHeight.Text) <> 450 Then
                RadioButton3.Checked = False
            ElseIf Val(TextBoxWidth.Text) = 660 And Val(TextBoxHeight.Text) = 450 Then
                RadioButton3.Checked = True
            End If
            If Val(TextBoxWidth.Text) <> 967 Or Val(TextBoxHeight.Text) <> 623 Then
                RadioButton4.Checked = False
            ElseIf Val(TextBoxWidth.Text) = 967 And Val(TextBoxHeight.Text) = 623 Then
                RadioButton4.Checked = True
            End If
            If TextBoxWidth.Text <> "" Then
                If TextBoxWidth.Text >= m Then
                    xv = True
                Else
                    xv = False
                End If
            End If
            If s >= 600000 Then
                fsl = 3
            ElseIf s >= 275625 Then
                fsl = 2
            ElseIf Val(TextBoxHeight.Text) >= 200 Then
                fsl = 1
            Else
                fsl = 0
            End If
        Catch ex As System.InvalidCastException
            MsgBox("输入格式不正确，请确定为纯数字。", MsgBoxStyle.Critical, "错误")
            TextBoxWidth.Text = ""
            TextBoxHeight.Text = ""
        End Try
        If xv = True Then
            xvs = "显示"
        Else
            xvs = "隐藏"
        End If
        TextBox2.Text = "字号等级：" & CStr(fsl) & vbNewLine & "宣言：" & xvs
        ButtonOK.Enabled = True
        ButtonUse.Enabled = True
        If TextBoxWidth.Text = "" Or TextBoxHeight.Text = "" Then
            ButtonOK.Enabled = False
            ButtonUse.Enabled = False
        End If
    End Sub

    Private Sub TextBoxHeight_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHeight.TextChanged
        Call check()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBoxWidth.Text = CStr(Screen.PrimaryScreen.Bounds.Width.ToString - 100)
        Else
            TextBoxWidth.Text = ""
        End If
    End Sub
    Private Sub OK()
        Dim min, sec, time As Integer
        Form1.Width = Val(TextBoxWidth.Text)
        Form1.Height = Val(TextBoxHeight.Text)
        Form1.Left = Val(TextBoxX.Text)
        Form1.Top = Val(TextBoxY.Text)
        min = NumericUpDown1.Value
        sec = NumericUpDown2.Value
        If open = True Then
            time = (min * 60 + sec) * 1000
            Form1.LabelTimeup.Text = CStr(time)
            Form1.Timer2.Start()
        Else
            Form1.Timer2.Stop()
            Form1.LabelTime.Text = "就绪"
        End If
        If TextBoxPic.Text <> "" Then
            Form1.GroupBox1.BackgroundImage = Image.FromFile(TextBoxPic.Text)
            My.Settings.G1P = TextBoxPic.Text
            My.Settings.G1PY = True
        Else
            Form1.GroupBox1.BackgroundImage = Nothing
            My.Settings.G1P = ""
            My.Settings.G1PY = False
        End If
        If TextBoxFT.Text <> "" Then
            Form1.Text = TextBoxFT.Text
        End If
        If TextBoxG1T.Text <> "" Then
            Form1.GroupBox1.Text = TextBoxG1T.Text
        End If
        If TextBoxG2T.Text <> "" Then
            Form1.GroupBox2.Text = TextBoxG2T.Text
        End If
        If TextBoxMT.Text <> "" Then
            Form1.LabelTitle.Text = TextBoxMT.Text
        End If
        Form1.LabelDate.Text = DateTimePicker1.Value
        My.Settings.WindowTitle = TextBoxFT.Text
        My.Settings.ClockTitle = TextBoxG1T.Text
        My.Settings.ClockMTitle = TextBoxMT.Text
        My.Settings.SayTitle = TextBoxG2T.Text
        My.Settings.EndDate = DateTimePicker1.Value
        If CheckBoxMTop.Checked = True Then
            My.Settings.MTop = True
        Else
            My.Settings.MTop = False
        End If
        If CheckBoxS.Checked = True Then
            If RadioButtonSM.Checked = True Then
                My.Settings.MSM = True
            Else
                My.Settings.MSM = False
            End If
            If RadioButtonS.Checked = True Then
                My.Settings.MS = True
            Else
                My.Settings.MS = False
            End If
        End If
        If CheckBoxP.Checked = True Then
            If RadioButtonLU.Checked = True Then
                My.Settings.LU = True
            Else
                My.Settings.LU = False
            End If
            If RadioButtonRU.Checked = True Then
                My.Settings.RU = True
            Else
                My.Settings.RU = False
            End If
        End If
        Form1.Label8.Text = 0
    End Sub
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Call OK()
        Me.Close()
    End Sub

    Private Sub ButtonUse_Click(sender As Object, e As EventArgs) Handles ButtonUse.Click
        Call OK()
        ButtonUse.Enabled = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControlMain.SelectedIndex = CShort(Form1.Label8.Text)
        TextBoxWidth.Text = CStr(Form1.Width)
        TextBoxHeight.Text = CStr(Form1.Height)
        TextBoxX.Text = CStr(Form1.Left)
        TextBoxY.Text = CStr(Form1.Top)
        If Form1.LabelTime.Text = "就绪" Then
            Me.ButtonOpen.Enabled = True
            Me.ButtonClose.Enabled = False
            Me.GroupBox1.Enabled = False
            Me.NumericUpDown1.Value = 10
            Me.NumericUpDown2.Value = 0
            Me.GroupBox6.Visible = False
        Else
            Me.ButtonOpen.Enabled = False
            Me.ButtonClose.Enabled = True
            Me.GroupBox1.Enabled = True
            Me.GroupBox6.Visible = True
            Me.NumericUpDown1.Value = Int((Val(Form1.LabelTimeup.Text) / 1000) / 60)
            Me.NumericUpDown2.Value = (Val(Form1.LabelTimeup.Text) / 1000) Mod 60
        End If
        TextBoxTitle.BackColor = Form1.LabelTitle.ForeColor
        TextBoxDayNumber.BackColor = Form1.LabelDay.ForeColor
        TextBoxDayChn.BackColor = Form1.LabelDayChn.ForeColor
        TextBoxTime.BackColor = Form1.LabelHour.ForeColor
        TextBoxTimeChn.BackColor = Form1.LabelHourChn.ForeColor
        TextBoxStrip.BackColor = Form1.StatusStrip1.BackColor
        TextBoxStripText.BackColor = Form1.LabelTime.ForeColor
        TextBoxBack.BackColor = Form1.BackColor
        If My.Settings.G1PY = False Then
            TextBoxPic.Enabled = False
            ButtonFind.Enabled = False
            RadioButton12.Checked = True
            TextBoxPic.Text = ""
        Else
            TextBoxPic.Enabled = True
            ButtonFind.Enabled = True
            RadioButton13.Checked = True
            TextBoxPic.Text = My.Settings.G1P
        End If
        TextBoxFT.Text = Form1.Text
        TextBoxG1T.Text = Form1.GroupBox1.Text
        TextBoxG2T.Text = Form1.GroupBox2.Text
        TextBoxMT.Text = Form1.LabelTitle.Text
        DateTimePicker1.Value = Form1.LabelDate.Text
        ButtonUse.Enabled = False
        If TextBoxPic.Text = "" Then
            RadioButton12.Checked = True
        End If
        Form1.Left = 0
        Form1.Top = 0
        Me.Left = Screen.PrimaryScreen.Bounds.Width.ToString - Me.Width
        Me.Top = 0
        If My.Settings.MTop = True Then
            CheckBoxMTop.Checked = True
        Else
            CheckBoxMTop.Checked = False
        End If
        If My.Settings.MSM = True Or My.Settings.MS = True Then
            Me.CheckBoxS.Checked = True
            If My.Settings.MSM = True Then
                Me.RadioButtonSM.Checked = True
            ElseIf My.Settings.MS = True Then
                Me.RadioButtonS.Checked = True
            End If
        Else
        Me.CheckBoxS.Checked = False
        End If
        If My.Settings.LU = True Or My.Settings.RU = True Then
            Me.CheckBoxP.Checked = True
            If My.Settings.LU = True Then
                Me.RadioButtonLU.Checked = True
            ElseIf My.Settings.RU = True Then
                Me.RadioButtonRU.Checked = True
            End If
        Else
            Me.CheckBoxP.Checked = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            TextBoxX.Text = 0
            TextBoxY.Text = 0
        End If
        ButtonUse.Enabled = True
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            TextBoxX.Text = Screen.PrimaryScreen.Bounds.Width.ToString - Val(TextBoxWidth.Text)
            TextBoxY.Text = 0
        End If
        ButtonUse.Enabled = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBoxX.Text = 0
            TextBoxY.Text = Screen.PrimaryScreen.Bounds.Height.ToString - Val(TextBoxHeight.Text)
        End If
        ButtonUse.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBoxX.Text = Screen.PrimaryScreen.Bounds.Width.ToString - Val(TextBoxWidth.Text)
            TextBoxY.Text = Screen.PrimaryScreen.Bounds.Height.ToString - Val(TextBoxHeight.Text)
        End If
        ButtonUse.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        ButtonClose.Enabled = True
        ButtonOpen.Enabled = False
        GroupBox1.Enabled = True
        ButtonOK.Enabled = True
        ButtonUse.Enabled = True
        open = True
        GroupBox6.Visible = True
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        ButtonOpen.Enabled = True
        ButtonClose.Enabled = False
        GroupBox1.Enabled = False
        ButtonOK.Enabled = True
        ButtonUse.Enabled = True
        open = False
        GroupBox6.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonTitle.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelTitle.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelTitle.ForeColor = ColorDialog.Color
            TextBoxTitle.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorT = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonDayNumber_Click(sender As Object, e As EventArgs) Handles ButtonDayNumber.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelDay.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelDay.ForeColor = ColorDialog.Color
            TextBoxDayNumber.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorD = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonDayChn_Click(sender As Object, e As EventArgs) Handles ButtonDayChn.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelDayChn.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelDayChn.ForeColor = ColorDialog.Color
            Form1.LabelDayEng.ForeColor = ColorDialog.Color
            TextBoxDayChn.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorDC = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonTime_Click(sender As Object, e As EventArgs) Handles ButtonTime.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelHour.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelHour.ForeColor = ColorDialog.Color
            Form1.LabelMin.ForeColor = ColorDialog.Color
            Form1.LabelSec.ForeColor = ColorDialog.Color
            TextBoxTime.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorTime = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonTimeChn_Click(sender As Object, e As EventArgs) Handles ButtonTimeChn.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelHourChn.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelHourChn.ForeColor = ColorDialog.Color
            Form1.LabelHourEng.ForeColor = ColorDialog.Color
            Form1.LabelMinChn.ForeColor = ColorDialog.Color
            Form1.LabelMinEng.ForeColor = ColorDialog.Color
            Form1.LabelSecChn.ForeColor = ColorDialog.Color
            Form1.LabelSecEng.ForeColor = ColorDialog.Color
            TextBoxTimeChn.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorTC = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonStrip_Click(sender As Object, e As EventArgs) Handles ButtonStrip.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.StatusStrip1.BackColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.StatusStrip1.BackColor = ColorDialog.Color
            TextBoxStrip.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorST = ColorDialog.Color
        End If
    End Sub

    Private Sub ButtonStripText_Click(sender As Object, e As EventArgs) Handles ButtonStripText.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.LabelTime.ForeColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.LabelTime.ForeColor = ColorDialog.Color
            Form1.LabelSize.ForeColor = ColorDialog.Color
            Form1.LabelLock.ForeColor = ColorDialog.Color
            Form1.LabelSave.ForeColor = ColorDialog.Color
            Form1.LabelByte.ForeColor = ColorDialog.Color
            TextBoxStripText.BackColor = ColorDialog.Color
            RadioButton9.Checked = False
            RadioButton9.Checked = False
            RadioButton11.Checked = False
            My.Settings.ColorSTT = ColorDialog.Color
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Form1.LabelTitle.ForeColor = Color.Black
            Form1.LabelDay.ForeColor = Color.Red
            Form1.LabelDayChn.ForeColor = Color.Black
            Form1.LabelDayEng.ForeColor = Color.Black
            Form1.LabelHour.ForeColor = Color.Blue
            Form1.LabelMin.ForeColor = Color.Blue
            Form1.LabelSec.ForeColor = Color.Blue
            Form1.LabelHourChn.ForeColor = Color.Black
            Form1.LabelHourEng.ForeColor = Color.Black
            Form1.LabelMinChn.ForeColor = Color.Black
            Form1.LabelMinEng.ForeColor = Color.Black
            Form1.LabelSecChn.ForeColor = Color.Black
            Form1.LabelSecEng.ForeColor = Color.Black
            Form1.StatusStrip1.BackColor = Color.DodgerBlue
            Form1.LabelTime.ForeColor = Color.White
            Form1.LabelSize.ForeColor = Color.White
            Form1.LabelLock.ForeColor = Color.White
            Form1.LabelSave.ForeColor = Color.White
            Form1.LabelByte.ForeColor = Color.White
            TextBoxTitle.BackColor = Color.Black
            TextBoxDayNumber.BackColor = Color.Red
            TextBoxDayChn.BackColor = Color.Black
            TextBoxTime.BackColor = Color.Blue
            TextBoxTimeChn.BackColor = Color.Black
            TextBoxStrip.BackColor = Color.DodgerBlue
            TextBoxStripText.BackColor = Color.White
            My.Settings.ColorT = Color.Black
            My.Settings.ColorD = Color.Red
            My.Settings.ColorDC = Color.Black
            My.Settings.ColorTime = Color.Blue
            My.Settings.ColorTC = Color.Black
            My.Settings.ColorST = Color.DodgerBlue
            My.Settings.ColorSTT = Color.White
            ButtonUse.Enabled = True
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Form1.LabelTitle.ForeColor = Color.OrangeRed
            Form1.LabelDay.ForeColor = Color.Red
            Form1.LabelDayChn.ForeColor = Color.Red
            Form1.LabelDayEng.ForeColor = Color.Red
            Form1.LabelHour.ForeColor = Color.Chocolate
            Form1.LabelMin.ForeColor = Color.Chocolate
            Form1.LabelSec.ForeColor = Color.Chocolate
            Form1.LabelHourChn.ForeColor = Color.SaddleBrown
            Form1.LabelHourEng.ForeColor = Color.SaddleBrown
            Form1.LabelMinChn.ForeColor = Color.SaddleBrown
            Form1.LabelMinEng.ForeColor = Color.SaddleBrown
            Form1.LabelSecChn.ForeColor = Color.SaddleBrown
            Form1.LabelSecEng.ForeColor = Color.SaddleBrown
            Form1.StatusStrip1.BackColor = Color.Red
            Form1.LabelTime.ForeColor = Color.White
            Form1.LabelSize.ForeColor = Color.White
            Form1.LabelLock.ForeColor = Color.White
            Form1.LabelSave.ForeColor = Color.White
            Form1.LabelByte.ForeColor = Color.White
            TextBoxTitle.BackColor = Color.OrangeRed
            TextBoxDayNumber.BackColor = Color.Red
            TextBoxDayChn.BackColor = Color.Red
            TextBoxTime.BackColor = Color.Chocolate
            TextBoxTimeChn.BackColor = Color.SaddleBrown
            TextBoxStrip.BackColor = Color.Red
            TextBoxStripText.BackColor = Color.White
            My.Settings.ColorT = Color.OrangeRed
            My.Settings.ColorD = Color.Red
            My.Settings.ColorDC = Color.Red
            My.Settings.ColorTime = Color.Chocolate
            My.Settings.ColorTC = Color.SaddleBrown
            My.Settings.ColorST = Color.Red
            My.Settings.ColorSTT = Color.White
            ButtonUse.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Form1.LabelTitle.ForeColor = Color.MediumSeaGreen
            Form1.LabelDay.ForeColor = Color.ForestGreen
            Form1.LabelDayChn.ForeColor = Color.ForestGreen
            Form1.LabelDayEng.ForeColor = Color.ForestGreen
            Form1.LabelHour.ForeColor = Color.LimeGreen
            Form1.LabelMin.ForeColor = Color.LimeGreen
            Form1.LabelSec.ForeColor = Color.LimeGreen
            Form1.LabelHourChn.ForeColor = Color.YellowGreen
            Form1.LabelHourEng.ForeColor = Color.YellowGreen
            Form1.LabelMinChn.ForeColor = Color.YellowGreen
            Form1.LabelMinEng.ForeColor = Color.YellowGreen
            Form1.LabelSecChn.ForeColor = Color.YellowGreen
            Form1.LabelSecEng.ForeColor = Color.YellowGreen
            Form1.StatusStrip1.BackColor = Color.Green
            Form1.LabelTime.ForeColor = Color.White
            Form1.LabelSize.ForeColor = Color.White
            Form1.LabelLock.ForeColor = Color.White
            Form1.LabelSave.ForeColor = Color.White
            Form1.LabelByte.ForeColor = Color.White
            TextBoxTitle.BackColor = Color.MediumSeaGreen
            TextBoxDayNumber.BackColor = Color.ForestGreen
            TextBoxDayChn.BackColor = Color.ForestGreen
            TextBoxTime.BackColor = Color.LimeGreen
            TextBoxTimeChn.BackColor = Color.YellowGreen
            TextBoxStrip.BackColor = Color.Green
            TextBoxStripText.BackColor = Color.White
            My.Settings.ColorT = Color.MediumSeaGreen
            My.Settings.ColorD = Color.ForestGreen
            My.Settings.ColorDC = Color.ForestGreen
            My.Settings.ColorTime = Color.LimeGreen
            My.Settings.ColorTC = Color.YellowGreen
            My.Settings.ColorST = Color.Green
            My.Settings.ColorSTT = Color.White
            ButtonUse.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ButtonBack.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.BackColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.BackColor = ColorDialog.Color
            TextBoxBack.BackColor = ColorDialog.Color
            My.Settings.ColorMBack = ColorDialog.Color
        End If
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.BackColor = Color.WhiteSmoke
        TextBoxBack.BackColor = Color.WhiteSmoke
        My.Settings.ColorMBack = Color.White
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonG1.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.GroupBox1.BackColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.GroupBox1.BackColor = ColorDialog.Color
            TextBoxG1.BackColor = ColorDialog.Color
            My.Settings.ColorG1B = ColorDialog.Color
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.GroupBox1.BackColor = Color.WhiteSmoke
        TextBoxG1.BackColor = Color.WhiteSmoke
        My.Settings.ColorG1B = Color.WhiteSmoke
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            ButtonG1.Enabled = True
            TextBoxG1.Enabled = True
            Button3.Enabled = True
        Else
            ButtonG1.Enabled = False
            TextBoxG1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles ButtonFind.Click
        OpenFileDialog1.Filter = "图像文件 (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|所有文件(*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.Title = "装载图片"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.FileName <> "") Then
            TextBoxPic.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            TextBoxPic.Enabled = True
            ButtonFind.Enabled = True
        Else
            TextBoxPic.Enabled = False
            ButtonFind.Enabled = False
            TextBoxPic.Text = ""
        End If
    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Buttonback1.Click
        Form1.RichTextBoxSaying.BackColor = Color.WhiteSmoke
        TextBoxG2.BackColor = Color.WhiteSmoke
        My.Settings.ColorG2B = Color.WhiteSmoke
    End Sub

    Private Sub ButtonG2_Click(sender As Object, e As EventArgs) Handles ButtonG2.Click
        ColorDialog.AllowFullOpen = True
        ColorDialog.AnyColor = True
        ColorDialog.Color = Form1.RichTextBoxSaying.BackColor
        If (ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Form1.RichTextBoxSaying.BackColor = ColorDialog.Color
            TextBoxG2.BackColor = ColorDialog.Color
            My.Settings.ColorG2B = ColorDialog.Color
        End If
    End Sub

    Private Sub TextBoxFT_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFT.TextChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub TextBoxG1T_TextChanged(sender As Object, e As EventArgs) Handles TextBoxG1T.TextChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub TextBoxG2T_TextChanged(sender As Object, e As EventArgs) Handles TextBoxG2T.TextChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub Button2_Click_4(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxFT.Text = "中考倒计"
        TextBoxG1T.Text = "计时器"
        TextBoxG2T.Text = "班级宣言"
        TextBoxMT.Text = "距离中考还有"
        DateTimePicker1.Value = "2015-06-14 08:00:00"
    End Sub

    Private Sub TextBoxMT_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMT.TextChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub TextBoxPic_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPic.TextChanged
        ButtonUse.Enabled = True
    End Sub

    Private Sub TextBoxX_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX.TextChanged
        Call Pcheck()
    End Sub
    Private Sub Pcheck()
        Dim l, t As Short
        Dim w, h As Short
        w = Screen.PrimaryScreen.Bounds.Width.ToString
        h = Screen.PrimaryScreen.Bounds.Height.ToString
        l = Val(TextBoxX.Text)
        t = Val(TextBoxY.Text)
        If l <> 0 Or t <> 0 Then
            RadioButton8.Checked = False
        ElseIf l = 0 And t = 0 Then
            RadioButton8.Checked = True
        End If
        If l <> w - Val(TextBoxWidth.Text) Or t <> 0 Then
            RadioButton7.Checked = False
        ElseIf l = w - Val(TextBoxWidth.Text) And t = 0 Then
            RadioButton7.Checked = True
        End If
        If l <> 0 Or t <> h - Val(TextBoxHeight.Text) Then
            RadioButton6.Checked = False
        ElseIf l = 0 And t = h - Val(TextBoxHeight.Text) Then
            RadioButton6.Checked = True
        End If
        If l <> w - Val(TextBoxWidth.Text) Or t <> h - Val(TextBoxHeight.Text) Then
            RadioButton5.Checked = False
        ElseIf l = w - Val(TextBoxWidth.Text) And t = h - Val(TextBoxHeight.Text) Then
            RadioButton5.Checked = True
        End If
    End Sub

    Private Sub TextBoxY_TextChanged(sender As Object, e As EventArgs) Handles TextBoxY.TextChanged
        Call Pcheck()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim about As New About
        about.Show()
    End Sub

    Private Sub CheckBoxS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxS.CheckedChanged
        If CheckBoxS.Checked = True Then
            GroupBox14.Enabled = True
        Else
            GroupBox14.Enabled = False
            RadioButtonSM.Checked = False
            RadioButtonS.Checked = False
        End If
    End Sub

    Private Sub CheckBoxP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxP.CheckedChanged
        If CheckBoxP.Checked = True Then
            GroupBox15.Enabled = True
        Else
            GroupBox15.Enabled = False
            RadioButtonLU.Checked = False
            RadioButtonRU.Checked = False
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("此操作会导致数据丢失，是否继续？", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "恢复初始设置") = MsgBoxResult.Ok Then
            Form1.Close()
            My.Settings.Reset()
            MsgBox("已经恢复初始设置，重启程序后有效。即将重启程序。", MsgBoxStyle.Information, "恢复初始设置")
            Application.Restart()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TabControlMain.SelectedIndex = 1
    End Sub
End Class