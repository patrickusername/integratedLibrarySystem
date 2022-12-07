<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFaculty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFaculty))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cmb_faculadvi = New System.Windows.Forms.ComboBox()
        Me.lbl_faculadvi = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_pword1 = New System.Windows.Forms.TextBox()
        Me.txt_uname1 = New System.Windows.Forms.TextBox()
        Me.lbl_pword1 = New System.Windows.Forms.Label()
        Me.lbl_uname1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(25, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 208
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(343, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 197)
        Me.GroupBox2.TabIndex = 236
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barcode"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(315, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 37)
        Me.Button1.TabIndex = 235
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(197, 632)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(108, 37)
        Me.btn_save.TabIndex = 234
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(427, 219)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(108, 37)
        Me.btn_add.TabIndex = 233
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(10, 264)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(679, 363)
        Me.ListView1.TabIndex = 232
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'cmb_faculadvi
        '
        Me.cmb_faculadvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_faculadvi.ForeColor = System.Drawing.Color.Black
        Me.cmb_faculadvi.FormattingEnabled = True
        Me.cmb_faculadvi.Location = New System.Drawing.Point(12, 182)
        Me.cmb_faculadvi.Name = "cmb_faculadvi"
        Me.cmb_faculadvi.Size = New System.Drawing.Size(311, 28)
        Me.cmb_faculadvi.TabIndex = 231
        '
        'lbl_faculadvi
        '
        Me.lbl_faculadvi.AutoSize = True
        Me.lbl_faculadvi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_faculadvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_faculadvi.ForeColor = System.Drawing.Color.Black
        Me.lbl_faculadvi.Location = New System.Drawing.Point(16, 161)
        Me.lbl_faculadvi.Name = "lbl_faculadvi"
        Me.lbl_faculadvi.Size = New System.Drawing.Size(121, 20)
        Me.lbl_faculadvi.TabIndex = 230
        Me.lbl_faculadvi.Text = "Advisory Class"
        '
        'txt_contact
        '
        Me.txt_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.ForeColor = System.Drawing.Color.Black
        Me.txt_contact.Location = New System.Drawing.Point(11, 132)
        Me.txt_contact.Mask = "(+63) 000-0000-000"
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(311, 27)
        Me.txt_contact.TabIndex = 229
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.ForeColor = System.Drawing.Color.Black
        Me.lbl_contact.Location = New System.Drawing.Point(15, 111)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(97, 20)
        Me.lbl_contact.TabIndex = 228
        Me.lbl_contact.Text = "Contact No."
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(12, 81)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(311, 28)
        Me.txt_name.TabIndex = 227
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(16, 59)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 226
        Me.lbl_name.Text = "Name"
        '
        'txt_pword1
        '
        Me.txt_pword1.BackColor = System.Drawing.Color.White
        Me.txt_pword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pword1.ForeColor = System.Drawing.Color.Black
        Me.txt_pword1.Location = New System.Drawing.Point(10, 231)
        Me.txt_pword1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pword1.Multiline = True
        Me.txt_pword1.Name = "txt_pword1"
        Me.txt_pword1.ReadOnly = True
        Me.txt_pword1.Size = New System.Drawing.Size(311, 28)
        Me.txt_pword1.TabIndex = 225
        '
        'txt_uname1
        '
        Me.txt_uname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname1.ForeColor = System.Drawing.Color.Black
        Me.txt_uname1.Location = New System.Drawing.Point(11, 28)
        Me.txt_uname1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_uname1.MaxLength = 17
        Me.txt_uname1.Multiline = True
        Me.txt_uname1.Name = "txt_uname1"
        Me.txt_uname1.Size = New System.Drawing.Size(311, 28)
        Me.txt_uname1.TabIndex = 224
        '
        'lbl_pword1
        '
        Me.lbl_pword1.AutoSize = True
        Me.lbl_pword1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pword1.ForeColor = System.Drawing.Color.Black
        Me.lbl_pword1.Location = New System.Drawing.Point(18, 211)
        Me.lbl_pword1.Name = "lbl_pword1"
        Me.lbl_pword1.Size = New System.Drawing.Size(83, 20)
        Me.lbl_pword1.TabIndex = 223
        Me.lbl_pword1.Text = "Password"
        '
        'lbl_uname1
        '
        Me.lbl_uname1.AutoSize = True
        Me.lbl_uname1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname1.ForeColor = System.Drawing.Color.Black
        Me.lbl_uname1.Location = New System.Drawing.Point(14, 10)
        Me.lbl_uname1.Name = "lbl_uname1"
        Me.lbl_uname1.Size = New System.Drawing.Size(86, 20)
        Me.lbl_uname1.TabIndex = 222
        Me.lbl_uname1.Text = "Username"
        '
        'AddFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmb_faculadvi)
        Me.Controls.Add(Me.lbl_faculadvi)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_pword1)
        Me.Controls.Add(Me.txt_uname1)
        Me.Controls.Add(Me.lbl_pword1)
        Me.Controls.Add(Me.lbl_uname1)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddFaculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Faculty"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cmb_faculadvi As ComboBox
    Friend WithEvents lbl_faculadvi As Label
    Friend WithEvents txt_contact As MaskedTextBox
    Friend WithEvents lbl_contact As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_pword1 As TextBox
    Friend WithEvents txt_uname1 As TextBox
    Friend WithEvents lbl_pword1 As Label
    Friend WithEvents lbl_uname1 As Label
End Class
