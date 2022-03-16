Public Class Binning_4
    Dim PBrowcount As Integer
    Dim Prowcount As Integer

    Private Sub Binning_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'this clears the bin and ensures that data throughout the dataset is valid
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'this clears the bin and ensures that data throughout the dataset is valid
        User_ID.Text = UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Binning_2.Show()                'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()                'shows the main menu form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim ItemID As Integer
        Dim BCodeFlag As Boolean
        Dim flag As Boolean = False
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBrowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        BCodeFlag = False

        For i = 0 To Prowcount
            If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = BCode.Text Then
                ItemID = SSMS_DATABASEDataSet.Product.Rows(i).Item("ProductID")
                BCodeFlag = True
                For j = 0 To PBrowcount
                    If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("BinID") = Bin_Number Then
                        If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("ProductID") = ItemID Then
                            Dim Binned_Amount As Integer = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3)             'adds the item to the dataset
                            Dim Case_Size As Integer = SSMS_DATABASEDataSet.Product.Rows(i).Item("Case_Size")
                            SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3) = (Binned_Amount + Case_Size)
                            flag = True

                        End If
                    End If
                Next j
                If flag = False Then
                    Dim NewPBRow As DataRow = SSMS_DATABASEDataSet.Product_Bin.NewRow()
                    NewPBRow("BinID") = Bin_Number
                    NewPBRow("ProductID") = ItemID
                    NewPBRow(3) = SSMS_DATABASEDataSet.Product.Rows(i).Item("Case_Size")
                    SSMS_DATABASEDataSet.Product_Bin.Rows.Add(NewPBRow)
                End If
            End If
        Next i

        If BCodeFlag = False Then
            MsgBox("Barcode number not found.")
        End If

    End Sub


    Private Sub Btn_Final_Click(sender As Object, e As EventArgs) Handles Btn_Final.Click
        Product_BinTableAdapter.Update(SSMS_DATABASEDataSet)   'updates the dataset so that it is accurate, this ensures that, if the form is exited, inputted data would not be saved unless finalise is chosen
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBrowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        Dim Binned_Amount As Integer
        Dim TotalBinnedAmount As Integer
        Dim ProductID As Integer

        For i = 0 To PBrowcount
            TotalBinnedAmount = 0
            ProductID = SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(2)
            For j = 0 To Prowcount
                If SSMS_DATABASEDataSet.Product.Rows(j).Item(0) = ProductID Then
                    Binned_Amount = SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(3)                'validates the dataset to ensure that all data kept is correct
                    TotalBinnedAmount = TotalBinnedAmount + Binned_Amount
                    SSMS_DATABASEDataSet.Product.Rows(j).Item(7) = TotalBinnedAmount
                End If
            Next j
        Next i



        MsgBox("Items Added.")
        Me.Hide()
        Binning_2.Show()

        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)
    End Sub

    Private Sub Btn_Loose_Click(sender As Object, e As EventArgs) Handles Btn_Loose.Click
        Dim ItemID As Integer
        Dim BCodeFlag As Boolean
        Dim Flag As Boolean = True
        Prowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBrowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1

        If IsNumeric(Los_Itm.Text) = False Then
            MsgBox("Please enter a valid number")
            Flag = False
        End If

        If Flag = True Then
            For i = 0 To Prowcount
                If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = BCode.Text Then
                    ItemID = SSMS_DATABASEDataSet.Product.Rows(i).Item("ProductID")
                    BCodeFlag = True
                    For j = 0 To PBrowcount
                        If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("BinID") = Bin_Number Then
                            If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item("ProductID") = ItemID Then
                                Dim Binned_Amount As Integer = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3)             'adds the loose items to the dataset
                                SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3) = (Binned_Amount + Los_Itm.Text)
                            End If
                        End If
                    Next j
                End If
            Next i
        End If
    End Sub

    Private Sub Los_Itm_TextChanged(sender As Object, e As EventArgs) Handles Los_Itm.TextChanged
        Lbl_Qua.Hide()

        If IsNumeric(Los_Itm.Text) = True Then
            If Los_Itm.Text > 15 Then
                Lbl_Qua.Show()
            End If
        End If
    End Sub
End Class