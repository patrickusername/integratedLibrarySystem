<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Borrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrow))
        Me.cmb_categooory = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_authorr = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_bookno = New System.Windows.Forms.TextBox()
        Me.dtp_datetorett = New System.Windows.Forms.DateTimePicker()
        Me.txt_isbnn = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lbl_matname = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_matno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.rb_printed = New System.Windows.Forms.RadioButton()
        Me.rb_nonprinted = New System.Windows.Forms.RadioButton()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_titlee = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_teacher = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_gradesecc = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rb_student = New System.Windows.Forms.RadioButton()
        Me.rb_faculty = New System.Windows.Forms.RadioButton()
        Me.txt_num = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.dtp_dateborr = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_categooory
        '
        Me.cmb_categooory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categooory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categooory.FormattingEnabled = True
        Me.cmb_categooory.Location = New System.Drawing.Point(608, 361)
        Me.cmb_categooory.Name = "cmb_categooory"
        Me.cmb_categooory.Size = New System.Drawing.Size(540, 33)
        Me.cmb_categooory.TabIndex = 163
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(896, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 25)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Due Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(614, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 25)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Borrowed Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(618, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 25)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Publisher"
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(611, 222)
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(540, 30)
        Me.txt_pubcom.TabIndex = 157
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(615, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 25)
        Me.Label14.TabIndex = 155
        Me.Label14.Text = "Category"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 404)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 25)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "Author"
        '
        'txt_authorr
        '
        Me.txt_authorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_authorr.Location = New System.Drawing.Point(27, 432)
        Me.txt_authorr.Multiline = True
        Me.txt_authorr.Name = "txt_authorr"
        Me.txt_authorr.Size = New System.Drawing.Size(540, 31)
        Me.txt_authorr.TabIndex = 153
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 333)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 25)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "Title"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 25)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = "ISBN"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(262, 413)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(128, 60)
        Me.btn_cancel.TabIndex = 148
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(606, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(611, 161)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(256, 30)
        Me.txt_year.TabIndex = 164
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(30, 188)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(131, 25)
        Me.lbl_bookno.TabIndex = 169
        Me.lbl_bookno.Text = "Book Number"
        '
        'txt_bookno
        '
        Me.txt_bookno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bookno.Location = New System.Drawing.Point(27, 221)
        Me.txt_bookno.MaxLength = 17
        Me.txt_bookno.Name = "txt_bookno"
        Me.txt_bookno.Size = New System.Drawing.Size(543, 30)
        Me.txt_bookno.TabIndex = 168
        '
        'dtp_datetorett
        '
        Me.dtp_datetorett.CustomFormat = ""
        Me.dtp_datetorett.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_datetorett.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_datetorett.Location = New System.Drawing.Point(890, 433)
        Me.dtp_datetorett.Name = "dtp_datetorett"
        Me.dtp_datetorett.Size = New System.Drawing.Size(258, 30)
        Me.dtp_datetorett.TabIndex = 172
        Me.dtp_datetorett.Value = New Date(2022, 9, 21, 0, 0, 0, 0)
        '
        'txt_isbnn
        '
        Me.txt_isbnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbnn.Location = New System.Drawing.Point(27, 288)
        Me.txt_isbnn.Mask = "000-0-00000-000-0"
        Me.txt_isbnn.Name = "txt_isbnn"
        Me.txt_isbnn.Size = New System.Drawing.Size(540, 30)
        Me.txt_isbnn.TabIndex = 173
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(610, 297)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(540, 33)
        Me.cmb_ddc.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(615, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 25)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Dewey Decimal Classification"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(16, 17)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1766, 272)
        Me.ListView1.TabIndex = 216
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'lbl_matname
        '
        Me.lbl_matname.AutoSize = True
        Me.lbl_matname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matname.Location = New System.Drawing.Point(289, 110)
        Me.lbl_matname.Name = "lbl_matname"
        Me.lbl_matname.Size = New System.Drawing.Size(138, 25)
        Me.lbl_matname.TabIndex = 220
        Me.lbl_matname.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(294, 145)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(276, 30)
        Me.txt_matname.TabIndex = 219
        '
        'lbl_matno
        '
        Me.lbl_matno.AutoSize = True
        Me.lbl_matno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matno.Location = New System.Drawing.Point(32, 110)
        Me.lbl_matno.Name = "lbl_matno"
        Me.lbl_matno.Size = New System.Drawing.Size(155, 25)
        Me.lbl_matno.TabIndex = 218
        Me.lbl_matno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(30, 144)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(228, 30)
        Me.txt_matno.TabIndex = 217
        '
        'rb_printed
        '
        Me.rb_printed.AutoSize = True
        Me.rb_printed.BackColor = System.Drawing.Color.Transparent
        Me.rb_printed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_printed.Location = New System.Drawing.Point(89, 37)
        Me.rb_printed.Name = "rb_printed"
        Me.rb_printed.Size = New System.Drawing.Size(94, 29)
        Me.rb_printed.TabIndex = 179
        Me.rb_printed.Text = "Printed"
        Me.rb_printed.UseVisualStyleBackColor = False
        '
        'rb_nonprinted
        '
        Me.rb_nonprinted.AutoSize = True
        Me.rb_nonprinted.BackColor = System.Drawing.Color.Transparent
        Me.rb_nonprinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nonprinted.Location = New System.Drawing.Point(200, 37)
        Me.rb_nonprinted.Name = "rb_nonprinted"
        Me.rb_nonprinted.Size = New System.Drawing.Size(137, 29)
        Me.rb_nonprinted.TabIndex = 180
        Me.rb_nonprinted.TabStop = True
        Me.rb_nonprinted.Text = "Non-Printed"
        Me.rb_nonprinted.UseVisualStyleBackColor = False
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.BackColor = System.Drawing.Color.Transparent
        Me.lbl_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(20, 16)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(81, 25)
        Me.lbl_material.TabIndex = 181
        Me.lbl_material.Text = "Material"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_material)
        Me.Panel1.Controls.Add(Me.rb_nonprinted)
        Me.Panel1.Controls.Add(Me.rb_printed)
        Me.Panel1.Location = New System.Drawing.Point(6, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 80)
        Me.Panel1.TabIndex = 222
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_copyright)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_titlee)
        Me.GroupBox1.Controls.Add(Me.dtp_datetorett)
        Me.GroupBox1.Controls.Add(Me.dtp_dateborr)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.lbl_matname)
        Me.GroupBox1.Controls.Add(Me.txt_matname)
        Me.GroupBox1.Controls.Add(Me.lbl_matno)
        Me.GroupBox1.Controls.Add(Me.txt_matno)
        Me.GroupBox1.Controls.Add(Me.cmb_ddc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_isbnn)
        Me.GroupBox1.Controls.Add(Me.lbl_bookno)
        Me.GroupBox1.Controls.Add(Me.txt_bookno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.cmb_categooory)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_pubcom)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_authorr)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1159, 486)
        Me.GroupBox1.TabIndex = 224
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(615, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 244
        Me.Label4.Text = "Copyright"
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(610, 91)
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(430, 32)
        Me.txt_copyright.TabIndex = 243
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(618, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 25)
        Me.Label13.TabIndex = 242
        Me.Label13.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(608, 29)
        Me.txt_address.MaxLength = 13
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(430, 32)
        Me.txt_address.TabIndex = 241
        '
        'txt_titlee
        '
        Me.txt_titlee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titlee.Location = New System.Drawing.Point(27, 361)
        Me.txt_titlee.Multiline = True
        Me.txt_titlee.Name = "txt_titlee"
        Me.txt_titlee.Size = New System.Drawing.Size(540, 31)
        Me.txt_titlee.TabIndex = 223
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(422, 413)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(128, 60)
        Me.btn_clear.TabIndex = 229
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Beige
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(58, 413)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(169, 60)
        Me.btn_add.TabIndex = 228
        Me.btn_add.Text = "Borrow"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 504)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1801, 339)
        Me.GroupBox3.TabIndex = 228
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1469, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 38)
        Me.Button1.TabIndex = 227
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_teacher)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_cancel)
        Me.GroupBox2.Controls.Add(Me.txt_gradesecc)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txt_num)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_namee)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_idno)
        Me.GroupBox2.Location = New System.Drawing.Point(1196, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 486)
        Me.GroupBox2.TabIndex = 229
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(327, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 25)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Teacher"
        '
        'txt_teacher
        '
        Me.txt_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_teacher.Location = New System.Drawing.Point(332, 360)
        Me.txt_teacher.Multiline = True
        Me.txt_teacher.Name = "txt_teacher"
        Me.txt_teacher.Size = New System.Drawing.Size(257, 31)
        Me.txt_teacher.TabIndex = 226
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 25)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Grade and Section"
        '
        'txt_gradesecc
        '
        Me.txt_gradesecc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gradesecc.Location = New System.Drawing.Point(45, 360)
        Me.txt_gradesecc.Multiline = True
        Me.txt_gradesecc.Name = "txt_gradesecc"
        Me.txt_gradesecc.Size = New System.Drawing.Size(257, 31)
        Me.txt_gradesecc.TabIndex = 224
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.rb_student)
        Me.Panel2.Controls.Add(Me.rb_faculty)
        Me.Panel2.Location = New System.Drawing.Point(16, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(572, 81)
        Me.Panel2.TabIndex = 223
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "User Level"
        '
        'rb_student
        '
        Me.rb_student.AutoSize = True
        Me.rb_student.BackColor = System.Drawing.Color.Transparent
        Me.rb_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_student.Location = New System.Drawing.Point(233, 47)
        Me.rb_student.Name = "rb_student"
        Me.rb_student.Size = New System.Drawing.Size(101, 29)
        Me.rb_student.TabIndex = 142
        Me.rb_student.TabStop = True
        Me.rb_student.Text = "Student"
        Me.rb_student.UseVisualStyleBackColor = False
        '
        'rb_faculty
        '
        Me.rb_faculty.AutoSize = True
        Me.rb_faculty.BackColor = System.Drawing.Color.Transparent
        Me.rb_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_faculty.Location = New System.Drawing.Point(122, 47)
        Me.rb_faculty.Name = "rb_faculty"
        Me.rb_faculty.Size = New System.Drawing.Size(96, 29)
        Me.rb_faculty.TabIndex = 141
        Me.rb_faculty.Text = "Faculty"
        Me.rb_faculty.UseVisualStyleBackColor = False
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.Location = New System.Drawing.Point(49, 272)
        Me.txt_num.Mask = "(+63) 000-0000-000"
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(540, 30)
        Me.txt_num.TabIndex = 146
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Contact No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Name"
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(49, 201)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(540, 31)
        Me.txt_namee.TabIndex = 135
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "No."
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(49, 126)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(540, 30)
        Me.txt_idno.TabIndex = 133
        '
        'dtp_dateborr
        '
        Me.dtp_dateborr.CustomFormat = "dd/MM/yyyy--HH-mm"
        Me.dtp_dateborr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dateborr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dateborr.Location = New System.Drawing.Point(608, 433)
        Me.dtp_dateborr.Name = "dtp_dateborr"
        Me.dtp_dateborr.Size = New System.Drawing.Size(253, 30)
        Me.dtp_dateborr.TabIndex = 171
        Me.dtp_dateborr.Value = New Date(2022, 9, 21, 0, 0, 0, 0)
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1843, 869)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Borrow"
        Me.Text = "Borrow Book - Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmb_categooory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_authorr As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_bookno As TextBox
    Friend WithEvents dtp_datetorett As DateTimePicker
    Friend WithEvents txt_isbnn As MaskedTextBox
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lbl_matname As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_matno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents rb_printed As RadioButton
    Friend WithEvents rb_nonprinted As RadioButton
    Friend WithEvents lbl_material As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_teacher As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_gradesecc As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents rb_student As RadioButton
    Friend WithEvents rb_faculty As RadioButton
    Friend WithEvents txt_num As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents txt_titlee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents dtp_dateborr As DateTimePicker
End Class
