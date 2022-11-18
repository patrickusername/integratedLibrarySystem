'Imports Microsoft.SqlServer
'Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
''Imports Microsoft.SqlServer.Management.Smo
'Public Class bar
'    Private Sub cmb_db_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_db.SelectedIndexChanged
'        Try
'            cmb_db.Items.Clear()
'            Dim serverName As String = cmb_servername.Text.ToString()
'            Dim serverConnection As Microsoft.SqlServer.Management.Common.ServerConnection = New Microsoft.SqlServer.Management.Common.ServerConnection()
'            serverConnection.ServerInstance = serverName
'            serverConnection.LoginSecure = True
'            If cmb_authen.SelectedIndex = 1 Then
'                serverConnection.LoginSecure = False
'                serverConnection.Login = txt_uname.Text
'                serverConnection.Password = txt_password.Text
'            End If
'            Dim server As Server = New Server(serverConnection)
'            Try
'                For Each database As Database In server.Databases
'                    cmbDataBase1.Items.Add(database.Name)
'                Next
'            Catch ex As Exception
'                Dim exception As String = ex.Message
'            End Try
'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub
'End Class