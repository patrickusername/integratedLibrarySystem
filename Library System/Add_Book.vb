Imports MySql.Data.MySqlClient

Public Class Add_Book
    Public conn As New MySqlConnection(connString)
    Private Sub btn_cancl_Click(sender As Object, e As EventArgs) Handles btn_cancl.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_isbn4.Clear()
        txt_title4.Clear()
        txt_author4.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categoory.SelectedIndex = -1
        txt_address.Clear()
        txt_copyright.Clear()
        txt_year.Clear()
        txt_booknum.Clear()
        txt_pubcom.Clear()
    End Sub

    Private Sub btn_add1_Click(sender As Object, e As EventArgs) Handles btn_add1.Click
        If txt_booknum.Text = "" Then
            MsgBox("Please Enter Book Number", MsgBoxStyle.Critical)
            txt_booknum.Focus()

        ElseIf txt_isbn4.Text = "   -  -" Then
            MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
            txt_isbn4.Focus()

        ElseIf txt_title4.Text = "" Then
            MsgBox("Please Enter Title", MsgBoxStyle.Critical)
            txt_title4.Focus()

        ElseIf txt_author4.Text = "" Then
            MsgBox("Please Enter Author", MsgBoxStyle.Critical)
            txt_author4.Focus()
        ElseIf txt_address.Text = "" Then
            MsgBox("Please Enter Address", MsgBoxStyle.Critical)
            txt_address.Focus()

        ElseIf txt_copyright.Text = "" Then
            MsgBox("Please Enter Copyright", MsgBoxStyle.Critical)
            txt_copyright.Focus()
        ElseIf cmb_ddc.Text = "" Then
            MsgBox("Please Enter Dewey Decimal Classification", MsgBoxStyle.Critical)
            cmb_ddc.Focus()
        ElseIf cmb_categoory.Text = "" Then
            MsgBox("Please Enter Category", MsgBoxStyle.Critical)
            cmb_categoory.Focus()
        ElseIf txt_year.Text = "" Then
            MsgBox("Please Enter Year Of Publication", MsgBoxStyle.Critical)
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
        ElseIf MsgBox("Are you sure you want to add New Book?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            conn.Open()

            Dim qstr12 As String = "SELECT count(BookNumber) FROM tbl_book WHERE BookNumber='" & txt_booknum.Text & "'"
            Dim cmd12 As New MySqlCommand(qstr12, conn)
            Dim userCounter1 As Integer = cmd12.ExecuteScalar
            Dim data12 As MySqlDataReader = cmd12.ExecuteReader
            If data12.Read Then
                data12.Close()
                conn.Close()
                conn.Open()

                If userCounter1 > 0 Then
                    txt_booknum.Clear()
                    txt_isbn4.Clear()
                    txt_title4.Clear()
                    txt_author4.Clear()
                    cmb_categoory.SelectedIndex = -1
                    txt_year.Clear()
                    txt_pubcom.Clear()
                    txt_copyright.Clear()
                    txt_address.Clear()
                    txt_address.Clear()
                    txt_copyright.Clear()
                    txt_isbn4.Focus()
                Else

                    Dim qstr As String = "INSERT INTO tbl_book (BookNumber,isbn,title,author,DeweyDecimalClassification,category,yearofpublication,publisher,address,copyright,address, copyright) VALUES ('" & txt_booknum.Text & "' ,'" & txt_isbn4.Text & "' , '" & txt_title4.Text & "' , '" & txt_author4.Text & "' , '" & cmb_ddc.Text & "' , '" & cmb_categoory.Text & "' , '" & txt_year.Text & "' , '" & txt_pubcom.Text & "' , '" & txt_address.Text & "' , '" & txt_copyright.Text & "') On DUPLICATE KEY UPDATE booknumber = '" & txt_booknum.Text & "'"
                    Dim cm As New MySqlCommand(qstr, conn)
                    Dim dat As MySqlDataReader = cm.ExecuteReader
                    dat.Close()

                    Dim qstr1 As String = "Update  tbl_book set status = 'Available' where booknumber= '" & txt_booknum.Text & "' "
                    Dim cm1 As New MySqlCommand(qstr1, conn)
                    Dim dat1 As MySqlDataReader = cm1.ExecuteReader
                    dat1.Close()

                    Dim book As String = txt_booknum.Text & ".jpg"
                    Dim folder As String = "C:\Barcode\"
                    Dim query As String = "Update tbl_book set ImagePath = @pathstring where BookNumber = '" & txt_booknum.Text & "'"
                    Using con As MySqlConnection = New MySqlConnection(connString)
                        Using cmd As MySqlCommand = New MySqlCommand(query, con)
                            Dim pathstring As String = System.IO.Path.Combine(folder, book)
                            cmd.Parameters.AddWithValue("@pathstring", pathstring)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                            Dim a As Image = PictureBox1.Image
                            a.Save(pathstring)
                        End Using
                    End Using

                    MsgBox("The Book has been added!", MsgBoxStyle.Information)

                    txt_isbn4.Clear()
                    txt_title4.Clear()
                    txt_author4.Clear()
                    cmb_categoory.SelectedIndex = -1
                    txt_year.Clear()
                    txt_booknum.Clear()
                    txt_pubcom.Clear()
                    txt_address.Clear()
                    txt_copyright.Clear()
                    txt_isbn4.Focus()
                    txt_copyright.Clear()
                    txt_address.Clear()

                    'Refresh DataTable
                    Dim cmd13 As New MySqlCommand("Select * From Tbl_book", conn)
                    Dim daw13 As New MySqlDataAdapter
                    daw13.SelectCommand = cmd13
                    Dim dt13 As New DataTable
                    dt13.Clear()
                    daw13.Fill(dt13)
                    SearchBook.DataGridView1.DataSource = dt13

                    'Refresh DataTable
                    Dim cmd131 As New MySqlCommand("Select * From Tbl_book", conn)
                    Dim daw131 As New MySqlDataAdapter
                    daw131.SelectCommand = cmd131
                    Dim dt131 As New DataTable
                    dt131.Clear()
                    daw131.Fill(dt131)
                    SearchBook.DataGridView1.DataSource = dt131

                    AdminMainForms.Show()
                    Me.Hide()
                End If

            End If
        End If
        conn.Close()


    End Sub

    Private Sub Add_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_categoory.DataSource = dt
                cmb_categoory.DisplayMember = "category"
                cmb_categoory.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_categoory.SelectedIndex = -1
                cmb_categoory.Refresh()
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

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_isbn4.Clear()
        txt_title4.Clear()
        txt_author4.Clear()
        cmb_categoory.SelectedIndex = -1
        txt_booknum.Clear()
        txt_pubcom.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_year.Clear()
        cmb_ddc.SelectedIndex = -1
        txt_copyright.Clear()
        txt_address.Clear()
    End Sub

    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.TextChanged
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_year.Text > currentYear Then
            MsgBox("Invalid Year", MsgBoxStyle.Information)
            txt_year.Clear()
            txt_year.Focus()
        End If
    End Sub

    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_year.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txt_isbn4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_isbn4.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_booknum_TextChanged(sender As Object, e As EventArgs) Handles txt_booknum.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = txt_booknum.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txt_booknum.Text))

        Catch ex As Exception

        End Try
        If txt_booknum.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class