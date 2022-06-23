Public Class Form1
    
    Dim a As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer = CInt(Math.Ceiling(Rnd() * 300)) + 1
        Dim y As Integer = CInt(Math.Ceiling(Rnd() * 500)) + 1
        Dim a As System.Random = New System.Random
        Dim i As Integer = a.Next(1, 10)
        PictureBox1.Width = 100
        PictureBox1.Height = 100
        PictureBox1.Top = x
        PictureBox1.Left = y
        PictureBox1.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\Wallpapers\Diluc.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(PictureBox1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        PictureBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        PictureBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        a = 0
        Label1.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        a = a + 1
        Label1.Text = "Score = " & a
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button3.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Visible = True
        Timer1.Interval = 1000
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button1.Visible = True
        Timer1.Interval = 750
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.Visible = True
        Timer1.Interval = 500
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class
