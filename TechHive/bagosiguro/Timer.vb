Imports System.Reflection.Emit
Imports System.Threading

Public Class Timer

    Dim hour As Integer
    Dim minutes As Integer
    Dim seconds As Integer


    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RC(Me)
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        hour = Convert.ToInt32(Label4.Text.Substring(0, 2))
        minutes = Convert.ToInt32(Label4.Text.Substring(3, 2))
        seconds = Convert.ToInt32(Label4.Text.Substring(6, 2))

        seconds = seconds - 1
        If seconds < 0 Then
            seconds = 59
            minutes = minutes - 1
            If minutes < 0 Then
                minutes = 59
                hour = hour - 1
            End If
        End If

        Label4.Text = hour.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

        If hour = 0 And minutes = 0 And seconds = 0 Then
            Timer4.Enabled = False
            Label4.ForeColor = Color.Red
            MsgBox("Time is up!")
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        hour = Convert.ToInt32(Label2.Text.Substring(0, 2))
        minutes = Convert.ToInt32(Label2.Text.Substring(3, 2))
        seconds = Convert.ToInt32(Label2.Text.Substring(6, 2))

        seconds = seconds - 1
        If seconds < 0 Then
            seconds = 59
            minutes = minutes - 1
            If minutes < 0 Then
                minutes = 59
                hour = hour - 1
            End If
        End If

        Label2.Text = hour.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

        If hour = 0 And minutes = 0 And seconds = 0 Then
            Timer2.Enabled = False
            Label2.ForeColor = Color.Red
            MsgBox("Time is up!")
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        hour = Convert.ToInt32(Label3.Text.Substring(0, 2))
        minutes = Convert.ToInt32(Label3.Text.Substring(3, 2))
        seconds = Convert.ToInt32(Label3.Text.Substring(6, 2))

        seconds = seconds - 1
        If seconds < 0 Then
            seconds = 59
            minutes = minutes - 1
            If minutes < 0 Then
                minutes = 59
                hour = hour - 1
            End If
        End If

        Label3.Text = hour.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

        If hour = 0 And minutes = 0 And seconds = 0 Then
            Timer3.Enabled = False
            Label3.ForeColor = Color.Red
            MsgBox("Time is up!")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        hour = Convert.ToInt32(Label1.Text.Substring(0, 2))
        minutes = Convert.ToInt32(Label1.Text.Substring(3, 2))
        seconds = Convert.ToInt32(Label1.Text.Substring(6, 2))

        seconds = seconds - 1
        If seconds < 0 Then
            seconds = 59
            minutes = minutes - 1
            If minutes < 0 Then
                minutes = 59
                hour = hour - 1
            End If
        End If

        Label1.Text = hour.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

        If hour = 0 And minutes = 0 And seconds = 0 Then
            Timer1.Enabled = False
            Label1.ForeColor = Color.Red
            MsgBox("Time is up!")
        End If

    End Sub

End Class