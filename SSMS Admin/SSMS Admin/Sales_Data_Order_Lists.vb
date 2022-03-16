Imports System.IO
Public Class Sales_Data_Order_Lists
    Dim PRowcount As Integer
    Dim SDRowcount As Integer

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

    Private Sub Sales_Data_Order_Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database
        Me.Sub_DepartmentTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Sub_Department) 'allows the algorithm to search through the sub department table of the database
        Lbl_UserID.Text = UserID

        SDRowcount = SSMS_DATABASEDataSet.Sub_Department.Rows.Count - 1

        For i = 0 To SDRowcount
            SubDepBox.Items.Add(SSMS_DATABASEDataSet.Sub_Department.Rows(i).Item("Sub_Department")) 'fills the sub department combbobox with the sub department's saved within the system
        Next i
    End Sub

    Private Sub GenLst_Click(sender As Object, e As EventArgs) Handles GenLst.Click
        Dim ArrayItem As String
        Dim ArrayBarcode As String
        Dim Bin_Amount As Integer
        Dim Shelf_Count As Integer
        Dim Min_Stock As Integer
        Dim Case_Size As Integer
        Dim multiple As Integer
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        SubDep = SubDepBox.SelectedItem
        Order_List.Items.Clear()

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Sub_Department") = SubDepBox.SelectedItem Then
                ArrayItem = SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name")
                ArrayBarcode = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber")
                Bin_Amount = SSMS_DATABASEDataSet.Product.Rows(i).Item("Bin_Amount")
                Shelf_Count = SSMS_DATABASEDataSet.Product.Rows(i).Item("Shelf_Count")
                Min_Stock = SSMS_DATABASEDataSet.Product.Rows(i).Item("Min_Stock")
                Case_Size = SSMS_DATABASEDataSet.Product.Rows(i).Item("Case_Size")

                If (Bin_Amount + Shelf_Count) < Min_Stock Then


                    For j = 0 To Min_Stock
                        If ((Bin_Amount + Shelf_Count) + (Case_Size * j)) <= (Min_Stock * Odr_Mul.Value) Then 'the calculation that determines what gets ordered, and how much
                            multiple = (j * Case_Size)
                        End If
                    Next j


                    If multiple > 0 Then
                        Order_List.Items.Add(ArrayItem & ", " & ArrayBarcode & ", amount: " & (multiple))       'adds the item to the order list
                        SSMS_DATABASEDataSet.Product.Rows(i).Item("Order_List") = "Yes"
                        SSMS_DATABASEDataSet.Product.Rows(i).Item("Amount_Order") = multiple
                    End If
                End If
            End If
        Next i
    End Sub

    Private Sub ExpLst_Click(sender As Object, e As EventArgs) Handles ExpLst.Click

        Dim W As IO.StreamWriter
        W = New IO.StreamWriter("D:\" & SubDep & " Order List.txt")

        For i = 0 To Order_List.Items.Count - 1                             'exports the order list to a text file at the stated file location
            W.WriteLine(Order_List.Items.Item(i))
        Next i

        W.Close()
        MsgBox("Saved: H:\" & SubDep & " Order List.txt")

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("Order_List") = "Removed" Then
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Order_List") = "No"
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Amount_Order") = "0"
            End If
        Next i

        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub AddItm_Click(sender As Object, e As EventArgs) Handles AddItm.Click
        Dim ArrayItem As String
        Dim ArrayBarcode As String
        Dim Case_Size As Integer

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = ItmBcode.Text Then
                ArrayItem = SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name")
                ArrayBarcode = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber")               'adds the specified item to the order list
                Case_Size = SSMS_DATABASEDataSet.Product.Rows(i).Item("Case_Size")
                Order_List.Items.Add(ArrayItem & ", " & ArrayBarcode & ", amount: " & Case_Size)

                SSMS_DATABASEDataSet.Product.Rows(i).Item("Order_List") = "Yes"
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Amount_Order") = (SSMS_DATABASEDataSet.Product.Rows(i).Item("Amount_Order") + Case_Size)
            End If
        Next i
    End Sub

    Private Sub RmvItm_Click(sender As Object, e As EventArgs) Handles RmvItm.Click
        Dim SelItem As String
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        SelItem = Order_List.SelectedItem.ToString()

        For i = 0 To PRowcount
            If SelItem.Contains(SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber")) Then        'removes an item from the order list based on it's barcode
                SSMS_DATABASEDataSet.Product.Rows(i).Item("Order_List") = "Removed"
                Order_List.Items.Remove(Order_List.SelectedItem)
            End If
        Next i
        ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub
End Class