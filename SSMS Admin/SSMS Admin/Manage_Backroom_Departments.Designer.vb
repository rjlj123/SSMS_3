﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Backroom_Departments
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
        Me.AddSubDep = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddSubDepBox = New System.Windows.Forms.TextBox()
        Me.AddDep = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddDepBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RmvDep = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RmvSubDep = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddDepTxt = New System.Windows.Forms.RichTextBox()
        Me.RmvDepTxt = New System.Windows.Forms.RichTextBox()
        Me.AddSubDepTxt = New System.Windows.Forms.RichTextBox()
        Me.RmvSubDepTxt = New System.Windows.Forms.RichTextBox()
        Me.SSMS_DATABASEDataSet = New SSMS_Admin.SSMS_DATABASEDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter()
        Me.TableAdapterManager = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Sub_DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter()
        Me.Sub_DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RmvSubDepDepBox = New System.Windows.Forms.ComboBox()
        Me.AddSubDepDepBox = New System.Windows.Forms.ComboBox()
        Me.RmvDepBox = New System.Windows.Forms.ComboBox()
        Me.RmvSubDepBox = New System.Windows.Forms.ComboBox()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AddSubDep
        '
        Me.AddSubDep.BackColor = System.Drawing.Color.SteelBlue
        Me.AddSubDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSubDep.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.AddSubDep.ForeColor = System.Drawing.Color.White
        Me.AddSubDep.Location = New System.Drawing.Point(530, 191)
        Me.AddSubDep.Name = "AddSubDep"
        Me.AddSubDep.Size = New System.Drawing.Size(100, 41)
        Me.AddSubDep.TabIndex = 20
        Me.AddSubDep.Text = "Add"
        Me.AddSubDep.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Add Sub-Department"
        '
        'AddSubDepBox
        '
        Me.AddSubDepBox.Location = New System.Drawing.Point(530, 152)
        Me.AddSubDepBox.Name = "AddSubDepBox"
        Me.AddSubDepBox.Size = New System.Drawing.Size(100, 20)
        Me.AddSubDepBox.TabIndex = 17
        '
        'AddDep
        '
        Me.AddDep.BackColor = System.Drawing.Color.SteelBlue
        Me.AddDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddDep.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.AddDep.ForeColor = System.Drawing.Color.White
        Me.AddDep.Location = New System.Drawing.Point(233, 161)
        Me.AddDep.Name = "AddDep"
        Me.AddDep.Size = New System.Drawing.Size(100, 41)
        Me.AddDep.TabIndex = 24
        Me.AddDep.Text = "Add"
        Me.AddDep.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Department Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Add Department"
        '
        'AddDepBox
        '
        Me.AddDepBox.Location = New System.Drawing.Point(233, 124)
        Me.AddDepBox.Name = "AddDepBox"
        Me.AddDepBox.Size = New System.Drawing.Size(100, 20)
        Me.AddDepBox.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(351, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sub-Department Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(351, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Sub-Department Name:"
        '
        'RmvDep
        '
        Me.RmvDep.BackColor = System.Drawing.Color.SteelBlue
        Me.RmvDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RmvDep.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RmvDep.ForeColor = System.Drawing.Color.White
        Me.RmvDep.Location = New System.Drawing.Point(233, 360)
        Me.RmvDep.Name = "RmvDep"
        Me.RmvDep.Size = New System.Drawing.Size(100, 41)
        Me.RmvDep.TabIndex = 32
        Me.RmvDep.Text = "Remove"
        Me.RmvDep.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Department Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Remove Department"
        '
        'RmvSubDep
        '
        Me.RmvSubDep.BackColor = System.Drawing.Color.SteelBlue
        Me.RmvSubDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RmvSubDep.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RmvSubDep.ForeColor = System.Drawing.Color.White
        Me.RmvSubDep.Location = New System.Drawing.Point(530, 389)
        Me.RmvSubDep.Name = "RmvSubDep"
        Me.RmvSubDep.Size = New System.Drawing.Size(100, 41)
        Me.RmvSubDep.TabIndex = 28
        Me.RmvSubDep.Text = "Remove"
        Me.RmvSubDep.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Remove Sub-Department"
        '
        'AddDepTxt
        '
        Me.AddDepTxt.BackColor = System.Drawing.Color.LightGray
        Me.AddDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddDepTxt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDepTxt.Location = New System.Drawing.Point(90, 161)
        Me.AddDepTxt.Name = "AddDepTxt"
        Me.AddDepTxt.Size = New System.Drawing.Size(120, 44)
        Me.AddDepTxt.TabIndex = 34
        Me.AddDepTxt.Text = ""
        '
        'RmvDepTxt
        '
        Me.RmvDepTxt.BackColor = System.Drawing.Color.LightGray
        Me.RmvDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RmvDepTxt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RmvDepTxt.Location = New System.Drawing.Point(90, 360)
        Me.RmvDepTxt.Name = "RmvDepTxt"
        Me.RmvDepTxt.Size = New System.Drawing.Size(120, 44)
        Me.RmvDepTxt.TabIndex = 35
        Me.RmvDepTxt.Text = ""
        '
        'AddSubDepTxt
        '
        Me.AddSubDepTxt.BackColor = System.Drawing.Color.LightGray
        Me.AddSubDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddSubDepTxt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubDepTxt.Location = New System.Drawing.Point(354, 191)
        Me.AddSubDepTxt.Name = "AddSubDepTxt"
        Me.AddSubDepTxt.Size = New System.Drawing.Size(120, 44)
        Me.AddSubDepTxt.TabIndex = 36
        Me.AddSubDepTxt.Text = ""
        '
        'RmvSubDepTxt
        '
        Me.RmvSubDepTxt.BackColor = System.Drawing.Color.LightGray
        Me.RmvSubDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RmvSubDepTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RmvSubDepTxt.Location = New System.Drawing.Point(354, 389)
        Me.RmvSubDepTxt.Name = "RmvSubDepTxt"
        Me.RmvSubDepTxt.Size = New System.Drawing.Size(120, 44)
        Me.RmvSubDepTxt.TabIndex = 37
        Me.RmvSubDepTxt.Text = ""
        '
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Nothing
        Me.TableAdapterManager.Count_VerificationTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Me.DepartmentTableAdapter
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Me.Sub_DepartmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sub_DepartmentTableAdapter
        '
        Me.Sub_DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Sub_DepartmentBindingSource
        '
        Me.Sub_DepartmentBindingSource.DataMember = "Sub_Department"
        Me.Sub_DepartmentBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Department Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Department Name:"
        '
        'RmvSubDepDepBox
        '
        Me.RmvSubDepDepBox.FormattingEnabled = True
        Me.RmvSubDepDepBox.Location = New System.Drawing.Point(530, 322)
        Me.RmvSubDepDepBox.Name = "RmvSubDepDepBox"
        Me.RmvSubDepDepBox.Size = New System.Drawing.Size(100, 21)
        Me.RmvSubDepDepBox.TabIndex = 42
        '
        'AddSubDepDepBox
        '
        Me.AddSubDepDepBox.FormattingEnabled = True
        Me.AddSubDepDepBox.Location = New System.Drawing.Point(530, 122)
        Me.AddSubDepDepBox.Name = "AddSubDepDepBox"
        Me.AddSubDepDepBox.Size = New System.Drawing.Size(100, 21)
        Me.AddSubDepDepBox.TabIndex = 43
        '
        'RmvDepBox
        '
        Me.RmvDepBox.FormattingEnabled = True
        Me.RmvDepBox.Location = New System.Drawing.Point(233, 322)
        Me.RmvDepBox.Name = "RmvDepBox"
        Me.RmvDepBox.Size = New System.Drawing.Size(100, 21)
        Me.RmvDepBox.TabIndex = 44
        '
        'RmvSubDepBox
        '
        Me.RmvSubDepBox.FormattingEnabled = True
        Me.RmvSubDepBox.Location = New System.Drawing.Point(530, 349)
        Me.RmvSubDepBox.Name = "RmvSubDepBox"
        Me.RmvSubDepBox.Size = New System.Drawing.Size(100, 21)
        Me.RmvSubDepBox.TabIndex = 45
        '
        'Manage_Backroom_Departments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(654, 509)
        Me.Controls.Add(Me.RmvSubDepBox)
        Me.Controls.Add(Me.RmvDepBox)
        Me.Controls.Add(Me.AddSubDepDepBox)
        Me.Controls.Add(Me.RmvSubDepDepBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RmvSubDepTxt)
        Me.Controls.Add(Me.AddSubDepTxt)
        Me.Controls.Add(Me.RmvDepTxt)
        Me.Controls.Add(Me.AddDepTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RmvDep)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RmvSubDep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddDep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AddDepBox)
        Me.Controls.Add(Me.AddSubDep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddSubDepBox)
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
        Me.Name = "Manage_Backroom_Departments"
        Me.Text = "Manage_Backroom_Departments"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sub_DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AddSubDep As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AddSubDepBox As TextBox
    Friend WithEvents AddDep As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AddDepBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RmvDep As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RmvSubDep As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AddDepTxt As RichTextBox
    Friend WithEvents RmvDepTxt As RichTextBox
    Friend WithEvents AddSubDepTxt As RichTextBox
    Friend WithEvents RmvSubDepTxt As RichTextBox
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sub_DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter
    Friend WithEvents Sub_DepartmentBindingSource As BindingSource
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RmvSubDepDepBox As ComboBox
    Friend WithEvents AddSubDepDepBox As ComboBox
    Friend WithEvents RmvDepBox As ComboBox
    Friend WithEvents RmvSubDepBox As ComboBox
End Class
