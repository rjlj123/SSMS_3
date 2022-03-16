<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Stock_Del
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
        Me.DelItems = New System.Windows.Forms.ListBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnClr = New System.Windows.Forms.Button()
        Me.SSMS_DATABASEDataSet = New SSMS_Admin.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DelItems
        '
        Me.DelItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelItems.FormattingEnabled = True
        Me.DelItems.ItemHeight = 18
        Me.DelItems.Location = New System.Drawing.Point(90, 64)
        Me.DelItems.Name = "DelItems"
        Me.DelItems.Size = New System.Drawing.Size(226, 418)
        Me.DelItems.TabIndex = 12
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnDel.ForeColor = System.Drawing.Color.White
        Me.BtnDel.Location = New System.Drawing.Point(322, 418)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(169, 64)
        Me.BtnDel.TabIndex = 13
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'BtnClr
        '
        Me.BtnClr.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnClr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClr.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnClr.ForeColor = System.Drawing.Color.White
        Me.BtnClr.Location = New System.Drawing.Point(322, 64)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(169, 29)
        Me.BtnClr.TabIndex = 14
        Me.BtnClr.Text = "Remove Item"
        Me.BtnClr.UseVisualStyleBackColor = False
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
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Manage_Stock_Del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(654, 509)
        Me.Controls.Add(Me.BtnClr)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.DelItems)
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
        Me.Name = "Manage_Stock_Del"
        Me.Text = "Manage_Stock_Del"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents DelItems As System.Windows.Forms.ListBox
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnClr As System.Windows.Forms.Button
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_Admin.SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
End Class
