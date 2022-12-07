Imports MySql.Data.MySqlClient
Public Class Add_DDC
    Public conn As New MySqlConnection("server=localhost;uid=root;database=db_system")
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_ddc.Text = "" Then
            MsgBox("Please Enter New Dewey Decimal Classification", MsgBoxStyle.Critical)
            txt_ddc.Focus()
        ElseIf MsgBox("Are you sure you want to add New Dewey Decimal Classification?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim qstr12 As String = "SELECT count(deweydecimalclassification) FROM tbl_ddc WHERE deweydecimalclassification='" & txt_ddc.Text & "'"
            Dim cmd12 As New MySqlCommand(qstr12, conn)
            Dim userCounter1 As Integer = cmd12.ExecuteScalar
            Dim data12 As MySqlDataReader = cmd12.ExecuteReader
            If data12.Read Then
                data12.Close()


                If userCounter1 > 0 Then
                    MsgBox("Dewey Decimal Classification Already Exist", MsgBoxStyle.Critical)
                    txt_ddc.Clear()
                Else

                    Dim qstr As String = "INSERT INTO tbl_ddc (deweydecimalclassification) VALUES ('" & txt_ddc.Text & "') On DUPLICATE KEY UPDATE deweydecimalclassification = '" & txt_ddc.Text & "'"
                    Dim cm As New MySqlCommand(qstr, conn)
                    Dim dat As MySqlDataReader = cm.ExecuteReader
                    dat.Close()
                    MsgBox("Dewey Decimal Classification has been added!", MsgBoxStyle.Information)

                    Add_Book.Show()
                    Add_Book.cmb_ddc.Text = txt_ddc.Text
                    Me.Hide()

                    'Refresh DataTable
                    Dim cmd131 As New MySqlCommand("Select * From tbl_ddc", conn)
                    Dim daw131 As New MySqlDataAdapter
                    daw131.SelectCommand = cmd131
                    Dim dt131 As New DataTable
                    dt131.Clear()
                    daw131.Fill(dt131)
                    conn.Close()

                    conn.Open()
                    Try
                        Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_ddc"
                        Dim da1 As New MySqlDataAdapter(str1, conn)
                        Dim dt1 As New DataTable
                        da1.Fill(dt1)
                        If dt1.Rows.Count > 0 Then
                            Add_Book.cmb_ddc.DataSource = dt1
                            Add_Book.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
                            Add_Book.cmb_ddc.ValueMember = ""
                            'cmb_category.DataSource = dt
                            Add_Book.cmb_ddc.SelectedIndex = -1
                            Add_Book.cmb_ddc.Refresh()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Add_Book.Show()
                    Add_Book.cmb_ddc.Text = txt_ddc.Text
                    Me.Hide()
                    conn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Add_Book.Show()
        Me.Hide()
    End Sub

    Private Sub Add_DDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ddc.Clear()
    End Sub
End Class