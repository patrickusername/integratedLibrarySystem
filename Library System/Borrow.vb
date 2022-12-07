Imports MySql.Data.MySqlClient
Public Class Borrow
    Public conn As New MySqlConnection("server=localhost;uid=root;database=db_system")
    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListView1.Columns.Add("Material", 80, HorizontalAlignment.Left) '0
        ListView1.Columns.Add("MaterialNumber", 80, HorizontalAlignment.Left) '1
        ListView1.Columns.Add("MaterialName", 80, HorizontalAlignment.Left) '2
        ListView1.Columns.Add("BookNumber", 80, HorizontalAlignment.Left) '3
        ListView1.Columns.Add("ISBN", 80, HorizontalAlignment.Left) '4
        ListView1.Columns.Add("Address", 80, HorizontalAlignment.Left) '5 
        ListView1.Columns.Add("Copyright", 80, HorizontalAlignment.Left) '6
        ListView1.Columns.Add("Title", 80, HorizontalAlignment.Left) '7
        ListView1.Columns.Add("Edition", 60, HorizontalAlignment.Left) '8
        ListView1.Columns.Add("AuthorLastName", 80, HorizontalAlignment.Left) '9
        ListView1.Columns.Add("AuthorFirstName", 80, HorizontalAlignment.Left) '10 
        ListView1.Columns.Add("AuthorMiddleName", 80, HorizontalAlignment.Left) '11
        ListView1.Columns.Add("YearofPublication", 80, HorizontalAlignment.Left) '12
        ListView1.Columns.Add("Publisher", 80, HorizontalAlignment.Left) '13
        ListView1.Columns.Add("Classification", 80, HorizontalAlignment.Left) '14
        ListView1.Columns.Add("Category", 80, HorizontalAlignment.Left) '15
        ListView1.Columns.Add("BorrowedDate", 80, HorizontalAlignment.Left) '16 
        ListView1.Columns.Add("DatetoReturn", 80, HorizontalAlignment.Left) '17
        ListView1.Columns.Add("Conditions", 80, HorizontalAlignment.Left) '18
        ListView1.Columns.Add("Usertype", 80, HorizontalAlignment.Left) '19
        ListView1.Columns.Add("Username", 80, HorizontalAlignment.Left) '20
        ListView1.Columns.Add("Name", 80, HorizontalAlignment.Left) '21
        ListView1.Columns.Add("ContactNumber", 80, HorizontalAlignment.Left) '22
        ListView1.Columns.Add("GradeandSection", 80, HorizontalAlignment.Left) '23
        ListView1.Columns.Add("Teacher", 80, HorizontalAlignment.Left) '24



        'If cmb_categooory.Text = "" Then
        '    dtp_datetorett.Text = ""
        '    dtp_datetorett.CustomFormat = " "
        'End If

        txt_titlee.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory.SelectedIndex = -1
        txt_year.Clear()
        txt_pubcom.Clear()
        txt_isbnn.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
        txt_year.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        'dtp_datetorett.Text = ""
        'dtp_datetorett.CustomFormat = " "
        ''''''''dtp_dateborr.CustomFormat = "dd/MM/yyyy - hh:mm tt"
        'dtp_datetorett.MinDate = DateTime.Now
        txt_duedate.Clear()
        Label3.Enabled = True
        Label9.Enabled = True
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_gradesecc.Enabled = True
        txt_teacher.Enabled = True
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_edition.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_num.ReadOnly = False
        txt_gradesecc.ReadOnly = False
        txt_teacher.ReadOnly = False
        txt_duedate.ReadOnly = False
        'Me.dtp_dateborr.Enabled = False
        txt_gradesecc.Clear()
        txt_teacher.Clear()
        rb_faculty.Checked = False
        rb_student.Checked = False
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        rb_student.Enabled = True
        rb_faculty.Enabled = True

        'txt_isbnn.Focus()
        'dtp_dateborr.Format = DateTimePickerFormat.Custom
        ' txt_idno.Focus()

        'dtp_datetorett.Format = DateTimePickerFormat.Custom
        'dtp_datetorett.CustomFormat = " "

        'cmb_categooory.DataSource = Nothing
        'cmb_categooory.Text = ""

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_categooory.DataSource = dt
                cmb_categooory.DisplayMember = "category"
                cmb_categooory.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_categooory.SelectedIndex = -1
                cmb_categooory.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        conn.Open()
        Try
            Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_ddc"
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

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Try
        '    Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
        '    Dim da As New MySqlDataAdapter(str, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    If dt.Rows.Count > 0 Then
        '        cmb_categooory.DataSource = dt
        '        cmb_categooory.DisplayMember = "category"
        '        cmb_categooory.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        cmb_categooory.SelectedIndex = -1
        '        cmb_categooory.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        'conn.Open()
        'Try
        '    Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_book GROUP BY DeweyDecimalClassification"
        '    Dim da1 As New MySqlDataAdapter(str1, conn)
        '    Dim dt1 As New DataTable
        '    da1.Fill(dt1)
        '    If dt1.Rows.Count > 0 Then
        '        cmb_ddc.DataSource = dt1
        '        cmb_ddc.DisplayMember = "DeweyDecimalClassification"
        '        cmb_ddc.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        cmb_ddc.SelectedIndex = -1
        '        cmb_ddc.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        AdminMainForms.Show()
        Me.Hide()
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_year.Clear()
        txt_titlee.Clear()
        txt_edition.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory.SelectedIndex = -1
        txt_year.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_pubcom.Clear()
        txt_isbnn.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
        txt_year.Clear()
        txt_gradesecc.Clear()
        txt_teacher.Clear()
        txt_bookno.Clear()
        txt_matno.Clear()
        txt_matname.Clear()
        rb_faculty.Checked = False
        rb_student.Checked = False
        rb_student.Enabled = True
        rb_faculty.Enabled = True
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_edition.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_num.ReadOnly = False
        txt_gradesecc.ReadOnly = False
        txt_teacher.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_duedate.ReadOnly = False
        txt_duedate.Clear()
        ListView1.Items.Clear()
        'Me.dtp_dateborr.Enabled = False
    End Sub

    'Private Sub txt_isbnn_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    txt_isbnn.Focus()
    '    If e.KeyChar = ChrW(Keys.Back) Then
    '    Else
    '        If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
    '        Else
    '            e.Handled = True
    '        End If
    '    End If

    '    If e.KeyChar = ChrW(13) Then

    '        conn.Open()
    '        Dim qstr As String = "SELECT * FROM tbl_books WHERE isbn = '" & txt_isbnn.Text & "'"
    '        Dim cmd As New MySqlCommand(qstr, conn)
    '        Dim data As MySqlDataReader = cmd.ExecuteReader

    '        If data.Read Then
    '            If data(1) = txt_isbnn.Text Then
    '                txt_isbnn.Text = data(1)
    '                txt_isbnn.ReadOnly = True
    '                txt_titlee.Text = data(2)
    '                txt_titlee.ReadOnly = True
    '                txt_authorr.Text = data(3)
    '                txt_authorr.ReadOnly = True
    '                cmb_categooory.Text = data(4)
    '                txt_year.Text = data(5)
    '                txt_year.ReadOnly = True
    '            End If
    '            data.Close()
    '        End If
    '    End If
    '    conn.Close()

    '    txt_pubcom.Focus()
    'End Sub
    'Private Sub txt_isbnn_TextChanged(sender As Object, e As EventArgs)
    '    txt_isbnn.Focus()
    'End Sub

    Private Sub rb_faculty_CheckedChanged(sender As Object, e As EventArgs) Handles rb_faculty.CheckedChanged
        txt_idno.Focus()
        Label3.Enabled = False
        txt_gradesecc.Enabled = False
        Label9.Enabled = False
        txt_teacher.Enabled = False
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
        txt_gradesecc.Clear()
        txt_teacher.Clear()
    End Sub
    Private Sub dtp_dateborr_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dateborr.ValueChanged
        dtp_dateborr.Value = DateTime.Now
        dtp_dateborr.CustomFormat = "MM/dd/yyyy - hh:mm tt"

    End Sub
    Private Sub txt_bookno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bookno.KeyPress
        If e.KeyChar = ChrW(13) Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_book WHERE booknumber = '" & txt_bookno.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader
            If data.Read Then
                If data(0) = txt_bookno.Text Then
                    txt_bookno.Text = data(0)
                    txt_bookno.ReadOnly = True
                    txt_isbnn.Text = data(1)
                    txt_isbnn.ReadOnly = True
                    txt_titlee.Text = data(2)
                    txt_titlee.ReadOnly = True
                    txt_edition.Text = data(3)
                    txt_edition.ReadOnly = True
                    txt_auth_ln.Text = data(4)
                    txt_auth_ln.ReadOnly = True
                    txt_auth_fn.Text = data(5)
                    txt_auth_fn.ReadOnly = True
                    txt_auth_mn.Text = data(6)
                    txt_auth_mn.ReadOnly = True
                    cmb_ddc.Text = data(7)
                    cmb_categooory.Text = data(8)
                    txt_year.Text = data(9)
                    txt_year.ReadOnly = True
                    txt_pubcom.Text = data(10)
                    txt_pubcom.ReadOnly = True
                    txt_address.Text = data(11)
                    txt_address.ReadOnly = True
                    txt_copyright.Text = data(12)
                    txt_copyright.ReadOnly = True
                End If
                If data(14) = "Good" Then
                    rb_good.Checked = True
                ElseIf data(14) = "Damaged" Then
                    rb_damaged.Checked = True
                End If

                If data(13) = "Borrowed" Then
                    MsgBox("Already Borrowed", MsgBoxStyle.Critical)
                    rb_printed.Checked = False
                    rb_nonprinted.Checked = False
                    txt_matno.Clear()
                    txt_matname.Clear()
                    txt_bookno.Clear()
                    txt_isbnn.Clear()
                    txt_address.Clear()
                    txt_copyright.Clear()
                    txt_titlee.Clear()
                    txt_auth_ln.Clear()
                    txt_auth_fn.Clear()
                    txt_auth_mn.Clear()
                    txt_year.Clear()
                    txt_pubcom.Clear()
                    cmb_ddc.SelectedIndex = -1
                    cmb_categooory.SelectedIndex = -1
                    'rb_faculty.Checked = False
                    'rb_student.Checked = False
                    'txt_idno.Clear()
                    'txt_namee.Clear()
                    'txt_num.Clear()
                    'txt_gradesecc.Clear()
                    'txt_teacher.Clear()
                    txt_duedate.Clear()
                    txt_duedate.Enabled = True
                    'Label3.Enabled = True
                    'Label9.Enabled = True
                    'txt_gradesecc.Enabled = True
                    'txt_teacher.Enabled = True
                    txt_matname.Enabled = True
                    txt_matno.Enabled = True
                    txt_isbnn.Enabled = True
                    txt_titlee.Enabled = True
                    txt_edition.Enabled = True
                    txt_bookno.Enabled = True
                    txt_auth_ln.Enabled = True
                    txt_auth_fn.Enabled = True
                    txt_auth_mn.Enabled = True
                    txt_year.Enabled = True
                    txt_address.Enabled = True
                    txt_copyright.Enabled = True
                    txt_pubcom.Enabled = True
                    cmb_ddc.Enabled = True
                    cmb_categooory.Enabled = True
                    txt_isbnn.ReadOnly = False
                    txt_titlee.ReadOnly = False
                    txt_edition.ReadOnly = False
                    txt_auth_ln.ReadOnly = False
                    txt_auth_fn.ReadOnly = False
                    txt_auth_mn.ReadOnly = False
                    txt_year.ReadOnly = False
                    'txt_idno.ReadOnly = False
                    'txt_namee.ReadOnly = False
                    'txt_num.ReadOnly = False
                    'txt_gradesecc.ReadOnly = False
                    'txt_teacher.ReadOnly = False
                    txt_address.ReadOnly = False
                    txt_copyright.ReadOnly = False
                    txt_bookno.ReadOnly = False
                    txt_pubcom.ReadOnly = False
                    'rb_nonprinted.Checked = False
                    'rb_printed.Checked = False
                    txt_matname.ReadOnly = False
                    txt_matno.ReadOnly = False
                    txt_duedate.ReadOnly = False
                End If

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim qstr1 As String = "SELECT * FROM tbl_category WHERE category = '" & cmb_categooory.Text & "'"
                Dim cmd1 As New MySqlCommand(qstr1, conn)
                Dim data1 As MySqlDataReader = cmd1.ExecuteReader
                If data1.Read Then
                    If data1(1) = cmb_categooory.Text Then
                        cmb_categooory.Text = data1(1)
                        txt_duedate.Text = Now.AddDays(data1(0)).ToString("MM/dd/yyyy - hh:mm tt")
                    End If
                End If
                conn.Close()
            End If
            data.Close()
        End If
    End Sub

    Private Sub cmb_categooory_SelectedIndexChanged(sender As Object, e As EventArgs)


        'If cmb_categooory.Text = "Textbook" Then
        '    txt_duedate.Text = Now.AddDays(3).ToString("MM/dd/yyyy - hh:mm tt")
        '    dtp_datetorett.Value = DateTime.Now.AddDays(3)
        'ElseIf cmb_categooory.Text = "" Then
        '    txt_duedate.Text = ""
        'Else
        '    txt_duedate.Text = Now.AddDays(1).ToString("MM/dd/yyyy - hh:mm tt")
        '    dtp_datetorett.Value = DateTime.Now.AddDays(1)
        'End If



        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim qstr111 As String = "SELECT * FROM tbl_category WHERE category = '" & cmb_categooory.Text & "'"
        'Dim cmd111 As New MySqlCommand(qstr111, conn)
        'Dim data1 As MySqlDataReader = cmd111.ExecuteReader

        'If data1.Read Then

        '    If data1(0) = cmb_categooory.Text Then
        '        cmb_categooory.Text = data1(0)
        '        txt_duedate.Text = Now.AddDays(data1(1)).ToString("MM/dd/yyyy - hh:mm tt")
        '    End If
        'End If
        'conn.Close()
    End Sub

    Private Sub rb_printed_CheckedChanged(sender As Object, e As EventArgs) Handles rb_printed.CheckedChanged
        txt_bookno.Focus()
        'rb_nonprinted.Checked = False
        txt_matno.Clear()
        txt_matname.Clear()
        txt_duedate.Clear()
        txt_bookno.Enabled = True
        txt_isbnn.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_titlee.Enabled = True
        txt_edition.Enabled = True
        txt_auth_ln.Enabled = True
        txt_auth_fn.Enabled = True
        txt_auth_mn.Enabled = True
        txt_year.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_matno.Enabled = False
        txt_matname.Enabled = False
    End Sub

    Private Sub rb_nonprinted_CheckedChanged(sender As Object, e As EventArgs) Handles rb_nonprinted.CheckedChanged
        txt_bookno.Clear()
        txt_isbnn.Clear()
        txt_titlee.Clear()
        txt_edition.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory.SelectedIndex = -1
        txt_year.Clear()
        txt_pubcom.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_duedate.Clear()
        'rb_printed.Checked = False

        txt_matno.Focus()
        txt_bookno.Enabled = False
        txt_isbnn.Enabled = False
        txt_address.Enabled = False
        txt_copyright.Enabled = False
        txt_titlee.Enabled = False
        txt_edition.Enabled = False
        txt_auth_ln.Enabled = False
        txt_auth_fn.Enabled = False
        txt_auth_mn.Enabled = False
        txt_year.Enabled = False
        txt_pubcom.Enabled = False
        cmb_ddc.Enabled = False
        cmb_categooory.Enabled = False
        txt_matno.Enabled = True
        txt_matname.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListView1.Items.Count = 0 Then
            MsgBox("Borrow list is empty", MsgBoxStyle.Information)

        Else
            If MsgBox("Are you sure you want To borrow these materials?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                For Each lvitem As ListViewItem In ListView1.Items

                    If lvitem.SubItems(0).Text = "Printed" Then
                        Dim conn As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds As New MySqlCommand("Insert Into tbl_borrowedbooks (BookNumber,ISBN,Title,Edition,AuthorLastname,AuthorFirstname,AuthorMiddlename,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,Conditions,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@BookNumber,@ISBN,@Title,@Edition,@AuthorLastName,@AuthorFirstName,@AuthorMiddleName,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@Conditions,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn)
                        cmmds.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                        cmmds.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                        cmmds.Parameters.AddWithValue("@Edition", lvitem.SubItems(8).Text)
                        cmmds.Parameters.AddWithValue("@AuthorLastName", lvitem.SubItems(9).Text)
                        cmmds.Parameters.AddWithValue("@AuthorFirstName", lvitem.SubItems(10).Text)
                        cmmds.Parameters.AddWithValue("@AuthorMiddleName", lvitem.SubItems(11).Text)
                        cmmds.Parameters.AddWithValue("@Classification", lvitem.SubItems(14).Text)
                        cmmds.Parameters.AddWithValue("@Category", lvitem.SubItems(15).Text)
                        cmmds.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(12).Text)
                        cmmds.Parameters.AddWithValue("@Publisher", lvitem.SubItems(13).Text)
                        cmmds.Parameters.AddWithValue("@Address", lvitem.SubItems(5).Text)
                        cmmds.Parameters.AddWithValue("@Copyright", lvitem.SubItems(6).Text)
                        cmmds.Parameters.AddWithValue("@Conditions", lvitem.SubItems(18).Text)
                        cmmds.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                        cmmds.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                        cmmds.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                        cmmds.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                        cmmds.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                        conn.Open()
                        cmmds.ExecuteNonQuery()
                        conn.Close()

                        Dim conn2 As New MySqlConnection("server= localhost; uid=root;database=db_system")
                        Dim cmmds2 As New MySqlCommand("Insert Into tbl_borrowreturnbooks (BookNumber,ISBN,Title,Edition,AuthorLastname,AuthorFirstname,AuthorMiddlename,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,Conditions,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@BookNumber,@ISBN,@Title,@Edition,@AuthorLastName,@AuthorFirstname,@AuthorMiddleName,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@Conditions,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn2)
                        cmmds2.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds2.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                        cmmds2.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                        cmmds2.Parameters.AddWithValue("@Edition", lvitem.SubItems(8).Text)
                        cmmds2.Parameters.AddWithValue("@AuthorLastName", lvitem.SubItems(9).Text)
                        cmmds2.Parameters.AddWithValue("@AuthorFirstName", lvitem.SubItems(10).Text)
                        cmmds2.Parameters.AddWithValue("@AuthorMiddleName", lvitem.SubItems(11).Text)
                        cmmds2.Parameters.AddWithValue("@Classification", lvitem.SubItems(14).Text)
                        cmmds2.Parameters.AddWithValue("@Category", lvitem.SubItems(15).Text)
                        cmmds2.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(12).Text)
                        cmmds2.Parameters.AddWithValue("@Publisher", lvitem.SubItems(13).Text)
                        cmmds2.Parameters.AddWithValue("@Address", lvitem.SubItems(5).Text)
                        cmmds2.Parameters.AddWithValue("@Copyright", lvitem.SubItems(6).Text)
                        cmmds2.Parameters.AddWithValue("@Conditions", lvitem.SubItems(18).Text)
                        cmmds2.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                        cmmds2.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                        cmmds2.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                        cmmds2.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                        cmmds2.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                        conn2.Open()
                        cmmds2.ExecuteNonQuery()
                        conn2.Close()

                        If lvitem.SubItems(19).Text = "Faculty" Then
                            Dim conn1 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                            Dim cmmds1 As New MySqlCommand("Insert Into tbl_facultyborrowers (Username,Name,ContactNo,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@BookNumber,@Material,@Title,@BorrowedDate,@DatetoReturn)", conn1)
                            cmmds1.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                            cmmds1.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                            cmmds1.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                            cmmds1.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                            cmmds1.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                            cmmds1.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                            cmmds1.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                            cmmds1.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                            conn1.Open()
                            cmmds1.ExecuteNonQuery()
                            conn1.Close()

                        ElseIf lvitem.SubItems(19).Text = "Student" Then
                            Dim conn5 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                            Dim cmmds5 As New MySqlCommand("Insert Into tbl_studentborrowers (Username,Name,ContactNo,GradeSec,Teacher,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@GradeandSection,@Teacher,@BookNumber,@Material,@Title,@BorrowedDate,@DatetoReturn)", conn5)
                            cmmds5.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                            cmmds5.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                            cmmds5.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                            cmmds5.Parameters.AddWithValue("@GradeandSection", lvitem.SubItems(23).Text)
                            cmmds5.Parameters.AddWithValue("@Teacher", lvitem.SubItems(24).Text)
                            cmmds5.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                            cmmds5.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                            cmmds5.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                            cmmds5.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                            cmmds5.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                            conn5.Open()
                            cmmds5.ExecuteNonQuery()
                            conn5.Close()
                        End If

                        Dim conn8 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds8 As New MySqlCommand("Update tbl_book Set status = 'Borrowed' where BookNumber= '" & lvitem.SubItems(3).Text & "' ", conn8)
                        conn8.Open()
                        cmmds8.ExecuteNonQuery()
                        conn8.Close()


                    ElseIf lvitem.SubItems(0).Text = "Non-Printed" Then
                        Dim conn3 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds3 As New MySqlCommand("Insert Into tbl_borrowednonprinted (MaterialNumber,MaterialName,Conditions,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@MaterialNumber,@MaterialName,@Conditions,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn3)
                        cmmds3.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds3.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds3.Parameters.AddWithValue("@Conditions", lvitem.SubItems(18).Text)
                        cmmds3.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                        cmmds3.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                        cmmds3.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                        cmmds3.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                        cmmds3.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                        conn3.Open()
                        cmmds3.ExecuteNonQuery()
                        conn3.Close()

                        Dim conn4 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds4 As New MySqlCommand("Insert Into tbl_borrowreturnnonprinted (MaterialNumber,MaterialName,Conditions,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@MaterialNumber,@MaterialName,@Conditions,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn4)
                        cmmds4.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds4.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds4.Parameters.AddWithValue("@Conditions", lvitem.SubItems(18).Text)
                        cmmds4.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                        cmmds4.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                        cmmds4.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                        cmmds4.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                        cmmds4.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                        conn4.Open()
                        cmmds4.ExecuteNonQuery()
                        conn4.Close()

                        If lvitem.SubItems(19).Text = "Faculty" Then
                            Dim conn9 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                            Dim cmmds9 As New MySqlCommand("Insert Into tbl_facultyborrowers (Username,Name,ContactNo,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@MaterialNumber,@Material,@MaterialName,@BorrowedDate,@DatetoReturn)", conn9)
                            cmmds9.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                            cmmds9.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                            cmmds9.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                            cmmds9.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                            cmmds9.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                            cmmds9.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                            cmmds9.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                            cmmds9.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                            conn9.Open()
                            cmmds9.ExecuteNonQuery()
                            conn9.Close()

                        ElseIf lvitem.SubItems(19).Text = "Student" Then
                            Dim conn10 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                            Dim cmmds10 As New MySqlCommand("Insert Into tbl_studentborrowers (Username,Name,ContactNo,GradeSec,Teacher,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@GradeandSection,@Teacher,@MaterialNumber,@Material,@MaterialName,@BorrowedDate,@DatetoReturn)", conn10)
                            cmmds10.Parameters.AddWithValue("@Username", lvitem.SubItems(20).Text)
                            cmmds10.Parameters.AddWithValue("@Name", lvitem.SubItems(21).Text)
                            cmmds10.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(22).Text)
                            cmmds10.Parameters.AddWithValue("@GradeandSection", lvitem.SubItems(23).Text)
                            cmmds10.Parameters.AddWithValue("@Teacher", lvitem.SubItems(24).Text)
                            cmmds10.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                            cmmds10.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                            cmmds10.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                            cmmds10.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(16).Text)
                            cmmds10.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(17).Text)
                            conn10.Open()
                            cmmds10.ExecuteNonQuery()
                            conn10.Close()
                        End If

                        Dim conn8 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds8 As New MySqlCommand("Update tbl_nonprinted set status = 'Borrowed' where MaterialNumber= '" & lvitem.SubItems(1).Text & "' ", conn8)
                        conn8.Open()
                        cmmds8.ExecuteNonQuery()
                        conn8.Close()
                    End If

                Next
                MsgBox("Borrowed successfully", MsgBoxStyle.Information)

                ListView1.Items.Clear()
                AdminMainForms.Show()
                Me.Hide()

            End If
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        rb_printed.Checked = False
        rb_nonprinted.Checked = False
        rb_good.Checked = False
        rb_damaged.Checked = False
        txt_matno.Clear()
        txt_matname.Clear()
        txt_bookno.Clear()
        txt_isbnn.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_titlee.Clear()
        txt_edition.Clear()
        txt_auth_ln.Clear()
        txt_auth_fn.Clear()
        txt_auth_mn.Clear()
        txt_year.Clear()
        txt_pubcom.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory.SelectedIndex = -1
        'rb_faculty.Checked = False
        'rb_student.Checked = False
        'txt_idno.Clear()
        'txt_namee.Clear()
        'txt_num.Clear()
        'txt_gradesecc.Clear()
        'txt_teacher.Clear()
        'txt_duedate.Clear()

        'Label3.Enabled = True
        'Label9.Enabled = True
        'txt_gradesecc.Enabled = True
        'txt_teacher.Enabled = True
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn.Enabled = True
        txt_titlee.Enabled = True
        txt_edition.Enabled = True
        txt_bookno.Enabled = True
        txt_auth_ln.Enabled = True
        txt_auth_fn.Enabled = True
        txt_auth_mn.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_edition.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        'txt_idno.ReadOnly = False
        'txt_namee.ReadOnly = False
        'txt_num.ReadOnly = False
        'txt_gradesecc.ReadOnly = False
        'txt_teacher.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_pubcom.ReadOnly = False
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_matname.ReadOnly = False
        txt_matno.ReadOnly = False
    End Sub

    Private Sub rb_student_CheckedChanged(sender As Object, e As EventArgs) Handles rb_student.CheckedChanged
        txt_idno.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_num.ReadOnly = False
        'Label7.Enabled = True
        'txt_idno.Enabled = True
        'Label1.Enabled = True
        'txt_namee.Enabled = True
        'Label2.Enabled = True
        'txt_num.Text = True
        Label3.Enabled = True
        txt_gradesecc.Enabled = True
        Label9.Enabled = True
        txt_teacher.Enabled = True
        txt_idno.Focus()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
    End Sub

    Private Sub txt_matno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matno.KeyPress
        If e.KeyChar = ChrW(13) Then

            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_nonprinted WHERE materialnumber = '" & txt_matno.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then


                If data(0) = txt_matno.Text Then
                    txt_matno.Text = data(0)
                    txt_matno.ReadOnly = True
                    txt_matname.Text = data(1)
                    txt_matname.ReadOnly = True
                    'dtp_datetorett.Value = DateTime.Now.AddDays(1)
                    txt_duedate.Text = Now.AddDays(1).ToString("MM/dd/yyyy - hh:mm tt")
                End If
                If data(2) = "Borrowed" Then
                    MsgBox("Already Borrowed", MsgBoxStyle.Critical)
                    rb_printed.Checked = False
                    rb_nonprinted.Checked = False
                    txt_matno.Clear()
                    txt_matname.Clear()
                    txt_bookno.Clear()
                    txt_isbnn.Clear()
                    txt_address.Clear()
                    txt_copyright.Clear()
                    txt_titlee.Clear()
                    txt_edition.Clear()
                    txt_auth_ln.Clear()
                    txt_auth_fn.Clear()
                    txt_auth_mn.Clear()
                    txt_year.Clear()
                    txt_pubcom.Clear()
                    cmb_ddc.SelectedIndex = -1
                    cmb_categooory.SelectedIndex = -1
                    'rb_faculty.Checked = False
                    'rb_student.Checked = False
                    'txt_idno.Clear()
                    'txt_namee.Clear()
                    'txt_num.Clear()
                    'txt_gradesecc.Clear()
                    'txt_teacher.Clear()
                    txt_duedate.Clear()
                    'Label3.Enabled = True
                    'Label9.Enabled = True
                    'txt_gradesecc.Enabled = True
                    'txt_teacher.Enabled = True
                    txt_matname.Enabled = True
                    txt_matno.Enabled = True
                    txt_isbnn.Enabled = True
                    txt_titlee.Enabled = True
                    txt_edition.Enabled = True
                    txt_bookno.Enabled = True
                    txt_auth_ln.Enabled = True
                    txt_auth_fn.Enabled = True
                    txt_auth_mn.Enabled = True
                    txt_year.Enabled = True
                    txt_address.Enabled = True
                    txt_copyright.Enabled = True
                    txt_pubcom.Enabled = True
                    cmb_ddc.Enabled = True
                    cmb_categooory.Enabled = True
                    txt_isbnn.ReadOnly = False
                    txt_titlee.ReadOnly = False
                    txt_edition.ReadOnly = False
                    txt_auth_ln.ReadOnly = False
                    txt_auth_fn.ReadOnly = False
                    txt_auth_mn.ReadOnly = False
                    txt_year.ReadOnly = False
                    'txt_idno.ReadOnly = False
                    'txt_namee.ReadOnly = False
                    'txt_num.ReadOnly = False
                    'txt_gradesecc.ReadOnly = False
                    'txt_teacher.ReadOnly = False
                    txt_address.ReadOnly = False
                    txt_copyright.ReadOnly = False
                    txt_bookno.ReadOnly = False
                    txt_pubcom.ReadOnly = False
                    'rb_nonprinted.Checked = False
                    'rb_printed.Checked = False
                    txt_matname.ReadOnly = False
                    txt_matno.ReadOnly = False

                End If
            End If
            data.Close()
        End If

        conn.Close()
    End Sub
    Private Sub txt_matno_Click(sender As Object, e As EventArgs) Handles txt_matno.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_matname_Click(sender As Object, e As EventArgs) Handles txt_matname.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_bookno_CausesValidationChanged(sender As Object, e As EventArgs) Handles txt_bookno.CausesValidationChanged
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_isbnn_Click(sender As Object, e As EventArgs) Handles txt_isbnn.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    'Private Sub txt_authorr_Click(sender As Object, e As EventArgs) Handles txt_author.Click
    '    If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
    '        MsgBox("Please Select Material", MsgBoxStyle.Critical)
    '    End If
    'End Sub
    'Private Sub txt_classnum_Click(sender As Object, e As EventArgs) Handles txt_classnum.Click
    '    If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
    '        MsgBox("Please Select Material", MsgBoxStyle.Critical)
    '    End If
    'End Sub
    Private Sub cmb_ddc_Click(sender As Object, e As EventArgs) Handles cmb_ddc.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cmb_categooory_Click(sender As Object, e As EventArgs) Handles cmb_categooory.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    'Private Sub dtp_datetorett_Click(sender As Object, e As EventArgs) Handles dtp_datetorett.Click
    '    If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
    '        MsgBox("Please Select Material", MsgBoxStyle.Critical)
    '    End If
    'End Sub
    Private Sub txt_idno_Click(sender As Object, e As EventArgs) Handles txt_idno.Click
        If rb_faculty.Checked = False And rb_student.Checked = False Then
            MsgBox("Please Select User Level", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_namee_Click(sender As Object, e As EventArgs) Handles txt_namee.Click
        If rb_faculty.Checked = False And rb_student.Checked = False Then
            MsgBox("Please Select User Level", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_num_Click(sender As Object, e As EventArgs) Handles txt_num.Click
        If rb_faculty.Checked = False And rb_student.Checked = False Then
            MsgBox("Please Select User Level", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_gradesecc_Click(sender As Object, e As EventArgs) Handles txt_gradesecc.Click
        If rb_faculty.Checked = False And rb_student.Checked = False Then
            MsgBox("Please Select User Level", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_teacher_Click(sender As Object, e As EventArgs) Handles txt_teacher.Click
        If rb_faculty.Checked = False And rb_student.Checked = False Then
            MsgBox("Please Select User Level", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_bookno_Click(sender As Object, e As EventArgs) Handles txt_bookno.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_titlee_Click(sender As Object, e As EventArgs) Handles txt_titlee.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_idno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idno.KeyPress

        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(13) Then

            'txt_idno.Text = e.KeyChar

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            'If rb_student.Checked = False And rb_printed.Checked = False Then
            '    txt_idno.Clear()
            '    MsgBox("Please select User", MsgBoxStyle.Critical)

            If rb_student.Checked = True Then

                Dim qstr As String = "Select * FROM tbl_student WHERE Username = '" & txt_idno.Text & "'"
                Dim cmd As New MySqlCommand(qstr, conn)
                Dim data As MySqlDataReader = cmd.ExecuteReader

                If data.Read Then
                    If data(0) = txt_idno.Text Then

                        txt_idno.Text = data(0)
                        txt_idno.ReadOnly = True
                        txt_namee.Text = data(1)
                        txt_namee.ReadOnly = True
                        txt_num.Text = data(2)
                        txt_num.ReadOnly = True
                        txt_gradesecc.Text = data(3)
                        txt_gradesecc.ReadOnly = True
                        txt_teacher.Text = data(4)
                        txt_teacher.ReadOnly = True
                    End If
                    data.Close()
                    Dim qstr3 As String = "Select count(tbl_borrowreturnbooks.Username) + count(tbl_borrowreturnnonprinted.Username) FROM tbl_borrowreturnbooks, tbl_borrowreturnnonprinted Where tbl_borrowreturnbooks.Username = '" & txt_idno.Text & "' and tbl_borrowreturnnonprinted.Username = '" & txt_idno.Text & "' "
                    Dim cmd3 As New MySqlCommand(qstr3, conn)
                    Dim dat3 As Integer = cmd3.ExecuteScalar
                    Dim data3 As MySqlDataReader = cmd3.ExecuteReader
                    If data3.Read Then
                        If dat3 >= 3 Then
                            'If data3(0) >= 3 Then
                            MsgBox("The borrower had already borrowed 3 materials", MsgBoxStyle.Critical)
                            txt_idno.Clear()
                            rb_student.Checked = False
                            txt_num.Clear()
                            txt_gradesecc.Clear()
                            txt_teacher.Clear()
                            txt_namee.Clear()

                        End If
                    End If
                End If

            ElseIf rb_faculty.Checked = True Then

                Dim qstr1 As String = "SELECT * FROM tbl_faculty WHERE Username = '" & txt_idno.Text & "'"
                Dim cmd1 As New MySqlCommand(qstr1, conn)
                Dim data1 As MySqlDataReader = cmd1.ExecuteReader

                If data1.Read Then

                    If data1(0) = txt_idno.Text Then
                        txt_idno.Text = data1(0)
                        txt_idno.ReadOnly = True
                        txt_namee.Text = data1(1)
                        txt_namee.ReadOnly = True
                        txt_num.Text = data1(2)
                        txt_num.ReadOnly = True
                    End If
                End If
                data1.Close()
                Dim qstr4 As String = "Select count(tbl_borrowreturnbooks.Username) + count(tbl_borrowreturnnonprinted.Username) FROM tbl_borrowreturnbooks, tbl_borrowreturnnonprinted Where tbl_borrowreturnbooks.Username = '" & txt_idno.Text & "' and tbl_borrowreturnnonprinted.Username = '" & txt_idno.Text & "' "
                Dim cmd4 As New MySqlCommand(qstr4, conn)
                Dim dat4 As Integer = cmd4.ExecuteScalar
                Dim data4 As MySqlDataReader = cmd4.ExecuteReader

                If data4.Read Then
                    If dat4 >= 3 Then
                        'If data4(0) >= 3 Then
                        MsgBox("The borrower had already borrowed 3 materials", MsgBoxStyle.Critical)
                        txt_idno.Clear()
                        rb_faculty.Checked = False
                        txt_num.Clear()
                        txt_namee.Clear()
                    End If
                End If

            ElseIf rb_student.Checked = False And rb_faculty.Checked = False Then
                MsgBox("Please select User Level", MsgBoxStyle.Critical)
                txt_idno.Clear()

            End If
        End If
        conn.Close()
    End Sub
    Private Sub txt_address_Click(sender As Object, e As EventArgs) Handles txt_address.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_copyright_Click(sender As Object, e As EventArgs) Handles txt_copyright.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_year_Click(sender As Object, e As EventArgs) Handles txt_year.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_pubcom_Click(sender As Object, e As EventArgs) Handles txt_pubcom.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
        '    MsgBox("Please Select Material", MsgBoxStyle.Critical)
        'End If

        If rb_nonprinted.Checked Then
            'txt_matno.Focus()

            If txt_matno.Text = "" Then
                MsgBox("Please Enter Material Number", MsgBoxStyle.Critical)
                txt_matno.Focus()
            ElseIf txt_matname.Text = "" Then
                MsgBox("Please Material Name", MsgBoxStyle.Critical)
                txt_matname.Focus()
            ElseIf txt_duedate.Text = "" Then
                MsgBox("Please Due Date", MsgBoxStyle.Critical)
                txt_duedate.Focus()
            ElseIf txt_idno.Text = "" Then
                MsgBox("Please Enter No.", MsgBoxStyle.Critical)
                txt_idno.Focus()
            ElseIf txt_namee.Text = "" Then
                MsgBox("Please Enter Name", MsgBoxStyle.Critical)
                txt_namee.Focus()
            ElseIf txt_num.Text = "(+63)    -    -" Then
                MsgBox("Please Enter Contact Number", MsgBoxStyle.Critical)
                txt_num.Focus()
            ElseIf MsgBox("Are you sure you want to add this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'dtp_datetorett.CustomFormat = ""
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                'VALIDATE NONPRINTED
                Dim tx As String = "SELECT MaterialNumber, MaterialName from tbl_nonprinted where MaterialNumber= '" & txt_matno.Text & "' AND MaterialName= '" & txt_matname.Text & "'"
                Dim com As New MySqlCommand(tx, conn)
                Dim da As MySqlDataReader = com.ExecuteReader

                If da.Read Then
                    da.Close()

                    If rb_faculty.Checked Then
                        'VALIDATE FACULTY BORROWER INFO
                        Dim tx2 As String = "Select Username,Name,contactno from tbl_faculty where Username='" & txt_idno.Text & "' AND Name= '" & txt_namee.Text & "' AND contactno= '" & txt_num.Text & "'"
                        Dim com2 As New MySqlCommand(tx2, conn)
                        Dim da2 As MySqlDataReader = com2.ExecuteReader

                        If da2.Read Then
                            da2.Close()

                            Dim newitem As New ListViewItem(rb_nonprinted.Text)
                            newitem.SubItems.Add(txt_matno.Text)
                            newitem.SubItems.Add(txt_matname.Text)
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(txt_duedate.Text)
                            If rb_good.Checked = True Then
                                newitem.SubItems.Add(rb_good.Text)
                            ElseIf rb_damaged.Checked = True Then
                                newitem.SubItems.Add(rb_damaged.Text)
                            Else
                                newitem.SubItems.Add("")
                            End If
                            newitem.SubItems.Add(rb_faculty.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.Name = txt_matno.Text
                            If ListView1.Items.Item(txt_matno.Text) Is Nothing Then
                                ListView1.Items.Add(newitem)

                                'Label3.Enabled = True
                                'Label9.Enabled = True
                                txt_duedate.Enabled = True
                                'txt_gradesecc.Enabled = True
                                'txt_teacher.Enabled = True
                                txt_matname.Enabled = True
                                txt_matno.Enabled = True
                                txt_isbnn.Enabled = True
                                txt_titlee.Enabled = True
                                txt_edition.Enabled = True
                                txt_bookno.Enabled = True
                                txt_auth_ln.Enabled = True
                                txt_auth_fn.Enabled = True
                                txt_auth_mn.Enabled = True
                                txt_year.Enabled = True
                                txt_address.Enabled = True
                                txt_copyright.Enabled = True
                                txt_pubcom.Enabled = True
                                cmb_ddc.Enabled = True
                                cmb_categooory.Enabled = True
                                txt_isbnn.ReadOnly = False
                                txt_titlee.ReadOnly = False
                                txt_edition.ReadOnly = False
                                txt_auth_ln.ReadOnly = False
                                txt_auth_fn.ReadOnly = False
                                txt_auth_mn.ReadOnly = False
                                txt_year.ReadOnly = False
                                'txt_idno.ReadOnly = False
                                'txt_namee.ReadOnly = False
                                'txt_num.ReadOnly = False
                                'txt_gradesecc.ReadOnly = False
                                'txt_teacher.ReadOnly = False
                                txt_address.ReadOnly = False
                                txt_copyright.ReadOnly = False
                                txt_bookno.ReadOnly = False
                                txt_pubcom.ReadOnly = False
                                rb_nonprinted.Checked = False
                                rb_printed.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matname.ReadOnly = False
                                txt_matno.ReadOnly = False
                            Else
                                MsgBox("Material exists in the list", MsgBoxStyle.Critical)

                                rb_printed.Checked = False
                                rb_nonprinted.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matno.Clear()
                                txt_matname.Clear()
                                txt_bookno.Clear()
                                txt_isbnn.Clear()
                                txt_address.Clear()
                                txt_copyright.Clear()
                                txt_titlee.Clear()
                                txt_edition.Clear()
                                txt_auth_ln.Clear()
                                txt_auth_fn.Clear()
                                txt_auth_mn.Clear()
                                txt_year.Clear()
                                txt_pubcom.Clear()
                                cmb_ddc.SelectedIndex = -1
                                cmb_categooory.SelectedIndex = -1
                                'rb_faculty.Checked = False
                                'rb_student.Checked = False
                                'txt_idno.Clear()
                                'txt_namee.Clear()
                                'txt_num.Clear()
                                'txt_gradesecc.Clear()
                                'txt_teacher.Clear()
                                'txt_duedate.Clear()
                                'txt_duedate.Clear()
                            End If
                        Else
                            MsgBox("Faculty not found!", MsgBoxStyle.Critical)
                        End If


                    ElseIf rb_student.Checked Then
                        'VALIDATE STUDENT
                        Dim tx2 As String = "SELECT Username,Name,contactno,gradesec,teacher from tbl_student where Username='" & txt_idno.Text & "' AND Name= '" & txt_namee.Text & "' AND contactno= '" & txt_num.Text & "' AND gradesec= '" & txt_gradesecc.Text & "' AND teacher= '" & txt_teacher.Text & "'"
                        Dim com2 As New MySqlCommand(tx2, conn)
                        Dim da2 As MySqlDataReader = com2.ExecuteReader

                        If da2.Read Then
                            da2.Close()

                            Dim newitem As New ListViewItem(rb_nonprinted.Text)
                            newitem.SubItems.Add(txt_matno.Text)
                            newitem.SubItems.Add(txt_matname.Text)
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            ''newitem.SubItems.Add(dtp_datetorett.Text)
                            newitem.SubItems.Add(txt_duedate.Text)
                            If rb_good.Checked = True Then
                                newitem.SubItems.Add(rb_good.Text)
                            ElseIf rb_damaged.Checked = True Then
                                newitem.SubItems.Add(rb_damaged.Text)
                            Else
                                newitem.SubItems.Add("")
                            End If
                            newitem.SubItems.Add(rb_student.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.SubItems.Add(txt_gradesecc.Text)
                            newitem.SubItems.Add(txt_teacher.Text)
                            newitem.Name = txt_matno.Text
                            If ListView1.Items.Item(txt_matno.Text) Is Nothing Then
                                ListView1.Items.Add(newitem)

                                'Label3.Enabled = True
                                'Label9.Enabled = True
                                'txt_gradesecc.Enabled = True
                                'txt_teacher.Enabled = True
                                txt_matname.Enabled = True
                                txt_matno.Enabled = True
                                txt_isbnn.Enabled = True
                                txt_titlee.Enabled = True
                                txt_edition.Enabled = True
                                txt_bookno.Enabled = True
                                txt_auth_ln.Enabled = True
                                txt_auth_fn.Enabled = True
                                txt_auth_mn.Enabled = True
                                txt_year.Enabled = True
                                txt_address.Enabled = True
                                txt_copyright.Enabled = True
                                txt_pubcom.Enabled = True
                                cmb_ddc.Enabled = True
                                cmb_categooory.Enabled = True
                                txt_isbnn.ReadOnly = False
                                txt_titlee.ReadOnly = False
                                txt_edition.ReadOnly = False
                                txt_auth_ln.ReadOnly = False
                                txt_auth_fn.ReadOnly = False
                                txt_auth_mn.ReadOnly = False
                                txt_year.ReadOnly = False
                                'txt_idno.ReadOnly = False
                                'txt_namee.ReadOnly = False
                                'txt_num.ReadOnly = False
                                'txt_gradesecc.ReadOnly = False
                                'txt_teacher.ReadOnly = False
                                txt_address.ReadOnly = False
                                txt_copyright.ReadOnly = False
                                txt_bookno.ReadOnly = False
                                txt_pubcom.ReadOnly = False
                                rb_nonprinted.Checked = False
                                rb_printed.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matname.ReadOnly = False
                                txt_matno.ReadOnly = False
                            Else
                                MsgBox("Material exists in the list", MsgBoxStyle.Critical)

                                rb_printed.Checked = False
                                rb_nonprinted.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matno.Clear()
                                txt_matname.Clear()
                                txt_bookno.Clear()
                                txt_isbnn.Clear()
                                txt_address.Clear()
                                txt_copyright.Clear()
                                txt_titlee.Clear()
                                txt_edition.Clear()
                                txt_auth_ln.Clear()
                                txt_auth_fn.Clear()
                                txt_auth_mn.Clear()
                                txt_year.Clear()
                                txt_pubcom.Clear()
                                cmb_ddc.SelectedIndex = -1
                                cmb_categooory.SelectedIndex = -1
                                'rb_faculty.Checked = False
                                'rb_student.Checked = False
                                'txt_idno.Clear()
                                'txt_namee.Clear()
                                'txt_num.Clear()
                                'txt_gradesecc.Clear()
                                'txt_teacher.Clear()
                                'dtp_datetorett.CustomFormat = " "
                            End If

                        Else
                            MsgBox("Student not found!", MsgBoxStyle.Critical)
                        End If
                    End If
                Else
                    MsgBox("Book not found!", MsgBoxStyle.Critical)

                    'Label3.Enabled = True
                    'Label9.Enabled = True
                    'txt_gradesecc.Enabled = True
                    'txt_teacher.Enabled = True
                    txt_matname.Enabled = True
                    txt_matno.Enabled = True
                    txt_isbnn.Enabled = True
                    txt_titlee.Enabled = True
                    txt_edition.Enabled = True
                    txt_bookno.Enabled = True
                    txt_auth_ln.Enabled = True
                    txt_auth_fn.Enabled = True
                    txt_auth_mn.Enabled = True
                    txt_year.Enabled = True
                    txt_address.Enabled = True
                    txt_copyright.Enabled = True
                    txt_pubcom.Enabled = True
                    cmb_ddc.Enabled = True
                    cmb_categooory.Enabled = True
                    txt_isbnn.ReadOnly = False
                    txt_titlee.ReadOnly = False
                    txt_edition.ReadOnly = False
                    txt_auth_ln.ReadOnly = False
                    txt_auth_fn.ReadOnly = False
                    txt_auth_mn.ReadOnly = False
                    txt_year.ReadOnly = False
                    'txt_idno.ReadOnly = False
                    'txt_namee.ReadOnly = False
                    'txt_num.ReadOnly = False
                    'txt_gradesecc.ReadOnly = False
                    'txt_teacher.ReadOnly = False
                    txt_address.ReadOnly = False
                    txt_copyright.ReadOnly = False
                    txt_bookno.ReadOnly = False
                    txt_pubcom.ReadOnly = False
                    rb_nonprinted.Checked = False
                    rb_printed.Checked = False
                    rb_good.Checked = False
                    rb_damaged.Checked = False
                    txt_matname.ReadOnly = False
                    txt_matno.ReadOnly = False
                End If
            End If

        ElseIf rb_printed.Checked Then
            ' txt_bookno.Focus()

            If txt_bookno.Text = "" Then
                MsgBox("Please Enter BookNumber", MsgBoxStyle.Critical)
                txt_bookno.Focus()
            ElseIf txt_isbnn.Text = "" Then
                MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
                txt_isbnn.Focus()
            ElseIf txt_isbnn.MaskCompleted = False Then
                MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
                txt_isbnn.Focus()
            ElseIf txt_titlee.Text = "" Then
                MsgBox("Please Enter Title", MsgBoxStyle.Critical)
                txt_titlee.Focus()
                'ElseIf txt_authorr.Text = "" Then
                '    MsgBox("Please Enter Author", MsgBoxStyle.Critical)
                '    txt_authorr.Focus()
            ElseIf cmb_ddc.Text = "" Then
                MsgBox("Please Enter Dewey Decimal Classification", MsgBoxStyle.Critical)
                cmb_ddc.Focus()
            ElseIf cmb_categooory.Text = "" Then
                MsgBox("Please Enter Category", MsgBoxStyle.Critical)
                cmb_categooory.Focus()
            ElseIf txt_year.Text = "" Then
                MsgBox("Please Enter Year", MsgBoxStyle.Critical)
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
            ElseIf txt_duedate.Text = "" Then
                MsgBox("Please Enter Due Date", MsgBoxStyle.Critical)
                txt_duedate.Focus()
            ElseIf rb_faculty.Checked = False And rb_student.Checked = False Then
                MsgBox("Please Select User Level", MsgBoxStyle.Critical)
            ElseIf txt_idno.Text = "" Then
                MsgBox("Please Enter No.", MsgBoxStyle.Critical)
                txt_idno.Focus()
            ElseIf txt_namee.Text = "" Then
                MsgBox("Please Enter Name", MsgBoxStyle.Critical)
                txt_namee.Focus()
            ElseIf txt_num.Text = "(+63)    -    -" Then
                MsgBox("Please Enter Contact Number", MsgBoxStyle.Critical)
                txt_num.Focus()
            ElseIf MsgBox("Are you sure you want to add this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                conn.Open()
                'VALIDATE BOOK
                Dim tx As String = "SELECT booknumber,isbn,title,authorlastname,authorfirstname,authormiddlename,deweydecimalclassification,category,yearofpublication,address,copyright,publisher from tbl_book where booknumber= '" & txt_bookno.Text & "' AND isbn= '" & txt_isbnn.Text & "' AND title= '" & txt_titlee.Text & "' AND authorlastname= '" & txt_auth_ln.Text & "' AND AuthorFirstName= '" & txt_auth_fn.Text & "' AND AuthorMiddleName= '" & txt_auth_mn.Text & "'  And DeweyDecimalClassification = '" & cmb_ddc.Text & "' AND category= '" & cmb_categooory.Text & "' AND YearofPublication= '" & txt_year.Text & "' AND address= '" & txt_address.Text & "' AND copyright= '" & txt_copyright.Text & "'AND publisher= '" & txt_pubcom.Text & "'"
                Dim com As New MySqlCommand(tx, conn)
                Dim da As MySqlDataReader = com.ExecuteReader

                If da.Read Then
                    da.Close()
                    If rb_faculty.Checked Then
                        'VALIDATE FACULTY BORROWER INFO
                        Dim tx2 As String = "SELECT Username,Name,contactno from tbl_faculty where Username='" & txt_idno.Text & "' AND Name= '" & txt_namee.Text & "' AND contactno= '" & txt_num.Text & "'"
                        Dim com2 As New MySqlCommand(tx2, conn)
                        Dim da2 As MySqlDataReader = com2.ExecuteReader

                        If da2.Read Then
                            da2.Close()

                            Dim newitem As New ListViewItem(rb_printed.Text)
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add(txt_bookno.Text)
                            newitem.SubItems.Add(txt_isbnn.Text)
                            newitem.SubItems.Add(txt_address.Text)
                            newitem.SubItems.Add(txt_copyright.Text)
                            newitem.SubItems.Add(txt_titlee.Text)
                            newitem.SubItems.Add(txt_edition.Text)
                            newitem.SubItems.Add(txt_auth_ln.Text)
                            newitem.SubItems.Add(txt_auth_fn.Text)
                            newitem.SubItems.Add(txt_auth_mn.Text)
                            newitem.SubItems.Add(txt_year.Text)
                            newitem.SubItems.Add(txt_pubcom.Text)
                            newitem.SubItems.Add(cmb_ddc.Text)
                            newitem.SubItems.Add(cmb_categooory.Text)
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(txt_duedate.Text)
                            If rb_good.Checked = True Then
                                newitem.SubItems.Add(rb_good.Text)
                            ElseIf rb_damaged.Checked = True Then
                                newitem.SubItems.Add(rb_damaged.Text)
                            Else
                                newitem.SubItems.Add("")
                            End If
                            newitem.SubItems.Add(rb_faculty.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.Name = txt_bookno.Text
                            If ListView1.Items.Item(txt_bookno.Text) Is Nothing Then
                                ListView1.Items.Add(newitem)

                                'Label3.Enabled = True
                                'Label9.Enabled = True
                                ''txt_gradesecc.Enabled = True
                                'txt_teacher.Enabled = True
                                txt_matname.Enabled = True
                                txt_matno.Enabled = True
                                txt_isbnn.Enabled = True
                                txt_titlee.Enabled = True
                                txt_edition.Enabled = True
                                txt_bookno.Enabled = True
                                txt_auth_ln.Enabled = True
                                txt_auth_fn.Enabled = True
                                txt_auth_mn.Enabled = True
                                txt_year.Enabled = True
                                txt_address.Enabled = True
                                txt_copyright.Enabled = True
                                txt_pubcom.Enabled = True
                                cmb_ddc.Enabled = True
                                cmb_categooory.Enabled = True
                                txt_isbnn.ReadOnly = False
                                txt_titlee.ReadOnly = False
                                txt_edition.ReadOnly = False
                                txt_auth_ln.ReadOnly = False
                                txt_auth_fn.ReadOnly = False
                                txt_auth_mn.ReadOnly = False
                                txt_year.ReadOnly = False
                                'txt_idno.ReadOnly = False
                                'txt_namee.ReadOnly = False
                                'txt_num.ReadOnly = False
                                'txt_gradesecc.ReadOnly = False
                                'txt_teacher.ReadOnly = False
                                txt_address.ReadOnly = False
                                txt_copyright.ReadOnly = False
                                txt_bookno.ReadOnly = False
                                txt_pubcom.ReadOnly = False
                                rb_nonprinted.Checked = False
                                rb_printed.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matname.ReadOnly = False
                                txt_matno.ReadOnly = False
                            Else
                                MsgBox("Material exists in the list", MsgBoxStyle.Critical)

                                rb_printed.Checked = False
                                rb_nonprinted.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matno.Clear()
                                txt_matname.Clear()
                                txt_bookno.Clear()
                                txt_isbnn.Clear()
                                txt_address.Clear()
                                txt_copyright.Clear()
                                txt_titlee.Clear()
                                txt_edition.Clear()
                                txt_auth_ln.Clear()
                                txt_auth_fn.Clear()
                                txt_auth_mn.Clear()
                                txt_year.Clear()
                                txt_pubcom.Clear()
                                cmb_ddc.SelectedIndex = -1
                                cmb_categooory.SelectedIndex = -1
                                'rb_faculty.Checked = False
                                'rb_student.Checked = False
                                'txt_idno.Clear()
                                'txt_namee.Clear()
                                'txt_num.Clear()
                                'txt_gradesecc.Clear()
                                'txt_teacher.Clear()
                                'txt_duedate.Clear()
                                'txt_gradesecc.Enabled = True
                                'txt_teacher.Enabled = True
                            End If

                        Else
                            MsgBox("Faculty not found!", MsgBoxStyle.Critical)
                        End If


                    ElseIf rb_student.Checked Then
                        'VALIDATE STUDENT
                        Dim tx2 As String = "SELECT Username,Name,contactno,gradesec,teacher from tbl_student where Username='" & txt_idno.Text & "' AND Name= '" & txt_namee.Text & "' AND contactno= '" & txt_num.Text & "' AND gradesec= '" & txt_gradesecc.Text & "' AND teacher= '" & txt_teacher.Text & "'"
                        Dim com2 As New MySqlCommand(tx2, conn)
                        Dim da2 As MySqlDataReader = com2.ExecuteReader

                        If da2.Read Then
                            da2.Close()

                            Dim newitem As New ListViewItem(rb_printed.Text)
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add("")
                            newitem.SubItems.Add(txt_bookno.Text)
                            newitem.SubItems.Add(txt_isbnn.Text)
                            newitem.SubItems.Add(txt_address.Text)
                            newitem.SubItems.Add(txt_copyright.Text)
                            newitem.SubItems.Add(txt_titlee.Text)
                            newitem.SubItems.Add(txt_edition.Text)
                            newitem.SubItems.Add(txt_auth_ln.Text)
                            newitem.SubItems.Add(txt_auth_fn.Text)
                            newitem.SubItems.Add(txt_auth_mn.Text)
                            newitem.SubItems.Add(txt_year.Text)
                            newitem.SubItems.Add(txt_pubcom.Text)
                            newitem.SubItems.Add(cmb_ddc.Text)
                            newitem.SubItems.Add(cmb_categooory.Text)
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(txt_duedate.Text)
                            If rb_good.Checked = True Then
                                newitem.SubItems.Add(rb_good.Text)
                            ElseIf rb_damaged.Checked = True Then
                                newitem.SubItems.Add(rb_damaged.Text)
                            Else
                                newitem.SubItems.Add("")
                            End If
                            newitem.SubItems.Add(rb_student.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.SubItems.Add(txt_gradesecc.Text)
                            newitem.SubItems.Add(txt_teacher.Text)
                            newitem.Name = txt_bookno.Text
                            If ListView1.Items.Item(txt_bookno.Text) Is Nothing Then
                                ListView1.Items.Add(newitem)

                                'Label3.Enabled = True
                                'Label9.Enabled = True
                                'txt_gradesecc.Enabled = True
                                'txt_teacher.Enabled = True
                                txt_matname.Enabled = True
                                txt_matno.Enabled = True
                                txt_isbnn.Enabled = True
                                txt_titlee.Enabled = True
                                txt_edition.Enabled = True
                                txt_bookno.Enabled = True
                                txt_auth_ln.Enabled = True
                                txt_auth_fn.Enabled = True
                                txt_auth_mn.Enabled = True
                                txt_year.Enabled = True
                                txt_address.Enabled = True
                                txt_copyright.Enabled = True
                                txt_pubcom.Enabled = True
                                cmb_ddc.Enabled = True
                                cmb_categooory.Enabled = True
                                txt_isbnn.ReadOnly = False
                                txt_titlee.ReadOnly = False
                                txt_edition.ReadOnly = False
                                txt_auth_ln.ReadOnly = False
                                txt_auth_fn.ReadOnly = False
                                txt_auth_mn.ReadOnly = False
                                txt_year.ReadOnly = False
                                'txt_idno.ReadOnly = False
                                'txt_namee.ReadOnly = False
                                'txt_num.ReadOnly = False
                                'txt_gradesecc.ReadOnly = False
                                'txt_teacher.ReadOnly = False
                                txt_address.ReadOnly = False
                                txt_copyright.ReadOnly = False
                                txt_bookno.ReadOnly = False
                                txt_pubcom.ReadOnly = False
                                rb_nonprinted.Checked = False
                                rb_printed.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matname.ReadOnly = False
                                txt_matno.ReadOnly = False
                            Else
                                MsgBox("Material exists in the list", MsgBoxStyle.Critical)

                                rb_printed.Checked = False
                                rb_nonprinted.Checked = False
                                rb_good.Checked = False
                                rb_damaged.Checked = False
                                txt_matno.Clear()
                                txt_matname.Clear()
                                txt_bookno.Clear()
                                txt_isbnn.Clear()
                                txt_address.Clear()
                                txt_copyright.Clear()
                                txt_titlee.Clear()
                                txt_edition.Clear()
                                txt_auth_ln.Clear()
                                txt_auth_fn.Clear()
                                txt_auth_mn.Clear()
                                txt_year.Clear()
                                txt_pubcom.Clear()
                                cmb_ddc.SelectedIndex = -1
                                cmb_categooory.SelectedIndex = -1
                                'dtp_datetorett.Text = " "
                                'rb_faculty.Checked = False
                                'rb_student.Checked = False
                                'txt_idno.Clear()
                                'txt_namee.Clear()
                                'txt_num.Clear()
                                'txt_gradesecc.Clear()
                                'txt_teacher.Clear()
                                txt_duedate.Clear()
                            End If

                        Else
                            MsgBox("Student not found!", MsgBoxStyle.Critical)
                        End If
                    End If

                Else
                    MsgBox("Book not found!", MsgBoxStyle.Critical)
                End If
            End If

        ElseIf rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
        'Label3.Enabled = True
        'Label9.Enabled = True
        'txt_gradesecc.Enabled = True
        'txt_teacher.Enabled = True
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn.Enabled = True
        txt_titlee.Enabled = True
        txt_edition.Enabled = True
        txt_bookno.Enabled = True
        txt_auth_ln.Enabled = True
        txt_auth_fn.Enabled = True
        txt_auth_mn.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_edition.ReadOnly = False
        txt_auth_ln.ReadOnly = False
        txt_auth_fn.ReadOnly = False
        txt_auth_mn.ReadOnly = False
        txt_year.ReadOnly = False
        'txt_idno.ReadOnly = False
        'txt_namee.ReadOnly = False
        'txt_num.ReadOnly = False
        'txt_gradesecc.ReadOnly = False
        'txt_teacher.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_pubcom.ReadOnly = False
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        rb_good.Checked = False
        rb_damaged.Checked = False
        txt_matname.ReadOnly = False
        txt_matno.ReadOnly = False
    End Sub
    Private Sub txt_copyright_TextChanged(sender As Object, e As EventArgs) Handles txt_copyright.TextChanged
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_copyright.Text > currentYear Then
            MsgBox("Invalid Year", MsgBoxStyle.Information)
            txt_copyright.Clear()
            txt_copyright.Focus()
        End If
    End Sub
    Private Sub txt_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
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
    Private Sub txt_edition_Click(sender As Object, e As EventArgs) Handles txt_edition.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_auth_ln_Click(sender As Object, e As EventArgs) Handles txt_auth_ln.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_auth_fn_Click(sender As Object, e As EventArgs) Handles txt_auth_fn.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_auth_mn_Click(sender As Object, e As EventArgs) Handles txt_auth_mn.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_clear2_Click(sender As Object, e As EventArgs) Handles btn_clear2.Click
        rb_faculty.Checked = False
        rb_student.Checked = False
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
        txt_gradesecc.Clear()
        txt_teacher.Clear()
        txt_duedate.Clear()
        txt_idno.Enabled = True
        txt_namee.Enabled = True
        txt_num.Enabled = True
        txt_gradesecc.Enabled = True
        txt_teacher.Enabled = True
        txt_idno.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_num.ReadOnly = False
        txt_gradesecc.ReadOnly = False
        txt_teacher.ReadOnly = False
        Label3.Enabled = True
        Label9.Enabled = True

    End Sub

    Private Sub txt_duedate_TextChanged(sender As Object, e As EventArgs) Handles txt_duedate.TextChanged
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_bookno_TextChanged(sender As Object, e As EventArgs) Handles txt_bookno.TextChanged

    End Sub

    Private Sub txt_matno_TextChanged(sender As Object, e As EventArgs) Handles txt_matno.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rb_good_CheckedChanged(sender As Object, e As EventArgs) Handles rb_good.CheckedChanged

    End Sub

    Private Sub txt_idno_TextChanged(sender As Object, e As EventArgs) Handles txt_idno.TextChanged
        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim qstr3 As String = "Select * FROM tbl_borrowreturnbooks WHERE username = '" & txt_idno.Text & "'"
        'Dim cmd3 As New MySqlCommand(qstr3, conn)
        'Dim data3 As MySqlDataReader = cmd3.ExecuteReader
        'If data3.Read Then
        '    If data3(16) > 3 Then
        '        MsgBox("The borrower had already borrowed 3 materials", MsgBoxStyle.Critical)
        '        txt_idno.Clear()
        '        rb_student.Checked = False
        '    End If
        'End If

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim qstr4 As String = "Select * FROM tbl_borrowreturnbooks WHERE Username = '" & txt_idno.Text & "'"
        'Dim cmd4 As New MySqlCommand(qstr4, conn)
        'Dim data4 As MySqlDataReader = cmd4.ExecuteReader

        'If data4.Read Then
        '    If data4(16) > 3 Then
        '        MsgBox("The borrower had already borrowed 3 materials", MsgBoxStyle.Critical)
        '        txt_idno.Clear()
        '        rb_faculty.Checked = False
        '    End If
        'End If

    End Sub

End Class