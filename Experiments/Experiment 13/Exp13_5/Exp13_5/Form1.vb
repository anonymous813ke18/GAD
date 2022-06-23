Imports System.Text.RegularExpressions

Public Class Form1

    Dim c As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The text box cannot be blank!")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        c = Regex.IsMatch(TextBox1.Text, "[789]\d{9}")

        If c Then
            MsgBox("The number is verified.")
        Else
            ErrorProvider1.SetError(TextBox1, "The number is not verified.")
        End If
    End Sub
End Class
