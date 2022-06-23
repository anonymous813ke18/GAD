Imports System.Text.RegularExpressions

Public Class Form1

    Dim str As String = "How are you today?"
    Dim c As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = Regex.IsMatch(str, "\bt\S*")

        If c Then
            MsgBox("you string contains a letter with t")
        Else
            MsgBox("you string does not contains a letter with t")
        End If
    End Sub
End Class