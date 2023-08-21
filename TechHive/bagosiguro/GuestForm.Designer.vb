<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.slbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.Label()
        Me.lobtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(318, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(996, 793)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.slbtn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.lobtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 793)
        Me.Panel1.TabIndex = 2
        '
        'slbtn
        '
        Me.slbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.slbtn.FlatAppearance.BorderSize = 0
        Me.slbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.slbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.slbtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.slbtn.Image = Global.TechHive.My.Resources.Resources._4_removebg_preview2
        Me.slbtn.Location = New System.Drawing.Point(3, 309)
        Me.slbtn.Name = "slbtn"
        Me.slbtn.Size = New System.Drawing.Size(294, 64)
        Me.slbtn.TabIndex = 8
        Me.slbtn.Text = "       Session Log"
        Me.slbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.slbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TechHive.My.Resources.Resources._2_removebg_preview3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 211)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(30, 261)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(248, 34)
        Me.user.TabIndex = 6
        Me.user.Text = "Welcome Guest"
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lobtn
        '
        Me.lobtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lobtn.FlatAppearance.BorderSize = 0
        Me.lobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lobtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lobtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lobtn.Image = Global.TechHive.My.Resources.Resources._6_removebg_preview
        Me.lobtn.Location = New System.Drawing.Point(3, 716)
        Me.lobtn.Name = "lobtn"
        Me.lobtn.Size = New System.Drawing.Size(294, 60)
        Me.lobtn.TabIndex = 5
        Me.lobtn.Text = "          Log Out"
        Me.lobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lobtn.UseVisualStyleBackColor = False
        '
        'GuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1326, 817)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "GuestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GuestForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents slbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents user As Label
    Friend WithEvents lobtn As Button
End Class
