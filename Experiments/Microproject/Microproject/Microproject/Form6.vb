Public Class Form6

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\GAD\Experiments\Microproject\Microproject.accdb")
    Dim cmd1 As New OleDb.OleDbCommand("Select * from Electronics", con)
    Dim da As New OleDb.OleDbDataAdapter(cmd1)
    Dim ds As New DataSet()

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Electronics")
        PictureBox1.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\25.jpg"
        PictureBox2.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\26.jpg"
        PictureBox3.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\27.jpg"
        PictureBox4.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\28.jpg"
        PictureBox5.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\29.jpg"
        PictureBox6.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\30.jpg"
        PictureBox7.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\31.jpg"
        PictureBox8.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\32.jpg"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage

        Label2.Text = ds.Tables("Electronics").Rows(0).Item(1)
        Label11.Text = ds.Tables("Electronics").Rows(1).Item(1)
        Label17.Text = ds.Tables("Electronics").Rows(2).Item(1)
        Label23.Text = ds.Tables("Electronics").Rows(3).Item(1)
        Label47.Text = ds.Tables("Electronics").Rows(4).Item(1)
        Label41.Text = ds.Tables("Electronics").Rows(5).Item(1)
        Label35.Text = ds.Tables("Electronics").Rows(6).Item(1)
        Label29.Text = ds.Tables("Electronics").Rows(7).Item(1)

        Label4.Text = ds.Tables("Electronics").Rows(0).Item(2)
        Label9.Text = ds.Tables("Electronics").Rows(1).Item(2)
        Label15.Text = ds.Tables("Electronics").Rows(2).Item(2)
        Label21.Text = ds.Tables("Electronics").Rows(3).Item(2)
        Label45.Text = ds.Tables("Electronics").Rows(4).Item(2)
        Label39.Text = ds.Tables("Electronics").Rows(5).Item(2)
        Label33.Text = ds.Tables("Electronics").Rows(6).Item(2)
        Label27.Text = ds.Tables("Electronics").Rows(7).Item(2)

        Label6.Text = ds.Tables("Electronics").Rows(0).Item(3)
        Label7.Text = ds.Tables("Electronics").Rows(1).Item(3)
        Label13.Text = ds.Tables("Electronics").Rows(2).Item(3)
        Label19.Text = ds.Tables("Electronics").Rows(3).Item(3)
        Label43.Text = ds.Tables("Electronics").Rows(4).Item(3)
        Label37.Text = ds.Tables("Electronics").Rows(5).Item(3)
        Label31.Text = ds.Tables("Electronics").Rows(6).Item(3)
        Label25.Text = ds.Tables("Electronics").Rows(7).Item(3)
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
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(0).Item(3) - 1) & " WHERE Productname = 'LG Washing Machine'", con)
        If ds.Tables("Electronics").Rows(0).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label6.Text = ds.Tables("Electronics").Rows(0).Item(3)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(1).Item(3) - 1) & " WHERE Productname = 'LG Television'", con)
        If ds.Tables("Electronics").Rows(1).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label7.Text = ds.Tables("Electronics").Rows(1).Item(3)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(2).Item(3) - 1) & " WHERE Productname = 'Samsung Washing Machine'", con)
        If ds.Tables("Electronics").Rows(2).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label13.Text = ds.Tables("Electronics").Rows(2).Item(3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(3).Item(3) - 1) & " WHERE Productname = 'Samsung Television'", con)
        If ds.Tables("Electronics").Rows(3).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label19.Text = ds.Tables("Electronics").Rows(3).Item(3)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(4).Item(3) - 1) & " WHERE Productname = 'LG Vacuum cleaner'", con)
        If ds.Tables("Electronics").Rows(4).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label43.Text = ds.Tables("Electronics").Rows(4).Item(3)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(5).Item(3) - 1) & " WHERE Productname = 'LG Oven'", con)
        If ds.Tables("Electronics").Rows(5).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label37.Text = ds.Tables("Electronics").Rows(5).Item(3)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(6).Item(3) - 1) & " WHERE Productname = 'LG Dish washer'", con)
        If ds.Tables("Electronics").Rows(6).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label31.Text = ds.Tables("Electronics").Rows(6).Item(3)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE Electronics SET Available = " & (ds.Tables("Electronics").Rows(7).Item(3) - 1) & " WHERE Productname = 'Oven'", con)
        If ds.Tables("Electronics").Rows(7).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("Electronics").Clear()
            da.Fill(ds, "Electronics")
            Label25.Text = ds.Tables("Electronics").Rows(7).Item(3)
        End If
    End Sub
End Class