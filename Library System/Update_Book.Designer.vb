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
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.btn_clears = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.Location = New System.Drawing.Point(825, 296)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(151, 45)
        Me.btn_search.TabIndex = 0
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(1082, 296)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 45)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(401, 766)
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(520, 32)
        Me.txt_pubcom.TabIndex = 3
        '
        'txt_yearofpub
        '
        Me.txt_yearofpub.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_yearofpub.Location = New System.Drawing.Point(1088, 811)
        Me.txt_yearofpub.Name = "txt_yearofpub"
        Me.txt_yearofpub.Size = New System.Drawing.Size(524, 32)
        Me.txt_yearofpub.TabIndex = 4
        '
        'txt_author
        '
        Me.txt_author.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_author.Location = New System.Drawing.Point(401, 684)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(520, 32)
        Me.txt_author.TabIndex = 5
        '
        'txt_title
        '
        Me.txt_title.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.Location = New System.Drawing.Point(401, 602)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(524, 32)
        Me.txt_title.TabIndex = 7
        '
        'btn_clears
        '
        Me.btn_clears.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clears.Image = CType(resources.GetObject("btn_clears.Image"), System.Drawing.Image)
        Me.btn_clears.Location = New System.Drawing.Point(826, 924)
        Me.btn_clears.Name = "btn_clears"
        Me.btn_clears.Size = New System.Drawing.Size(151, 57)
        Me.btn_clears.TabIndex = 10
        Me.btn_clears.Text = "CLEAR"
        Me.btn_clears.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(1399, 924)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(151, 57)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(1121, 924)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(151, 57)
        Me.btn_update.TabIndex = 12
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(404, 569)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(404, 647)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1093, 614)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 30)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1093, 778)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 30)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Year of Publication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(409, 733)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 30)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Publisher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(576, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(351, 30)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Please Enter Book Number"
        '
        'cmb_category
        '
        Me.cmb_category.DisplayMember = "Category"
        Me.cmb_category.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(1088, 647)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(524, 31)
        Me.cmb_category.TabIndex = 21
        Me.cmb_category.ValueMember = "BookNumber"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(409, 409)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 30)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Book Number"
        '
        'txt_booknumber
        '
        Me.txt_booknumber.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_booknumber.Location = New System.Drawing.Point(401, 442)
        Me.txt_booknumber.Name = "txt_booknumber"
        Me.txt_booknumber.ReadOnly = True
        Me.txt_booknumber.Size = New System.Drawing.Size(524, 32)
        Me.txt_booknumber.TabIndex = 22
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(565, 246)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(679, 32)
        Me.txt_search.TabIndex = 70
        '
        'txt_isbn
        '
        Me.txt_isbn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn.Location = New System.Drawing.Point(401, 519)
        Me.txt_isbn.Mask = "000-0-00000-000-0"
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(526, 32)
        Me.txt_isbn.TabIndex = 71
        '
        'cmb_ddc
        '
        Me.cmb_ddc.DisplayMember = "Category"
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(1088, 565)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(524, 31)
        Me.cmb_ddc.TabIndex = 73
        Me.cmb_ddc.ValueMember = "BookNumber"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1093, 532)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(384, 30)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Dewey Decimal Classification"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(401, 844)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(518, 31)
        Me.txt_address.TabIndex = 83
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(1088, 487)
        Me.txt_copyright.MaxLength = 100
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(524, 31)
        Me.txt_copyright.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1093, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 30)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Copyright"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(409, 811)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 30)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Address"
        '
        'Update_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_copyright)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_isbn)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_booknumber)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clears)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.txt_yearofpub)
        Me.Controls.Add(Me.txt_pubcom)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_search)
        Me.Name = "Update_Book"
        Me.Text = "Update Book - Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents txt_yearofpub As TextBox
    Friend WithEvents txt_author As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents btn_clears As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
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
End Class
