Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            PictureBox1.Visible = False

            Me.BackgroundImage = My.Resources.bg

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = True
    End Sub


End Class
