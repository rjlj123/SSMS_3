Public Class Fgt_Pass
    Dim rowcount As Integer
    Private Sub Fgt_Pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through
        Back_Nav.Parent = Banner_Box
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Login.Show()        'navigates back to the login screen
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        rowcount = SSMS_DATABASEDataSet.Tables("Staff").Rows.Count - 1
        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item("Username") = Txt_User.Text Then
                SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item("Password_Request?") = "Y"            'marks the user for a password reset
                MsgBox("Password reset requested.")
                Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
            End If
        Next i
    End Sub

End Class