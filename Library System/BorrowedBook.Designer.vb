<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowedBook))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_search = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(289, 388)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1271, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_generate
        '
        Me.btn_generate.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Image = CType(resources.GetObject("btn_generate.Image"), System.Drawing.Image)
        Me.btn_generate.Location = New System.Drawing.Point(1218, 312)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(151, 57)
        Me.btn_generate.TabIndex = 1
        Me.btn_generate.Text = "PRINT"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.Location = New System.Drawing.Point(968, 312)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(151, 57)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'dt1
        '
        Me.dt1.CalendarFont = New System.Drawing.Font("Book Antiqua", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt1.Location = New System.Drawing.Point(573, 243)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(294, 32)
        Me.dt1.TabIndex = 3
        '
        'dt2
        '
        Me.dt2.CalendarFont = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt2.Location = New System.Drawing.Point(1083, 243)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(265, 32)
        Me.dt2.TabIndex = 4
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Image = CType(resources.GetObject("txt_search.Image"), System.Drawing.Image)
        Me.txt_search.Location = New System.Drawing.Point(496, 312)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(151, 57)
        Me.txt_search.TabIndex = 5
        Me.txt_search.Text = "SEARCH"
        Me.txt_search.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(715, 312)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(184, 57)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1078, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To:"
        '
        'BorrowedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BorrowedBook"
        Me.Text = "Borrowed Book Report - Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_generate As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents txt_search As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
