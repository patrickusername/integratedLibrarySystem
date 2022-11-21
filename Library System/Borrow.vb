Imports MySql.Data.MySqlClient
Public Class Borrow
    Public conn As New MySqlConnection(connString)
    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        ListView1.Columns.Add("Material", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("MaterialNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("MaterialName", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("BookNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("ISBN", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Address", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Copyright", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Title", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Author", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("YearofPublication", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Publisher", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Classification", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Category", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("BorrowedDate", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("DatetoReturn", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Usertype", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Username", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("ContactNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("GradeandSection", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Teacher", 80, HorizontalAlignment.Left)

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        If cmb_categooory.Text = "" Then
            dtp_datetorett.Text = ""
            dtp_datetorett.CustomFormat = " "
        End If

        txt_titlee.Clear()
        txt_authorr.Clear()
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
        dtp_datetorett.Text = ""
        dtp_datetorett.CustomFormat = " "
        dtp_datetorett.MinDate = Date.Today
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
        txt_authorr.ReadOnly = False
        txt_year.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_num.ReadOnly = False
        txt_gradesecc.ReadOnly = False
        txt_teacher.ReadOnly = False
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
        dtp_dateborr.Format = DateTimePickerFormat.Custom
        dtp_datetorett.Format = DateTimePickerFormat.Custom
        dtp_datetorett.CustomFormat = " "

        cmb_categooory.DataSource = Nothing
        cmb_categooory.Text = ""

        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
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

        'Dim con As New MySqlConnection(connString)
        'con.Open()
        'Dim cmd As New MySqlCommand("select * from tbl_category", con)
        'Dim da As New MySqlDataAdapter
        'da.SelectCommand = cmd
        'Dim dt As New DataTable
        ''dt.Clear()
        'da.Fill(dt)

        'cmb_categooory.DataSource = dt
        'cmb_categooory.DisplayMember = "category_name"
        'cmb_categooory.ValueMember = "category_id"
        'cmb_categooory.SelectedIndex = -1

        'Dim theDate As Date
        'theDate = Format(Now())
        'txt_dateborr.Text = theDate.ToShortDateString

        'Dim currentDate As Date
        '' Get the current date from the textbox
        'currentDate = Convert.ToDateTime(txt_dateborr.Text)
        '' Add 3 days
        'currentDate = currentDate.AddDays(3)
        '' Write the date back to the textbox
        'txt_datetorett.Text = currentDate.ToShortDateString

        'Dim overnight As Date = Date.Today.AddDays(1)
        'overnight = Convert.ToDateTime(cmb_datereturned.SelectedItem = "Overnight")

        'Dim overnight1 As Date = Date.Today.AddDays(1)
        'overnight = Convert.ToDateTime(cmb_datereturned.SelectedItem = "Overnight")
        'cmb_datereturned.SelectedItem = "Overnight"
        'cmb_datereturned.Items.Add("Overnight")
        'cmb_datereturned.Items.Add("Before Vacation")
        'cmb_datereturned.Items.Add("3 days")
        'cmb_categooory.Items.Add(AddCategory.txt_addcategory.Visible)
        'cmb_categooory.Items.Add("Atlas")
        'cmb_categooory.Items.Add("Encyclopedia")
        'cmb_categooory.Items.Add("Textbook")
        'cmb_categooory.Items.Add("General References")
        'cmb_categooory.Items.Add("Other Book")

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_year.Clear()
        txt_titlee.Clear()
        txt_authorr.Clear()
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
        rb_faculty.Checked = False
        rb_student.Checked = False
        rb_student.Enabled = True
        rb_faculty.Enabled = True
        'txt_isbnn.Focus()
        AdminMainForms.Show()
        Me.Hide()
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_authorr.ReadOnly = False
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

    Private Sub rb_faculty_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb_faculty.CheckedChanged
        txt_idno.Focus()
        Label3.Enabled = False
        txt_gradesecc.Enabled = False
        Label9.Enabled = False
        txt_teacher.Enabled = False

    End Sub
    Private Sub dtp_dateborr_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dateborr.ValueChanged
        dtp_dateborr.Value = DateTime.Now
        dtp_dateborr.CustomFormat = "dd/MM/yyyy - hh:mm tt"
    End Sub
    Private Sub dtp_datetorett_ValueChanged(sender As Object, e As EventArgs) Handles dtp_datetorett.ValueChanged
        'dtp_datetorett.Text = ""
        'dtp_datetorett.CustomFormat = " "
        dtp_datetorett.CustomFormat = "dd/MM/yyyy - hh:mm tt"

        'If cmb_categooory.Text = "Textbook" Then
        '    dtp_datetorett.Value = DateTime.Today.AddDays(3)
        'End If
    End Sub

    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_num_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_bookno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bookno.KeyPress
        If e.KeyChar = ChrW(13) Then

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
                    txt_authorr.Text = data(3)
                    txt_authorr.ReadOnly = True
                    cmb_ddc.Text = data(4)
                    cmb_categooory.Text = data(5)
                    txt_year.Text = data(6)
                    txt_year.ReadOnly = True
                    txt_pubcom.Text = data(7)
                    txt_pubcom.ReadOnly = True
                    txt_address.Text = data(8)
                    txt_address.ReadOnly = True
                    txt_copyright.Text = data(9)
                    txt_copyright.ReadOnly = True

                    'If data(9) = "Borrowed" Then
                    '    MsgBox("Book is already Borrowed", MsgBoxStyle.Critical)
                    'txt_titlee.Clear()
                    'txt_authorr.Clear()
                    'cmb_ddc.SelectedIndex = -1
                    'cmb_categooory.SelectedIndex = -1
                    'txt_pubcom.Clear()
                    'txt_isbnn.Clear()
                    'dtp_datetorett.CustomFormat = " "
                    ''txt_idno.Clear()
                    ''txt_namee.Clear()
                    ''txt_num.Clear()
                    'txt_classnum.Clear()
                    'txt_year.Clear()
                    ''txt_gradesecc.Clear()
                    ''txt_teacher.Clear()
                    'txt_bookno.Clear()
                    'txt_bookno.Focus()

                End If
            End If
            data.Close()
        End If

        conn.Close()
    End Sub

    Private Sub cmb_categooory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_categooory.SelectedIndexChanged

        'dtp_datetorett.Text = ""
        'dtp_datetorett.CustomFormat = " "

        If cmb_categooory.Text = "Textbook" Then
            dtp_datetorett.Value = DateTime.Today.AddDays(3)
        ElseIf cmb_categooory.Text = "" Then
            dtp_datetorett.Text = ""
            dtp_datetorett.CustomFormat = " "
        Else
            dtp_datetorett.Value = DateTime.Today.AddDays(1)
        End If
    End Sub

    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs)
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_year.Text > currentYear Then
            MsgBox("Invalid Year", MsgBoxStyle.Information)
            txt_year.Clear()
            txt_year.Focus()
        End If
    End Sub

    Private Sub rb_printed_CheckedChanged(sender As Object, e As EventArgs) Handles rb_printed.CheckedChanged
        txt_bookno.Focus()
        txt_bookno.Enabled = True
        txt_isbnn.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_titlee.Enabled = True
        txt_authorr.Enabled = True
        txt_year.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_matno.Enabled = False
        txt_matname.Enabled = False
    End Sub

    Private Sub rb_nonprinted_CheckedChanged(sender As Object, e As EventArgs) Handles rb_nonprinted.CheckedChanged
        txt_matno.Focus()
        txt_bookno.Enabled = False
        txt_isbnn.Enabled = False
        txt_address.Enabled = False
        txt_copyright.Enabled = False
        txt_titlee.Enabled = False
        txt_authorr.Enabled = False
        txt_year.Enabled = False
        txt_pubcom.Enabled = False
        cmb_ddc.Enabled = False
        cmb_categooory.Enabled = False
        txt_matno.Enabled = True
        txt_matname.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MsgBox("Are you sure you want to borrow these materials?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            For Each lvitem As ListViewItem In ListView1.Items

                If lvitem.SubItems(0).Text = "Printed" Then
                    Dim conn As New MySqlConnection(connString)
                    Dim cmmds As New MySqlCommand("Insert Into tbl_borrowedbooks (BookNumber,ISBN,Title,Author,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@BookNumber,@ISBN,@Title,@Author,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn)
                    cmmds.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                    cmmds.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                    cmmds.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                    cmmds.Parameters.AddWithValue("@Author", lvitem.SubItems(8).Text)
                    cmmds.Parameters.AddWithValue("@Classification", lvitem.SubItems(11).Text)
                    cmmds.Parameters.AddWithValue("@Category", lvitem.SubItems(12).Text)
                    cmmds.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(9).Text)
                    cmmds.Parameters.AddWithValue("@Publisher", lvitem.SubItems(10).Text)
                    cmmds.Parameters.AddWithValue("@Address", lvitem.SubItems(5).Text)
                    cmmds.Parameters.AddWithValue("@Copyright", lvitem.SubItems(6).Text)
                    cmmds.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(13).Text)
                    cmmds.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(14).Text)
                    cmmds.Parameters.AddWithValue("@Username", lvitem.SubItems(16).Text)
                    cmmds.Parameters.AddWithValue("@Name", lvitem.SubItems(17).Text)
                    cmmds.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(18).Text)
                    conn.Open()
                    cmmds.ExecuteNonQuery()
                    conn.Close()

                    Dim conn2 As New MySqlConnection(connString)
                    Dim cmmds2 As New MySqlCommand("Insert Into tbl_borrowreturnbooks (BookNumber,ISBN,Title,Author,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@BookNumber,@ISBN,@Title,@Author,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn2)
                    cmmds2.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                    cmmds2.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                    cmmds2.Parameters.AddWithValue("@Title", lvitem.SubItems(7).Text)
                    cmmds2.Parameters.AddWithValue("@Author", lvitem.SubItems(8).Text)
                    cmmds2.Parameters.AddWithValue("@Classification", lvitem.SubItems(11).Text)
                    cmmds2.Parameters.AddWithValue("@Category", lvitem.SubItems(12).Text)
                    cmmds2.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(9).Text)
                    cmmds2.Parameters.AddWithValue("@Publisher", lvitem.SubItems(10).Text)
                    cmmds2.Parameters.AddWithValue("@Address", lvitem.SubItems(5).Text)
                    cmmds2.Parameters.AddWithValue("@Copyright", lvitem.SubItems(6).Text)
                    cmmds2.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(13).Text)
                    cmmds2.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(14).Text)
                    cmmds2.Parameters.AddWithValue("@Username", lvitem.SubItems(16).Text)
                    cmmds2.Parameters.AddWithValue("@Name", lvitem.SubItems(17).Text)
                    cmmds2.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(18).Text)
                    conn2.Open()
                    cmmds2.ExecuteNonQuery()
                    conn2.Close()

                    If lvitem.SubItems(14).Text = "Faculty" Then
                        Dim conn1 As New MySqlConnection(connString)
                        Dim cmmds1 As New MySqlCommand("Insert Into tbl_facultyborrowers (Username,Name,ContactNo,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@BookNumber,@Material,@Title,@BorrowedDate,@DatetoReturn)", conn1)
                        cmmds1.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                        cmmds1.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                        cmmds1.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                        cmmds1.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds1.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                        cmmds1.Parameters.AddWithValue("@Title", lvitem.SubItems(6).Text)
                        cmmds1.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                        cmmds1.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                        conn1.Open()
                        cmmds1.ExecuteNonQuery()
                        conn1.Close()

                    ElseIf lvitem.SubItems(14).Text = "Student" Then
                        Dim conn5 As New MySqlConnection(connString)
                        Dim cmmds5 As New MySqlCommand("Insert Into tbl_studentborrowers (Username,Name,ContactNo,GradeSec,Teacher,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@GradeandSection,@Teacher,@BookNumber,@Material,@Title,@BorrowedDate,@DatetoReturn)", conn5)
                        cmmds5.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                        cmmds5.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                        cmmds5.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                        cmmds5.Parameters.AddWithValue("@GradeandSection", lvitem.SubItems(18).Text)
                        cmmds5.Parameters.AddWithValue("@Teacher", lvitem.SubItems(19).Text)
                        cmmds5.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds5.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                        cmmds5.Parameters.AddWithValue("@Title", lvitem.SubItems(6).Text)
                        cmmds5.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                        cmmds5.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                        conn5.Open()
                        cmmds5.ExecuteNonQuery()
                        conn5.Close()
                    End If

                    Dim conn8 As New MySqlConnection(connString)
                    Dim cmmds8 As New MySqlCommand("Update tbl_book set status = 'Borrowed' where BookNumber= '" & lvitem.SubItems(3).Text & "' ", conn8)
                    conn8.Open()
                    cmmds8.ExecuteNonQuery()
                    conn8.Close()


                ElseIf lvitem.SubItems(0).Text = "Non-Printed" Then
                    Dim conn3 As New MySqlConnection(connString)
                    Dim cmmds3 As New MySqlCommand("Insert Into tbl_borrowednonprinted (MaterialNumber,MaterialName,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@MaterialNumber,@MaterialName,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn3)
                    cmmds3.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                    cmmds3.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                    cmmds3.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                    cmmds3.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                    cmmds3.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                    cmmds3.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                    cmmds3.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                    conn3.Open()
                    cmmds3.ExecuteNonQuery()
                    conn3.Close()

                    Dim conn4 As New MySqlConnection(connString)
                    Dim cmmds4 As New MySqlCommand("Insert Into tbl_borrowreturnnonprinted (MaterialNumber,MaterialName,DateBorrowed,DatetoReturn,Username,Name,ContactNo) VALUES (@MaterialNumber,@MaterialName,@BorrowedDate,@DatetoReturn,@Username,@Name,@ContactNumber)", conn4)
                    cmmds4.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                    cmmds4.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                    cmmds4.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                    cmmds4.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                    cmmds4.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                    cmmds4.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                    cmmds4.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                    conn4.Open()
                    cmmds4.ExecuteNonQuery()
                    conn4.Close()

                    If lvitem.SubItems(14).Text = "Faculty" Then
                        Dim conn9 As New MySqlConnection(connString)
                        Dim cmmds9 As New MySqlCommand("Insert Into tbl_facultyborrowers (Username,Name,ContactNo,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@MaterialNumber,@Material,@MaterialName,@BorrowedDate,@DatetoReturn)", conn9)
                        cmmds9.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                        cmmds9.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                        cmmds9.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                        cmmds9.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds9.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                        cmmds9.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds9.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                        cmmds9.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                        conn9.Open()
                        cmmds9.ExecuteNonQuery()
                        conn9.Close()

                    ElseIf lvitem.SubItems(14).Text = "Student" Then
                        Dim conn10 As New MySqlConnection(connString)
                        Dim cmmds10 As New MySqlCommand("Insert Into tbl_studentborrowers (Username,Name,ContactNo,GradeSec,Teacher,ItemNumber,ItemType,Title,DateBorrowed,DatetoReturn) VALUES (@Username,@Name,@ContactNumber,@GradeandSection,@Teacher,@MaterialNumber,@Material,@MaterialName,@BorrowedDate,@DatetoReturn)", conn10)
                        cmmds10.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                        cmmds10.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                        cmmds10.Parameters.AddWithValue("@ContactNumber", lvitem.SubItems(17).Text)
                        cmmds10.Parameters.AddWithValue("@GradeandSection", lvitem.SubItems(18).Text)
                        cmmds10.Parameters.AddWithValue("@Teacher", lvitem.SubItems(19).Text)
                        cmmds10.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds10.Parameters.AddWithValue("@Material", lvitem.SubItems(0).Text)
                        cmmds10.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds10.Parameters.AddWithValue("@BorrowedDate", lvitem.SubItems(12).Text)
                        cmmds10.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(13).Text)
                        conn10.Open()
                        cmmds10.ExecuteNonQuery()
                        conn10.Close()
                    End If

                    Dim conn8 As New MySqlConnection(connString)
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
    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        If rb_nonprinted.Checked Then
            txt_matno.Focus()

            If txt_matno.Text = "" Then
                MsgBox("Please Enter Material Number", MsgBoxStyle.Critical)
                txt_matno.Focus()
            ElseIf txt_matname.Text = "" Then
                MsgBox("Please Material Name", MsgBoxStyle.Critical)
                txt_matname.Focus()
            ElseIf dtp_datetorett.Text = "" Then
                MsgBox("Please Due Date", MsgBoxStyle.Critical)
                dtp_datetorett.Focus()
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
                dtp_datetorett.CustomFormat = ""
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
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(dtp_datetorett.Text)
                            newitem.SubItems.Add(rb_faculty.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)

                            ListView1.Items.Add(newitem)

                            rb_printed.Checked = False
                            rb_nonprinted.Checked = False
                            txt_matno.Clear()
                            txt_matname.Clear()
                            txt_bookno.Clear()
                            txt_isbnn.Clear()
                            txt_address.Clear()
                            txt_copyright.Clear()
                            txt_titlee.Clear()
                            txt_authorr.Clear()
                            txt_year.Clear()
                            txt_pubcom.Clear()
                            cmb_ddc.SelectedIndex = -1
                            cmb_categooory.SelectedIndex = -1
                            rb_faculty.Checked = False
                            rb_student.Checked = False
                            txt_idno.Clear()
                            txt_namee.Clear()
                            txt_num.Clear()
                            txt_gradesecc.Clear()
                            txt_teacher.Clear()
                            dtp_datetorett.Text = ""

                        Else
                            MsgBox("Faculty not found!", MsgBoxStyle.Critical)

                        End If
                        Label3.Enabled = True
                        Label9.Enabled = True
                        txt_gradesecc.Enabled = True
                        txt_teacher.Enabled = True
                        txt_matname.Enabled = True
                        txt_matno.Enabled = True
                        txt_isbnn.Enabled = True
                        txt_titlee.Enabled = True
                        txt_bookno.Enabled = True
                        txt_authorr.Enabled = True
                        txt_year.Enabled = True
                        txt_address.Enabled = True
                        txt_copyright.Enabled = True
                        txt_pubcom.Enabled = True
                        cmb_ddc.Enabled = True
                        cmb_categooory.Enabled = True
                        txt_isbnn.ReadOnly = False
                        txt_titlee.ReadOnly = False
                        txt_authorr.ReadOnly = False
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
                        rb_nonprinted.Checked = False
                        rb_printed.Checked = False
                        txt_matname.ReadOnly = False
                        txt_matno.ReadOnly = False
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
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(dtp_datetorett.Text)
                            newitem.SubItems.Add(rb_student.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.SubItems.Add(txt_gradesecc.Text)
                            newitem.SubItems.Add(txt_teacher.Text)

                            ListView1.Items.Add(newitem)

                            rb_printed.Checked = False
                            rb_nonprinted.Checked = False
                            txt_matno.Clear()
                            txt_matname.Clear()
                            txt_bookno.Clear()
                            txt_isbnn.Clear()
                            txt_address.Clear()
                            txt_copyright.Clear()
                            txt_titlee.Clear()
                            txt_authorr.Clear()
                            txt_year.Clear()
                            txt_pubcom.Clear()
                            cmb_ddc.SelectedIndex = -1
                            cmb_categooory.SelectedIndex = -1
                            rb_faculty.Checked = False
                            rb_student.Checked = False
                            txt_idno.Clear()
                            txt_namee.Clear()
                            txt_num.Clear()
                            txt_gradesecc.Clear()
                            txt_teacher.Clear()
                            dtp_datetorett.Text = ""

                        Else
                            MsgBox("Student not found!", MsgBoxStyle.Critical)
                        End If
                    End If
                    Label3.Enabled = True
                    Label9.Enabled = True
                    txt_gradesecc.Enabled = True
                    txt_teacher.Enabled = True
                    txt_matname.Enabled = True
                    txt_matno.Enabled = True
                    txt_isbnn.Enabled = True
                    txt_titlee.Enabled = True
                    txt_bookno.Enabled = True
                    txt_authorr.Enabled = True
                    txt_year.Enabled = True
                    txt_address.Enabled = True
                    txt_copyright.Enabled = True
                    txt_pubcom.Enabled = True
                    cmb_ddc.Enabled = True
                    cmb_categooory.Enabled = True
                    txt_isbnn.ReadOnly = False
                    txt_titlee.ReadOnly = False
                    txt_authorr.ReadOnly = False
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
                    rb_nonprinted.Checked = False
                    rb_printed.Checked = False
                    txt_matname.ReadOnly = False
                    txt_matno.ReadOnly = False
                Else
                    MsgBox("Book not found!", MsgBoxStyle.Critical)
                End If
            End If
            Label3.Enabled = True
            Label9.Enabled = True
            txt_gradesecc.Enabled = True
            txt_teacher.Enabled = True
            txt_matname.Enabled = True
            txt_matno.Enabled = True
            txt_isbnn.Enabled = True
            txt_titlee.Enabled = True
            txt_bookno.Enabled = True
            txt_authorr.Enabled = True
            txt_year.Enabled = True
            txt_address.Enabled = True
            txt_copyright.Enabled = True
            txt_pubcom.Enabled = True
            cmb_ddc.Enabled = True
            cmb_categooory.Enabled = True
            txt_isbnn.ReadOnly = False
            txt_titlee.ReadOnly = False
            txt_authorr.ReadOnly = False
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
            rb_nonprinted.Checked = False
            rb_printed.Checked = False
            txt_matname.ReadOnly = False
            txt_matno.ReadOnly = False
        ElseIf rb_printed.Checked Then
            txt_bookno.Focus()

            If txt_bookno.Text = "" Then
                MsgBox("Please Enter BookNumber", MsgBoxStyle.Critical)
                txt_bookno.Focus()
            ElseIf txt_isbnn.Text = "" Then
                MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
                txt_isbnn.Focus()
            ElseIf txt_titlee.Text = "" Then
                MsgBox("Please Enter Title", MsgBoxStyle.Critical)
                txt_titlee.Focus()
            ElseIf txt_authorr.Text = "" Then
                MsgBox("Please Enter Author", MsgBoxStyle.Critical)
                txt_authorr.Focus()
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
            ElseIf dtp_datetorett.CustomFormat = " " Then
                MsgBox("Please Enter Due Date", MsgBoxStyle.Critical)
                dtp_datetorett.Focus()
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
                dtp_datetorett.CustomFormat = ""
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                conn.Open()
                'VALIDATE BOOK
                Dim tx As String = "SELECT booknumber,isbn,title,author,deweydecimalclassification,category,yearofpublication,address,copyright,publisher from tbl_book where booknumber= '" & txt_bookno.Text & "' AND isbn= '" & txt_isbnn.Text & "' AND title= '" & txt_titlee.Text & "' AND author= '" & txt_authorr.Text & "' AND DeweyDecimalClassification= '" & cmb_ddc.Text & "' AND category= '" & cmb_categooory.Text & "' AND YearofPublication= '" & txt_year.Text & "' AND address= '" & txt_address.Text & "' AND copyright= '" & txt_copyright.Text & "'AND publisher= '" & txt_pubcom.Text & "'"
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
                            newitem.SubItems.Add(txt_authorr.Text)
                            newitem.SubItems.Add(txt_year.Text)
                            newitem.SubItems.Add(txt_pubcom.Text)
                            newitem.SubItems.Add(cmb_ddc.Text)
                            newitem.SubItems.Add(cmb_categooory.Text)
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(dtp_datetorett.Text)
                            newitem.SubItems.Add(rb_faculty.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)

                            ListView1.Items.Add(newitem)

                            rb_printed.Checked = False
                            rb_nonprinted.Checked = False
                            txt_matno.Clear()
                            txt_matname.Clear()
                            txt_bookno.Clear()
                            txt_isbnn.Clear()
                            txt_address.Clear()
                            txt_copyright.Clear()
                            txt_titlee.Clear()
                            txt_authorr.Clear()
                            txt_year.Clear()
                            txt_pubcom.Clear()
                            cmb_ddc.SelectedIndex = -1
                            cmb_categooory.SelectedIndex = -1
                            rb_faculty.Checked = False
                            rb_student.Checked = False
                            txt_idno.Clear()
                            txt_namee.Clear()
                            txt_num.Clear()
                            txt_gradesecc.Clear()
                            txt_teacher.Clear()
                            dtp_datetorett.Text = ""
                            txt_gradesecc.Enabled = True
                            txt_teacher.Enabled = True

                        Else
                            MsgBox("Faculty not found!", MsgBoxStyle.Critical)

                        End If
                        Label3.Enabled = True
                        Label9.Enabled = True
                        txt_gradesecc.Enabled = True
                        txt_teacher.Enabled = True
                        txt_matname.Enabled = True
                        txt_matno.Enabled = True
                        txt_isbnn.Enabled = True
                        txt_titlee.Enabled = True
                        txt_bookno.Enabled = True
                        txt_authorr.Enabled = True
                        txt_year.Enabled = True
                        txt_address.Enabled = True
                        txt_copyright.Enabled = True
                        txt_pubcom.Enabled = True
                        cmb_ddc.Enabled = True
                        cmb_categooory.Enabled = True
                        txt_isbnn.ReadOnly = False
                        txt_titlee.ReadOnly = False
                        txt_authorr.ReadOnly = False
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
                        rb_nonprinted.Checked = False
                        rb_printed.Checked = False
                        txt_matname.ReadOnly = False
                        txt_matno.ReadOnly = False
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
                            newitem.SubItems.Add(txt_authorr.Text)
                            newitem.SubItems.Add(txt_year.Text)
                            newitem.SubItems.Add(txt_pubcom.Text)
                            newitem.SubItems.Add(cmb_ddc.Text)
                            newitem.SubItems.Add(cmb_categooory.Text)
                            newitem.SubItems.Add(dtp_dateborr.Text)
                            newitem.SubItems.Add(dtp_datetorett.Text)
                            newitem.SubItems.Add(rb_student.Text)
                            newitem.SubItems.Add(txt_idno.Text)
                            newitem.SubItems.Add(txt_namee.Text)
                            newitem.SubItems.Add(txt_num.Text)
                            newitem.SubItems.Add(txt_gradesecc.Text)
                            newitem.SubItems.Add(txt_teacher.Text)

                            ListView1.Items.Add(newitem)

                            rb_printed.Checked = False
                            rb_nonprinted.Checked = False
                            txt_matno.Clear()
                            txt_matname.Clear()
                            txt_bookno.Clear()
                            txt_isbnn.Clear()
                            txt_address.Clear()
                            txt_copyright.Clear()
                            txt_titlee.Clear()
                            txt_authorr.Clear()
                            txt_year.Clear()
                            txt_pubcom.Clear()
                            cmb_ddc.SelectedIndex = -1
                            cmb_categooory.SelectedIndex = -1
                            dtp_datetorett.Text = ""
                            rb_faculty.Checked = False
                            rb_student.Checked = False
                            txt_idno.Clear()
                            txt_namee.Clear()
                            txt_num.Clear()
                            txt_gradesecc.Clear()
                            txt_teacher.Clear()
                            dtp_datetorett.Text = ""

                        Else
                            MsgBox("Student not found!", MsgBoxStyle.Critical)
                        End If
                    End If
                    Label3.Enabled = True
                    Label9.Enabled = True
                    txt_gradesecc.Enabled = True
                    txt_teacher.Enabled = True
                    txt_matname.Enabled = True
                    txt_matno.Enabled = True
                    txt_isbnn.Enabled = True
                    txt_titlee.Enabled = True
                    txt_bookno.Enabled = True
                    txt_authorr.Enabled = True
                    txt_year.Enabled = True
                    txt_address.Enabled = True
                    txt_copyright.Enabled = True
                    txt_pubcom.Enabled = True
                    cmb_ddc.Enabled = True
                    cmb_categooory.Enabled = True
                    txt_isbnn.ReadOnly = False
                    txt_titlee.ReadOnly = False
                    txt_authorr.ReadOnly = False
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
                    rb_nonprinted.Checked = False
                    rb_printed.Checked = False
                    txt_matname.ReadOnly = False
                    txt_matno.ReadOnly = False
                Else
                    MsgBox("Book not found!", MsgBoxStyle.Critical)
                End If
            End If
        End If
        Label3.Enabled = True
        Label9.Enabled = True
        txt_gradesecc.Enabled = True
        txt_teacher.Enabled = True
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn.Enabled = True
        txt_titlee.Enabled = True
        txt_bookno.Enabled = True
        txt_authorr.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_authorr.ReadOnly = False
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
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_matname.ReadOnly = False
        txt_matno.ReadOnly = False
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        rb_printed.Checked = False
        rb_nonprinted.Checked = False
        txt_matno.Clear()
        txt_matname.Clear()
        txt_bookno.Clear()
        txt_isbnn.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_titlee.Clear()
        txt_authorr.Clear()
        txt_year.Clear()
        txt_pubcom.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory.SelectedIndex = -1
        rb_faculty.Checked = False
        rb_student.Checked = False
        txt_idno.Clear()
        txt_namee.Clear()
        txt_num.Clear()
        txt_gradesecc.Clear()
        txt_teacher.Clear()
        dtp_datetorett.Text = ""
        Label3.Enabled = True
        Label9.Enabled = True
        txt_gradesecc.Enabled = True
        txt_teacher.Enabled = True
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn.Enabled = True
        txt_titlee.Enabled = True
        txt_bookno.Enabled = True
        txt_authorr.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory.Enabled = True
        txt_isbnn.ReadOnly = False
        txt_titlee.ReadOnly = False
        txt_authorr.ReadOnly = False
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
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_matname.ReadOnly = False
        txt_matno.ReadOnly = False
    End Sub

    Private Sub rb_student_CheckedChanged(sender As Object, e As EventArgs) Handles rb_student.CheckedChanged
        Label3.Enabled = True
        txt_gradesecc.Enabled = True
        Label9.Enabled = True
        txt_teacher.Enabled = True
        txt_idno.Focus()

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

                End If

                data.Close()
            End If
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
    Private Sub txt_authorr_Click(sender As Object, e As EventArgs) Handles txt_authorr.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_classnum_Click(sender As Object, e As EventArgs)
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_pubcom_Click(sender As Object, e As EventArgs)
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
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

    Private Sub dtp_datetorett_Click(sender As Object, e As EventArgs) Handles dtp_datetorett.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
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

    Private Sub txt_year_Click(sender As Object, e As EventArgs)
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

            conn.Open()
            If rb_student.Checked Then
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
                End If
            ElseIf rb_faculty.Checked Then
                Dim qstr As String = "SELECT * FROM tbl_faculty WHERE Username = '" & txt_idno.Text & "'"
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
                    End If
                End If
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
End Class