Imports System.Windows
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataFormats
Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.UseSystemPasswordChar = False

        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        logs()
        dashboard()
        topupbalance()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RC(Me)

        RCspnl(Panel3)
        RCspnl(Panel2)

        RCbtn(Button1)

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GuestForm.Show()
        Me.Hide()

    End Sub
End Class
