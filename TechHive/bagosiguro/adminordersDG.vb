Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class adminordersDG
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Private Sub loadorders_Click(sender As Object, e As EventArgs) Handles loadorders.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT o.userid, u.username, o.foodid, f.foodname, f.foodprice, o.orderdate " &
                                  "FROM orders o " &
                                  "INNER JOIN userdata u ON o.userid = u.userid " &
                                  "INNER JOIN foodstocks f ON o.foodid = f.foodid;"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End Using

    End Sub

    Private Sub deleteorder_Click(sender As Object, e As EventArgs) Handles deleteorder.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim orderId As Integer = Convert.ToInt32(DataGridView1.Rows(selectedRowIndex).Cells("foodid").Value)

            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM orders WHERE foodid = @OrderId;"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@OrderId", orderId)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            DataGridView1.Rows.RemoveAt(selectedRowIndex)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub adminordersDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(loadorders)
        RCbtn(deleteorder)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()

        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\Gwyn\Desktop\FINAL FUNDA\TechHive\bagosiguro\CrystalReport4.rpt")
        Form5.CrystalReportViewer1.ReportSource = crystal
        Form5.CrystalReportViewer1.Refresh()
    End Sub
End Class