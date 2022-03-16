Public Class Login
    Dim rowcount As Integer
    Dim userflag As Boolean
    Dim passflag As Boolean
    Dim correctflag As Boolean

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.SSMS_DATABASEDataSet.Staff) 'Allows the algorithm to search through the Staff table of the database
    End Sub

    Private Sub Lbl_Frgt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_Frgt.LinkClicked
        Me.Hide()
        Fgt_Pass.Show()     'Allows the user to view the forgotten password form
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        rowcount = SSMS_DATABASEDataSet.Tables("Staff").Rows.Count - 1

        If Txt_Pass.Text = "" Then MsgBox("Please enter a password.")
        If Txt_User.Text = "" Then MsgBox("Please enter a username.")

        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Staff.Rows(i).Item("Username") = Txt_User.Text Then
                userflag = True
                If SSMS_DATABASEDataSet.Staff.Rows(i).Item("Password") = Txt_Pass.Text Then 'validates the user's log in credentials
                    passflag = True
                    correctflag = True
                End If
            End If
        Next i

        For i = 0 To rowcount
            If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(5) = Txt_User.Text Then
                If SSMS_DATABASEDataSet.Tables("Staff").Rows(i).Item(8) = "N" Then
                    MsgBox("You do not have the level of access required to log on, please contact a manager for assistance.") 'Ensures that those without elevated privlages cannot log into the system
                    correctflag = False
                End If
            End If
        Next i

        If correctflag = True Then
            If userflag = True Then
                If passflag = True Then
                    Me.Hide()
                    Global_Variables.UserID = Txt_User.Text 'logs the user into the main menu
                    Main_Menu.Show()
                End If
            End If
        End If

        If userflag = False Then
            MsgBox("The username entered was not found, please try again.")
        Else
            If passflag = False Then
                MsgBox("The password entered was incorrect, please try again.") 'gives the user feedback if  their login cfredentials are incorrect
            End If
        End If
    End Sub
End Class