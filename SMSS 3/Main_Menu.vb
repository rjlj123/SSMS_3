Public Class Main_Menu
    Dim rowcount As Integer
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the staff table of the database
        User_ID.Text = "User ID " & Global_Variables.UserID
        Lbl_ItmMan.Hide()
        Btn_ItmMan.Hide()

        rowcount = SSMS_DATABASEDataSet.Tables("Staff").Rows.Count - 1
        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(5) = Global_Variables.UserID Then
                If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(8) = "Y" Then                        'if the user has administrative privlages then they will be able to access more features than a regular user
                    Lbl_ItmMan.Show()
                    Btn_ItmMan.Show()
                End If
            End If
        Next i

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_log.Click
        Log_Out.Show()    'shows the log out form
    End Sub

    Private Sub Btn_Log_Click(sender As Object, e As EventArgs) Handles Btn_ItmMan.Click
        Me.Hide()
        Item_Management.Show()              'shows the item management form
    End Sub

    Private Sub Bnt_Sal_Click(sender As Object, e As EventArgs) Handles Bnt_Sal.Click
        Me.Hide()
        Item_Search.Show()              'shows the item search (sales floor) form
    End Sub

    Private Sub Btn_Cnt_Click(sender As Object, e As EventArgs) Handles Btn_Cnt.Click
        Me.Hide()
        Count_1.Show()                  'shows the count choice form
    End Sub

    Private Sub Btn_Cou_Click(sender As Object, e As EventArgs) Handles Btn_Cou.Click
        Me.Hide()
        Pick_1.Show()                   'shows the pick form
    End Sub

    Private Sub Btn_Bin_Click(sender As Object, e As EventArgs) Handles Btn_Bin.Click
        Me.Hide()
        Binning_1.Show()                'shows the binning choice form
    End Sub

End Class