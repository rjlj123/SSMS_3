Public Class Binning_2
    Dim PBRowcount As Integer
    Dim PRowcount As Integer
    Dim ProID As Integer
    Dim ItemName As String
    Dim ItemCode As Double
    Dim SelItem As String
    Dim searchitem As String

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Binning_1.Show()        'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()        'returns the user to the main menu
    End Sub

    Private Sub Clr_Click(sender As Object, e As EventArgs) Handles Clr.Click
        Binning_3.Show()        'shows the clear bin form
    End Sub

    Private Sub Bin_In_Click(sender As Object, e As EventArgs) Handles Bin_In.Click
        Me.Hide()
        Binning_4.Show()        'shows the binning form
    End Sub

    Private Sub Binning_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'allows the algorithm to search through the product bin table of the database 
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 
        Me.BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Bin) 'allows the algorithm to search through the bin table of the database 
        User_ID.Text = UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box
        Bin_ID.Text = "Bin ID: " & Bin_Number
        Bin_Info.Items.Clear()

        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1

        For i = 0 To PBRowcount
            If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(1) = Bin_Number Then
                ProID = SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(2)
                For j = 0 To PRowcount
                    If ProID = SSMS_DATABASEDataSet.Product.Rows(j).Item(0) Then
                        ItemName = SSMS_DATABASEDataSet.Product.Rows(j).Item(3)         'displays the products found in the bin listbox
                        ItemCode = SSMS_DATABASEDataSet.Product.Rows(j).Item(2)
                        Bin_Info.Items.Add(ItemName)
                    End If
                Next j
            End If
        Next i

        ItemName = ""
        ItemCode = 0
    End Sub

    Private Sub Bin_Info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Bin_Info.SelectedIndexChanged

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        SelItem = Bin_Info.SelectedItem

        For i = 0 To PRowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item(3) = SelItem Then
                ItemInfo.Items.Clear()
                ItemInfo.Items.Add("Poduct Name: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(3))
                ItemInfo.Items.Add("Barcode Number: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(2))       'displays futher information about the selected item in the bin listbox
                ItemInfo.Items.Add("Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(4))
                ItemInfo.Items.Add("Sub-Department: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(5))
                ItemInfo.Items.Add("Bin-Amount: " & SSMS_DATABASEDataSet.Product.Rows(i).Item(7))
            End If
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        searchitem = Search_Term.Text
        If Bin_Info.Items.Contains(searchitem) Then                     'sets the selected item in the bin listbox to the search term 
            Bin_Info.SelectedItem = searchitem
        Else
            MsgBox("Item not found.")
        End If

    End Sub

End Class