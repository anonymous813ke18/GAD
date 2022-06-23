Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the first number", "Error 404")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter the second number", "Error 404")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Sum is = " & (a + b), "Result")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the first number", "Error 404")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter the second number", "Error 404")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Diff is = " & (a - b), "Result")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the first number", "Error 404")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter the second number", "Error 404")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Product is = " & (a * b), "Result")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the first number", "Error 404")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter the second number", "Error 404")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Divion is = " & (a / b), "Result")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the first number", "Error 404")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter the second number", "Error 404")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Remainder is = " & (a Mod b), "Result")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
