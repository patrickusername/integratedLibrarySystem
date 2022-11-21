Imports MySql.Data.MySqlClient
Public Class BackupRestore
    Dim con, con1 As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dread As MySqlDataReader
    Private Sub BackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub server(ByVal str As String)
        'con = New MySqlConnection("Data Source=" & str & ";Database=db_system;")
        con = New MySqlConnection(connString)
        con.Open()
        cmd = New MySqlCommand("Select * from localhost_3306", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmb_server.Items.Add(dread(2))
        End While
        dread.Close()
    End Sub

    Sub connection()
        con = New MySqlConnection("Data Source=" & Trim(cmb_server.Text) & ";Database=db_system;")
        con.Open()
        cmb_selectdb.Items.Clear()
        cmd = New MySqlCommand("Select * from localhost_3306", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmb_selectdb.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub
End Class