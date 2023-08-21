<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSeatsDG
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
        Me.inuse = New System.Windows.Forms.Button()
        Me.reserve = New System.Windows.Forms.Button()
        Me.vacant = New System.Windows.Forms.Button()
        Me.loadinuseseats = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.maintance = New System.Windows.Forms.Button()
        Me.loadseat = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inuse
        '
        Me.inuse.BackColor = System.Drawing.Color.OliveDrab
        Me.inuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inuse.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.inuse.Location = New System.Drawing.Point(521, 256)
        Me.inuse.Name = "inuse"
        Me.inuse.Size = New System.Drawing.Size(181, 71)
        Me.inuse.TabIndex = 10
        Me.inuse.Text = "Update Status to ""In Use"""
        Me.inuse.UseVisualStyleBackColor = False
        '
        'reserve
        '
        Me.reserve.BackColor = System.Drawing.Color.Red
        Me.reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reserve.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.reserve.Location = New System.Drawing.Point(521, 333)
        Me.reserve.Name = "reserve"
        Me.reserve.Size = New System.Drawing.Size(181, 65)
        Me.reserve.TabIndex = 9
        Me.reserve.Text = "Update Status to ""Reserved"""
        Me.reserve.UseVisualStyleBackColor = False
        '
        'vacant
        '
        Me.vacant.BackColor = System.Drawing.Color.Silver
        Me.vacant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vacant.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.vacant.Location = New System.Drawing.Point(521, 189)
        Me.vacant.Name = "vacant"
        Me.vacant.Size = New System.Drawing.Size(181, 61)
        Me.vacant.TabIndex = 8
        Me.vacant.Text = "Update Status to ""Vacant"""
        Me.vacant.UseVisualStyleBackColor = False
        '
        'loadinuseseats
        '
        Me.loadinuseseats.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loadinuseseats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadinuseseats.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.loadinuseseats.Location = New System.Drawing.Point(521, 118)
        Me.loadinuseseats.Name = "loadinuseseats"
        Me.loadinuseseats.Size = New System.Drawing.Size(181, 65)
        Me.loadinuseseats.TabIndex = 7
        Me.loadinuseseats.Text = "Load  in use seats"
        Me.loadinuseseats.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(503, 472)
        Me.DataGridView1.TabIndex = 6
        '
        'maintance
        '
        Me.maintance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.maintance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maintance.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.maintance.Location = New System.Drawing.Point(521, 404)
        Me.maintance.Name = "maintance"
        Me.maintance.Size = New System.Drawing.Size(181, 64)
        Me.maintance.TabIndex = 11
        Me.maintance.Text = "Update Status to ""Under Maintance"""
        Me.maintance.UseVisualStyleBackColor = False
        '
        'loadseat
        '
        Me.loadseat.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loadseat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadseat.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.loadseat.Location = New System.Drawing.Point(521, 47)
        Me.loadseat.Name = "loadseat"
        Me.loadseat.Size = New System.Drawing.Size(181, 65)
        Me.loadseat.TabIndex = 12
        Me.loadseat.Text = "Load Seats"
        Me.loadseat.UseVisualStyleBackColor = False
        '
        'AdminSeatsDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 512)
        Me.Controls.Add(Me.loadseat)
        Me.Controls.Add(Me.maintance)
        Me.Controls.Add(Me.inuse)
        Me.Controls.Add(Me.reserve)
        Me.Controls.Add(Me.vacant)
        Me.Controls.Add(Me.loadinuseseats)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminSeatsDG"
        Me.Text = "admin_seats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inuse As Button
    Friend WithEvents reserve As Button
    Friend WithEvents vacant As Button
    Friend WithEvents loadinuseseats As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents maintance As Button
    Friend WithEvents loadseat As Button
End Class
