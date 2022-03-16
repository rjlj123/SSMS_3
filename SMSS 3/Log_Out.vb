Public Class Log_Out

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserID = ""
        Me.Hide()
        Login.Show()      'logs the user out
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() 'closes the form
    End Sub
End Class