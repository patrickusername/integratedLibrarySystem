Imports MySql.Data.MySqlClient
Public Class DueMaterials
    Private Sub DueMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Dim conn As New MySqlConnection("server=localhost;uid=root;database=db_system")
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("Select BookNumber, ISBN, Title, DateBorrowed, DateToReturn, Username, name, contactno from tbl_borrowreturnbooks WHERE DatetoReturn='" & DateTime.Today.AddDays(1) & "'", conn)
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Me.Hide()
        SendMessage.Show()
    End Sub
End Class