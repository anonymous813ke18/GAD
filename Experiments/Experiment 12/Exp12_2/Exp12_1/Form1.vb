Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1
        Button2.Visible = False
        Button3.Visible = False
        Label1.Visible = False
        Timer1.Interval = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
        Else
            ProgressBar1.Value += ProgressBar1.Step
            Label1.Text = ProgressBar1.Value & "%"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Label1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        Label1.Text = ""
        Label1.Visible = False
        Button3.Visible = False
        Button2.Visible = False
    End Sub
End Class
