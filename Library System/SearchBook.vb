Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class SearchBook
    Private Sub bind_data()
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("select * from tbl_book", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_cleaar11_Click(sender As Object, e As EventArgs) Handles btn_cleaar11.Click
        txt_isbn1.Clear()
        DataGridView1.ClearSelection()
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        txt_isbn1.Focus()
        bind_data()
    End Sub

    Private Sub SearchBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        bind_data()

        DataGridView1.ClearSelection()
        DataGridView1.Refresh()
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)

        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("select * from tbl_book", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
    End Sub

    Private Sub btn_cancell_Click(sender As Object, e As EventArgs) Handles btn_cancell.Click
        AdminMainForms.Show()
        Me.Hide()
        DataGridView1.ClearSelection()
        txt_isbn1.Clear()
        txt_isbn1.Focus()
        bind_data()
    End Sub

    Private Sub txt_isbn1_TextChanged(sender As Object, e As EventArgs) Handles txt_isbn1.TextChanged
        Dim searchque As String = "Select * from tbl_book Where concat (BookNumber, ISBN, Title, Author, DeweyDecimalClassification, Category, YearofPublication, Publisher, Address, Copyright, Status, ImagePath)  like '%" & txt_isbn1.Text & "%'"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd5 As MySqlCommand = New MySqlCommand(searchque, conn)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        da.SelectCommand = cmd5
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count >= 0 Then
            DataGridView1.DataSource = dt
        End If
    End Sub
End Class