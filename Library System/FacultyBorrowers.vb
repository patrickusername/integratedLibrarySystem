Imports MySql.Data.MySqlClient
'Imports System.ComponentModel
Public Class FacultyBorrowers
    Private Sub bind_data()
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub FacultyBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        bind_data()
        'DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        dt1.CustomFormat = " "
        dt2.CustomFormat = " "
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        AdminMainForms.Show()
        Me.Hide()

        dt1.CustomFormat = " "
        dt2.CustomFormat = " "

        'Refresh DataTable

        'dt1.CustomFormat = " "
        'dt2.CustomFormat = " "
        'dt2.Refresh()
        'dt2.Refresh()
        Dim cmd As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        'Dim cmd As New MySqlCommand("select * from tbl_facultyborrowers", conn)
        Dim cmd As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers where dateborrowed between '" & dt1.Value.ToString("MM/dd/yyyy - hh:mm tt") & "' and '" & dt2.Value.ToString("MM/dd/yyyy - hh:mm tt") & "'", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CrystalReport9
        reportDocument.SetDataSource(dt)
        FacultyBorrowerReport.CrystalReportViewer1.ReportSource = reportDocument
        FacultyBorrowerReport.ShowDialog()
        FacultyBorrowerReport.Dispose()
    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Dim dtdate1 As DateTime = DateTime.Parse(dt1.Text)
        'Dim dtdate2 As DateTime = DateTime.Parse(dt2.Text)

        Dim cmd As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers where dateborrowed between '" & dt1.Value.ToString("MM/dd/yyyy - hh:mm tt") & "' and '" & dt2.Value.ToString("MM/dd/yyyy - hh:mm tt") & "'", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        'Refresh DataTable

        dt1.CustomFormat = " "
        dt2.CustomFormat = " "
        'dt2.Refresh()
        'dt2.Refresh()
        Dim cmd As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        dt1.CustomFormat = "MM/dd/yyyy - hh:mm tt"
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        dt2.CustomFormat = "MM/dd/yyyy - hh:mm tt"
    End Sub
End Class