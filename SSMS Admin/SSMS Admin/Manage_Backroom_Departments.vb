Public Class Manage_Backroom_Departments
    Dim SDRowcount As Integer
    Dim DRowcount As Integer
    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        LastForm = Me
        Me.Hide()
        Me.Show()
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
        Manage_Stock.Show()
    End Sub

    Private Sub Btn_Shp_Click(sender As Object, e As EventArgs) Handles Btn_Shp.Click
        LastForm = Me
        Me.Hide()
        Shop_Floor.Show()
    End Sub

    Private Sub Btn_Data_Click(sender As Object, e As EventArgs) Handles Btn_Data.Click
        LastForm = Me
        Me.Hide()
        Sales_Data.Show()
    End Sub

    Private Sub Btn_BckRm_Click(sender As Object, e As EventArgs) Handles Btn_BckRm.Click
        LastForm = Me
        Me.Hide()
        Manage_Backroom.Show()
    End Sub


    Private Sub Manage_Backroom_Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the Sub_Department table of the database
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the Department table of the database
        Lbl_UserID.Text = UserID

        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            AddSubDepDepBox.Items.Add(SSMS_DATABASEDataSet.Department.Rows(i).Item(1))
        Next i

        For i = 0 To DRowcount
            RmvSubDepDepBox.Items.Add(SSMS_DATABASEDataSet.Department.Rows(i).Item(1)) 'adds each Department found in the database to the relevant comboboxes
        Next i

        For i = 0 To DRowcount
            RmvDepBox.Items.Add(SSMS_DATABASEDataSet.Department.Rows(i).Item(1))
        Next i
    End Sub

    Private Sub AddDep_Click(sender As Object, e As EventArgs) Handles AddDep.Click
        Dim NewDepRow As DataRow = SSMS_DATABASEDataSet.Department.NewRow
        Dim DepFlag As Boolean = True

        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1
        For i = 0 To DRowcount
            If SSMS_DATABASEDataSet.Department.Rows(i).Item("Department") = AddDepBox.Text Then 'validation that ensures that departments aren't duplicated
                DepFlag = False
                MsgBox("Department already exists.")
            End If
        Next i

        If DepFlag = True Then
            NewDepRow("Department") = AddDepBox.Text
            SSMS_DATABASEDataSet.Department.Rows.Add(NewDepRow)
            DepartmentTableAdapter.Update(SSMS_DATABASEDataSet)     'adds the specified department to the database
            MsgBox("Department added.")
            AddDepTxt.Clear()
        End If
    End Sub

    Private Sub AddDepBox_TextChanged(sender As Object, e As EventArgs) Handles AddDepBox.TextChanged
        AddDepTxt.Text = "Are you sure you want to add " & AddDepBox.Text & " as a department?" 'gives the user feedback about what department they want to add
    End Sub

    Private Sub AddSubDep_Click(sender As Object, e As EventArgs) Handles AddSubDep.Click
        Dim NewSubDepRow As DataRow = SSMS_DATABASEDataSet.Sub_Department.NewRow
        Dim SubDepFlag As Boolean = True

        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1

        For i = 0 To SDRowcount
            If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department") = AddSubDepBox.Text Then
                SubDepFlag = False
                MsgBox("Sub Department already exists.")            'validation that ensures that sub departments aren't duplicated
            End If
        Next i

        If SubDepFlag = True Then
            NewSubDepRow("Department") = AddSubDepDepBox.SelectedItem
            NewSubDepRow("Sub_Department") = AddSubDepBox.Text

            DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

            For i = 0 To DRowcount
                If AddSubDepDepBox.SelectedItem = SSMS_DATABASEDataSet.Department.Rows(i).Item(1) Then
                    NewSubDepRow("DepartmentID") = SSMS_DATABASEDataSet.Department.Rows(i).Item(0)      'adds the specified sub department to the database
                End If
            Next i

            SSMS_DATABASEDataSet.Sub_Department.Rows.Add(NewSubDepRow)
            Sub_DepartmentTableAdapter.Update(SSMS_DATABASEDataSet)
            MsgBox("Sub Department added.")
        End If
    End Sub

    Private Sub AddSubDepBox_TextChanged(sender As Object, e As EventArgs) Handles AddSubDepBox.TextChanged, AddSubDepDepBox.SelectedIndexChanged
        AddSubDepTxt.Text = "Are you sure you want To add " & AddSubDepBox.Text & " as a sub-department for " & AddSubDepDepBox.SelectedItem & "?" 'gives the user feedback about what sub department they want to add
    End Sub

    Private Sub RmvDep_Click(sender As Object, e As EventArgs) Handles RmvDep.Click
        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            If SSMS_DATABASEDataSet.Department.Rows(i).Item("Department") = RmvDepBox.SelectedItem Then     'removes the specified department from the system
                SSMS_DATABASEDataSet.Department.Rows(i).Delete()
            End If
        Next i
        DepartmentTableAdapter.Update(SSMS_DATABASEDataSet)
        MsgBox("Department deleted.")
    End Sub

    Private Sub RmvDepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RmvDepBox.SelectedIndexChanged
        RmvDepTxt.Text = "Are you sure you want to remove " & RmvDepBox.SelectedItem & "?" 'gives the user feedback about what department they want to remove
    End Sub

    Private Sub RmvSubDepDepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RmvSubDepDepBox.SelectedIndexChanged
        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        RmvSubDepBox.Items.Clear()

        For i = 0 To SDRowcount
            If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Department") = RmvSubDepDepBox.SelectedItem Then       'fills the sub department combobox with the relevant sub departments
                RmvSubDepBox.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department"))
            End If
        Next i
    End Sub

    Private Sub RmvSubDep_Click(sender As Object, e As EventArgs) Handles RmvSubDep.Click
        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1

        For i = 0 To SDRowcount
            If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department") = RmvDepBox.SelectedItem Then         'removes the specified sub departments from the database
                SSMS_DATABASEDataSet.Sub_Department.Rows(i).Delete()
            End If
        Next i

        MsgBox("Sub-Department removed.")
        Sub_DepartmentTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub RmvSubDepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RmvSubDepBox.SelectedIndexChanged, RmvSubDepDepBox.SelectedIndexChanged
        RmvDepTxt.Text = "Are you sure you want to remove " & RmvSubDepBox.SelectedItem & "?" 'gives the user feedback about what sub department they want to remove
    End Sub

End Class