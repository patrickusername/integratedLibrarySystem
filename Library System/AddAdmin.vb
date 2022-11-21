Imports MySql.Data.MySqlClient
Public Class AddAdmin
    Private Sub Add_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txt_pword1.Text = "password"

        ListView1.Columns.Add("Username", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 120, HorizontalAlignment.Left)
        ListView1.Columns.Add("Password", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("ContactNo", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("ImagePath", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Usertype", 80, HorizontalAlignment.Left)

        Me.WindowState = FormWindowState.Maximized

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_name.Text = "" Then
            MsgBox("Please Enter your Name", MsgBoxStyle.Critical)
            txt_name.Focus()

        ElseIf txt_uname1.Text = "" Then
            MsgBox("Please Enter your Username", MsgBoxStyle.Critical)
            txt_uname1.Focus()

        ElseIf txt_contact.Text = "(+63)    -    -" Then
            MsgBox("Please Enter your Contact Number", MsgBoxStyle.Critical)
            txt_contact.Focus()

        ElseIf MsgBox("Are you sure you want to add this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim qstr1 As String = "SELECT count(Username) FROM tbl_users WHERE Username='" & txt_uname1.Text & "'"
            Dim cmd1 As New MySqlCommand(qstr1, conn)
            Dim userCounter As Integer = cmd1.ExecuteScalar
            Dim data1 As MySqlDataReader = cmd1.ExecuteReader

            If data1.Read Then
                If userCounter > 0 Then
                    MsgBox("User already exists! ", MsgBoxStyle.Exclamation)
                    txt_uname1.Clear()
                    txt_name.Clear()
                    txt_contact.Clear()

                Else

                    Dim uname As String = txt_uname1.Text & ".jpg"
                    Dim folder As String = "C:\Barcode\"
                    Dim query As String = "Update tbl_admin set ImagePath = @pathstring where Username = '" & txt_uname1.Text & "'"
                    Using con As MySqlConnection = New MySqlConnection(connString)
                        Using cmd As MySqlCommand = New MySqlCommand(query, con)
                            Dim pathstring As String = System.IO.Path.Combine(folder, uname)
                            cmd.Parameters.AddWithValue("@pathstring", pathstring)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                            Dim a As Image = PictureBox1.Image
                            a.Save(pathstring)

                            Dim newitem As New ListViewItem(txt_uname1.Text)
                            newitem.SubItems.Add(txt_name.Text)
                            newitem.SubItems.Add(txt_pword1.Text)
                            newitem.SubItems.Add(txt_contact.Text)
                            newitem.SubItems.Add(pathstring)
                            newitem.SubItems.Add("Admin")

                            ListView1.Items.Add(newitem)

                        End Using
                    End Using

                    txt_uname1.Clear()
                    txt_name.Clear()
                    txt_contact.Clear()

                End If
            End If
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        If MsgBox("Are you sure you want to add this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            For Each lvitem As ListViewItem In ListView1.Items
                Dim conn As New MySqlConnection(connString)
                Dim cmmds As New MySqlCommand("Insert Into tbl_admin (Username,Name,Password,ContactNo,ImagePath) VALUES (@Username,@Name,@Password,@ContactNo,@ImagePath)", conn)
                cmmds.Parameters.AddWithValue("@Username", lvitem.SubItems(0).Text)
                cmmds.Parameters.AddWithValue("@Name", lvitem.SubItems(1).Text)
                cmmds.Parameters.AddWithValue("@Password", lvitem.SubItems(2).Text)
                cmmds.Parameters.AddWithValue("@ContactNo", lvitem.SubItems(3).Text)
                cmmds.Parameters.AddWithValue("@ImagePath", lvitem.SubItems(4).Text)
                conn.Open()
                cmmds.ExecuteNonQuery()
                conn.Close()

                Dim conn1 As New MySqlConnection(connString)
                Dim cmmds1 As New MySqlCommand("Insert Into tbl_users (Username,Name,Password,Usertype) VALUES (@Username,@Name,@Password,@Usertype)", conn1)
                cmmds1.Parameters.AddWithValue("@Username", lvitem.SubItems(0).Text)
                cmmds1.Parameters.AddWithValue("@Name", lvitem.SubItems(1).Text)
                cmmds1.Parameters.AddWithValue("@Password", lvitem.SubItems(2).Text)
                cmmds1.Parameters.AddWithValue("@Usertype", lvitem.SubItems(5).Text)
                conn1.Open()
                cmmds1.ExecuteNonQuery()
                conn1.Close()

            Next
            MsgBox("Users are added successfully", MsgBoxStyle.Information)
            ListView1.Items.Clear()
            AdminMainForms.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub txt_uname1_TextChanged(sender As Object, e As EventArgs) Handles txt_uname1.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = txt_uname1.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txt_uname1.Text))

        Catch ex As Exception

        End Try
        If txt_uname1.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminMainForms.Show()
        Me.Hide()
        txt_uname1.Clear()
        txt_contact.Clear()
        txt_name.Clear()
        txt_pword1.Clear()
        PictureBox1.Image = Nothing
    End Sub
End Class