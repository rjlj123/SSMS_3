<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Lbl_Frgt = New System.Windows.Forms.LinkLabel()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SSMS_Admin.SSMS_DATABASEDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Submit = New System.Windows.Forms.Button()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Frgt
        '
        Me.Lbl_Frgt.AutoSize = True
        Me.Lbl_Frgt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Frgt.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Frgt.Location = New System.Drawing.Point(18, 168)
        Me.Lbl_Frgt.Name = "Lbl_Frgt"
        Me.Lbl_Frgt.Size = New System.Drawing.Size(101, 15)
        Me.Lbl_Frgt.TabIndex = 10
        Me.Lbl_Frgt.TabStop = True
        Me.Lbl_Frgt.Text = "Forgot Password"
        Me.Lbl_Frgt.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Location = New System.Drawing.Point(108, 62)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_Pass.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Pass.TabIndex = 9
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(108, 30)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(100, 20)
        Me.Txt_User.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        '
        'SSMS_DATABASEDataSet
        '
        Me.SSMS_DATABASEDataSet.DataSetName = "SSMS_DATABASEDataSet"
        Me.SSMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.SSMS_DATABASEDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BinTableAdapter = Nothing
        Me.TableAdapterManager.Count_VerificationTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Product_BinTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SSMS_Admin.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.SteelBlue
        Me.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Submit.ForeColor = System.Drawing.Color.White
        Me.Submit.Location = New System.Drawing.Point(108, 95)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 44)
        Me.Submit.TabIndex = 11
        Me.Submit.Text = "Login"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(313, 185)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Lbl_Frgt)
        Me.Controls.Add(Me.Txt_Pass)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Frgt As LinkLabel
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Submit As System.Windows.Forms.Button
End Class
