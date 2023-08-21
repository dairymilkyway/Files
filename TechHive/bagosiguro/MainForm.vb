Imports System.Windows
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataFormats
Public Class MainForm
    Public Property username As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RC(Me)

        RCpanel(Panel1)
        RCpanel(Panel2)

        RCbtn(dbbtn)

        RCbtn(otbn)
        RCbtn(lobtn)
        RCbtn(asbtn)
        RCbtn(slbtn)
        dashboard()
    End Sub

    Private Sub lobtn_Click(sender As Object, e As EventArgs) Handles lobtn.Click
        Login.username.Clear()
        Login.password.Clear()
        reader()
        status()
        LoadUsers()
        Me.Hide()
        Timer.Close()
        Login.Show()

    End Sub

    Public Sub go(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub dbbtn_Click(sender As Object, e As EventArgs) Handles dbbtn.Click
        go(DashboardForm)
    End Sub

    Private Sub otbn_Click(sender As Object, e As EventArgs) Handles otbn.Click
        go(OrdersForm)
    End Sub

    Private Sub tpbtn_Click(sender As Object, e As EventArgs)
        go(TopupForm)
    End Sub

    Private Sub sbtn_Click(sender As Object, e As EventArgs)
        go(SeatsForm)
    End Sub

    Private Sub slbtn_Click(sender As Object, e As EventArgs) Handles slbtn.Click
        go(SessionLogForm)
    End Sub

    Private Sub asbtn_Click(sender As Object, e As EventArgs) Handles asbtn.Click
        go(AccountSettingsForm)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class