<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spl_Scr
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Load_1 = New System.Windows.Forms.PictureBox()
        Me.Load_2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Banner_Box = New System.Windows.Forms.PictureBox()
        CType(Me.Load_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Load_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supermarket Stock Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 648)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version 3.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loading..."
        '
        'Load_1
        '
        Me.Load_1.BackColor = System.Drawing.Color.White
        Me.Load_1.Location = New System.Drawing.Point(42, 332)
        Me.Load_1.Name = "Load_1"
        Me.Load_1.Size = New System.Drawing.Size(446, 31)
        Me.Load_1.TabIndex = 3
        Me.Load_1.TabStop = False
        '
        'Load_2
        '
        Me.Load_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Load_2.Location = New System.Drawing.Point(42, 332)
        Me.Load_2.Name = "Load_2"
        Me.Load_2.Size = New System.Drawing.Size(32, 31)
        Me.Load_2.TabIndex = 4
        Me.Load_2.TabStop = False
        '
        'Timer1
        '
        '
        'Banner_Box
        '
        Me.Banner_Box.BackgroundImage = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Banner_Box.Image = Global.SMSS_3.My.Resources.Resources.Banner_Sized
        Me.Banner_Box.Location = New System.Drawing.Point(0, 0)
        Me.Banner_Box.Name = "Banner_Box"
        Me.Banner_Box.Size = New System.Drawing.Size(528, 111)
        Me.Banner_Box.TabIndex = 139
        Me.Banner_Box.TabStop = False
        '
        'Spl_Scr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 680)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Banner_Box)
        Me.Controls.Add(Me.Load_2)
        Me.Controls.Add(Me.Load_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Spl_Scr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Spl_Scr"
        CType(Me.Load_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Load_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banner_Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Load_1 As PictureBox
    Friend WithEvents Load_2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Public WithEvents Banner_Box As System.Windows.Forms.PictureBox
End Class
