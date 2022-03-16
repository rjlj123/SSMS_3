Public Class Manage_Stock_View
    Dim flag = True
    Dim DRowcount As Integer
    Dim SDRowcount As Integer
    Dim Prowcount As Integer

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

    Private Sub Manage_Stock_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the sub department table of the database 
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the department table of the database 
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 
        Lbl_UserID.Text = UserID

        Dim a As Control
        flag = True

        For Each a In Me.Controls
            flag = True
            If a.Name = "BarNumb" Then flag = False
            If flag = True Then
                If TypeOf a Is TextBox Then
                    a.Enabled = False
                End If
            End If

            If TypeOf a Is ComboBox Then                'disables all controls on the form, until a product barcode is searched for
                a.Enabled = False
            End If
            Unt.SelectedItem = Nothing
            DepBox.SelectedItem = Nothing
            SubBox.SelectedItem = Nothing
        Next


        DRowcount = SSMS_DATABASEDataSet.Department.Rows.Count - 1

        For i = 0 To DRowcount
            Dep = SSMS_DATABASEDataSet.Department.Rows(i).Item(1)       'adds the databases's departments to the department combobox
            Me.DepBox.Items.Add(Dep)
        Next i
    End Sub

    Private Sub Btn_Srch_Click(sender As Object, e As EventArgs) Handles Btn_Srch.Click
        BarNumb.Enabled = False
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        flag = False

        For i = 0 To Prowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item(2) = BarNumb.Text Then
                flag = True
            End If

            If flag = True Then
                ProdNme.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(3)
                DepBox.SelectedItem = SSMS_DATABASEDataSet.Product.Rows(i).Item(4)
                SubBox.SelectedItem = SSMS_DATABASEDataSet.Product.Rows(i).Item(5)
                Prc.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(12)
                Wgt.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(13)
                Unt.SelectedItem = SSMS_DATABASEDataSet.Product.Rows(i).Item(14)
                Flavr.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(15)
                ALoc.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(16)
                SalAvg.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(6)
                MaxSlf.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(9)
                MinStk.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(10)
                CasSiz.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(11)

                Dim a As Control
                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then                     'enables the controls so that data can be editted
                        a.Enabled = True
                    End If

                    If TypeOf a Is ComboBox Then
                        a.Enabled = True
                    End If
                Next

            End If
        Next i

        If flag = False Then
            MsgBox("Barcode not found.")        'provides the user with feedback that the barcode could not be found
        End If
    End Sub

    Private Sub DepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepBox.SelectedIndexChanged
        SDRowCount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        SubBox.SelectedItem = Nothing
        SubBox.Items.Clear()

        For i = 0 To SDRowCount
            If SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item(2) = DepBox.SelectedItem Then   'fills the sub department combobox based on the selected department
                SubBox.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item(1))
            End If
        Next i
    End Sub

    Private Sub Edit_Details_Click(sender As Object, e As EventArgs) Handles Edit_Details.Click
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        flag = True

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
        If TxtFlag = False Then flag = False

        If Unt.SelectedItem = Nothing Then
            MsgBox("Please select a weight unit.")
            flag = False
        End If

        If DepBox.SelectedItem = Nothing Then
            MsgBox("Please select a department.")
            flag = False
        End If

        If SubBox.SelectedItem = Nothing Then
            MsgBox("Please select a sub department.")
            flag = False
        End If

        If ProdNme.Text.Length > 60 Then
            MsgBox("Product name must be less than 60 characters.")
            flag = False
        End If

        If ProdNme.Text.Length < 5 Then
            MsgBox("Product name must be more than 5 charcters.")
            flag = False
        End If

        If IsNumeric(BarNumb.Text) = False Then
            MsgBox("Please enter a valid barcode.")
            flag = False
        End If

        Dim BCode As Integer
        BCode = BarNumb.Text
        For i = 0 To Prowcount
            If BCode = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") Then
                MsgBox("Barcode number already exists, please enter a different barcode.")
                flag = False
            End If
        Next i

        If IsNumeric(Prc.Text) = False Then
            MsgBox("Please enter a valid price.")
            flag = False
        End If

        If IsNumeric(Wgt.Text) = False Then
            MsgBox("Please enter a valid weight.")
            flag = False
        End If

        If Flavr.Text.Length > 20 Then
            MsgBox("Flavour must be less than 20 characters.")
            flag = False
        End If

        If Flavr.Text.Length < 5 Then
            MsgBox("Flavour must be more than 5 charcters.")        'validates all user inputted data to ensure that all data entered is valid
            flag = False
        End If

        If IsNumeric(CasSiz.Text) = False Then
            MsgBox("Please enter a valid case size.")
            flag = False
        End If

        If CasSiz.Text.Length > 2 Then
            MsgBox("Case size needs to be between 1 and 99.")
            flag = False
        End If

        If CasSiz.Text = "0" Then
            MsgBox("Case size needs to be between 1 and 99.")
            flag = False
        End If

        If IsNumeric(MinStk.Text) = False Then
            MsgBox("Please enter a valid min stock level.")
            flag = False
        End If

        If MinStk.Text.Length > 2 Then
            MsgBox("Min stock level needs to be between 1 and 99.")
            flag = False
        End If

        If MinStk.Text = "0" Then
            MsgBox("Min stock level needs to be between 1 and 99.")
            flag = False
        End If

        If IsNumeric(MaxSlf.Text) = False Then
            MsgBox("Please enter a valid max shelf level.")
            flag = False
        End If

        If MaxSlf.Text.Length > 2 Then
            MsgBox("Max shelf level needs to be between 1 and 99.")
            flag = False
        End If

        If MaxSlf.Text = "0" Then
            MsgBox("Max shelf level needs to be between 1 and 99.")
            flag = False
        End If

        If IsNumeric(SalAvg.Text) = False Then
            MsgBox("Please enter a valid sales average.")
            flag = False
        End If

        If SalAvg.Text.Length > 2 Then
            MsgBox("Sales average level needs to be between 1 and 99.")
            flag = False
        End If

        If SalAvg.Text = "0" Then
            MsgBox("Sales average level needs to be between 1 and 99.")
            flag = False
        End If
        'validation ends

        If flag = True Then
            For i = 0 To Prowcount
                If SSMS_DATABASEDataSet.Product.Rows(i).Item(2) = BarNumb.Text Then
                    BarNumb.Enabled = False
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(3) = ProdNme.Text
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(4) = DepBox.SelectedItem
                    SubBox.SelectedItem = SSMS_DATABASEDataSet.Product.Rows(i).Item(5)
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(12) = Prc.Text
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(13) = Wgt.Text
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(14) = Unt.SelectedItem                'updates the database to contain the new data that the user has 
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(15) = Flavr.Text
                    SSMS_DATABASEDataSet.Product.Rows(i).Item(16) = ALoc.Text
                    SalAvg.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(6) = SalAvg.Text
                    MaxSlf.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(9) = MaxSlf.Text
                    MinStk.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(10) = MinStk.Text
                    CasSiz.Text = SSMS_DATABASEDataSet.Product.Rows(i).Item(11) = CasSiz.Text
                End If
            Next i
        End If

        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click
        Dim a As Control
        flag = True

        For Each a In Me.Controls
            If a.Name = "BarNumb" Then
                a.Text = ""
                flag = False
            Else
                flag = True
            End If
            If flag = True Then
                If TypeOf a Is TextBox Then         'reverts the form back to it's original state
                    a.Enabled = False
                    a.Text = ""
                End If
            End If

            If TypeOf a Is ComboBox Then
                a.Enabled = False
            End If
            Unt.SelectedItem = Nothing
            DepBox.SelectedItem = Nothing
            SubBox.SelectedItem = Nothing
        Next
    End Sub
End Class