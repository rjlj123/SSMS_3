Public Class Add_Item
    Private Sub Add_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the sub-department table of the database 
        Me.DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Department) 'allows the algorithm to search through the department table of the database 
        Me.ProductTableAdapter.Fill(SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 
        User_ID.Text = "User ID: " & UserID
        Home_Nav.Parent = Banner_Box
        Back_Nav.Parent = Banner_Box

        Dim DRowcount As Integer = SSMS_DATABASEDataSet.Department.Rows.Count - 1
        For i = 0 To DRowcount
            DepBox.Items.Add(SSMS_DATABASEDataSet.Department.Rows(i).Item("Department"))                    'fills the department combobox with the database's departments
        Next i
    End Sub

    Private Sub DepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepBox.SelectedIndexChanged
        Dim SDRowcount As Integer = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1
        SubBox.SelectedItem = Nothing
        SubBox.Items.Clear()

        For i = 0 To SDRowcount
            If DepBox.SelectedItem = SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Department") Then        'fills the sub department combobox with sub departments come under the chosen department
                SubBox.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department"))
            End If
        Next i
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Item_Management.Show()          'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'returns the user to the main menu
    End Sub

    Private Sub Btn_Sub_Click(sender As Object, e As EventArgs) Handles Btn_Sub.Click
        Dim newproductrow As DataRow = SSMS_DATABASEDataSet.Tables("Product").NewRow
        Dim flag As Boolean = True

        'validation
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                If a.Text = "" Then
                    MsgBox("Please ensure that all textboxes contain text.")
                    flag = False
                End If
            End If
        Next

        If Prod_Nme.Text.Length > 60 Then
            MsgBox("Product name must be less than 60 characters.")
            flag = False
        End If

        If Prod_Nme.Text.Length < 5 Then
            MsgBox("Product name must be more than 5 charcters.")
            flag = False
        End If

        If IsNumeric(BarNumb.Text) = False Then
            MsgBox("Please enter a valid barcode.")
            flag = False
        Else
            Dim BCode As Integer
            Dim PRowcount As Integer = SSMS_DATABASEDataSet.Product.Rows.Count - 1              'validates the data entered

            BCode = BarNumb.Text
            For i = 0 To PRowcount
                If BCode = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") Then
                    MsgBox("Barcode number already exists, please enter a different barcode.")
                    flag = False
                End If
            Next i
        End If
        If DepBox.SelectedItem = Nothing Then
            MsgBox("Please select a department.")
            flag = False
        End If

        If SubBox.SelectedItem = Nothing Then
            MsgBox("Please select a sub department.")
            flag = False
        End If

        'validation ends

        If flag = True Then
            newproductrow("Product_Name") = Prod_Nme.Text
            newproductrow("BarcodeNumber") = BarNumb.Text
            newproductrow("Department") = DepBox.SelectedItem
            newproductrow("Sub_Department") = SubBox.SelectedItem

            SSMS_DATABASEDataSet.Product.Rows.Add(newproductrow)                    'adds the new product to the dataset

            Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)

            MsgBox("Success, basic item details added.")
        End If

    End Sub
End Class