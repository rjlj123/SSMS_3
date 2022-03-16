Public Class Binning_1
    Dim rowcount As Integer
    Dim flag As Boolean
    Private Sub Binning_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BinTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Bin) 'allows the algorithm to search through the bin table of the database 
        User_ID.Text = UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box

    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Main_Menu.Show()        'backwards navigation
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show()        'returns the user to the main menu
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Enter.Click
        rowcount = SSMS_DATABASEDataSet.Tables("Bin").Rows.Count - 1
        flag = False
        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Bin.Rows(i).Item(0) = BinNumb.Text Then
                SubDep = SSMS_DATABASEDataSet.Bin.Rows(i).Item(0)
                Bin_Number = BinNumb.Text
                Me.Hide()
                Binning_2.Show()                                                                'searches the algorithm to find the user specifies bin
                flag = True
            End If
        Next

        If flag = False Then
            MsgBox("Bin ID not found. Please try again.")
        End If
    End Sub

End Class