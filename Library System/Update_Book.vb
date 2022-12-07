Imports MySql.Data.MySqlClient
Public Class Update_Book
    Public conn As New MySqlConnection(connString)
    'Dim str As String
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_search.Text = "" Then
            MsgBox("Please Enter Book Number", MsgBoxStyle.Critical)
            txt_search.Focus()
        Else
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM tbl_book WHERE BookNumber = '" & txt_search.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd1.ExecuteReader
            If data.Read Then
                If data(0) = txt_search.Text Then
                    txt_booknumber.Text = data(0)
                    txt_isbn.Text = data(1)
                    txt_title.Text = data(2)
                    txt_auth_ln.Text = data(3)
                    txt_auth_fn.Text = data(4)
                    txt_auth_mn.Text = data(5)
                    cmb_ddc.Text = data(6)
                    cmb_category.Text = data(7)
                    txt_yearofpub.Text = data(8)
                    txt_pubcom.Text = data(9)
                    txt_address.Text = data(10)
                    txt_copyright.Text = data(11)
                    txt_search.Clear()
                End If
            Else
                MsgBox("Book not found", MsgBoxStyle.Exclamation)
                txt_search.Clear()
                txt_search.Focus()

            End If
            conn.Close()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_isbn.Clear()
        txt_title.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        cmb_category.SelectedIndex = -1
        txt_yearofpub.Clear()
        txt_pubcom.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_booknumber.Clear()
        txt_address.Clear()
        txt_copyright.Clear()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_search.Clear()
        txt_search.Focus()
    End Sub

    Private Sub btn_clears_Click(sender As Object, e As EventArgs) Handles btn_clears.Click
        txt_search.Clear()
        txt_title.Clear()
        txt_isbn.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        txt_yearofpub.Clear()
        txt_pubcom.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_category.SelectedIndex = -1
        txt_booknumber.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_isbn.Text = "" Then
            MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
            txt_isbn.Focus()
        ElseIf txt_isbn.MaskCompleted = False Then
            MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
            txt_isbn.Focus()
        ElseIf txt_title.Text = "" Then
            MsgBox("Please Enter Title", MsgBoxStyle.Critical)
            txt_title.Focus()
            'ElseIf txt_auth_ln.Text = "" Or txt_auth_fn.Text = "" Or txt_auth_mn.Text = "" Then
            '    MsgBox("Please Enter Author", MsgBoxStyle.Critical)
            '    txt_auth_ln.Focus()
        ElseIf cmb_ddc.Text = "" Then
            MsgBox("Please Enter Dewey Decimal Classification", MsgBoxStyle.Critical)
            cmb_ddc.Focus()
        ElseIf cmb_category.Text = "" Then
            MsgBox("Please Enter Category", MsgBoxStyle.Critical)
            cmb_category.Focus()
        ElseIf txt_yearofpub.Text = "" Then
            MsgBox("Please Enter Year of Publication", MsgBoxStyle.Critical)
            txt_yearofpub.Focus()
        ElseIf txt_pubcom.Text = "" Then
            MsgBox("Please Enter Publisher", MsgBoxStyle.Critical)
            txt_pubcom.Focus()
        ElseIf txt_address.Text = "" Then
            MsgBox("Please Enter Address", MsgBoxStyle.Critical)
            txt_address.Focus()
        ElseIf txt_copyright.Text = "" Then
            MsgBox("Please Enter Copyright", MsgBoxStyle.Critical)
            txt_copyright.Focus()
        ElseIf txt_address.Text = "" Then
            MsgBox("Please Enter Address", MsgBoxStyle.Critical)
            txt_address.Focus()
        ElseIf txt_copyright.Text = "" Then
            MsgBox("Please Enter Copyright", MsgBoxStyle.Critical)
            txt_copyright.Focus()
        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            conn.Open()
            'Dim qstr As String = "UPDATE tbl_book SET ISBN = '" & txt_isbn.Text & "' , Title = '" & txt_title.Text & "' , Author = '" & txt_author.Text & "' , Category = '" & cmb_category.SelectedItem & "' , YearofPublication = '" & txt_yearofpub.Text & "' , PublishingCompany = '" & txt_pubcom.Text & "' , ClassNumber = '" & txt_classnum.Text & "' WHERE BookNumber = '" & txt_booknumber.Text & "'"
            Dim qstr As String = "UPDATE tbl_book SET ISBN='" & txt_isbn.Text & "' , Title ='" & txt_title.Text & "' , AuthorLastName = '" & txt_auth_ln.Text & "' , AuthorFirstName = '" & txt_auth_fn.Text & "' , AuthorMiddleName = '" & txt_auth_mn.Text & "' , DeweyDecimalClassification = '" & cmb_ddc.Text & "' , Category = '" & cmb_category.Text & "' , YearofPublication = '" & txt_yearofpub.Text & "' , Publisher = '" & txt_pubcom.Text & "' , Address = '" & txt_address.Text & "' , Copyright = '" & txt_copyright.Text & "' WHERE BookNumber = '" & txt_booknumber.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim dat As MySqlDataReader = cmd.ExecuteReader
            MsgBox("Book Information has been Updated!", MsgBoxStyle.Information)
            txt_search.Clear()
            txt_isbn.Clear()
            txt_title.Clear()
            txt_copyright.Clear()
            txt_address.Clear()
            txt_auth_ln.Clear()
            txt_auth_fn.Clear()
            txt_auth_mn.Clear()
            cmb_ddc.SelectedIndex = -1
            cmb_category.SelectedIndex = -1
            txt_yearofpub.Clear()
            txt_pubcom.Clear()
            txt_address.Clear()
            txt_copyright.Clear()
            txt_booknumber.Clear()
            AdminMainForms.Show()
            Me.Hide()

        End If
        conn.Close()
    End Sub

    Private Sub Update_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_category.DataSource = Nothing
        cmb_category.Text = ""


        'Me.WindowState = FormWindowState.Maximized
        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_category.DataSource = dt
                cmb_category.DisplayMember = "category"
                cmb_category.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_category.SelectedIndex = -1
                cmb_category.Refresh()
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
    End Sub
    Private Sub txt_yearofpub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_yearofpub.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
    'Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pubcom.KeyPress
    '    If e.KeyChar = ChrW(Keys.Back) Then
    '    Else
    '        If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
    Private Sub txt_isbn_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_isbn.MaskInputRejected

    End Sub

    Private Sub txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_isbn.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        If e.KeyChar = ChrW(13) Then

            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_book where BookNumber = '" & txt_search.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                If data(0) = txt_search.Text Then
                    txt_booknumber.Text = data(0)
                    txt_isbn.Text = data(1)
                    txt_title.Text = data(2)
                    txt_auth_ln.Text = data(3)
                    txt_auth_fn.Text = data(4)
                    txt_auth_mn.Text = data(5)
                    cmb_ddc.Text = data(6)
                    cmb_category.Text = data(7)
                    txt_yearofpub.Text = data(8)
                    txt_pubcom.Text = data(9)
                    txt_address.Text = data(10)
                    txt_copyright.Text = data(11)

                End If
                data.Close()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub txt_yearofpub_TextChanged(sender As Object, e As EventArgs) Handles txt_yearofpub.TextChanged
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_yearofpub.Text > currentYear Then
            MsgBox("Year does not yet exist", MsgBoxStyle.Information)
            txt_yearofpub.Clear()
            txt_yearofpub.Focus()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

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