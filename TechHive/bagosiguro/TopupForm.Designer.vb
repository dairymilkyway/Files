<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopupForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bals = New System.Windows.Forms.Label()
        Me.historybtn = New System.Windows.Forms.Button()
        Me.paynow = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fourth = New System.Windows.Forms.Button()
        Me.third = New System.Windows.Forms.Button()
        Me.second = New System.Windows.Forms.Button()
        Me.first = New System.Windows.Forms.Button()
        Me.resultid = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.usertype = New System.Windows.Forms.Label()
        Me.balance = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bals)
        Me.Panel1.Controls.Add(Me.historybtn)
        Me.Panel1.Location = New System.Drawing.Point(66, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 158)
        Me.Panel1.TabIndex = 0
        '
        'bals
        '
        Me.bals.AutoSize = True
        Me.bals.Font = New System.Drawing.Font("Yu Gothic", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.bals.Location = New System.Drawing.Point(65, 24)
        Me.bals.Name = "bals"
        Me.bals.Size = New System.Drawing.Size(406, 121)
        Me.bals.TabIndex = 8
        Me.bals.Text = "$123.45"
        '
        'historybtn
        '
        Me.historybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.historybtn.FlatAppearance.BorderSize = 0
        Me.historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.historybtn.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Bold)
        Me.historybtn.ForeColor = System.Drawing.Color.White
        Me.historybtn.Location = New System.Drawing.Point(561, 38)
        Me.historybtn.Name = "historybtn"
        Me.historybtn.Size = New System.Drawing.Size(252, 86)
        Me.historybtn.TabIndex = 8
        Me.historybtn.Text = "History"
        Me.historybtn.UseVisualStyleBackColor = False
        '
        'paynow
        '
        Me.paynow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.paynow.FlatAppearance.BorderSize = 0
        Me.paynow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.paynow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paynow.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.paynow.Location = New System.Drawing.Point(66, 690)
        Me.paynow.Name = "paynow"
        Me.paynow.Size = New System.Drawing.Size(848, 91)
        Me.paynow.TabIndex = 3
        Me.paynow.Text = "Pay Now"
        Me.paynow.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(66, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 152)
        Me.Panel2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic Medium", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(54, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(747, 193)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(77, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top Up Amount"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(501, 596)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(401, 79)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Promos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(501, 496)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(401, 79)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Promos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'fourth
        '
        Me.fourth.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.fourth.FlatAppearance.BorderSize = 0
        Me.fourth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fourth.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourth.ForeColor = System.Drawing.Color.White
        Me.fourth.Image = CType(resources.GetObject("fourth.Image"), System.Drawing.Image)
        Me.fourth.Location = New System.Drawing.Point(501, 596)
        Me.fourth.Name = "fourth"
        Me.fourth.Size = New System.Drawing.Size(401, 79)
        Me.fourth.TabIndex = 7
        Me.fourth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.fourth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.fourth.UseVisualStyleBackColor = False
        '
        'third
        '
        Me.third.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.third.FlatAppearance.BorderSize = 0
        Me.third.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.third.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.third.ForeColor = System.Drawing.Color.White
        Me.third.Image = CType(resources.GetObject("third.Image"), System.Drawing.Image)
        Me.third.Location = New System.Drawing.Point(78, 596)
        Me.third.Name = "third"
        Me.third.Size = New System.Drawing.Size(401, 79)
        Me.third.TabIndex = 6
        Me.third.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.third.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.third.UseVisualStyleBackColor = False
        '
        'second
        '
        Me.second.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.second.FlatAppearance.BorderSize = 0
        Me.second.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.second.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second.ForeColor = System.Drawing.Color.White
        Me.second.Image = CType(resources.GetObject("second.Image"), System.Drawing.Image)
        Me.second.Location = New System.Drawing.Point(501, 496)
        Me.second.Name = "second"
        Me.second.Size = New System.Drawing.Size(401, 79)
        Me.second.TabIndex = 5
        Me.second.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.second.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.second.UseVisualStyleBackColor = False
        '
        'first
        '
        Me.first.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.first.FlatAppearance.BorderSize = 0
        Me.first.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.first.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first.ForeColor = System.Drawing.Color.White
        Me.first.Image = CType(resources.GetObject("first.Image"), System.Drawing.Image)
        Me.first.Location = New System.Drawing.Point(78, 496)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(401, 79)
        Me.first.TabIndex = 4
        Me.first.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.first.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.first.UseVisualStyleBackColor = False
        '
        'resultid
        '
        Me.resultid.AutoSize = True
        Me.resultid.Location = New System.Drawing.Point(913, 5)
        Me.resultid.Name = "resultid"
        Me.resultid.Size = New System.Drawing.Size(0, 29)
        Me.resultid.TabIndex = 8
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.SystemColors.Control
        Me.username.Location = New System.Drawing.Point(63, 425)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(118, 30)
        Me.username.TabIndex = 9
        Me.username.Text = "username"
        '
        'usertype
        '
        Me.usertype.AutoSize = True
        Me.usertype.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertype.ForeColor = System.Drawing.SystemColors.Control
        Me.usertype.Location = New System.Drawing.Point(716, 425)
        Me.usertype.Name = "usertype"
        Me.usertype.Size = New System.Drawing.Size(104, 30)
        Me.usertype.TabIndex = 10
        Me.usertype.Text = "usertype"
        '
        'balance
        '
        Me.balance.AutoSize = True
        Me.balance.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance.ForeColor = System.Drawing.SystemColors.Control
        Me.balance.Location = New System.Drawing.Point(379, 425)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(96, 30)
        Me.balance.TabIndex = 11
        Me.balance.Text = "balance"
        '
        'TopupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(996, 793)
        Me.Controls.Add(Me.balance)
        Me.Controls.Add(Me.usertype)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.resultid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.fourth)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.third)
        Me.Controls.Add(Me.second)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.paynow)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TopupForm"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents paynow As Button
    Friend WithEvents first As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents third As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents historybtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents second As Button
    Friend WithEvents fourth As Button
    Public WithEvents bals As Label
    Friend WithEvents resultid As Label
    Public WithEvents username As Label
    Public WithEvents usertype As Label
    Public WithEvents balance As Label
End Class
