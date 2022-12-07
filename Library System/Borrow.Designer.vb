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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.btn_clear2 = New System.Windows.Forms.Button()
        Me.rb_student = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rb_faculty = New System.Windows.Forms.RadioButton()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_teacher = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_gradesecc = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.rb_printed = New System.Windows.Forms.RadioButton()
        Me.rb_nonprinted = New System.Windows.Forms.RadioButton()
        Me.txt_isbnn = New System.Windows.Forms.MaskedTextBox()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.txt_auth_mn = New System.Windows.Forms.TextBox()
        Me.txt_auth_fn = New System.Windows.Forms.TextBox()
        Me.txt_auth_ln = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_edition = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_duedate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.dtp_dateborr = New System.Windows.Forms.DateTimePicker()
        Me.lbl_matname = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_matno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_bookno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.cmb_categooory = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_titlee = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_damaged = New System.Windows.Forms.RadioButton()
        Me.rb_good = New System.Windows.Forms.RadioButton()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 23)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Name"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Library_System.My.Resources.Resources.blue
        Me.Button1.Location = New System.Drawing.Point(542, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 34)
        Me.Button1.TabIndex = 227
        Me.Button1.Text = "BORROW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.txt_idno)
        Me.GroupBox2.Controls.Add(Me.btn_clear2)
        Me.GroupBox2.Controls.Add(Me.rb_student)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.rb_faculty)
        Me.GroupBox2.Controls.Add(Me.txt_namee)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_teacher)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_gradesecc)
        Me.GroupBox2.Controls.Add(Me.txt_num)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 375)
        Me.GroupBox2.TabIndex = 232
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower Information"
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(35, 98)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(139, 29)
        Me.txt_idno.TabIndex = 133
        '
        'btn_clear2
        '
        Me.btn_clear2.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear2.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear2.ForeColor = System.Drawing.Color.White
        Me.btn_clear2.Image = CType(resources.GetObject("btn_clear2.Image"), System.Drawing.Image)
        Me.btn_clear2.Location = New System.Drawing.Point(145, 315)
        Me.btn_clear2.Name = "btn_clear2"
        Me.btn_clear2.Size = New System.Drawing.Size(112, 36)
        Me.btn_clear2.TabIndex = 230
        Me.btn_clear2.Text = "CLEAR"
        Me.btn_clear2.UseVisualStyleBackColor = False
        '
        'rb_student
        '
        Me.rb_student.AutoSize = True
        Me.rb_student.BackColor = System.Drawing.Color.Transparent
        Me.rb_student.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_student.Location = New System.Drawing.Point(201, 55)
        Me.rb_student.Name = "rb_student"
        Me.rb_student.Size = New System.Drawing.Size(102, 27)
        Me.rb_student.TabIndex = 142
        Me.rb_student.TabStop = True
        Me.rb_student.Text = "Student"
        Me.rb_student.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 23)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "User Level"
        '
        'rb_faculty
        '
        Me.rb_faculty.AutoSize = True
        Me.rb_faculty.BackColor = System.Drawing.Color.Transparent
        Me.rb_faculty.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_faculty.Location = New System.Drawing.Point(97, 55)
        Me.rb_faculty.Name = "rb_faculty"
        Me.rb_faculty.Size = New System.Drawing.Size(98, 27)
        Me.rb_faculty.TabIndex = 141
        Me.rb_faculty.Text = "Faculty"
        Me.rb_faculty.UseVisualStyleBackColor = False
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(35, 156)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(384, 26)
        Me.txt_namee.TabIndex = 135
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 23)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Teacher"
        '
        'txt_teacher
        '
        Me.txt_teacher.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_teacher.Location = New System.Drawing.Point(40, 277)
        Me.txt_teacher.Multiline = True
        Me.txt_teacher.Name = "txt_teacher"
        Me.txt_teacher.Size = New System.Drawing.Size(379, 26)
        Me.txt_teacher.TabIndex = 226
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 23)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Grade and Section"
        '
        'txt_gradesecc
        '
        Me.txt_gradesecc.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gradesecc.Location = New System.Drawing.Point(232, 214)
        Me.txt_gradesecc.Multiline = True
        Me.txt_gradesecc.Name = "txt_gradesecc"
        Me.txt_gradesecc.Size = New System.Drawing.Size(187, 26)
        Me.txt_gradesecc.TabIndex = 224
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.Location = New System.Drawing.Point(35, 211)
        Me.txt_num.Mask = "(+63) 000-0000-000"
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(187, 29)
        Me.txt_num.TabIndex = 146
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Contact No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "No."
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 17)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1570, 290)
        Me.ListView1.TabIndex = 216
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1582, 358)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lbl_material)
        Me.GroupBox1.Controls.Add(Me.rb_printed)
        Me.GroupBox1.Controls.Add(Me.rb_nonprinted)
        Me.GroupBox1.Controls.Add(Me.txt_isbnn)
        Me.GroupBox1.Controls.Add(Me.txt_copyright)
        Me.GroupBox1.Controls.Add(Me.txt_auth_mn)
        Me.GroupBox1.Controls.Add(Me.txt_auth_fn)
        Me.GroupBox1.Controls.Add(Me.txt_auth_ln)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_edition)
        Me.GroupBox1.Controls.Add(Me.btn_clear)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.txt_duedate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.dtp_dateborr)
        Me.GroupBox1.Controls.Add(Me.lbl_matname)
        Me.GroupBox1.Controls.Add(Me.txt_matname)
        Me.GroupBox1.Controls.Add(Me.lbl_matno)
        Me.GroupBox1.Controls.Add(Me.txt_matno)
        Me.GroupBox1.Controls.Add(Me.cmb_ddc)
        Me.GroupBox1.Controls.Add(Me.Label8)
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
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_titlee)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(464, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1130, 375)
        Me.GroupBox1.TabIndex = 233
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Information"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.BackColor = System.Drawing.Color.Transparent
        Me.lbl_material.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(26, 27)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(87, 23)
        Me.lbl_material.TabIndex = 262
        Me.lbl_material.Text = "Material"
        '
        'rb_printed
        '
        Me.rb_printed.AutoSize = True
        Me.rb_printed.BackColor = System.Drawing.Color.Transparent
        Me.rb_printed.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_printed.Location = New System.Drawing.Point(46, 48)
        Me.rb_printed.Name = "rb_printed"
        Me.rb_printed.Size = New System.Drawing.Size(98, 27)
        Me.rb_printed.TabIndex = 261
        Me.rb_printed.Text = "Printed"
        Me.rb_printed.UseVisualStyleBackColor = False
        '
        'rb_nonprinted
        '
        Me.rb_nonprinted.AutoSize = True
        Me.rb_nonprinted.BackColor = System.Drawing.Color.Transparent
        Me.rb_nonprinted.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nonprinted.Location = New System.Drawing.Point(46, 71)
        Me.rb_nonprinted.Name = "rb_nonprinted"
        Me.rb_nonprinted.Size = New System.Drawing.Size(141, 27)
        Me.rb_nonprinted.TabIndex = 260
        Me.rb_nonprinted.TabStop = True
        Me.rb_nonprinted.Text = "Non-Printed"
        Me.rb_nonprinted.UseVisualStyleBackColor = False
        '
        'txt_isbnn
        '
        Me.txt_isbnn.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbnn.Location = New System.Drawing.Point(399, 36)
        Me.txt_isbnn.Name = "txt_isbnn"
        Me.txt_isbnn.Size = New System.Drawing.Size(359, 29)
        Me.txt_isbnn.TabIndex = 173
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(776, 139)
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(348, 26)
        Me.txt_copyright.TabIndex = 247
        '
        'txt_auth_mn
        '
        Me.txt_auth_mn.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_mn.Location = New System.Drawing.Point(21, 319)
        Me.txt_auth_mn.Multiline = True
        Me.txt_auth_mn.Name = "txt_auth_mn"
        Me.txt_auth_mn.Size = New System.Drawing.Size(359, 28)
        Me.txt_auth_mn.TabIndex = 256
        Me.txt_auth_mn.Text = "Middle Name"
        '
        'txt_auth_fn
        '
        Me.txt_auth_fn.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_fn.Location = New System.Drawing.Point(21, 285)
        Me.txt_auth_fn.Multiline = True
        Me.txt_auth_fn.Name = "txt_auth_fn"
        Me.txt_auth_fn.Size = New System.Drawing.Size(359, 28)
        Me.txt_auth_fn.TabIndex = 255
        Me.txt_auth_fn.Text = "First Name"
        '
        'txt_auth_ln
        '
        Me.txt_auth_ln.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_ln.Location = New System.Drawing.Point(21, 251)
        Me.txt_auth_ln.Multiline = True
        Me.txt_auth_ln.Name = "txt_auth_ln"
        Me.txt_auth_ln.Size = New System.Drawing.Size(359, 28)
        Me.txt_auth_ln.TabIndex = 254
        Me.txt_auth_ln.Text = "Last Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 23)
        Me.Label18.TabIndex = 253
        Me.Label18.Text = "Author"
        '
        'txt_edition
        '
        Me.txt_edition.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edition.Location = New System.Drawing.Point(399, 138)
        Me.txt_edition.Multiline = True
        Me.txt_edition.Name = "txt_edition"
        Me.txt_edition.Size = New System.Drawing.Size(359, 26)
        Me.txt_edition.TabIndex = 252
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(1012, 296)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(112, 36)
        Me.btn_clear.TabIndex = 229
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Beige
        Me.btn_add.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(776, 296)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(110, 36)
        Me.btn_add.TabIndex = 228
        Me.btn_add.Text = "SAVE"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'txt_duedate
        '
        Me.txt_duedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duedate.Location = New System.Drawing.Point(776, 243)
        Me.txt_duedate.Name = "txt_duedate"
        Me.txt_duedate.Size = New System.Drawing.Size(348, 28)
        Me.txt_duedate.TabIndex = 249
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(773, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 23)
        Me.Label4.TabIndex = 248
        Me.Label4.Text = "Copyright"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(887, 296)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(123, 36)
        Me.btn_cancel.TabIndex = 148
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(396, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 23)
        Me.Label13.TabIndex = 246
        Me.Label13.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(400, 303)
        Me.txt_address.MaxLength = 13423423
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(358, 29)
        Me.txt_address.TabIndex = 245
        '
        'dtp_dateborr
        '
        Me.dtp_dateborr.CustomFormat = "dd/MM/yyyy - hh:mm tt"
        Me.dtp_dateborr.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dateborr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dateborr.Location = New System.Drawing.Point(776, 190)
        Me.dtp_dateborr.Name = "dtp_dateborr"
        Me.dtp_dateborr.Size = New System.Drawing.Size(348, 29)
        Me.dtp_dateborr.TabIndex = 171
        Me.dtp_dateborr.Value = New Date(2022, 11, 27, 0, 0, 0, 0)
        '
        'lbl_matname
        '
        Me.lbl_matname.AutoSize = True
        Me.lbl_matname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matname.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matname.Location = New System.Drawing.Point(209, 109)
        Me.lbl_matname.Name = "lbl_matname"
        Me.lbl_matname.Size = New System.Drawing.Size(145, 23)
        Me.lbl_matname.TabIndex = 220
        Me.lbl_matname.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(199, 135)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(181, 29)
        Me.txt_matname.TabIndex = 219
        '
        'lbl_matno
        '
        Me.lbl_matno.AutoSize = True
        Me.lbl_matno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matno.Location = New System.Drawing.Point(17, 112)
        Me.lbl_matno.Name = "lbl_matno"
        Me.lbl_matno.Size = New System.Drawing.Size(165, 23)
        Me.lbl_matno.TabIndex = 218
        Me.lbl_matno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(21, 135)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(172, 29)
        Me.txt_matno.TabIndex = 217
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(399, 190)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(359, 30)
        Me.cmb_ddc.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 23)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Dewey Decimal Classification"
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(24, 167)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(133, 23)
        Me.lbl_bookno.TabIndex = 169
        Me.lbl_bookno.Text = "Book Number"
        '
        'txt_bookno
        '
        Me.txt_bookno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bookno.Location = New System.Drawing.Point(21, 191)
        Me.txt_bookno.MaxLength = 17
        Me.txt_bookno.Name = "txt_bookno"
        Me.txt_bookno.Size = New System.Drawing.Size(359, 29)
        Me.txt_bookno.TabIndex = 168
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(772, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 23)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(776, 34)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(348, 29)
        Me.txt_year.TabIndex = 164
        '
        'cmb_categooory
        '
        Me.cmb_categooory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categooory.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categooory.FormattingEnabled = True
        Me.cmb_categooory.Location = New System.Drawing.Point(399, 243)
        Me.cmb_categooory.Name = "cmb_categooory"
        Me.cmb_categooory.Size = New System.Drawing.Size(359, 30)
        Me.cmb_categooory.TabIndex = 163
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(773, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 23)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Due Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(773, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 23)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Borrowed Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(773, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 23)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Publisher"
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(776, 86)
        Me.txt_pubcom.Multiline = True
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(348, 28)
        Me.txt_pubcom.TabIndex = 157
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 23)
        Me.Label14.TabIndex = 155
        Me.Label14.Text = "Category"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(396, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 23)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "Edition"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(395, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 23)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "Title"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(395, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 23)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = "ISBN"
        '
        'txt_titlee
        '
        Me.txt_titlee.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titlee.Location = New System.Drawing.Point(399, 87)
        Me.txt_titlee.Multiline = True
        Me.txt_titlee.Name = "txt_titlee"
        Me.txt_titlee.Size = New System.Drawing.Size(359, 26)
        Me.txt_titlee.TabIndex = 223
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_damaged)
        Me.Panel2.Controls.Add(Me.rb_good)
        Me.Panel2.Controls.Add(Me.lbl_condition)
        Me.Panel2.Location = New System.Drawing.Point(200, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 87)
        Me.Panel2.TabIndex = 259
        '
        'rb_damaged
        '
        Me.rb_damaged.AutoSize = True
        Me.rb_damaged.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_damaged.Location = New System.Drawing.Point(44, 51)
        Me.rb_damaged.Name = "rb_damaged"
        Me.rb_damaged.Size = New System.Drawing.Size(116, 27)
        Me.rb_damaged.TabIndex = 251
        Me.rb_damaged.TabStop = True
        Me.rb_damaged.Text = "Damaged"
        Me.rb_damaged.UseVisualStyleBackColor = True
        '
        'rb_good
        '
        Me.rb_good.AutoSize = True
        Me.rb_good.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_good.Location = New System.Drawing.Point(44, 27)
        Me.rb_good.Name = "rb_good"
        Me.rb_good.Size = New System.Drawing.Size(77, 27)
        Me.rb_good.TabIndex = 250
        Me.rb_good.TabStop = True
        Me.rb_good.Text = "Good"
        Me.rb_good.UseVisualStyleBackColor = True
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.BackColor = System.Drawing.Color.Transparent
        Me.lbl_condition.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition.Location = New System.Drawing.Point(9, 7)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(98, 23)
        Me.lbl_condition.TabIndex = 257
        Me.lbl_condition.Text = "Condition"
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1622, 773)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow Book"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_student As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents rb_faculty As RadioButton
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_teacher As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_gradesecc As TextBox
    Friend WithEvents txt_num As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_clear2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_isbnn As MaskedTextBox
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents lbl_condition As Label
    Friend WithEvents txt_auth_mn As TextBox
    Friend WithEvents txt_auth_fn As TextBox
    Friend WithEvents txt_auth_ln As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_edition As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents rb_damaged As RadioButton
    Friend WithEvents rb_good As RadioButton
    Friend WithEvents txt_duedate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_titlee As TextBox
    Friend WithEvents dtp_dateborr As DateTimePicker
    Friend WithEvents lbl_matname As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_matno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_bookno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents cmb_categooory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_material As Label
    Friend WithEvents rb_printed As RadioButton
    Friend WithEvents rb_nonprinted As RadioButton
End Class
