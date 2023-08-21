Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class adminTopupDG
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Private Sub loadtopup_Click(sender As Object, e As EventArgs) Handles loadtopup.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT t.userid, u.usertype, u.username, u.balance, t.topupdate " &
                              "FROM topupdate t " &
                              "INNER JOIN userdata u ON t.userid = u.userid;"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub adminTopupDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(loadtopup)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\Gwyn\Desktop\FINAL FUNDA\TechHive\bagosiguro\CrystalReport2.rpt")
        Form3.CrystalReportViewer1.ReportSource = crystal
        Form3.CrystalReportViewer1.Refresh()

    End Sub
End Class