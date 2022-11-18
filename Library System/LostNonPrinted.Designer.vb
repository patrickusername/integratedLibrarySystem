<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostNonPrinted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LostNonPrinted))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_lostbook = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cncl1 = New System.Windows.Forms.Button()
        Me.txt_datetoreturn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 30)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(272, 184)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(540, 32)
        Me.txt_matname.TabIndex = 178
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(275, 42)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(228, 30)
        Me.lbl_bookno.TabIndex = 177
        Me.lbl_bookno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(272, 89)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(540, 32)
        Me.txt_matno.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(881, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 30)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Name"
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(880, 120)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(540, 31)
        Me.txt_namee.TabIndex = 185
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(892, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 30)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "No."
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(880, 54)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(540, 32)
        Me.txt_idno.TabIndex = 183
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(171, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1270, 415)
        Me.DataGridView1.TabIndex = 233
        '
        'btn_lostbook
        '
        Me.btn_lostbook.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lostbook.Image = CType(resources.GetObject("btn_lostbook.Image"), System.Drawing.Image)
        Me.btn_lostbook.Location = New System.Drawing.Point(675, 269)
        Me.btn_lostbook.Name = "btn_lostbook"
        Me.btn_lostbook.Size = New System.Drawing.Size(259, 57)
        Me.btn_lostbook.TabIndex = 234
        Me.btn_lostbook.Text = "ADD LOST MATERIAL"
        Me.btn_lostbook.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(477, 269)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 57)
        Me.btn_clear.TabIndex = 232
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_cncl1
        '
        Me.btn_cncl1.BackColor = System.Drawing.Color.Transparent
        Me.btn_cncl1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cncl1.Image = CType(resources.GetObject("btn_cncl1.Image"), System.Drawing.Image)
        Me.btn_cncl1.Location = New System.Drawing.Point(981, 269)
        Me.btn_cncl1.Name = "btn_cncl1"
        Me.btn_cncl1.Size = New System.Drawing.Size(151, 57)
        Me.btn_cncl1.TabIndex = 231
        Me.btn_cncl1.Text = "CANCEL"
        Me.btn_cncl1.UseVisualStyleBackColor = False
        '
        'txt_datetoreturn
        '
        Me.txt_datetoreturn.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoreturn.Location = New System.Drawing.Point(877, 184)
        Me.txt_datetoreturn.Multiline = True
        Me.txt_datetoreturn.Name = "txt_datetoreturn"
        Me.txt_datetoreturn.Size = New System.Drawing.Size(543, 32)
        Me.txt_datetoreturn.TabIndex = 236
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(881, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 25)
        Me.Label11.TabIndex = 235
        Me.Label11.Text = "Due Date"
        '
        'LostNonPrinted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.txt_datetoreturn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_lostbook)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cncl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_namee)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_idno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_matname)
        Me.Controls.Add(Me.lbl_bookno)
        Me.Controls.Add(Me.txt_matno)
        Me.Name = "LostNonPrinted"
        Me.Text = "LostNonPrinted"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents btn_lostbook As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_cncl1 As Button
    Friend WithEvents txt_datetoreturn As TextBox
    Friend WithEvents Label11 As Label
End Class
