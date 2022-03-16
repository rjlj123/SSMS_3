Public Class Del_Item
    Dim PRowcount As Integer
    Dim flag As Boolean

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()            'shows the main menu form
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Item_Management.Show()      'backwards navigation
    End Sub

    Private Sub Del_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(SSMS_DATABASEDataSet.Product) 'allows the algorithm to search through the product table of the database

        User_ID.Text = "User ID: " & UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box
    End Sub

    Private Sub Btn_Sub_Click(sender As Object, e As EventArgs) Handles Btn_Sub.Click
        PRowcount = SSMS_DATABASEDataSet.Tables("Product").Rows.Count - 1
        flag = True

        If IsNumeric(BarNumb.Text) = False Then
            flag = False
            MsgBox("Please enter a valid barcode number.")    'validates the entered barcode number
        End If


        If flag = True Then
            For i = 0 To PRowcount
                If SSMS_DATABASEDataSet.Product.Rows(i).Item("BarcodeNumber") = BarNumb.Text Then
                    SSMS_DATABASEDataSet.Product.Rows(i).Item("Removed") = "Yes"                           'marks the product for deletion
                    MsgBox("Item set for removal.")
                Else
                    flag = False
                End If
            Next i
        End If

        If flag = False Then
            MsgBox("Item barcode not found.")
        End If

        Me.ProductTableAdapter.Update(SSMS_DATABASEDataSet)

    End Sub

End Class