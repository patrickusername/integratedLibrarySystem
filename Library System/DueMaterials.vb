Imports MySql.Data.MySqlClient
Public Class DueMaterials
    Private Sub DueMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Dim conn As New MySqlConnection(connString)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("Select BookNumber, ISBN, Title, DateBorrowed, DateToReturn, Username, name, contactno from tbl_borrowreturnbooks WHERE DatetoReturn <'" & DateTime.Today.ToString("yyyy-MM-dd") & "'", conn)
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        SendMessage.Show()
    End Sub

    Private Sub DueMaterials_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class