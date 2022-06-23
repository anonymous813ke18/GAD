Imports System.Text.RegularExpressions

Public Class Form1

    Dim str As String = "How are you today?"
    Dim m As Match

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        m = Regex.Match(str, "\bt\S*")

        If m.ToString <> "" Then
            MsgBox("Your string contains a word staritng with t")
        Else
            MsgBox("Your string doesn't contain a word starting with t")
        End If
    End Sub
End Class
