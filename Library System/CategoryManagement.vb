Imports MySql.Data.MySqlClient
Public Class CategoryManagement
    Public conn As New MySqlConnection("server=localhost;uid=root;database=db_system")
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        AdminMainForms.Show()
        Me.Hide()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_category.Text = "" Then
            MsgBox("Please Enter New Dewey Decimal Classification", MsgBoxStyle.Critical)
            txt_category.Focus()
        ElseIf txt_days.Text = "" Then
            MsgBox("Please Enter Days to Borrow", MsgBoxStyle.Critical)
            txt_days.Focus()
        ElseIf MsgBox("Are you sure you want to add New Category?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim qstr12 As String = "SELECT count(category) FROM tbl_category WHERE category='" & txt_category.Text & "'"
            Dim cmd12 As New MySqlCommand(qstr12, conn)
            Dim userCounter1 As Integer = cmd12.ExecuteScalar
            Dim data12 As MySqlDataReader = cmd12.ExecuteReader
            If data12.Read Then
                data12.Close()


                If userCounter1 > 0 Then
                    MsgBox("Category Already Exist", MsgBoxStyle.Critical)
                    txt_category.Clear()
                    txt_days.Clear()
                    txt_category.Focus()
                Else

                    Dim qstr As String = "INSERT INTO tbl_category (category,daystoborrow) VALUES ('" & txt_category.Text & "' , '" & txt_days.Text & "' ) On DUPLICATE KEY UPDATE category = '" & txt_category.Text & "'"
                    Dim cm As New MySqlCommand(qstr, conn)
                    Dim dat As MySqlDataReader = cm.ExecuteReader
                    dat.Close()
                    MsgBox("Category has been added!", MsgBoxStyle.Information)

                    Add_Book.Show()
                    Add_Book.cmb_categoory.Text = txt_category.Text
                    Me.Hide()

                    'Refresh DataTable
                    Dim cmd131 As New MySqlCommand("Select * From tbl_category", conn)
                    Dim daw131 As New MySqlDataAdapter
                    daw131.SelectCommand = cmd131
                    Dim dt131 As New DataTable
                    dt131.Clear()
                    daw131.Fill(dt131)
                    conn.Close()

                    conn.Open()
                    Try
                        Dim str1 As String = "SELECT category FROM tbl_category"
                        Dim da1 As New MySqlDataAdapter(str1, conn)
                        Dim dt1 As New DataTable
                        da1.Fill(dt1)
                        If dt1.Rows.Count > 0 Then
                            Add_Book.cmb_categoory.DataSource = dt1
                            Add_Book.cmb_categoory.DisplayMember = "category"
                            Add_Book.cmb_categoory.ValueMember = ""
                            'cmb_category.DataSource = dt
                            Add_Book.cmb_categoory.SelectedIndex = -1
                            Add_Book.cmb_categoory.Refresh()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    AdminMainForms.Show()
                    Me.Hide()
                    conn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub CategoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_category.Focus()
        txt_category.Clear()
        txt_days.Clear()
    End Sub
    Private Sub txt_days_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_days.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class