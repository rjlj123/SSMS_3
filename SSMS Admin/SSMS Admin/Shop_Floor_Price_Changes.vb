Public Class Shop_Floor_Price_Changes
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

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database
        Lbl_UserID.Text = UserID

    End Sub

    Private Sub BarNum_TextChanged(sender As Object, e As EventArgs) Handles BarNum.TextChanged
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        ProDet.Items.Clear()

        For i = 0 To PRowcount
            If BarNum.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") Then
                ProDet.Items.Add("Product Name: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name"))
                ProDet.Items.Add("Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("Department"))
                ProDet.Items.Add("Sub-Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("Sub_Department"))      'if the barcode number is found, the prodcut's details are shown
                ProDet.Items.Add("Colour/flavour: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("Colour_Flavour"))
                ProDet.Items.Add("On Promo: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("On_Promo"))
                CurPri.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item("Price")
            End If
        Next i
    End Sub

    Private Sub ConPri_Click(sender As Object, e As EventArgs) Handles ConPri.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        Dim flag As Boolean = True

        If IsNumeric(NewPri.Text) = False Then
            flag = False
            MsgBox("Please enter a valid price.")           'validates the price
        End If

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = BarNum.Text Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Price") = NewPri.Text
            End If
            If ProChk.Checked = True Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("On_Promo") = "Yes"       'changes the products price and promo feild to the user submitted data
            Else
                SSMS_DATABASEDataSet.Product.Rows(i).Item("On_Promo") = "No"
            End If
        Next i

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

End Class