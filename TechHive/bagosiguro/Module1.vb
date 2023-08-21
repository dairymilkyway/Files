
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Imports Google.Protobuf.Reflection
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Bcpg
Imports ZstdSharp.Unsafe

Module Module1
    Public hourlist As New Dictionary(Of String, Object)
    Public orderlist As New Dictionary(Of String, Object)
    'forms
    Public Sub RC(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'Top Left
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'Top right
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'Bottom right
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'Bottom left
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    'buttons
    Public Sub RCbtn(btn As Button)
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()

        'Top Left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)

        'Top right
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        'Bottom right
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'Bottom left
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        rad.CloseFigure()

        btn.Region = New Region(rad)

    End Sub

    'textbox
    Public Sub RCtxt(txt As TextBox)
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()

        'Top Left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, txt.Width - 20, 0)

        'Top right
        rad.AddArc(New Rectangle(txt.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(txt.Width, 20, txt.Width, txt.Height - 10)

        'Bottom right
        rad.AddArc(New Rectangle(txt.Width - 25, txt.Height - 25, 25, 25), 0, 90)

        'Bottom left
        rad.AddLine(txt.Width - 10, txt.Width, 20, txt.Height)

        rad.AddArc(New Rectangle(0, txt.Height - 20, 20, 20), 90, 90)
        rad.CloseFigure()

        txt.Region = New Region(rad)

    End Sub


    'panel
    Public Sub RCpanel(pnl As Panel)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'Top Left
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, pnl.Width - 40, 0)

        'Top right
        DGP.AddArc(New Rectangle(pnl.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(pnl.Width, 40, pnl.Width, pnl.Height - 40)

        'Bottom right
        DGP.AddArc(New Rectangle(pnl.Width - 40, pnl.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(pnl.Width - 40, pnl.Height, 40, pnl.Height)

        'Bottom left
        DGP.AddArc(New Rectangle(0, pnl.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        pnl.Region = New Region(DGP)
    End Sub

    'small panel
    Public Sub RCspnl(spnl As Panel)
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()

        'Top Left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, spnl.Width - 20, 0)

        'Top right
        rad.AddArc(New Rectangle(spnl.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(spnl.Width, 20, spnl.Width, spnl.Height - 10)

        'Bottom right
        rad.AddArc(New Rectangle(spnl.Width - 25, spnl.Height - 25, 25, 25), 0, 90)

        'Bottom left
        rad.AddLine(spnl.Width - 10, spnl.Width, 20, spnl.Height)

        rad.AddArc(New Rectangle(0, spnl.Height - 20, 20, 20), 90, 90)
        rad.CloseFigure()

        spnl.Region = New Region(rad)

    End Sub

    Public Sub lock()
        SeatsForm.com1.Enabled = False
        SeatsForm.com2.Enabled = False
        SeatsForm.com3.Enabled = False
        SeatsForm.com4.Enabled = False
        SeatsForm.com5.Enabled = False
        SeatsForm.com6.Enabled = False
        SeatsForm.com7.Enabled = False
        SeatsForm.com8.Enabled = False
        SeatsForm.com9.Enabled = False
        SeatsForm.com10.Enabled = False
        SeatsForm.com11.Enabled = False
        SeatsForm.com12.Enabled = False
        SeatsForm.com13.Enabled = False
        SeatsForm.com14.Enabled = False
        SeatsForm.com15.Enabled = False
        SeatsForm.com16.Enabled = False
        SeatsForm.com17.Enabled = False
        SeatsForm.com18.Enabled = False
        SeatsForm.com19.Enabled = False
        SeatsForm.com20.Enabled = False
        SeatsForm.com21.Enabled = False
        SeatsForm.com22.Enabled = False
        SeatsForm.com23.Enabled = False
        SeatsForm.com24.Enabled = False
        SeatsForm.com25.Enabled = False
    End Sub
    Public Sub member()
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Dim result As String = TopupForm.resultid.Text ' Assuming this is your source of data

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim userId As Integer = Convert.ToInt32(result)

                Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
                Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
                checkUserCommand.Parameters.AddWithValue("@userid", userId)
                Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

                If userCount > 0 Then
                    Dim selectedAmount As Integer = Convert.ToInt32(TopupForm.TextBox1.Text)

                    Dim queryBalance As String = "SELECT balance FROM userdata WHERE username = 'admindev';"
                    Dim currentBalance As Decimal = 0

                    Using commandBalance As New MySqlCommand(queryBalance, connection)
                        Dim balanceResult As Object = commandBalance.ExecuteScalar()
                        If balanceResult IsNot Nothing AndAlso Decimal.TryParse(balanceResult.ToString(), currentBalance) Then
                            If currentBalance >= selectedAmount Then
                                Dim queryUpdateBalance As String = "UPDATE userdata SET balance = balance - @amount WHERE username = 'admindev';"

                                Using commandUpdateBalance As New MySqlCommand(queryUpdateBalance, connection)
                                    commandUpdateBalance.Parameters.AddWithValue("@amount", selectedAmount)
                                    Dim rowsAffected As Integer = commandUpdateBalance.ExecuteNonQuery()
                                    If rowsAffected > 0 Then
                                        ' Update the displayed balance label
                                        currentBalance -= selectedAmount
                                        TopupForm.bals.Text = $"${currentBalance}"

                                        Dim queryupdateuser As String = "UPDATE userdata SET balance = balance + @amount WHERE userid = @userid"
                                        Using commandInsertTopUpdate As New MySqlCommand(queryupdateuser, connection)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
                                            commandInsertTopUpdate.ExecuteNonQuery()
                                        End Using

                                        ' Insert into topupdate table
                                        Dim queryInsertTopUpdate As String = "INSERT INTO topupdate (userid, amount, topupdate) VALUES (@userid, @amount, @topupdate);"
                                        Using commandInsertTopUpdate As New MySqlCommand(queryInsertTopUpdate, connection)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@topupdate", DateTime.Now)
                                            commandInsertTopUpdate.ExecuteNonQuery()
                                        End Using

                                        MessageBox.Show($"Payment of {selectedAmount} deducted from your balance.")


                                        If selectedAmount = 25 OrElse selectedAmount = 50 OrElse selectedAmount = 75 OrElse selectedAmount = 100 Then
                                            Dim hoursToAdd As Integer = selectedAmount / 25
                                            Dim queryInsertHourUpdate As String = "UPDATE userdata SET hour = hour + @hours WHERE userid = @userid"
                                            Using commandInsertHourUpdate As New MySqlCommand(queryInsertHourUpdate, connection)
                                                commandInsertHourUpdate.Parameters.AddWithValue("@userid", userId)
                                                commandInsertHourUpdate.Parameters.AddWithValue("@hours", hoursToAdd)
                                                commandInsertHourUpdate.ExecuteNonQuery()
                                            End Using
                                            MessageBox.Show($"Added {hoursToAdd} hours to the account.")
                                        End If

                                    Else
                                        MessageBox.Show("Payment failed. Please check your balance.")
                                    End If
                                End Using
                            Else
                                MessageBox.Show("Insufficient balance for payment.")
                            End If
                        Else
                            MessageBox.Show("Error retrieving current balance.")
                        End If
                    End Using
                Else
                    MessageBox.Show("Cannot Find User")
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub
    Public Sub student()
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Dim result As String = TopupForm.resultid.Text ' Assuming this is your source of data

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim userId As Integer = Convert.ToInt32(result)

                Dim checkUserQuery As String = "SELECT COUNT(*) FROM userdata WHERE userid = @userid"
                Dim checkUserCommand As New MySqlCommand(checkUserQuery, connection)
                checkUserCommand.Parameters.AddWithValue("@userid", userId)
                Dim userCount As Integer = Convert.ToInt32(checkUserCommand.ExecuteScalar())

                If userCount > 0 Then
                    Dim selectedAmount As Integer = Convert.ToInt32(TopupForm.TextBox1.Text)

                    Dim queryBalance As String = "SELECT balance FROM userdata WHERE username = 'admindev';"
                    Dim currentBalance As Decimal = 0

                    Using commandBalance As New MySqlCommand(queryBalance, connection)
                        Dim balanceResult As Object = commandBalance.ExecuteScalar()
                        If balanceResult IsNot Nothing AndAlso Decimal.TryParse(balanceResult.ToString(), currentBalance) Then
                            If currentBalance >= selectedAmount Then
                                Dim queryUpdateBalance As String = "UPDATE userdata SET balance = balance - @amount WHERE username = 'admindev';"

                                Using commandUpdateBalance As New MySqlCommand(queryUpdateBalance, connection)
                                    commandUpdateBalance.Parameters.AddWithValue("@amount", selectedAmount)
                                    Dim rowsAffected As Integer = commandUpdateBalance.ExecuteNonQuery()
                                    If rowsAffected > 0 Then
                                        ' Update the displayed balance label
                                        currentBalance -= selectedAmount
                                        TopupForm.bals.Text = $"${currentBalance}"

                                        Dim queryupdateuser As String = "UPDATE userdata SET balance = balance + @amount WHERE userid = @userid"
                                        Using commandInsertTopUpdate As New MySqlCommand(queryupdateuser, connection)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
                                            commandInsertTopUpdate.ExecuteNonQuery()
                                        End Using

                                        ' Insert into topupdate table
                                        Dim queryInsertTopUpdate As String = "INSERT INTO topupdate (userid, amount, topupdate) VALUES (@userid, @amount, @topupdate);"
                                        Using commandInsertTopUpdate As New MySqlCommand(queryInsertTopUpdate, connection)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@userid", userId)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@amount", selectedAmount)
                                            commandInsertTopUpdate.Parameters.AddWithValue("@topupdate", DateTime.Now)
                                            commandInsertTopUpdate.ExecuteNonQuery()
                                        End Using

                                        MessageBox.Show($"Payment of {selectedAmount} deducted from your balance.")


                                        If selectedAmount = 20 OrElse selectedAmount = 40 OrElse selectedAmount = 60 OrElse selectedAmount = 80 Then
                                            Dim hoursToAdd As Integer = selectedAmount / 20
                                            Dim queryInsertHourUpdate As String = "UPDATE userdata SET hour = hour + @hours WHERE userid = @userid"
                                            Using commandInsertHourUpdate As New MySqlCommand(queryInsertHourUpdate, connection)
                                                commandInsertHourUpdate.Parameters.AddWithValue("@userid", userId)
                                                commandInsertHourUpdate.Parameters.AddWithValue("@hours", hoursToAdd)
                                                commandInsertHourUpdate.ExecuteNonQuery()
                                            End Using
                                            MessageBox.Show($"Added {hoursToAdd} hours to the account.")
                                        End If

                                    Else
                                        MessageBox.Show("Payment failed. Please check your balance.")
                                    End If
                                End Using
                            Else
                                MessageBox.Show("Insufficient balance for payment.")
                            End If
                        Else
                            MessageBox.Show("Error retrieving current balance.")
                        End If
                    End Using
                Else
                    MessageBox.Show("Cannot Find User")
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try

    End Sub
    Public Sub data()
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Dim query As String = $"SELECT username, balance,usertype FROM userdata WHERE userid = @userId;"
        Dim userId As String = TopupForm.resultid.Text

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim username As String = reader("username").ToString()
                        Dim balance As String = reader("balance").ToString()
                        Dim usertype As String = reader("usertype").ToString()

                        TopupForm.username.Text = $"Username: {username}"
                        TopupForm.balance.Text = $"Balance: {balance}"
                        TopupForm.usertype.Text = $"Usertype: {usertype}"
                    Else
                        ' Handle the case where the user ID is not found
                        TopupForm.username.Text = "User not found"
                        TopupForm.balance.Text = ""
                        TopupForm.usertype.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub topupprice()
        ' Prompt the user for the userId using an InputBox

        ' Prompt the user for the userId using an InputBox
        Dim inputUserId As String = InputBox("Enter your user ID (or press Cancel to exit):")
        Dim userId As Integer

        If inputUserId = 1 Then
            MsgBox("Invalid, Usertype is Admin")
        End If
        If String.IsNullOrEmpty(inputUserId) Then
            ' Exit the method if the user cancels the InputBox
            Return
        End If

        If Integer.TryParse(inputUserId, userId) Then
            ' Code to execute if userId is successfully parsed from the input
            TopupForm.resultid.Text = userId
            Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

                Dim userType As String = ""
                Using commandUserType As New MySqlCommand(queryUserType, connection)
                    Dim result As Object = commandUserType.ExecuteScalar()
                    If result IsNot Nothing Then
                        userType = result.ToString()

                        If userType = "member" Then
                            data()
                            Dim queryPrices As String = $"SELECT memberprice.hoursid, memberprice.hoursprice FROM memberprice "

                            Using commandPrices As New MySqlCommand(queryPrices, connection)
                                Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                    Dim buttons As Button() = {TopupForm.first, TopupForm.second, TopupForm.third, TopupForm.fourth}
                                    Dim buttonIndex As Integer = 0
                                    While reader.Read() AndAlso buttonIndex < buttons.Length
                                        Dim price As Integer = (reader("hoursprice"))

                                        ' Set the text of the current button to display the retrieved data
                                        buttons(buttonIndex).Text = price
                                        buttonIndex += 1
                                    End While
                                End Using
                            End Using
                        ElseIf userType = "student" Then
                            data()
                            Dim queryPrices As String = $"SELECT studentprice.hoursid, studentprice.price FROM studentprice "

                            Using commandPrices As New MySqlCommand(queryPrices, connection)
                                Using reader As MySqlDataReader = commandPrices.ExecuteReader()
                                    Dim buttons As Button() = {TopupForm.first, TopupForm.second, TopupForm.third, TopupForm.fourth}
                                    Dim buttonIndex As Integer = 0
                                    While reader.Read() AndAlso buttonIndex < buttons.Length
                                        Dim price As Integer = (reader("price"))

                                        ' Set the text of the current button to display the retrieved data
                                        buttons(buttonIndex).Text = price
                                        buttonIndex += 1
                                    End While
                                End Using
                            End Using
                        End If
                    Else
                        ' Handle the case where no user type is found for the provided userId
                        MessageBox.Show("User not found.")
                    End If
                End Using
            End Using

        Else
            ' Code to execute if parsing userId from input fails or is not an integer
            MessageBox.Show("Invalid user ID entered.")
        End If




        '    Dim userId As Integer

        '    If Integer.TryParse(MainForm.id.Text, userId) Then

        '    ElseIf Integer.TryParse(adminForm.id.Text, userId) Then

        '    Else

        '    End If

        '    Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

        '    Using connection As New MySqlConnection(connectionString)
        '        connection.Open()

        '        Dim queryUserType As String = $"SELECT usertype FROM userdata WHERE userid = {userId};"

        '        Dim userType As String = ""
        '        Using commandUserType As New MySqlCommand(queryUserType, connection)
        '            Dim result As Object = commandUserType.ExecuteScalar()
        '            If result IsNot Nothing Then
        '                userType = result.ToString()
        '            End If
        '        End Using


        '        Dim queryPrices As String = $"SELECT memberprice.hoursid, memberprice.hoursprice FROM memberprice "

        '        Using commandPrices As New MySqlCommand(queryPrices, connection)
        '            Using reader As MySqlDataReader = commandPrices.ExecuteReader()
        '                Dim buttons As Button() = {TopupForm.first, TopupForm.second, TopupForm.third, TopupForm.fourth}
        '                Dim buttonIndex As Integer = 0
        '                While reader.Read() AndAlso buttonIndex < buttons.Length
        '                    Dim price As Integer = (reader("hoursprice"))

        '                    ' Set the text of the current button to display the retrieved data
        '                    buttons(buttonIndex).Text = price
        '                    buttonIndex += 1
        '                End While
        '            End Using
        '        End Using
        '    End Using
    End Sub


    Public Sub reader1()
        Dim connectionStr As String = "Data Source=localhost;database=techhive;username=root;password=" ' Replace with your MySQL connection string

        Using connection As New MySqlConnection(connectionStr)
            connection.Open()
            Dim query As String = "SELECT seatid, status FROM seats"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim seatID As Integer = reader.GetInt32("seatid")
                        Dim status As String = reader.GetString("status")
                        Dim buttonName As String = "com" & seatID
                        Dim labelName As String = "stat" & seatID
                        Dim button As Button = TryCast(SeatsForm.Controls.Find(buttonName, True).FirstOrDefault(), Button)
                        Dim label As Label = TryCast(SeatsForm.Controls.Find(labelName, True).FirstOrDefault(), Label)
                        If button IsNot Nothing Then
                            SetButtonStatus(button, status)
                            label.Text = status
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub SetButtonStatus1(button As Button, status As String)
        Select Case status
            Case "vacant"
                button.BackgroundImage = My.Resources.wh
                button.Enabled = False
            Case "in use"
                button.BackgroundImage = My.Resources.gr
                button.Enabled = False
            Case "reserved"
                button.BackgroundImage = My.Resources.re
                button.Enabled = False
            Case "maintenance"
                button.BackgroundImage = My.Resources._or
                button.Enabled = False
        End Select
    End Sub

    Public Sub reader()
        Dim connectionStr As String = "Data Source=localhost;database=techhive;username=root;password=" ' Replace with your MySQL connection string

        Using connection As New MySqlConnection(connectionStr)
            connection.Open()
            Dim query As String = "SELECT seatid, status FROM seats"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim seatID As Integer = reader.GetInt32("seatid")
                        Dim status As String = reader.GetString("status")
                        Dim buttonName As String = "com" & seatID
                        Dim labelName As String = "stat" & seatID
                        Dim button As Button = TryCast(SeatsForm.Controls.Find(buttonName, True).FirstOrDefault(), Button)
                        Dim label As Label = TryCast(SeatsForm.Controls.Find(labelName, True).FirstOrDefault(), Label)
                        If button IsNot Nothing Then
                            SetButtonStatus(button, status)
                            label.Text = status
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub DisplayUpdatedHour()
        Dim userid As String = MainForm.id.Text
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim selectQuery As String = "SELECT hour FROM userdata WHERE userid = @userid"

                Using command As New MySqlCommand(selectQuery, conn)
                    command.Parameters.AddWithValue("@userid", userid)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim updatedTime As String = reader("hour")
                            SessionLogForm.bal.Text = updatedTime ' Assign the retrieved hour to the label
                        Else
                            MessageBox.Show("User data not found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub SetButtonStatus(button As Button, status As String)
        Select Case status
            Case "vacant"
                button.BackgroundImage = My.Resources.wh
                button.Enabled = True
            Case "in use"
                button.BackgroundImage = My.Resources.gr
                button.Enabled = True
            Case "reserved"
                button.BackgroundImage = My.Resources.re
                button.Enabled = True
            Case "maintenance"
                button.BackgroundImage = My.Resources._or
                button.Enabled = True
        End Select
    End Sub



    Public Sub status()
        Dim connectionStr As String = "Data Source=localhost;database=techhive;username=root;password=" ' Replace with your MySQL connection string

        Using connection As New MySqlConnection(connectionStr)
            connection.Open()
            For i As Integer = 1 To 25
                Dim query As String = "SELECT status FROM seats WHERE seatid = @SeatID"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SeatID", i)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim status As String = reader.GetString("status")
                            Dim labelName As String = "stat" & i
                            Dim label As Label = TryCast(SeatsForm.Controls.Find(labelName, True).FirstOrDefault(), Label)
                            If label IsNot Nothing Then
                                label.Text = "Status " & i & ": " & status
                            End If
                        End If
                    End Using
                End Using
            Next i
        End Using

    End Sub


    Public Sub dashboard()
        Dim userid As String = MainForm.id.Text
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        conn.Open()
        Dim cmd As New MySqlCommand("Select * from userdata WHERE userid = @userid", conn)
        cmd.Parameters.AddWithValue("@userid", userid)

        Dim reader As MySqlDataReader = cmd.ExecuteReader

        If reader.HasRows Then
            While reader.Read

                DashboardForm.bal.Text = "Your Hour Balance is: " & reader("hour")
                SessionLogForm.bal.Text = reader("hour")
            End While
        End If
    End Sub
    Public Sub topupbalance()
        Dim username As String = Login.username.Text

        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim queryBalance As String = $"SELECT balance FROM userdata WHERE username = @username;"
            Dim currentBalance As Decimal = 0

            Using commandBalance As New MySqlCommand(queryBalance, connection)
                commandBalance.Parameters.AddWithValue("@username", username)
                Dim balanceResult As Object = commandBalance.ExecuteScalar()

                If balanceResult IsNot Nothing AndAlso Decimal.TryParse(balanceResult.ToString(), currentBalance) Then
                    TopupForm.bals.Text = $"${currentBalance}"
                Else

                End If
            End Using
        End Using
    End Sub

    Public Sub LoadUsers()
        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password=   "
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            Dim query As String = "SELECT userid, usertype FROM userdata WHERE userid = @userid"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("userid", MainForm.id.Text)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim userID As Integer = reader.GetInt32("userid")
                    Dim userType As String = reader.GetString("usertype")

                    If userType = "student" Then
                        ' Perform actions for student users
                        ProcessStudent(userID)
                    ElseIf userType = "member" Then
                        ' Perform actions for member users
                        ProcessMember(userID)
                    End If
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try


    End Sub

    Public Sub ProcessStudent(userID As Integer)
        Dim primaryKey1 As Integer() = {1}
        Dim primaryKey2 As Integer() = {2}
        Dim primarykey3 As Integer() = {3}
        Dim primarykey4 As Integer() = {4}
        Dim primarykey5 As Integer() = {5}
        Dim primarykey6 As Integer() = {6}
        Dim primarykey7 As Integer() = {7}
        Dim primarykey8 As Integer() = {8}
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        conn.Open()


        For Each primaryKeyValue1 As Integer In primaryKey1
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue1)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")


                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item1.Text = "Stocks: " + stocksValue
                                OrdersForm.price1.Text = "Price: " + priceValue
                                OrdersForm.foodname1.Text = foodname

                            Else

                            End If

                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue2 As Integer In primaryKey2
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue2)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item2.Text = "Stocks: " + stocksValue
                                OrdersForm.price2.Text = "Price: " + priceValue
                                OrdersForm.foodname2.Text = foodname

                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue3 As Integer In primarykey3
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue3)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item3.Text = "Stocks: " + stocksValue
                                OrdersForm.price3.Text = "Price: " + priceValue
                                OrdersForm.foodname3.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue4 As Integer In primarykey4
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue4)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")
                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item4.Text = "Stocks: " + stocksValue
                                OrdersForm.price4.Text = "Price: " + priceValue
                                OrdersForm.foodname4.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next


        For Each primaryKeyValue5 As Integer In primarykey5
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue5)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item5.Text = "Stocks: " + stocksValue
                                OrdersForm.price5.Text = "Price: " + priceValue
                                OrdersForm.foodname4.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue6 As Integer In primarykey6
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue6)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item6.Text = "Stocks: " + stocksValue
                                OrdersForm.price6.Text = "Price: " + priceValue
                                OrdersForm.foodname6.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue7 As Integer In primarykey7
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue7)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")
                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item7.Text = "Stocks: " + stocksValue
                                OrdersForm.price7.Text = "Price: " + priceValue
                                OrdersForm.foodname7.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue8 As Integer In primarykey8
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue8)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("discountprice").ToString()
                            Dim foodname As String = reader("foodname")
                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item8.Text = "Stocks: " + stocksValue
                                OrdersForm.price8.Text = "Price: " + priceValue
                                OrdersForm.foodname8.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

    End Sub
    Public Sub ProcessMember(userID As Integer)
        Dim primaryKey1 As Integer() = {1}
        Dim primaryKey2 As Integer() = {2}
        Dim primarykey3 As Integer() = {3}
        Dim primarykey4 As Integer() = {4}
        Dim primarykey5 As Integer() = {5}
        Dim primarykey6 As Integer() = {6}
        Dim primarykey7 As Integer() = {7}
        Dim primarykey8 As Integer() = {8}
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        conn.Open()


        For Each primaryKeyValue1 As Integer In primaryKey1
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue1)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim foodname As String = reader("foodname").ToString
                            Dim priceValue As String = reader("foodprice").ToString()



                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item1.Text = "Stocks: " + stocksValue
                                OrdersForm.price1.Text = "Price: " + priceValue
                                OrdersForm.foodname1.Text = foodname

                            Else

                            End If

                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue2 As Integer In primaryKey2
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue2)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item2.Text = "Stocks: " + stocksValue
                                OrdersForm.price2.Text = "Price: " + priceValue
                                OrdersForm.foodname2.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue3 As Integer In primarykey3
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue3)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname").ToString

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item3.Text = "Stocks: " + stocksValue
                                OrdersForm.price3.Text = "Price: " + priceValue
                                OrdersForm.foodname3.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue4 As Integer In primarykey4
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue4)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item4.Text = "Stocks: " + stocksValue
                                OrdersForm.price4.Text = "Price: " + priceValue
                                OrdersForm.foodname4.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next


        For Each primaryKeyValue5 As Integer In primarykey5
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue5)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item5.Text = "Stocks: " + stocksValue
                                OrdersForm.price5.Text = "Price: " + priceValue
                                OrdersForm.foodname5.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue6 As Integer In primarykey6
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue6)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item6.Text = "Stocks: " + stocksValue
                                OrdersForm.price6.Text = "Price: " + priceValue
                                OrdersForm.foodname6.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue7 As Integer In primarykey7
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue7)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item7.Text = "Stocks: " + stocksValue
                                OrdersForm.price7.Text = "Price: " + priceValue
                                OrdersForm.foodname7.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

        For Each primaryKeyValue8 As Integer In primarykey8
            Dim query As String = "SELECT * FROM foodstocks WHERE foodid = @PrimaryKeyValue"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue8)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read
                            Dim stocksValue As String = reader("stocks").ToString()
                            Dim priceValue As String = reader("foodprice").ToString()
                            Dim foodname As String = reader("foodname")

                            Dim stocksDouble As Double
                            If Double.TryParse(stocksValue, stocksDouble) Then
                                OrdersForm.item8.Text = "Stocks: " + stocksValue
                                OrdersForm.price8.Text = "Price: " + priceValue
                                OrdersForm.foodname8.Text = foodname
                            Else

                                MessageBox.Show("Invalid Stocks value: " & stocksValue)
                            End If
                        End While
                    End If

                End Using
            End Using
        Next

    End Sub

    Public Sub logs()
        Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        conn.Open()

        Dim cmd As New MySqlCommand("SELECT * FROM userdata WHERE username = @username AND password = @password", conn)
        cmd.Parameters.AddWithValue("@username", Login.username.Text)
        cmd.Parameters.AddWithValue("@password", Login.password.Text)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Try
                Dim usertype As String = reader("usertype").ToString()

                Select Case usertype
                    Case "admin"
                        MsgBox("Admin Login Successfully")
                        adminForm.Show()
                        Login.Hide()
                        adminForm.user.Text = "Welcome " & reader("username") & "!"
                        adminForm.id.Text = reader("userid")

                    Case "member"
                        MsgBox("Member Login Successfully")
                        MainForm.Show()
                        Login.Hide()
                        MainForm.go(DashboardForm)
                        MainForm.user.Text = "Welcome " & reader("username") & "!"
                        MainForm.id.Text = reader("userid")
                        LoadUsers()

                    Case "student"
                        MsgBox("Student Login Successfully")
                        MainForm.Show()
                        Login.Hide()
                        MainForm.go(DashboardForm)
                        MainForm.id.Text = reader("userid")
                        MainForm.user.Text = "Welcome " & reader("username") & "!"
                        LoadUsers()

                    Case Else
                        MsgBox("Guest Login Successfully")
                        GuestForm.Show()
                        Login.Hide()
                        MainForm.go(DashboardForm)
                        MainForm.user.Text = "Welcome Guest!"

                End Select
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox("Invalid username or password")
        End If

        conn.Close()

    End Sub

























End Module