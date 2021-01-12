Public Class Form4



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fname As String
        fname = Application.StartupPath + "/Help.rtf"
        Try
            Me.RichTextBox1.LoadFile(fname, RichTextBoxStreamType.RichText)
        Catch ex As Exception
            Me.RichTextBox1.Text = "没有找到帮助文件"
        End Try
    End Sub

    Private Sub Form4_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        RichTextBox1.Width = Me.Width - 50
        RichTextBox1.Height = Me.Height - 100
    End Sub
End Class