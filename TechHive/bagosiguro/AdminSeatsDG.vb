Imports MySql.Data.MySqlClient

Public Class AdminSeatsDG
    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Private Sub loadseats_Click(sender As Object, e As EventArgs) Handles loadinuseseats.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT s.seatsid, s.status, u.username " &
                                  "FROM seats s " &
                                  "INNER JOIN userdata u ON s.userid = u.userid;"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub vacant_Click(sender As Object, e As EventArgs) Handles vacant.Click
        Dim inputSeatsId As String = InputBox("Enter Seats ID to clear:", "Clear Seat")
        Dim seatsId As Integer

        If Not String.IsNullOrEmpty(inputSeatsId) AndAlso Integer.TryParse(inputSeatsId, seatsId) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "UPDATE seats SET status = 'vacant', userid = NULL WHERE seatid = @SeatsId;"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SeatsId", seatsId)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Update data in DataGridView
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Convert.ToInt32(row.Cells("seatsid").Value) = seatsId Then
                    row.Cells("status").Value = "vacant"
                    row.Cells("userid").Value = DBNull.Value
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Please enter a valid Seats ID.")
        End If
    End Sub

    Private Sub inuse_Click(sender As Object, e As EventArgs) Handles inuse.Click
        Dim inputSeatsId As String = InputBox("Enter Seats ID to occupy:", "Occupy Seat")
        Dim seatsId As Integer
        Dim userId As Integer

        If Not String.IsNullOrEmpty(inputSeatsId) AndAlso Integer.TryParse(inputSeatsId, seatsId) Then
            Dim inputUserId As String = InputBox("Enter User ID:", "Occupy Seat")

            If Not String.IsNullOrEmpty(inputUserId) AndAlso Integer.TryParse(inputUserId, userId) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE seats SET status = 'in use', userid = @UserId WHERE seatid = @SeatsId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@UserId", userId)
                        command.Parameters.AddWithValue("@SeatsId", seatsId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Update data in DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("seatid").Value) = seatsId Then
                        row.Cells("status").Value = "in use"
                        row.Cells("userid").Value = userId
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please enter a valid User ID.")
            End If
        Else
            MessageBox.Show("Please enter a valid Seats ID.")
        End If
    End Sub

    Private Sub reserve_Click(sender As Object, e As EventArgs) Handles reserve.Click
        Dim inputSeatsId As String = InputBox("Enter Seats ID to reserve:", "Reserve Seat")
        Dim seatsId As Integer
        Dim userId As Integer

        If Not String.IsNullOrEmpty(inputSeatsId) AndAlso Integer.TryParse(inputSeatsId, seatsId) Then
            Dim inputUserId As String = InputBox("Enter User ID:", "Reserve Seat")

            If Not String.IsNullOrEmpty(inputUserId) AndAlso Integer.TryParse(inputUserId, userId) Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "UPDATE seats SET status = 'reserved', userid = @UserId WHERE seatsid = @SeatsId;"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@UserId", userId)
                        command.Parameters.AddWithValue("@SeatsId", seatsId)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Update data in DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("seatsid").Value) = seatsId Then
                        row.Cells("status").Value = "reserved"
                        row.Cells("userid").Value = userId
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Please enter a valid User ID.")
            End If
        Else
            MessageBox.Show("Please enter a valid Seats ID.")
        End If
    End Sub

    Private Sub maintance_Click(sender As Object, e As EventArgs) Handles maintance.Click
        Dim inputSeatsId As String = InputBox("Enter Seats ID to mark as maintenance:", "Mark maintenance")
        Dim seatsId As Integer

        If Not String.IsNullOrEmpty(inputSeatsId) AndAlso Integer.TryParse(inputSeatsId, seatsId) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "UPDATE seats SET status = 'maintenance', userid = NULL WHERE seatsid = @SeatsId;"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SeatsId", seatsId)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Update data in DataGridView
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Convert.ToInt32(row.Cells("seatsid").Value) = seatsId Then
                    row.Cells("status").Value = "maintenance"
                    row.Cells("userid").Value = DBNull.Value
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Please enter a valid Seats ID.")
        End If
    End Sub

    Private Sub loadseat_Click(sender As Object, e As EventArgs) Handles loadseat.Click
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM seats;"
            Dim dataAdapter As New MySqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            dataAdapter.Fill(dataSet, "TableData")

            DataGridView1.DataSource = dataSet.Tables("TableData")
        End Using
    End Sub

    Private Sub AdminSeatsDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(loadseat)
        RCbtn(loadinuseseats)
        RCbtn(vacant)
        RCbtn(reserve)
        RCbtn(inuse)
        RCbtn(maintance)
    End Sub
End Class