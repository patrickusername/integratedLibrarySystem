<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnBook))
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rb_damaged = New System.Windows.Forms.RadioButton()
        Me.lbl_materialstat = New System.Windows.Forms.Label()
        Me.rb_good = New System.Windows.Forms.RadioButton()
        Me.rb_nonprinted = New System.Windows.Forms.RadioButton()
        Me.rb_printed = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_matname = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_matno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_isbnn1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_dateret = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_datetoreturn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_bookno = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.cmb_categooory1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_titlee1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_cncl1 = New System.Windows.Forms.Button()
        Me.btn_save0 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_auth_mn = New System.Windows.Forms.TextBox()
        Me.txt_auth_fn = New System.Windows.Forms.TextBox()
        Me.txt_auth_ln = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_edition = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(21, 621)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(374, 28)
        Me.txt_address.TabIndex = 288
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(21, 674)
        Me.txt_copyright.MaxLength = 100
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(374, 28)
        Me.txt_copyright.TabIndex = 287
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 648)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 23)
        Me.Label14.TabIndex = 286
        Me.Label14.Text = "Copyright"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 596)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 23)
        Me.Label17.TabIndex = 285
        Me.Label17.Text = "Address"
        '
        'rb_damaged
        '
        Me.rb_damaged.AutoSize = True
        Me.rb_damaged.BackColor = System.Drawing.Color.Transparent
        Me.rb_damaged.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_damaged.Location = New System.Drawing.Point(193, 20)
        Me.rb_damaged.Name = "rb_damaged"
        Me.rb_damaged.Size = New System.Drawing.Size(116, 27)
        Me.rb_damaged.TabIndex = 260
        Me.rb_damaged.TabStop = True
        Me.rb_damaged.Text = "Damaged"
        Me.rb_damaged.UseVisualStyleBackColor = False
        '
        'lbl_materialstat
        '
        Me.lbl_materialstat.AutoSize = True
        Me.lbl_materialstat.BackColor = System.Drawing.Color.Transparent
        Me.lbl_materialstat.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_materialstat.Location = New System.Drawing.Point(24, 79)
        Me.lbl_materialstat.Name = "lbl_materialstat"
        Me.lbl_materialstat.Size = New System.Drawing.Size(150, 23)
        Me.lbl_materialstat.TabIndex = 262
        Me.lbl_materialstat.Text = "Material Status"
        '
        'rb_good
        '
        Me.rb_good.AutoSize = True
        Me.rb_good.BackColor = System.Drawing.Color.Transparent
        Me.rb_good.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_good.Location = New System.Drawing.Point(64, 22)
        Me.rb_good.Name = "rb_good"
        Me.rb_good.Size = New System.Drawing.Size(77, 27)
        Me.rb_good.TabIndex = 258
        Me.rb_good.Text = "Good"
        Me.rb_good.UseVisualStyleBackColor = False
        '
        'rb_nonprinted
        '
        Me.rb_nonprinted.AutoSize = True
        Me.rb_nonprinted.BackColor = System.Drawing.Color.Transparent
        Me.rb_nonprinted.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nonprinted.Location = New System.Drawing.Point(192, 42)
        Me.rb_nonprinted.Name = "rb_nonprinted"
        Me.rb_nonprinted.Size = New System.Drawing.Size(141, 27)
        Me.rb_nonprinted.TabIndex = 261
        Me.rb_nonprinted.TabStop = True
        Me.rb_nonprinted.Text = "Non-Printed"
        Me.rb_nonprinted.UseVisualStyleBackColor = False
        '
        'rb_printed
        '
        Me.rb_printed.AutoSize = True
        Me.rb_printed.BackColor = System.Drawing.Color.Transparent
        Me.rb_printed.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_printed.Location = New System.Drawing.Point(64, 42)
        Me.rb_printed.Name = "rb_printed"
        Me.rb_printed.Size = New System.Drawing.Size(98, 27)
        Me.rb_printed.TabIndex = 259
        Me.rb_printed.Text = "Printed"
        Me.rb_printed.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 23)
        Me.Label8.TabIndex = 284
        Me.Label8.Text = "Material"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(724, 656)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(136, 43)
        Me.btn_save.TabIndex = 283
        Me.btn_save.Text = "RETURN"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'lbl_matname
        '
        Me.lbl_matname.AutoSize = True
        Me.lbl_matname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matname.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matname.Location = New System.Drawing.Point(215, 146)
        Me.lbl_matname.Name = "lbl_matname"
        Me.lbl_matname.Size = New System.Drawing.Size(145, 23)
        Me.lbl_matname.TabIndex = 282
        Me.lbl_matname.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(213, 167)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(182, 29)
        Me.txt_matname.TabIndex = 281
        '
        'lbl_matno
        '
        Me.lbl_matno.AutoSize = True
        Me.lbl_matno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matno.Location = New System.Drawing.Point(24, 146)
        Me.lbl_matno.Name = "lbl_matno"
        Me.lbl_matno.Size = New System.Drawing.Size(165, 23)
        Me.lbl_matno.TabIndex = 280
        Me.lbl_matno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(21, 167)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(182, 29)
        Me.txt_matno.TabIndex = 279
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(852, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 23)
        Me.Label15.TabIndex = 278
        Me.Label15.Text = "Name"
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(846, 106)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(374, 27)
        Me.txt_namee.TabIndex = 277
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(852, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 23)
        Me.Label16.TabIndex = 276
        Me.Label16.Text = "ID No."
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(846, 47)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(374, 29)
        Me.txt_idno.TabIndex = 275
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(426, 189)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(794, 460)
        Me.ListView1.TabIndex = 274
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(20, 446)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(374, 30)
        Me.cmb_ddc.TabIndex = 273
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 422)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(274, 23)
        Me.Label12.TabIndex = 272
        Me.Label12.Text = "Dewey Decimal Classification"
        '
        'txt_isbnn1
        '
        Me.txt_isbnn1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbnn1.Location = New System.Drawing.Point(21, 283)
        Me.txt_isbnn1.Name = "txt_isbnn1"
        Me.txt_isbnn1.Size = New System.Drawing.Size(374, 29)
        Me.txt_isbnn1.TabIndex = 269
        '
        'txt_dateret
        '
        Me.txt_dateret.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dateret.Location = New System.Drawing.Point(628, 47)
        Me.txt_dateret.Name = "txt_dateret"
        Me.txt_dateret.ReadOnly = True
        Me.txt_dateret.Size = New System.Drawing.Size(174, 29)
        Me.txt_dateret.TabIndex = 268
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(496, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(317, 23)
        Me.Label13.TabIndex = 267
        Me.Label13.Text = "(If late, please indicate the reason)"
        '
        'txt_datetoreturn
        '
        Me.txt_datetoreturn.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoreturn.Location = New System.Drawing.Point(428, 47)
        Me.txt_datetoreturn.Multiline = True
        Me.txt_datetoreturn.Name = "txt_datetoreturn"
        Me.txt_datetoreturn.Size = New System.Drawing.Size(178, 26)
        Me.txt_datetoreturn.TabIndex = 266
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(438, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 23)
        Me.Label11.TabIndex = 265
        Me.Label11.Text = "Due Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 540)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 23)
        Me.Label10.TabIndex = 264
        Me.Label10.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(20, 562)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(182, 29)
        Me.txt_year.TabIndex = 263
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(24, 203)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(133, 23)
        Me.lbl_bookno.TabIndex = 257
        Me.lbl_bookno.Text = "Book Number"
        '
        'txt_bookno
        '
        Me.txt_bookno.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bookno.Location = New System.Drawing.Point(21, 227)
        Me.txt_bookno.MaxLength = 17
        Me.txt_bookno.Name = "txt_bookno"
        Me.txt_bookno.Size = New System.Drawing.Size(374, 29)
        Me.txt_bookno.TabIndex = 256
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(579, 146)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(112, 37)
        Me.btn_clear.TabIndex = 255
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'cmb_categooory1
        '
        Me.cmb_categooory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categooory1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categooory1.FormattingEnabled = True
        Me.cmb_categooory1.Location = New System.Drawing.Point(20, 502)
        Me.cmb_categooory1.Name = "cmb_categooory1"
        Me.cmb_categooory1.Size = New System.Drawing.Size(374, 30)
        Me.cmb_categooory1.TabIndex = 254
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 253
        Me.Label6.Text = "Reason"
        '
        'txt_reason
        '
        Me.txt_reason.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reason.Location = New System.Drawing.Point(428, 108)
        Me.txt_reason.Multiline = True
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(374, 27)
        Me.txt_reason.TabIndex = 252
        Me.txt_reason.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(635, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 23)
        Me.Label9.TabIndex = 251
        Me.Label9.Text = "Returned Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 23)
        Me.Label5.TabIndex = 250
        Me.Label5.Text = "Publisher"
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(212, 562)
        Me.txt_pubcom.Multiline = True
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(182, 29)
        Me.txt_pubcom.TabIndex = 249
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "Edition"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 245
        Me.Label1.Text = "Title"
        '
        'txt_titlee1
        '
        Me.txt_titlee1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titlee1.Location = New System.Drawing.Point(20, 340)
        Me.txt_titlee1.Multiline = True
        Me.txt_titlee1.Name = "txt_titlee1"
        Me.txt_titlee1.Size = New System.Drawing.Size(374, 26)
        Me.txt_titlee1.TabIndex = 244
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 23)
        Me.Label7.TabIndex = 243
        Me.Label7.Text = "ISBN"
        '
        'btn_cncl1
        '
        Me.btn_cncl1.BackColor = System.Drawing.Color.Transparent
        Me.btn_cncl1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cncl1.ForeColor = System.Drawing.Color.White
        Me.btn_cncl1.Image = CType(resources.GetObject("btn_cncl1.Image"), System.Drawing.Image)
        Me.btn_cncl1.Location = New System.Drawing.Point(867, 146)
        Me.btn_cncl1.Name = "btn_cncl1"
        Me.btn_cncl1.Size = New System.Drawing.Size(115, 37)
        Me.btn_cncl1.TabIndex = 242
        Me.btn_cncl1.Text = "CANCEL"
        Me.btn_cncl1.UseVisualStyleBackColor = False
        '
        'btn_save0
        '
        Me.btn_save0.BackColor = System.Drawing.Color.Transparent
        Me.btn_save0.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save0.ForeColor = System.Drawing.Color.White
        Me.btn_save0.Image = CType(resources.GetObject("btn_save0.Image"), System.Drawing.Image)
        Me.btn_save0.Location = New System.Drawing.Point(720, 146)
        Me.btn_save0.Name = "btn_save0"
        Me.btn_save0.Size = New System.Drawing.Size(120, 37)
        Me.btn_save0.TabIndex = 241
        Me.btn_save0.Text = "SAVE"
        Me.btn_save0.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.rb_nonprinted)
        Me.Panel1.Controls.Add(Me.rb_printed)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(21, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 73)
        Me.Panel1.TabIndex = 289
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.rb_damaged)
        Me.Panel2.Controls.Add(Me.rb_good)
        Me.Panel2.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(20, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 65)
        Me.Panel2.TabIndex = 290
        '
        'txt_auth_mn
        '
        Me.txt_auth_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_mn.Location = New System.Drawing.Point(452, 813)
        Me.txt_auth_mn.Multiline = True
        Me.txt_auth_mn.Name = "txt_auth_mn"
        Me.txt_auth_mn.Size = New System.Drawing.Size(324, 28)
        Me.txt_auth_mn.TabIndex = 294
        Me.txt_auth_mn.Text = "Middle Name"
        '
        'txt_auth_fn
        '
        Me.txt_auth_fn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_fn.Location = New System.Drawing.Point(452, 779)
        Me.txt_auth_fn.Multiline = True
        Me.txt_auth_fn.Name = "txt_auth_fn"
        Me.txt_auth_fn.Size = New System.Drawing.Size(324, 28)
        Me.txt_auth_fn.TabIndex = 293
        Me.txt_auth_fn.Text = "First Name"
        '
        'txt_auth_ln
        '
        Me.txt_auth_ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_ln.Location = New System.Drawing.Point(452, 744)
        Me.txt_auth_ln.Multiline = True
        Me.txt_auth_ln.Name = "txt_auth_ln"
        Me.txt_auth_ln.Size = New System.Drawing.Size(324, 28)
        Me.txt_auth_ln.TabIndex = 292
        Me.txt_auth_ln.Text = "Last Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(460, 721)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 20)
        Me.Label18.TabIndex = 291
        Me.Label18.Text = "Author"
        '
        'txt_edition
        '
        Me.txt_edition.Font = New System.Drawing.Font("Century Schoolbook", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edition.Location = New System.Drawing.Point(27, 393)
        Me.txt_edition.Multiline = True
        Me.txt_edition.Name = "txt_edition"
        Me.txt_edition.Size = New System.Drawing.Size(374, 26)
        Me.txt_edition.TabIndex = 295
        '
        'ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1267, 871)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_edition)
        Me.Controls.Add(Me.txt_auth_mn)
        Me.Controls.Add(Me.txt_auth_fn)
        Me.Controls.Add(Me.txt_auth_ln)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_copyright)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbl_materialstat)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_matname)
        Me.Controls.Add(Me.txt_matname)
        Me.Controls.Add(Me.lbl_matno)
        Me.Controls.Add(Me.txt_matno)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_namee)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_idno)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_isbnn1)
        Me.Controls.Add(Me.txt_dateret)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_datetoreturn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.lbl_bookno)
        Me.Controls.Add(Me.txt_bookno)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cmb_categooory1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_reason)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_pubcom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_titlee1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cncl1)
        Me.Controls.Add(Me.btn_save0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Book - Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents rb_damaged As RadioButton
    Friend WithEvents lbl_materialstat As Label
    Friend WithEvents rb_good As RadioButton
    Friend WithEvents rb_nonprinted As RadioButton
    Friend WithEvents rb_printed As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_matname As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_matno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_isbnn1 As MaskedTextBox
    Friend WithEvents txt_dateret As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_datetoreturn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_bookno As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents cmb_categooory1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_reason As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_titlee1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_cncl1 As Button
    Friend WithEvents btn_save0 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_auth_mn As TextBox
    Friend WithEvents txt_auth_fn As TextBox
    Friend WithEvents txt_auth_ln As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_edition As TextBox
End Class
