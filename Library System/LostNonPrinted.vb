Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class LostNonPrinted
    Private Sub bind_data()
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("Select * from tbl_borrowreturnnonprinted", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub btn_lostbook_Click(sender As Object, e As EventArgs) Handles btn_lostbook.Click
        If txt_matno.Text = "" Then
            MsgBox("Please Enter Material Number Number", MsgBoxStyle.Critical)
            txt_matno.Focus()
        ElseIf txt_matname.Text = "" Then
            MsgBox("Please Enter Material Name", MsgBoxStyle.Critical)
            txt_matname.Focus()
        ElseIf txt_datetoreturn.Text = "" Then
            MsgBox("Please Enter Due Date", MsgBoxStyle.Critical)
            txt_datetoreturn.Focus()
        ElseIf txt_idno.Text = "" Then
            MsgBox("Please Enter No.", MsgBoxStyle.Critical)
            txt_idno.Focus()
        ElseIf txt_namee.Text = "" Then
            MsgBox("Please Enter Name", MsgBoxStyle.Critical)
            txt_namee.Focus()

        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            'SELECT BOOK BORROWED FROM TBL_BORROWEDBOOKS
            conn.Open()
            Dim bobo As String = "SELECT materialnumber,materialname from tbl_nonprinted where materialnumber= '" & txt_matno.Text & "' AND materialname= '" & txt_matname.Text & "'"
            Dim commmbo As New MySqlCommand(bobo, conn)
            Dim userCounter As Integer = commmbo.ExecuteScalar
            Dim da201 As MySqlDataReader = commmbo.ExecuteReader

            If da201.Read Then
                If userCounter > 0 Then
                    da201.Close()

                    Dim qstr6bo As String = "INSERT INTO tbl_lostnonprinted (materialnumber,materialname,name,datetoreturn) VALUES ('" & txt_matno.Text & "' , '" & txt_matname.Text & "' , '" & txt_namee.Text & "' , '" & txt_datetoreturn.Text & "') On DUPLICATE KEY UPDATE materialnumber= '" & txt_matno.Text & "'"
                    Dim cm6bo As New MySqlCommand(qstr6bo, conn)
                    Dim dat6bo As MySqlDataReader = cm6bo.ExecuteReader
                    dat6bo.Close()

                    'DELETE Records in TBL_BORROWRETURNBOOKS
                    Dim qstr00bo As String = "DELETE From tbl_borrowreturnnonprinted where materialnumber='" & txt_matno.Text & "'"
                    Dim cm00bo As New MySqlCommand(qstr00bo, conn)
                    Dim dat00bo As MySqlDataReader = cm00bo.ExecuteReader
                    dat00bo.Close()

                    Dim inc1 As String = "Update tbl_nonprinted set status = 'Lost' where materialnumber= '" & txt_matno.Text & "' "
                    Dim commm1 As New MySqlCommand(inc1, conn)
                    Dim dat1251 As MySqlDataReader = commm1.ExecuteReader
                    dat1251.Close()

                    MsgBox("The Record has been Saved!!", MsgBoxStyle.Information)
                    txt_matno.Clear()
                    txt_matname.Clear()
                    txt_idno.Clear()
                    txt_namee.Clear()
                    txt_datetoreturn.Clear()


                    AdminMainForms.Show()
                    Me.Hide()
                End If
                'Refresh LOST BOOK FORM DataGridView
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim cmd0130 As New MySqlCommand("Select * From tbl_lostnonprinted", conn)
                Dim daw0130 As New MySqlDataAdapter
                daw0130.SelectCommand = cmd0130
                Dim dt0130 As New DataTable
                dt0130.Clear()
                daw0130.Fill(dt0130)
                DataGridView1.DataSource = dt0130
                conn.Close()
            Else
                MsgBox("Borrowed Book not found", MsgBoxStyle.Information)
                txt_matno.Clear()
                txt_matname.Clear()
                txt_idno.Clear()
                txt_namee.Clear()
                txt_datetoreturn.Clear()
                txt_matno.Focus()

                'Refresh LOST BOOK FORM DataGridView
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim cmd0130 As New MySqlCommand("Select * From tbl_lostnonprinted", conn)
                Dim daw0130 As New MySqlDataAdapter
                daw0130.SelectCommand = cmd0130
                Dim dt0130 As New DataTable
                dt0130.Clear()
                daw0130.Fill(dt0130)
                DataGridView1.DataSource = dt0130
                conn.Close()

            End If
        End If

        conn.Close()
    End Sub

    Private Sub LostNonPrinted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        bind_data()
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        txt_matno.Enabled = True
        txt_matname.Enabled = True
        txt_datetoreturn.Enabled = True
        txt_namee.Enabled = True
        txt_idno.Enabled = True
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd0130 As New MySqlCommand("Select * From tbl_lostnonprinted", conn)
        Dim daw0130 As New MySqlDataAdapter
        daw0130.SelectCommand = cmd0130
        Dim dt0130 As New DataTable
        dt0130.Clear()
        daw0130.Fill(dt0130)
        DataGridView1.DataSource = dt0130
        conn.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        conn.Close()
        conn.Open()

        Dim index As Integer
        index = DataGridView1.CurrentRow.Index
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        txt_matno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_matno.ReadOnly = True
        txt_matname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_matname.ReadOnly = True
        txt_datetoreturn.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txt_datetoreturn.ReadOnly = True
        txt_idno.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txt_idno.ReadOnly = True
        txt_namee.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txt_namee.ReadOnly = True
        conn.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_matno.Clear()
        txt_datetoreturn.Clear()
        txt_matname.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_matno.Enabled = True
        txt_matname.Enabled = True
        txt_datetoreturn.Enabled = True
        txt_namee.Enabled = True
        txt_idno.Enabled = True
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
    End Sub

    Private Sub btn_cncl1_Click(sender As Object, e As EventArgs) Handles btn_cncl1.Click
        AdminMainForms.Show()
        Me.Hide()

        txt_matno.Clear()
        txt_matname.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_datetoreturn.Clear()

        txt_matno.Enabled = True
        txt_matname.Enabled = True
        txt_datetoreturn.Enabled = True
        txt_namee.Enabled = True
        txt_idno.Enabled = True
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
    End Sub
End Class