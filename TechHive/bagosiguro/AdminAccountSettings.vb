Imports MySql.Data.MySqlClient

Public Class AdminAccountSettings

    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

    Private Sub createaccount_Click(sender As Object, e As EventArgs) Handles createaccount.Click
        Dim username As String = createusername.Text
        Dim password As String = createpassword.Text
        Dim conn As New MySqlConnection(connectionString)

        Dim result As MsgBoxResult = MsgBox("Is the User Member?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            conn.Open()

            Dim query As String = "INSERT INTO userdata (username, password, balance, usertype) VALUES (@username, @password, 0, @usertype)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password) ' Use the password entered, not the username
            If result = MsgBoxResult.Yes Then
                cmd.Parameters.AddWithValue("@usertype", "member")
            ElseIf result = MsgBoxResult.No Then
                cmd.Parameters.AddWithValue("@usertype", "student")
            End If

            Dim affectedRows As Integer = cmd.ExecuteNonQuery()
            If affectedRows > 0 Then
                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub AdminAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(createaccount)


        RCspnl(Panel1)
        RCspnl(Panel2)
    End Sub
End Class