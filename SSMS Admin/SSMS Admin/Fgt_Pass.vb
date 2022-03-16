Public Class Fgt_Pass
    Dim rowcount As Integer
    Private Sub Fgt_Pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'Allows the algorithm to search through the Staff table of the database
    End Sub

    Private Sub Lbl_Frgt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_Frgt.LinkClicked
        Me.Hide()
        Login.Show() 'navigates the user back to the login form
    End Sub

    Private Sub Submit_Click_1(sender As Object, e As EventArgs) Handles Submit.Click

        rowcount = SSMS_DATABASEDataSet.Tables("Staff").Rows.Count - 1
        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(5) = Txt_User.Text Then        'Makes changes to the database so that the password is flagged for reset.
                SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(7) = "Y"
                MsgBox("Password reset requested.")
                Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
            End If
        Next i
    End Sub
End Class