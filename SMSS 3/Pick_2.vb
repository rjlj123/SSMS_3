Public Class Pick_2
    Dim rowcount As Integer
    Private Sub Pick_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        'TODO: This line of code loads data into the 'SSMS_DATABASEDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Product)
        User_ID.Text = "User ID: " & UserID
        Sub_Dep.Text = SubDep
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box

        rowcount = SSMS_DATABASEDataSet.Tables("Product").Rows.Count - 1
        For i = 0 To rowcount
            Dim Shelf_Count As Integer = SSMS_DATABASEDataSet.Tables("Product").Rows(i).Item(11)
            Dim Bin_Amount As Integer = SSMS_DATABASEDataSet.Tables("Product").Rows(i).Item(12)
            Dim Shelf_Max As Integer = SSMS_DATABASEDataSet.Tables("Product").Rows(i).Item(13)
            Dim Case_Size As Integer = SSMS_DATABASEDataSet.Tables("Product").Rows(i).Item(10)
            Dim Pick_Amount As Integer
            Dim Shelf_Space As Integer
            If Shelf_Count < Shelf_Max Then
                Shelf_Space = Shelf_Max - Shelf_Count
                For j = 0 To Bin_Amount
                    If Shelf_Space > Case_Size Then

                        Pick_Amount = Pick_Amount * (Bin_Amount / Case_Size)
                    End If
                    Pick_Info.Items.Add(SSMS_DATABASEDataSet.Tables("Product").Rows(i).Item(2))
                Next j
            End If
        Next i
    End Sub
    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Pick_1.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SSMS_DATABASEDataSet)

    End Sub
End Class