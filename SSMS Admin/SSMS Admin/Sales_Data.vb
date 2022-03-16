Public Class Sales_Data
    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        LastForm = Me
        Me.Hide()
        Main_Menu.Show()
    End Sub
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        LastForm.Show()
    End Sub
    Private Sub Btn_Ref_Click(sender As Object, e As EventArgs) Handles Btn_Ref.Click
        Me.Refresh()
    End Sub
    Private Sub Btn_Pro_Click(sender As Object, e As EventArgs) Handles Btn_Pro.Click
        LastForm = Me
        Me.Hide()
        My_Profile.Show()
    End Sub
    Private Sub Btn_Log_Click(sender As Object, e As EventArgs) Handles Btn_Log.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub Btn_Staff_Click(sender As Object, e As EventArgs) Handles Btn_Staff.Click
        LastForm = Me
        Me.Hide()
        Manage_Staff.Show()
    End Sub

    Private Sub Btn_SIA_Click(sender As Object, e As EventArgs) Handles Btn_SIA.Click
        LastForm = Me
        Me.Hide()
        Manage_SIA.Show()
    End Sub

    Private Sub Btn_Stk_Click(sender As Object, e As EventArgs) Handles Btn_Stk.Click
        LastForm = Me
        Me.Hide()
        Manage_Stock.show()
    End Sub

    Private Sub Btn_Shp_Click(sender As Object, e As EventArgs) Handles Btn_Shp.Click
        LastForm = Me
        Me.Hide()
        Shop_Floor.show()
    End Sub

    Private Sub Btn_Data_Click(sender As Object, e As EventArgs) Handles Btn_Data.Click
        LastForm = Me
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Btn_BckRm_Click(sender As Object, e As EventArgs) Handles Btn_BckRm.Click
        LastForm = Me
        Me.Hide()
        Manage_Backroom.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LastForm = Me
        Me.Hide()
        Sales_Data_Order_Lists.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        LastForm = Me
        Me.Hide()
        Sales_Data_Sales_Average.Show()     'shows the sales data sales average form
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LastForm = Me
        Me.Hide()
        Sales_Data_Order_Lists.Show()       'shows the sales data order list form
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        LastForm = Me
        Me.Hide()
        Sales_Data_Sales_Average.Show()
    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_UserID.Text = UserID

    End Sub

End Class