<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_db = New System.Windows.Forms.ComboBox()
        Me.cmb_servername = New System.Windows.Forms.ComboBox()
        Me.lbl_db = New System.Windows.Forms.Label()
        Me.cmb_authen = New System.Windows.Forms.ComboBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_uname = New System.Windows.Forms.Label()
        Me.lbl_authen = New System.Windows.Forms.Label()
        Me.lbl_servername = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Restore = New System.Windows.Forms.Button()
        Me.btn_BackUp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmb_db)
        Me.GroupBox1.Controls.Add(Me.cmb_servername)
        Me.GroupBox1.Controls.Add(Me.lbl_db)
        Me.GroupBox1.Controls.Add(Me.cmb_authen)
        Me.GroupBox1.Controls.Add(Me.lbl_password)
        Me.GroupBox1.Controls.Add(Me.lbl_uname)
        Me.GroupBox1.Controls.Add(Me.lbl_authen)
        Me.GroupBox1.Controls.Add(Me.lbl_servername)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.txt_uname)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(43, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(428, 188)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill Info:"
        '
        'cmb_db
        '
        Me.cmb_db.FormattingEnabled = True
        Me.cmb_db.Location = New System.Drawing.Point(153, 154)
        Me.cmb_db.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_db.Name = "cmb_db"
        Me.cmb_db.Size = New System.Drawing.Size(261, 24)
        Me.cmb_db.TabIndex = 13
        '
        'cmb_servername
        '
        Me.cmb_servername.FormattingEnabled = True
        Me.cmb_servername.Location = New System.Drawing.Point(153, 23)
        Me.cmb_servername.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_servername.Name = "cmb_servername"
        Me.cmb_servername.Size = New System.Drawing.Size(261, 24)
        Me.cmb_servername.TabIndex = 12
        '
        'lbl_db
        '
        Me.lbl_db.AutoSize = True
        Me.lbl_db.Location = New System.Drawing.Point(60, 158)
        Me.lbl_db.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_db.Name = "lbl_db"
        Me.lbl_db.Size = New System.Drawing.Size(78, 17)
        Me.lbl_db.TabIndex = 11
        Me.lbl_db.Text = "DataBase :"
        '
        'cmb_authen
        '
        Me.cmb_authen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_authen.FormattingEnabled = True
        Me.cmb_authen.Items.AddRange(New Object() {"Windows Authentications", "Sql Server Authentications"})
        Me.cmb_authen.Location = New System.Drawing.Point(153, 57)
        Me.cmb_authen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_authen.Name = "cmb_authen"
        Me.cmb_authen.Size = New System.Drawing.Size(261, 24)
        Me.cmb_authen.TabIndex = 2
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(61, 126)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(77, 17)
        Me.lbl_password.TabIndex = 8
        Me.lbl_password.Text = "Password :"
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.Location = New System.Drawing.Point(52, 90)
        Me.lbl_uname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(87, 17)
        Me.lbl_uname.TabIndex = 7
        Me.lbl_uname.Text = "User Name :"
        '
        'lbl_authen
        '
        Me.lbl_authen.AutoSize = True
        Me.lbl_authen.Location = New System.Drawing.Point(32, 57)
        Me.lbl_authen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_authen.Name = "lbl_authen"
        Me.lbl_authen.Size = New System.Drawing.Size(106, 17)
        Me.lbl_authen.TabIndex = 6
        Me.lbl_authen.Text = "Authentication :"
        '
        'lbl_servername
        '
        Me.lbl_servername.AutoSize = True
        Me.lbl_servername.Location = New System.Drawing.Point(40, 27)
        Me.lbl_servername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_servername.Name = "lbl_servername"
        Me.lbl_servername.Size = New System.Drawing.Size(99, 17)
        Me.lbl_servername.TabIndex = 5
        Me.lbl_servername.Text = "Server Name :"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(153, 122)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(260, 22)
        Me.txt_password.TabIndex = 4
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_uname
        '
        Me.txt_uname.Location = New System.Drawing.Point(153, 89)
        Me.txt_uname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(260, 22)
        Me.txt_uname.TabIndex = 3
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(320, 255)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(100, 28)
        Me.btn_Cancel.TabIndex = 23
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Restore
        '
        Me.btn_Restore.Location = New System.Drawing.Point(212, 255)
        Me.btn_Restore.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(100, 28)
        Me.btn_Restore.TabIndex = 22
        Me.btn_Restore.Text = "Restore"
        Me.btn_Restore.UseVisualStyleBackColor = True
        '
        'btn_BackUp
        '
        Me.btn_BackUp.Location = New System.Drawing.Point(104, 255)
        Me.btn_BackUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_BackUp.Name = "btn_BackUp"
        Me.btn_BackUp.Size = New System.Drawing.Size(100, 28)
        Me.btn_BackUp.TabIndex = 21
        Me.btn_BackUp.Text = "Back up"
        Me.btn_BackUp.UseVisualStyleBackColor = True
        '
        'bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 312)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Restore)
        Me.Controls.Add(Me.btn_BackUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "bar"
        Me.Text = "bar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_db As ComboBox
    Friend WithEvents cmb_servername As ComboBox
    Friend WithEvents lbl_db As Label
    Public WithEvents cmb_authen As ComboBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_uname As Label
    Friend WithEvents lbl_authen As Label
    Friend WithEvents lbl_servername As Label
    Public WithEvents txt_password As TextBox
    Public WithEvents txt_uname As TextBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Restore As Button
    Friend WithEvents btn_BackUp As Button
End Class
