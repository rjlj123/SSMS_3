<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fgt_Pass
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
        Me.Txt_User = New System.Windows.Forms.TextBox()
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
        Me.Lbl_Frgt.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Lbl_Frgt.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Frgt.Location = New System.Drawing.Point(12, 124)
        Me.Lbl_Frgt.Name = "Lbl_Frgt"
        Me.Lbl_Frgt.Size = New System.Drawing.Size(44, 18)
        Me.Lbl_Frgt.TabIndex = 13
        Me.Lbl_Frgt.TabStop = True
        Me.Lbl_Frgt.Text = "Back"
        Me.Lbl_Frgt.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(104, 14)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(100, 20)
        Me.Txt_User.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 10
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
        Me.Submit.Location = New System.Drawing.Point(104, 54)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 44)
        Me.Submit.TabIndex = 14
        Me.Submit.Text = "Request Change"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Fgt_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(277, 162)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Lbl_Frgt)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fgt_Pass"
        Me.Text = "Fgt_Pass"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Frgt As LinkLabel
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SSMS_DATABASEDataSet As SSMS_DATABASEDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Submit As System.Windows.Forms.Button
End Class
