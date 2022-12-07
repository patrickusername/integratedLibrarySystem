Imports MySql.Data.MySqlClient
'Imports System.ComponentModel
Public Class ClassBorrower
    Private Sub btn_back9_Click(sender As Object, e As EventArgs) Handles btn_back9.Click
        TeacherMainForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClassBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        'DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        Dim conn As New MySqlConnection(connString)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("select Username, name, contactno, gradesec, title, dateborrowed, datetoreturn from tbl_studentborrowers WHERE Teacher='" & TeacherMainForm.lbl_name.Text & "'", conn)
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class