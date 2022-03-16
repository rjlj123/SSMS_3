Public Class Manage_Staff_View
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

    Private Sub Manage_Staff_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the Department table of the database
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the Staff table of the database
        Lbl_UserID.Text = UserID

        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1)       'fills the department combobox with the system's departments
            Me.Department.Items.Add(Dep)
        Next i
    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        DRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For i = 0 To DRowcount
            If UserNme.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) Then
                flag = True
            End If
            If flag = True Then
                FirstName.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(2)
                Surname.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(3)
                Department.SelectedItem = SSMS_DATABASEDataSet.Staff.Rows(i).Item(4)        'searches the staff dataset for the user specified username
                PassWrd.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(6)
                If SSMS_DATABASEDataSet.Staff.Rows(i).Item(8) = "Y" Then
                    MngChk.CheckState = CheckState.Checked
                End If
            End If
            If flag = False Then
                MsgBox("Username not found.")
            End If
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewStaffRow As DataRow = SSMS_DATABASEDataSet.Staff.NewRow

        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1
        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        'validation starts
        flag = True

        If PassWrd.Text <> RePassWrd.Text Then
            flag = False
            MsgBox("Passwords do not match.")
        End If

        If FirstName.Text.Length > 25 Then
            MsgBox("First name is too long.")
            flag = False                                                'ensures that all data submitted is validated
        End If

        If Surname.Text.Length > 25 Then
            MsgBox("Surname is too long.")
            flag = False
        End If

        If Department.SelectedItem = Nothing Then
            flag = False
            MsgBox("Please select a department")
        End If
        'validation ends

        If flag = True Then
            NewStaffRow("Forename") = FirstName.Text
            NewStaffRow("Surname") = Surname.Text
            NewStaffRow("Department") = Department.SelectedItem
            NewStaffRow("Username") = UserNme.Text
            NewStaffRow("Password") = PassWrd.Text
            NewStaffRow("Password_Request?") = "N"
            If MngChk.CheckState = CheckState.Checked Then
                NewStaffRow("Manager?") = "Y"
            Else
                NewStaffRow("Manager?") = "N"
            End If
            For i = 0 To DRowcount
                If SSMS_DATABASEDataSet.Department.Rows(i).Item(1) = Department.SelectedItem Then       'Changes the data kept about the staff to the new user specified data
                    NewStaffRow("DepartmentID") = SSMS_DATABASEDataSet.Department.Rows(i).Item(0)
                End If
            Next i
            SSMS_DATABASEDataSet.Staff.Rows.Add(NewStaffRow)
            MsgBox("Staff Member Added.")
            Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1

        For i = 0 To SRowcount
            If UserNme.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) Then
                SSMS_DATABASEDataSet.Staff.Rows(i).Delete()                         'removes the selected staff member from the dataset
            End If
        Next i
        Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class