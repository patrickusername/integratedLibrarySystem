Imports MySql.Data.MySqlClient
Public Class AddStudent
    Private Sub Add_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_pword1.Text = "password"

        ListView1.Columns.Add("Username", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 120, HorizontalAlignment.Left)
        ListView1.Columns.Add("ContactNo", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("GradeSec", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Teacher", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Password", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("ImagePath", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Usertype", 80, HorizontalAlignment.Left)

        cmb_studgs.DataSource = Nothing
        cmb_studgs.Text = ""

        cmb_studtea.DataSource = Nothing
        cmb_studtea.Text = ""

        Me.WindowState = FormWindowState.Maximized

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        Try
            Dim str As String = "SELECT GradeSec FROM tbl_student GROUP BY GradeSec"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_studgs.DataSource = dt
                cmb_studgs.DisplayMember = "GradeSec"
                cmb_studgs.ValueMember = ""

                cmb_studgs.SelectedIndex = -1
                cmb_studgs.Refresh()
            End If

            Dim str1 As String = "SELECT Teacher FROM tbl_student GROUP BY Teacher"
            Dim da1 As New MySqlDataAdapter(str1, conn)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                cmb_studtea.DataSource = dt1
                cmb_studtea.DisplayMember = "Teacher"
                cmb_studtea.ValueMember = ""

                cmb_studtea.SelectedIndex = -1
                cmb_studtea.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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

        ElseIf cmb_studgs.Text = "" Then
            MsgBox("Please Select Grade and Section", MsgBoxStyle.Critical)
            cmb_studgs.Focus()

        ElseIf cmb_studtea.Text = "" Then
            MsgBox("Please Select Teacher", MsgBoxStyle.Critical)
            cmb_studtea.Focus()

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
                    Using con As MySqlConnection = New MySqlConnection("server=localhost;uid=root;database=db_system")
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
                            newitem.SubItems.Add(txt_contact.Text)
                            newitem.SubItems.Add(cmb_studgs.Text)
                            newitem.SubItems.Add(cmb_studtea.Text)
                            newitem.SubItems.Add(txt_pword1.Text)
                            newitem.SubItems.Add(pathstring)
                            newitem.SubItems.Add("Student")

                            ListView1.Items.Add(newitem)

                        End Using
                    End Using

                    txt_uname1.Clear()
                    txt_name.Clear()
                    txt_contact.Clear()
                    cmb_studgs.ResetText()
                    cmb_studtea.ResetText()
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
                Dim conn As New MySqlConnection("server=localhost; uid=root;database=db_system")
                Dim cmmds As New MySqlCommand("Insert Into tbl_student (Username,Name,ContactNo,GradeSec,Teacher,Password,ImagePath) VALUES (@Username,@Name,@ContactNo,@GradeSec,@Teacher,@Password,@ImagePath)", conn)
                cmmds.Parameters.AddWithValue("@Username", lvitem.SubItems(0).Text)
                cmmds.Parameters.AddWithValue("@Name", lvitem.SubItems(1).Text)
                cmmds.Parameters.AddWithValue("@ContactNo", lvitem.SubItems(2).Text)
                cmmds.Parameters.AddWithValue("@GradeSec", lvitem.SubItems(3).Text)
                cmmds.Parameters.AddWithValue("@Teacher", lvitem.SubItems(4).Text)
                cmmds.Parameters.AddWithValue("@Password", lvitem.SubItems(5).Text)
                cmmds.Parameters.AddWithValue("@ImagePath", lvitem.SubItems(6).Text)

                conn.Open()
                cmmds.ExecuteNonQuery()
                conn.Close()

                Dim conn1 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                Dim cmmds1 As New MySqlCommand("Insert Into tbl_users (Username,Name,Password,Usertype) VALUES (@Username,@Name,@Password,@Usertype)", conn1)
                cmmds1.Parameters.AddWithValue("@Username", lvitem.SubItems(0).Text)
                cmmds1.Parameters.AddWithValue("@Name", lvitem.SubItems(1).Text)
                cmmds1.Parameters.AddWithValue("@Password", lvitem.SubItems(5).Text)
                cmmds1.Parameters.AddWithValue("@Usertype", lvitem.SubItems(7).Text)
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

    Private Sub txt_uname1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_uname1.TextChanged
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
        cmb_studgs.SelectedIndex = -1
        cmb_studtea.SelectedIndex = -1
        PictureBox1.Image = Nothing
    End Sub
End Class