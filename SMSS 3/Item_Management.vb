Public Class Item_Management
    Private Sub Btn_Bin_Click(sender As Object, e As EventArgs) Handles Btn_Bin.Click
        Me.Hide()
        Add_Item.Show() 'navigates to the add items form
    End Sub

    Private Sub Bnt_Sal_Click(sender As Object, e As EventArgs) Handles Bnt_Sal.Click
        Me.Hide()
        Del_Item.Show() 'navigates to the delete items form
    End Sub

    Private Sub Home_Nav_Click(sender As Object, e As EventArgs) Handles Home_Nav.Click
        Me.Hide()
        Main_Menu.Show() 'navigates to the main menu
    End Sub

    Private Sub Back_Nav_Click(sender As Object, e As EventArgs) Handles Back_Nav.Click
        Me.Hide()
        Main_Menu.Show() 'backwards navigation
    End Sub

    Private Sub Item_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User_ID.Text = "User ID: " & UserID
        Back_Nav.Parent = Banner_Box
        Home_Nav.Parent = Banner_Box
    End Sub

End Class