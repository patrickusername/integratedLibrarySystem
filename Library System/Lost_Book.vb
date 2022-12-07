Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Lost_Book
    Public conn As New MySqlConnection(connString)
    Private Sub bind_data()
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("Select * from tbl_borrowreturnbooks", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub btn_lostbook_Click(sender As Object, e As EventArgs) Handles btn_lostbook.Click
        If txt_bookno.Text = "" Then
            MsgBox("Please Enter Book Number", MsgBoxStyle.Critical)
            txt_bookno.Focus()
        ElseIf txt_isbnn1.Text = "" Then
            MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
            txt_isbnn1.Focus()
        ElseIf txt_isbnn1.MaskCompleted = False Then
            MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
            txt_isbnn1.Focus()
        ElseIf txt_titlee1.Text = "" Then
            MsgBox("Please Enter Title", MsgBoxStyle.Critical)
            txt_titlee1.Focus()
            'ElseIf txt_authorr1.Text = "" Then
            '    MsgBox("Please Enter Author", MsgBoxStyle.Critical)
            '    txt_authorr1.Focus()
        ElseIf cmb_ddc.Text = "" Then
            MsgBox("Please Enter Dewey Decimal Classification", MsgBoxStyle.Critical)
            cmb_ddc.Focus()
        ElseIf cmb_categooory1.Text = "" Then
            MsgBox("Please Enter Category", MsgBoxStyle.Critical)
            cmb_categooory1.Focus()
        ElseIf txt_year.Text = "" Then
            MsgBox("Please Enter Year", MsgBoxStyle.Critical)
            txt_year.Focus()
        ElseIf txt_pubcom.Text = "" Then
            MsgBox("Please Enter Publisher", MsgBoxStyle.Critical)
            txt_pubcom.Focus()
        ElseIf txt_address.Text = "" Then
            MsgBox("Please Enter Address", MsgBoxStyle.Critical)
            txt_address.Focus()
        ElseIf txt_copyright.Text = "" Then
            MsgBox("Please Enter Copyright", MsgBoxStyle.Critical)
            txt_copyright.Focus()
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
            Dim bobo As String = "SELECT booknumber,isbn,title,authorlastname,authorfirstname,authormiddlename,deweydecimalclassification,category,yearofpublication,publisher,address,copyright from tbl_book where booknumber= '" & txt_bookno.Text & "' AND isbn= '" & txt_isbnn1.Text & "' AND title= '" & txt_titlee1.Text & "' AND authoralstname= '" & txt_auth_ln.Text & "' AND authorfirstname= '" & txt_auth_fn.Text & "' AND authormiddlename= '" & txt_auth_mn.Text & "' AND DeweyDecimalClassification= '" & cmb_ddc.Text & "' AND category= '" & cmb_categooory1.Text & "' AND YearofPublication= '" & txt_year.Text & "' AND publisher= '" & txt_pubcom.Text & "' AND Address= '" & txt_address.Text & "' AND Copyright= '" & txt_copyright.Text & "'"
            Dim commmbo As New MySqlCommand(bobo, conn)
            Dim userCounter As Integer = commmbo.ExecuteScalar
            Dim da201 As MySqlDataReader = commmbo.ExecuteReader

            If da201.Read Then
                If userCounter > 0 Then
                    da201.Close()

                    Dim qstr6bo As String = "INSERT INTO tbl_lostbooks (booknumber,isbn,title,authorlastname,authorfirstname,authormiddlename,deweydecimalclassification,category,yearofpublication,publisher,address,copyright,name,datetoreturn) VALUES ('" & txt_bookno.Text & "' , '" & txt_isbnn1.Text & "' , '" & txt_titlee1.Text & "' , '" & txt_auth_ln.Text & "' , '" & txt_auth_fn.Text & "' , '" & txt_auth_mn.Text & "' , '" & cmb_ddc.Text & "' , '" & cmb_categooory1.Text & "' , '" & txt_year.Text & "' , '" & txt_pubcom.Text & "' , '" & txt_address.Text & "' , '" & txt_copyright.Text & "' , '" & txt_namee.Text & "' , '" & txt_datetoreturn.Text & "') On DUPLICATE KEY UPDATE booknumber= '" & txt_bookno.Text & "'"
                    Dim cm6bo As New MySqlCommand(qstr6bo, conn)
                    Dim dat6bo As MySqlDataReader = cm6bo.ExecuteReader
                    dat6bo.Close()

                    'DELETE Records in TBL_BORROWRETURNBOOKS
                    Dim qstr00bo As String = "DELETE From tbl_borrowreturnbooks where booknumber='" & txt_bookno.Text & "'"
                    Dim cm00bo As New MySqlCommand(qstr00bo, conn)
                    Dim dat00bo As MySqlDataReader = cm00bo.ExecuteReader
                    dat00bo.Close()

                    Dim inc1 As String = "Update tbl_book set status = 'Lost' where booknumber= '" & txt_bookno.Text & "' "
                    Dim commm1 As New MySqlCommand(inc1, conn)
                    Dim dat1251 As MySqlDataReader = commm1.ExecuteReader
                    dat1251.Close()


                    conn.Close()


                    MsgBox("The Record has been Saved!!", MsgBoxStyle.Information)
                    txt_bookno.Clear()
                    txt_isbnn1.Clear()
                    txt_titlee1.Clear()
                    txt_auth_ln.Clear()
                    txt_auth_mn.Clear()
                    txt_auth_fn.Clear()
                    cmb_ddc.SelectedIndex = -1
                    cmb_categooory1.SelectedIndex = -1
                    txt_year.Clear()
                    txt_idno.Clear()
                    txt_namee.Clear()
                    txt_pubcom.Clear()
                    txt_year.Clear()
                    txt_address.Clear()
                    txt_copyright.Clear()
                    txt_datetoreturn.Clear()

                    AdminMainForms.Show()
                    Me.Hide()
                    txt_isbnn1.ReadOnly = False
                    txt_titlee1.ReadOnly = False
                    txt_auth_ln.ReadOnly = False
                    txt_auth_fn.ReadOnly = False
                    txt_auth_mn.ReadOnly = False
                    txt_year.ReadOnly = False
                    txt_pubcom.ReadOnly = False
                    txt_datetoreturn.ReadOnly = False
                    txt_namee.ReadOnly = False
                    txt_idno.ReadOnly = False
                    txt_bookno.ReadOnly = False
                    txt_address.ReadOnly = False
                    txt_copyright.ReadOnly = False
                End If
                'Refresh LOST BOOK FORM DataGridView
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim cmd0130 As New MySqlCommand("Select * from tbl_borrowreturnbooks", conn)
                Dim daw0130 As New MySqlDataAdapter
                daw0130.SelectCommand = cmd0130
                Dim dt0130 As New DataTable
                dt0130.Clear()
                daw0130.Fill(dt0130)
                DataGridView1.DataSource = dt0130
                conn.Close()
            Else
                MsgBox("Borrowed Book not found", MsgBoxStyle.Information)
                txt_bookno.Clear()
                txt_isbnn1.Clear()
                txt_titlee1.Clear()
                txt_auth_ln.Clear()
                txt_auth_mn.Clear()
                txt_auth_fn.Clear()
                cmb_ddc.SelectedIndex = -1
                cmb_categooory1.SelectedIndex = -1
                txt_year.Clear()
                txt_idno.Clear()
                txt_namee.Clear()
                txt_address.Clear()
                txt_copyright.Clear()
                txt_pubcom.Clear()
                txt_year.Clear()
                txt_datetoreturn.Clear()
                txt_isbnn1.Focus()
                txt_isbnn1.ReadOnly = False
                txt_titlee1.ReadOnly = False
                txt_auth_ln.ReadOnly = False
                txt_auth_fn.ReadOnly = False
                txt_auth_mn.ReadOnly = False
                txt_year.ReadOnly = False
                txt_pubcom.ReadOnly = False
                txt_datetoreturn.ReadOnly = False
                txt_namee.ReadOnly = False
                txt_idno.ReadOnly = False
                txt_bookno.ReadOnly = False
                txt_address.ReadOnly = False
                txt_copyright.ReadOnly = False
            End If
        End If
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * from tbl_borrowreturnbooks", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        DataGridView1.DataSource = dt013
        conn.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_isbnn1.Clear()
        txt_titlee1.Clear()
        txt_auth_ln.Clear()
        txt_auth_mn.Clear()
        txt_auth_fn.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory1.SelectedIndex = -1
        txt_pubcom.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_bookno.Clear()
        txt_pubcom.Clear()
        txt_year.Clear()
        txt_datetoreturn.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
    End Sub

    Private Sub btn_cncl1_Click(sender As Object, e As EventArgs) Handles btn_cncl1.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_isbnn1.Clear()
        txt_titlee1.Clear()
        txt_auth_ln.Clear()
        txt_auth_mn.Clear()
        txt_auth_fn.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory1.SelectedIndex = -1
        txt_pubcom.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_bookno.Clear()
        txt_pubcom.Clear()
        txt_year.Clear()
        txt_datetoreturn.Clear()

        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False

        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
    End Sub

    Private Sub Lost_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        bind_data()
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)

        'conn.Open()
        'Try
        '    Dim str As String = "SELECT category FROM tbl_category"
        '    Dim da As New MySqlDataAdapter(str, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    If dt.Rows.Count > 0 Then
        '        cmb_categooory1.DataSource = dt
        '        cmb_categooory1.DisplayMember = "category"
        '        cmb_categooory1.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        cmb_categooory1.SelectedIndex = -1
        '        cmb_categooory1.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        'conn.Open()
        'Try
        '    Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_ddc"
        '    Dim da1 As New MySqlDataAdapter(str1, conn)
        '    Dim dt1 As New DataTable
        '    da1.Fill(dt1)
        '    If dt1.Rows.Count > 0 Then
        '        cmb_ddc.DataSource = dt1
        '        cmb_ddc.DisplayMember = "DeweyDecimalClassification"
        '        cmb_ddc.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        cmb_ddc.SelectedIndex = -1
        '        cmb_ddc.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_categooory1.DataSource = dt
                cmb_categooory1.DisplayMember = "category"
                cmb_categooory1.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_categooory1.SelectedIndex = -1
                cmb_categooory1.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        conn.Open()
        Try
            Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_book GROUP BY DeweyDecimalClassification"
            Dim da1 As New MySqlDataAdapter(str1, conn)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                cmb_ddc.DataSource = dt1
                cmb_ddc.DisplayMember = "DeweyDecimalClassification"
                cmb_ddc.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_ddc.SelectedIndex = -1
                cmb_ddc.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False

        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub


    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_year.Click
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.Click
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_year.Text > currentYear Then
            MsgBox("Year does not yet exist", MsgBoxStyle.Information)
            txt_year.Clear()
            txt_year.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        conn.Close()
        conn.Open()

        Dim index As Integer
        index = DataGridView1.CurrentRow.Index
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        txt_bookno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_bookno.ReadOnly = True
        txt_isbnn1.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_isbnn1.ReadOnly = True
        txt_titlee1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txt_titlee1.ReadOnly = True
        txt_auth_ln.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txt_auth_ln.ReadOnly = True
        txt_auth_fn.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txt_auth_fn.ReadOnly = True
        txt_auth_mn.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txt_auth_mn.ReadOnly = True
        cmb_ddc.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        cmb_categooory1.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txt_year.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txt_year.ReadOnly = True
        txt_pubcom.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txt_pubcom.ReadOnly = True
        txt_address.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txt_address.ReadOnly = True
        txt_copyright.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        txt_copyright.ReadOnly = True
        txt_datetoreturn.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        txt_datetoreturn.ReadOnly = True
        txt_idno.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        txt_idno.ReadOnly = True
        txt_namee.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        txt_namee.ReadOnly = True
        conn.Close()
    End Sub

    Private Sub txt_year_TextChanged_1(sender As Object, e As EventArgs) Handles txt_year.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txt_copyright_TextChanged(sender As Object, e As EventArgs) Handles txt_copyright.TextChanged
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_copyright.Text > currentYear Then
            MsgBox("Invalid Year", MsgBoxStyle.Information)
            txt_copyright.Clear()
            txt_copyright.Focus()
        End If
    End Sub
End Class