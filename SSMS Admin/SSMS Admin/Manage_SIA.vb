Public Class Manage_SIA
    Dim PRowcount As Integer
    Dim multiple As Integer
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
        Me.Show()
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

    Private Sub Manage_SIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the Product table of the database
        Lbl_UserID.Text = UserID

    End Sub

    Private Sub RmvItm_Click(sender As Object, e As EventArgs) Handles RmvItm.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name") = SIA_Listbox.SelectedItem Then        'removes the selected item from the SIA listbox
                SSMS_DATABASEDataSet.Product.Rows(i).Item("SIA") = "Removed"
                SIA_Listbox.Items.Remove(SIA_Listbox.SelectedItem)
            End If
        Next i
        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub SIAMul_ValueChanged(sender As Object, e As EventArgs) Handles SIAMul.ValueChanged
        Dim MaxShelf As Integer
        Dim BinAmount As Integer

        SIA_Listbox.Items.Clear()
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        multiple = SIAMul.Value


        For i = 0 To PRowcount
                MaxShelf = SSMS_DATABASEDataSet.Product.Rows(i).Item("Max_Shelf")
                BinAmount = SSMS_DATABASEDataSet.Product.Rows(i).Item("Bin_Amount")
                If (BinAmount + MaxShelf) > (MaxShelf * multiple) Then
                SIA_Listbox.Items.Add(SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name"))        'determines the conditions that SIA will be applied under
                End If
            Next i

    End Sub

    Private Sub ConSia_Click(sender As Object, e As EventArgs) Handles ConSia.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        SRowcount = SIA_Listbox.Items.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("SIA") = "Removed" Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("SIA") = "No"
            End If
        Next i

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("SIA") = "Yes" Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("SIA") = "No"
            End If
        Next i
        'updates the database to ensure that SIA products are selected correctly.
        For i = 0 To SRowcount
            For j = 0 To PRowcount
                If SIA_Listbox.Items(i) = SSMS_DATABASEDataSet.Product.Rows(j).Item("Product_Name") Then
                    SSMS_DATABASEDataSet.Product.Rows(j).Item("SIA") = "Yes"
                End If
            Next j
        Next i

        MsgBox("Items confirmed.")
        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class