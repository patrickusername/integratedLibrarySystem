<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnreturnedMaterials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnreturnedMaterials))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cleaar11 = New System.Windows.Forms.Button()
        Me.btn_cancell = New System.Windows.Forms.Button()
        Me.txt_isbn1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1228, 404)
        Me.DataGridView1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Search"
        '
        'btn_cleaar11
        '
        Me.btn_cleaar11.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cleaar11.ForeColor = System.Drawing.Color.White
        Me.btn_cleaar11.Image = CType(resources.GetObject("btn_cleaar11.Image"), System.Drawing.Image)
        Me.btn_cleaar11.Location = New System.Drawing.Point(554, 44)
        Me.btn_cleaar11.Name = "btn_cleaar11"
        Me.btn_cleaar11.Size = New System.Drawing.Size(111, 39)
        Me.btn_cleaar11.TabIndex = 143
        Me.btn_cleaar11.Text = "CLEAR"
        Me.btn_cleaar11.UseVisualStyleBackColor = True
        '
        'btn_cancell
        '
        Me.btn_cancell.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancell.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancell.ForeColor = System.Drawing.Color.White
        Me.btn_cancell.Image = CType(resources.GetObject("btn_cancell.Image"), System.Drawing.Image)
        Me.btn_cancell.Location = New System.Drawing.Point(675, 44)
        Me.btn_cancell.Name = "btn_cancell"
        Me.btn_cancell.Size = New System.Drawing.Size(111, 39)
        Me.btn_cancell.TabIndex = 142
        Me.btn_cancell.Text = "CANCEL"
        Me.btn_cancell.UseVisualStyleBackColor = False
        '
        'txt_isbn1
        '
        Me.txt_isbn1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_isbn1.Location = New System.Drawing.Point(48, 48)
        Me.txt_isbn1.Name = "txt_isbn1"
        Me.txt_isbn1.Size = New System.Drawing.Size(489, 32)
        Me.txt_isbn1.TabIndex = 141
        '
        'UnreturnedMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 593)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cleaar11)
        Me.Controls.Add(Me.btn_cancell)
        Me.Controls.Add(Me.txt_isbn1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UnreturnedMaterials"
        Me.Text = "UnreturnedMaterials"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cleaar11 As Button
    Friend WithEvents btn_cancell As Button
    Friend WithEvents txt_isbn1 As TextBox
End Class
