Imports MySql.Data.MySqlClient
Public Class backupandrestore3
    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        SaveFileDialog1.FileName = txt_database.Text & ".bak"
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim mysqlconnection As String = "server=localhost;uid=root;Database=db_system;Port=3306; integrated security=true;Initial Catalog=" & txt_database.Text & "; Data Source=" & txt_server.Text & ""

        Dim conn As New MySqlConnection(mysqlconnection)
        conn.Open()

        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "BACKUP DATABASE " & txt_database.Text & " TO DISK= " & SaveFileDialog1.FileName & ""
        cmd.Connection = conn

        If cmd.ExecuteNonQuery() Then
            MsgBox("Backup made successfully")
        End If
    End Sub
End Class