Imports MySql.Data.MySqlClient
Public Class Restore
    Dim con As New MySqlConnection("server=localhost;uid=root;Database=db_system;Port=3306;Integrated security=true;")
    Private Sub btn_browsee_Click(sender As Object, e As EventArgs) Handles btn_browsee.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        dlg.Title = "Restore Database"
        If dlg.ShowDialog = DialogResult.OK Then
            TextBox2.Text = dlg.FileName
        End If
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Dim database As String = conn.Database.ToString
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        conn.Open()
        Dim restoreDB As New MySqlBackup(cmd)
        restoreDB.ImportFromFile(TextBox2.Text)


        MsgBox("Restore Database Done Successfully", MsgBoxStyle.Information)
        AdminMainForms.Show()
        Me.Hide()
        conn.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        AdminMainForms.Show()
        Me.Hide()
        TextBox2.Clear()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox2.Clear()
    End Sub
End Class