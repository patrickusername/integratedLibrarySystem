<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DDCManagement2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.cmb_ddc = New System.Windows.Forms.ComboBox()
        Me.txt_ddcid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter New Dewey Decimal Classification"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(277, 144)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 37)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(118, 144)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 37)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'cmb_ddc
        '
        Me.cmb_ddc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ddc.FormattingEnabled = True
        Me.cmb_ddc.Location = New System.Drawing.Point(55, 75)
        Me.cmb_ddc.Name = "cmb_ddc"
        Me.cmb_ddc.Size = New System.Drawing.Size(354, 30)
        Me.cmb_ddc.TabIndex = 11
        '
        'txt_ddcid
        '
        Me.txt_ddcid.Location = New System.Drawing.Point(55, 47)
        Me.txt_ddcid.Name = "txt_ddcid"
        Me.txt_ddcid.ReadOnly = True
        Me.txt_ddcid.Size = New System.Drawing.Size(354, 22)
        Me.txt_ddcid.TabIndex = 12
        '
        'DDCManagement2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 222)
        Me.Controls.Add(Me.txt_ddcid)
        Me.Controls.Add(Me.cmb_ddc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_update)
        Me.Name = "DDCManagement2"
        Me.Text = "DDCManagement2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents cmb_ddc As ComboBox
    Friend WithEvents txt_ddcid As TextBox
End Class
