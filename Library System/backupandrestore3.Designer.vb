<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backupandrestore3
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
        Me.lbl_database = New System.Windows.Forms.Label()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Location = New System.Drawing.Point(62, 53)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(50, 17)
        Me.lbl_server.TabIndex = 0
        Me.lbl_server.Text = "Server"
        '
        'lbl_database
        '
        Me.lbl_database.AutoSize = True
        Me.lbl_database.Location = New System.Drawing.Point(62, 118)
        Me.lbl_database.Name = "lbl_database"
        Me.lbl_database.Size = New System.Drawing.Size(69, 17)
        Me.lbl_database.TabIndex = 1
        Me.lbl_database.Text = "Database"
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(65, 73)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(339, 22)
        Me.txt_server.TabIndex = 2
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(65, 138)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(339, 22)
        Me.txt_database.TabIndex = 3
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(90, 178)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(110, 40)
        Me.btn_backup.TabIndex = 4
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_restore
        '
        Me.btn_restore.Location = New System.Drawing.Point(253, 178)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(110, 40)
        Me.btn_restore.TabIndex = 5
        Me.btn_restore.Text = "Restore"
        Me.btn_restore.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'backupandrestore3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 252)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.txt_database)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.lbl_database)
        Me.Controls.Add(Me.lbl_server)
        Me.Name = "backupandrestore3"
        Me.Text = "backupandrestore3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_server As Label
    Friend WithEvents lbl_database As Label
    Friend WithEvents txt_server As TextBox
    Friend WithEvents txt_database As TextBox
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_restore As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
