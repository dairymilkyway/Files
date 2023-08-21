Imports System.Data.OleDb
Imports System.Drawing.Text

Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Security

Public Class OrdersForm
    Public bcv As Integer = 0
    Public fcv As Integer = 0
    Public ncv As Integer = 0
    Public chcv As Integer = 0
    Public ccv As Integer = 0
    Public jcv As Integer = 0
    Public scv As Integer = 0
    Public wcv As Integer = 0

    Public Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RC(Me)


        RCpanel(Panel1)
        RCpanel(Panel2)



        RCspnl(Panel14)
        RCspnl(Panel25)
        RCspnl(Panel26)
        RCspnl(Panel27)
        RCspnl(Panel28)
        RCspnl(Panel29)
        RCspnl(Panel30)
        RCspnl(Panel24)

        RCpanel(Panel3)
        RCpanel(Panel4)
        RCpanel(Panel5)
        RCpanel(Panel6)
        RCpanel(Panel7)
        RCpanel(Panel8)
        RCpanel(Panel9)
        RCpanel(Panel10)
        RCpanel(Panel11)

        RCbtn(first)
        RCbtn(second)
        RCbtn(fourth)
        RCbtn(third)
        RCbtn(six)
        RCbtn(fifth)
        RCbtn(eight)
        RCbtn(seven)
        RCbtn(orderbtn)

        RCspnl(Panel16)

        LoadUsers()
    End Sub


    Private connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
    Public Sub makeorder(sender As Object, e As EventArgs) Handles orderbtn.Click
        Dim allSuccessful As Boolean = True

        For Each key As String In orderlist.Keys
            Dim query = orderlist(key)

            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        LoadUsers()
                    End Using
                Catch ex As Exception
                    allSuccessful = False
                    Exit For ' Exit the loop when an error occurs
                End Try
            End Using
        Next

        If allSuccessful Then
            MessageBox.Show("All orders were successfully processed.")
        Else
            MessageBox.Show("An error occurred while processing orders.")
        End If

    End Sub

    Private Sub prodclick(sender As Object, e As EventArgs) Handles first.Click, second.Click, third.Click, fourth.Click, fifth.Click, six.Click, seven.Click, eight.Click
        Dim prodid As Integer
        Dim userid As Integer = MainForm.id.Text
        Select Case sender.Name
            Case "first"
                prodid = 1
                bcv = bcv + 1
                quantity0.Text = bcv

                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {bcv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "second"
                prodid = 2
                fcv = fcv + 1
                quantity1.Text = fcv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {fcv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "third"
                prodid = 3
                ncv = ncv + 1
                quantity2.Text = ncv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {ncv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "fourth"
                prodid = 4
                chcv = chcv + 1
                quantity3.Text = chcv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {chcv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "fifth"
                prodid = 5
                ccv = ccv + 1
                quantity4.Text = ccv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {ccv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "six"
                prodid = 6
                jcv = jcv + 1
                quantity5.Text = jcv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {jcv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "seven"
                prodid = 7
                scv = scv + 1
                quantity6.Text = scv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {scv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery

            Case "eight"
                prodid = 8
                wcv = wcv + 1
                quantity7.Text = wcv


                Dim insertQuery As String = $"INSERT INTO orders (foodid, userid, orderdate) VALUES ({prodid}, {userid}, '{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim insertQuery1 As String = $"INSERT INTO orderdate (foodid, orderdate) VALUES ({prodid},'{DateTime.Now.Date.ToString("yyyy-MM-dd")}')"
                Dim updateQuery As String = $"UPDATE foodstocks SET stocks = stocks - {wcv} WHERE foodid = {prodid}"


                orderlist(sender.Name) = insertQuery & ";" & insertQuery1 & ";" & updateQuery
        End Select
    End Sub




    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Panel13_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel13.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel13.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class