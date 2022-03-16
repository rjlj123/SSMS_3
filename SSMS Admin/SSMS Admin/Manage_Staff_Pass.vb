Public Class Manage_Staff_Pass
    Dim SRowcount As Integer

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        LastForm = Me
        Me.Hide()
        Main_Menu.Show()
    End Sub
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        LastForm.Show()
    End Sub
    Private Sub Btn_Ref_Click(sender As Object, e As EventArgs) Handles Btn_Ref.Click
        Me.Refresh()
    End Sub
    Private Sub Btn_Pro_Click(sender As Object, e As EventArgs) Handles Btn_Pro.Click
        LastForm = Me
        Me.Hide()
        My_Profile.Show()
    End Sub
    Private Sub Btn_Log_Click(sender As Object, e As EventArgs) Handles Btn_Log.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub Btn_Staff_Click(sender As Object, e As EventArgs) Handles Btn_Staff.Click
        LastForm = Me
        Me.Hide()
        Manage_Staff.Show()
    End Sub

    Private Sub Btn_SIA_Click(sender As Object, e As EventArgs) Handles Btn_SIA.Click
        LastForm = Me
        Me.Hide()
        Manage_SIA.Show()
    End Sub

    Private Sub Btn_Stk_Click(sender As Object, e As EventArgs) Handles Btn_Stk.Click
        LastForm = Me
        Me.Hide()
        Manage_Stock.show()
    End Sub

    Private Sub Btn_Shp_Click(sender As Object, e As EventArgs) Handles Btn_Shp.Click
        LastForm = Me
        Me.Hide()
        Shop_Floor.show()
    End Sub

    Private Sub Btn_Data_Click(sender As Object, e As EventArgs) Handles Btn_Data.Click
        LastForm = Me
        Me.Hide()
        Sales_Data.show()
    End Sub

    Private Sub Btn_BckRm_Click(sender As Object, e As EventArgs) Handles Btn_BckRm.Click
        LastForm = Me
        Me.Hide()
        Manage_Backroom.show()
    End Sub

    Private Sub Manage_Staff_Pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the Staff table of the database
        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For i = 0 To SRowcount
            If SSMS_DATABASEDataSet.Staff.Rows(i).Item(7) = "Y" Then
                UserListBox.Items.Add(SSMS_DATABASEDataSet.Staff.Rows(i).Item(5)) 'fills the listbox with staff members who have requested a password reset
            End If
        Next i
    End Sub

    Private Sub RstPass_Click(sender As Object, e As EventArgs) Handles RstPass.Click
        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For j = 0 To UserListBox.Items.Count - 1
            For i = 0 To SRowcount
                If SSMS_DATABASEDataSet.Staff.Rows(i).Item("Username") = UserListBox.Items(j) Then      'Users who are flagged for a password reset, will have their password reset to P123
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item("Password") = "P123"
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item("Password_Request?") = "N"
                End If
            Next i
        Next j

        UserListBox.Items.Clear()
        MsgBox("Passwords reset to P123.")
        StaffTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For i = 0 To SRowcount
            If SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) = UserListBox.SelectedItem Then
                SSMS_DATABASEDataSet.Staff.Rows(i).Item("Password_Request?") = "N"                  'Removes a user from the listbox, and changes the database so that the password remains the same, and that they are no longer flagged for a reset
                UserListBox.Items.Remove(UserListBox.SelectedItem)
                StaffTableAdapter.Update(SSMS_DATABASEDataSet)
            End If
        Next i
    End Sub
End Class