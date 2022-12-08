Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs)
        txt_uname.Clear()
        txt_pword.Clear()
        txt_uname.Focus()

    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If txt_uname.Text = "" Then
            MsgBox("Please Enter your Username", MsgBoxStyle.Critical)
            txt_uname.Focus()
        ElseIf txt_pword.Text = "" Then
            MsgBox("Please Enter your Password", MsgBoxStyle.Critical)
            txt_pword.Focus()
        Else
            conn.Open()
            Dim qstr1 As String = "SELECT * FROM tbl_users WHERE Username='" & txt_uname.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr1, conn)
            Dim data1 As MySqlDataReader = cmd1.ExecuteReader

            If data1.Read Then
                Dim ulvl = data1(3)
                Select Case ulvl
                    Case "Admin"
                        If data1(0) = txt_uname.Text Then
                            If data1(2) = txt_pword.Text Then
                                MsgBox("Welcome " & data1(1), MsgBoxStyle.Information)
                                AdminMainForms.lbl_name.Text = data1(1)
                                AdminMainForms.lbl_usertype.Text = data1(3)
                                AdminMainForms.Show()
                                Me.Hide()

                            Else
                                MsgBox("Incorrect Password", MsgBoxStyle.Critical)
                                txt_pword.Clear()
                                txt_pword.Focus()
                            End If
                        End If

                    Case "Faculty"
                        If data1(0) = txt_uname.Text Then
                            If data1(2) = txt_pword.Text Then
                                MsgBox("Welcome " & data1(1), MsgBoxStyle.Information)
                                TeacherMainForm.lbl_name.Text = data1(1)
                                TeacherMainForm.lbl_usertype.Text = data1(3)
                                TeacherMainForm.Show()
                                Me.Hide()

                            Else
                                MsgBox("Incorrect Password", MsgBoxStyle.Critical)
                                txt_pword.Clear()
                                txt_pword.Focus()
                            End If
                        End If

                    Case "Student"
                        If data1(0) = txt_uname.Text Then
                            If data1(2) = txt_pword.Text Then
                                MsgBox("Welcome " & data1(1), MsgBoxStyle.Information)
                                Main_Form.lbl_name.Text = data1(1)
                                Main_Form.lbl_usertype.Text = data1(3)
                                Main_Form.Show()
                                Me.Hide()

                            Else
                                MsgBox("Incorrect Password", MsgBoxStyle.Critical)
                                txt_pword.Clear()
                                txt_pword.Focus()
                            End If
                        End If
                End Select
            Else
                MsgBox("User not Found", MsgBoxStyle.Critical)
                txt_uname.Clear()
                txt_pword.Clear()
                txt_uname.Focus()
            End If
            conn.Close()
        End If

    End Sub

    Private Sub txt_uname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uname.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_exit_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Refresh tbl_user
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_users", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub
End Class
