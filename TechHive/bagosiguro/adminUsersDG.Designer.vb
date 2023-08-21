<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminUsersDG
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
        Me.loadusers = New System.Windows.Forms.Button()
        Me.addusers = New System.Windows.Forms.Button()
        Me.deleteusers = New System.Windows.Forms.Button()
        Me.updateusers = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(671, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'loadusers
        '
        Me.loadusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loadusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadusers.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.loadusers.Location = New System.Drawing.Point(31, 312)
        Me.loadusers.Name = "loadusers"
        Me.loadusers.Size = New System.Drawing.Size(314, 77)
        Me.loadusers.TabIndex = 1
        Me.loadusers.Text = "Load Users"
        Me.loadusers.UseVisualStyleBackColor = False
        '
        'addusers
        '
        Me.addusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.addusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addusers.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.addusers.Location = New System.Drawing.Point(380, 312)
        Me.addusers.Name = "addusers"
        Me.addusers.Size = New System.Drawing.Size(307, 77)
        Me.addusers.TabIndex = 2
        Me.addusers.Text = "Add New Users"
        Me.addusers.UseVisualStyleBackColor = False
        '
        'deleteusers
        '
        Me.deleteusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.deleteusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteusers.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.deleteusers.Location = New System.Drawing.Point(380, 412)
        Me.deleteusers.Name = "deleteusers"
        Me.deleteusers.Size = New System.Drawing.Size(307, 78)
        Me.deleteusers.TabIndex = 3
        Me.deleteusers.Text = "Delete Users"
        Me.deleteusers.UseVisualStyleBackColor = False
        '
        'updateusers
        '
        Me.updateusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.updateusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateusers.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.updateusers.Location = New System.Drawing.Point(31, 412)
        Me.updateusers.Name = "updateusers"
        Me.updateusers.Size = New System.Drawing.Size(314, 78)
        Me.updateusers.TabIndex = 4
        Me.updateusers.Text = "Update Users"
        Me.updateusers.UseVisualStyleBackColor = False
        '
        'adminUsersDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 512)
        Me.Controls.Add(Me.updateusers)
        Me.Controls.Add(Me.deleteusers)
        Me.Controls.Add(Me.addusers)
        Me.Controls.Add(Me.loadusers)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminUsersDG"
        Me.Text = "Admin_users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents loadusers As Button
    Friend WithEvents addusers As Button
    Friend WithEvents deleteusers As Button
    Friend WithEvents updateusers As Button
End Class
