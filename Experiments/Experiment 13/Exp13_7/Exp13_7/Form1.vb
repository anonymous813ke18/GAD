Imports System.Text.RegularExpressions

Public Class Form1

    Dim c As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The text box cannot be blank!")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        c = Regex.IsMatch(TextBox1.Text, "([1-9]|[1-2][0-9]|3[0-1])(\-|\\)([1-9]|1[0-2])(\-|\\)(19[2-9][0-9]|20[0-1][0-9]|202[0-2])")

        If c Then
            MsgBox("The Birthday is verified.")
        Else
            ErrorProvider1.SetError(TextBox1, "The Birthday is not verified")
        End If
    End Sub
End Class
