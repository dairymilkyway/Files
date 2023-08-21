<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminordersDG
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
        Me.loadorders = New System.Windows.Forms.Button()
        Me.deleteorder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(503, 425)
        Me.DataGridView1.TabIndex = 8
        '
        'loadorders
        '
        Me.loadorders.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loadorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadorders.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.loadorders.Location = New System.Drawing.Point(521, 55)
        Me.loadorders.Name = "loadorders"
        Me.loadorders.Size = New System.Drawing.Size(181, 149)
        Me.loadorders.TabIndex = 9
        Me.loadorders.Text = "Load Orders"
        Me.loadorders.UseVisualStyleBackColor = False
        '
        'deleteorder
        '
        Me.deleteorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.deleteorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteorder.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.deleteorder.Location = New System.Drawing.Point(521, 210)
        Me.deleteorder.Name = "deleteorder"
        Me.deleteorder.Size = New System.Drawing.Size(181, 162)
        Me.deleteorder.TabIndex = 10
        Me.deleteorder.Text = "Cancel Order"
        Me.deleteorder.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(521, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 102)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Show Order Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'adminordersDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.deleteorder)
        Me.Controls.Add(Me.loadorders)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminordersDG"
        Me.Text = "admin_order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents loadorders As Button
    Friend WithEvents deleteorder As Button
    Friend WithEvents Button1 As Button
End Class
