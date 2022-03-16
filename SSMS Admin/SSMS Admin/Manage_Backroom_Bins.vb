Public Class Manage_Backroom_Bins
    Dim BRowcount As Integer
    Dim PBRowcount As Integer
    Dim PRowcount As Integer

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

    Private Sub Manage_Backroom_Bins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'allows the algorithm to search through the Product Bin table of the database 
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the Product table of the database 
        Me.BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Bin) 'allows the algorithm to search through the Bin table of the database 
        Lbl_UserID.Text = UserID

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Add_Bin.Click
        Dim NewRow As DataRow = SSMS_DATABASEDataSet.Bin.NewRow

        SSMS_DATABASEDataSet.Bin.Rows.Add(NewRow)
        BinTableAdapter.Update(SSMS_DATABASEDataSet)                            'Adds a new Bin to the database
        MsgBox("Bin " & SSMS_DATABASEDataSet.Bin.NewRow.Item(0) & " added.")
    End Sub

    Private Sub Remove_Bin_Click(sender As Object, e As EventArgs) Handles Remove_Bin.Click
        BRowcount = SSMS_DATABASEDataSet.Bin.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        Dim Binned_Amount As Integer
        Dim TotalBinnedAmount As Integer
        Dim ProductID As Integer

        For i = 0 To BRowcount
            If SSMS_DATABASEDataSet.Bin.Rows(i).Item(0) = BinIDTxt.Text Then
                For j = 0 To PBRowcount
                    ProductID = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(2)
                    If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(1) = BinIDTxt.Text Then
                        For k = 0 To PRowcount
                            If SSMS_DATABASEDataSet.Product.Rows(k).Item(0) = ProductID Then
                                Binned_Amount = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3)   'deletes the Bin, and ensures that product Bin amounts are valid
                                TotalBinnedAmount = TotalBinnedAmount + Binned_Amount
                                SSMS_DATABASEDataSet.Product.Rows(k).Item(7) = TotalBinnedAmount
                            End If
                        Next k
                        SSMS_DATABASEDataSet.Product_Bin.Rows(j).Delete()
                    End If
                Next j
                MsgBox("Bin " & SSMS_DATABASEDataSet.Bin.Rows(i).Item(0) & " deleted.")
                SSMS_DATABASEDataSet.Bin.Rows(i).Delete()
            End If
        Next i

        BinIDTxt.Clear()
        Me.Product_BinTableAdapter.Update(SSMS_DATABASEDataSet)
        Me.BinTableAdapter.Update(SSMS_DATABASEDataSet)                 'updates the respective datasets
        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class