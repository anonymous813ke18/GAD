Public Class Form5

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\GAD\Experiments\Microproject\Microproject.accdb")
    Dim cmd1 As New OleDb.OleDbCommand("Select * from HomeAppliances", con)
    Dim da As New OleDb.OleDbDataAdapter(cmd1)
    Dim ds As New DataSet()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "HomeAppliances")
        PictureBox1.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\17.jpeg"
        PictureBox2.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\18.jpeg"
        PictureBox3.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\19.jpeg"
        PictureBox4.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\20.jpeg"
        PictureBox5.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\21.jpeg"
        PictureBox6.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\22.jpeg"
        PictureBox7.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\23.jpeg"
        PictureBox8.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\24.jpeg"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage

        Label2.Text = ds.Tables("HomeAppliances").Rows(0).Item(1)
        Label11.Text = ds.Tables("HomeAppliances").Rows(1).Item(1)
        Label17.Text = ds.Tables("HomeAppliances").Rows(2).Item(1)
        Label23.Text = ds.Tables("HomeAppliances").Rows(3).Item(1)
        Label47.Text = ds.Tables("HomeAppliances").Rows(4).Item(1)
        Label41.Text = ds.Tables("HomeAppliances").Rows(5).Item(1)
        Label35.Text = ds.Tables("HomeAppliances").Rows(6).Item(1)
        Label29.Text = ds.Tables("HomeAppliances").Rows(7).Item(1)

        Label4.Text = ds.Tables("HomeAppliances").Rows(0).Item(2)
        Label9.Text = ds.Tables("HomeAppliances").Rows(1).Item(2)
        Label15.Text = ds.Tables("HomeAppliances").Rows(2).Item(2)
        Label21.Text = ds.Tables("HomeAppliances").Rows(3).Item(2)
        Label45.Text = ds.Tables("HomeAppliances").Rows(4).Item(2)
        Label39.Text = ds.Tables("HomeAppliances").Rows(5).Item(2)
        Label33.Text = ds.Tables("HomeAppliances").Rows(6).Item(2)
        Label27.Text = ds.Tables("HomeAppliances").Rows(7).Item(2)

        Label6.Text = ds.Tables("HomeAppliances").Rows(0).Item(3)
        Label7.Text = ds.Tables("HomeAppliances").Rows(1).Item(3)
        Label13.Text = ds.Tables("HomeAppliances").Rows(2).Item(3)
        Label19.Text = ds.Tables("HomeAppliances").Rows(3).Item(3)
        Label43.Text = ds.Tables("HomeAppliances").Rows(4).Item(3)
        Label37.Text = ds.Tables("HomeAppliances").Rows(5).Item(3)
        Label31.Text = ds.Tables("HomeAppliances").Rows(6).Item(3)
        Label25.Text = ds.Tables("HomeAppliances").Rows(7).Item(3)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(0).Item(3) - 1) & " WHERE Productname = 'Lights'", con)
        If ds.Tables("HomeAppliances").Rows(0).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label6.Text = ds.Tables("HomeAppliances").Rows(0).Item(3)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(1).Item(3) - 1) & " WHERE Productname = 'Chandilier'", con)
        If ds.Tables("HomeAppliances").Rows(1).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label7.Text = ds.Tables("HomeAppliances").Rows(1).Item(3)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(2).Item(3) - 1) & " WHERE Productname = 'TV'", con)
        If ds.Tables("HomeAppliances").Rows(2).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label13.Text = ds.Tables("HomeAppliances").Rows(2).Item(3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(3).Item(3) - 1) & " WHERE Productname = 'Decorative light'", con)
        If ds.Tables("HomeAppliances").Rows(3).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label19.Text = ds.Tables("HomeAppliances").Rows(3).Item(3)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(4).Item(3) - 1) & " WHERE Productname = 'Speakers'", con)
        If ds.Tables("HomeAppliances").Rows(4).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label43.Text = ds.Tables("HomeAppliances").Rows(4).Item(3)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(5).Item(3) - 1) & " WHERE Productname = 'Lamp'", con)
        If ds.Tables("HomeAppliances").Rows(5).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label37.Text = ds.Tables("HomeAppliances").Rows(5).Item(3)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(6).Item(3) - 1) & " WHERE Productname = 'RGB Lights'", con)
        If ds.Tables("HomeAppliances").Rows(6).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label31.Text = ds.Tables("HomeAppliances").Rows(6).Item(3)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim cmd1 As New OleDb.OleDbCommand("UPDATE HomeAppliances SET Available = " & (ds.Tables("HomeAppliances").Rows(7).Item(3) - 1) & " WHERE Productname = 'Bulb'", con)
        If ds.Tables("HomeAppliances").Rows(7).Item(3) = 0 Then
            MessageBox.Show("The item you are trying to purchase is out of stock" & vbCrLf & "Try again later!")
        Else
            con.Close()
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            ds.Tables("HomeAppliances").Clear()
            da.Fill(ds, "HomeAppliances")
            Label25.Text = ds.Tables("HomeAppliances").Rows(7).Item(3)
        End If
    End Sub
End Class