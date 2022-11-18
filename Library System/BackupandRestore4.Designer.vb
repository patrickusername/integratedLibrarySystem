<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupandRestore4
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
        Me.lbl_server = New System.Windows.Forms.Label()
        Me.lbl_db = New System.Windows.Forms.Label()
        Me.lbl_uname = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.txt_db = New System.Windows.Forms.TextBox()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_percent = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Location = New System.Drawing.Point(68, 47)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(50, 17)
        Me.lbl_server.TabIndex = 0
        Me.lbl_server.Text = "Server"
        '
        'lbl_db
        '
        Me.lbl_db.AutoSize = True
        Me.lbl_db.Location = New System.Drawing.Point(49, 96)
        Me.lbl_db.Name = "lbl_db"
        Me.lbl_db.Size = New System.Drawing.Size(69, 17)
        Me.lbl_db.TabIndex = 1
        Me.lbl_db.Text = "Database"
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.Location = New System.Drawing.Point(41, 143)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(77, 17)
        Me.lbl_uname.TabIndex = 2
        Me.lbl_uname.Text = "User name"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(49, 198)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(69, 17)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "Password"
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(125, 44)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(298, 22)
        Me.txt_server.TabIndex = 4
        Me.txt_server.Text = "localhost"
        '
        'txt_db
        '
        Me.txt_db.Location = New System.Drawing.Point(125, 91)
        Me.txt_db.Name = "txt_db"
        Me.txt_db.Size = New System.Drawing.Size(298, 22)
        Me.txt_db.TabIndex = 5
        Me.txt_db.Text = "db_system"
        '
        'txt_uname
        '
        Me.txt_uname.Location = New System.Drawing.Point(125, 143)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(298, 22)
        Me.txt_uname.TabIndex = 6
        Me.txt_uname.Text = "root"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(125, 195)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(298, 22)
        Me.txt_password.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(70, 240)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(407, 36)
        Me.ProgressBar1.TabIndex = 8
        '
        'lbl_percent
        '
        Me.lbl_percent.AutoSize = True
        Me.lbl_percent.Location = New System.Drawing.Point(227, 279)
        Me.lbl_percent.Name = "lbl_percent"
        Me.lbl_percent.Size = New System.Drawing.Size(28, 17)
        Me.lbl_percent.TabIndex = 9
        Me.lbl_percent.Text = "0%"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(67, 318)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(48, 17)
        Me.lbl_status.TabIndex = 10
        Me.lbl_status.Text = "Status"
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(483, 245)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(130, 31)
        Me.btn_backup.TabIndex = 11
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'BackupandRestore4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 376)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_percent)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.txt_db)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_uname)
        Me.Controls.Add(Me.lbl_db)
        Me.Controls.Add(Me.lbl_server)
        Me.Name = "BackupandRestore4"
        Me.Text = "BackupandRestore4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_server As Label
    Friend WithEvents lbl_db As Label
    Friend WithEvents lbl_uname As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_server As TextBox
    Friend WithEvents txt_db As TextBox
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl_percent As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents btn_backup As Button
End Class
