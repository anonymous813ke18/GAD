Public Class Form1

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\GAD\Experiments\Microproject\Microproject.accdb")
    Dim cmd1 As New OleDb.OleDbCommand("Select * from Loginscreen", con)
    Dim da As New OleDb.OleDbDataAdapter(cmd1)
    Dim ds As New DataSet()

    Dim i As Integer

    Dim Category As New Form2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Button2.Visible = False
        Button1.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label3.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        TextBox3.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Loginscreen")
        Button2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        TextBox3.Visible = False
        Label5.ForeColor = Color.Blue
        Label6.ForeColor = Color.Blue
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Button1.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label3.Visible = True
        Label5.Visible = True
        Label7.Visible = True
        Button2.Visible = True
        TextBox3.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Boolean = False
        For i = 0 To ds.Tables("Loginscreen").Rows.Count - 1
            If String.Compare(TextBox1.Text, ds.Tables("Loginscreen").Rows(i).Item(1)) = 0 And String.Compare(TextBox2.Text, ds.Tables("Loginscreen").Rows(i).Item(2)) = 0 Then
                flag = True
            Else
                Continue For
            End If
        Next
        If flag Then
                MessageBox.Show("Log in successful")
                Category.Show()
        Else
            MessageBox.Show("Username or password is wrong")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rowcount As Integer = ds.Tables("Loginscreen").Rows.Count

        Dim cmd2 As New OleDb.OleDbCommand("INSERT INTO Loginscreen VALUES(" & (rowcount + 1) & ",'" & TextBox1.Text & "','" & TextBox2.Text & "')", con)

        If TextBox2.Text = TextBox3.Text Then
            con.Close()
            con.Open()
            cmd2.ExecuteNonQuery()
            con.Close()
            ds.Tables.Clear()
            da.Fill(ds, "Loginscreen")
            MessageBox.Show("Login successfull!")
            Category.Show()
        Else
            ErrorProvider1.SetError(TextBox3, "The passwords entered did not match")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ErrorProvider1.Clear()
    End Sub
End Class
