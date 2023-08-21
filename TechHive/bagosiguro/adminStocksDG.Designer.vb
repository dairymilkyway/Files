<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminStocksDG
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.loadstocks = New System.Windows.Forms.Button()
        Me.updisprice = New System.Windows.Forms.Button()
        Me.updprice = New System.Windows.Forms.Button()
        Me.Updatestocks = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(503, 472)
        Me.DataGridView1.TabIndex = 1
        '
        'loadstocks
        '
        Me.loadstocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loadstocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadstocks.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.loadstocks.Location = New System.Drawing.Point(521, 22)
        Me.loadstocks.Name = "loadstocks"
        Me.loadstocks.Size = New System.Drawing.Size(181, 73)
        Me.loadstocks.TabIndex = 2
        Me.loadstocks.Text = "Load Stocks"
        Me.loadstocks.UseVisualStyleBackColor = False
        '
        'updisprice
        '
        Me.updisprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.updisprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updisprice.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.updisprice.Location = New System.Drawing.Point(521, 239)
        Me.updisprice.Name = "updisprice"
        Me.updisprice.Size = New System.Drawing.Size(181, 71)
        Me.updisprice.TabIndex = 3
        Me.updisprice.Text = "Update Discount Price"
        Me.updisprice.UseVisualStyleBackColor = False
        '
        'updprice
        '
        Me.updprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.updprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updprice.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.updprice.Location = New System.Drawing.Point(521, 164)
        Me.updprice.Name = "updprice"
        Me.updprice.Size = New System.Drawing.Size(181, 69)
        Me.updprice.TabIndex = 4
        Me.updprice.Text = "Update Price"
        Me.updprice.UseVisualStyleBackColor = False
        '
        'Updatestocks
        '
        Me.Updatestocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Updatestocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Updatestocks.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Updatestocks.Location = New System.Drawing.Point(521, 101)
        Me.Updatestocks.Name = "Updatestocks"
        Me.Updatestocks.Size = New System.Drawing.Size(181, 57)
        Me.Updatestocks.TabIndex = 5
        Me.Updatestocks.Text = "Update Stocks"
        Me.Updatestocks.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(521, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 71)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Show Inventory Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'adminStocksDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Updatestocks)
        Me.Controls.Add(Me.updprice)
        Me.Controls.Add(Me.updisprice)
        Me.Controls.Add(Me.loadstocks)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminStocksDG"
        Me.Text = "admin_stocks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents loadstocks As Button
    Friend WithEvents updisprice As Button
    Friend WithEvents updprice As Button
    Friend WithEvents Updatestocks As Button
    Friend WithEvents Button1 As Button
End Class
