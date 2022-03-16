<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_ItmMan = New System.Windows.Forms.Label()
        Me.SSMS_DATABASEDataSet = New SMSS_3.SSMS_DATABASEDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        Me.Btn_log = New System.Windows.Forms.Button()
        Me.Btn_ItmMan = New System.Windows.Forms.Button()
        Me.Bnt_Sal = New System.Windows.Forms.Button()
        Me.Btn_Cnt = New System.Windows.Forms.Button()
        Me.Btn_Bin = New System.Windows.Forms.Button()
        Me.Btn_Cou = New System.Windows.Forms.Button()
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(6, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Sales Floor Tool"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(409, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Picking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(215, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Counting"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(38, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Binning"
        '
        'Lbl_ItmMan
        '
        Me.Lbl_ItmMan.AutoSize = True
        Me.Lbl_ItmMan.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ItmMan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_ItmMan.Location = New System.Drawing.Point(182, 420)
        Me.Lbl_ItmMan.Name = "Lbl_ItmMan"
        Me.Lbl_ItmMan.Size = New System.Drawing.Size(162, 22)
        Me.Lbl_ItmMan.TabIndex = 29
        Me.Lbl_ItmMan.Text = "Item Management"
        Me.Lbl_ItmMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.Sub_DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'User_ID
        '
        Me.User_ID.AutoSize = True
        Me.User_ID.BackColor = System.Drawing.Color.White
        Me.User_ID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.User_ID.ForeColor = System.Drawing.Color.Gray
        Me.User_ID.Location = New System.Drawing.Point(378, 630)
        Me.User_ID.Name = "User_ID"
        Me.User_ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.User_ID.Size = New System.Drawing.Size(60, 18)
        Me.User_ID.TabIndex = 113
        Me.User_ID.Text = "User ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(39, 623)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Log Out"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Banner_Box
        '
        Me.Banner_Box.BackgroundImage = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Banner_Box.Image = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.Location = New System.Drawing.Point(0, 0)
        Me.Banner_Box.Name = "Banner_Box"
        Me.Banner_Box.Size = New System.Drawing.Size(528, 111)
        Me.Banner_Box.TabIndex = 114
        Me.Banner_Box.TabStop = False
        '
        'Btn_log
        '
        Me.Btn_log.BackColor = System.Drawing.Color.Transparent
        Me.Btn_log.BackgroundImage = Global.SMSS_3.My.Resources.Resources._043_exit2
        Me.Btn_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_log.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_log.ForeColor = System.Drawing.SystemColors.Window
        Me.Btn_log.Location = New System.Drawing.Point(6, 482)
        Me.Btn_log.Name = "Btn_log"
        Me.Btn_log.Size = New System.Drawing.Size(138, 138)
        Me.Btn_log.TabIndex = 30
        Me.Btn_log.UseVisualStyleBackColor = False
        '
        'Btn_ItmMan
        '
        Me.Btn_ItmMan.BackgroundImage = Global.SMSS_3.My.Resources.Resources._032_mailing
        Me.Btn_ItmMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_ItmMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ItmMan.ForeColor = System.Drawing.Color.White
        Me.Btn_ItmMan.Location = New System.Drawing.Point(195, 279)
        Me.Btn_ItmMan.Name = "Btn_ItmMan"
        Me.Btn_ItmMan.Size = New System.Drawing.Size(138, 138)
        Me.Btn_ItmMan.TabIndex = 27
        Me.Btn_ItmMan.UseVisualStyleBackColor = True
        '
        'Bnt_Sal
        '
        Me.Bnt_Sal.BackgroundImage = Global.SMSS_3.My.Resources.Resources._019_check_mark_1
        Me.Bnt_Sal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Bnt_Sal.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bnt_Sal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bnt_Sal.ForeColor = System.Drawing.Color.White
        Me.Bnt_Sal.Location = New System.Drawing.Point(10, 279)
        Me.Bnt_Sal.Name = "Bnt_Sal"
        Me.Bnt_Sal.Size = New System.Drawing.Size(138, 138)
        Me.Bnt_Sal.TabIndex = 26
        Me.Bnt_Sal.UseVisualStyleBackColor = True
        '
        'Btn_Cnt
        '
        Me.Btn_Cnt.BackgroundImage = Global.SMSS_3.My.Resources.Resources._012_check_mark
        Me.Btn_Cnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Cnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cnt.ForeColor = System.Drawing.Color.White
        Me.Btn_Cnt.Location = New System.Drawing.Point(209, 114)
        Me.Btn_Cnt.Name = "Btn_Cnt"
        Me.Btn_Cnt.Size = New System.Drawing.Size(124, 138)
        Me.Btn_Cnt.TabIndex = 25
        Me.Btn_Cnt.UseVisualStyleBackColor = True
        '
        'Btn_Bin
        '
        Me.Btn_Bin.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Bin.BackgroundImage = Global.SMSS_3.My.Resources.Resources._023_packaging
        Me.Btn_Bin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Bin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Bin.ForeColor = System.Drawing.Color.White
        Me.Btn_Bin.Location = New System.Drawing.Point(10, 114)
        Me.Btn_Bin.Name = "Btn_Bin"
        Me.Btn_Bin.Size = New System.Drawing.Size(138, 138)
        Me.Btn_Bin.TabIndex = 24
        Me.Btn_Bin.UseVisualStyleBackColor = False
        '
        'Btn_Cou
        '
        Me.Btn_Cou.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cou.BackgroundImage = Global.SMSS_3.My.Resources.Resources._022_unpacking
        Me.Btn_Cou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Cou.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cou.ForeColor = System.Drawing.Color.White
        Me.Btn_Cou.Location = New System.Drawing.Point(381, 114)
        Me.Btn_Cou.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Cou.Name = "Btn_Cou"
        Me.Btn_Cou.Size = New System.Drawing.Size(138, 138)
        Me.Btn_Cou.TabIndex = 17
        Me.Btn_Cou.UseVisualStyleBackColor = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 657)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.Btn_log)
        Me.Controls.Add(Me.Lbl_ItmMan)
        Me.Controls.Add(Me.Btn_ItmMan)
        Me.Controls.Add(Me.Bnt_Sal)
        Me.Controls.Add(Me.Btn_Cnt)
        Me.Controls.Add(Me.Btn_Bin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Cou)
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        CType(Me.SSMS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_ItmMan As Button
    Friend WithEvents Bnt_Sal As Button
    Friend WithEvents Btn_Cnt As Button
    Friend WithEvents Btn_Bin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cou As Button
    Friend WithEvents Lbl_ItmMan As Label
    Friend WithEvents Btn_log As Button
    Friend WithEvents SSMS_DATABASEDataSet As SMSS_3.SSMS_DATABASEDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As SMSS_3.SSMS_DATABASEDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As SMSS_3.SSMS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_ID As System.Windows.Forms.Label
    Friend WithEvents Banner_Box As PictureBox
    Friend WithEvents Label5 As Label
End Class
