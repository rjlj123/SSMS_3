Public Class Count_2
    Dim Sub_Department As String
    Dim PRowcount As Integer
    Dim CVRowcount As Integer
    Dim BarcodeNumber As Integer
    Dim ItemCount As Integer
    Dim SalesAvg As Integer
    Dim BinAmount As Integer
    Dim MaxShelf As Integer
    Dim Selecteditem As String
    Dim CountAmount As Integer

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Sub_Dep.Text = ""       'backwards navigation
        Count_1.Show()
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Sub_Dep.Text = ""       'shows the main menu form
        Main_Menu.Show()
    End Sub

    Private Sub Count_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        Me.Count_VerificationTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Count_Verification) 'allows the algorithm to search through the count verification table of the database
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database
        User_ID.Text = "User ID: " & UserID
        Sub_Dep.Text = Global_Variables.SubDep
        Home_Nav.Parent = Banner_Box
        Back_Nav.Parent = Banner_Box
        Count_Info.Items.Clear()

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        For i = 0 To PRowcount
            Sub_Department = SSMS_DATABASEDataSet.Product.Rows(i).Item(5)
            If Sub_Department = SubDep Then
                ItemCount = SSMS_DATABASEDataSet.Product.Rows(i).Item(8)
                SalesAvg = SSMS_DATABASEDataSet.Product.Rows(i).Item(6)
                MaxShelf = SSMS_DATABASEDataSet.Product.Rows(i).Item(9)
                BinAmount = SSMS_DATABASEDataSet.Product.Rows(i).Item(7)                'adds the products that require counting to the count listbox
                If BinAmount > 0 Then
                    If ItemCount < MaxShelf Then
                        If ItemCount - SalesAvg < MaxShelf = True Then
                            Count_Info.Items.Add(SSMS_DATABASEDataSet.Product.Rows(i).Item(3))
                        End If
                    End If
                End If
            End If
        Next i

    End Sub

    Private Sub Count_Info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Count_Info.SelectedIndexChanged
        Selecteditem = Count_Info.SelectedItem
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item(3) = Selecteditem Then
                Item_Info.Items.Clear()
                Item_Info.Items.Add("Poduct Name: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(3))
                Item_Info.Items.Add("Barcode Number: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(2))          'displays information about the selected product
                Item_Info.Items.Add("Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(4))
                Item_Info.Items.Add("Sub-Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(5))
                Item_Info.Items.Add("Bin-Amount: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(7))
                Item_Info.Items.Add("Count status: Incomplete")
            End If
        Next i
    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Dim flag As Boolean = True
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        CVRowcount = SSMS_DATABASEDataSet.Count_Verification.Rows.Count - 1

        If IsNumeric(txtcount.Text) = False Then
            MsgBox("Please enter a valid count.")
            flag = False
        End If

        For i = 0 To PRowcount
            If Count_Info.SelectedItem = SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name") Then
                Dim NewCVRow As DataRow = SSMS_DATABASEDataSet.Count_Verification.NewRow
                NewCVRow("BarcodeNumber") = SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber")
                NewCVRow("Shelfcount") = txtcount.Text
                NewCVRow("Sub_DepartmentID") = SSMS_DATABASEDataSet.Product.Rows(i).Item("Sub_DepartmentID")
                NewCVRow("Product_Name") = SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name")

                SSMS_DATABASEDataSet.Count_Verification.Rows.Add(NewCVRow)
                Count_VerificationTableAdapter.Update(SSMS_DATABASEDataSet)                                             'updates the count and validates the dataset

                If Item_Info.Items.Contains("Count status: Incomplete") Then
                    Item_Info.Items.Remove("Count status: Incomplete")
                    Item_Info.Items.Add("Count status: Complete")
                End If

                txtcount.Clear()
            End If
        Next i
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        MsgBox("Changes confirmed.")
    End Sub

    Private Sub txtcount_TextChanged(sender As Object, e As EventArgs) Handles txtcount.TextChanged
        LrgCnt.Hide()

        If IsNumeric(txtcount.Text) = True Then
            If txtcount.Text > 50 Then                              'warns the user that the count amount may be incorrect
                LrgCnt.Show()
            End If
        End If
    End Sub
End Class