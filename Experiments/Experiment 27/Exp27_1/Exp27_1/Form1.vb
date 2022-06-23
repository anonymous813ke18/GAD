Imports System.Data.OleDb

Public Class Form1

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\VB DB\Database2.accdb")
    Dim cmd As New OleDb.OleDbCommand("Select * from Faculty", conn)
    Dim da As New OleDb.OleDbDataAdapter(cmd)
    Dim ds As New DataSet()

    Dim ID As String
    Dim firstName As String
    Dim lastName As String
    Dim address As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Faculty")
        DataGridView1.DataSource = ds.Tables("Faculty")

        If (ds.Tables("Faculty").Rows.Count = 0) Then
            Button3.Visible = False
            Button4.Visible = False
        End If

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False

        Button5.Visible = False
        Button6.Visible = False
        Button8.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True

        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rowCount As Integer
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The ID field cannot be empty!")
        End If
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "The first name field cannot be empty!")
        End If
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "The last name field cannot be empty!")
        End If
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "The last name field cannot be empty!")
        End If
        ID = TextBox1.Text
        firstName = TextBox2.Text
        lastName = TextBox3.Text
        address = TextBox4.Text

        conn.Close()
        conn.Open()
        Dim cmd1 As New OleDb.OleDbCommand("INSERT INTO Faculty VALUES(" + ID + ", '" + firstName + "', '" + lastName + "', '" + address + "')", conn)
        rowCount = cmd1.ExecuteNonQuery()
        MsgBox(rowCount & " rows inserted")
        conn.Close()
        ds.Tables.Clear()
        da.Fill(ds, "Faculty")
        DataGridView1.DataSource = ds.Tables("Faculty")

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False

        Button5.Visible = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True

        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim rowCount As Integer
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The ID field cannot be empty!")
        End If
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "The first name field cannot be empty!")
        End If
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "The last name field cannot be empty!")
        End If
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "The last name field cannot be empty!")
        End If
        ID = TextBox1.Text
        firstName = TextBox2.Text
        lastName = TextBox3.Text
        address = TextBox4.Text

        If (CInt(ID) > ds.Tables("Faculty").Rows.Count) Then
            ErrorProvider1.SetError(TextBox1, "ID out of bound!")
        Else
            conn.Close()
            conn.Open()
            Dim cmd1 As New OleDb.OleDbCommand("UPDATE Faculty SET FirstName = '" + firstName + "', LastName = '" + lastName + "', Address = '" + address + "' WHERE ID = " + ID, conn)
            rowCount = cmd1.ExecuteNonQuery()
            MsgBox(rowCount & " rows updated")
            conn.Close()
            ds.Tables.Clear()
            da.Fill(ds, "Faculty")
            DataGridView1.DataSource = ds.Tables("Faculty")

            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False

            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False

            Button6.Visible = False

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Visible = True
        TextBox1.Visible = True
        Button7.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim rowCount As Integer
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The ID field cannot be empty!")
        End If

        ID = TextBox1.Text

        If (CInt(ID) > ds.Tables("Faculty").Rows.Count) Then
            ErrorProvider1.SetError(TextBox1, "ID out of bound!")
        End If

        conn.Close()
        conn.Open()
        Dim cmd1 As New OleDb.OleDbCommand("DELETE FROM Faculty WHERE ID = " + ID, conn)
        rowCount = cmd1.ExecuteNonQuery()
        MsgBox(rowCount & " rows deleted")
        conn.Close()
        ds.Tables.Clear()
        da.Fill(ds, "Faculty")
        DataGridView1.DataSource = ds.Tables("Faculty")

        Label1.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = ""
        Button7.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Visible = True
        TextBox1.Visible = True
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim fm, lm, ad As String
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "The ID field cannot be empty!")
        End If

        ID = TextBox1.Text

        If (CInt(ID) > ds.Tables("Faculty").Rows.Count) Then
            ErrorProvider1.SetError(TextBox1, "ID out of bound!")
        End If
        fm = ds.Tables("Faculty").Rows(ID - 1)("FirstName")
        lm = ds.Tables("Faculty").Rows(ID - 1)("LastName")
        ad = ds.Tables("Faculty").Rows(ID - 1)("Address")
        MsgBox("First Name = " + fm + vbCrLf & "Last Name = " + lm + vbCrLf & "Address = " + ad)

        Label1.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = ""
        Button8.Visible = False
    End Sub
End Class
