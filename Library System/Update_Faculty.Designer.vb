<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Faculty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Faculty))
        Me.txt_studcontact = New System.Windows.Forms.MaskedTextBox()
        Me.btn_studcancels = New System.Windows.Forms.Button()
        Me.btn_studclears = New System.Windows.Forms.Button()
        Me.btn_studsaves = New System.Windows.Forms.Button()
        Me.txt_studpword = New System.Windows.Forms.TextBox()
        Me.txt_advisory = New System.Windows.Forms.TextBox()
        Me.txt_studname = New System.Windows.Forms.TextBox()
        Me.txt_studuname = New System.Windows.Forms.TextBox()
        Me.lbl_studpword = New System.Windows.Forms.Label()
        Me.lbl_studgs = New System.Windows.Forms.Label()
        Me.lbl_studcontact = New System.Windows.Forms.Label()
        Me.lbl_studname = New System.Windows.Forms.Label()
        Me.lbl_studuname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_studcontact
        '
        Me.txt_studcontact.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studcontact.Location = New System.Drawing.Point(411, 457)
        Me.txt_studcontact.Mask = "(+63) 000-0000-000"
        Me.txt_studcontact.Name = "txt_studcontact"
        Me.txt_studcontact.Size = New System.Drawing.Size(524, 32)
        Me.txt_studcontact.TabIndex = 149
        '
        'btn_studcancels
        '
        Me.btn_studcancels.BackColor = System.Drawing.Color.Transparent
        Me.btn_studcancels.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studcancels.Image = CType(resources.GetObject("btn_studcancels.Image"), System.Drawing.Image)
        Me.btn_studcancels.Location = New System.Drawing.Point(1200, 595)
        Me.btn_studcancels.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_studcancels.Name = "btn_studcancels"
        Me.btn_studcancels.Size = New System.Drawing.Size(151, 57)
        Me.btn_studcancels.TabIndex = 148
        Me.btn_studcancels.Text = "CANCEL"
        Me.btn_studcancels.UseVisualStyleBackColor = False
        '
        'btn_studclears
        '
        Me.btn_studclears.BackColor = System.Drawing.Color.Transparent
        Me.btn_studclears.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studclears.Image = CType(resources.GetObject("btn_studclears.Image"), System.Drawing.Image)
        Me.btn_studclears.Location = New System.Drawing.Point(663, 595)
        Me.btn_studclears.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_studclears.Name = "btn_studclears"
        Me.btn_studclears.Size = New System.Drawing.Size(151, 57)
        Me.btn_studclears.TabIndex = 147
        Me.btn_studclears.Text = "CLEAR"
        Me.btn_studclears.UseVisualStyleBackColor = False
        '
        'btn_studsaves
        '
        Me.btn_studsaves.BackColor = System.Drawing.Color.Transparent
        Me.btn_studsaves.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studsaves.Image = CType(resources.GetObject("btn_studsaves.Image"), System.Drawing.Image)
        Me.btn_studsaves.Location = New System.Drawing.Point(920, 595)
        Me.btn_studsaves.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_studsaves.Name = "btn_studsaves"
        Me.btn_studsaves.Size = New System.Drawing.Size(151, 57)
        Me.btn_studsaves.TabIndex = 146
        Me.btn_studsaves.Text = "UPDATE"
        Me.btn_studsaves.UseVisualStyleBackColor = False
        '
        'txt_studpword
        '
        Me.txt_studpword.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studpword.Location = New System.Drawing.Point(1071, 380)
        Me.txt_studpword.Name = "txt_studpword"
        Me.txt_studpword.Size = New System.Drawing.Size(524, 32)
        Me.txt_studpword.TabIndex = 145
        '
        'txt_advisory
        '
        Me.txt_advisory.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advisory.Location = New System.Drawing.Point(1071, 457)
        Me.txt_advisory.Name = "txt_advisory"
        Me.txt_advisory.Size = New System.Drawing.Size(524, 32)
        Me.txt_advisory.TabIndex = 144
        '
        'txt_studname
        '
        Me.txt_studname.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studname.Location = New System.Drawing.Point(411, 380)
        Me.txt_studname.Name = "txt_studname"
        Me.txt_studname.Size = New System.Drawing.Size(524, 32)
        Me.txt_studname.TabIndex = 143
        '
        'txt_studuname
        '
        Me.txt_studuname.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studuname.Location = New System.Drawing.Point(411, 299)
        Me.txt_studuname.MaxLength = 17
        Me.txt_studuname.Name = "txt_studuname"
        Me.txt_studuname.ReadOnly = True
        Me.txt_studuname.Size = New System.Drawing.Size(524, 32)
        Me.txt_studuname.TabIndex = 142
        '
        'lbl_studpword
        '
        Me.lbl_studpword.AutoSize = True
        Me.lbl_studpword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studpword.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studpword.Location = New System.Drawing.Point(1079, 347)
        Me.lbl_studpword.Name = "lbl_studpword"
        Me.lbl_studpword.Size = New System.Drawing.Size(134, 30)
        Me.lbl_studpword.TabIndex = 141
        Me.lbl_studpword.Text = "Password"
        '
        'lbl_studgs
        '
        Me.lbl_studgs.AutoSize = True
        Me.lbl_studgs.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studgs.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studgs.Location = New System.Drawing.Point(1066, 424)
        Me.lbl_studgs.Name = "lbl_studgs"
        Me.lbl_studgs.Size = New System.Drawing.Size(198, 30)
        Me.lbl_studgs.TabIndex = 140
        Me.lbl_studgs.Text = "Advisory Class"
        '
        'lbl_studcontact
        '
        Me.lbl_studcontact.AutoSize = True
        Me.lbl_studcontact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studcontact.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studcontact.Location = New System.Drawing.Point(415, 424)
        Me.lbl_studcontact.Name = "lbl_studcontact"
        Me.lbl_studcontact.Size = New System.Drawing.Size(153, 30)
        Me.lbl_studcontact.TabIndex = 139
        Me.lbl_studcontact.Text = "Contact No"
        '
        'lbl_studname
        '
        Me.lbl_studname.AutoSize = True
        Me.lbl_studname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studname.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studname.Location = New System.Drawing.Point(417, 347)
        Me.lbl_studname.Name = "lbl_studname"
        Me.lbl_studname.Size = New System.Drawing.Size(85, 30)
        Me.lbl_studname.TabIndex = 138
        Me.lbl_studname.Text = "Name"
        '
        'lbl_studuname
        '
        Me.lbl_studuname.AutoSize = True
        Me.lbl_studuname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studuname.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studuname.Location = New System.Drawing.Point(419, 263)
        Me.lbl_studuname.Name = "lbl_studuname"
        Me.lbl_studuname.Size = New System.Drawing.Size(139, 30)
        Me.lbl_studuname.TabIndex = 137
        Me.lbl_studuname.Text = "Username"
        '
        'Update_Faculty
        '
        Me.AcceptButton = Me.btn_studsaves
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.txt_studcontact)
        Me.Controls.Add(Me.btn_studcancels)
        Me.Controls.Add(Me.btn_studclears)
        Me.Controls.Add(Me.btn_studsaves)
        Me.Controls.Add(Me.txt_studpword)
        Me.Controls.Add(Me.txt_advisory)
        Me.Controls.Add(Me.txt_studname)
        Me.Controls.Add(Me.txt_studuname)
        Me.Controls.Add(Me.lbl_studpword)
        Me.Controls.Add(Me.lbl_studgs)
        Me.Controls.Add(Me.lbl_studcontact)
        Me.Controls.Add(Me.lbl_studname)
        Me.Controls.Add(Me.lbl_studuname)
        Me.Name = "Update_Faculty"
        Me.Text = "Update Faculty - Faculty"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_studcontact As MaskedTextBox
    Friend WithEvents btn_studcancels As Button
    Friend WithEvents btn_studclears As Button
    Friend WithEvents btn_studsaves As Button
    Friend WithEvents txt_studpword As TextBox
    Friend WithEvents txt_advisory As TextBox
    Friend WithEvents txt_studname As TextBox
    Friend WithEvents txt_studuname As TextBox
    Friend WithEvents lbl_studpword As Label
    Friend WithEvents lbl_studgs As Label
    Friend WithEvents lbl_studcontact As Label
    Friend WithEvents lbl_studname As Label
    Friend WithEvents lbl_studuname As Label
End Class
