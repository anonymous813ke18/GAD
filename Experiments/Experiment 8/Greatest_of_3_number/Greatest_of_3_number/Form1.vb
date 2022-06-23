Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles Button1.Enter
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        If a > b And a > c Then
            MessageBox.Show(a & " is the greatest number", "Result")
        ElseIf b > a And b > c Then
            MessageBox.Show(b & " is the greatest number", "Result")
        Else
            MessageBox.Show(c & " is the greatest number", "Result")
        End If
        Me.Close()
    End Sub
End Class
