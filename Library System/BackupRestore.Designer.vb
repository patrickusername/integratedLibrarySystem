<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupRestore
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
        Me.cmb_server = New System.Windows.Forms.ComboBox()
        Me.cmb_selectdb = New System.Windows.Forms.ComboBox()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.lbl_server = New System.Windows.Forms.Label()
        Me.lbl_selectdb = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'cmb_server
        '
        Me.cmb_server.FormattingEnabled = True
        Me.cmb_server.Location = New System.Drawing.Point(46, 71)
        Me.cmb_server.Name = "cmb_server"
        Me.cmb_server.Size = New System.Drawing.Size(331, 24)
        Me.cmb_server.TabIndex = 0
        '
        'cmb_selectdb
        '
        Me.cmb_selectdb.FormattingEnabled = True
        Me.cmb_selectdb.Location = New System.Drawing.Point(46, 162)
        Me.cmb_selectdb.Name = "cmb_selectdb"
        Me.cmb_selectdb.Size = New System.Drawing.Size(331, 24)
        Me.cmb_selectdb.TabIndex = 1
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(78, 218)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(112, 44)
        Me.btn_backup.TabIndex = 2
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_restore
        '
        Me.btn_restore.Location = New System.Drawing.Point(222, 218)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(112, 44)
        Me.btn_restore.TabIndex = 3
        Me.btn_restore.Text = "Restore"
        Me.btn_restore.UseVisualStyleBackColor = True
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Location = New System.Drawing.Point(43, 51)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(50, 17)
        Me.lbl_server.TabIndex = 4
        Me.lbl_server.Text = "Server"
        '
        'lbl_selectdb
        '
        Me.lbl_selectdb.AutoSize = True
        Me.lbl_selectdb.Location = New System.Drawing.Point(43, 142)
        Me.lbl_selectdb.Name = "lbl_selectdb"
        Me.lbl_selectdb.Size = New System.Drawing.Size(112, 17)
        Me.lbl_selectdb.TabIndex = 5
        Me.lbl_selectdb.Text = "Select Database"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 311)
        Me.Controls.Add(Me.lbl_selectdb)
        Me.Controls.Add(Me.lbl_server)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.cmb_selectdb)
        Me.Controls.Add(Me.cmb_server)
        Me.Name = "BackupRestore"
        Me.Text = "BackupRestore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_server As ComboBox
    Friend WithEvents cmb_selectdb As ComboBox
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_restore As Button
    Friend WithEvents lbl_server As Label
    Friend WithEvents lbl_selectdb As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
