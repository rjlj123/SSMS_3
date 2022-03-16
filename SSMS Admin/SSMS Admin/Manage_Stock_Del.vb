Public Class Manage_Stock_Del
    Dim PRowcount As Integer
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

    Private Sub Manage_Stock_Del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 
        Lbl_UserID.Text = UserID

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Removed") = "Yes" Then
                DelItems.Items.Add(SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name")) 'if a product is flagged for removal, it is added to the listbox
            End If
        Next i

    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name") = DelItems.SelectedItem Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Removed") = "No"                             'removes the selected product from the listbox and remove it's flag for deletion
            End If
        Next i

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        DelItems.Items.Remove(DelItems.SelectedItem)
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For j = 0 To DelItems.Items.Count - 1
            For i = 0 To PRowcount
                If SSMS_DATABASEDataSet.Product.Rows(i).Item("Removed") = DelItems.Items(j) Then        'deletes the products, within the listbox, from the database
                    SSMS_DATABASEDataSet.Product.Rows(i).Delete()
                End If
            Next i
        Next j

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class