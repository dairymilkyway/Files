Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class SeatsForm
    Public id As Integer = 0
    Private Sub SeatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Data Source=localhost;database=techhive;username=root;password="
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Retrieve the user's usertype from the database
            Dim username As String = Login.username.Text ' Replace with actual username
            Dim selectQuery As String = "SELECT usertype FROM userdata WHERE username = @username"
            Using command As New MySqlCommand(selectQuery, connection)
                command.Parameters.AddWithValue("@username", username)
                Dim userType As String = CStr(command.ExecuteScalar())

                ' Determine if the button on the specific form should be locked
                If userType = "admin" OrElse userType = "guest" Then
                    reader()
                    status()
                ElseIf userType = "student" OrElse userType = "member" Then
                    reader1()
                    status()
                    com1.Enabled = False
                    com2.Enabled = False
                    com3.Enabled = False
                    com4.Enabled = False
                    com5.Enabled = False
                    com7.Enabled = False
                    com8.Enabled = False
                    com9.Enabled = False
                    com10.Enabled = False
                    com11.Enabled = False
                    com12.Enabled = False
                    com13.Enabled = False
                    com14.Enabled = False
                    com15.Enabled = False
                    com16.Enabled = False
                    com17.Enabled = False
                    com18.Enabled = False
                    com19.Enabled = False
                    com20.Enabled = False
                    com21.Enabled = False
                    com22.Enabled = False
                    com23.Enabled = False
                    com24.Enabled = False
                    com25.Enabled = False
                End If
            End Using
        End Using


        RCspnl(Panel1)
        RCspnl(Panel2)

        RCbtn(com21)
        RCbtn(com22)
        RCbtn(com23)
        RCbtn(com24)
        RCbtn(com25)
        RCbtn(com16)
        RCbtn(com17)
        RCbtn(com18)
        RCbtn(com19)
        RCbtn(com20)
        RCbtn(com15)
        RCbtn(com14)
        RCbtn(com13)
        RCbtn(com12)
        RCbtn(com11)
        RCbtn(com6)
        RCbtn(com7)
        RCbtn(com8)
        RCbtn(com9)
        RCbtn(com10)
        RCbtn(com5)
        RCbtn(com4)
        RCbtn(com3)
        RCbtn(com2)
        RCbtn(com1)
    End Sub

    Private Sub com1_Click(sender As Object, e As EventArgs) Handles com1.Click
        Form1.Show()
        id = 1
    End Sub

    Private Sub com2_Click(sender As Object, e As EventArgs) Handles com2.Click
        Form1.Show()
        id = 2
    End Sub

    Private Sub com3_Click(sender As Object, e As EventArgs) Handles com3.Click
        Form1.Show()
        id = 3
    End Sub

    Private Sub com4_Click(sender As Object, e As EventArgs) Handles com4.Click
        Form1.Show()
        id = 4
    End Sub

    Private Sub com5_Click(sender As Object, e As EventArgs) Handles com5.Click
        Form1.Show()
        id = 5
    End Sub

    Private Sub com6_Click(sender As Object, e As EventArgs) Handles com6.Click
        Form1.Show()
        id = 6
    End Sub

    Private Sub com7_Click(sender As Object, e As EventArgs) Handles com7.Click
        Form1.Show()
        id = 7
    End Sub

    Private Sub com8_Click(sender As Object, e As EventArgs) Handles com8.Click

        Form1.Show()
        id = 8
    End Sub

    Private Sub com9_Click(sender As Object, e As EventArgs) Handles com9.Click
        Form1.Show()
        id = 9
    End Sub

    Private Sub com10_Click(sender As Object, e As EventArgs) Handles com10.Click
        Form1.Show()
        id = 10
    End Sub

    Private Sub com15_Click(sender As Object, e As EventArgs) Handles com15.Click
        Form1.Show()
        id = 15
    End Sub

    Private Sub com14_Click(sender As Object, e As EventArgs) Handles com14.Click
        Form1.Show()
        id = 14
    End Sub

    Private Sub com13_Click(sender As Object, e As EventArgs) Handles com13.Click
        Form1.Show()
        id = 13
    End Sub

    Private Sub com12_Click(sender As Object, e As EventArgs) Handles com12.Click
        Form1.Show()
        id = 12
    End Sub

    Private Sub com11_Click(sender As Object, e As EventArgs) Handles com11.Click
        Form1.Show()
        id = 11
    End Sub

    Private Sub com16_Click(sender As Object, e As EventArgs) Handles com16.Click
        Form1.Show()
        id = 16
    End Sub

    Private Sub com17_Click(sender As Object, e As EventArgs) Handles com17.Click
        Form1.Show()
        id = 17
    End Sub

    Private Sub com18_Click(sender As Object, e As EventArgs) Handles com18.Click
        Form1.Show()
        id = 18
    End Sub

    Private Sub com19_Click(sender As Object, e As EventArgs) Handles com19.Click
        Form1.Show()
        id = 19
    End Sub

    Private Sub com20_Click(sender As Object, e As EventArgs) Handles com20.Click
        Form1.Show()
        id = 20
    End Sub

    Private Sub com21_Click(sender As Object, e As EventArgs) Handles com21.Click
        Form1.Show()
        id = 21
    End Sub

    Private Sub com22_Click(sender As Object, e As EventArgs) Handles com22.Click
        Form1.Show()
        id = 22
    End Sub

    Private Sub com23_Click(sender As Object, e As EventArgs) Handles com23.Click
        Form1.Show()
        id = 23

    End Sub

    Private Sub com24_Click(sender As Object, e As EventArgs) Handles com24.Click
        Form1.Show()
        id = 24
    End Sub

    Private Sub com25_Click(sender As Object, e As EventArgs) Handles com25.Click
        Form1.Show()
        id = 25
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class











