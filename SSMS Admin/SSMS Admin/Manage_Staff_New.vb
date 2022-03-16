Public Class Manage_Staff_New
    Dim SRowcount As Integer
    Dim DRowcount As Integer
    Dim Flag As Boolean = True
    Dim Dep As String

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

    Private Sub Manage_Staff_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the Department table of the database
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the Staff table of the database
        Lbl_UserID.Text = UserID

        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1)       'fills the department combobox with the system's departments
            Me.Department.Items.Add(Dep)
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewStaffRow As DataRow = SSMS_DATABASEDataSet.Staff.NewRow

        SRowcount = SSMS_DATABASEDataSet.Staff.Rows.Count - 1
        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        'validation starts
        Flag = True

        Dim a As Control
        Dim TxtFlag As Boolean = True
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                If TxtFlag = True Then
                    If a.Text = "" Then
                        MsgBox("Please ensure that all textboxes contain text.")
                        TxtFlag = False
                    End If
                End If
            End If
        Next a
        If TxtFlag = False Then Flag = False

        For i = 0 To SRowcount
            If UserNme.Text = SSMS_DATABASEDataSet.Staff.Rows(i).Item(5) Then
                Flag = False
            End If
        Next i

        If RePassWrd.Text <> PassWrd.Text Then
            MsgBox("Passwords do not match.")
            Flag = False
        End If

        If FirstName.Text.Length > 25 Then                                                              'this code validates all data entered onto the form to ensure that all data kept is valid
            MsgBox("First name is too long.")
        End If

        If Surname.Text.Length > 25 Then
            MsgBox("Surname is too long.")
        End If

        If PassWrd.Text.Length < 5 Then
            Flag = False
            MsgBox("Password must be between 5 and 20 characters.")
        End If

        If PasswordLabel.Text.Length > 20 Then
            Flag = False
            MsgBox("Password must be between 5 and 20 characters.")
        End If

        If Flag = False Then
            MsgBox("Username already exists. Please enter a different username.")
        End If
        'validation ends

        If Flag = True Then
            NewStaffRow("Forename") = FirstName.Text
            NewStaffRow("Surname") = Surname.Text
            NewStaffRow("Department") = Department.SelectedItem
            NewStaffRow("Username") = UserNme.Text
            NewStaffRow("Password") = PassWrd.Text
            NewStaffRow("Password_Request?") = "N"
            If CheckBox1.CheckState = CheckState.Checked Then
                NewStaffRow("Manager?") = "Y"
            Else
                NewStaffRow("Manager?") = "N"                                                                       'this adds the new staff member to the dataset
            End If
            For i = 0 To DRowcount
                If SSMS_DATABASEDataSet.Department.Rows(i).Item(1) = Department.SelectedItem Then
                    NewStaffRow("DepartmentID") = SSMS_DATABASEDataSet.Department.Rows(i).Item(0)
                End If
            Next i
            SSMS_DATABASEDataSet.Staff.Rows.Add(NewStaffRow)
            MsgBox("Staff Member Added.")
            Me.StaffTableAdapter.Update(SSMS_DATABASEDataSet)
        End If

    End Sub
End Class