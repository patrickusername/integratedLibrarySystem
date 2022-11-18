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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Book))
        Me.btn_add1 = New System.Windows.Forms.Button()
        Me.btn_cancl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_title4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_categoory = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_pubcom = New System.Windows.Forms.TextBox()
        Me.txt_booknum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_author4 = New System.Windows.Forms.TextBox()
        Me.txt_isbn4 = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_copyright = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add1
        '
        Me.btn_add1.BackColor = System.Drawing.Color.Transparent
        Me.btn_add1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add1.Image = CType(resources.GetObject("btn_add1.Image"), System.Drawing.Image)
        Me.btn_add1.Location = New System.Drawing.Point(892, 809)
        Me.btn_add1.Name = "btn_add1"
        Me.btn_add1.Size = New System.Drawing.Size(151, 59)
        Me.btn_add1.TabIndex = 6
        Me.btn_add1.Text = "ADD"
        Me.btn_add1.UseVisualStyleBackColor = False
        '
        'btn_cancl
        '
        Me.btn_cancl.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancl.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancl.Image = CType(resources.GetObject("btn_cancl.Image"), System.Drawing.Image)
        Me.btn_cancl.Location = New System.Drawing.Point(1127, 811)
        Me.btn_cancl.Name = "btn_cancl"
        Me.btn_cancl.Size = New System.Drawing.Size(151, 59)
        Me.btn_cancl.TabIndex = 7
        Me.btn_cancl.Text = "CANCEL"
        Me.btn_cancl.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1002, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 30)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 30)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Title"
        '
        'txt_title4
        '
        Me.txt_title4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title4.Location = New System.Drawing.Point(171, 351)
        Me.txt_title4.Multiline = True
        Me.txt_title4.Name = "txt_title4"
        Me.txt_title4.Size = New System.Drawing.Size(526, 31)
        Me.txt_title4.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 30)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "ISBN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 30)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Publisher"
        '
        'cmb_categoory
        '
        Me.cmb_categoory.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoory.FormattingEnabled = True
        Me.cmb_categoory.Location = New System.Drawing.Point(998, 274)
        Me.cmb_categoory.Name = "cmb_categoory"
        Me.cmb_categoory.Size = New System.Drawing.Size(526, 31)
        Me.cmb_categoory.TabIndex = 62
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(669, 809)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 57)
        Me.btn_clear.TabIndex = 63
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1005, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 30)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Year of Publication"
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(1002, 465)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Multiline = True
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(521, 31)
        Me.txt_year.TabIndex = 64
        '
        'txt_pubcom
        '
        Me.txt_pubcom.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pubcom.Location = New System.Drawing.Point(174, 536)
        Me.txt_pubcom.MaxLength = 100
        Me.txt_pubcom.Multiline = True
        Me.txt_pubcom.Name = "txt_pubcom"
        Me.txt_pubcom.Size = New System.Drawing.Size(524, 31)
        Me.txt_pubcom.TabIndex = 68
        '
        'txt_booknum
        '
        Me.txt_booknum.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_booknum.Location = New System.Drawing.Point(172, 176)
        Me.txt_booknum.Multiline = True
        Me.txt_booknum.Name = "txt_booknum"
        Me.txt_booknum.Size = New System.Drawing.Size(526, 31)
        Me.txt_booknum.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 30)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Book Number"
        '
        'txt_author4
        '
        Me.txt_author4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_author4.Location = New System.Drawing.Point(172, 446)
        Me.txt_author4.Multiline = True
        Me.txt_author4.Name = "txt_author4"
        Me.txt_author4.Size = New System.Drawing.Size(526, 31)
        Me.txt_author4.TabIndex = 71
        '
        'txt_isbn4
        '
        Me.txt_isbn4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn4.Location = New System.Drawing.Point(172, 265)
        Me.txt_isbn4.Mask = "000-0-00000-000-0"
        Me.txt_isbn4.Name = "txt_isbn4"
        Me.txt_isbn4.Size = New System.Drawing.Size(526, 32)
        Me.txt_isbn4.TabIndex = 72
        '
        'cmb_ddc
        '
        Me.cmb_ddc.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(997, 190)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(526, 31)
        Me.cmb_ddc.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1001, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(384, 30)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Dewey Decimal Classification"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(987, 518)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(548, 221)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(172, 620)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(526, 31)
        Me.txt_address.TabIndex = 79
        '
        'txt_copyright
        '
        Me.txt_copyright.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_copyright.Location = New System.Drawing.Point(174, 708)
        Me.txt_copyright.MaxLength = 100
        Me.txt_copyright.Multiline = True
        Me.txt_copyright.Name = "txt_copyright"
        Me.txt_copyright.Size = New System.Drawing.Size(524, 31)
        Me.txt_copyright.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(175, 666)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 30)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Copyright"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(175, 587)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 30)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Address"
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_copyright)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_isbn4)
        Me.Controls.Add(Me.txt_author4)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Book"
        Me.Text = "Add Book - Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add1 As Button
    Friend WithEvents btn_cancl As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_title4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_categoory As ComboBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_pubcom As TextBox
    Friend WithEvents txt_booknum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_author4 As TextBox
    Friend WithEvents txt_isbn4 As MaskedTextBox
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_copyright As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
