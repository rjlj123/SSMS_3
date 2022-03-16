<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Binning_1
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
        Me.Btn_Enter = New System.Windows.Forms.Button()
        Me.BinNumb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.BinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.BinTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Enter
        '
        Me.Btn_Enter.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enter.Location = New System.Drawing.Point(228, 417)
        Me.Btn_Enter.Name = "Btn_Enter"
        Me.Btn_Enter.Size = New System.Drawing.Size(106, 51)
        Me.Btn_Enter.TabIndex = 110
        Me.Btn_Enter.Text = "Enter"
        Me.Btn_Enter.UseVisualStyleBackColor = True
        '
        'BinNumb
        '
        Me.BinNumb.Location = New System.Drawing.Point(265, 371)
        Me.BinNumb.Name = "BinNumb"
        Me.BinNumb.Size = New System.Drawing.Size(144, 20)
        Me.BinNumb.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Or Enter Bin ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Scan Bin ID"
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
        Me.User_ID.TabIndex = 115
        Me.User_ID.Text = "User ID"
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 23)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Home_Nav.TabIndex = 119
        Me.Home_Nav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 46)
        Me.PictureBox2.TabIndex = 118
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
        Me.Back_Nav.TabIndex = 117
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
        Me.Banner_Box.TabIndex = 116
        Me.Banner_Box.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.SMSS_3.My.Resources.Resources._009_barcode
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(203, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(154, 130)
        Me.PictureBox3.TabIndex = 106
        Me.PictureBox3.TabStop = False
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
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Binning_1
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
        Me.Controls.Add(Me.Btn_Enter)
        Me.Controls.Add(Me.BinNumb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Binning_1"
        Me.Text = "Binning_1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Enter As Button
    Friend WithEvents BinNumb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Friend WithEvents Home_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents BinBindingSource As BindingSource
    Friend WithEvents BinTableAdapter As SSMS_DATABASEDataSetTableAdapters.BinTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
End Class
