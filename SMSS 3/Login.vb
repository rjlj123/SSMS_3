Public Class Login
    Dim rowcount As Integer
    Dim userflag As Boolean
    Dim passflag As Boolean
    Dim correctflag As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit.Click

        rowcount = SSMS_DATABASEDataSet.Tables("Staff").Rows.Count - 1

        If Txt_Pass.Text = "" Then MsgBox("Please enter a password.")
        If Txt_User.Text = "" Then MsgBox("Please enter a username.")

        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(5) = Txt_User.Text Then
                userflag = True
                If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(6) = Txt_Pass.Text Then                'verifies the users login credentials
                    passflag = True
                End If
            End If
        Next i

        If userflag = True Then
            If passflag = True Then                                                             'logs the user into the system
                Me.Hide()
                Global_Variables.UserID = Txt_User.Text
                Main_Menu.Show()
            End If
        End If

        If userflag = False Then
            MsgBox("The username entered was not found, please try again.")
        Else
            If passflag = False Then                                                            'provides the user with feedback about the incoreect login
                MsgBox("The password entered was incorrect, please try again.")
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'allows the algorithm to search through the staff table of the database
    End Sub

    Private Sub Lbl_Frgt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_Frgt.LinkClicked
        Me.Hide()
        Fgt_Pass.Show()     'navigates the user to the forgot password form
    End Sub
End Class
