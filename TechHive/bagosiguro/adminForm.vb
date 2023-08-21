Public Class adminForm
    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCpanel(Panel1)
        RCpanel(Panel2)


        RCbtn(tpbtn)
        RCbtn(lobtn)
        RCbtn(sbtn)
        RCbtn(asbtn)

        RC(Me)
    End Sub

    Private Sub lobtn_Click(sender As Object, e As EventArgs) Handles lobtn.Click
        Login.username.Clear()
        Login.password.Clear()
        Me.Hide()
        Login.Show()
    End Sub
    Public Sub go(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub dbbtn_Click(sender As Object, e As EventArgs)
        go(DashboardForm)
    End Sub

    Private Sub sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        go(SeatsForm)
    End Sub

    Private Sub tpbtn_Click(sender As Object, e As EventArgs) Handles tpbtn.Click
        go(TopupForm)
        topupprice()
        TopupForm.TextBox1.Clear()
    End Sub

    Private Sub slbtn_Click(sender As Object, e As EventArgs)
        go(SessionLogForm)

    End Sub

    Private Sub otbn_Click(sender As Object, e As EventArgs)
        go(OrdersForm)
    End Sub

    Private Sub asbtn_Click(sender As Object, e As EventArgs) Handles asbtn.Click
        go(AdminAccountSettings)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDG.Show()
        Me.Hide()
    End Sub
End Class