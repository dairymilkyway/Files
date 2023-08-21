Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class AccountSettingsForm
    Private Sub AccountSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCbtn(changepass)



        RCspnl(Panel1)
        RCspnl(Panel2)

    End Sub



    Private Sub changepass_Click(sender As Object, e As EventArgs) Handles changepass.Click
        Dim currentPassword As String = currentpass.Text
        Dim newPassword As String = newpass.Text

        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Dim selectQuery As String = "SELECT password FROM userdata WHERE userid = @userId;"
        Dim updateQuery As String = "UPDATE userdata SET password = @newPassword WHERE userid = @userId;"

        Dim userIdToUpdate As Integer = MainForm.id.Text ' Replace with the actual user ID to update

        Using connection As New MySqlConnection(connectionString)
            ' First, check if the current password matches the one in the database
            Using selectCommand As New MySqlCommand(selectQuery, connection)
                selectCommand.Parameters.AddWithValue("@userId", userIdToUpdate)

                Try
                    connection.Open()
                    Dim storedPassword As String = CStr(selectCommand.ExecuteScalar())
                    If storedPassword = currentPassword Then
                        ' Current password matches, proceed with updating the new password
                        Using updateCommand As New MySqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@newPassword", newPassword)
                            updateCommand.Parameters.AddWithValue("@userId", userIdToUpdate)

                            Try
                                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Password updated successfully.")
                                Else
                                    MessageBox.Show("Password update failed.")
                                End If
                            Catch ex As Exception
                                MessageBox.Show("An error occurred: " & ex.Message)
                            End Try
                        End Using
                    Else
                        MessageBox.Show("Current password does not match.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Private Sub newpassword1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs)

    End Sub
End Class