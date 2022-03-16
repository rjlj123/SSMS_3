Public Class Manage_Stock_Add
    Dim DRowCount As Integer
    Dim SDRowCount As Integer
    Dim PRowCount As Integer
    Dim Flag = True

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

    Private Sub Manage_Stock_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_UserID.Text = UserID
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the sub department table of the database 
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the department table of the database 
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 
        Lbl_UserID.Text = UserID

        DRowCount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowCount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1)       'fills the department combobox with the database's departments
            Me.DepBox.Items.Add(Dep)
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
            Unt.SelectedItem = Nothing              'clears all user inputted data from the form
            DepBox.SelectedItem = Nothing
            SubBox.SelectedItem = Nothing
            SubBox.Items.Clear()
        Next
    End Sub

    Private Sub DepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepBox.SelectedIndexChanged
        SDRowCount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        SubBox.SelectedItem = Nothing
        SubBox.Items.Clear()

        For i = 0 To SDRowCount
            If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item(2) = DepBox.SelectedItem Then
                SubBox.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item(1))       'fills the sub department combobox with sub departments come under the chosen department
            End If
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewProductRow As DataRow = SSMS_DATABASEDataSet.Product.NewRow
        Flag = True

        PRowCount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        SDRowCount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        'validation starts
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
        Next
        If TxtFlag = False Then Flag = False

        If Unt.SelectedItem = Nothing Then
            MsgBox("Please select a weight unit.")
            Flag = False
        End If

        If DepBox.SelectedItem = Nothing Then
            MsgBox("Please select a department.")
            Flag = False
        End If

        If SubBox.SelectedItem = Nothing Then
            MsgBox("Please select a sub department.")
            Flag = False
        End If

        If ProdNme.Text.Length > 60 Then
            MsgBox("Product name must be less than 60 characters.")
            Flag = False
        End If

        If ProdNme.Text.Length < 5 Then
            MsgBox("Product name must be more than 5 charcters.")
            Flag = False
        End If

        If IsNumeric(BarNumb.Text) = False Then
            MsgBox("Please enter a valid barcode.")
            Flag = False
        End If

        Dim BCode As Integer
        BCode = BarNumb.Text
        For i = 0 To PRowCount
            If BCode = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") Then
                MsgBox("Barcode number already exists, please enter a different barcode.")
                Flag = False
            End If
        Next i

        If IsNumeric(Prc.Text) = False Then
            MsgBox("Please enter a valid price.")
            Flag = False
        End If

        If IsNumeric(Wgt.Text) = False Then
            MsgBox("Please enter a valid weight.")
            Flag = False
        End If

        If Flavr.Text.Length > 20 Then
            MsgBox("Flavour must be less than 20 characters.")
            Flag = False
        End If

        If Flavr.Text.Length < 5 Then
            MsgBox("Flavour must be more than 5 charcters.")        'validates all user inputted data to ensure that all data entered is valid
            Flag = False
        End If

        If IsNumeric(CasSiz.Text) = False Then
            MsgBox("Please enter a valid case size.")
            Flag = False
        End If

        If CasSiz.Text.Length > 2 Then
            MsgBox("Case size needs to be between 1 and 99.")
            Flag = False
        End If

        If CasSiz.Text = "0" Then
            MsgBox("Case size needs to be between 1 and 99.")
            Flag = False
        End If

        If IsNumeric(MinStk.Text) = False Then
            MsgBox("Please enter a valid min stock level.")
            Flag = False
        End If

        If MinStk.Text.Length > 2 Then
            MsgBox("Min stock level needs to be between 1 and 99.")
            Flag = False
        End If

        If MinStk.Text = "0" Then
            MsgBox("Min stock level needs to be between 1 and 99.")
            Flag = False
        End If

        If IsNumeric(MaxSlf.Text) = False Then
            MsgBox("Please enter a valid max shelf level.")
            Flag = False
        End If

        If MaxSlf.Text.Length > 2 Then
            MsgBox("Max shelf level needs to be between 1 and 99.")
            Flag = False
        End If

        If MaxSlf.Text = "0" Then
            MsgBox("Max shelf level needs to be between 1 and 99.")
            Flag = False
        End If

        If IsNumeric(SalAvg.Text) = False Then
            MsgBox("Please enter a valid sales average.")
            Flag = False
        End If

        If SalAvg.Text.Length > 2 Then
            MsgBox("Sales average level needs to be between 1 and 99.")
            Flag = False
        End If

        If SalAvg.Text = "0" Then
            MsgBox("Sales average level needs to be between 1 and 99.")
            Flag = False
        End If
        'validation ends

            If Flag = True Then
                NewProductRow("Product_Name") = ProdNme.Text
                NewProductRow("BarcodeNumber") = BarNumb.Text
                NewProductRow("Department") = DepBox.SelectedItem
                NewProductRow("Sub_Department") = SubBox.SelectedItem
                NewProductRow("Price") = Prc.Text
                NewProductRow("Weight") = Wgt.Text
                NewProductRow("Weight_Unit") = Unt.SelectedItem
                NewProductRow("Colour_Flavour") = Flavr.Text
                NewProductRow("Ailse Location") = ALoc.Text
                NewProductRow("Sales_Avg") = SalAvg.Text
                NewProductRow("Max_Shelf") = MaxSlf.Text
                NewProductRow("Min_Stock") = MinStk.Text
                NewProductRow("Case_Size") = CasSiz.Text

            For i = 0 To SDRowCount
                If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item(1) = SubBox.SelectedItem Then
                    NewProductRow("Sub_DepartmentID") = SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_DepartmentID")        'Adds the new product to the dataset
                End If
            Next i

                NewProductRow("Bin_Amount") = "0"
                NewProductRow("Shelf_Count") = "0"
                NewProductRow("Amount_Order") = "0"
                NewProductRow("On_Promo") = "No"
                NewProductRow("Removed") = "No"
                NewProductRow("SIA") = "No"
                NewProductRow("Order_List") = "No"

            End If
        SSMS_DATABASEDataSet.Product.Rows.Add(NewProductRow)
        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        MsgBox("Item added.")
    End Sub
End Class