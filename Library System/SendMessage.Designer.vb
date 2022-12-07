<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendMessage))
        Me.btn_send = New System.Windows.Forms.Button()
        Me.txt_message = New System.Windows.Forms.TextBox()
        Me.txt_recipient = New System.Windows.Forms.TextBox()
        Me.lbl_recipient = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.White
        Me.btn_send.Image = CType(resources.GetObject("btn_send.Image"), System.Drawing.Image)
        Me.btn_send.Location = New System.Drawing.Point(72, 326)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(150, 43)
        Me.btn_send.TabIndex = 9
        Me.btn_send.Text = "SEND"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'txt_message
        '
        Me.txt_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_message.Location = New System.Drawing.Point(6, 25)
        Me.txt_message.Multiline = True
        Me.txt_message.Name = "txt_message"
        Me.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_message.Size = New System.Drawing.Size(375, 185)
        Me.txt_message.TabIndex = 8
        '
        'txt_recipient
        '
        Me.txt_recipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recipient.Location = New System.Drawing.Point(31, 47)
        Me.txt_recipient.Name = "txt_recipient"
        Me.txt_recipient.Size = New System.Drawing.Size(387, 27)
        Me.txt_recipient.TabIndex = 7
        '
        'lbl_recipient
        '
        Me.lbl_recipient.AutoSize = True
        Me.lbl_recipient.BackColor = System.Drawing.Color.Transparent
        Me.lbl_recipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recipient.Location = New System.Drawing.Point(34, 26)
        Me.lbl_recipient.Name = "lbl_recipient"
        Me.lbl_recipient.Size = New System.Drawing.Size(79, 20)
        Me.lbl_recipient.TabIndex = 5
        Me.lbl_recipient.Text = "Recipient"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_message)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 216)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.Location = New System.Drawing.Point(245, 326)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(150, 43)
        Me.btn_back.TabIndex = 11
        Me.btn_back.Text = "CANCEL"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'SendMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(460, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_recipient)
        Me.Controls.Add(Me.lbl_recipient)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SendMessage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_send As Button
    Friend WithEvents txt_message As TextBox
    Friend WithEvents txt_recipient As TextBox
    Friend WithEvents lbl_recipient As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_back As Button
End Class
