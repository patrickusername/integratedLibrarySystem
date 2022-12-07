<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAdmin))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_contact = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_pword1 = New System.Windows.Forms.TextBox()
        Me.txt_uname1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_pword1 = New System.Windows.Forms.Label()
        Me.lbl_uname1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 246)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(667, 317)
        Me.ListView1.TabIndex = 230
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(206, 569)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(119, 42)
        Me.btn_save.TabIndex = 229
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.Library_System.My.Resources.Resources.button
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_add.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(464, 199)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(106, 39)
        Me.btn_add.TabIndex = 228
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_contact
        '
        Me.txt_contact.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(34, 206)
        Me.txt_contact.Mask = "(+63) 000-0000-000"
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(318, 30)
        Me.txt_contact.TabIndex = 227
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contact.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.Location = New System.Drawing.Point(39, 182)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(114, 23)
        Me.lbl_contact.TabIndex = 226
        Me.lbl_contact.Text = "Contact No."
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(34, 92)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(318, 29)
        Me.txt_name.TabIndex = 225
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(39, 68)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(63, 23)
        Me.lbl_name.TabIndex = 224
        Me.lbl_name.Text = "Name"
        '
        'txt_pword1
        '
        Me.txt_pword1.BackColor = System.Drawing.Color.White
        Me.txt_pword1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pword1.Location = New System.Drawing.Point(34, 149)
        Me.txt_pword1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pword1.Multiline = True
        Me.txt_pword1.Name = "txt_pword1"
        Me.txt_pword1.ReadOnly = True
        Me.txt_pword1.Size = New System.Drawing.Size(318, 29)
        Me.txt_pword1.TabIndex = 223
        '
        'txt_uname1
        '
        Me.txt_uname1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname1.Location = New System.Drawing.Point(34, 36)
        Me.txt_uname1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_uname1.MaxLength = 17
        Me.txt_uname1.Multiline = True
        Me.txt_uname1.Name = "txt_uname1"
        Me.txt_uname1.Size = New System.Drawing.Size(318, 29)
        Me.txt_uname1.TabIndex = 222
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(26, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 217
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(369, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 189)
        Me.GroupBox1.TabIndex = 232
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barcode"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(380, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 42)
        Me.Button1.TabIndex = 231
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_pword1
        '
        Me.lbl_pword1.AutoSize = True
        Me.lbl_pword1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pword1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pword1.Location = New System.Drawing.Point(39, 124)
        Me.lbl_pword1.Name = "lbl_pword1"
        Me.lbl_pword1.Size = New System.Drawing.Size(96, 23)
        Me.lbl_pword1.TabIndex = 221
        Me.lbl_pword1.Text = "Password"
        '
        'lbl_uname1
        '
        Me.lbl_uname1.AutoSize = True
        Me.lbl_uname1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uname1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname1.Location = New System.Drawing.Point(38, 14)
        Me.lbl_uname1.Name = "lbl_uname1"
        Me.lbl_uname1.Size = New System.Drawing.Size(102, 23)
        Me.lbl_uname1.TabIndex = 220
        Me.lbl_uname1.Text = "Username"
        '
        'AddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_pword1)
        Me.Controls.Add(Me.txt_uname1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_pword1)
        Me.Controls.Add(Me.lbl_uname1)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_contact As MaskedTextBox
    Friend WithEvents lbl_contact As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_pword1 As TextBox
    Friend WithEvents txt_uname1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_pword1 As Label
    Friend WithEvents lbl_uname1 As Label
End Class
