Imports MySql.Data.MySqlClient
Public Class UpdateNonPrinted
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_search.Text = "" Then
            MsgBox("Please Enter Material Number", MsgBoxStyle.Critical)
            txt_search.Focus()
        Else
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM tbl_nonprinted WHERE MaterialNumber = '" & txt_search.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd1.ExecuteReader
            If data.Read Then
                If data(0) = txt_search.Text Then
                    txt_matno.Text = data(0)
                    txt_matname.Text = data(1)
                    txt_search.Clear()
                End If
            Else
                MsgBox("Material not found", MsgBoxStyle.Exclamation)
                txt_search.Clear()
                txt_search.Focus()

            End If
            conn.Close()
        End If
    End Sub

    Private Sub btn_clears_Click(sender As Object, e As EventArgs) Handles btn_clears.Click
        txt_matno.Clear()
        txt_matname.Clear()
        txt_matname.Focus()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_matno.Clear()
        txt_matname.Clear()
        AdminMainForms.Show()
        Me.Hide()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_search.Clear()
        txt_search.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_matname.Text = "" Then
            MsgBox("Please Enter Material Name", MsgBoxStyle.Critical)
            txt_matname.Focus()

        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            conn.Open()
            'Dim qstr As String = "UPDATE tbl_book SET ISBN = '" & txt_isbn.Text & "' , Title = '" & txt_title.Text & "' , Author = '" & txt_author.Text & "' , Category = '" & cmb_category.SelectedItem & "' , YearofPublication = '" & txt_yearofpub.Text & "' , PublishingCompany = '" & txt_pubcom.Text & "' , ClassNumber = '" & txt_classnum.Text & "' WHERE BookNumber = '" & txt_booknumber.Text & "'"
            Dim qstr As String = "UPDATE tbl_nonprinted SET MaterialName='" & txt_matname.Text & "' WHERE MaterialNumber = '" & txt_matno.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim dat As MySqlDataReader = cmd.ExecuteReader
            MsgBox("Material Information has been Updated!", MsgBoxStyle.Information)
            txt_search.Clear()
            txt_matno.Clear()
            txt_matname.Clear()
            AdminMainForms.Show()
            Me.Hide()

        End If
        conn.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class