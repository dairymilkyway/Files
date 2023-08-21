Public Class FormDG
    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCpanel(Panel1)
        RCpanel(Panel2)

        RCbtn(dbbtndg)
        RCbtn(tpbtndg)
        RCbtn(otbndg)
        RCbtn(sbtndg)

        RC(Me)
    End Sub

    Private Sub lobtn_Click(sender As Object, e As EventArgs) Handles lobtn.Click

        Me.Hide()
        adminForm.Show()
    End Sub

    Public Sub go(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub dbbtndg_Click(sender As Object, e As EventArgs) Handles dbbtndg.Click
        go(adminUsersDG)
    End Sub

    Private Sub sbtndg_Click(sender As Object, e As EventArgs) Handles sbtndg.Click
        go(AdminSeatsDG)
    End Sub

    Private Sub tpbtndg_Click(sender As Object, e As EventArgs) Handles tpbtndg.Click
        go(adminTopupDG)
    End Sub

    Private Sub otbndg_Click(sender As Object, e As EventArgs) Handles otbndg.Click
        go(adminStocksDG)
    End Sub

    Private Sub Button1dg_Click(sender As Object, e As EventArgs) Handles Button1dg.Click
        go(adminordersDG)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adminForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        go(Form2)
    End Sub
End Class