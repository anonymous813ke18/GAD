Imports System.Text.RegularExpressions


Public Class Form1
    Dim str As String = "it is the last day. How are you today?"
    Dim mc As MatchCollection
    Dim m As Match

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mc = Regex.Matches(str, "\bt\S*")
        For Each m In mc
            Label1.Text = Label1.Text & " " & m.ToString()
        Next
    End Sub
End Class
