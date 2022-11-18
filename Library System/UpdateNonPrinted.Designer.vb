<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateNonPrinted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateNonPrinted))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clears = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 30)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(69, 329)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(540, 32)
        Me.txt_matname.TabIndex = 182
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(79, 207)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(228, 30)
        Me.lbl_bookno.TabIndex = 181
        Me.lbl_bookno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(76, 240)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(540, 32)
        Me.txt_matno.TabIndex = 180
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(33, 60)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(679, 32)
        Me.txt_search.TabIndex = 187
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(393, 30)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "Please Enter Material Number"
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(550, 110)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 45)
        Me.btn_clear.TabIndex = 185
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.Location = New System.Drawing.Point(293, 110)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(151, 45)
        Me.btn_search.TabIndex = 184
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(296, 433)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(151, 57)
        Me.btn_update.TabIndex = 190
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(499, 433)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(151, 57)
        Me.btn_cancel.TabIndex = 189
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clears
        '
        Me.btn_clears.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clears.Image = CType(resources.GetObject("btn_clears.Image"), System.Drawing.Image)
        Me.btn_clears.Location = New System.Drawing.Point(93, 433)
        Me.btn_clears.Name = "btn_clears"
        Me.btn_clears.Size = New System.Drawing.Size(151, 57)
        Me.btn_clears.TabIndex = 188
        Me.btn_clears.Text = "CLEAR"
        Me.btn_clears.UseVisualStyleBackColor = True
        '
        'UpdateNonPrinted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 688)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clears)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_matname)
        Me.Controls.Add(Me.lbl_bookno)
        Me.Controls.Add(Me.txt_matno)
        Me.Name = "UpdateNonPrinted"
        Me.Text = "UpdateNonPrinted"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clears As Button
End Class
