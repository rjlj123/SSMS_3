Public Class Binning_3
    Dim PRowcount As Integer
    Dim PBRowcount As Integer
    Dim ProductID As Integer
    Dim BinnedAmount As Integer
    Dim TotalBinnedAmount As Integer

    Private Sub Binning_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        Me.Product_BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product_Bin) 'allows the algorithm to search through the product bin table of the database 
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1

        For i = 0 To PBRowcount
            If SSMS_DATABASEDataSet.Product_Bin.Rows(i).Item(1) = Bin_Number Then
                SSMS_DATABASEDataSet.Product_Bin.Rows(i).Delete()
            End If
        Next i                                                                                      'this clears the bin and ensures that data throughout the dataset is valid
        Me.Product_BinTableAdapter.Update(SSMS_DATABASEDataSet)

        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        PBRowcount = SSMS_DATABASEDataSet.Product_Bin.Rows.Count - 1
        For i = 0 To PRowcount
            ProductID = SSMS_DATABASEDataSet.Product.Rows(i).Item(0)
            For j = 0 To PBRowcount
                If SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(2) = ProductID Then
                    BinnedAmount = SSMS_DATABASEDataSet.Product_Bin.Rows(j).Item(3)
                    TotalBinnedAmount = TotalBinnedAmount + BinnedAmount
                End If
            Next j
            SSMS_DATABASEDataSet.Product.Rows(i).Item(7) = BinnedAmount
            ProductTableAdapter.Update(SSMS_DATABASEDataSet)
        Next i

        Me.Hide()
        Binning_2.Hide()
        Binning_1.Show()
    End Sub
End Class