Public Class About
    Dim t As Short
    Dim mediaw As New Media

    Private Sub About_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mediaw.Close()
    End Sub
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        Me.Label1.Text = My.Application.Info.ProductName
        Me.Label2.Text = String.Format("版本 {0}", My.Application.Info.Version.ToString)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width.ToString - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height.ToString - Me.Height) / 2
        mediaw.Show()
        mediaw.AxWindowsMediaPlayer1.URL = Application.StartupPath & "\CHARIOTS OF FIRE-烈火战车.mp3"
        mediaw.AxWindowsMediaPlayer1.settings.volume = 10
        mediaw.Width = 428
        mediaw.Height = 127
        mediaw.Left = Me.Left
        mediaw.Top = Me.Top + Me.Height
        Me.Timer1.Start()
        mediaw.Text = "背景音乐"
        t = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mediaw.Close()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t = t + 1
        If t = 1 Then
            Label11.Visible = False
            Button3.Visible = False
            TextBox1.Text = "感谢支持，这是最后一个版本！"
        ElseIf t = 2 Then
            TextBox1.Text = "如有BUG，将不会另起一个版本。"
        ElseIf t = 3 Then
            TextBox1.Text = "版本 1.0.0.0 创建程序 程序雏形"
        ElseIf t = 4 Then
            TextBox1.Text = "版本 1.0.0.0 大小随意 字体改变"
        ElseIf t = 5 Then
            TextBox1.Text = "版本 1.0.0.0 宣言在右 可隐可现"
        ElseIf t = 6 Then
            TextBox1.Text = "版本 1.1.0.0 大小规则 因机而异"
        ElseIf t = 7 Then
            TextBox1.Text = "版本 1.1.0.0 宣言修改 轻松方便"
        ElseIf t = 8 Then
            TextBox1.Text = "版本 1.2.0.0 窗口大小 可以规则"
        ElseIf t = 9 Then
            TextBox1.Text = "版本 1.2.0.0 添加图标 更加形象"
        ElseIf t = 10 Then
            TextBox1.Text = "版本 1.3.0.0 定时关闭 离开无忧"
        ElseIf t = 11 Then
            TextBox1.Text = "版本 1.3.0.0 自定大小 状态清楚"
        ElseIf t = 12 Then
            TextBox1.Text = "版本 1.3.0.0 置于顶层 明显显示"
        ElseIf t = 13 Then
            TextBox1.Text = "版本 1.3.0.0 帮助文档 轻松使用"
        ElseIf t = 14 Then
            TextBox1.Text = "版本 1.4.0.0 各种设置 一网打尽"
        ElseIf t = 15 Then
            TextBox1.Text = "版本 1.4.0.0 文本颜色 背景图片"
        ElseIf t = 16 Then
            TextBox1.Text = "版本 1.4.0.0 修改日期 自定计时"
        ElseIf t = 17 Then
            TextBox1.Text = "版本 1.4.5.0 标题能改 更加完善"
        ElseIf t = 18 Then
            TextBox1.Text = "版本 1.4.5.0 计时设置 相互规避"
        ElseIf t = 19 Then
            TextBox1.Text = "版本 1.5.0.0 设置保存 不怕关闭"
        ElseIf t = 20 Then
            TextBox1.Text = "版本 1.5.0.0 高级选项 文本透明"
        ElseIf t = 21 Then
            TextBox1.Text = "版本 1.5.0.0 班级宣言 打开就有"
        ElseIf t = 22 Then
            TextBox1.Text = "版本 1.5.0.0 音乐视频 定时关闭"
        ElseIf t = 23 Then
            TextBox1.Text = "版本 1.5.0.0 最终版本 程序成型"
        ElseIf t = 24 Then
            TextBox1.Text = "版本 1.5.0.1 有错无忧 提示解决"
        ElseIf t = 25 Then
            Timer1.Interval = 1
            TextBox1.Text = 1
        ElseIf t > 25 And t < 1526 Then
            TextBox1.Text = TextBox1.Text + 1
        ElseIf t = 1526 Then
            TextBox1.Text = "说明结束 谢谢观看"
            Timer1.Interval = 1500
        ElseIf t = 1527 Then
            TextBox1.Text = "版权所有 翻版必究"
            Button3.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim help As New Form4
        help.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        t = 0
    End Sub

    Private Sub About_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        mediaw.Left = Me.Left
        mediaw.Top = Me.Top + Me.Height
    End Sub
End Class