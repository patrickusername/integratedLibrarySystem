Imports MySql.Data.MySqlClient
Public Class UpdateFaculty
    Private Sub btn_searchs_Click(sender As Object, e As EventArgs) Handles btn_searchs.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
            txt_unames.Focus()
        Else
            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_faculty WHERE Username = '" & txt_unames.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd1.ExecuteReader
            If data.Read Then
                If data(0) = txt_unames.Text Then
                    txt_studuname.Text = data(0)
                    txt_studname.Text = data(1)
                    txt_studcontact.Text = data(2)
                    txt_advisory.Text = data(3)
                    txt_studpword.Text = data(4)
                    txt_unames.Clear()

                End If
            Else
                MsgBox("Username not found", MsgBoxStyle.Exclamation)
                txt_unames.Clear()
                txt_unames.Focus()

            End If
            conn.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_unames.Clear()
        'txt_studuname.Clear()
        'txt_studname.Clear()
        'txt_studcontact.Clear()
        'txt_advisory.Clear()
        'txt_studpword.Clear()
        txt_unames.Focus()
    End Sub

    Private Sub btn_studclears_Click(sender As Object, e As EventArgs) Handles btn_studclears.Click
        txt_studpword.Clear()
        txt_studcontact.Clear()
        txt_advisory.Clear()
        txt_studpword.Focus()
        txt_studname.Clear()
    End Sub

    Private Sub btn_studcancels_Click(sender As Object, e As EventArgs) Handles btn_studcancels.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_unames.Clear()
        txt_studuname.Clear()
        txt_studname.Clear()
        txt_studcontact.Clear()
        txt_advisory.Clear()
        txt_studpword.Clear()
    End Sub

    Private Sub btn_studsaves_Click(sender As Object, e As EventArgs) Handles btn_studsaves.Click
        If txt_studpword.Text = "" Then
            MsgBox("Please Enter your Password", MsgBoxStyle.Critical)
            txt_studpword.Focus()
        ElseIf txt_studcontact.MaskCompleted = False Then
            MsgBox("Please Enter your Contact Number", MsgBoxStyle.Critical)
            txt_studcontact.Focus()
        ElseIf txt_advisory.Text = "" Then
            MsgBox("Please Enter your Advisory Class", MsgBoxStyle.Critical)
            txt_advisory.Focus()

        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            conn.Open()
            Dim qstr As String = "UPDATE tbl_faculty SET Name='" & txt_studname.Text & "' , Password='" & txt_studpword.Text & "' , contactNo = '" & txt_studcontact.Text & "' , advisoryclass = '" & txt_advisory.Text & "' WHERE Username = '" & txt_studuname.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim dat As MySqlDataReader = cmd.ExecuteReader
            dat.Close()
            Dim qstr1 As String = "UPDATE tbl_users SET Name='" & txt_studname.Text & "' , Password = '" & txt_studpword.Text & "' WHERE Username = '" & txt_studuname.Text & "'"
            Dim cm1 As New MySqlCommand(qstr1, conn)
            Dim dat1 As MySqlDataReader = cm1.ExecuteReader
            dat1.Close()
            MsgBox("Faculty's Information has been Updated!", MsgBoxStyle.Information)
            txt_unames.Clear()
            txt_studuname.Clear()
            txt_studname.Clear()
            txt_studpword.Clear()
            txt_studcontact.Clear()
            txt_advisory.Clear()
            AdminMainForms.Show()
            Me.Hide()

        End If
        conn.Close()
    End Sub

    Private Sub UpdateFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txt_studname_TextChanged(sender As Object, e As EventArgs) Handles txt_studname.TextChanged

    End Sub

    Private Sub txt_studname_Click(sender As Object, e As EventArgs) Handles txt_studname.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_studpword_TextChanged(sender As Object, e As EventArgs) Handles txt_studpword.TextChanged

    End Sub

    Private Sub txt_studpword_Click(sender As Object, e As EventArgs) Handles txt_studpword.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_studcontact_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_studcontact.MaskInputRejected

    End Sub

    Private Sub txt_studcontact_CausesValidationChanged(sender As Object, e As EventArgs) Handles txt_studcontact.CausesValidationChanged
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_advisory_TextChanged(sender As Object, e As EventArgs) Handles txt_advisory.TextChanged

    End Sub

    Private Sub txt_advisory_Click(sender As Object, e As EventArgs) Handles txt_advisory.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_studcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_studcontact.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_unames_TextChanged(sender As Object, e As EventArgs) Handles txt_unames.TextChanged

    End Sub

    Private Sub txt_unames_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unames.KeyPress
        If e.KeyChar = ChrW(13) Then

            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_faculty WHERE Username = '" & txt_unames.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                If data(0) = txt_unames.Text Then
                    txt_studuname.Text = data(0)
                    txt_studname.Text = data(1)
                    txt_studpword.Text = data(4)
                    txt_studcontact.Text = data(2)
                    txt_advisory.Text = data(3)
                End If
                data.Close()
            End If
        End If
        conn.Close()
    End Sub



    'Private Sub txt_unames_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_unames.KeyPress
    '    If e.KeyChar = ChrW(Keys.Back) Then
    '    Else
    '        If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
End Class