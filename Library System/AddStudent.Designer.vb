<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStudent
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_studtea = New System.Windows.Forms.ComboBox()
        Me.cmb_studgs = New System.Windows.Forms.ComboBox()
        Me.lbl_studtea = New System.Windows.Forms.Label()
        Me.lbl_studgs = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_pword1 = New System.Windows.Forms.TextBox()
        Me.txt_uname1 = New System.Windows.Forms.TextBox()
        Me.lbl_pword1 = New System.Windows.Forms.Label()
        Me.lbl_uname1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(15, 517)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 210
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 30)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Barcode"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(574, 43)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1014, 706)
        Me.ListView1.TabIndex = 208
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(891, 775)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(367, 45)
        Me.btn_save.TabIndex = 207
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(81, 775)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(367, 45)
        Me.btn_add.TabIndex = 206
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cmb_studtea
        '
        Me.cmb_studtea.FormattingEnabled = True
        Me.cmb_studtea.Location = New System.Drawing.Point(15, 371)
        Me.cmb_studtea.Name = "cmb_studtea"
        Me.cmb_studtea.Size = New System.Drawing.Size(539, 24)
        Me.cmb_studtea.TabIndex = 205
        '
        'cmb_studgs
        '
        Me.cmb_studgs.FormattingEnabled = True
        Me.cmb_studgs.Location = New System.Drawing.Point(16, 307)
        Me.cmb_studgs.Name = "cmb_studgs"
        Me.cmb_studgs.Size = New System.Drawing.Size(539, 24)
        Me.cmb_studgs.TabIndex = 204
        '
        'lbl_studtea
        '
        Me.lbl_studtea.AutoSize = True
        Me.lbl_studtea.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studtea.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studtea.Location = New System.Drawing.Point(19, 338)
        Me.lbl_studtea.Name = "lbl_studtea"
        Me.lbl_studtea.Size = New System.Drawing.Size(114, 30)
        Me.lbl_studtea.TabIndex = 203
        Me.lbl_studtea.Text = "Teacher"
        '
        'lbl_studgs
        '
        Me.lbl_studgs.AutoSize = True
        Me.lbl_studgs.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studgs.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studgs.Location = New System.Drawing.Point(20, 274)
        Me.lbl_studgs.Name = "lbl_studgs"
        Me.lbl_studgs.Size = New System.Drawing.Size(244, 30)
        Me.lbl_studgs.TabIndex = 202
        Me.lbl_studgs.Text = "Grade and Section"
        '
        'txt_contact
        '
        Me.txt_contact.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(15, 228)
        Me.txt_contact.Mask = "(+63) 000-0000-000"
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(539, 32)
        Me.txt_contact.TabIndex = 201
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contact.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.Location = New System.Drawing.Point(18, 195)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(160, 30)
        Me.lbl_contact.TabIndex = 200
        Me.lbl_contact.Text = "Contact No."
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(15, 152)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(539, 31)
        Me.txt_name.TabIndex = 199
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(19, 118)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(85, 30)
        Me.lbl_name.TabIndex = 198
        Me.lbl_name.Text = "Name"
        '
        'txt_pword1
        '
        Me.txt_pword1.BackColor = System.Drawing.Color.White
        Me.txt_pword1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pword1.Location = New System.Drawing.Point(15, 437)
        Me.txt_pword1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pword1.Multiline = True
        Me.txt_pword1.Name = "txt_pword1"
        Me.txt_pword1.ReadOnly = True
        Me.txt_pword1.Size = New System.Drawing.Size(539, 31)
        Me.txt_pword1.TabIndex = 197
        '
        'txt_uname1
        '
        Me.txt_uname1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname1.Location = New System.Drawing.Point(15, 80)
        Me.txt_uname1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_uname1.MaxLength = 17
        Me.txt_uname1.Multiline = True
        Me.txt_uname1.Name = "txt_uname1"
        Me.txt_uname1.Size = New System.Drawing.Size(539, 31)
        Me.txt_uname1.TabIndex = 196
        '
        'lbl_pword1
        '
        Me.lbl_pword1.AutoSize = True
        Me.lbl_pword1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pword1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pword1.Location = New System.Drawing.Point(19, 403)
        Me.lbl_pword1.Name = "lbl_pword1"
        Me.lbl_pword1.Size = New System.Drawing.Size(134, 30)
        Me.lbl_pword1.TabIndex = 195
        Me.lbl_pword1.Text = "Password"
        '
        'lbl_uname1
        '
        Me.lbl_uname1.AutoSize = True
        Me.lbl_uname1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uname1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname1.Location = New System.Drawing.Point(18, 48)
        Me.lbl_uname1.Name = "lbl_uname1"
        Me.lbl_uname1.Size = New System.Drawing.Size(139, 30)
        Me.lbl_uname1.TabIndex = 194
        Me.lbl_uname1.Text = "Username"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 775)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(367, 45)
        Me.Button1.TabIndex = 211
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1615, 845)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cmb_studtea)
        Me.Controls.Add(Me.cmb_studgs)
        Me.Controls.Add(Me.lbl_studtea)
        Me.Controls.Add(Me.lbl_studgs)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_pword1)
        Me.Controls.Add(Me.txt_uname1)
        Me.Controls.Add(Me.lbl_pword1)
        Me.Controls.Add(Me.lbl_uname1)
        Me.Name = "AddStudent"
        Me.Text = "AddStudent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents cmb_studtea As ComboBox
    Friend WithEvents cmb_studgs As ComboBox
    Friend WithEvents lbl_studtea As Label
    Friend WithEvents lbl_studgs As Label
    Friend WithEvents txt_contact As MaskedTextBox
    Friend WithEvents lbl_contact As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_pword1 As TextBox
    Friend WithEvents txt_uname1 As TextBox
    Friend WithEvents lbl_pword1 As Label
    Friend WithEvents lbl_uname1 As Label
    Friend WithEvents Button1 As Button
End Class
