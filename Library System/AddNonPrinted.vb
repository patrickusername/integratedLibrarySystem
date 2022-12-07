Imports MySql.Data.MySqlClient
Public Class AddNonPrinted
    Private Sub btn_cancl_Click(sender As Object, e As EventArgs) Handles btn_cancl.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_matno.Clear()
        txt_matname.Clear()

    End Sub

    Private Sub btn_add1_Click(sender As Object, e As EventArgs) Handles btn_add1.Click
        If txt_quantity.Text = "" Then
            MsgBox("Please Enter Quantity", MsgBoxStyle.Critical)
            txt_quantity.Focus()
        ElseIf txt_matno.Text = "" Then
            MsgBox("Please Enter Material Number", MsgBoxStyle.Critical)
            txt_matno.Focus()
        ElseIf txt_matname.Text = "" Then
            MsgBox("Please Enter Material Name", MsgBoxStyle.Critical)
            txt_matname.Focus()
        ElseIf MsgBox("Are you sure you want to add New Material?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            conn.Open()
            Dim qstr12 As String = "SELECT count(MaterialNumber) FROM tbl_nonprinted WHERE materialNumber='" & txt_matno.Text & "'"
            Dim cmd12 As New MySqlCommand(qstr12, conn)
            Dim userCounter1 As Integer = cmd12.ExecuteScalar
            Dim data12 As MySqlDataReader = cmd12.ExecuteReader
            If data12.Read Then
                data12.Close()
                conn.Close()
                conn.Open()

                If userCounter1 > 0 Then
                    txt_matno.Clear()
                    txt_matname.Clear()
                    PictureBox1.Image = Nothing
                    MsgBox("Material Already Exist", MsgBoxStyle.Critical)

                Else
                    Dim qstr As String = "INSERT INTO tbl_nonprinted (MaterialNumber,MaterialName) VALUES ('" & txt_matno.Text & "' ,'" & txt_matname.Text & "') On DUPLICATE KEY UPDATE materialnumber = '" & txt_matno.Text & "'"
                    Dim cm As New MySqlCommand(qstr, conn)
                    Dim dat As MySqlDataReader = cm.ExecuteReader
                    dat.Close()

                    Dim qstr1 As String = "Update  tbl_nonprinted set status = 'Available' where materialnumber= '" & txt_matno.Text & "' "
                    Dim cm1 As New MySqlCommand(qstr1, conn)
                    Dim dat1 As MySqlDataReader = cm1.ExecuteReader
                    dat1.Close()

                    Dim qstr14 As String = "Update  tbl_nonprinted set conditions = 'Good' where materialnumber= '" & txt_matno.Text & "' "
                    Dim cm14 As New MySqlCommand(qstr14, conn)
                    Dim dat14 As MySqlDataReader = cm14.ExecuteReader
                    dat14.Close()

                    Dim book As String = txt_matno.Text & ".jpg"
                    Dim folder As String = "C:\Users\patrick\Desktop\NONPRINTED BARCODE\"
                    Dim query As String = "Update tbl_nonprinted set ImagePath = @pathstring where MaterialNumber = '" & txt_matno.Text & "'"
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

                    MsgBox("The Material has been added!", MsgBoxStyle.Information)

                    txt_matno.Clear()
                    txt_matname.Clear()

                    'Refresh DataTable
                    Dim cmd13 As New MySqlCommand("Select * From Tbl_nonprinted", conn)
                    Dim daw13 As New MySqlDataAdapter
                    daw13.SelectCommand = cmd13
                    Dim dt13 As New DataTable
                    dt13.Clear()
                    daw13.Fill(dt13)
                    SearchNonPrinted.DataGridView1.DataSource = dt13

                    'Refresh DataTable
                    Dim cmd131 As New MySqlCommand("Select * From Tbl_nonprinted", conn)
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
        'End If

        'PictureBox1.Image.Save("C:\ariane\" & txt_booknum.Text & " .Gif")
        conn.Close()
    End Sub

    Private Sub AddNonPrinted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_quantity.Focus()
        'Me.WindowState = FormWindowState.Maximized
        'AUTOINCREMENT AND AUTOFILL BOOK NUMBER
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim strsql = "Select materialnumber from tbl_nonprinted where materialnumber=(select max(materialnumber)from tbl_nonprinted)"
        Dim cmddd1 As New MySqlCommand(strsql, conn)
        Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
        If myreader.Read() Then
            txt_matno.Text = myreader("materialnumber") + 1
        End If
        conn.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_matname.Clear()
        txt_matno.Clear()
        txt_matno.Focus()
    End Sub

    Private Sub txt_matno_TextChanged(sender As Object, e As EventArgs) Handles txt_matno.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = txt_matno.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txt_matno.Text))

        Catch ex As Exception

        End Try
        If txt_matno.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub txt_matno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matno.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class