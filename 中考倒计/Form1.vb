Imports System.IO
Public Class Form1
    Dim Fname As String
    Dim FExtName As String
    Dim timeup As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wrongform As New WrongForm
        Me.Width = My.Settings.Width
        Me.Height = My.Settings.Height
        Me.Left = My.Settings.Left
        Me.Top = My.Settings.Top
        If My.Settings.Width + My.Settings.Left < 0 Or My.Settings.Height + My.Settings.Top < 0 Then
            My.Settings.wrong = 1
            wrongform.Show()
        End If
        Me.LabelDate.Text = My.Settings.EndDate
        Me.Text = My.Settings.WindowTitle
        Me.GroupBox1.Text = My.Settings.ClockTitle
        Me.LabelTitle.Text = My.Settings.ClockMTitle
        Me.GroupBox2.Text = My.Settings.SayTitle
        Me.LabelTitle.ForeColor = My.Settings.ColorT
        Me.LabelDay.ForeColor = My.Settings.ColorD
        Me.LabelDayChn.ForeColor = My.Settings.ColorDC
        Me.LabelDayEng.ForeColor = My.Settings.ColorDC
        Me.LabelHour.ForeColor = My.Settings.ColorTime
        Me.LabelMin.ForeColor = My.Settings.ColorTime
        Me.LabelSec.ForeColor = My.Settings.ColorTime
        Me.LabelHourChn.ForeColor = My.Settings.ColorTC
        Me.LabelHourEng.ForeColor = My.Settings.ColorTC
        Me.LabelMinChn.ForeColor = My.Settings.ColorTC
        Me.LabelMinEng.ForeColor = My.Settings.ColorTC
        Me.LabelSecChn.ForeColor = My.Settings.ColorTC
        Me.LabelSecEng.ForeColor = My.Settings.ColorTC
        Me.StatusStrip1.BackColor = My.Settings.ColorST
        Me.LabelTime.ForeColor = My.Settings.ColorSTT
        Me.LabelSize.ForeColor = My.Settings.ColorSTT
        Me.LabelLock.ForeColor = My.Settings.ColorSTT
        Me.LabelSave.ForeColor = My.Settings.ColorSTT
        Me.LabelByte.ForeColor = My.Settings.ColorSTT
        Me.BackColor = My.Settings.ColorMBack
        Me.GroupBox1.BackColor = My.Settings.ColorG1B
        Me.RichTextBoxSaying.BackColor = My.Settings.ColorG2B
        If My.Settings.G1PY = True Then
            If My.Settings.G1P <> "" Then
                Try
                    Me.GroupBox1.BackgroundImage = Image.FromFile(My.Settings.G1P)
                Catch ex As Exception
                    My.Settings.wrong = 3
                    wrongform.Show()
                End Try
            End If
        End If
        Try
            Me.RichTextBoxSaying.LoadFile(Application.StartupPath & My.Settings.SayingN)
            LabelByte.Text = "字符数：" + CStr(RichTextBoxSaying.TextLength)
            LabelSave.Text = "已保存"
        Catch ex As Exception

        End Try
        Timer1.Start()
        If My.Settings.first = True Then
            My.Settings.first = False
            NewFoc.Show()
        End If
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        Call NotSaveProcess()
        My.Settings.Width = Me.Width
        My.Settings.Height = Me.Height
        My.Settings.Left = Me.Left
        My.Settings.Top = Me.Top
        Me.Close()
        End
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        '储存变量
        Dim w, h As Integer  '窗口大小
        Dim s As Integer '窗口面积
        Dim fsl As Integer '字号等级(Font Size Level)
        Dim ts As Short '标题字号
        Dim tl, tt As Short '标题位置
        Dim ds As Short '天数字号
        Dim dl, dt As Short '天数位置
        Dim dcs As Short '天数中文字号
        Dim dcl, dct As Short '天数中文位置
        Dim des As Short '天数英文字号
        Dim del, det As Short '天数英文位置
        Dim hs As Short '小时、分钟、秒字号
        Dim hl, ht As Short '小时位置
        Dim hcs As Short '小时、分钟、秒中文字号
        Dim hcl, hct As Short '小时中文位置
        Dim hes As Short '小时、分钟、秒英文字号
        Dim hel, het As Short '小时英文位置
        Dim ml, mt As Short '分钟位置
        Dim mcl, mct As Short '分钟中文位置
        Dim mel, met As Short '分钟英文位置
        Dim sl, st As Short '秒位置
        Dim scl, sct As Short '秒中文位置
        Dim sel, set1 As Short '秒英文位置
        Dim gw, gh As Short '计时器组框架的大小
        Dim gw2, gh2 As Short '誓言组框架的大小
        Dim rsw, rsh As Short '誓言框的大小
        Dim x, y, w1 As Long
        x = Screen.PrimaryScreen.Bounds.Width.ToString
        y = Screen.PrimaryScreen.Bounds.Height.ToString
        w = Me.Width
        h = Me.Height
        s = w * h
        w1 = x - 100
        '标题是否显示
        If h >= 200 Then
            LabelTitle.Visible = True
        Else
            LabelTitle.Visible = False
        End If
        '时间是否显示
        If h >= 275 Then
            LabelHour.Visible = True
            LabelHourChn.Visible = True
            LabelHourEng.Visible = True
            LabelMin.Visible = True
            LabelMinChn.Visible = True
            LabelMinEng.Visible = True
            LabelSec.Visible = True
            LabelSecChn.Visible = True
            LabelSecEng.Visible = True
        ElseIf h < 275 Then
            LabelHour.Visible = False
            LabelHourChn.Visible = False
            LabelHourEng.Visible = False
            LabelMin.Visible = False
            LabelMinChn.Visible = False
            LabelMinEng.Visible = False
            LabelSec.Visible = False
            LabelSecChn.Visible = False
            LabelSecEng.Visible = False
        End If
        '誓言是否显示
        If w >= w1 Then
            GroupBox2.Visible = True
            RichTextBoxSaying.Visible = True
        Else
            GroupBox2.Visible = False
            RichTextBoxSaying.Visible = False
        End If
        '计算计时器组框架的大小、位置
        If GroupBox2.Visible = False Then
            GroupBox1.Left = 12
            GroupBox1.Top = 40
            gw = w - 40
            gh = h - 115
        Else
            GroupBox1.Left = 12
            GroupBox1.Top = 40
            gw = w * 0.53125
            gh = h - 115
        End If
        GroupBox1.Width = gw
        GroupBox1.Height = gh
        '计算誓言组框架的大小、位置
        If GroupBox2.Visible = False Then

        Else
            GroupBox2.Left = w * 0.55
            GroupBox2.Top = 40
            gw2 = w * 0.43
            gh2 = h - 115
            GroupBox2.Width = gw2
            GroupBox2.Height = gh2
            '誓言框的大小、位置
            RichTextBoxSaying.Left = 6
            RichTextBoxSaying.Top = 22
            rsw = gw2 - 13
            rsh = gh2 - 26
            RichTextBoxSaying.Width = rsw
            RichTextBoxSaying.Height = rsh
        End If
        '最小
        If h <= 200 Then
            MenuStrip.Visible = False
            StatusStrip1.Visible = False
            GroupBox1.Text = ""
        Else
            MenuStrip.Visible = True
            StatusStrip1.Visible = True
            GroupBox1.Text = "计时器"
        End If
        '计算字号的级别
        If s >= 600000 Then
            fsl = 3
        ElseIf s >= 275625 Then
            fsl = 2
        ElseIf h >= 200 Then
            fsl = 1
        Else
            fsl = 0
        End If
        '调试字号级别
        Select Case fsl
            Case 3
                ts = 40
                ds = 70
                dcs = 45
                des = 30
                hs = 44
                hcs = 35
                hes = 12
            Case 2
                ts = 25
                ds = 55
                dcs = 30
                des = 20
                hs = 33
                hcs = 25
                hes = 10
            Case 1
                ts = 15
                ds = 35
                dcs = 20
                des = 12
                hs = 22
                hcs = 15
                hes = 8
            Case 0
                ts = 2
                ds = 20
                dcs = 12
                des = 8
                hs = 2
                hcs = 2
                hes = 2
        End Select
        '设置标题字体
        LabelTitle.Font = New Font("微软雅黑", ts)
        LabelDay.Font = New Font("微软雅黑", ds, FontStyle.Bold)
        LabelDayChn.Font = New Font("微软雅黑", dcs)
        LabelDayEng.Font = New Font("微软雅黑 light", des)
        LabelHour.Font = New Font("微软雅黑", hs)
        LabelHourChn.Font = New Font("微软雅黑", hcs)
        LabelHourEng.Font = New Font("微软雅黑 light", hes)
        LabelMin.Font = New Font("微软雅黑", hs)
        LabelMinChn.Font = New Font("微软雅黑", hcs)
        LabelMinEng.Font = New Font("微软雅黑 light", hes)
        LabelSec.Font = New Font("微软雅黑", hs)
        LabelSecChn.Font = New Font("微软雅黑", hcs)
        LabelSecEng.Font = New Font("微软雅黑 light", hes)
        '计算标题位置
        If GroupBox2.Visible = True Then
            Select Case fsl
                Case 3
                    tl = gw * 0.2
                    tt = gh * 0.15
                Case Else
                    tl = gw * 0.25
                    tt = gh * 0.2
            End Select
        Else
            Select Case fsl
                Case 3
                    tl = gw * 0.3
                    tt = gh * 0.15
                Case 2
                    tl = gw * 0.35
                    tt = gh * 0.2
                Case 1
                    tl = gw * 0.3
                    tt = gh * 0.15
            End Select
        End If
        LabelTitle.Left = tl
        LabelTitle.Top = tt
        '计算天数的位置
        If GroupBox2.Visible = True Then
            Select Case fsl
                Case 3
                    dl = gw * 0.25
                    dt = tt + 100
                    dcl = dl + 230
                    dct = dt
                    del = dcl
                    det = dct + 75
                Case 2
                    dl = gw * 0.2
                    dt = tt + 50
                    dcl = dl + 185
                    dct = dt
                    del = dcl
                    det = dct + 50
                Case 1
                    LabelTitle.Visible = False
                    dl = gw * 0.2
                    dt = gh * 0.2
                    dcl = dl + 120
                    dct = dt
                    del = dcl
                    det = dct + 32
            End Select
        Else
            Select Case fsl
                Case 3
                    dl = gw * 0.3
                    dt = tt + 100
                    dcl = dl + 230
                    dct = dt
                    del = dcl
                    det = dct + 75
                Case 2
                    dl = gw * 0.32
                    dt = tt + 50
                    dcl = dl + 185
                    dct = dt
                    del = dcl
                    det = dct + 50
                Case 1
                    If LabelTitle.Visible = False Then
                        dl = gw * 0.25
                        dt = gh * 0.27
                    Else
                        dl = gw * 0.25
                        dt = tt + 30
                    End If
                    dcl = dl + 120
                    dct = dt
                    del = dcl
                    det = dct + 32
                Case 0
                    dl = gw * 0.1
                    dt = 15
                    dcl = dl + 75
                    dct = dt
                    del = dcl
                    det = dct + 25
                    GroupBox1.Top = 4
                    GroupBox1.Height = h - 50
            End Select
        End If
        LabelDay.Left = dl
        LabelDay.Top = dt
        LabelDayChn.Left = dcl
        LabelDayChn.Top = dct
        LabelDayEng.Left = del
        LabelDayEng.Top = det
        '计算时间位置
        Select Case fsl
            Case 3
                hl = dl - 100
                ht = dt + 150
                hcl = hl + 85
                hct = ht
                hel = hcl
                het = hct + 55
                ml = hcl + 65
                mt = ht
                mcl = ml + 85
                mct = mt
                mel = mcl
                met = het
                sl = mcl + 65
                st = mt
                scl = sl + 85
                sct = st
                sel = scl
                set1 = met
            Case 2
                hl = dl - 100
                ht = dt + 100
                hcl = hl + 75
                hct = ht
                hel = hcl
                het = hct + 40
                ml = hcl + 65
                mt = ht
                mcl = ml + 75
                mct = mt
                mel = mcl
                met = het
                sl = mcl + 75
                st = mt
                scl = sl + 75
                sct = st
                sel = scl
                set1 = met
            Case 1
                hl = dl - 50
                ht = dt + 73
                hcl = hl + 50
                hct = ht
                hel = hcl
                het = hct + 25
                ml = hcl + 50
                mt = ht
                mcl = ml + 50
                mct = mt
                mel = mcl
                met = het
                sl = mcl + 50
                st = mt
                scl = sl + 50
                sct = st
                sel = scl
                set1 = met
        End Select
        LabelHour.Left = hl
        LabelHour.Top = ht
        LabelHourChn.Left = hcl
        LabelHourChn.Top = hct
        LabelHourEng.Left = hel
        LabelHourEng.Top = het
        LabelMin.Left = ml
        LabelMin.Top = mt
        LabelMinChn.Left = mcl
        LabelMinChn.Top = mct
        LabelMinEng.Left = mel
        LabelMinEng.Top = met
        LabelSec.Left = sl
        LabelSec.Top = st
        LabelSecChn.Left = scl
        LabelSecChn.Top = sct
        LabelSecEng.Left = sel
        LabelSecEng.Top = set1
        '大小状态
        LabelSize.Text = CStr(w) + "," + CStr(h) + "," + CStr(fsl)

    End Sub



    Private Sub 编辑誓言EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编辑誓言EToolStripMenuItem.Click
        编辑誓言EToolStripMenuItem.Enabled = False
        锁定誓言LToolStripMenuItem.Enabled = True
        格式OToolStripMenuItem.Visible = True
        编辑EToolStripMenuItem.Visible = True
        RichTextBoxSaying.ReadOnly = False
        RichTextBoxSaying.BorderStyle = BorderStyle.Fixed3D
        新建NToolStripMenuItem.Enabled = True
        保存SToolStripMenuItem.Enabled = True
        LabelLock.Text = "已解锁"
        LabelSave.Visible = True
        LabelByte.Visible = True
    End Sub

    Private Sub 撤销UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤销UToolStripMenuItem.Click
        RichTextBoxSaying.Undo()
    End Sub

    Private Sub 重做RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重做RToolStripMenuItem.Click
        RichTextBoxSaying.Redo()
    End Sub

    Private Sub 复制CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制CToolStripMenuItem.Click
        RichTextBoxSaying.Copy()
        粘贴PToolStripMenuItem.Enabled = True
    End Sub

    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        RichTextBoxSaying.Cut()
        复制CToolStripMenuItem.Enabled = False
        粘贴PToolStripMenuItem.Enabled = True
    End Sub

    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        RichTextBoxSaying.Paste()
    End Sub

    Private Sub 删除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除DToolStripMenuItem.Click
        RichTextBoxSaying.SelectedText = ""
    End Sub

    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        RichTextBoxSaying.SelectAll()
    End Sub

    Private Sub RichTextBoxSaying_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBoxSaying.SelectionChanged
        If RichTextBoxSaying.SelectedText <> "" Then
            剪切TToolStripMenuItem.Enabled = True
            复制CToolStripMenuItem.Enabled = True
            删除DToolStripMenuItem.Enabled = True
        Else
            剪切TToolStripMenuItem.Enabled = False
            复制CToolStripMenuItem.Enabled = False
            删除DToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RichTextBoxSaying_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxSaying.TextChanged
        If RichTextBoxSaying.Modified Then
            LabelSave.Text = "未保存"
        End If
        LabelByte.Text = "字符数：" + CStr(RichTextBoxSaying.TextLength)
    End Sub

    Private Sub 字体FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体FToolStripMenuItem.Click
        FontDialog1.ShowEffects = True
        FontDialog1.Font = RichTextBoxSaying.SelectionFont
        If (FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            RichTextBoxSaying.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub 颜色CToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 颜色CToolStripMenuItem1.Click
        ColorDialogBox.AllowFullOpen = True
        ColorDialogBox.AnyColor = True
        ColorDialogBox.Color = RichTextBoxSaying.SelectionColor
        If (ColorDialogBox.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            RichTextBoxSaying.SelectionColor = ColorDialogBox.Color
        End If
    End Sub

    Private Sub 锁定誓言LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 锁定誓言LToolStripMenuItem.Click
        锁定誓言LToolStripMenuItem.Enabled = False
        编辑誓言EToolStripMenuItem.Enabled = True
        格式OToolStripMenuItem.Visible = False
        编辑EToolStripMenuItem.Visible = False
        RichTextBoxSaying.ReadOnly = True
        RichTextBoxSaying.BorderStyle = BorderStyle.None
        新建NToolStripMenuItem.Enabled = False
        保存SToolStripMenuItem.Enabled = False
        LabelLock.Text = "已锁定"
        LabelSave.Visible = False
        LabelByte.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim TheDate As Date
        Dim DayLeft As Integer
        Dim HourLeft, MinLeft, SecLeft As Integer
        TheDate = CDate(LabelDate.Text)
        Try
            DayLeft = DateDiff(DateInterval.DayOfYear, Now, TheDate)
            LabelDay.Text = CStr(DayLeft)
            HourLeft = DateDiff(DateInterval.Hour, Now, TheDate)
            LabelHour.Text = CStr(HourLeft Mod 24)
            MinLeft = DateDiff(DateInterval.Minute, Now, TheDate)
            LabelMin.Text = CStr(MinLeft Mod 60)
            SecLeft = DateDiff(DateInterval.Second, Now, TheDate)
        Catch ex As System.OverflowException
            Timer1.Stop()
            My.Settings.wrong = 4
            WrongForm.Show()
        End Try
        LabelSec.Text = CStr(SecLeft Mod 60)
        If DayLeft < 0 Then
            If My.Settings.DateI = False Then
                My.Settings.wrong = 2
                WrongForm.Show()
                Me.Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub 时间数字NToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialogTime.AllowFullOpen = True
        ColorDialogTime.AnyColor = True
        ColorDialogTime.Color = LabelHour.ForeColor
        If (ColorDialogTime.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            LabelHour.ForeColor = ColorDialogTime.Color
            LabelMin.ForeColor = ColorDialogTime.Color
            LabelSec.ForeColor = ColorDialogTime.Color
        End If
    End Sub

    Private Sub 时间提示TToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialogTime2.AllowFullOpen = True
        ColorDialogTime2.AnyColor = True
        ColorDialogTime2.Color = LabelHourChn.ForeColor
        If (ColorDialogTime2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            LabelHourChn.ForeColor = ColorDialogTime2.Color
            LabelMinChn.ForeColor = ColorDialogTime2.Color
            LabelSecChn.ForeColor = ColorDialogTime2.Color
            LabelHourEng.ForeColor = ColorDialogTime2.Color
            LabelMinEng.ForeColor = ColorDialogTime2.Color
            LabelSecEng.ForeColor = ColorDialogTime2.Color
        End If
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click
        Dim about As New About
        about.Show()
    End Sub


    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        Call Save()
    End Sub
    Private Sub NotSaveProcess()
        If RichTextBoxSaying.Modified = True Then
            If MsgBox("尚未保存，是否保存？", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "保存提示") = _
MsgBoxResult.Yes Then
                RichTextBoxSaying.SaveFile(Application.StartupPath & My.Settings.SayingN, RichTextBoxStreamType.RichText)
            End If
        End If
    End Sub
    Private Sub NewFile()
        Call NotSaveProcess()
        Fname = ""
        FExtName = ""
        RichTextBoxSaying.Text = ""
        RichTextBoxSaying.SaveFile(Application.StartupPath & My.Settings.SayingN, RichTextBoxStreamType.RichText)
        RichTextBoxSaying.Modified = False
        LabelSave.Text = "已保存"
    End Sub
    Private Sub FileOpen()
        Call NotSaveProcess()
        OpenFileDialog1.Filter = "RTF 格式文件(*.RTF)|*.RTF"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.Title = "打开文件"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        Fname = OpenFileDialog1.FileName
        If (Fname <> "") Then
            RichTextBoxSaying.LoadFile(Fname, RichTextBoxStreamType.RichText)
            RichTextBoxSaying.SaveFile(Application.StartupPath & My.Settings.SayingN, RichTextBoxStreamType.RichText)
            FExtName = "rtf"
        End If
        RichTextBoxSaying.Modified = False
        LabelSave.Text = "已保存"
    End Sub

    Private Sub 置于顶层TToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles 置于顶层TToolStripMenuItem.CheckedChanged
        If 置于顶层TToolStripMenuItem.Checked = False Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub 新建NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建NToolStripMenuItem.Click
        Call NewFile()
    End Sub
    Private Sub Save()
        If RichTextBoxSaying.Modified Then
            RichTextBoxSaying.SaveFile(Application.StartupPath & My.Settings.SayingN, RichTextBoxStreamType.RichText)
        End If
        RichTextBoxSaying.Modified = False
        LabelSave.Text = "已保存"
    End Sub

    Private Sub 打开OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开OToolStripMenuItem.Click
        Call FileOpen()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim sec As Integer
        LabelTimeup.Text = Val(LabelTimeup.Text) - 1000
        timeup = Val(LabelTimeup.Text)
        sec = timeup / 1000
        LabelTime.Text = "将在" + "  " + CStr(Int(sec / 60)) + "分" + CStr(sec Mod 60) + "秒" + "  " + "后自动关闭"
        If timeup = 0 Then
            End
        End If
    End Sub


    Private Sub 定时关闭EToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 定时关闭EToolStripMenuItem.Click
        Call NotSaveProcess()
        Dim timeupform As New SettingsForm
        Label8.Text = 1
        timeupform.Show()

    End Sub

    Private Sub 小ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 最小SToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 中ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub 宣言TToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 自定义OToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 帮助HToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 帮助HToolStripMenuItem1.Click
        Dim wh As New Form4
        wh.Show()
    End Sub


    Private Sub 左上角ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 左上角ToolStripMenuItem.Click
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub 右上角ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 右上角ToolStripMenuItem.Click
        Dim x, l As Long
        x = Screen.PrimaryScreen.Bounds.Width.ToString
        l = x - Me.Width
        Me.Left = l
        Me.Top = 0
    End Sub

    Private Sub 左下角ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 左下角ToolStripMenuItem.Click
        Dim x, y, t As Long
        x = Screen.PrimaryScreen.Bounds.Width.ToString
        y = Screen.PrimaryScreen.Bounds.Height.ToString
        t = y - Me.Height
        Me.Left = 0
        Me.Top = t
    End Sub

    Private Sub 右下角ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 右下角ToolStripMenuItem.Click
        Dim x, y, l, t As Long
        x = Screen.PrimaryScreen.Bounds.Width.ToString
        y = Screen.PrimaryScreen.Bounds.Height.ToString
        l = x - Me.Width
        t = y - Me.Height
        Me.Left = l
        Me.Top = t
    End Sub

    Private Sub 最小SToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 最小SToolStripMenuItem.Click
        Me.Width = 205
        Me.Height = 109
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Width = 400
        Me.Height = 300
    End Sub

    Private Sub 中ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 中ToolStripMenuItem.Click
        Me.Width = 660
        Me.Height = 450
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Width = 967
        Me.Height = 623
    End Sub

    Private Sub 宣言TToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 宣言TToolStripMenuItem.Click
        Me.Width = Screen.PrimaryScreen.Bounds.Width.ToString - 100
    End Sub



    Private Sub 设置OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置OToolStripMenuItem.Click
        Dim setting As New SettingsForm
        Label8.Text = 0
        setting.Show()
    End Sub

    Private Sub 自定义OToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles 自定义OToolStripMenuItem.Click
        Dim sp As New SettingsForm
        Label8.Text = 0
        sp.Show()
    End Sub
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Width = Me.Width
        My.Settings.Height = Me.Height
        My.Settings.Left = Me.Left
        My.Settings.Top = Me.Top
        My.Settings.DateI = False
    End Sub

    Private Sub 多媒体MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 多媒体MToolStripMenuItem.Click
        Dim media As New Media
        Dim x, l As Long
        media.Show()
        If My.Settings.MTop = True Then
            Me.置于顶层TToolStripMenuItem.Checked = True
        Else
            Me.置于顶层TToolStripMenuItem.Checked = False
        End If
        If My.Settings.MSM = True Then
            Me.Width = 205
            Me.Height = 109
        End If
        If My.Settings.MS = True Then
            Me.Width = 400
            Me.Height = 300
        End If
        If My.Settings.LU = True Then
            Me.Left = 0
            Me.Top = 0
        End If
        If My.Settings.RU = True Then
            x = Screen.PrimaryScreen.Bounds.Width.ToString
            l = x - Me.Width
            Me.Left = l
            Me.Top = 0
        End If
    End Sub

    Private Sub 新功能NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新功能NToolStripMenuItem.Click
        NewFoc.Show()
    End Sub
End Class
