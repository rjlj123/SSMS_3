﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Staff_New
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.First_NameLabel = New System.Windows.Forms.Label()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Btn_Staff = New System.Windows.Forms.Button()
        Me.Btn_SIA = New System.Windows.Forms.Button()
        Me.Btn_Stk = New System.Windows.Forms.Button()
        Me.Btn_Shp = New System.Windows.Forms.Button()
        Me.Btn_Data = New System.Windows.Forms.Button()
        Me.Btn_BckRm = New System.Windows.Forms.Button()
        Me.Lbl_UserID = New System.Windows.Forms.RichTextBox()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.Btn_Ref = New System.Windows.Forms.Button()
        Me.Btn_Log = New System.Windows.Forms.Button()
        Me.Btn_Pro = New System.Windows.Forms.Button()
        Me.SSMS_DATABASEDataSet = New SSMS_Admin.SSMS_DATABASEDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.UserNme = New System.Windows.Forms.TextBox()
        Me.PassWrd = New System.Windows.Forms.TextBox()
        Me.RePassWrd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        Me.First_NameLabel.AutoSize = True
        Me.First_NameLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameLabel.Location = New System.Drawing.Point(104, 74)
        Me.First_NameLabel.Name = "First_NameLabel"
        Me.First_NameLabel.Size = New System.Drawing.Size(84, 17)
        Me.First_NameLabel.TabIndex = 13
        Me.First_NameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.SurnameLabel.Location = New System.Drawing.Point(115, 114)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(72, 17)
        Me.SurnameLabel.TabIndex = 14
        Me.SurnameLabel.Text = "Surname:"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DepartmentLabel.Location = New System.Drawing.Point(98, 156)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(89, 17)
        Me.DepartmentLabel.TabIndex = 16
        Me.DepartmentLabel.Text = "Department:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.UsernameLabel.Location = New System.Drawing.Point(107, 199)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(80, 17)
        Me.UsernameLabel.TabIndex = 18
        Me.UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.PasswordLabel.Location = New System.Drawing.Point(109, 241)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(78, 17)
        Me.PasswordLabel.TabIndex = 20
        Me.PasswordLabel.Text = "Password:"
        '
        'Btn_Staff
        '
        Me.Btn_Staff.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Staff.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Staff.ForeColor = System.Drawing.Color.White
        Me.Btn_Staff.Location = New System.Drawing.Point(2, 56)
        Me.Btn_Staff.Name = "Btn_Staff"
        Me.Btn_Staff.Size = New System.Drawing.Size(70, 70)
        Me.Btn_Staff.TabIndex = 0
        Me.Btn_Staff.Text = "Manage Staff"
        Me.Btn_Staff.UseVisualStyleBackColor = False
        '
        'Btn_SIA
        '
        Me.Btn_SIA.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SIA.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_SIA.ForeColor = System.Drawing.Color.White
        Me.Btn_SIA.Location = New System.Drawing.Point(2, 132)
        Me.Btn_SIA.Name = "Btn_SIA"
        Me.Btn_SIA.Size = New System.Drawing.Size(70, 70)
        Me.Btn_SIA.TabIndex = 1
        Me.Btn_SIA.Text = "SIA"
        Me.Btn_SIA.UseVisualStyleBackColor = False
        '
        'Btn_Stk
        '
        Me.Btn_Stk.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Stk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stk.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Stk.ForeColor = System.Drawing.Color.White
        Me.Btn_Stk.Location = New System.Drawing.Point(2, 208)
        Me.Btn_Stk.Name = "Btn_Stk"
        Me.Btn_Stk.Size = New System.Drawing.Size(70, 70)
        Me.Btn_Stk.TabIndex = 2
        Me.Btn_Stk.Text = "Manage Stock"
        Me.Btn_Stk.UseVisualStyleBackColor = False
        '
        'Btn_Shp
        '
        Me.Btn_Shp.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Shp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Shp.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Shp.ForeColor = System.Drawing.Color.White
        Me.Btn_Shp.Location = New System.Drawing.Point(2, 284)
        Me.Btn_Shp.Name = "Btn_Shp"
        Me.Btn_Shp.Size = New System.Drawing.Size(70, 70)
        Me.Btn_Shp.TabIndex = 3
        Me.Btn_Shp.Text = "Shop Floor"
        Me.Btn_Shp.UseVisualStyleBackColor = False
        '
        'Btn_Data
        '
        Me.Btn_Data.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Data.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Data.ForeColor = System.Drawing.Color.White
        Me.Btn_Data.Location = New System.Drawing.Point(2, 360)
        Me.Btn_Data.Name = "Btn_Data"
        Me.Btn_Data.Size = New System.Drawing.Size(70, 70)
        Me.Btn_Data.TabIndex = 4
        Me.Btn_Data.Text = "Sales Data"
        Me.Btn_Data.UseVisualStyleBackColor = False
        '
        'Btn_BckRm
        '
        Me.Btn_BckRm.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_BckRm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BckRm.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Btn_BckRm.ForeColor = System.Drawing.Color.White
        Me.Btn_BckRm.Location = New System.Drawing.Point(2, 436)
        Me.Btn_BckRm.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_BckRm.Name = "Btn_BckRm"
        Me.Btn_BckRm.Size = New System.Drawing.Size(70, 70)
        Me.Btn_BckRm.TabIndex = 5
        Me.Btn_BckRm.Text = "Manage Backroom"
        Me.Btn_BckRm.UseVisualStyleBackColor = False
        '
        'Lbl_UserID
        '
        Me.Lbl_UserID.BackColor = System.Drawing.Color.LightGray
        Me.Lbl_UserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lbl_UserID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserID.Location = New System.Drawing.Point(406, 16)
        Me.Lbl_UserID.Name = "Lbl_UserID"
        Me.Lbl_UserID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_UserID.Size = New System.Drawing.Size(70, 18)
        Me.Lbl_UserID.TabIndex = 6
        Me.Lbl_UserID.Text = "USER ID"
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Back.ForeColor = System.Drawing.Color.White
        Me.Btn_Back.Location = New System.Drawing.Point(90, 8)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(70, 32)
        Me.Btn_Back.TabIndex = 7
        Me.Btn_Back.Text = "Back"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Btn_Home
        '
        Me.Btn_Home.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Home.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Home.ForeColor = System.Drawing.Color.White
        Me.Btn_Home.Location = New System.Drawing.Point(2, 8)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(70, 32)
        Me.Btn_Home.TabIndex = 8
        Me.Btn_Home.Text = "Home"
        Me.Btn_Home.UseVisualStyleBackColor = False
        '
        'Btn_Ref
        '
        Me.Btn_Ref.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Ref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ref.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Ref.ForeColor = System.Drawing.Color.White
        Me.Btn_Ref.Location = New System.Drawing.Point(178, 8)
        Me.Btn_Ref.Name = "Btn_Ref"
        Me.Btn_Ref.Size = New System.Drawing.Size(70, 32)
        Me.Btn_Ref.TabIndex = 9
        Me.Btn_Ref.Text = "Refresh"
        Me.Btn_Ref.UseVisualStyleBackColor = False
        '
        'Btn_Log
        '
        Me.Btn_Log.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Log.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Btn_Log.ForeColor = System.Drawing.Color.White
        Me.Btn_Log.Location = New System.Drawing.Point(572, 8)
        Me.Btn_Log.Name = "Btn_Log"
        Me.Btn_Log.Size = New System.Drawing.Size(70, 32)
        Me.Btn_Log.TabIndex = 10
        Me.Btn_Log.Text = "Log Out"
        Me.Btn_Log.UseVisualStyleBackColor = False
        '
        'Btn_Pro
        '
        Me.Btn_Pro.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pro.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Btn_Pro.ForeColor = System.Drawing.Color.White
        Me.Btn_Pro.Location = New System.Drawing.Point(482, 8)
        Me.Btn_Pro.Name = "Btn_Pro"
        Me.Btn_Pro.Size = New System.Drawing.Size(70, 32)
        Me.Btn_Pro.TabIndex = 11
        Me.Btn_Pro.Text = "My Profile"
        Me.Btn_Pro.UseVisualStyleBackColor = False
        '
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(101, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 70)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add Staff Member"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Manager?"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(194, 287)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(193, 156)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(100, 21)
        Me.Department.TabIndex = 26
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(194, 74)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 27
        '
        'Surname
        '
        Me.Surname.Location = New System.Drawing.Point(193, 114)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(100, 20)
        Me.Surname.TabIndex = 28
        '
        'UserNme
        '
        Me.UserNme.Location = New System.Drawing.Point(194, 199)
        Me.UserNme.Name = "UserNme"
        Me.UserNme.Size = New System.Drawing.Size(100, 20)
        Me.UserNme.TabIndex = 29
        '
        'PassWrd
        '
        Me.PassWrd.Location = New System.Drawing.Point(194, 241)
        Me.PassWrd.Name = "PassWrd"
        Me.PassWrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PassWrd.Size = New System.Drawing.Size(100, 20)
        Me.PassWrd.TabIndex = 30
        '
        'RePassWrd
        '
        Me.RePassWrd.Location = New System.Drawing.Point(464, 241)
        Me.RePassWrd.Name = "RePassWrd"
        Me.RePassWrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.RePassWrd.Size = New System.Drawing.Size(100, 20)
        Me.RePassWrd.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(321, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Re-Type Password:"
        '
        'Manage_Staff_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(645, 508)
        Me.Controls.Add(Me.RePassWrd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PassWrd)
        Me.Controls.Add(Me.UserNme)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.SurnameLabel)
        Me.Controls.Add(Me.First_NameLabel)
        Me.Controls.Add(Me.Btn_Pro)
        Me.Controls.Add(Me.Btn_Log)
        Me.Controls.Add(Me.Btn_Ref)
        Me.Controls.Add(Me.Btn_Home)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Lbl_UserID)
        Me.Controls.Add(Me.Btn_BckRm)
        Me.Controls.Add(Me.Btn_Data)
        Me.Controls.Add(Me.Btn_Shp)
        Me.Controls.Add(Me.Btn_Stk)
        Me.Controls.Add(Me.Btn_SIA)
        Me.Controls.Add(Me.Btn_Staff)
        Me.MaximizeBox = False
        Me.Name = "Manage_Staff_New"
        Me.Text = "Manage_Staff_New"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Staff As Button
    Friend WithEvents Btn_SIA As Button
    Friend WithEvents Btn_Stk As Button
    Friend WithEvents Btn_Shp As Button
    Friend WithEvents Btn_Data As Button
    Friend WithEvents Btn_BckRm As Button
    Friend WithEvents Lbl_UserID As RichTextBox
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Btn_Home As Button
    Friend WithEvents Btn_Ref As Button
    Friend WithEvents Btn_Log As Button
    Friend WithEvents Btn_Pro As Button
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents First_NameLabel As Label
    Friend WithEvents SurnameLabel As Label
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Department As System.Windows.Forms.ComboBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents UserNme As System.Windows.Forms.TextBox
    Friend WithEvents PassWrd As System.Windows.Forms.TextBox
    Friend WithEvents RePassWrd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
