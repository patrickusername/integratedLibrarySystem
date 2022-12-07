<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherMainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonPrintedMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintedMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonPrintedMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_usertype = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.BorrowersToolStripMenuItem, Me.BorrowedBooksToolStripMenuItem, Me.UpdateNToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 49)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripMenuItem, Me.NonPrintedMaterialToolStripMenuItem})
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(83, 45)
        Me.ToolStripMenuItem4.Text = "Search"
        Me.ToolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Image = CType(resources.GetObject("BookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.BookToolStripMenuItem.Text = "Printed Materials"
        '
        'NonPrintedMaterialToolStripMenuItem
        '
        Me.NonPrintedMaterialToolStripMenuItem.Image = CType(resources.GetObject("NonPrintedMaterialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NonPrintedMaterialToolStripMenuItem.Name = "NonPrintedMaterialToolStripMenuItem"
        Me.NonPrintedMaterialToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.NonPrintedMaterialToolStripMenuItem.Text = "Non-Printed Material"
        '
        'BorrowersToolStripMenuItem
        '
        Me.BorrowersToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowersToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BorrowersToolStripMenuItem.Image = CType(resources.GetObject("BorrowersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrowersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BorrowersToolStripMenuItem.Name = "BorrowersToolStripMenuItem"
        Me.BorrowersToolStripMenuItem.Size = New System.Drawing.Size(168, 45)
        Me.BorrowersToolStripMenuItem.Text = "Class Borrowers"
        Me.BorrowersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BorrowedBooksToolStripMenuItem
        '
        Me.BorrowedBooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintedMaterialsToolStripMenuItem, Me.NonPrintedMaterialsToolStripMenuItem})
        Me.BorrowedBooksToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowedBooksToolStripMenuItem.Name = "BorrowedBooksToolStripMenuItem"
        Me.BorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(217, 45)
        Me.BorrowedBooksToolStripMenuItem.Text = "Unreturned Materials"
        Me.BorrowedBooksToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PrintedMaterialsToolStripMenuItem
        '
        Me.PrintedMaterialsToolStripMenuItem.Name = "PrintedMaterialsToolStripMenuItem"
        Me.PrintedMaterialsToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.PrintedMaterialsToolStripMenuItem.Text = "Printed Materials"
        '
        'NonPrintedMaterialsToolStripMenuItem
        '
        Me.NonPrintedMaterialsToolStripMenuItem.Name = "NonPrintedMaterialsToolStripMenuItem"
        Me.NonPrintedMaterialsToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.NonPrintedMaterialsToolStripMenuItem.Text = "Non-Printed Materials"
        '
        'UpdateNToolStripMenuItem
        '
        Me.UpdateNToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateNToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UpdateNToolStripMenuItem.Image = CType(resources.GetObject("UpdateNToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateNToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateNToolStripMenuItem.Name = "UpdateNToolStripMenuItem"
        Me.UpdateNToolStripMenuItem.Size = New System.Drawing.Size(130, 45)
        Me.UpdateNToolStripMenuItem.Text = "User Profile"
        Me.UpdateNToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(63, 45)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(83, 45)
        Me.ExitToolStripMenuItem.Text = "Logout"
        Me.ExitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_name, Me.ToolStripStatusLabel2, Me.lbl_usertype})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 49)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 30)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 25)
        Me.ToolStripStatusLabel1.Text = "WELCOME"
        '
        'lbl_name
        '
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(71, 25)
        Me.lbl_name.Text = "Name"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(197, 25)
        Me.ToolStripStatusLabel2.Text = "You are logged in as"
        '
        'lbl_usertype
        '
        Me.lbl_usertype.Name = "lbl_usertype"
        Me.lbl_usertype.Size = New System.Drawing.Size(105, 25)
        Me.lbl_usertype.Text = "Usertype"
        '
        'TeacherMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TeacherMainForm"
        Me.Text = "Faculty Main Form"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BorrowersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NonPrintedMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lbl_name As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbl_usertype As ToolStripStatusLabel
    Friend WithEvents PrintedMaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NonPrintedMaterialsToolStripMenuItem As ToolStripMenuItem
End Class
