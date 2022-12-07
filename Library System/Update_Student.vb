Imports MySql.Data.MySqlClient
Public Class Update_Student
    Private Sub btn_studsaves_Click(sender As Object, e As EventArgs) Handles btn_studsaves.Click
        If txt_studpword.Text = "" Then
            MsgBox("Please Enter your Password", MsgBoxStyle.Critical)
            txt_studpword.Focus()
        ElseIf txt_studcontact.MaskCompleted = False Then
            MsgBox("Please Enter your Contact Number", MsgBoxStyle.Critical)
            txt_studcontact.Focus()
        ElseIf txt_studgs.Text = "" Then
            MsgBox("Please Enter your Grade and Section", MsgBoxStyle.Critical)
            txt_studgs.Focus()
        ElseIf txt_studtea.Text = "" Then
            MsgBox("Please Enter your Teacher", MsgBoxStyle.Critical)
            txt_studtea.Focus()

        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            conn.Open()
            Dim qstr As String = "UPDATE tbl_student SET Name='" & txt_studname.Text & "' , Password ='" & txt_studpword.Text & "' , contactNo = '" & txt_studcontact.Text & "' , gradesec = '" & txt_studgs.Text & "' , teacher = '" & txt_studtea.Text & "' WHERE Username = '" & txt_studuname.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim dat As MySqlDataReader = cmd.ExecuteReader
            dat.Close()

            Dim qstr1 As String = "UPDATE tbl_users SET Name='" & txt_studname.Text & "' , Password = '" & txt_studpword.Text & "' WHERE Username = '" & txt_studuname.Text & "'"
            Dim cm1 As New MySqlCommand(qstr1, conn)
            Dim dat1 As MySqlDataReader = cm1.ExecuteReader
            dat1.Close()

            MsgBox("Student's Information has been Updated!", MsgBoxStyle.Information)
            txt_studuname.Clear()
            txt_studname.Clear()
            txt_studpword.Clear()
            txt_studcontact.Clear()
            txt_studgs.Clear()
            txt_studtea.Clear()

            Form1.Show()
            Me.Hide()
            Main_Form.Hide()
            Form1.txt_uname.Clear()
            Form1.txt_pword.Clear()
            Form1.txt_uname.Focus()

        End If
        conn.Close()
    End Sub

    Private Sub btn_studcancels_Click(sender As Object, e As EventArgs) Handles btn_studcancels.Click
        Main_Form.Show()
        Me.Hide()
    End Sub

    Private Sub btn_studclears_Click(sender As Object, e As EventArgs) Handles btn_studclears.Click
        txt_studpword.Clear()
        txt_studcontact.Clear()
        txt_studgs.Clear()
        txt_studtea.Clear()
        txt_studpword.Focus()
    End Sub

    Private Sub Update_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txt_studcontact_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_studcontact.MaskInputRejected

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
End Class