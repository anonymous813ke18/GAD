Public Class Form1
    Dim ds As New DataSet()
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable("Student")
        Dim dc1 As New DataColumn("Roll no")
        Dim dc2 As New DataColumn("Name")
        Dim dc3 As New DataColumn("Course")
        Dim r1 As DataRow
        Dim r2 As DataRow
        Dim r3 As DataRow
        Dim r4 As DataRow
        Dim r5 As DataRow

        dt.Columns.Add(dc1)
        dt.Columns.Add(dc2)
        dt.Columns.Add(dc3)
        r1 = dt.NewRow()
        r2 = dt.NewRow()
        r3 = dt.NewRow()
        r4 = dt.NewRow()
        r5 = dt.NewRow()

        r1.Item("Roll no") = 20434
        r1.Item("Name") = "Hammad"
        r1.Item("Course") = "CO2I"
        r2.Item("Roll no") = 20433
        r2.Item("Name") = "Mufaddal"
        r2.Item("Course") = "CO2I"
        r3.Item("Roll no") = 20447
        r3.Item("Name") = "Arbaz"
        r3.Item("Course") = "CO2I"
        r4.Item("Roll no") = 20435
        r4.Item("Name") = "Namir"
        r4.Item("Course") = "CO2I"
        r5.Item("Roll no") = 20426
        r5.Item("Name") = "Omar"
        r5.Item("Course") = "CO2I"

        dt.Rows.Add(r1)
        dt.Rows.Add(r2)
        dt.Rows.Add(r3)
        dt.Rows.Add(r4)
        dt.Rows.Add(r5)

        ds.Tables.Add(dt)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class
