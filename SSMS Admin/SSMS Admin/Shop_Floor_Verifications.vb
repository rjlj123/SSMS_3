Public Class Shop_Floor_Verifications
    Dim PRowcount As Integer
    Dim SDRowcount As Integer
    Dim CVRowcount As Integer
    Dim ProdNme As String
    Dim BarNum As Integer
    Dim SlfCnt As Integer

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

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department)
        Me.Count_VerificationTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Count_Verification)
        Lbl_UserID.Text = UserID

        ' when count is verified item should be taken off of order list
        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        For i = 0 To SDRowcount
            SubDeps.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department"))       'fills the sub department combobox with the database's sub departments
        Next i
    End Sub

    Private Sub SubDeps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubDeps.SelectedIndexChanged
        Count_Verify.Items.Clear()
        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        For i = 0 To SDRowcount
            If SubDeps.SelectedItem = SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department") Then
                SubDep = SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_DepartmentID")
            End If
        Next i
        'adds the counts that need to be verified, to the listbox
        CVRowcount = SSMS_DATABASEDataSet.Count_Verification.Rows.Count - 1
        For i = 0 To CVRowcount
            If SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Sub_DepartmentID") Then
                Count_Verify.Items.Add(SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Product_Name"))
            End If
        Next i
    End Sub

    Private Sub Count_Verify_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Count_Verify.SelectedIndexChanged

        CVRowcount = SSMS_DATABASEDataSet.Count_Verification.Rows.Count - 1
        For i = 0 To CVRowcount
            If Count_Verify.SelectedItem = SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Product_Name") Then
                ProdNme = SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Product_Name")
                BarNum = SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("BarcodeNumber")
                SlfCnt = SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("ShelfCount")                         'provides the user with details about the selected item

                ProdNmeTxt.Text = ProdNme
                BarNumTxt.Text = BarNum
                SlfCntTxt.Text = SlfCnt
            End If
        Next i
    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        CVRowcount = SSMS_DATABASEDataSet.Count_Verification.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name") = ProdNme Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Shelf_Count") = SlfCnt
            End If
        Next i

        For i = 0 To CVRowcount
            If SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Product_Name") = ProdNme Then      'verifies the selected count and validates the dataset
                Count_Verify.Items.Remove(Count_Verify.SelectedItem)
                SSMS_DATABASEDataSet.Count_Verification.Rows(i).Delete()
            End If
        Next i

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        Count_VerificationTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub BtnAll_Click(sender As Object, e As EventArgs) Handles BtnAll.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        CVRowcount = SSMS_DATABASEDataSet.Count_Verification.Rows.Count - 1
        For i = 0 To Count_Verify.Items.Count - 1
            For j = 0 To PRowcount
                If Count_Verify.Items(i) = SSMS_DATABASEDataSet.Product.Rows(j).Item("Product_Name") Then
                    For k = 0 To CVRowcount
                        If SSMS_DATABASEDataSet.Product.Rows(j).Item("Product_Name") = SSMS_DATABASEDataSet.Count_Verification.Rows(k).Item("Product_Name") Then
                            SSMS_DATABASEDataSet.Product.Rows(j).Item("Shelf_Count") = SlfCnt
                        End If
                    Next k                                                                                      'verifies the sub department's counts and validates the dataset
                End If
            Next j
        Next i

        For i = 0 To CVRowcount
            If SSMS_DATABASEDataSet.Count_Verification.Rows(i).Item("Sub_DepartmentID") = SubDep Then
                Count_Verify.Items.Remove(Count_Verify.SelectedItem)
                SSMS_DATABASEDataSet.Count_Verification.Rows(i).Delete()
            End If
        Next i

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        Count_VerificationTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class