Imports MySql.Data.MySqlClient
Public Class UnreturnedMaterialss
    Private Sub btn_cancell_Click(sender As Object, e As EventArgs) Handles btn_cancell.Click
        Me.Hide()
    End Sub

    Private Sub UnreturnedMaterialss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Dim conn As New MySqlConnection(connString)
        Dim dt As New DataTable
        Dim dat As New MySqlDataAdapter("Select * From tbl_borrowreturnnonprinted WHERE Name='" & Main_Form.lbl_name.Text & "'", conn)
        dt.Clear()
        dat.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_cleaar11_Click(sender As Object, e As EventArgs) Handles btn_cleaar11.Click
        DataGridView1.ClearSelection()
        txt_isbn1.Clear()
        txt_isbn1.Focus()
    End Sub

    Private Sub txt_isbn1_TextChanged(sender As Object, e As EventArgs) Handles txt_isbn1.TextChanged
        Dim searchque As String = "Select MaterialNumber, MaterialName,Conditions, DateBorrowed, DatetoReturn, Username, Name, ContactNo from tbl_borrowreturnnonprinted Where concat (MaterialNumber, MaterialName,Conditions, DateBorrowed, DatetoReturn, Username, Name, ContactNo)  like '%" & txt_isbn1.Text & "%'"
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