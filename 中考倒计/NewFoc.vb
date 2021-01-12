Public Class NewFoc
    Dim t As Integer = (Screen.PrimaryScreen.Bounds.Height.ToString - Me.Width) / 2

    Private Sub NewFoc_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If CheckBox1.Checked = True Then
            My.Settings.first = True
        Else
            My.Settings.first = False
        End If
    End Sub
    Private Sub NewFoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.Bounds.Width.ToString - Me.Width) / 2
        Me.Top = 0 - Me.Width
        Timer1.Start()
        If My.Settings.first = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wrongnum As Integer
        wrongnum = ComboBox1.Text
        If RadioButton1.Checked = True Then
            My.Settings.wrong = wrongnum
            Select Case wrongnum
                Case 1
                    Form1.Close()
                    My.Settings.Left = -1000
                    My.Settings.Top = -1000
                    Application.Restart()
                Case 2
                    My.Settings.EndDate = "2000-01-01 00:00"
                    Form1.LabelDate.Text = My.Settings.EndDate
                Case 3
                    My.Settings.G1P = Application.StartupPath & "\XXX.png"
                    My.Settings.G1PY = True
                    Application.Restart()
                Case 4
                    My.Settings.EndDate = "2100-01-01 00:00"
                    Form1.LabelDate.Text = My.Settings.EndDate
            End Select
        Else
            My.Settings.wrong = wrongnum
            WrongForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("此操作会导致数据丢失，是否继续？", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "恢复初始设置") = MsgBoxResult.Ok Then
            Form1.Close()
            My.Settings.Reset()
            MsgBox("已经恢复初始设置，重启程序后有效。即将重启程序。", MsgBoxStyle.Information, "恢复初始设置")
            Application.Restart()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Top < t Then
            Me.Top = Me.Top + 50
        Else
            Timer1.Stop()
        End If
    End Sub

End Class