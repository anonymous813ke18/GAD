Public Class Form2
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\VB DB\Database2.accdb")
    Dim com As New OleDb.OleDbCommand("Select * from Student", con)
    Dim da As New OleDb.OleDbDataAdapter(com)
    Dim ds As New DataSet()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class