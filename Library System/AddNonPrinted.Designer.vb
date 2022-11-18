<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNonPrinted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNonPrinted))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_matname = New System.Windows.Forms.TextBox()
        Me.lbl_bookno = New System.Windows.Forms.Label()
        Me.txt_matno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cancl = New System.Windows.Forms.Button()
        Me.btn_add1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(602, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(548, 221)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 30)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Material Name"
        '
        'txt_matname
        '
        Me.txt_matname.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matname.Location = New System.Drawing.Point(12, 277)
        Me.txt_matname.MaxLength = 100000
        Me.txt_matname.Name = "txt_matname"
        Me.txt_matname.Size = New System.Drawing.Size(540, 32)
        Me.txt_matname.TabIndex = 178
        '
        'lbl_bookno
        '
        Me.lbl_bookno.AutoSize = True
        Me.lbl_bookno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bookno.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookno.Location = New System.Drawing.Point(22, 127)
        Me.lbl_bookno.Name = "lbl_bookno"
        Me.lbl_bookno.Size = New System.Drawing.Size(228, 30)
        Me.lbl_bookno.TabIndex = 177
        Me.lbl_bookno.Text = "Material Number"
        '
        'txt_matno
        '
        Me.txt_matno.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matno.Location = New System.Drawing.Point(19, 160)
        Me.txt_matno.MaxLength = 17
        Me.txt_matno.Name = "txt_matno"
        Me.txt_matno.Size = New System.Drawing.Size(540, 32)
        Me.txt_matno.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(460, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 30)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Add Non Printed Material"
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(308, 397)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(151, 57)
        Me.btn_clear.TabIndex = 183
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_cancl
        '
        Me.btn_cancl.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancl.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancl.Image = CType(resources.GetObject("btn_cancl.Image"), System.Drawing.Image)
        Me.btn_cancl.Location = New System.Drawing.Point(766, 399)
        Me.btn_cancl.Name = "btn_cancl"
        Me.btn_cancl.Size = New System.Drawing.Size(151, 59)
        Me.btn_cancl.TabIndex = 182
        Me.btn_cancl.Text = "CANCEL"
        Me.btn_cancl.UseVisualStyleBackColor = False
        '
        'btn_add1
        '
        Me.btn_add1.BackColor = System.Drawing.Color.Transparent
        Me.btn_add1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add1.Image = CType(resources.GetObject("btn_add1.Image"), System.Drawing.Image)
        Me.btn_add1.Location = New System.Drawing.Point(531, 397)
        Me.btn_add1.Name = "btn_add1"
        Me.btn_add1.Size = New System.Drawing.Size(151, 59)
        Me.btn_add1.TabIndex = 181
        Me.btn_add1.Text = "ADD"
        Me.btn_add1.UseVisualStyleBackColor = False
        '
        'AddNonPrinted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 482)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cancl)
        Me.Controls.Add(Me.btn_add1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_matname)
        Me.Controls.Add(Me.lbl_bookno)
        Me.Controls.Add(Me.txt_matno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddNonPrinted"
        Me.Text = "AddNonPrinted"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_matname As TextBox
    Friend WithEvents lbl_bookno As Label
    Friend WithEvents txt_matno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_cancl As Button
    Friend WithEvents btn_add1 As Button
End Class
