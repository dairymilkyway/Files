Imports MySql.Data.MySqlClient

Public Class SessionLogForm
    Private Sub SessionLogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RCspnl(Panel5)

        RCbtn(Button6)
        RCbtn(Button7)
        RCbtn(Button8)
        RCbtn(Button9)
        RCbtn(Button10)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click




    End Sub

    Private connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Public Sub session(sender As Object, e As EventArgs) Handles Button6.Click
        Dim allSuccessful As Boolean = True

        For Each key As String In hourlist.Keys
            Dim query As String = hourlist(key)

            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    allSuccessful = False
                    Exit For ' Exit the loop when an error occurs
                End Try
            End Using
        Next

        If allSuccessful Then
            DisplayUpdatedHour() ' Display the updated hour only once after all successful updates
            MessageBox.Show("Success!")
            Timer.Show()
        Else
            MessageBox.Show("An error occurred while processing orders.")
        End If


    End Sub
    Private Sub time_picker(sender As Object, e As EventArgs) Handles Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim userid As Integer = MainForm.id.Text
        Dim hour As Integer
        Select Case sender.name

            Case "Button7"
                hour = 1
                Dim command1 As String = $"INSERT INTO session (userid, hour,date) VALUES ({userid}, {hour}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim command As String = $"UPDATE userdata SET hour = hour - {hour} WHERE userid = {userid}"

                Timer.Timer1.Enabled = True
                Timer.Label2.Hide()
                Timer.Label3.Hide()
                Timer.Label4.Hide()

                hourlist(sender.name) = command1 & ";" & command



            Case "Button8"
                hour = 2
                Dim command1 As String = $"INSERT INTO session (userid, hour,date) VALUES ({userid}, {hour}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim command As String = $"UPDATE userdata SET hour = hour - {hour} WHERE userid = {userid}"
                Timer.Timer2.Enabled = True
                Timer.Label1.Hide()
                Timer.Label3.Hide()
                Timer.Label4.Hide()
                hourlist(sender.name) = command1 & ";" & command

            Case "Button9"
                hour = 3
                Dim command1 As String = $"INSERT INTO session (userid, hour,date) VALUES ({userid}, {hour}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim command As String = $"UPDATE userdata SET hour = hour - {hour} WHERE userid = {userid}"
                Timer.Timer3.Enabled = True
                Timer.Label2.Hide()
                Timer.Label1.Hide()
                Timer.Label4.Hide()
                hourlist(sender.name) = command1 & ";" & command

            Case "Button10"
                hour = 4
                Dim command1 As String = $"INSERT INTO session (userid, hour,date) VALUES ({userid}, {hour}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim command As String = $"UPDATE userdata SET hour = hour - {hour} WHERE userid = {userid}"
                Timer.Timer4.Enabled = True
                Timer.Label2.Hide()
                Timer.Label3.Hide()
                Timer.Label1.Hide()
                hourlist(sender.name) = command1 & ";" & command
        End Select

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        Try
            conn.Open()

            Dim command As New MySqlCommand("SELECT hoursprice FROM memberprice WHERE hoursid = 1", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            reader.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        Try
            conn.Open()

            Dim command As New MySqlCommand("SELECT hoursprice FROM memberprice WHERE hoursid = 2", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            reader.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        Try
            conn.Open()

            Dim command As New MySqlCommand("SELECT hoursprice FROM memberprice WHERE hoursid = 3", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        Try
            conn.Open()

            Dim command As New MySqlCommand("SELECT hoursprice FROM memberprice WHERE hoursid = 4", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Close()
        Finally
            conn.Close()
        End Try
    End Sub
End Class