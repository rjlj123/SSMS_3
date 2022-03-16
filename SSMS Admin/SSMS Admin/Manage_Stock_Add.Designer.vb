<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manage_Stock_Add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.SSMS_DATABASEDataSet = New SSMS_Admin.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.BarNumb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProdNme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Prc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Wgt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Unt = New System.Windows.Forms.ComboBox()
        Me.Flavr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ALoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DepBox = New System.Windows.Forms.ComboBox()
        Me.SubBox = New System.Windows.Forms.ComboBox()
        Me.CasSiz = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MinStk = New System.Windows.Forms.TextBox()
        Me.SalAvg = New System.Windows.Forms.TextBox()
        Me.MaxSlf = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter()
        Me.Sub_DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Nothing
        Me.TableAdapterManager.Count_VerificationTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(89, 124)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(118, 16)
        Me.Lbl1.TabIndex = 12
        Me.Lbl1.Text = "Barcode Number:"
        '
        'BarNumb
        '
        Me.BarNumb.Location = New System.Drawing.Point(213, 123)
        Me.BarNumb.Name = "BarNumb"
        Me.BarNumb.Size = New System.Drawing.Size(62, 20)
        Me.BarNumb.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Product Name:"
        '
        'ProdNme
        '
        Me.ProdNme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProdNme.Location = New System.Drawing.Point(196, 85)
        Me.ProdNme.Name = "ProdNme"
        Me.ProdNme.Size = New System.Drawing.Size(446, 20)
        Me.ProdNme.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Department:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sub-Department:"
        '
        'Prc
        '
        Me.Prc.Location = New System.Drawing.Point(350, 123)
        Me.Prc.Name = "Prc"
        Me.Prc.Size = New System.Drawing.Size(58, 20)
        Me.Prc.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "£"
        '
        'Wgt
        '
        Me.Wgt.Location = New System.Drawing.Point(483, 123)
        Me.Wgt.Name = "Wgt"
        Me.Wgt.Size = New System.Drawing.Size(49, 20)
        Me.Wgt.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Weight:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(538, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Unit:"
        '
        'Unt
        '
        Me.Unt.FormattingEnabled = True
        Me.Unt.Items.AddRange(New Object() {"g", "kg"})
        Me.Unt.Location = New System.Drawing.Point(580, 122)
        Me.Unt.Name = "Unt"
        Me.Unt.Size = New System.Drawing.Size(62, 21)
        Me.Unt.TabIndex = 26
        '
        'Flavr
        '
        Me.Flavr.Location = New System.Drawing.Point(360, 162)
        Me.Flavr.Name = "Flavr"
        Me.Flavr.Size = New System.Drawing.Size(86, 20)
        Me.Flavr.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(294, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Flavour:"
        '
        'ALoc
        '
        Me.ALoc.Location = New System.Drawing.Point(558, 162)
        Me.ALoc.Name = "ALoc"
        Me.ALoc.Size = New System.Drawing.Size(84, 20)
        Me.ALoc.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(452, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Ailse Location:"
        '
        'DepBox
        '
        Me.DepBox.FormattingEnabled = True
        Me.DepBox.Location = New System.Drawing.Point(178, 162)
        Me.DepBox.Name = "DepBox"
        Me.DepBox.Size = New System.Drawing.Size(110, 21)
        Me.DepBox.TabIndex = 31
        '
        'SubBox
        '
        Me.SubBox.FormattingEnabled = True
        Me.SubBox.Location = New System.Drawing.Point(211, 200)
        Me.SubBox.Name = "SubBox"
        Me.SubBox.Size = New System.Drawing.Size(110, 21)
        Me.SubBox.TabIndex = 32
        '
        'CasSiz
        '
        Me.CasSiz.Location = New System.Drawing.Point(408, 200)
        Me.CasSiz.Name = "CasSiz"
        Me.CasSiz.Size = New System.Drawing.Size(72, 20)
        Me.CasSiz.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(89, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Sales Average:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(277, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Max Shelf:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Min Stock:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(327, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Case Size:"
        '
        'MinStk
        '
        Me.MinStk.Location = New System.Drawing.Point(565, 200)
        Me.MinStk.Name = "MinStk"
        Me.MinStk.Size = New System.Drawing.Size(77, 20)
        Me.MinStk.TabIndex = 38
        '
        'SalAvg
        '
        Me.SalAvg.Location = New System.Drawing.Point(196, 239)
        Me.SalAvg.Name = "SalAvg"
        Me.SalAvg.Size = New System.Drawing.Size(72, 20)
        Me.SalAvg.TabIndex = 39
        '
        'MaxSlf
        '
        Me.MaxSlf.Location = New System.Drawing.Point(356, 239)
        Me.MaxSlf.Name = "MaxSlf"
        Me.MaxSlf.Size = New System.Drawing.Size(72, 20)
        Me.MaxSlf.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(92, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 70)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Add New Item"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(506, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 25)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Sub_DepartmentBindingSource
        '
        Me.Sub_DepartmentBindingSource.DataMember = "Sub_Department"
        Me.Sub_DepartmentBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Sub_DepartmentTableAdapter
        '
        Me.Sub_DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Manage_Stock_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(654, 509)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaxSlf)
        Me.Controls.Add(Me.SalAvg)
        Me.Controls.Add(Me.MinStk)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CasSiz)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SubBox)
        Me.Controls.Add(Me.DepBox)
        Me.Controls.Add(Me.ALoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Flavr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Unt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Wgt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Prc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProdNme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarNumb)
        Me.Controls.Add(Me.Lbl1)
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
        Me.Name = "Manage_Stock_Add"
        Me.Text = "Manage_Stock_Add"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Lbl1 As Label
    Friend WithEvents BarNumb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProdNme As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Prc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Wgt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Unt As ComboBox
    Friend WithEvents Flavr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ALoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DepBox As ComboBox
    Friend WithEvents SubBox As ComboBox
    Friend WithEvents CasSiz As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MinStk As TextBox
    Friend WithEvents SalAvg As TextBox
    Friend WithEvents MaxSlf As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Sub_DepartmentBindingSource As BindingSource
    Friend WithEvents Sub_DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter
End Class
