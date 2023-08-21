Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports ZstdSharp.Unsafe

Public Class TopupForm
    Public connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Public connection As New MySqlConnection(connectionString)
    Public userCount As Integer = 0


    Private Sub TopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RC(Me)

        RCpanel(Panel1)
        RCpanel(Panel2)

        RCbtn(paynow)
        RCbtn(first)
        RCbtn(Button3)
        RCbtn(Button4)
        RCbtn(third)
        RCbtn(historybtn)

        RCtxt(TextBox1)


        topupbalance()



    End Sub

    Private Sub paynow_click(sender As Object, e As EventArgs) Handles paynow.Click
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Dim result As String = resultid.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim userId As Integer = Convert.ToInt32(result)

                Dim userTypeQuery As String = "SELECT usertype FROM userdata WHERE userid = @userid"
                Dim userTypeCommand As New MySqlCommand(userTypeQuery, connection)
                userTypeCommand.Parameters.AddWithValue("@userid", userId)
                Dim userType As String = Convert.ToString(userTypeCommand.ExecuteScalar())

                If userType = "member" Then
                    ' Code for members
                    member()
                    data()
                    ' Add your code for members here
                    ' ...

                ElseIf userType = "student" Then
                    ' Code for students
                    student()
                    data()
                    ' Add your code for students here
                    ' ...

                Else
                    MessageBox.Show("User not found or has an invalid user type.")
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
        End Try





        'Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        'Dim result As String = InputBox("Enter the user ID:", "Input Box", "Default Value")
        'Dim userId As Integer = Convert.ToInt32(result)

        'Try
        '    connection.Open()



        '    Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
        '    Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
        '    checkUserCommand.Parameters.AddWithValue("@userid", userId)
        '    Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

        '    If userCount > 0 Then
        '        Dim selectedAmount As Decimal = Convert.ToDecimal(TextBox1.Text)
        '        Using connection As New MySqlConnection(connectionString)
        '            connection.Open()

        '            Dim queryBalance As String = $"SELECT balance FROM userdata WHERE username = 'admindev';"
        '            Dim currentBalance As Decimal = 0

        '            Using commandBalance As New MySqlCommand(queryBalance, connection)
        '                Dim balanceResult As Object = commandBalance.ExecuteScalar()
        '                If balanceResult IsNot Nothing AndAlso Decimal.TryParse(balanceResult.ToString(), currentBalance) Then
        '                    If currentBalance >= selectedAmount Then
        '                        Dim queryUpdateBalance As String = $"UPDATE userdata SET balance = balance - @amount WHERE username = 'admindev';"

        '                        Using commandUpdateBalance As New MySqlCommand(queryUpdateBalance, connection)
        '                            commandUpdateBalance.Parameters.AddWithValue("@amount", selectedAmount)
        '                            Dim rowsAffected As Integer = commandUpdateBalance.ExecuteNonQuery()
        '                            If rowsAffected > 0 Then
        '                                ' Update the displayed balance label
        '                                currentBalance -= selectedAmount
        '                                bals.Text = $"${currentBalance}"

        '                                Dim queryupdateuser As String = $"UPDATE userdata SET balance = balance + @amount WHERE userid = @userid"
        '                                Using commandInsertTopUpdate As New MySqlCommand(queryupdateuser, connection)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@topupdate", DateTime.Now)
        '                                    commandInsertTopUpdate.ExecuteNonQuery()
        '                                End Using
        '                                ' Insert into topupdate table
        '                                Dim queryInsertTopUpdate As String = $"INSERT INTO topupdate (userid, amount, topupdate) VALUES (@userid, @amount, @topupdate);"
        '                                Using commandInsertTopUpdate As New MySqlCommand(queryInsertTopUpdate, connection)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
        '                                    commandInsertTopUpdate.Parameters.AddWithValue("@topupdate", DateTime.Now)
        '                                    commandInsertTopUpdate.ExecuteNonQuery()
        '                                End Using

        '                                MessageBox.Show($"Payment of ${selectedAmount} deducted from your balance.")
        '                                connection.Close()
        '                            Else
        '                                MessageBox.Show("Payment failed. Please check your balance.")
        '                            End If
        '                        End Using
        '                    Else
        '                        MessageBox.Show("Insufficient balance for payment.")
        '                    End If
        '                Else
        '                    MessageBox.Show("Error retrieving current balance.")

        '                End If
        '            End Using
        '        End Using
        '    Else
        '        MsgBox("Cannot Find User")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles first.Click


        Dim userId As Integer

        If Integer.TryParse(resultid.Text, userId) Then
            Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

            Dim userType As String = ""
            Using connectionUserType As New MySqlConnection(connectionString)
                connectionUserType.Open()

                Using commandUserType As New MySqlCommand(queryUserType, connectionUserType)
                    Dim result As Object = commandUserType.ExecuteScalar()

                    If result IsNot Nothing Then
                        userType = result.ToString()

                        Dim connectionStringPrices As String = "Data Source=localhost;database=techhive;username=root;password="

                        Using connectionPrices As New MySqlConnection(connectionStringPrices)
                            connectionPrices.Open()

                            If userType = "member" Then
                                Dim queryPrices As String = $"SELECT memberprice.hoursprice FROM memberprice
                                                      WHERE memberprice.hoursid = 1 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("hoursprice"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using

                            ElseIf userType = "student" Then
                                Dim queryPrices As String = $"SELECT studentprice.price FROM studentprice
                                                      WHERE studentprice.hoursid = 1 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("price"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using
                            End If
                        End Using
                    End If
                End Using
            End Using
        End If


    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles second.Click
        Dim userId As Integer

        If Integer.TryParse(resultid.Text, userId) Then
            Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

            Dim userType As String = ""
            Using connectionUserType As New MySqlConnection(connectionString)
                connectionUserType.Open()

                Using commandUserType As New MySqlCommand(queryUserType, connectionUserType)
                    Dim result As Object = commandUserType.ExecuteScalar()

                    If result IsNot Nothing Then
                        userType = result.ToString()

                        Dim connectionStringPrices As String = "Data Source=localhost;database=techhive;username=root;password="

                        Using connectionPrices As New MySqlConnection(connectionStringPrices)
                            connectionPrices.Open()

                            If userType = "member" Then
                                Dim queryPrices As String = $"SELECT memberprice.hoursprice FROM memberprice
                                                      WHERE memberprice.hoursid = 2 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("hoursprice"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using

                            ElseIf userType = "student" Then
                                Dim queryPrices As String = $"SELECT studentprice.price FROM studentprice
                                                      WHERE studentprice.hoursid = 2 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("price"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using
                            End If
                        End Using
                    End If
                End Using
            End Using
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles third.Click
        Dim userId As Integer

        If Integer.TryParse(resultid.Text, userId) Then
            Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

            Dim userType As String = ""
            Using connectionUserType As New MySqlConnection(connectionString)
                connectionUserType.Open()

                Using commandUserType As New MySqlCommand(queryUserType, connectionUserType)
                    Dim result As Object = commandUserType.ExecuteScalar()

                    If result IsNot Nothing Then
                        userType = result.ToString()

                        Dim connectionStringPrices As String = "Data Source=localhost;database=techhive;username=root;password="

                        Using connectionPrices As New MySqlConnection(connectionStringPrices)
                            connectionPrices.Open()

                            If userType = "member" Then
                                Dim queryPrices As String = $"SELECT memberprice.hoursprice FROM memberprice
                                                      WHERE memberprice.hoursid = 3 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("hoursprice"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using

                            ElseIf userType = "student" Then
                                Dim queryPrices As String = $"SELECT studentprice.price FROM studentprice
                                                      WHERE studentprice.hoursid = 3 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("price"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using
                            End If
                        End Using
                    End If
                End Using
            End Using
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles fourth.Click
        Dim userId As Integer

        If Integer.TryParse(resultid.Text, userId) Then
            Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

            Dim userType As String = ""
            Using connectionUserType As New MySqlConnection(connectionString)
                connectionUserType.Open()

                Using commandUserType As New MySqlCommand(queryUserType, connectionUserType)
                    Dim result As Object = commandUserType.ExecuteScalar()

                    If result IsNot Nothing Then
                        userType = result.ToString()

                        Dim connectionStringPrices As String = "Data Source=localhost;database=techhive;username=root;password="

                        Using connectionPrices As New MySqlConnection(connectionStringPrices)
                            connectionPrices.Open()

                            If userType = "member" Then
                                Dim queryPrices As String = $"SELECT memberprice.hoursprice FROM memberprice
                                                      WHERE memberprice.hoursid = 4 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("hoursprice"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using

                            ElseIf userType = "student" Then
                                Dim queryPrices As String = $"SELECT studentprice.price FROM studentprice
                                                      WHERE studentprice.hoursid = 4 LIMIT 25;"

                                Using commandPrices As New MySqlCommand(queryPrices, connectionPrices)
                                    Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                        Dim dataStringBuilder As New StringBuilder()

                                        While reader.Read()
                                            Dim price As Integer = Convert.ToInt32(reader("price"))
                                            dataStringBuilder.AppendLine(price.ToString())
                                        End While

                                        TextBox1.Text = dataStringBuilder.ToString()
                                    End Using
                                End Using
                            End If
                        End Using
                    End If
                End Using
            End Using
        End If

    End Sub

    Private Sub historybtn_Click(sender As Object, e As EventArgs) Handles historybtn.Click
        'Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        'conn.Open()
        'Dim cmd As New MySqlCommand("SELECT userdata.userid,userdata.username,userdata.balance,customerhours.amount, customerhours.hours FROM userdata
        'INNER JOIN customerhours on userdata.username = customerhours.username", conn)

        'Dim reader As MySqlDataReader = cmd.ExecuteReader


        'If reader.Read Then
        '    MsgBox("Customer ID: " & reader("userid") & vbCrLf & "Username: " & reader("username") & vbCrLf & "Balance: $" & reader("balance") & vbCrLf & "Ammount Spend: $" & reader("amount") & vbCrLf & "Total Hours: " & reader("hours"))

        'End If
        'conn.Close()
    End Sub

    Private Sub bals_Click(sender As Object, e As EventArgs) Handles bals.Click

    End Sub
End Class