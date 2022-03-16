Public Class Item_Search
    Dim PRowcount As Integer
    Dim flag As Boolean
    
    Private Sub Item_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database

        User_ID.Text = "User ID: " & UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'shows the main menu form
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        PRowcount = SSMS_DATABASEDataSet.Product.Rows.Count - 1
        flag = False

        If IsNumeric(BarNumb.Text) = True Then
            For i = 0 To PRowcount
                If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = BarNumb.Text Then
                    BarcodeNumber = BarNumb.Text
                    searchterm = i                                                                  'displays the sales floor tool if the product is found
                    flag = True
                    Me.Hide()
                    Sales_Floor.Show()
                End If
            Next i
        Else
            MsgBox("Please enter a valid barcode number.")
        End If

        If flag = False Then
            MsgBox("Barcode number not found.")                                                 'provides the user with feedback if the barcode number isn't found.
        End If
    End Sub

End Class