Imports MySql.Data.MySqlClient
Module Module1
    Public lv_contents(6) As String
    Friend conpath As String = "server=localhost; uid=root;database=db_system"
    Friend conn As New MySqlConnection(conpath)
    Friend Sub query(ByVal str As String)
    End Sub
End Module