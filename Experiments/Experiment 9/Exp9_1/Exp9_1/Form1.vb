Public Class Form1

    Dim str As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            str &= CheckBox1.Text
            str &= vbCrLf & ""
        End If
        If CheckBox2.Checked Then
            str &= CheckBox2.Text
            str &= vbCrLf & ""
        End If
        If CheckBox3.Checked Then
            str &= CheckBox3.Text
            str &= vbCrLf & ""
        End If
        If CheckBox4.Checked Then
            str &= CheckBox4.Text
            str &= vbCrLf & ""
        End If
        MessageBox.Show(str)
        Me.Close()
    End Sub
End Class
