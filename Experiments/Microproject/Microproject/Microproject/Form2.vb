Public Class Form2

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khan\OneDrive\Desktop\GAD\Experiments\Microproject\Microproject.accdb")
    Dim cmd1 As New OleDb.OleDbCommand("Select * from Loginscreen", con)
    Dim da As New OleDb.OleDbDataAdapter(cmd1)
    Dim ds As New DataSet()

    Dim Clothes As New Form3
    Dim Cosmetics As New Form4
    Dim HomeAppliances As New Form5
    Dim Electronics As New Form6

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Loginscreen")

        Label3.Text = Form1.TextBox1.Text
        Label5.Text = Form1.TextBox2.Text

        Label2.Font = New Font("Arial", 10, FontStyle.Regular)
        Label3.Font = New Font("Arial", 10, FontStyle.Regular)
        Label4.Font = New Font("Arial", 10, FontStyle.Regular)
        Label5.Font = New Font("Arial", 10, FontStyle.Regular)

        PictureBox1.ImageLocation = "C:\Users\Khan\OneDrive\Pictures\GAD\Microproject\admin.jpg"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Form1.Visible = False
        Label1.Font = New Font("Arial", 13, FontStyle.Bold)
        Button10.ForeColor = Color.Red
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clothes.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cosmetics.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HomeAppliances.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Electronics.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class