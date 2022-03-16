Public Class Sales_Floor
    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Item_Search.Show()      'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()        'shows the main menu form
    End Sub

    Private Sub Sales_Floor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'allows the algorithm to search through the product bin table of the database
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database

        BarNumb.Text = "Barcode Number: " & SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(2)
        Nme.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(3)
        Dep.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(4)
        SubDep.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(5)
        Avg.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(6)
        Bin_Amt.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(7)
        Max.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(9)
        MinAmt.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(10)
        Cas.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(11)
        Price.Text = "£ " & SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(12)                                                                  'displays inforamtion about the selected product on the form
        ItmSiz.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(13) & SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(14)
        ItmCol.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(15)
        Ail.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(16)
        Pro.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(17)
        Rmvd.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(18)
        SIA.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(19)

        Order.Text = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(21)

        Dim rowcount As Integer
        rowcount = SSMS_DATABASEDataSet.Tables("Product_Bin").Rows.Count - 1
        BinNumb.Text = ""
        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Product_Bin").Rows(i).Item(2) = SSMS_DATABASEDataSet.Product.Rows(searchterm).Item(0) Then
                BinNumb.Text = BinNumb.Text & " " & SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(1)
            End If
        Next i

        User_ID.Text = "User ID: " & UserID
        Home_Nav.Parent = Banner_Box
        Back_Nav.Parent = Banner_Box
    End Sub

End Class