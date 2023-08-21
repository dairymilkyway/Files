Imports MySql.Data.MySqlClient
Public Class adminUsersDG
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loadusers.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM userdata;"
            Dim dataAdapter As New MySqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            dataAdapter.Fill(dataSet, "TableData")

            DataGridView1.DataSource = dataSet.Tables("TableData")
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addusers.Click
        Dim newUsername As String = InputBox("Enter username:", "Add New User")
        Dim newPassword As String = InputBox("Enter password:", "Add New User")
        Dim newUserType As String = InputBox("Enter user type:", "Add New User")
        Dim newBalanceStr As String = InputBox("Enter balance:", "Add New User")
        Dim newBalance As Integer

        If Not String.IsNullOrEmpty(newUsername) AndAlso
       Not String.IsNullOrEmpty(newPassword) AndAlso
       Not String.IsNullOrEmpty(newUserType) AndAlso
       Not String.IsNullOrEmpty(newBalanceStr) AndAlso
       Integer.TryParse(newBalanceStr, newBalance) Then

            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "INSERT INTO userdata (username, password, usertype, balance) VALUES (@Username, @Password, @UserType, @Balance);"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", newUsername)
                    command.Parameters.AddWithValue("@Password", newPassword)
                    command.Parameters.AddWithValue("@UserType", newUserType)
                    command.Parameters.AddWithValue("@Balance", newBalance)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh the DataGridView
            RefreshDataGridView()
        Else
            MessageBox.Show("Please enter valid data.")
        End If
    End Sub

    Private Sub RefreshDataGridView()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM userdata;"
            Dim dataAdapter As New MySqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            dataAdapter.Fill(dataSet, "UserData")

            DataGridView1.DataSource = dataSet.Tables("UserData")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteusers.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim selectedUserId As Integer = Convert.ToInt32(DataGridView1.Rows(selectedRowIndex).Cells("userid").Value)

            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM userdata WHERE userid = @userid;"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserId", selectedUserId)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Remove the selected row from DataGridView
            DataGridView1.Rows.RemoveAt(selectedRowIndex)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub updateusers_Click(sender As Object, e As EventArgs) Handles updateusers.Click
        Dim newBalance As Integer
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim selectedUserId As Integer = Convert.ToInt32(DataGridView1.Rows(selectedRowIndex).Cells("userid").Value)

            ' Retrieve existing data
            Dim existingUsername As String = DataGridView1.Rows(selectedRowIndex).Cells("username").Value.ToString()
            Dim existingPassword As String = DataGridView1.Rows(selectedRowIndex).Cells("password").Value.ToString()
            Dim existingUserType As String = DataGridView1.Rows(selectedRowIndex).Cells("usertype").Value.ToString()
            Dim existingBalance As Integer = Convert.ToInt32(DataGridView1.Rows(selectedRowIndex).Cells("balance").Value)

            ' Show input boxes for updating data
            Dim newUsername As String = InputBox("Enter new username:", "Update User Data", existingUsername)
            Dim newPassword As String = InputBox("Enter new password:", "Update User Data", existingPassword)
            Dim newUserType As String = InputBox("Enter new user type:", "Update User Data", existingUserType)
            Dim newBalanceStr As String = InputBox("Enter new balance:", "Update User Data", existingBalance.ToString())

            ' Update data in DataGridView
            DataGridView1.Rows(selectedRowIndex).Cells("username").Value = newUsername
            DataGridView1.Rows(selectedRowIndex).Cells("password").Value = newPassword
            DataGridView1.Rows(selectedRowIndex).Cells("usertype").Value = newUserType
            DataGridView1.Rows(selectedRowIndex).Cells("balance").Value = newBalanceStr

            If Integer.TryParse(newBalanceStr, newBalance) Then
                ' Update data in MySQL database
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE userdata SET username = @Username, password = @Password, usertype = @UserType, balance = @Balance WHERE userid = @UserId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", newUsername)
                        command.Parameters.AddWithValue("@Password", newPassword)
                        command.Parameters.AddWithValue("@UserType", newUserType)
                        command.Parameters.AddWithValue("@Balance", newBalance)
                        command.Parameters.AddWithValue("@UserId", selectedUserId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Else
                MessageBox.Show("Please enter a valid balance.")
            End If
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub adminUsersDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(loadusers)
        RCbtn(deleteusers)
        RCbtn(updateusers)
        RCbtn(addusers)
    End Sub
End Class