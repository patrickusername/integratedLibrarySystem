<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutomaticSMS
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
        Me.cbRunBG = New System.Windows.Forms.CheckBox()
        Me.btnSaveSetting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbRunBG
        '
        Me.cbRunBG.AutoSize = True
        Me.cbRunBG.Location = New System.Drawing.Point(57, 64)
        Me.cbRunBG.Name = "cbRunBG"
        Me.cbRunBG.Size = New System.Drawing.Size(119, 17)
        Me.cbRunBG.TabIndex = 0
        Me.cbRunBG.Text = "Run In Background"
        Me.cbRunBG.UseVisualStyleBackColor = True
        '
        'btnSaveSetting
        '
        Me.btnSaveSetting.Location = New System.Drawing.Point(27, 114)
        Me.btnSaveSetting.Name = "btnSaveSetting"
        Me.btnSaveSetting.Size = New System.Drawing.Size(180, 38)
        Me.btnSaveSetting.TabIndex = 1
        Me.btnSaveSetting.Text = "Run Settings"
        Me.btnSaveSetting.UseVisualStyleBackColor = True
        '
        'frmAutomaticSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 175)
        Me.Controls.Add(Me.btnSaveSetting)
        Me.Controls.Add(Me.cbRunBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutomaticSMS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAutomaticSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbRunBG As CheckBox
    Friend WithEvents btnSaveSetting As Button
End Class
