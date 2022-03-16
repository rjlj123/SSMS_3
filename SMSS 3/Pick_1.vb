Public Class Pick_1
    Dim Prowcount As Integer
    Dim PBRowcount As Integer
    Dim BRowcount As Integer

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Main_Menu.Show()                        'backwards navigation
        Me.Hide()
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Main_Menu.Show()                        'shows the main menu form
        Me.Hide()
    End Sub

    Private Sub BtnSIA_Click(sender As Object, e As EventArgs) Handles BtnSIA.Click
        Pick_SIA.Show()                         'shows the SIA form
        Me.Hide()
    End Sub

    Private Sub Pick_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'allows the algorithm to search through the product bin table of the database
        Me.BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Bin) 'allows the algorithm to search through the bin table of the database
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorith to search through the product table of the database
        User_ID.Text = "User ID: " & UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box

        BRowcount = SSMS_DATABASEDataSet.Bin.Rows.Count - 1
        For i = 0 To BRowcount
            BinChoice.Items.Add(SSMS_DATABASEDataSet.Bin.Rows(i).Item("BinID"))         'fills the bin choice combobox with the dataset's bins
        Next i

    End Sub

    Private Sub BinChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BinChoice.SelectedIndexChanged
        Dim ProdName As String
        Dim ProdBcode As Integer
        Dim BinAmt As Integer
        Dim SlfCnt As Integer
        Dim MaxSlf As Integer
        Dim CasSiz As Integer
        Dim BindAmt As Integer
        Dim Cases As Integer = 0
        Dim SelectedBin As Integer

        Pick_Info.Items.Clear()
        Item_Info.Items.Clear()

        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        SelectedBin = BinChoice.SelectedItem

        For i = 0 To PBRowcount
            If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item("BinID") = SelectedBin Then
                For j = 0 To Prowcount
                    If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item("ProductID") = SSMS_DATABASEDataSet.Product.Rows(j).Item("ProductID") Then
                        ProdName = SSMS_DATABASEDataSet.Product.Rows(j).Item("Product_Name")
                        ProdBcode = SSMS_DATABASEDataSet.Product.Rows(j).Item("BarcodeNumber")
                        BinAmt = SSMS_DATABASEDataSet.Product.Rows(j).Item("Bin_Amount")
                        SlfCnt = SSMS_DATABASEDataSet.Product.Rows(j).Item("Shelf_Count")
                        MaxSlf = SSMS_DATABASEDataSet.Product.Rows(j).Item("Max_Shelf")
                        CasSiz = SSMS_DATABASEDataSet.Product.Rows(j).Item("Case_Size")
                        BindAmt = SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(3)                'calculates the stock replenishment list for the chosen bin
                        Cases = 0
                        If BindAmt > 0 Then
                            Do While SlfCnt + CasSiz <= MaxSlf
                                SlfCnt = SlfCnt + CasSiz
                                Cases = Cases + 1
                                BindAmt = BindAmt - CasSiz
                                If BindAmt = 0 Then
                                    Exit Do
                                End If
                            Loop
                        End If
                        If Cases > 0 Then
                            Pick_Info.Items.Add(ProdName & ", " & ProdBcode & ", " & Cases)
                        End If
                    End If
                Next j
            End If
        Next i
    End Sub

    Private Sub Pick_Info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Pick_Info.SelectedIndexChanged
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        Item_Info.Items.Clear()

        If Pick_Info.SelectedItem <> "" Then
            For i = 0 To Prowcount
                If Pick_Info.SelectedItem.ToString.Contains(SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber")) Then
                    Item_Info.Items.Add("Item Name: " & SSMS_DATABASEDataSet.Product.Rows(i).Item("Product_Name"))                    'displays information about the selected item in the pick list
                    Item_Info.Items.Add("Pick Status: Incomplete")
                    For j = 0 To PBRowcount
                        If SSMS_DATABASEDataSet.Product.Rows(i).Item("ProductID") = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("ProductID") Then
                            If BinChoice.SelectedItem = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("BinID") Then
                                Item_Info.Items.Add("Binned Amount: " & SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3))

                                Dim SlfCnt As Integer
                                Dim MaxSlf As Integer
                                Dim CasSiz As Integer
                                Dim BindAmt As Integer
                                Dim Cases As Integer

                                SlfCnt = SSMS_DATABASEDataSet.Product.Rows(i).Item("Shelf_Count")
                                MaxSlf = SSMS_DATABASEDataSet.Product.Rows(i).Item("Max_Shelf")
                                CasSiz = SSMS_DATABASEDataSet.Product.Rows(i).Item("Case_Size")
                                BindAmt = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3)
                                If BindAmt > 0 Then
                                    Do While SlfCnt + CasSiz <= MaxSlf
                                        SlfCnt = SlfCnt + CasSiz
                                        Cases = Cases + 1
                                        BindAmt = BindAmt - CasSiz                                              'calculates the exact amount of stock that needs to be picked
                                        If BindAmt = 0 Then
                                            Exit Do
                                        End If
                                    Loop
                                End If
                                CasTxt.Text = Cases
                                TotTxt.Text = Cases * CasSiz
                            End If
                        End If
                    Next j
                End If
            Next i
        End If
    End Sub

    Private Sub BtnPck_Click(sender As Object, e As EventArgs) Handles BtnPck.Click
        Dim SlfCnt As Integer
        Dim MaxSlf As Integer
        Dim CasSiz As Integer
        Dim SelectedBin As Integer
        Dim SelectedBarcode As Integer
        Dim BinAmt As Integer
        Dim ProBinAmt As Integer
        Dim TotalBinnedAmount As Integer


        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        SelectedBin = BinChoice.SelectedItem

        For i = 0 To PBRowcount
            If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item("BinID") = BinChoice.SelectedItem Then
                For j = 0 To Prowcount
                    If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item("ProductID") = SSMS_DATABASEDataSet.Product.Rows(j).Item("ProductID") Then
                        SelectedBarcode = SSMS_DATABASEDataSet.Product.Rows(j).Item("BarcodeNumber")
                        If Pick_Info.SelectedItem.ToString.Contains(SelectedBarcode) Then
                            SlfCnt = SSMS_DATABASEDataSet.Product.Rows(j).Item("Shelf_Count")
                            MaxSlf = SSMS_DATABASEDataSet.Product.Rows(j).Item("Max_Shelf")
                            CasSiz = SSMS_DATABASEDataSet.Product.Rows(j).Item("Case_Size")
                            BinAmt = SSMS_DATABASEDataSet.Product.Rows(j).Item("Bin_Amount")
                            ProBinAmt = SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(3)

                            SlfCnt = SlfCnt + CasSiz
                            ProBinAmt = ProBinAmt - CasSiz

                            SSMS_DATABASEDataSet.Product.Rows(j).Item("Shelf_Count") = SlfCnt                                   'performs the calculation that picks the item and updates the dataset so that it is accurate.
                            SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(3) = ProBinAmt

                            For k = 0 To PBRowcount
                                If SSMS_DATABASEDataSet.Product_Bin.Rows(k).Item("ProductID") = SSMS_DATABASEDataSet.Product.Rows(j).Item("ProductID") Then
                                    TotalBinnedAmount = TotalBinnedAmount + SSMS_DATABASEDataSet.Product_Bin.Rows(k).Item(3)
                                End If
                            Next k

                            SSMS_DATABASEDataSet.Product.Rows(j).Item("Bin_Amount") = TotalBinnedAmount
                        End If
                    End If
                Next j
            End If
        Next i

        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        Me.Product_BinTableAdapter.Update(SSMS_DATABASEDataSet)

        CasTxt.Text = CasTxt.Text - 1
        TotTxt.Text = TotTxt.Text - CasSiz

        If CasTxt.Text = 0 Then
            Item_Info.Items.Clear()
            Pick_Info.Items.Remove(Pick_Info.SelectedItem)
        End If

    End Sub

    Private Sub BtnRem_Click(sender As Object, e As EventArgs) Handles BtnRem.Click
        Item_Info.Items.Clear()
        Pick_Info.Items.Remove(Pick_Info.SelectedItem)                              'removes the selected item from the picklist
    End Sub
End Class