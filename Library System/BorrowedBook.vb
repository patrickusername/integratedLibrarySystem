Imports MySql.Data.MySqlClient
'Imports System.ComponentModel
Public Class BorrowedBook
    'Dim conn As MySqlConnection
    'Dim cmd1 As MySqlCommand
    'Dim adp As MySqlDataAdapter
    'Dim dtb As New DataTable

    'Sub viewdata()
    '    cmd1 = New MySqlCommand("Select * From tbl_borrowedbooks", conn)
    '    adp = New MySqlDataAdapter(cmd1)
    '    adp.Fill(dtb)
    '    conn.Close()
    '    conn.Dispose()
    'End Sub
    Private Sub bind_data()
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand("select * from tbl_borrowedbooks", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub BorrowedBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        bind_data()
        'DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        dt1.CustomFormat = " "
        dt2.CustomFormat = " "
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim conn As New MySqlConnection(connString)

        conn.Open()
        'Dim cmd As New MySqlCommand("select * from tbl_borrowedbooks", conn)
        Dim cmd As New MySqlCommand("Select * From tbl_borrowedbooks where dateborrowed between '" + dt1.Value.ToString("dd/MM/yyyy") + "' and '" + dt2.Value.ToString("dd/MM/yyyy") + "'", conn)
        Dim d As New MySqlDataAdapter
            d.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            d.Fill(dt)
            DataGridView1.DataSource = dt

        'dtb.Clear()
        'conn = New MySqlConnection("server=localhost;user=root;password='';database=db_system")
        'Dim myrpt As New BorrowedBooksReport
        'viewdata()
        'myrpt.Database.Tables("tbl_borrowedbooks").SetDataSource(dtb)
        'CReport.CrystalReportViewer1.ReportSource = Nothing
        'CReport.CrystalReportViewer1.ReportSource = myrpt
        'Dim dt As New DataTable
        'With dt
        '    .Columns.Add("ISBN")
        '    .Columns.Add("Title")
        '    .Columns.Add("Author")
        '    .Columns.Add("Category")
        '    .Columns.Add("DateBorrowed")
        '    .Columns.Add("DatetoReturn")
        '    .Columns.Add("Quantity")
        '    .Columns.Add("Name")
        '    .Columns.Add("ContactNo")
        'End With
        'For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
        '    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value, dgr.Cells(7).Value, dgr.Cells(8).Value)
        'Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CrystalReport1
        reportDocument.SetDataSource(dt)
        BorrowedBookReport.CrystalReportViewer1.ReportSource = reportDocument
        BorrowedBookReport.ShowDialog()
        BorrowedBookReport.Dispose()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        AdminMainForms.Show()
        Me.Hide()
        dt1.Text = ""
        dt2.Text = ""

        'Refresh DataTable

        'dt1.CustomFormat = " "
        'dt2.CustomFormat = " "
        'dt2.Refresh()
        'dt2.Refresh()
        Dim cmd As New MySqlCommand("Select * From Tbl_borrowedbooks", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        dt1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        dt2.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        'Refresh DataTable
        Dim cmd As New MySqlCommand("Select * From Tbl_borrowedbooks", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Dim dtdate1 As DateTime = DateTime.Parse(dt1.Text)
        'Dim dtdate2 As DateTime = DateTime.Parse(dt2.Text)

        Dim cmd As New MySqlCommand("Select * From tbl_borrowedbooks where dateborrowed between '" + dt1.Value.ToString("dd/MM/yyyy") + "' and '" + dt2.Value.ToString("dd/MM/yyyy") + "'", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
End Class