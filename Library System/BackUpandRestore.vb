Imports MySql.Data.MySqlClient
Public Class BackUpandRestore
    Dim con As New MySqlConnection("server=localhost;uid=root;Database=db_system;Port=3306;Integrated security=true;")
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim dlg As New FolderBrowserDialog()
        If dlg.ShowDialog = DialogResult.OK Then
            TextBox1.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        If TextBox1.Text Is String.Empty Then
            MsgBox("Please enter backup file location", MsgBoxStyle.Critical)
        Else
            Dim str = TextBox1.Text & "/db_backup" & "-" & Date.Now.ToString("yyyy-MM-dd--HH-mm-ss") & ".sql"
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Dim mb As New MySqlBackup(cmd)
            mb.ExportToFile(str)
            conn.Close()
            MsgBox("Database backup done successfully", MsgBoxStyle.Information)
            AdminMainForms.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        AdminMainForms.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox1.Clear()
    End Sub
End Class
