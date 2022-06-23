Imports System.Text.RegularExpressions

Public Class Form1

    Dim password As Boolean
    Dim username As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The text box cannot be blank!")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        username = Regex.IsMatch(TextBox1.Text, "\d+|\W+")
        password = Regex.IsMatch(TextBox2.Text, "^\d|\W+")

        If username Then
            MsgBox("Username not verified!")
        ElseIf password Then
            MsgBox("Password not verified!")
        Else
            MsgBox("Username and password verified!")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
