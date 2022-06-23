Public Class Form4

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\GAD\Experiments\Microproject\Microproject.accdb")
    Dim cmd1 As New OleDb.OleDbCommand("Select * from Cosmetics", con)
    Dim da As New OleDb.OleDbDataAdapter(cmd1)
    Dim ds As New DataSet()

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Cosmetics")
        PictureBox1.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\9.jpeg"
        PictureBox2.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\10.jpeg"
        PictureBox3.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\11.jpeg"
        PictureBox4.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\12.jpeg"
        PictureBox5.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\13.jpeg"
        PictureBox6.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\14.jpeg"
        PictureBox7.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\15.jpeg"
        PictureBox8.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\16.jpeg"

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage

        Label2.Text = ds.Tables("Cosmetics").Rows(0).Item(1)
        Label11.Text = ds.Tables("Cosmetics").Rows(1).Item(1)
        Label17.Text = ds.Tables("Cosmetics").Rows(2).Item(1)
        Label23.Text = ds.Tables("Cosmetics").Rows(3).Item(1)
        Label47.Text = ds.Tables("Cosmetics").Rows(4).Item(1)
        Label41.Text = ds.Tables("Cosmetics").Rows(5).Item(1)
        Label35.Text = ds.Tables("Cosmetics").Rows(6).Item(1)
        Label29.Text = ds.Tables("Cosmetics").Rows(7).Item(1)

        Label4.Text = ds.Tables("Cosmetics").Rows(0).Item(2)
        Label9.Text = ds.Tables("Cosmetics").Rows(1).Item(2)
        Label15.Text = ds.Tables("Cosmetics").Rows(2).Item(2)
        Label21.Text = ds.Tables("Cosmetics").Rows(3).Item(2)
        Label45.Text = ds.Tables("Cosmetics").Rows(4).Item(2)
        Label39.Text = ds.Tables("Cosmetics").Rows(5).Item(2)
        Label33.Text = ds.Tables("Cosmetics").Rows(6).Item(2)
        Label27.Text = ds.Tables("Cosmetics").Rows(7).Item(2)

        Label6.Text = ds.Tables("Cosmetics").Rows(0).Item(3)
        Label7.Text = ds.Tables("Cosmetics").Rows(1).Item(3)
        Label13.Text = ds.Tables("Cosmetics").Rows(2).Item(3)
        Label19.Text = ds.Tables("Cosmetics").Rows(3).Item(3)
        Label43.Text = ds.Tables("Cosmetics").Rows(4).Item(3)
        Label37.Text = ds.Tables("Cosmetics").Rows(5).Item(3)
        Label31.Text = ds.Tables("Cosmetics").Rows(6).Item(3)
        Label25.Text = ds.Tables("Cosmetics").Rows(7).Item(3)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(0).Item(3) - 1) & " WHERE Productname = 'Lakme Sunscream'", con)
        If ds.Tables("Cosmetics").Rows(0).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label6.Text = ds.Tables("Cosmetics").Rows(0).Item(3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(1).Item(3) - 1) & " WHERE Productname = 'Lip Balm'", con)
        If ds.Tables("Cosmetics").Rows(1).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label7.Text = ds.Tables("Cosmetics").Rows(1).Item(3)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(2).Item(3) - 1) & " WHERE Productname = 'Eye Liner'", con)
        If ds.Tables("Cosmetics").Rows(2).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label13.Text = ds.Tables("Cosmetics").Rows(2).Item(3)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(3).Item(3) - 1) & " WHERE Productname = 'CC Cream'", con)
        If ds.Tables("Cosmetics").Rows(3).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label19.Text = ds.Tables("Cosmetics").Rows(3).Item(3)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(4).Item(3) - 1) & " WHERE Productname = 'Compact'", con)
        If ds.Tables("Cosmetics").Rows(4).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label43.Text = ds.Tables("Cosmetics").Rows(4).Item(3)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(5).Item(3) - 1) & " WHERE Productname = 'Nail Polish'", con)
        If ds.Tables("Cosmetics").Rows(5).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label37.Text = ds.Tables("Cosmetics").Rows(5).Item(3)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(6).Item(3) - 1) & " WHERE Productname = 'Primer'", con)
        If ds.Tables("Cosmetics").Rows(6).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label31.Text = ds.Tables("Cosmetics").Rows(6).Item(3)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Cosmetics SET Available = " & (ds.Tables("Cosmetics").Rows(7).Item(3) - 1) & " WHERE Productname = 'Liner'", con)
        If ds.Tables("Cosmetics").Rows(7).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Cosmetics").Clear()
            da.Fill(ds, "Cosmetics")
            Label25.Text = ds.Tables("Cosmetics").Rows(7).Item(3)
        End If
    End Sub
End Class