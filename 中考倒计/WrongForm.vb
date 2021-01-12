Public Class WrongForm

    Private Sub WrongForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ErrorNum As Integer
        Dim ErrorData As String = ""
        Me.Left = (Screen.PrimaryScreen.Bounds.Width.ToString - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height.ToString - Me.Height) / 2
        Label4.Text = My.Settings.wrong
        ErrorNum = My.Settings.wrong
        Select Case ErrorNum
            Case 1
                ErrorData = "现象：窗口未显示在屏幕之内。" & vbNewLine & "数据：宽度：" & _
                    Form1.Width & "  " & "高度：" & Form1.Height & vbNewLine & _
                    "左：" & Form1.Left & "  " & "顶：" & Form1.Top
                Button1.Text = "恢复部分值为默认值并重启程序(&A)"
                Button2.Text = "恢复全部默认设置并重启程序(&B)"
                Button3.Text = "手动调试(&C)"
            Case 2
                ErrorData = "现象：剩余天数呈负数。" & vbNewLine & "数据：终止日期：" & _
                    My.Settings.EndDate & vbNewLine & "现在日期：" & Now.Date
                Button1.Text = "重新更改日期(&A)"
                Button2.Text = "忽略此问题至程序结束(&B)"
                Button3.Visible = False
            Case 3
                ErrorData = "现象：背景图片出现异常。" & vbNewLine & _
                    "数据：图片位置：" & My.Settings.G1P
                Button1.Text = "恢复此值为默认值(&A)"
                Button2.Text = "改变此值(&B)"
                Button3.Text = "结束程序并手动尝试恢复图片(&C)"
            Case 4
                ErrorData = "现象：倒计时间计算时溢出。" & vbNewLine & _
                    "数据：终止日期：" & Form1.LabelDate.Text & vbNewLine & _
                    "相差时间超过 Integer 数据类型的取值范围。"
                Button1.Text = "恢复此值为默认值(&A)"
                Button2.Text = "改变此值(&B)"
                Button3.Text = "恢复全部默认设置并重启程序(&C)"
        End Select
        TextBox1.Text = ErrorData
        Button1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.wrong = 1 Then
            Form1.Close()
            My.Settings.Width = 400
            My.Settings.Height = 300
            My.Settings.Left = 0
            My.Settings.Top = 0
            Application.Restart()
        ElseIf My.Settings.wrong = 2 Then
            Dim setting As New SettingsForm
            Form1.Label8.Text = 4
            setting.Show()
            setting.DateTimePicker1.Focus()
            Me.Button1.Text = "重启计时器(&R)"
            My.Settings.wrong = 100
            Me.Button2.Visible = False
        ElseIf My.Settings.wrong = 100 Then
            Form1.Timer1.Start()
            Me.Close()
        ElseIf My.Settings.wrong = 3 Then
            My.Settings.G1P = ""
            My.Settings.G1PY = False
            Form1.GroupBox1.BackgroundImage = Nothing
            Me.Close()
        ElseIf My.Settings.wrong = 4 Then
            My.Settings.EndDate = "2015-06-14 08:00"
            Form1.LabelDate.Text = My.Settings.EndDate
            Form1.Timer1.Start()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.wrong = 1 Then
            Form1.Close()
            My.Settings.Reset()
            Application.Restart()
        ElseIf My.Settings.wrong = 2 Then
            Form1.Timer1.Start()
            My.Settings.DateI = True
            Me.Close()
        ElseIf My.Settings.wrong = 3 Then
            Dim setting As New SettingsForm
            Form1.Label8.Text = 3
            setting.Show()
            setting.TextBoxPic.Focus()
            Me.Close()
        ElseIf My.Settings.wrong = 4 Then
            Dim setting As New SettingsForm
            Form1.Label8.Text = 4
            setting.Show()
            setting.DateTimePicker1.Focus()
            Me.Button2.Text = "重启计时器(&R)"
            My.Settings.wrong = 101
            Me.Button1.Visible = False
            Me.Button3.Visible = False
        ElseIf My.Settings.wrong = 101 Then
            Form1.Timer1.Start()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If My.Settings.wrong = 1 Then
            Me.Close()
            MsgBox("点击确定后，先使用 Ctrl+1 （返回左上角），再使用 Ctrl+6 (小号窗口），即可返回默认窗口值。", MsgBoxStyle.Information, "提示")
        ElseIf My.Settings.wrong = 3 Then
            MsgBox("注意将路径和文件名完全正确。" & vbLf & "文件：" & My.Settings.G1P, MsgBoxStyle.Information, "提示")
            Application.Exit()
        ElseIf My.Settings.wrong = 4 Then
            Form1.Close()
            My.Settings.Reset()
            Application.Restart()
        End If
    End Sub
End Class