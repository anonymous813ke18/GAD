Public Class Form1
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\VB DB\Database2.accdb")
    Dim com1 As New OleDb.OleDbCommand("Select * from Student", con)
    Dim com2 As New OleDb.OleDbCommand("Select * from Faculty", con)
    Dim da1 As New OleDb.OleDbDataAdapter(com1)
    Dim da2 As New OleDb.OleDbDataAdapter(com2)
    Dim ds As New DataSet()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        da1.Fill(ds, "Student")
        DataGridView1.DataSource = ds.Tables("Student")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da2.Fill(ds, "Faculty")
        DataGridView2.DataSource = ds.Tables("Faculty")
    End Sub
End Class
