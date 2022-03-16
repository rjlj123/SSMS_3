<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Floor
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
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Pro = New System.Windows.Forms.TextBox()
        Me.Max = New System.Windows.Forms.TextBox()
        Me.Cas = New System.Windows.Forms.TextBox()
        Me.Ail = New System.Windows.Forms.TextBox()
        Me.ItmCol = New System.Windows.Forms.TextBox()
        Me.ItmSiz = New System.Windows.Forms.TextBox()
        Me.SubDep = New System.Windows.Forms.TextBox()
        Me.Dep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.RichTextBox()
        Me.Bin_Amt = New System.Windows.Forms.RichTextBox()
        Me.Nme = New System.Windows.Forms.TextBox()
        Me.BarNumb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BinNumb = New System.Windows.Forms.TextBox()
        Me.Product_BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order = New System.Windows.Forms.TextBox()
        Me.Avg = New System.Windows.Forms.TextBox()
        Me.MinAmt = New System.Windows.Forms.TextBox()
        Me.SIA = New System.Windows.Forms.TextBox()
        Me.Rmvd = New System.Windows.Forms.TextBox()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.Product_BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pro
        '
        Me.Pro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pro.Location = New System.Drawing.Point(135, 570)
        Me.Pro.Name = "Pro"
        Me.Pro.ReadOnly = True
        Me.Pro.Size = New System.Drawing.Size(120, 20)
        Me.Pro.TabIndex = 73
        '
        'Max
        '
        Me.Max.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Max.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Max.Location = New System.Drawing.Point(135, 516)
        Me.Max.Name = "Max"
        Me.Max.ReadOnly = True
        Me.Max.Size = New System.Drawing.Size(120, 20)
        Me.Max.TabIndex = 72
        '
        'Cas
        '
        Me.Cas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cas.Location = New System.Drawing.Point(135, 462)
        Me.Cas.Name = "Cas"
        Me.Cas.ReadOnly = True
        Me.Cas.Size = New System.Drawing.Size(120, 20)
        Me.Cas.TabIndex = 71
        '
        'Ail
        '
        Me.Ail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ail.Location = New System.Drawing.Point(135, 408)
        Me.Ail.Name = "Ail"
        Me.Ail.ReadOnly = True
        Me.Ail.Size = New System.Drawing.Size(120, 20)
        Me.Ail.TabIndex = 70
        '
        'ItmCol
        '
        Me.ItmCol.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItmCol.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItmCol.Location = New System.Drawing.Point(135, 354)
        Me.ItmCol.Name = "ItmCol"
        Me.ItmCol.ReadOnly = True
        Me.ItmCol.Size = New System.Drawing.Size(120, 20)
        Me.ItmCol.TabIndex = 69
        '
        'ItmSiz
        '
        Me.ItmSiz.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItmSiz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItmSiz.Location = New System.Drawing.Point(135, 300)
        Me.ItmSiz.Name = "ItmSiz"
        Me.ItmSiz.ReadOnly = True
        Me.ItmSiz.Size = New System.Drawing.Size(120, 20)
        Me.ItmSiz.TabIndex = 68
        '
        'SubDep
        '
        Me.SubDep.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubDep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubDep.Location = New System.Drawing.Point(135, 246)
        Me.SubDep.Name = "SubDep"
        Me.SubDep.ReadOnly = True
        Me.SubDep.Size = New System.Drawing.Size(120, 20)
        Me.SubDep.TabIndex = 67
        '
        'Dep
        '
        Me.Dep.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dep.Location = New System.Drawing.Point(135, 192)
        Me.Dep.Name = "Dep"
        Me.Dep.ReadOnly = True
        Me.Dep.Size = New System.Drawing.Size(120, 20)
        Me.Dep.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(12, 571)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 16)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "On Promo?:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(12, 517)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Max Shelf:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(12, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Case Size:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(12, 409)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Ailse Location(s):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Col/Fla:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(12, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Item Size/Weight:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Sub Department:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Department:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 22)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Bin Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Item Price:"
        '
        'Price
        '
        Me.Price.BackColor = System.Drawing.Color.White
        Me.Price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Price.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Price.Location = New System.Drawing.Point(119, 148)
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Size = New System.Drawing.Size(88, 34)
        Me.Price.TabIndex = 74
        Me.Price.Text = "£0.00"
        '
        'Bin_Amt
        '
        Me.Bin_Amt.BackColor = System.Drawing.Color.White
        Me.Bin_Amt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bin_Amt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bin_Amt.Location = New System.Drawing.Point(394, 148)
        Me.Bin_Amt.Multiline = False
        Me.Bin_Amt.Name = "Bin_Amt"
        Me.Bin_Amt.ReadOnly = True
        Me.Bin_Amt.Size = New System.Drawing.Size(88, 26)
        Me.Bin_Amt.TabIndex = 75
        Me.Bin_Amt.Text = "0"
        '
        'Nme
        '
        Me.Nme.BackColor = System.Drawing.Color.White
        Me.Nme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nme.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Nme.Location = New System.Drawing.Point(15, 118)
        Me.Nme.Name = "Nme"
        Me.Nme.ReadOnly = True
        Me.Nme.Size = New System.Drawing.Size(221, 19)
        Me.Nme.TabIndex = 76
        Me.Nme.Text = "Name"
        Me.Nme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BarNumb
        '
        Me.BarNumb.BackColor = System.Drawing.Color.White
        Me.BarNumb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BarNumb.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BarNumb.Location = New System.Drawing.Point(290, 118)
        Me.BarNumb.Name = "BarNumb"
        Me.BarNumb.ReadOnly = True
        Me.BarNumb.Size = New System.Drawing.Size(224, 19)
        Me.BarNumb.TabIndex = 77
        Me.BarNumb.Text = "Barcode"
        Me.BarNumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(287, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Bin Number(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(287, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "On Order:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(287, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Avg Sales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(287, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Min Stk Amt:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(287, 409)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 16)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "SIA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(287, 463)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Removed:"
        '
        'BinNumb
        '
        Me.BinNumb.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BinNumb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Product_BinBindingSource, "BinID", True))
        Me.BinNumb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BinNumb.Location = New System.Drawing.Point(394, 192)
        Me.BinNumb.Name = "BinNumb"
        Me.BinNumb.ReadOnly = True
        Me.BinNumb.Size = New System.Drawing.Size(120, 20)
        Me.BinNumb.TabIndex = 86
        '
        'Product_BinBindingSource
        '
        Me.Product_BinBindingSource.DataMember = "Product_Bin"
        Me.Product_BinBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Order
        '
        Me.Order.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Order.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order.Location = New System.Drawing.Point(394, 246)
        Me.Order.Name = "Order"
        Me.Order.ReadOnly = True
        Me.Order.Size = New System.Drawing.Size(120, 20)
        Me.Order.TabIndex = 87
        '
        'Avg
        '
        Me.Avg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Avg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Avg.Location = New System.Drawing.Point(394, 300)
        Me.Avg.Name = "Avg"
        Me.Avg.ReadOnly = True
        Me.Avg.Size = New System.Drawing.Size(120, 20)
        Me.Avg.TabIndex = 86
        '
        'MinAmt
        '
        Me.MinAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MinAmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinAmt.Location = New System.Drawing.Point(394, 354)
        Me.MinAmt.Name = "MinAmt"
        Me.MinAmt.ReadOnly = True
        Me.MinAmt.Size = New System.Drawing.Size(120, 20)
        Me.MinAmt.TabIndex = 87
        '
        'SIA
        '
        Me.SIA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SIA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIA.Location = New System.Drawing.Point(394, 408)
        Me.SIA.Name = "SIA"
        Me.SIA.ReadOnly = True
        Me.SIA.Size = New System.Drawing.Size(120, 20)
        Me.SIA.TabIndex = 86
        '
        'Rmvd
        '
        Me.Rmvd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Rmvd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rmvd.Location = New System.Drawing.Point(394, 462)
        Me.Rmvd.Name = "Rmvd"
        Me.Rmvd.ReadOnly = True
        Me.Rmvd.Size = New System.Drawing.Size(120, 20)
        Me.Rmvd.TabIndex = 87
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 23)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Home_Nav.TabIndex = 136
        Me.Home_Nav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 46)
        Me.PictureBox2.TabIndex = 135
        Me.PictureBox2.TabStop = False
        '
        'Back_Nav
        '
        Me.Back_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Back_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Back_Nav.Image = Global.SMSS_3.My.Resources.Resources._004_next_page
        Me.Back_Nav.Location = New System.Drawing.Point(12, 23)
        Me.Back_Nav.Name = "Back_Nav"
        Me.Back_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Back_Nav.TabIndex = 134
        Me.Back_Nav.TabStop = False
        '
        'Banner_Box
        '
        Me.Banner_Box.BackgroundImage = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Banner_Box.Image = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.Location = New System.Drawing.Point(0, 0)
        Me.Banner_Box.Name = "Banner_Box"
        Me.Banner_Box.Size = New System.Drawing.Size(528, 111)
        Me.Banner_Box.TabIndex = 133
        Me.Banner_Box.TabStop = False
        '
        'User_ID
        '
        Me.User_ID.AutoSize = True
        Me.User_ID.BackColor = System.Drawing.Color.White
        Me.User_ID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.User_ID.ForeColor = System.Drawing.Color.Gray
        Me.User_ID.Location = New System.Drawing.Point(4, 627)
        Me.User_ID.Name = "User_ID"
        Me.User_ID.Size = New System.Drawing.Size(60, 18)
        Me.User_ID.TabIndex = 132
        Me.User_ID.Text = "User ID"
        '
        'Product_BinTableAdapter
        '
        Me.Product_BinTableAdapter.ClearBeforeFill = True
        '
        'Sales_Floor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 654)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.Rmvd)
        Me.Controls.Add(Me.MinAmt)
        Me.Controls.Add(Me.Order)
        Me.Controls.Add(Me.SIA)
        Me.Controls.Add(Me.Avg)
        Me.Controls.Add(Me.BinNumb)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarNumb)
        Me.Controls.Add(Me.Nme)
        Me.Controls.Add(Me.Bin_Amt)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Pro)
        Me.Controls.Add(Me.Max)
        Me.Controls.Add(Me.Cas)
        Me.Controls.Add(Me.Ail)
        Me.Controls.Add(Me.ItmCol)
        Me.Controls.Add(Me.ItmSiz)
        Me.Controls.Add(Me.SubDep)
        Me.Controls.Add(Me.Dep)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Sales_Floor"
        Me.Text = "Sales_Floor"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SSMS_DATABASEDataSet As SMSS_3.SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pro As TextBox
    Friend WithEvents Max As TextBox
    Friend WithEvents Cas As TextBox
    Friend WithEvents Ail As TextBox
    Friend WithEvents ItmCol As TextBox
    Friend WithEvents ItmSiz As TextBox
    Friend WithEvents SubDep As TextBox
    Friend WithEvents Dep As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Price As RichTextBox
    Friend WithEvents Bin_Amt As RichTextBox
    Friend WithEvents Nme As TextBox
    Friend WithEvents BarNumb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BinNumb As TextBox
    Friend WithEvents Order As TextBox
    Friend WithEvents Avg As TextBox
    Friend WithEvents MinAmt As TextBox
    Friend WithEvents SIA As TextBox
    Friend WithEvents Rmvd As TextBox
    Friend WithEvents Home_Nav As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents Product_BinBindingSource As BindingSource
    Friend WithEvents Product_BinTableAdapter As SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter
End Class
