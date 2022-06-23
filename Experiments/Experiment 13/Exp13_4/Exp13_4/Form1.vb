Imports System.Text.RegularExpressions

Public Class Form1

    Dim c As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The text box cannot be blank!")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        c = Regex.IsMatch(TextBox1.Text, "[0-9][0-9]|1[0-4][0-9]|150")

        If c Then
            MsgBox("The number is between 1 - 150")
        Else
            ErrorProvider1.SetError(TextBox1, "The number is not between 1 - 150")
        End If
    End Sub
End Class
