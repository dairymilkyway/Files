Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM expenses;"
            Dim dataAdapter As New MySqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            dataAdapter.Fill(dataSet, "TableData")

            DataGridView1.DataSource = dataSet.Tables("TableData")
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim expensesID As Integer
        Dim newCost As Decimal ' Changed data type to Decimal for cost
        Dim inputExpenses As String = InputBox("Enter Expenses ID to update cost:", "Update cost")

        If Not String.IsNullOrEmpty(inputExpenses) AndAlso Integer.TryParse(inputExpenses, expensesID) Then
            Dim newCostStr As String = InputBox("Enter new cost value:", "Update Cost")

            If Not String.IsNullOrEmpty(newCostStr) AndAlso Decimal.TryParse(newCostStr, newCost) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE expenses SET cost = @Cost WHERE expensesid = @ExpensesId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Cost", newCost)
                        command.Parameters.AddWithValue("@ExpensesId", expensesID)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Note: Since you provided no information about DataGridView1, I'm assuming it's similar to the original code.
                ' You would need to replace DataGridView1 with the actual DataGridView control you're using.

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("expensesid").Value) = expensesID Then
                        row.Cells("cost").Value = newCost
                        Exit For
                    End If
                Next
            Else
                        MessageBox.Show("Please enter a valid cost value.")
            End If
        Else
            MessageBox.Show("Please enter a valid expenses ID.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class