Public Class Form1

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Form2.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Show(Me)
        Form2.Location = New Point(Me.Location.X + Me.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Form2.Size.Height / 2))))
        Form2.Width = 80

        Me.BackColor = Color.FromArgb(224, 224, 224)
        Me.TransparencyKey = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If (Me.Location.X + Me.Size.Width) >= Screen.PrimaryScreen.Bounds.Size.Width Then
            Form2.Location = New Point((Me.Location.X + Me.Size.Width) - Form2.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Form2.Size.Height / 2))))
            Form2.Width = 80

        Else

            Form2.Location = New Point(Me.Location.X + Me.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Form2.Size.Height / 2))))
            Form2.Width = 80

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = 0
        Form2.Opacity = 0

        Try

            Dim screenshot As Bitmap
            Dim graph As Graphics

            screenshot = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(Me.Location.X + 8, Me.Location.Y + 8, 0, 0, Me.ClientSize, CopyPixelOperation.SourceCopy)
            screenshot.Save("C:\Users\" & SystemInformation.UserName & "\Desktop\Screenshot" & Form2.TextBox1.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)
            Timer1.Stop()
            Me.Opacity = 0.85
            Form2.Opacity = 0.85

        Catch ex As Exception

            Timer1.Stop()
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Error")
            Timer1.Stop()
            Me.Opacity = 0.85
            Form2.Opacity = 0.85

        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity = 0
        Form2.Opacity = 0

        Try

            Dim screenshot1 As Bitmap
            Dim graph1 As Graphics

            screenshot1 = New Bitmap(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph1 = Graphics.FromImage(screenshot1)
            graph1.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
            screenshot1.Save("C:\Users\" & SystemInformation.UserName & "\Desktop\Screenshot" & Form2.TextBox1.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)

            Me.BackgroundImage = screenshot1
            Me.BackColor = Color.White
            Me.BackgroundImageLayout = ImageLayout.Zoom
            Me.Refresh()
            Me.Size = New Size(Math.Round(Screen.PrimaryScreen.Bounds.Size.Width / 2), Math.Round(Screen.PrimaryScreen.Bounds.Size.Height / 2))

            Timer2.Stop()
            Me.Opacity = 1
            Form2.Opacity = 0.85

        Catch ex As Exception

            Timer2.Stop()
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Error")
            Timer2.Stop()
            Me.Opacity = 0.85
            Form2.Opacity = 0.85

        End Try
    End Sub
End Class
