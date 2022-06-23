Public Class Form1

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\VB DB\Database2.accdb")
    Dim com As New OleDb.OleDbCommand("Select * from Faculty", con)
    Dim da As New OleDb.OleDbDataAdapter(com)
    Dim ds As New DataSet()
    Dim counter As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = 0
        TextBox1.Text = ds.Tables("Faculty").Rows(counter)("First Name")
        TextBox2.Text = ds.Tables("Faculty").Rows(counter)("Address")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Faculty")
        DataGridView1.DataSource = ds.Tables("Faculty")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If counter = 0 Then
            MsgBox("No previous record")
        Else
            counter = counter - 1
            TextBox1.Text = ds.Tables("Faculty").Rows(counter)("First Name")
            TextBox2.Text = ds.Tables("Faculty").Rows(counter)("Address")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If counter = ds.Tables("Faculty").Rows.Count - 1 Then
            MsgBox("No further record")
        Else
            counter = counter + 1
            TextBox1.Text = ds.Tables("Faculty").Rows(counter)("First Name")
            TextBox2.Text = ds.Tables("Faculty").Rows(counter)("Address")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        counter = ds.Tables("Faculty").Rows.Count - 1
        TextBox1.Text = ds.Tables("Faculty").Rows(counter)("First Name")
        TextBox2.Text = ds.Tables("Faculty").Rows(counter)("Address")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
