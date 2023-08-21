Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCpanel(Panel1)
        RCpanel(Panel2)

        RCbtn(lobtn)
        RCbtn(slbtn)
        RC(Me)
    End Sub

    Public Sub go(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub lobtn_Click(sender As Object, e As EventArgs) Handles lobtn.Click
        Login.username.Clear()
        Login.password.Clear()
        Me.Hide()
        Timer.Close()
        Login.Show()
    End Sub

    Private Sub slbtn_Click(sender As Object, e As EventArgs) Handles slbtn.Click
        go(SessionLogForm)
    End Sub

End Class