<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Count_2
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
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.BtnSub = New System.Windows.Forms.Button()
        Me.txtcount = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Item_Info = New System.Windows.Forms.ListBox()
        Me.Count_Info = New System.Windows.Forms.ListBox()
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
        Me.Count_VerificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Count_VerificationTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.Count_VerificationTableAdapter()
        Me.LrgCnt = New System.Windows.Forms.Label()
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Count_VerificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFin
        '
        Me.BtnFin.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFin.Location = New System.Drawing.Point(292, 541)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(224, 47)
        Me.BtnFin.TabIndex = 61
        Me.BtnFin.Text = "Finalise Changes"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'BtnSub
        '
        Me.BtnSub.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSub.Location = New System.Drawing.Point(291, 504)
        Me.BtnSub.Name = "BtnSub"
        Me.BtnSub.Size = New System.Drawing.Size(110, 31)
        Me.BtnSub.TabIndex = 60
        Me.BtnSub.Text = "Submit"
        Me.BtnSub.UseVisualStyleBackColor = True
        '
        'txtcount
        '
        Me.txtcount.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcount.Location = New System.Drawing.Point(407, 457)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(68, 31)
        Me.txtcount.TabIndex = 59
        Me.txtcount.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 461)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Shelf Count:"
        '
        'Item_Info
        '
        Me.Item_Info.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_Info.FormattingEnabled = True
        Me.Item_Info.ItemHeight = 18
        Me.Item_Info.Location = New System.Drawing.Point(291, 116)
        Me.Item_Info.Name = "Item_Info"
        Me.Item_Info.Size = New System.Drawing.Size(225, 328)
        Me.Item_Info.TabIndex = 56
        '
        'Count_Info
        '
        Me.Count_Info.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count_Info.FormattingEnabled = True
        Me.Count_Info.ItemHeight = 18
        Me.Count_Info.Location = New System.Drawing.Point(4, 155)
        Me.Count_Info.Name = "Count_Info"
        Me.Count_Info.Size = New System.Drawing.Size(268, 454)
        Me.Count_Info.TabIndex = 55
        '
        'Sub_Dep
        '
        Me.Sub_Dep.BackColor = System.Drawing.Color.White
        Me.Sub_Dep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Sub_Dep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Dep.Location = New System.Drawing.Point(4, 116)
        Me.Sub_Dep.Name = "Sub_Dep"
        Me.Sub_Dep.Size = New System.Drawing.Size(268, 33)
        Me.Sub_Dep.TabIndex = 116
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
        'Count_VerificationBindingSource
        '
        Me.Count_VerificationBindingSource.DataMember = "Count_Verification"
        Me.Count_VerificationBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'Count_VerificationTableAdapter
        '
        Me.Count_VerificationTableAdapter.ClearBeforeFill = True
        '
        'LrgCnt
        '
        Me.LrgCnt.AutoSize = True
        Me.LrgCnt.BackColor = System.Drawing.Color.White
        Me.LrgCnt.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LrgCnt.ForeColor = System.Drawing.Color.Black
        Me.LrgCnt.Location = New System.Drawing.Point(422, 504)
        Me.LrgCnt.Name = "LrgCnt"
        Me.LrgCnt.Size = New System.Drawing.Size(94, 18)
        Me.LrgCnt.TabIndex = 132
        Me.LrgCnt.Text = "Large Count"
        Me.LrgCnt.Visible = False
        '
        'Count_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 654)
        Me.Controls.Add(Me.LrgCnt)
        Me.Controls.Add(Me.Home_Nav)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Back_Nav)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.Sub_Dep)
        Me.Controls.Add(Me.BtnFin)
        Me.Controls.Add(Me.BtnSub)
        Me.Controls.Add(Me.txtcount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Item_Info)
        Me.Controls.Add(Me.Count_Info)
        Me.Name = "Count_2"
        Me.Text = "Count_2"
        CType(Me.Home_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back_Nav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Count_VerificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnFin As System.Windows.Forms.Button
    Friend WithEvents BtnSub As System.Windows.Forms.Button
    Friend WithEvents txtcount As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Item_Info As System.Windows.Forms.ListBox
    Friend WithEvents Count_Info As System.Windows.Forms.ListBox
    Friend WithEvents Sub_Dep As RichTextBox
    Friend WithEvents Home_Nav As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Back_Nav As PictureBox
    Public WithEvents Banner_Box As PictureBox
    Friend WithEvents User_ID As Label
    Friend WithEvents SSMS_DATABASEDataSet As SMSS_3.SSMS_DATABASEDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Count_VerificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Count_VerificationTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.Count_VerificationTableAdapter
    Friend WithEvents LrgCnt As Label
End Class
