Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class adminStocksDG
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Private Sub loadstocks_Click(sender As Object, e As EventArgs) Handles loadstocks.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM foodstocks;"
            Dim dataAdapter As New MySqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            dataAdapter.Fill(dataSet, "TableData")

            DataGridView1.DataSource = dataSet.Tables("TableData")
        End Using
    End Sub

    Private Sub Updatestocks_Click(sender As Object, e As EventArgs) Handles Updatestocks.Click
        Dim foodId As Integer
        Dim newStocks As Integer
        Dim inputFoodId As String = InputBox("Enter Food ID to update stocks:", "Update Stocks")

        If Not String.IsNullOrEmpty(inputFoodId) AndAlso Integer.TryParse(inputFoodId, foodId) Then
            Dim newStocksStr As String = InputBox("Enter new stocks value:", "Update Stocks")

            If Not String.IsNullOrEmpty(newStocksStr) AndAlso Integer.TryParse(newStocksStr, newStocks) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE foodstocks SET stocks = @Stocks WHERE foodid = @FoodId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Stocks", newStocks)
                        command.Parameters.AddWithValue("@FoodId", foodId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("foodid").Value) = foodId Then
                        row.Cells("stocks").Value = newStocks
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please enter a valid stocks value.")
            End If
        Else
            MessageBox.Show("Please enter a valid Food ID.")
        End If
    End Sub

    Private Sub updprice_Click(sender As Object, e As EventArgs) Handles updprice.Click
        Dim inputFoodId As String = InputBox("Enter Food ID to update price:", "Update Price")
        Dim foodId As Integer
        Dim newFoodPrice As Double

        If Not String.IsNullOrEmpty(inputFoodId) AndAlso Integer.TryParse(inputFoodId, foodId) Then
            Dim newFoodPriceStr As String = InputBox("Enter new food price:", "Update Price")

            If Not String.IsNullOrEmpty(newFoodPriceStr) AndAlso Double.TryParse(newFoodPriceStr, newFoodPrice) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE foodstocks SET foodprice = @FoodPrice WHERE foodid = @FoodId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@FoodPrice", newFoodPrice)
                        command.Parameters.AddWithValue("@FoodId", foodId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Update data in DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("foodid").Value) = foodId Then
                        row.Cells("foodprice").Value = newFoodPrice
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please enter a valid food price.")
            End If
        Else
            MessageBox.Show("Please enter a valid Food ID.")
        End If
    End Sub

    Private Sub updisprice_Click(sender As Object, e As EventArgs) Handles updisprice.Click
        Dim inputFoodId As String = InputBox("Enter Food ID to update discount price:", "Update Discount Price")
        Dim foodId As Integer
        Dim newDiscountPrice As Double

        If Not String.IsNullOrEmpty(inputFoodId) AndAlso Integer.TryParse(inputFoodId, foodId) Then
            Dim newDiscountPriceStr As String = InputBox("Enter new discountprice:", "Update Discount Price")

            If Not String.IsNullOrEmpty(newDiscountPriceStr) AndAlso Double.TryParse(newDiscountPriceStr, newDiscountPrice) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE foodstocks SET discountprice = @DiscountPrice WHERE foodid = @FoodId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@DiscountPrice", newDiscountPrice)
                        command.Parameters.AddWithValue("@FoodId", foodId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Update data in DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("foodid").Value) = foodId Then
                        row.Cells("discountprice").Value = newDiscountPrice
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please enter a valid discount price.")
            End If
        Else
            MessageBox.Show("Please enter a valid Food ID.")
        End If
    End Sub

    Private Sub adminStocksDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(loadstocks)
        RCbtn(Updatestocks)
        RCbtn(updprice)
        RCbtn(updisprice)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\Gwyn\Desktop\FINAL FUNDA\TechHive\bagosiguro\CrystalReport3.rpt")
        Form4.CrystalReportViewer1.ReportSource = crystal
        Form4.CrystalReportViewer1.Refresh()
    End Sub
End Class