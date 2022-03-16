<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pick_2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Item_Info = New System.Windows.Forms.ListBox()
        Me.Pick_Info = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Bin_Amt = New System.Windows.Forms.RichTextBox()
        Me.Pick_Amt = New System.Windows.Forms.RichTextBox()
        Me.Sub_Dep = New System.Windows.Forms.RichTextBox()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(283, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 31)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Manually Pick"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Item_Info
        '
        Me.Item_Info.FormattingEnabled = True
        Me.Item_Info.Location = New System.Drawing.Point(283, 117)
        Me.Item_Info.Name = "Item_Info"
        Me.Item_Info.Size = New System.Drawing.Size(233, 329)
        Me.Item_Info.TabIndex = 117
        '
        'Pick_Info
        '
        Me.Pick_Info.FormattingEnabled = True
        Me.Pick_Info.Location = New System.Drawing.Point(4, 163)
        Me.Pick_Info.Name = "Pick_Info"
        Me.Pick_Info.Size = New System.Drawing.Size(261, 433)
        Me.Pick_Info.TabIndex = 116
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(283, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 31)
        Me.Button3.TabIndex = 128
        Me.Button3.Text = "Remove Item"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Bin_Amt
        '
        Me.Bin_Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bin_Amt.Location = New System.Drawing.Point(300, 526)
        Me.Bin_Amt.Name = "Bin_Amt"
        Me.Bin_Amt.Size = New System.Drawing.Size(73, 70)
        Me.Bin_Amt.TabIndex = 129
        Me.Bin_Amt.Text = ""
        '
        'Pick_Amt
        '
        Me.Pick_Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pick_Amt.Location = New System.Drawing.Point(425, 526)
        Me.Pick_Amt.Name = "Pick_Amt"
        Me.Pick_Amt.Size = New System.Drawing.Size(73, 70)
        Me.Pick_Amt.TabIndex = 130
        Me.Pick_Amt.Text = ""
        '
        'Sub_Dep
        '
        Me.Sub_Dep.BackColor = System.Drawing.Color.White
        Me.Sub_Dep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Sub_Dep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Dep.Location = New System.Drawing.Point(4, 117)
        Me.Sub_Dep.Name = "Sub_Dep"
        Me.Sub_Dep.Size = New System.Drawing.Size(261, 33)
        Me.Sub_Dep.TabIndex = 131
        Me.Sub_Dep.Text = ""
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
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pick_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 674)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.Sub_Dep)
        Me.Controls.Add(Me.Pick_Amt)
        Me.Controls.Add(Me.Bin_Amt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Item_Info)
        Me.Controls.Add(Me.Pick_Info)
        Me.Name = "Pick_2"
        Me.Text = "Pick_2"
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Item_Info As System.Windows.Forms.ListBox
    Friend WithEvents Pick_Info As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Bin_Amt As System.Windows.Forms.RichTextBox
    Friend WithEvents Pick_Amt As System.Windows.Forms.RichTextBox
    Friend WithEvents Sub_Dep As System.Windows.Forms.RichTextBox
    Friend WithEvents Home_Nav As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Back_Nav As System.Windows.Forms.PictureBox
    Public WithEvents Banner_Box As System.Windows.Forms.PictureBox
    Friend WithEvents User_ID As System.Windows.Forms.Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
End Class
