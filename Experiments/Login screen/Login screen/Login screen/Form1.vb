Public Class Form1

    Dim passwords = New String() {"123", "456", "789", ""}
    Dim username = New String() {"Hammad", "Mufaddal", "Omar", ""}
    Dim p As String
    Dim i, flag_u, flag_p As Integer
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        flag_p = 0
        For i To 4
            If TextBox2.Text = passwords(i) Then
                flag_p = 1
                Exit For
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        flag_u = 0
        For i To 4
            If TextBox1.Text = username(i) Then
                flag_u = 1
                Exit For
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag_p = 1 And flag_u = 1 Then
        ElseIf flag_p <> 1 Then
        ElseIf flag_u <> 1 Then
        End If
    End Sub
End Class

Public Class Form2

End Class

