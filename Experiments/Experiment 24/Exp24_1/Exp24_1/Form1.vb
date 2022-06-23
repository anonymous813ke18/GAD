Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database2DataSet.Student)

    End Sub
End Class
