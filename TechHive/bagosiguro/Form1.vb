Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Bcpg

Public Class Form1
    Public connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Public connection As New MySqlConnection(connectionString)
    Public userCount As Integer = 0

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCspnl(Panel1)

        RC(Me)

        RCbtn(Button1)
        RCbtn(Button2)
        RCbtn(Button3)
        RCbtn(Button4)
    End Sub

    'Private Sub UpdateUserCount()
    '    Try
    '        connection.Open()

    '        ' Get the user count from the Users table
    '        Dim countQuery As String = "SELECT COUNT(*) FROM userdata"
    '        Dim countCommand As New MySqlCommand(countQuery, connection)
    '        userCount = Convert.ToInt32(countCommand.ExecuteScalar())
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = InputBox("Enter the user ID:", "Input Box", "Default Value")
        Dim userid As String
        If Integer.TryParse(result, userid) Then
            Dim seatID As Integer = SeatsForm.id

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Check if the provided userid exists in the userdata table
                    Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
                    Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
                    checkUserCommand.Parameters.AddWithValue("@userid", userid)
                    Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

                    If userCount > 0 Then
                        ' Check if the user ID is already associated with a seat
                        Dim checkSeatAssignedQuery As String = "SELECT COUNT(*) FROM seats WHERE userid = @userid"
                        Dim checkSeatAssignedCommand As New MySqlCommand(checkSeatAssignedQuery, connection)
                        checkSeatAssignedCommand.Parameters.AddWithValue("@userid", userid)
                        Dim assignedCount As Integer = Convert.ToInt32(checkSeatAssignedCommand.ExecuteScalar())

                        If assignedCount = 0 Then
                            ' Update the seat status and associate it with the user
                            Dim updateSeatQuery As String = "UPDATE seats SET status = @Status, userid = @userid WHERE seatid = @SeatID"

                            Using updateSeatCommand As New MySqlCommand(updateSeatQuery, connection)
                                ' Set the appropriate status based on your scenario (in use, reserved, or maintenance)
                                updateSeatCommand.Parameters.AddWithValue("@Status", "in use") ' or "reserved" or "maintenance"
                                updateSeatCommand.Parameters.AddWithValue("@userid", userid)
                                updateSeatCommand.Parameters.AddWithValue("@SeatID", seatID)
                                updateSeatCommand.ExecuteNonQuery()
                                MessageBox.Show("Successfully updated seat status")

                                Me.Hide()
                                reader()
                                status()
                            End Using
                        Else
                            MessageBox.Show("User ID is already associated with a seat.")
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("User ID does not exist in the userdata table.")
                        Me.Hide()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid user ID entered.")
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim seatID As Integer = SeatsForm.id

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Check if the seat is currently occupied
                Dim checkSeatQuery As String = "SELECT status FROM seats WHERE seatid = @SeatID"
                Dim checkSeatCommand As New MySqlCommand(checkSeatQuery, connection)
                checkSeatCommand.Parameters.AddWithValue("@SeatID", seatID)

                Dim currentStatus As String = Convert.ToString(checkSeatCommand.ExecuteScalar())

                If currentStatus = "in use" OrElse currentStatus = "maintenance" Then
                    ' Update the seats table to make the seat vacant and remove the user ID
                    Dim updateQuery As String = "UPDATE seats SET status = @Status, userid = NULL WHERE seatid = @SeatID"
                    Using updateCommand As New MySqlCommand(updateQuery, connection)
                        updateCommand.Parameters.AddWithValue("@Status", "vacant")
                        updateCommand.Parameters.AddWithValue("@SeatID", seatID)
                        updateCommand.ExecuteNonQuery()
                        MessageBox.Show("Successfully vacated the seat")
                        Me.Hide()
                        reader()
                        status()
                    End Using
                ElseIf currentStatus = "vacant" Then
                    MessageBox.Show("The seat is already vacant.")
                    Me.Hide()
                Else
                    MessageBox.Show("Seat not found.")
                    Me.Hide()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As String = InputBox("Enter the user ID:", "Input Box", "Default Value")
        Dim userid As String
        If Integer.TryParse(result, userid) Then
            Dim seatID As Integer = SeatsForm.id

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Check if the provided userid exists in the userdata table
                    Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
                    Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
                    checkUserCommand.Parameters.AddWithValue("@userid", userid)
                    Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

                    If userCount > 0 Then
                        ' Check if the user ID is already associated with a seat
                        Dim checkSeatAssignedQuery As String = "SELECT COUNT(*) FROM seats WHERE userid = @userid"
                        Dim checkSeatAssignedCommand As New MySqlCommand(checkSeatAssignedQuery, connection)
                        checkSeatAssignedCommand.Parameters.AddWithValue("@userid", userid)
                        Dim assignedCount As Integer = Convert.ToInt32(checkSeatAssignedCommand.ExecuteScalar())

                        If assignedCount = 0 Then
                            ' Update the seat status and associate it with the user
                            Dim updateSeatQuery As String = "UPDATE seats SET status = @Status, userid = @userid WHERE seatid = @SeatID"

                            Using updateSeatCommand As New MySqlCommand(updateSeatQuery, connection)
                                ' Set the appropriate status based on your scenario (in use, reserved, or maintenance)
                                updateSeatCommand.Parameters.AddWithValue("@Status", "reserved") ' or "in use" or "maintenance"
                                updateSeatCommand.Parameters.AddWithValue("@userid", userid)
                                updateSeatCommand.Parameters.AddWithValue("@SeatID", seatID)
                                updateSeatCommand.ExecuteNonQuery()
                                MessageBox.Show("Successfully reserved a seat")

                                Me.Hide()

                                reader()
                                status()
                            End Using
                        Else
                            MessageBox.Show("User ID is already associated with a seat.")
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("User ID does not exist in the userdata table.")
                        Me.Hide()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid user ID entered.")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As String = InputBox("Enter the user ID:", "Input Box", "Default Value")
        Dim userid As String
        If Integer.TryParse(result, userid) Then
            Dim seatID As Integer = SeatsForm.id

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Check if the provided userid exists in the userdata table
                    Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
                    Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
                    checkUserCommand.Parameters.AddWithValue("@userid", userid)
                    Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

                    If userCount > 0 Then
                        ' Check if the user ID is already associated with a seat
                        Dim checkSeatAssignedQuery As String = "SELECT COUNT(*) FROM seats WHERE userid = @userid"
                        Dim checkSeatAssignedCommand As New MySqlCommand(checkSeatAssignedQuery, connection)
                        checkSeatAssignedCommand.Parameters.AddWithValue("@userid", userid)
                        Dim assignedCount As Integer = Convert.ToInt32(checkSeatAssignedCommand.ExecuteScalar())

                        If assignedCount = 0 Then
                            ' Update the seat status and associate it with the user
                            Dim updateSeatQuery As String = "UPDATE seats SET status = @Status, userid = @userid WHERE seatid = @SeatID"

                            Using updateSeatCommand As New MySqlCommand(updateSeatQuery, connection)
                                ' Set the appropriate status based on your scenario (in use, reserved, or maintenance)
                                updateSeatCommand.Parameters.AddWithValue("@Status", "maintenance") ' or "in use" or "reserved"
                                updateSeatCommand.Parameters.AddWithValue("@userid", userid)
                                updateSeatCommand.Parameters.AddWithValue("@SeatID", seatID)
                                updateSeatCommand.ExecuteNonQuery()
                                MessageBox.Show("Successfully marked the seat under maintenance")

                                Me.Hide()

                                reader()
                                status()
                            End Using
                        Else
                            MessageBox.Show("User ID is already associated with a seat.")
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("User ID does not exist in the userdata table.")
                        Me.Hide()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid user ID entered.")
        End If

    End Sub
End Class