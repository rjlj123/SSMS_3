Public Class Spl_Scr
    Private Sub Spl_Scr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()      'starts the timer
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Load_2.Width += 55
        If Load_2.Width >= 446 Then
            Login.Show()
            Me.Hide()       'displays the login form upon timer completion
            Timer1.Stop()
        End If
    End Sub

End Class