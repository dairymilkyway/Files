Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class DashboardForm


    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RC(Me)

        RCspnl(Panel1)

        Label1.Parent = Button1

        Label2.Parent = Button2

        Label3.Parent = Button3

        'Dim conn As New MySqlConnection("Data Source=localhost;database=techhive;username=root;password=")
        'conn.Open()
        'Dim cmd As New MySqlCommand("SELECT username, balance FROM userdata where username =@username", conn)
        'cmd.Parameters.AddWithValue("username", Login.TextBox1.Text)


        'Dim reader As MySqlDataReader = cmd.ExecuteReader


        'If reader.Read Then
        '    bal.Text = "Your Balance is: $" & reader("balance")
        'End If


    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackgroundImage = My.Resources.uno

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources._1
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackgroundImage = My.Resources.dos
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.ha_
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackgroundImage = My.Resources.tres
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = My.Resources.ano2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.go(OrdersForm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainForm.go(SessionLogForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MainForm.go(OrdersForm)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class