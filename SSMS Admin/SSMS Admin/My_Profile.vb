Public Class My_Profile
    Dim SRowcount As Integer
    Dim DRowcount As Integer
    Dim flag As Boolean
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
        Me.Show()
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

    Private Sub Manage_Staff_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the department table of the database 
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the staff table of the database 
        Lbl_UserID.Text = UserID
        UserNme.Text = UserID

        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1) 'fills the department combobox with the databases departments
            Me.Department.Items.Add(Dep)
        Next i

        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For i = 0 To SRowcount
            If SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) = UserID Then
                FirstName.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(2)
                Surname.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(3)
                Department.SelectedItem = SSMS_DATABASEDataSet.Staff.Rows(i).Item(4)            'fills the form with the user's information
                PassWrd.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(6)
            End If
        Next i
    End Sub

    Private Sub EdtDet_Click(sender As Object, e As EventArgs) Handles EdtDet.Click
        Dim NewPass As String

        'validation starts

        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1
        flag = True
        If PassWrd.Text <> RePassWrd.Text Then
            flag = False
            MsgBox("Passwords do not match.")
        End If

        If FirstName.Text.Length > 25 Then
            MsgBox("First name is too long.")
            flag = False
        End If

        If Surname.Text.Length > 25 Then                        'ensures that all data entered is valid
            MsgBox("Surname is too long.")
            flag = False
        End If

        If Department.SelectedItem = Nothing Then
            flag = False
            MsgBox("Please select a department")
        End If

        'validation ends

        If flag = True Then
            For i = 0 To SRowcount
                If SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) = UserID Then
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item(2) = FirstName.Text
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) = Surname.Text
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item(6) = Department.SelectedItem        'saves the new user inputted data to the database
                    NewPass = PassWrd.Text
                    SSMS_DATABASEDataSet.Staff.Rows(i).Item(6) = NewPass
                    Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
                End If
            Next i
        End If
    End Sub
End Class