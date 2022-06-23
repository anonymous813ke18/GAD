Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        If a Mod 2 = 0 Then
            MessageBox.Show(a & " is an even number")
        Else
            MessageBox.Show(a & " is an odd number")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c As Integer = TextBox2.Text
        Dim i As Integer
        Dim str As String
        For i = 1 To (c / 2)
            str &= a & " " & b & " "
            a = a + b
            b = a + b
        Next
        MessageBox.Show(str)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
