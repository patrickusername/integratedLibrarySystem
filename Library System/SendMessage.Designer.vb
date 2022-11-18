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
        Me.btn_send = New System.Windows.Forms.Button()
        Me.txt_message = New System.Windows.Forms.TextBox()
        Me.txt_recipient = New System.Windows.Forms.TextBox()
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.lbl_recipient = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.Location = New System.Drawing.Point(117, 354)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(150, 43)
        Me.btn_send.TabIndex = 9
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'txt_message
        '
        Me.txt_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_message.Location = New System.Drawing.Point(68, 166)
        Me.txt_message.Multiline = True
        Me.txt_message.Name = "txt_message"
        Me.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_message.Size = New System.Drawing.Size(255, 156)
        Me.txt_message.TabIndex = 8
        '
        'txt_recipient
        '
        Me.txt_recipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recipient.Location = New System.Drawing.Point(68, 77)
        Me.txt_recipient.Name = "txt_recipient"
        Me.txt_recipient.Size = New System.Drawing.Size(255, 27)
        Me.txt_recipient.TabIndex = 7
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.Location = New System.Drawing.Point(64, 143)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(114, 20)
        Me.lbl_message.TabIndex = 6
        Me.lbl_message.Text = "Text Message"
        '
        'lbl_recipient
        '
        Me.lbl_recipient.AutoSize = True
        Me.lbl_recipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recipient.Location = New System.Drawing.Point(65, 48)
        Me.lbl_recipient.Name = "lbl_recipient"
        Me.lbl_recipient.Size = New System.Drawing.Size(79, 20)
        Me.lbl_recipient.TabIndex = 5
        Me.lbl_recipient.Text = "Recipient"
        '
        'SendMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 416)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_message)
        Me.Controls.Add(Me.txt_recipient)
        Me.Controls.Add(Me.lbl_message)
        Me.Controls.Add(Me.lbl_recipient)
        Me.Name = "SendMessage"
        Me.Text = "SendMessage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_send As Button
    Friend WithEvents txt_message As TextBox
    Friend WithEvents txt_recipient As TextBox
    Friend WithEvents lbl_message As Label
    Friend WithEvents lbl_recipient As Label
End Class
