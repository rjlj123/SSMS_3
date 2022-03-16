<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Binning_4
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
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Final = New System.Windows.Forms.Button()
        Me.BCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Product_BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter()
        Me.Los_Itm = New System.Windows.Forms.TextBox()
        Me.Btn_Loose = New System.Windows.Forms.Button()
        Me.Lbl_Qua = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Add
        '
        Me.Btn_Add.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(211, 408)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(106, 41)
        Me.Btn_Add.TabIndex = 41
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Final
        '
        Me.Btn_Final.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Final.Location = New System.Drawing.Point(211, 455)
        Me.Btn_Final.Name = "Btn_Final"
        Me.Btn_Final.Size = New System.Drawing.Size(106, 41)
        Me.Btn_Final.TabIndex = 40
        Me.Btn_Final.Text = "Finalise"
        Me.Btn_Final.UseVisualStyleBackColor = True
        '
        'BCode
        '
        Me.BCode.Location = New System.Drawing.Point(313, 363)
        Me.BCode.Name = "BCode"
        Me.BCode.Size = New System.Drawing.Size(144, 20)
        Me.BCode.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 22)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Or Enter Barcode Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Scan Item Barcode"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.SMSS_3.My.Resources.Resources._009_barcode
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(203, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(154, 130)
        Me.PictureBox3.TabIndex = 121
        Me.PictureBox3.TabStop = False
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 23)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Home_Nav.TabIndex = 126
        Me.Home_Nav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 46)
        Me.PictureBox2.TabIndex = 125
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
        Me.Back_Nav.TabIndex = 124
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
        Me.Banner_Box.TabIndex = 123
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
        Me.User_ID.TabIndex = 122
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
        'Product_BinBindingSource
        '
        Me.Product_BinBindingSource.DataMember = "Product_Bin"
        Me.Product_BinBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Product_BinTableAdapter
        '
        Me.Product_BinTableAdapter.ClearBeforeFill = True
        '
        'Los_Itm
        '
        Me.Los_Itm.Location = New System.Drawing.Point(428, 440)
        Me.Los_Itm.Name = "Los_Itm"
        Me.Los_Itm.Size = New System.Drawing.Size(29, 20)
        Me.Los_Itm.TabIndex = 128
        '
        'Btn_Loose
        '
        Me.Btn_Loose.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Btn_Loose.Location = New System.Drawing.Point(350, 408)
        Me.Btn_Loose.Name = "Btn_Loose"
        Me.Btn_Loose.Size = New System.Drawing.Size(107, 26)
        Me.Btn_Loose.TabIndex = 127
        Me.Btn_Loose.Text = "Loose Items"
        Me.Btn_Loose.UseVisualStyleBackColor = True
        '
        'Lbl_Qua
        '
        Me.Lbl_Qua.AutoSize = True
        Me.Lbl_Qua.BackColor = System.Drawing.Color.White
        Me.Lbl_Qua.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Lbl_Qua.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Qua.Location = New System.Drawing.Point(348, 467)
        Me.Lbl_Qua.Name = "Lbl_Qua"
        Me.Lbl_Qua.Size = New System.Drawing.Size(109, 18)
        Me.Lbl_Qua.TabIndex = 129
        Me.Lbl_Qua.Text = "Large Quantity"
        Me.Lbl_Qua.Visible = False
        '
        'Binning_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 654)
        Me.Controls.Add(Me.Lbl_Qua)
        Me.Controls.Add(Me.Los_Itm)
        Me.Controls.Add(Me.Btn_Loose)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Final)
        Me.Controls.Add(Me.BCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Binning_4"
        Me.Text = "Binning_4"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Final As Button
    Friend WithEvents BCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Home_Nav As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Product_BinBindingSource As BindingSource
    Friend WithEvents Product_BinTableAdapter As SSMS_DATABASEDataSetTableAdapters.Product_BinTableAdapter
    Friend WithEvents Los_Itm As TextBox
    Friend WithEvents Btn_Loose As Button
    Friend WithEvents Lbl_Qua As Label
End Class
