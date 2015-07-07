Public Class Form2

    Private Sub Form2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Form1.BackColor = Color.FromArgb(224, 224, 224)
        Form1.TransparencyKey = Color.FromArgb(224, 224, 224)
        Form1.BackgroundImage = Nothing
        Form1.BackgroundImageLayout = ImageLayout.Tile

        Me.Opacity = 0.85
        Form1.Opacity = 0.85
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form1.Close()
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Form1.Timer1.Start()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 80
        TextBox1.Text = "0"
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        TextBox1.Text += 1

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Form1.Timer1.Start()
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Form1.Timer2.Start()
        End If
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        MessageBox.Show("This is my message", "Thats lel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class