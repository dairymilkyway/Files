<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAccountSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAccountSettings))
        Me.bals = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.createusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.createpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.createaccount = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bals
        '
        Me.bals.AutoSize = True
        Me.bals.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.bals.Location = New System.Drawing.Point(12, 9)
        Me.bals.Name = "bals"
        Me.bals.Size = New System.Drawing.Size(500, 77)
        Me.bals.TabIndex = 9
        Me.bals.Text = "Account Setting"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.createusername)
        Me.Panel1.Location = New System.Drawing.Point(107, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 47)
        Me.Panel1.TabIndex = 19
        '
        'createusername
        '
        Me.createusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.createusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.createusername.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Bold)
        Me.createusername.Location = New System.Drawing.Point(15, 5)
        Me.createusername.Name = "createusername"
        Me.createusername.Size = New System.Drawing.Size(734, 33)
        Me.createusername.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(81, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 47)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.createpassword)
        Me.Panel2.Location = New System.Drawing.Point(107, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(769, 47)
        Me.Panel2.TabIndex = 21
        '
        'createpassword
        '
        Me.createpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.createpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.createpassword.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Bold)
        Me.createpassword.Location = New System.Drawing.Point(15, 3)
        Me.createpassword.Name = "createpassword"
        Me.createpassword.Size = New System.Drawing.Size(734, 33)
        Me.createpassword.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(81, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 47)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password"
        '
        'createaccount
        '
        Me.createaccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.createaccount.FlatAppearance.BorderSize = 0
        Me.createaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createaccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.createaccount.Location = New System.Drawing.Point(107, 474)
        Me.createaccount.Name = "createaccount"
        Me.createaccount.Size = New System.Drawing.Size(769, 108)
        Me.createaccount.TabIndex = 22
        Me.createaccount.Text = "Create Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.createaccount.UseVisualStyleBackColor = False
        '
        'AdminAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 754)
        Me.Controls.Add(Me.createaccount)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bals)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AdminAccountSettings"
        Me.Text = "AccountSettingsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents bals As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents createusername As TextBox
    Public WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Public WithEvents Label3 As Label
    Friend WithEvents createaccount As Button
    Friend WithEvents createpassword As TextBox
End Class
