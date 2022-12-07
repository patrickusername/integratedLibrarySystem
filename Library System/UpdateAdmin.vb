Imports MySql.Data.MySqlClient
Public Class UpdateAdmin
    Private Sub btn_saves10_Click(sender As Object, e As EventArgs) Handles btn_saves10.Click
        If txt_pword10.Text = "" Then
            MsgBox("Please Enter your Password", MsgBoxStyle.Critical)
            txt_pword10.Focus()
        ElseIf txt_contact.MaskCompleted = False Then
            MsgBox("Please Enter your Contact Number", MsgBoxStyle.Critical)
            txt_contact.Focus()
        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim qstr100 As String = "UPDATE tbl_admin SET Name='" & txt_name10.Text & "' , Password='" & txt_pword10.Text & "' , ContactNo = '" & txt_contact.Text & "' WHERE Username = '" & txt_uname10.Text & "'"
            Dim cmd100 As New MySqlCommand(qstr100, conn)
            Dim dat100 As MySqlDataReader = cmd100.ExecuteReader
            dat100.Close()

            Dim qstr As String = "UPDATE tbl_users SET Name='" & txt_name10.Text & "' , Password = '" & txt_pword10.Text & "' WHERE Username = '" & txt_uname10.Text & "'"
            Dim cm As New MySqlCommand(qstr, conn)
            Dim dat As MySqlDataReader = cm.ExecuteReader
            dat.Close()

            MsgBox("Admin's Information has been Updated!", MsgBoxStyle.Information)
                txt_unames.Clear()
                txt_uname10.Clear()
                txt_pword10.Clear()
                txt_name10.Clear()
                txt_contact.Clear()

                AdminMainForms.Show()
                Me.Hide()

            End If
            conn.Close()
    End Sub

    Private Sub btn_clears10_Click(sender As Object, e As EventArgs) Handles btn_clears10.Click
        'txt_uname10.Clear()
        txt_pword10.Clear()
        txt_name10.Clear()
        txt_pword10.Focus()
        txt_contact.Clear()


    End Sub

    Private Sub btn_cancels10_Click(sender As Object, e As EventArgs) Handles btn_cancels10.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_unames.Clear()
        txt_uname10.Clear()
        txt_pword10.Clear()
        txt_name10.Clear()
        txt_contact.Clear()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_unames.Clear()
        'txt_uname10.Clear()
        'txt_pword10.Clear()
        'txt_name10.Clear()
        'txt_contact.Clear()
        txt_unames.Focus()
    End Sub

    Private Sub btn_searchs_Click(sender As Object, e As EventArgs) Handles btn_searchs.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
            txt_unames.Focus()
        Else
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM tbl_admin WHERE Username = '" & txt_unames.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd1.ExecuteReader
            If data.Read Then
                If data(0) = txt_unames.Text Then
                    txt_uname10.Text = data(0)
                    txt_name10.Text = data(1)
                    txt_pword10.Text = data(2)
                    txt_contact.Text = data(3)
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

    Private Sub UpdateAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txt_name10_TextChanged(sender As Object, e As EventArgs) Handles txt_name10.TextChanged

    End Sub

    Private Sub txt_name10_Click(sender As Object, e As EventArgs) Handles txt_name10.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_pword10_TextChanged(sender As Object, e As EventArgs) Handles txt_pword10.TextChanged

    End Sub

    Private Sub txt_pword10_Click(sender As Object, e As EventArgs) Handles txt_pword10.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_contact_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_contact.MaskInputRejected

    End Sub

    Private Sub txt_contact_Click(sender As Object, e As EventArgs) Handles txt_contact.Click
        If txt_unames.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contact.KeyPress
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
            Dim qstr As String = "SELECT * FROM tbl_admin WHERE Username = '" & txt_unames.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                If data(0) = txt_unames.Text Then
                    txt_uname10.Text = data(0)
                    txt_name10.Text = data(1)
                    txt_pword10.Text = data(2)
                    txt_contact.Text = data(3)
                End If
                data.Close()
            End If
        End If
        conn.Close()

        'txt_name10.Focus()
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