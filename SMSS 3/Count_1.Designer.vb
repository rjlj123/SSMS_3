<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Count_1
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
        Me.Dep_List = New System.Windows.Forms.ListBox()
        Me.Home_Nav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Back_Nav = New System.Windows.Forms.PictureBox()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Sub_List = New System.Windows.Forms.ListBox()
        Me.Sub_DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_DepartmentTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dep_List
        '
        Me.Dep_List.BackColor = System.Drawing.Color.White
        Me.Dep_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dep_List.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Dep_List.ForeColor = System.Drawing.Color.Gray
        Me.Dep_List.FormattingEnabled = True
        Me.Dep_List.ItemHeight = 24
        Me.Dep_List.Location = New System.Drawing.Point(55, 182)
        Me.Dep_List.Name = "Dep_List"
        Me.Dep_List.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Dep_List.Size = New System.Drawing.Size(210, 240)
        Me.Dep_List.TabIndex = 112
        '
        'Home_Nav
        '
        Me.Home_Nav.BackColor = System.Drawing.Color.Transparent
        Me.Home_Nav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Home_Nav.Image = Global.SMSS_3.My.Resources.Resources._005_home
        Me.Home_Nav.Location = New System.Drawing.Point(434, 23)
        Me.Home_Nav.Name = "Home_Nav"
        Me.Home_Nav.Size = New System.Drawing.Size(64, 64)
        Me.Home_Nav.TabIndex = 131
        Me.Home_Nav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SMSS_3.My.Resources.Resources.logo_transparent_Cropped
        Me.PictureBox2.Location = New System.Drawing.Point(396, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 46)
        Me.PictureBox2.TabIndex = 130
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
        Me.Back_Nav.TabIndex = 129
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
        Me.Banner_Box.TabIndex = 128
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
        Me.User_ID.TabIndex = 127
        Me.User_ID.Text = "User ID"
        '
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Me.DepartmentTableAdapter
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Me.Sub_DepartmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sub_List
        '
        Me.Sub_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Sub_List.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Sub_List.ForeColor = System.Drawing.Color.Gray
        Me.Sub_List.FormattingEnabled = True
        Me.Sub_List.ItemHeight = 24
        Me.Sub_List.Location = New System.Drawing.Point(264, 182)
        Me.Sub_List.Name = "Sub_List"
        Me.Sub_List.Size = New System.Drawing.Size(210, 240)
        Me.Sub_List.TabIndex = 113
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
        'Count_1
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
        Me.Controls.Add(Me.Sub_List)
        Me.Controls.Add(Me.Dep_List)
        Me.Name = "Count_1"
        Me.Text = "Count_1"
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sub_DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dep_List As ListBox
    Friend WithEvents Home_Nav As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sub_DepartmentTableAdapter As SSMS_DATABASEDataSetTableAdapters.Sub_DepartmentTableAdapter
    Friend WithEvents Sub_List As ListBox
    Friend WithEvents Sub_DepartmentBindingSource As BindingSource
End Class
