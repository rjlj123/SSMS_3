<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pick_SIA
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
        Me.BtnPck = New System.Windows.Forms.Button()
        Me.Item_Info = New System.Windows.Forms.ListBox()
        Me.Pick_Info = New System.Windows.Forms.ListBox()
        Me.BtnRem = New System.Windows.Forms.Button()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.BinTableAdapter()
        Me.Product_BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter()
        Me.CasTxt = New System.Windows.Forms.RichTextBox()
        Me.TotTxt = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BinChoice = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPck
        '
        Me.BtnPck.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPck.Location = New System.Drawing.Point(283, 487)
        Me.BtnPck.Name = "BtnPck"
        Me.BtnPck.Size = New System.Drawing.Size(233, 31)
        Me.BtnPck.TabIndex = 121
        Me.BtnPck.Text = "Pick Item"
        Me.BtnPck.UseVisualStyleBackColor = True
        '
        'Item_Info
        '
        Me.Item_Info.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_Info.FormattingEnabled = True
        Me.Item_Info.ItemHeight = 16
        Me.Item_Info.Location = New System.Drawing.Point(283, 126)
        Me.Item_Info.Name = "Item_Info"
        Me.Item_Info.Size = New System.Drawing.Size(233, 228)
        Me.Item_Info.TabIndex = 117
        '
        'Pick_Info
        '
        Me.Pick_Info.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pick_Info.FormattingEnabled = True
        Me.Pick_Info.ItemHeight = 16
        Me.Pick_Info.Location = New System.Drawing.Point(7, 157)
        Me.Pick_Info.Name = "Pick_Info"
        Me.Pick_Info.Size = New System.Drawing.Size(261, 484)
        Me.Pick_Info.TabIndex = 116
        '
        'BtnRem
        '
        Me.BtnRem.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRem.Location = New System.Drawing.Point(283, 524)
        Me.BtnRem.Name = "BtnRem"
        Me.BtnRem.Size = New System.Drawing.Size(233, 31)
        Me.BtnRem.TabIndex = 128
        Me.BtnRem.Text = "Remove Item"
        Me.BtnRem.UseVisualStyleBackColor = True
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 25)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 69)
        Me.Home_Nav.TabIndex = 136
        Me.Home_Nav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 655)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 50)
        Me.PictureBox2.TabIndex = 135
        Me.PictureBox2.TabStop = False
        '
        'Back_Nav
        '
        Me.Back_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Back_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Back_Nav.Image = Global.SMSS_3.My.Resources.Resources._004_next_page
        Me.Back_Nav.Location = New System.Drawing.Point(12, 25)
        Me.Back_Nav.Name = "Back_Nav"
        Me.Back_Nav.Size = New System.Drawing.Size(64, 69)
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
        Me.Banner_Box.Size = New System.Drawing.Size(528, 120)
        Me.Banner_Box.TabIndex = 133
        Me.Banner_Box.TabStop = False
        '
        'User_ID
        '
        Me.User_ID.AutoSize = True
        Me.User_ID.BackColor = System.Drawing.Color.White
        Me.User_ID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.User_ID.ForeColor = System.Drawing.Color.Gray
        Me.User_ID.Location = New System.Drawing.Point(4, 675)
        Me.User_ID.Name = "User_ID"
        Me.User_ID.Size = New System.Drawing.Size(60, 18)
        Me.User_ID.TabIndex = 132
        Me.User_ID.Text = "User ID"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.SMSS_3.My.Resources.Resources._009_barcode
        Me.PictureBox1.Location = New System.Drawing.Point(334, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 120)
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'BinBindingSource
        '
        Me.BinBindingSource.DataMember = "Bin"
        Me.BinBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'BinTableAdapter
        '
        Me.BinTableAdapter.ClearBeforeFill = True
        '
        'Product_BinBindingSource
        '
        Me.Product_BinBindingSource.DataMember = "Product_Bin"
        Me.Product_BinBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Product_BinTableAdapter
        '
        Me.Product_BinTableAdapter.ClearBeforeFill = True
        '
        'CasTxt
        '
        Me.CasTxt.BackColor = System.Drawing.Color.White
        Me.CasTxt.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CasTxt.Location = New System.Drawing.Point(382, 561)
        Me.CasTxt.Name = "CasTxt"
        Me.CasTxt.ReadOnly = True
        Me.CasTxt.Size = New System.Drawing.Size(83, 25)
        Me.CasTxt.TabIndex = 142
        Me.CasTxt.Text = ""
        '
        'TotTxt
        '
        Me.TotTxt.BackColor = System.Drawing.Color.White
        Me.TotTxt.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.TotTxt.Location = New System.Drawing.Point(382, 601)
        Me.TotTxt.Name = "TotTxt"
        Me.TotTxt.ReadOnly = True
        Me.TotTxt.Size = New System.Drawing.Size(83, 25)
        Me.TotTxt.TabIndex = 143
        Me.TotTxt.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(322, 563)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Cases:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(336, 603)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "SIA"
        '
        'BinChoice
        '
        Me.BinChoice.FormattingEnabled = True
        Me.BinChoice.Location = New System.Drawing.Point(153, 126)
        Me.BinChoice.Name = "BinChoice"
        Me.BinChoice.Size = New System.Drawing.Size(115, 22)
        Me.BinChoice.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Bin Number:"
        '
        'Pick_SIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 705)
        Me.Controls.Add(Me.BinChoice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotTxt)
        Me.Controls.Add(Me.CasTxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.BtnRem)
        Me.Controls.Add(Me.BtnPck)
        Me.Controls.Add(Me.Item_Info)
        Me.Controls.Add(Me.Pick_Info)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Pick_SIA"
        Me.Text = "Pick_SIA"
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPck As System.Windows.Forms.Button
    Friend WithEvents Item_Info As System.Windows.Forms.ListBox
    Friend WithEvents Pick_Info As System.Windows.Forms.ListBox
    Friend WithEvents BtnRem As System.Windows.Forms.Button
    Friend WithEvents Home_Nav As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Back_Nav As System.Windows.Forms.PictureBox
    Public WithEvents Banner_Box As System.Windows.Forms.PictureBox
    Friend WithEvents User_ID As System.Windows.Forms.Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BinTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.BinTableAdapter
    Friend WithEvents Product_BinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Product_BinTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter
    Friend WithEvents CasTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents TotTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BinChoice As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
