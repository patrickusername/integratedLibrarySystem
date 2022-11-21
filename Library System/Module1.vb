Imports MySql.Data.MySqlClient
Module Module1
    Public lv_contents(6) As String
    Public connString As String = "server=localhost; uid=root;database=db_system"
    Friend conpath As String = connString
    Friend conn As New MySqlConnection(conpath)
    Public ReadOnly apiSmsKey = "d590ce731d137e0324e20c8bd0be35a8"
    Public ReadOnly smsTemplate As String = "Hi {0}, the book/non-printed material you had borrowed on {1} is due tomorrow {2}. Please return it on time. Thank You!"
    Friend Sub query(ByVal str As String)
    End Sub
End Module