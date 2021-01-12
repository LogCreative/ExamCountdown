Public Class Media
    Private Sub 打开文件OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开文件OToolStripMenuItem.Click
        OpenFileDialog1.Filter = "音频格式文件(*.wmv;*.asf;*.mp3;*.wav)|*.wmv;*.asf;*.mp3;*.wav|视频格式文件(*.avi;*.mpeg;*.mpg;*.mpa;*.mp4)|*.avi;*.mpeg;*.mpg;*.mpa;*.mp4|所有音视频格式文件(*.wmv;*.asf;*.mp3;*.wav;*.avi;*.mpeg;*.mpg;*.mpa;*.mp4)|*.wmv;*.asf;*.mp3;*.avi;*.mpeg;*.mpg;*.mpa;*.mp4|所有文件(*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.Title = "打开媒体文件"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            Me.Text = AxWindowsMediaPlayer1.status
            Timer1.Start()
        End If
    End Sub

    Private Sub 定时关闭EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 定时关闭EToolStripMenuItem.Click
        Dim MSet As New SettingsForm
        Form1.Label8.Text = 5
        Me.Left = 0
        Me.Top = Screen.PrimaryScreen.Bounds.Height.ToString - Me.Height - 40
        MSet.Show()
    End Sub

    Private Sub Media_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If My.Settings.MTop = True Then
            Form1.置于顶层TToolStripMenuItem.Checked = False
        End If
        My.Settings.MW = Me.Width
        My.Settings.MH = Me.Height
        My.Settings.ML = Me.Left
        My.Settings.MT = Me.Top
    End Sub

    Private Sub Media_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = My.Settings.MW
        Me.Height = My.Settings.MH
        Me.Left = My.Settings.ML
        Me.Top = My.Settings.MT
    End Sub

    Private Sub 退出多媒体EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出多媒体EToolStripMenuItem.Click
        Me.Width = My.Settings.MW
        Me.Height = My.Settings.MH
        Me.Left = My.Settings.ML
        Me.Top = My.Settings.MT
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = AxWindowsMediaPlayer1.status
    End Sub
End Class