Imports MySql.Data.MySqlClient
Public Class DamagedNonPrinted
    Private Sub bind_data()
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand("Select * from tbl_damagednonprinted", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub DamagedNonPrinted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        'DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        bind_data()
        dt1.CustomFormat = " "
        dt2.CustomFormat = " "
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        AdminMainForms.Show()
        Me.Hide()
        dt1.Text = ""
        dt2.Text = ""
        'Refresh DataTable
        Dim cmd As New MySqlCommand("Select * From Tbl_borrowednonprinted", conn)
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
        'Dim cmd As New MySqlCommand("select * from tbl_damagedbooks", conn)
        Dim cmd As New MySqlCommand("Select * From tbl_damagednonprinted where datereturned between '" + dt1.Value.ToString("dd/MM/yyyy") + "' and '" + dt2.Value.ToString("dd/MM/yyyy") + "'", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CrystalReport12
        reportDocument.SetDataSource(dt)
        DamagedNonPrintedReport.CrystalReportViewer1.ReportSource = reportDocument
        DamagedNonPrintedReport.ShowDialog()
        DamagedNonPrintedReport.Dispose()
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        dt1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        dt2.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Dim dtdate1 As DateTime = DateTime.Parse(dt1.Text)
        'Dim dtdate2 As DateTime = DateTime.Parse(dt2.Text)

        Dim cmd As New MySqlCommand("Select * From tbl_damagednonprinted where datereturned between '" + dt1.Value.ToString("dd/MM/yyyy") + "' and '" + dt2.Value.ToString("dd/MM/yyyy") + "'", conn)
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

        Dim cmd As New MySqlCommand("Select * From Tbl_damagednonprinted", conn)
        Dim d As New MySqlDataAdapter
        d.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        d.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class