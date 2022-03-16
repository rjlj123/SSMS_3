<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shop_Floor_Price_Changes
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
        Me.ConPri = New System.Windows.Forms.Button()
        Me.ProDet = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurPri = New System.Windows.Forms.TextBox()
        Me.NewPri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProChk = New System.Windows.Forms.CheckBox()
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
        'ConPri
        '
        Me.ConPri.BackColor = System.Drawing.Color.SteelBlue
        Me.ConPri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConPri.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ConPri.ForeColor = System.Drawing.Color.White
        Me.ConPri.Location = New System.Drawing.Point(483, 159)
        Me.ConPri.Name = "ConPri"
        Me.ConPri.Size = New System.Drawing.Size(102, 43)
        Me.ConPri.TabIndex = 12
        Me.ConPri.Text = "Confirm"
        Me.ConPri.UseVisualStyleBackColor = False
        '
        'ProDet
        '
        Me.ProDet.BackColor = System.Drawing.Color.LightGray
        Me.ProDet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProDet.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ProDet.HorizontalScrollbar = True
        Me.ProDet.ItemHeight = 15
        Me.ProDet.Location = New System.Drawing.Point(217, 95)
        Me.ProDet.Name = "ProDet"
        Me.ProDet.Size = New System.Drawing.Size(131, 135)
        Me.ProDet.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Barcode Number:"
        '
        'BarNum
        '
        Me.BarNum.Location = New System.Drawing.Point(217, 69)
        Me.BarNum.Name = "BarNum"
        Me.BarNum.Size = New System.Drawing.Size(131, 20)
        Me.BarNum.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Current Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "New Price:"
        '
        'CurPri
        '
        Me.CurPri.BackColor = System.Drawing.Color.White
        Me.CurPri.Location = New System.Drawing.Point(502, 69)
        Me.CurPri.Name = "CurPri"
        Me.CurPri.ReadOnly = True
        Me.CurPri.Size = New System.Drawing.Size(82, 20)
        Me.CurPri.TabIndex = 19
        '
        'NewPri
        '
        Me.NewPri.Location = New System.Drawing.Point(502, 95)
        Me.NewPri.Name = "NewPri"
        Me.NewPri.Size = New System.Drawing.Size(82, 20)
        Me.NewPri.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "£"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "£"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(414, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Promo?"
        '
        'ProChk
        '
        Me.ProChk.AutoSize = True
        Me.ProChk.Location = New System.Drawing.Point(483, 124)
        Me.ProChk.Name = "ProChk"
        Me.ProChk.Size = New System.Drawing.Size(15, 14)
        Me.ProChk.TabIndex = 24
        Me.ProChk.UseVisualStyleBackColor = True
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
        'Shop_Floor_Price_Changes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SSMS_Admin.My.Resources.Resources.Potential_Background
        Me.ClientSize = New System.Drawing.Size(654, 509)
        Me.Controls.Add(Me.ProChk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NewPri)
        Me.Controls.Add(Me.CurPri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BarNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProDet)
        Me.Controls.Add(Me.ConPri)
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
        Me.Name = "Shop_Floor_Price_Changes"
        Me.Text = "Shop_Floor_Price_Changes"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ConPri As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BarNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CurPri As TextBox
    Friend WithEvents NewPri As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProDet As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProChk As CheckBox
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
End Class

