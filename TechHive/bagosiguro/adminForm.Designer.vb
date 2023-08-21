<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.id = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.asbtn = New System.Windows.Forms.Button()
        Me.sbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lobtn = New System.Windows.Forms.Button()
        Me.tpbtn = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.asbtn)
        Me.Panel1.Controls.Add(Me.sbtn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.lobtn)
        Me.Panel1.Controls.Add(Me.tpbtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 793)
        Me.Panel1.TabIndex = 2
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.id.Location = New System.Drawing.Point(149, 3)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(0, 29)
        Me.id.TabIndex = 10
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(28, 256)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(251, 34)
        Me.user.TabIndex = 6
        Me.user.Text = "Welcome Admin"
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.Image = Global.TechHive.My.Resources.Resources.Untitled_design__2__removebg_preview6
        Me.Button1.Location = New System.Drawing.Point(3, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(294, 64)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Tables      "
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'asbtn
        '
        Me.asbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.asbtn.FlatAppearance.BorderSize = 0
        Me.asbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.asbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asbtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.asbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.asbtn.Image = Global.TechHive.My.Resources.Resources._3_removebg_preview
        Me.asbtn.Location = New System.Drawing.Point(3, 638)
        Me.asbtn.Name = "asbtn"
        Me.asbtn.Size = New System.Drawing.Size(294, 64)
        Me.asbtn.TabIndex = 9
        Me.asbtn.Text = "Account Settings"
        Me.asbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.asbtn.UseVisualStyleBackColor = False
        '
        'sbtn
        '
        Me.sbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sbtn.FlatAppearance.BorderSize = 0
        Me.sbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.sbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sbtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.sbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.sbtn.Image = Global.TechHive.My.Resources.Resources._5_removebg_preview1
        Me.sbtn.Location = New System.Drawing.Point(3, 315)
        Me.sbtn.Name = "sbtn"
        Me.sbtn.Size = New System.Drawing.Size(294, 64)
        Me.sbtn.TabIndex = 7
        Me.sbtn.Text = "Seats         "
        Me.sbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.sbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TechHive.My.Resources.Resources._2_removebg_preview3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 211)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lobtn
        '
        Me.lobtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lobtn.FlatAppearance.BorderSize = 0
        Me.lobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lobtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lobtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lobtn.Image = Global.TechHive.My.Resources.Resources._6_removebg_preview
        Me.lobtn.Location = New System.Drawing.Point(3, 708)
        Me.lobtn.Name = "lobtn"
        Me.lobtn.Size = New System.Drawing.Size(294, 60)
        Me.lobtn.TabIndex = 5
        Me.lobtn.Text = "          Log Out"
        Me.lobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lobtn.UseVisualStyleBackColor = False
        '
        'tpbtn
        '
        Me.tpbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tpbtn.FlatAppearance.BorderSize = 0
        Me.tpbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.tpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tpbtn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.tpbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.tpbtn.Image = Global.TechHive.My.Resources.Resources._4_removebg_preview
        Me.tpbtn.Location = New System.Drawing.Point(3, 385)
        Me.tpbtn.Name = "tpbtn"
        Me.tpbtn.Size = New System.Drawing.Size(294, 64)
        Me.tpbtn.TabIndex = 2
        Me.tpbtn.Text = " Top Up      "
        Me.tpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.tpbtn.UseVisualStyleBackColor = False
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1326, 817)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "adminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents asbtn As Button
    Friend WithEvents sbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents user As Label
    Friend WithEvents lobtn As Button
    Friend WithEvents tpbtn As Button
    Friend WithEvents id As Label
    Friend WithEvents Button1 As Button
End Class
