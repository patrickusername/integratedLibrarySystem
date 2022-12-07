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
        Me.txt_datetoreturn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_lostbook = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cncl1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_namee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_datetoreturn
        '
        Me.txt_datetoreturn.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoreturn.Location = New System.Drawing.Point(645, 45)
        Me.txt_datetoreturn.Multiline = True
        Me.txt_datetoreturn.Name = "txt_datetoreturn"
        Me.txt_datetoreturn.Size = New System.Drawing.Size(268, 28)
        Me.txt_datetoreturn.TabIndex = 250
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(646, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 23)
        Me.Label11.TabIndex = 249
        Me.Label11.Text = "Due Date"
        '
        'btn_lostbook
        '
        Me.btn_lostbook.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lostbook.ForeColor = System.Drawing.Color.White
        Me.btn_lostbook.Image = CType(resources.GetObject("btn_lostbook.Image"), System.Drawing.Image)
        Me.btn_lostbook.Location = New System.Drawing.Point(774, 89)
        Me.btn_lostbook.Name = "btn_lostbook"
        Me.btn_lostbook.Size = New System.Drawing.Size(116, 45)
        Me.btn_lostbook.TabIndex = 248
        Me.btn_lostbook.Text = "ADD"
        Me.btn_lostbook.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 449)
        Me.DataGridView1.TabIndex = 247
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(645, 89)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(115, 45)
        Me.btn_clear.TabIndex = 246
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_cncl1
        '
        Me.btn_cncl1.BackColor = System.Drawing.Color.Transparent
        Me.btn_cncl1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cncl1.ForeColor = System.Drawing.Color.White
        Me.btn_cncl1.Image = CType(resources.GetObject("btn_cncl1.Image"), System.Drawing.Image)
        Me.btn_cncl1.Location = New System.Drawing.Point(896, 89)
        Me.btn_cncl1.Name = "btn_cncl1"
        Me.btn_cncl1.Size = New System.Drawing.Size(125, 45)
        Me.btn_cncl1.TabIndex = 245
        Me.btn_cncl1.Text = "CANCEL"
        Me.btn_cncl1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 23)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Name"
        '
        'txt_namee
        '
        Me.txt_namee.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namee.Location = New System.Drawing.Point(318, 106)
        Me.txt_namee.Multiline = True
        Me.txt_namee.Name = "txt_namee"
        Me.txt_namee.Size = New System.Drawing.Size(299, 28)
        Me.txt_namee.TabIndex = 243
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = "ID No."
        '
        'txt_idno
        '
        Me.txt_idno.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idno.Location = New System.Drawing.Point(318, 45)
        Me.txt_idno.MaxLength = 13
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.Size = New System.Drawing.Size(299, 30)
        Me.txt_idno.TabIndex = 241
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(12, 106)
        Me.txt_matname.MaxLength = 17
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(279, 30)
        Me.txt_matname.TabIndex = 239
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(11, 17)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(165, 23)
        Me.lbl_bookno.TabIndex = 238
        Me.lbl_bookno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(12, 45)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(279, 30)
        Me.txt_matno.TabIndex = 237
        '
        'LostNonPrinted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.hetooooonaaa_ahhhhhh1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 607)
        Me.ControlBox = False
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LostNonPrinted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost Non-Printed"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_datetoreturn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_lostbook As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_cncl1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_namee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_matno As TextBox
End Class
