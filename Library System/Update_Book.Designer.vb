<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update_Book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Book))
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.txt_yearofpub = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.btn_clears = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_booknumber = New System.Windows.Forms.TextBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.txt_isbn = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_auth_mn = New System.Windows.Forms.TextBox()
        Me.txt_auth_fn = New System.Windows.Forms.TextBox()
        Me.txt_auth_ln = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_edition = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.Location = New System.Drawing.Point(542, 56)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(124, 40)
        Me.btn_search.TabIndex = 0
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(679, 56)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(125, 40)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(7, 339)
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(422, 30)
        Me.txt_pubcom.TabIndex = 3
        '
        'txt_yearofpub
        '
        Me.txt_yearofpub.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_yearofpub.Location = New System.Drawing.Point(463, 215)
        Me.txt_yearofpub.Name = "txt_yearofpub"
        Me.txt_yearofpub.Size = New System.Drawing.Size(422, 30)
        Me.txt_yearofpub.TabIndex = 4
        '
        'txt_title
        '
        Me.txt_title.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.Location = New System.Drawing.Point(7, 105)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(422, 30)
        Me.txt_title.TabIndex = 7
        '
        'btn_clears
        '
        Me.btn_clears.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clears.ForeColor = System.Drawing.Color.White
        Me.btn_clears.Image = CType(resources.GetObject("btn_clears.Image"), System.Drawing.Image)
        Me.btn_clears.Location = New System.Drawing.Point(468, 260)
        Me.btn_clears.Name = "btn_clears"
        Me.btn_clears.Size = New System.Drawing.Size(123, 43)
        Me.btn_clears.TabIndex = 10
        Me.btn_clears.Text = "CLEAR"
        Me.btn_clears.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(752, 260)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(123, 43)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(602, 260)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(136, 43)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(466, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(466, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Year of Publication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Publisher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Please Enter Book Number"
        '
        'cmb_category
        '
        Me.cmb_category.DisplayMember = "Category"
        Me.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_category.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(463, 159)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(422, 30)
        Me.cmb_category.TabIndex = 21
        Me.cmb_category.ValueMember = "BookNumber"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Book Number"
        '
        'txt_booknumber
        '
        Me.txt_booknumber.BackColor = System.Drawing.SystemColors.Window
        Me.txt_booknumber.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_booknumber.Location = New System.Drawing.Point(7, 51)
        Me.txt_booknumber.Name = "txt_booknumber"
        Me.txt_booknumber.ReadOnly = True
        Me.txt_booknumber.Size = New System.Drawing.Size(203, 30)
        Me.txt_booknumber.TabIndex = 22
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(11, 60)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(522, 30)
        Me.txt_search.TabIndex = 70
        '
        'txt_isbn
        '
        Me.txt_isbn.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn.Location = New System.Drawing.Point(229, 51)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(200, 30)
        Me.txt_isbn.TabIndex = 71
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DisplayMember = "Category"
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(463, 105)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(422, 30)
        Me.cmb_ddc.TabIndex = 73
        Me.cmb_ddc.ValueMember = "BookNumber"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(463, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(274, 23)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Dewey Decimal Classification"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(7, 394)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(422, 26)
        Me.txt_address.TabIndex = 83
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(463, 45)
        Me.txt_copyright.MaxLength = 100
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(422, 26)
        Me.txt_copyright.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(466, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 23)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Copyright"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 23)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_edition)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_auth_mn)
        Me.GroupBox1.Controls.Add(Me.txt_auth_fn)
        Me.GroupBox1.Controls.Add(Me.txt_auth_ln)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_booknumber)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_copyright)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmb_ddc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_isbn)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmb_category)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_clears)
        Me.GroupBox1.Controls.Add(Me.txt_title)
        Me.GroupBox1.Controls.Add(Me.txt_yearofpub)
        Me.GroupBox1.Controls.Add(Me.txt_pubcom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 493)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Information"
        '
        'txt_auth_mn
        '
        Me.txt_auth_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_mn.Location = New System.Drawing.Point(9, 230)
        Me.txt_auth_mn.Multiline = True
        Me.txt_auth_mn.Name = "txt_auth_mn"
        Me.txt_auth_mn.Size = New System.Drawing.Size(401, 28)
        Me.txt_auth_mn.TabIndex = 119
        Me.txt_auth_mn.Text = "Middle Name"
        '
        'txt_auth_fn
        '
        Me.txt_auth_fn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_fn.Location = New System.Drawing.Point(9, 196)
        Me.txt_auth_fn.Multiline = True
        Me.txt_auth_fn.Name = "txt_auth_fn"
        Me.txt_auth_fn.Size = New System.Drawing.Size(401, 28)
        Me.txt_auth_fn.TabIndex = 118
        Me.txt_auth_fn.Text = "First Name"
        '
        'txt_auth_ln
        '
        Me.txt_auth_ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auth_ln.Location = New System.Drawing.Point(9, 161)
        Me.txt_auth_ln.Multiline = True
        Me.txt_auth_ln.Name = "txt_auth_ln"
        Me.txt_auth_ln.Size = New System.Drawing.Size(401, 28)
        Me.txt_auth_ln.TabIndex = 117
        Me.txt_auth_ln.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Author"
        '
        'txt_edition
        '
        Me.txt_edition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edition.Location = New System.Drawing.Point(9, 282)
        Me.txt_edition.MaxLength = 100
        Me.txt_edition.Multiline = True
        Me.txt_edition.Name = "txt_edition"
        Me.txt_edition.Size = New System.Drawing.Size(420, 28)
        Me.txt_edition.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Edition"
        '
        'Update_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 619)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_search)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Update_Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Book - Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents txt_yearofpub As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents btn_clears As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_booknumber As TextBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_isbn As MaskedTextBox
    Public WithEvents cmb_category As ComboBox
    Public WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_auth_mn As TextBox
    Friend WithEvents txt_auth_fn As TextBox
    Friend WithEvents txt_auth_ln As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_edition As TextBox
    Friend WithEvents Label7 As Label
End Class
