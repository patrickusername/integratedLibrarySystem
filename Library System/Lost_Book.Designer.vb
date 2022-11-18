<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lost_Book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lost_Book))
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_isbnn1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_datetoreturn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_bookno = New System.Windows.Forms.TextBox()
        Me.cmb_categooory1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_authorr1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_titlee1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_lostbook = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cncl1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(971, 224)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(430, 31)
        Me.cmb_ddc.TabIndex = 236
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(981, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(384, 30)
        Me.Label12.TabIndex = 235
        Me.Label12.Text = "Dewey Decimal Classification"
        '
        'txt_isbnn1
        '
        Me.txt_isbnn1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbnn1.Location = New System.Drawing.Point(472, 90)
        Me.txt_isbnn1.Mask = "000-0-00000-000-0"
        Me.txt_isbnn1.Name = "txt_isbnn1"
        Me.txt_isbnn1.Size = New System.Drawing.Size(434, 32)
        Me.txt_isbnn1.TabIndex = 232
        '
        'txt_datetoreturn
        '
        Me.txt_datetoreturn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoreturn.Location = New System.Drawing.Point(677, 222)
        Me.txt_datetoreturn.Multiline = True
        Me.txt_datetoreturn.Name = "txt_datetoreturn"
        Me.txt_datetoreturn.Size = New System.Drawing.Size(229, 32)
        Me.txt_datetoreturn.TabIndex = 228
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(681, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 25)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Due Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(468, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(212, 25)
        Me.Label10.TabIndex = 226
        Me.Label10.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(472, 222)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(199, 32)
        Me.txt_year.TabIndex = 225
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(255, 405)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1270, 415)
        Me.DataGridView1.TabIndex = 224
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1440, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 25)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "Name"
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(1435, 204)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(430, 32)
        Me.txt_namee.TabIndex = 222
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1450, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 25)
        Me.Label16.TabIndex = 221
        Me.Label16.Text = "No."
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(1435, 138)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(430, 32)
        Me.txt_idno.TabIndex = 220
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(40, 53)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(155, 25)
        Me.lbl_bookno.TabIndex = 219
        Me.lbl_bookno.Text = "Book Number"
        '
        'txt_bookno
        '
        Me.txt_bookno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bookno.Location = New System.Drawing.Point(35, 90)
        Me.txt_bookno.MaxLength = 17
        Me.txt_bookno.Name = "txt_bookno"
        Me.txt_bookno.Size = New System.Drawing.Size(382, 32)
        Me.txt_bookno.TabIndex = 218
        '
        'cmb_categooory1
        '
        Me.cmb_categooory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categooory1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categooory1.FormattingEnabled = True
        Me.cmb_categooory1.Location = New System.Drawing.Point(35, 223)
        Me.cmb_categooory1.Name = "cmb_categooory1"
        Me.cmb_categooory1.Size = New System.Drawing.Size(382, 31)
        Me.cmb_categooory1.TabIndex = 216
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "Publisher"
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(472, 157)
        Me.txt_pubcom.Multiline = True
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(434, 31)
        Me.txt_pubcom.TabIndex = 209
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Author"
        '
        'txt_authorr1
        '
        Me.txt_authorr1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_authorr1.Location = New System.Drawing.Point(35, 158)
        Me.txt_authorr1.Multiline = True
        Me.txt_authorr1.Name = "txt_authorr1"
        Me.txt_authorr1.Size = New System.Drawing.Size(382, 31)
        Me.txt_authorr1.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(980, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "Title"
        '
        'txt_titlee1
        '
        Me.txt_titlee1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titlee1.Location = New System.Drawing.Point(971, 90)
        Me.txt_titlee1.Multiline = True
        Me.txt_titlee1.Name = "txt_titlee1"
        Me.txt_titlee1.Size = New System.Drawing.Size(430, 32)
        Me.txt_titlee1.TabIndex = 204
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(467, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "ISBN"
        '
        'btn_lostbook
        '
        Me.btn_lostbook.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lostbook.Image = CType(resources.GetObject("btn_lostbook.Image"), System.Drawing.Image)
        Me.btn_lostbook.Location = New System.Drawing.Point(637, 318)
        Me.btn_lostbook.Name = "btn_lostbook"
        Me.btn_lostbook.Size = New System.Drawing.Size(259, 57)
        Me.btn_lostbook.TabIndex = 230
        Me.btn_lostbook.Text = "ADD LOST BOOK"
        Me.btn_lostbook.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(439, 318)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 57)
        Me.btn_clear.TabIndex = 217
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_cncl1
        '
        Me.btn_cncl1.BackColor = System.Drawing.Color.Transparent
        Me.btn_cncl1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cncl1.Image = CType(resources.GetObject("btn_cncl1.Image"), System.Drawing.Image)
        Me.btn_cncl1.Location = New System.Drawing.Point(943, 318)
        Me.btn_cncl1.Name = "btn_cncl1"
        Me.btn_cncl1.Size = New System.Drawing.Size(151, 57)
        Me.btn_cncl1.TabIndex = 202
        Me.btn_cncl1.Text = "CANCEL"
        Me.btn_cncl1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1357, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Copyright"
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(1352, 370)
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(430, 32)
        Me.txt_copyright.TabIndex = 239
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1367, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(1352, 304)
        Me.txt_address.MaxLength = 13
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(430, 32)
        Me.txt_address.TabIndex = 237
        '
        'Lost_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_copyright)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_isbnn1)
        Me.Controls.Add(Me.btn_lostbook)
        Me.Controls.Add(Me.txt_datetoreturn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_namee)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_idno)
        Me.Controls.Add(Me.lbl_bookno)
        Me.Controls.Add(Me.txt_bookno)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cmb_categooory1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_pubcom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_authorr1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_titlee1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cncl1)
        Me.Name = "Lost_Book"
        Me.Text = "Lost_Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_isbnn1 As MaskedTextBox
    Friend WithEvents btn_lostbook As Button
    Friend WithEvents txt_datetoreturn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_bookno As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents cmb_categooory1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_authorr1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_titlee1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_cncl1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address As TextBox
End Class
