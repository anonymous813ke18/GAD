Imports System.Text.RegularExpressions

Public Class Form1

    Dim c As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The text box cannot be blank!")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        c = Regex.IsMatch(TextBox1.Text, "((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9])")

        If c Then
            MsgBox("The IP address is verified.")
        Else
            ErrorProvider1.SetError(TextBox1, "The IP address is not verified")
        End If
    End Sub
End Class
