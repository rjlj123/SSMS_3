<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Binning_2
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
        Me.Bin_In = New System.Windows.Forms.Button()
        Me.Clr = New System.Windows.Forms.Button()
        Me.Bin_ID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bin_Info = New System.Windows.Forms.ListBox()
        Me.Search_Term = New System.Windows.Forms.RichTextBox()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.ItemInfo = New System.Windows.Forms.ListBox()
        Me.Product_BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.BinTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.ProductTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bin_In
        '
        Me.Bin_In.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bin_In.Location = New System.Drawing.Point(288, 230)
        Me.Bin_In.Name = "Bin_In"
        Me.Bin_In.Size = New System.Drawing.Size(228, 56)
        Me.Bin_In.TabIndex = 56
        Me.Bin_In.Text = "Binning"
        Me.Bin_In.UseVisualStyleBackColor = True
        '
        'Clr
        '
        Me.Clr.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clr.Location = New System.Drawing.Point(288, 168)
        Me.Clr.Name = "Clr"
        Me.Clr.Size = New System.Drawing.Size(228, 56)
        Me.Clr.TabIndex = 55
        Me.Clr.Text = "Clear Bin"
        Me.Clr.UseVisualStyleBackColor = True
        '
        'Bin_ID
        '
        Me.Bin_ID.AutoSize = True
        Me.Bin_ID.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Bin_ID.Location = New System.Drawing.Point(405, 126)
        Me.Bin_ID.Name = "Bin_ID"
        Me.Bin_ID.Size = New System.Drawing.Size(62, 22)
        Me.Bin_ID.TabIndex = 53
        Me.Bin_ID.Text = "Bin ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(288, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 30)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bin_Info
        '
        Me.Bin_Info.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bin_Info.FormattingEnabled = True
        Me.Bin_Info.ItemHeight = 18
        Me.Bin_Info.Location = New System.Drawing.Point(12, 168)
        Me.Bin_Info.Name = "Bin_Info"
        Me.Bin_Info.Size = New System.Drawing.Size(253, 436)
        Me.Bin_Info.TabIndex = 51
        '
        'Search_Term
        '
        Me.Search_Term.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Term.Location = New System.Drawing.Point(12, 118)
        Me.Search_Term.Name = "Search_Term"
        Me.Search_Term.Size = New System.Drawing.Size(253, 30)
        Me.Search_Term.TabIndex = 50
        Me.Search_Term.Text = ""
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 22)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Home_Nav.TabIndex = 122
        Me.Home_Nav.TabStop = False
        '
        'Back_Nav
        '
        Me.Back_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Back_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Back_Nav.Image = Global.SMSS_3.My.Resources.Resources._004_next_page
        Me.Back_Nav.Location = New System.Drawing.Point(12, 22)
        Me.Back_Nav.Name = "Back_Nav"
        Me.Back_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Back_Nav.TabIndex = 121
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
        Me.Banner_Box.TabIndex = 120
        Me.Banner_Box.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 46)
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
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
        Me.User_ID.TabIndex = 123
        Me.User_ID.Text = "User ID"
        '
        'ItemInfo
        '
        Me.ItemInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemInfo.FormattingEnabled = True
        Me.ItemInfo.ItemHeight = 18
        Me.ItemInfo.Location = New System.Drawing.Point(288, 294)
        Me.ItemInfo.Name = "ItemInfo"
        Me.ItemInfo.Size = New System.Drawing.Size(228, 310)
        Me.ItemInfo.TabIndex = 125
        '
        'Product_BinBindingSource
        '
        Me.Product_BinBindingSource.DataMember = "Product_Bin"
        Me.Product_BinBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Me.BinTableAdapter
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "Product"
        Me.ProductBindingSource1.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Product_BinTableAdapter
        '
        Me.Product_BinTableAdapter.ClearBeforeFill = True
        '
        'Binning_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 654)
        Me.Controls.Add(Me.ItemInfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.Bin_In)
        Me.Controls.Add(Me.Clr)
        Me.Controls.Add(Me.Bin_ID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bin_Info)
        Me.Controls.Add(Me.Search_Term)
        Me.Name = "Binning_2"
        Me.Text = "Binning_2"
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bin_In As Button
    Friend WithEvents Clr As Button
    Friend WithEvents Bin_ID As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Bin_Info As ListBox
    Friend WithEvents Search_Term As RichTextBox
    Friend WithEvents Home_Nav As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents BinBindingSource As BindingSource
    Friend WithEvents BinTableAdapter As SSMS_DATABASEDataSetTableAdapters.BinTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents Product_BinBindingSource As BindingSource
    Friend WithEvents Product_BinTableAdapter As SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter
    Friend WithEvents ItemInfo As ListBox
End Class
