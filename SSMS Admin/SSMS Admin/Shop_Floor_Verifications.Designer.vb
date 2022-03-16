<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop_Floor_Verifications
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
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim BarcodeNumberLabel As System.Windows.Forms.Label
        Dim ShelfCountLabel As System.Windows.Forms.Label
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
        Me.Count_VerificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Count_VerificationTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Count_VerificationTableAdapter()
        Me.SubDeps = New System.Windows.Forms.ComboBox()
        Me.Count_Verify = New System.Windows.Forms.ListBox()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.BtnAll = New System.Windows.Forms.Button()
        Me.Sub_DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_DepartmentTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter()
        Me.ProdNmeTxt = New System.Windows.Forms.TextBox()
        Me.BarNumTxt = New System.Windows.Forms.TextBox()
        Me.SlfCntTxt = New System.Windows.Forms.TextBox()
        Product_NameLabel = New System.Windows.Forms.Label()
        BarcodeNumberLabel = New System.Windows.Forms.Label()
        ShelfCountLabel = New System.Windows.Forms.Label()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Count_VerificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        Product_NameLabel.Location = New System.Drawing.Point(312, 101)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(101, 16)
        Product_NameLabel.TabIndex = 14
        Product_NameLabel.Text = "Product Name:"
        '
        'BarcodeNumberLabel
        '
        BarcodeNumberLabel.AutoSize = True
        BarcodeNumberLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        BarcodeNumberLabel.Location = New System.Drawing.Point(302, 125)
        BarcodeNumberLabel.Name = "BarcodeNumberLabel"
        BarcodeNumberLabel.Size = New System.Drawing.Size(118, 16)
        BarcodeNumberLabel.TabIndex = 16
        BarcodeNumberLabel.Text = "Barcode Number:"
        '
        'ShelfCountLabel
        '
        ShelfCountLabel.AutoSize = True
        ShelfCountLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        ShelfCountLabel.Location = New System.Drawing.Point(327, 151)
        ShelfCountLabel.Name = "ShelfCountLabel"
        ShelfCountLabel.Size = New System.Drawing.Size(86, 16)
        ShelfCountLabel.TabIndex = 18
        ShelfCountLabel.Text = "Shelf Count:"
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
        'Count_VerificationBindingSource
        '
        Me.Count_VerificationBindingSource.DataMember = "Count_Verification"
        Me.Count_VerificationBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Count_VerificationTableAdapter
        '
        Me.Count_VerificationTableAdapter.ClearBeforeFill = True
        '
        'SubDeps
        '
        Me.SubDeps.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.SubDeps.FormattingEnabled = True
        Me.SubDeps.Location = New System.Drawing.Point(90, 66)
        Me.SubDeps.Name = "SubDeps"
        Me.SubDeps.Size = New System.Drawing.Size(203, 24)
        Me.SubDeps.TabIndex = 12
        '
        'Count_Verify
        '
        Me.Count_Verify.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Count_Verify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Count_Verify.FormattingEnabled = True
        Me.Count_Verify.ItemHeight = 16
        Me.Count_Verify.Location = New System.Drawing.Point(90, 99)
        Me.Count_Verify.Name = "Count_Verify"
        Me.Count_Verify.Size = New System.Drawing.Size(203, 404)
        Me.Count_Verify.TabIndex = 13
        '
        'BtnVer
        '
        Me.BtnVer.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVer.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnVer.ForeColor = System.Drawing.Color.White
        Me.BtnVer.Location = New System.Drawing.Point(426, 187)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(100, 39)
        Me.BtnVer.TabIndex = 20
        Me.BtnVer.Text = "Verify"
        Me.BtnVer.UseVisualStyleBackColor = False
        '
        'BtnAll
        '
        Me.BtnAll.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAll.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnAll.ForeColor = System.Drawing.Color.White
        Me.BtnAll.Location = New System.Drawing.Point(315, 269)
        Me.BtnAll.Name = "BtnAll"
        Me.BtnAll.Size = New System.Drawing.Size(211, 54)
        Me.BtnAll.TabIndex = 21
        Me.BtnAll.Text = "Verify All"
        Me.BtnAll.UseVisualStyleBackColor = False
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
        'ProdNmeTxt
        '
        Me.ProdNmeTxt.BackColor = System.Drawing.Color.White
        Me.ProdNmeTxt.Location = New System.Drawing.Point(426, 100)
        Me.ProdNmeTxt.Name = "ProdNmeTxt"
        Me.ProdNmeTxt.ReadOnly = True
        Me.ProdNmeTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProdNmeTxt.TabIndex = 22
        '
        'BarNumTxt
        '
        Me.BarNumTxt.BackColor = System.Drawing.Color.White
        Me.BarNumTxt.Location = New System.Drawing.Point(426, 125)
        Me.BarNumTxt.Name = "BarNumTxt"
        Me.BarNumTxt.ReadOnly = True
        Me.BarNumTxt.Size = New System.Drawing.Size(100, 20)
        Me.BarNumTxt.TabIndex = 23
        '
        'SlfCntTxt
        '
        Me.SlfCntTxt.Location = New System.Drawing.Point(426, 150)
        Me.SlfCntTxt.Name = "SlfCntTxt"
        Me.SlfCntTxt.Size = New System.Drawing.Size(100, 20)
        Me.SlfCntTxt.TabIndex = 24
        '
        'Shop_Floor_Verifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(654, 509)
        Me.Controls.Add(Me.SlfCntTxt)
        Me.Controls.Add(Me.BarNumTxt)
        Me.Controls.Add(Me.ProdNmeTxt)
        Me.Controls.Add(Me.BtnAll)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(ShelfCountLabel)
        Me.Controls.Add(BarcodeNumberLabel)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Count_Verify)
        Me.Controls.Add(Me.SubDeps)
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
        Me.Name = "Shop_Floor_Verifications"
        Me.Text = "Shop_Floor_Verifications"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Count_VerificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_Admin.SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Count_VerificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Count_VerificationTableAdapter As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Count_VerificationTableAdapter
    Friend WithEvents SubDeps As System.Windows.Forms.ComboBox
    Friend WithEvents Count_Verify As System.Windows.Forms.ListBox
    Friend WithEvents BtnVer As System.Windows.Forms.Button
    Friend WithEvents BtnAll As System.Windows.Forms.Button
    Friend WithEvents Sub_DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_DepartmentTableAdapter As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter
    Friend WithEvents ProdNmeTxt As System.Windows.Forms.TextBox
    Friend WithEvents BarNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents SlfCntTxt As System.Windows.Forms.TextBox
End Class
