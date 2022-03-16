Public Class Count_1
    Dim selecteditem As String
    Dim DRowcount As Integer
    Dim SDRowcount As Integer
    Dim Dep As String
    Dim flag As Boolean

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'shows the main menu form
    End Sub

    Private Sub Count_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the sub department table of the database
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the department table of the database
        User_ID.Text = "User ID: " & UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box

        Sub_List.Hide()
        flag = False
        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1
        For i = 0 To DRowcount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1)               'fills the department listbox with the databases's departments
            If Dep = "Manager" Then flag = True
            If flag = False Then
                Dep_List.Items.Add(Dep)
            End If
        Next

    End Sub


    Private Sub Dep_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dep_List.SelectedIndexChanged
        Dim DepID As Integer
        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1
        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        selecteditem = Dep_List.SelectedItem

        Sub_List.Hide()
        Sub_List.Items.Clear()

        For i = 0 To DRowcount
            If selecteditem = SSMS_DATABASEDataSet.Department.Rows(i).Item(1) Then
                DepID = SSMS_DATABASEDataSet.Department.Rows(i).Item(0)
                For j = 0 To SDRowcount
                    If DepID = SSMS_DATABASEDataSet.Sub_Department.Rows(j).Item(0) Then
                        Sub_List.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(j).Item(1))     'fills the sub department listbox with the chosen departments's sub department's 
                        Sub_List.Location = New Point(264, (182 + (i * 24)))
                    End If
                Next j
            End If
        Next i



        Sub_List.Show()
    End Sub

    Private Sub Sub_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sub_List.SelectedIndexChanged
        If Sub_List.SelectedItem = Sub_List.SelectedItem Then
            SubDep = Sub_List.SelectedItem
            Me.Hide()
            Count_2.Show()                          'shows the counting form
        End If
    End Sub
End Class