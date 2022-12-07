<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Book
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_isbn4 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_booknum = New System.Windows.Forms.TextBox()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.cmb_categoory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_title4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cancl = New System.Windows.Forms.Button()
        Me.btn_add1 = New System.Windows.Forms.Button()
        Me.txt_edition = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdb_old = New System.Windows.Forms.RadioButton()
        Me.rdb_new = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_auth_ln = New System.Windows.Forms.TextBox()
        Me.txt_auth_fn = New System.Windows.Forms.TextBox()
        Me.txt_auth_mn = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(377, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 156)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barcode"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(8, 469)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(268, 28)
        Me.txt_address.TabIndex = 103
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(8, 522)
        Me.txt_copyright.MaxLength = 100
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(268, 28)
        Me.txt_copyright.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Copyright"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 447)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Address"
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(313, 37)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(268, 28)
        Me.cmb_ddc.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 20)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Dewey Decimal Classification"
        '
        'txt_isbn4
        '
        Me.txt_isbn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn4.Location = New System.Drawing.Point(14, 161)
        Me.txt_isbn4.Name = "txt_isbn4"
        Me.txt_isbn4.Size = New System.Drawing.Size(266, 27)
        Me.txt_isbn4.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Book Number"
        '
        'txt_booknum
        '
        Me.txt_booknum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_booknum.Location = New System.Drawing.Point(13, 29)
        Me.txt_booknum.Multiline = True
        Me.txt_booknum.Name = "txt_booknum"
        Me.txt_booknum.ReadOnly = True
        Me.txt_booknum.Size = New System.Drawing.Size(268, 28)
        Me.txt_booknum.TabIndex = 94
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(8, 416)
        Me.txt_pubcom.MaxLength = 100
        Me.txt_pubcom.Multiline = True
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(268, 28)
        Me.txt_pubcom.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 20)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(377, 268)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Multiline = True
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(268, 28)
        Me.txt_year.TabIndex = 91
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_clear.Image = Global.Library_System.My.Resources.Resources.blue
        Me.btn_clear.Location = New System.Drawing.Point(375, 471)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(85, 35)
        Me.btn_clear.TabIndex = 90
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'cmb_categoory
        '
        Me.cmb_categoory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoory.FormattingEnabled = True
        Me.cmb_categoory.Location = New System.Drawing.Point(313, 164)
        Me.cmb_categoory.Name = "cmb_categoory"
        Me.cmb_categoory.Size = New System.Drawing.Size(268, 28)
        Me.cmb_categoory.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Publisher"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(317, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Title"
        '
        'txt_title4
        '
        Me.txt_title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title4.Location = New System.Drawing.Point(12, 216)
        Me.txt_title4.Multiline = True
        Me.txt_title4.Name = "txt_title4"
        Me.txt_title4.Size = New System.Drawing.Size(268, 28)
        Me.txt_title4.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "ISBN"
        '
        'btn_cancl
        '
        Me.btn_cancl.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancl.Image = Global.Library_System.My.Resources.Resources.blue
        Me.btn_cancl.Location = New System.Drawing.Point(560, 469)
        Me.btn_cancl.Name = "btn_cancl"
        Me.btn_cancl.Size = New System.Drawing.Size(85, 37)
        Me.btn_cancl.TabIndex = 82
        Me.btn_cancl.Text = "CANCEL"
        Me.btn_cancl.UseVisualStyleBackColor = False
        '
        'btn_add1
        '
        Me.btn_add1.BackColor = System.Drawing.Color.Transparent
        Me.btn_add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add1.Image = Global.Library_System.My.Resources.Resources.blue
        Me.btn_add1.Location = New System.Drawing.Point(467, 469)
        Me.btn_add1.Name = "btn_add1"
        Me.btn_add1.Size = New System.Drawing.Size(85, 37)
        Me.btn_add1.TabIndex = 81
        Me.btn_add1.Text = "ADD"
        Me.btn_add1.UseVisualStyleBackColor = False
        '
        'txt_edition
        '
        Me.txt_edition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edition.Location = New System.Drawing.Point(8, 589)
        Me.txt_edition.MaxLength = 100
        Me.txt_edition.Multiline = True
        Me.txt_edition.Name = "txt_edition"
        Me.txt_edition.Size = New System.Drawing.Size(268, 28)
        Me.txt_edition.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 567)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Edition"
        '
        'rdb_old
        '
        Me.rdb_old.AutoSize = True
        Me.rdb_old.BackColor = System.Drawing.Color.Transparent
        Me.rdb_old.Location = New System.Drawing.Point(17, 133)
        Me.rdb_old.Name = "rdb_old"
        Me.rdb_old.Size = New System.Drawing.Size(55, 22)
        Me.rdb_old.TabIndex = 109
        Me.rdb_old.TabStop = True
        Me.rdb_old.Text = "Old"
        Me.rdb_old.UseVisualStyleBackColor = False
        '
        'rdb_new
        '
        Me.rdb_new.AutoSize = True
        Me.rdb_new.BackColor = System.Drawing.Color.Transparent
        Me.rdb_new.Location = New System.Drawing.Point(78, 133)
        Me.rdb_new.Name = "rdb_new"
        Me.rdb_new.Size = New System.Drawing.Size(61, 22)
        Me.rdb_new.TabIndex = 110
        Me.rdb_new.TabStop = True
        Me.rdb_new.Text = "New"
        Me.rdb_new.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(20, 82)
        Me.txt_quantity.Multiline = True
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(266, 28)
        Me.txt_quantity.TabIndex = 111
        '
        'txt_auth_ln
        '
        Me.txt_auth_ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_ln.Location = New System.Drawing.Point(8, 270)
        Me.txt_auth_ln.Multiline = True
        Me.txt_auth_ln.Name = "txt_auth_ln"
        Me.txt_auth_ln.Size = New System.Drawing.Size(268, 28)
        Me.txt_auth_ln.TabIndex = 113
        Me.txt_auth_ln.Text = "Last Name"
        '
        'txt_auth_fn
        '
        Me.txt_auth_fn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_fn.Location = New System.Drawing.Point(8, 305)
        Me.txt_auth_fn.Multiline = True
        Me.txt_auth_fn.Name = "txt_auth_fn"
        Me.txt_auth_fn.Size = New System.Drawing.Size(268, 28)
        Me.txt_auth_fn.TabIndex = 114
        Me.txt_auth_fn.Text = "First Name"
        '
        'txt_auth_mn
        '
        Me.txt_auth_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_mn.Location = New System.Drawing.Point(8, 339)
        Me.txt_auth_mn.Multiline = True
        Me.txt_auth_mn.Name = "txt_auth_mn"
        Me.txt_auth_mn.Size = New System.Drawing.Size(268, 28)
        Me.txt_auth_mn.TabIndex = 115
        Me.txt_auth_mn.Text = "Middle Name"
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_auth_mn)
        Me.Controls.Add(Me.txt_auth_fn)
        Me.Controls.Add(Me.txt_auth_ln)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.rdb_new)
        Me.Controls.Add(Me.rdb_old)
        Me.Controls.Add(Me.txt_edition)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_copyright)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_isbn4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_booknum)
        Me.Controls.Add(Me.txt_pubcom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cmb_categoory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_title4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancl)
        Me.Controls.Add(Me.btn_add1)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Book - Admin"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_isbn4 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_booknum As TextBox
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents cmb_categoory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_title4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_cancl As Button
    Friend WithEvents btn_add1 As Button
    Friend WithEvents txt_edition As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rdb_old As RadioButton
    Friend WithEvents rdb_new As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_auth_ln As TextBox
    Friend WithEvents txt_auth_fn As TextBox
    Friend WithEvents txt_auth_mn As TextBox
End Class
