Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class AdminMainForms
    Private Sub BorrowBookToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'BorrowBook.MdiParent = Me
        'BorrowBook.Show()
        'BorrowBook.txt_isbnn.Focus()
        Borrow.txt_duedate.Clear()
        'Borrow.dtp_datetorett.Text = ""
        'Borrow.MdiParent = Me
        Borrow.Show()
        Borrow.txt_isbnn.Focus()
        Borrow.Label3.Enabled = True
        Borrow.Label9.Enabled = True
        Borrow.txt_gradesecc.Enabled = True
        Borrow.txt_teacher.Enabled = True

        ''AUTOINCREMENT AND AUTOFILL BOOK NUMBER
        'If conn.State = ConnectionState.Closed Then
        '    conn.Open()
        'End If
        'Dim strsql = "Select book_number from tbl_borrowedbooks where book_number=(select max(book_number)from tbl_borrowedbooks)"
        'Dim cmddd1 As New MySqlCommand(strsql, conn)
        'Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
        'If myreader.Read() Then
        '    Borrow.txt_bookno.Text = myreader("book_number") + 1
        'End If
        'conn.Close()
    End Sub

    Private Sub DelinquentBorrowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelinquentBorrowersToolStripMenuItem.Click
        'DelinquentBorrower.MdiParent = Me
        DelinquentBorrower.Show()
        DelinquentBorrower.dt1.CustomFormat = " "
        DelinquentBorrower.dt2.CustomFormat = " "

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd51 As New MySqlCommand("Select * From tbl_delinquentborrowers", conn)
        Dim daw51 As New MySqlDataAdapter
        daw51.SelectCommand = cmd51
        Dim dt51 As New DataTable
        dt51.Clear()
        daw51.Fill(dt51)
        DelinquentBorrower.DataGridView1.DataSource = dt51
        conn.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim Ask As MsgBoxResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.OkCancel)
        If Ask = MsgBoxResult.Ok Then
            Form1.Show()
            Me.Hide()
            Form1.txt_uname.Clear()
            Form1.txt_pword.Clear()
            Form1.txt_uname.Focus()

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

        End If

    End Sub

    Private Sub ReturnBookToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReturnBook.txt_datetoreturn.Text = ""
        'ReturnBook.MdiParent = Me
        ReturnBook.Show()
        ReturnBook.txt_bookno.Focus()

        Dim theDate As Date
        theDate = Format(Now(), "dd-MM-yyyy")
        ReturnBook.txt_dateret.Text = theDate

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        'StudentBorrower.MdiParent = Me
        StudentBorrower.Show()
        StudentBorrower.dt1.CustomFormat = " "
        StudentBorrower.dt2.CustomFormat = " "
        StudentBorrower.DataGridView1.ClearSelection()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select Username, Name, ContactNo, GradeSec, Teacher, Itemtype, Title, Dateborrowed, datetoreturn From tbl_studentborrowers", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        StudentBorrower.DataGridView1.DataSource = dt01
        conn.Close()

        'Borrowers.MdiParent = Me
        'Borrowers.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        'FacultyBorrowers.MdiParent = Me
        FacultyBorrowers.Show()
        FacultyBorrowers.dt1.CustomFormat = " "
        FacultyBorrowers.dt2.CustomFormat = " "
        FacultyBorrowers.DataGridView1.ClearSelection()
        'Borrowers2.MdiParent = Me
        'Borrowers2.Show()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select Username,Name,ContactNo,Itemtype,Title,Dateborrowed,datetoreturn from tbl_facultyborrowers", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        FacultyBorrowers.DataGridView1.DataSource = dt01
        conn.Close()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Borrow.MdiParent = Me
        Borrow.Show()

        'Borrow.ListView1.Refresh()
        'BorrowBook.Show()
        'BorrowBook.txt_isbnn.Focus()
        Borrow.txt_duedate.Text = ""
        'Borrow.dtp_datetorett.CustomFormat = "dd/MM/yyyy - hh:mm tt"
        'Borrow.dtp_datetorett.Text = ""
        'Borrow.txt_idno.Focus()
        Borrow.Label3.Enabled = True
        Borrow.Label9.Enabled = True
        Borrow.txt_gradesecc.Enabled = True
        Borrow.txt_teacher.Enabled = True
        Borrow.txt_matname.Enabled = True
        Borrow.txt_matno.Enabled = True
        Borrow.txt_isbnn.Enabled = True
        Borrow.txt_titlee.Enabled = True
        Borrow.txt_edition.Enabled = True
        Borrow.txt_bookno.Enabled = True
        Borrow.txt_auth_ln.Enabled = True
        Borrow.txt_auth_fn.Enabled = True
        Borrow.txt_auth_mn.Enabled = True
        Borrow.txt_year.Enabled = True
        Borrow.txt_address.Enabled = True
        Borrow.txt_copyright.Enabled = True
        Borrow.txt_pubcom.Enabled = True
        Borrow.cmb_ddc.Enabled = True
        Borrow.cmb_categooory.Enabled = True
        Borrow.txt_isbnn.ReadOnly = False
        Borrow.txt_titlee.ReadOnly = False
        Borrow.txt_auth_ln.ReadOnly = False
        Borrow.txt_auth_fn.ReadOnly = False
        Borrow.txt_auth_mn.ReadOnly = False
        Borrow.txt_year.ReadOnly = False
        Borrow.txt_idno.ReadOnly = False
        Borrow.txt_namee.ReadOnly = False
        Borrow.txt_num.ReadOnly = False
        Borrow.txt_gradesecc.ReadOnly = False
        Borrow.txt_teacher.ReadOnly = False
        Borrow.txt_address.ReadOnly = False
        Borrow.txt_copyright.ReadOnly = False
        Borrow.txt_bookno.ReadOnly = False
        Borrow.txt_pubcom.ReadOnly = False
        Borrow.rb_nonprinted.Checked = False
        Borrow.rb_printed.Checked = False
        Borrow.txt_matname.ReadOnly = False
        Borrow.txt_matno.ReadOnly = False

        'Refresh tbl_nonprinted
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_nonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()

        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_book", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()


        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Borrow.cmb_categooory.DataSource = dt
                Borrow.cmb_categooory.DisplayMember = "category"
                Borrow.cmb_categooory.ValueMember = ""
                'cmb_category.DataSource = dt
                Borrow.cmb_categooory.SelectedIndex = -1
                Borrow.cmb_categooory.Refresh()
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
                Borrow.cmb_ddc.DataSource = dt1
                Borrow.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
                Borrow.cmb_ddc.ValueMember = ""
                'cmb_category.DataSource = dt
                Borrow.cmb_ddc.SelectedIndex = -1
                Borrow.cmb_ddc.Refresh()
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
        '        Borrow.cmb_categooory.DataSource = dt
        '        Borrow.cmb_categooory.DisplayMember = "category"
        '        Borrow.cmb_categooory.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        Borrow.cmb_categooory.SelectedIndex = -1
        '        Borrow.cmb_categooory.Refresh()
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
        '        Borrow.cmb_ddc.DataSource = dt1
        '        Borrow.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
        '        Borrow.cmb_ddc.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        Borrow.cmb_ddc.SelectedIndex = -1
        '        Borrow.cmb_ddc.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ReturnBook.txt_datetoreturn.Text = ""
        ReturnBook.MdiParent = Me
        ReturnBook.Show()
        ReturnBook.txt_bookno.Focus()
        ReturnBook.txt_reason.Enabled = False
        ReturnBook.txt_isbnn1.ReadOnly = False
        ReturnBook.txt_titlee1.ReadOnly = False
        ReturnBook.txt_auth_ln.ReadOnly = False
        ReturnBook.txt_auth_fn.ReadOnly = False
        ReturnBook.txt_auth_mn.ReadOnly = False
        ReturnBook.txt_year.ReadOnly = False
        ReturnBook.txt_pubcom.ReadOnly = False
        ReturnBook.txt_datetoreturn.ReadOnly = False
        ReturnBook.txt_reason.ReadOnly = False
        ReturnBook.txt_namee.ReadOnly = False
        ReturnBook.txt_idno.ReadOnly = False
        ReturnBook.txt_matno.ReadOnly = False
        ReturnBook.txt_matname.ReadOnly = False

        ReturnBook.txt_matname.Enabled = True
        ReturnBook.txt_matno.Enabled = True
        ReturnBook.txt_isbnn1.Enabled = True
        ReturnBook.txt_titlee1.Enabled = True
        ReturnBook.txt_bookno.Enabled = True
        ReturnBook.txt_auth_ln.Enabled = True
        ReturnBook.txt_auth_fn.Enabled = True
        ReturnBook.txt_auth_mn.Enabled = True
        ReturnBook.txt_year.Enabled = True
        ReturnBook.txt_address.Enabled = True
        ReturnBook.txt_copyright.Enabled = True
        ReturnBook.txt_pubcom.Enabled = True
        ReturnBook.cmb_ddc.Enabled = True
        ReturnBook.cmb_categooory1.Enabled = True

        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_borrowreturnnonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()

        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_borrowreturnbooks", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()

        'conn.Open()
        'Try
        '    Dim str As String = "SELECT category FROM tbl_category"
        '    Dim da As New MySqlDataAdapter(str, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    If dt.Rows.Count > 0 Then
        '        ReturnBook.cmb_categooory1.DataSource = dt
        '        ReturnBook.cmb_categooory1.DisplayMember = "category"
        '        ReturnBook.cmb_categooory1.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        ReturnBook.cmb_categooory1.SelectedIndex = -1
        '        ReturnBook.cmb_categooory1.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        'conn.Open()
        'Try
        '    Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_ddc"
        '    Dim da1 As New MySqlDataAdapter(str1, conn)
        '    Dim dt1 As New DataTable
        '    da1.Fill(dt1)
        '    If dt1.Rows.Count > 0 Then
        '        ReturnBook.cmb_ddc.DataSource = dt1
        '        ReturnBook.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
        '        ReturnBook.cmb_ddc.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        ReturnBook.cmb_ddc.SelectedIndex = -1
        '        ReturnBook.cmb_ddc.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ReturnBook.cmb_categooory1.DataSource = dt
                ReturnBook.cmb_categooory1.DisplayMember = "category"
                ReturnBook.cmb_categooory1.ValueMember = ""
                'cmb_category.DataSource = dt
                ReturnBook.cmb_categooory1.SelectedIndex = -1
                ReturnBook.cmb_categooory1.Refresh()
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
                ReturnBook.cmb_ddc.DataSource = dt1
                ReturnBook.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
                ReturnBook.cmb_ddc.ValueMember = ""
                'cmb_category.DataSource = dt
                ReturnBook.cmb_ddc.SelectedIndex = -1
                ReturnBook.cmb_ddc.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    'Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
    '    View.MdiParent = Me
    '    View.Show()
    'End Sub

    'Private Sub AddAdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddAdminToolStripMenuItem1.Click
    '    AddAdmin.MdiParent = Me
    '    AddAdmin.Show()
    '    AddAdmin.txt_pword1.Text = "password"
    'End Sub

    'Private Sub AddFacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFacultyToolStripMenuItem.Click
    '    AddFaculty.MdiParent = Me
    '    AddFaculty.Show()
    '    AddFaculty.txt_pword1.Text = "password"
    'End Sub

    'Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
    '    AddStudent.MdiParent = Me
    '    AddStudent.Show()
    '    AddStudent.txt_pword1.Text = "password"
    'End Sub

    'Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
    '    Lost_Book.MdiParent = Me
    '    Lost_Book.Show()
    'End Sub

    'Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
    '    'BorrowBook.MdiParent = Me
    '    'BorrowBook.Show()
    '    'BorrowBook.txt_isbnn.Focus()
    '    Borrow.dtp_datetorett.CustomFormat = " "
    '    'Borrow.dtp_datetorett.Text = ""
    '    Borrow.MdiParent = Me
    '    Borrow.Show()
    '    Borrow.txt_bookno.Focus()
    '    Borrow.Label3.Enabled = True
    '    Borrow.Label9.Enabled = True
    '    Borrow.txt_gradesecc.Enabled = True
    '    Borrow.txt_teacher.Enabled = True
    '    Borrow.txt_matname.Enabled = True
    '    Borrow.txt_matno.Enabled = True
    '    Borrow.txt_isbnn.Enabled = True
    '    Borrow.txt_titlee.Enabled = True
    '    Borrow.txt_bookno.Enabled = True
    '    Borrow.txt_authorr.Enabled = True
    '    Borrow.txt_year.Enabled = True
    '    Borrow.txt_classnum.Enabled = True
    '    Borrow.txt_pubcom.Enabled = True
    '    Borrow.cmb_ddc.Enabled = True
    '    Borrow.cmb_categooory.Enabled = True
    '    Borrow.txt_isbnn.ReadOnly = False
    '    Borrow.txt_titlee.ReadOnly = False
    '    Borrow.txt_authorr.ReadOnly = False
    '    Borrow.txt_year.ReadOnly = False
    '    Borrow.txt_idno.ReadOnly = False
    '    Borrow.txt_namee.ReadOnly = False
    '    Borrow.txt_num.ReadOnly = False
    '    Borrow.txt_gradesecc.ReadOnly = False
    '    Borrow.txt_teacher.ReadOnly = False
    '    Borrow.txt_classnum.ReadOnly = False
    '    Borrow.txt_bookno.ReadOnly = False
    '    Borrow.txt_pubcom.ReadOnly = False
    '    Borrow.rb_nonprinted.Checked = False
    '    Borrow.rb_printed.Checked = False
    '    Borrow.txt_matname.ReadOnly = False
    '    Borrow.txt_matno.ReadOnly = False
    '    ''AUTOINCREMENT AND AUTOFILL BOOK NUMBER
    '    'If conn.State = ConnectionState.Closed Then
    '    '    conn.Open()
    '    'End If
    '    'Dim strsql = "Select book_number from tbl_borrowedbooks where book_number=(select max(book_number)from tbl_borrowedbooks)"
    '    'Dim cmddd1 As New MySqlCommand(strsql, conn)
    '    'Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
    '    'If myreader.Read() Then
    '    '    Borrow.txt_bookno.Text = myreader("book_number") + 1
    '    'End If
    '    'conn.Close()
    'End Sub

    'Private Sub NonPrintedMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    BorrowNonPrinted.dtp_datetorett.CustomFormat = " "
    '    BorrowNonPrinted.Show()
    '    BorrowNonPrinted.MdiParent = Me
    '    BorrowNonPrinted.txt_matno.Focus()
    '    BorrowNonPrinted.Label3.Enabled = True
    '    BorrowNonPrinted.Label9.Enabled = True
    '    BorrowNonPrinted.txt_gradesecc.Enabled = True
    '    BorrowNonPrinted.txt_teacher.Enabled = True

    '    BorrowNonPrinted.txt_idno.ReadOnly = False
    '    BorrowNonPrinted.txt_namee.ReadOnly = False
    '    BorrowNonPrinted.txt_num.ReadOnly = False
    '    BorrowNonPrinted.txt_gradesecc.ReadOnly = False
    '    BorrowNonPrinted.txt_teacher.ReadOnly = False
    '    BorrowNonPrinted.txt_matno.ReadOnly = False
    '    BorrowNonPrinted.txt_matname.ReadOnly = False
    'End Sub

    Private Sub BookToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem1.Click
        Lost_Book.MdiParent = Me
        Lost_Book.Show()
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd0130 As New MySqlCommand("Select * from tbl_borrowreturnbooks", conn)
        Dim daw0130 As New MySqlDataAdapter
        daw0130.SelectCommand = cmd0130
        Dim dt0130 As New DataTable
        dt0130.Clear()
        daw0130.Fill(dt0130)
        Lost_Book.DataGridView1.DataSource = dt0130
        Lost_Book.DataGridView1.ClearSelection()

        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_borrowreturnnonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()

        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_borrowreturnbooks", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()

        'conn.Open()
        'Try
        '    Dim str As String = "SELECT category FROM tbl_category"
        '    Dim da As New MySqlDataAdapter(str, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    If dt.Rows.Count > 0 Then
        '        Lost_Book.cmb_categooory1.DataSource = dt
        '        Lost_Book.cmb_categooory1.DisplayMember = "category"
        '        Lost_Book.cmb_categooory1.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        Lost_Book.cmb_categooory1.SelectedIndex = -1
        '        Lost_Book.cmb_categooory1.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        'conn.Open()
        'Try
        '    Dim str1 As String = "SELECT DeweyDecimalClassification FROM tbl_ddc"
        '    Dim da1 As New MySqlDataAdapter(str1, conn)
        '    Dim dt1 As New DataTable
        '    da1.Fill(dt1)
        '    If dt1.Rows.Count > 0 Then
        '        Lost_Book.cmb_ddc.DataSource = dt1
        '        Lost_Book.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
        '        Lost_Book.cmb_ddc.ValueMember = ""
        '        'cmb_category.DataSource = dt
        '        Lost_Book.cmb_ddc.SelectedIndex = -1
        '        Lost_Book.cmb_ddc.Refresh()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Lost_Book.cmb_categooory1.DataSource = dt
                Lost_Book.cmb_categooory1.DisplayMember = "category"
                Lost_Book.cmb_categooory1.ValueMember = ""
                'cmb_category.DataSource = dt
                Lost_Book.cmb_categooory1.SelectedIndex = -1
                Lost_Book.cmb_categooory1.Refresh()
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
                Lost_Book.cmb_ddc.DataSource = dt1
                Lost_Book.cmb_ddc.DisplayMember = "DeweyDecimalClassification"
                Lost_Book.cmb_ddc.ValueMember = ""
                'cmb_category.DataSource = dt
                Lost_Book.cmb_ddc.SelectedIndex = -1
                Lost_Book.cmb_ddc.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialToolStripMenuItem1.Click
        LostNonPrinted.MdiParent = Me
        LostNonPrinted.Show()
        LostNonPrinted.txt_matno.Enabled = True
        LostNonPrinted.txt_matname.Enabled = True
        LostNonPrinted.txt_datetoreturn.Enabled = True
        LostNonPrinted.txt_namee.Enabled = True
        LostNonPrinted.txt_idno.Enabled = True
        LostNonPrinted.txt_matno.ReadOnly = False
        LostNonPrinted.txt_matname.ReadOnly = False
        LostNonPrinted.txt_datetoreturn.ReadOnly = False
        LostNonPrinted.txt_namee.ReadOnly = False
        LostNonPrinted.txt_idno.ReadOnly = False
        LostNonPrinted.DataGridView1.ClearSelection()
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd0130 As New MySqlCommand("Select * from tbl_borrowreturnnonprinted", conn)
        Dim daw0130 As New MySqlDataAdapter
        daw0130.SelectCommand = cmd0130
        Dim dt0130 As New DataTable
        dt0130.Clear()
        daw0130.Fill(dt0130)
        LostNonPrinted.DataGridView1.DataSource = dt0130
        conn.Close()
    End Sub

    'Private Sub BookToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem2.Click
    '    ReturnBook.txt_datetoreturn.Text = ""
    '    ReturnBook.MdiParent = Me
    '    ReturnBook.Show()
    '    ReturnBook.txt_bookno.Focus()
    '    ReturnBook.txt_reason.Enabled = False
    '    ReturnBook.txt_isbnn1.ReadOnly = False
    '    ReturnBook.txt_titlee1.ReadOnly = False
    '    ReturnBook.txt_authorr1.ReadOnly = False
    '    ReturnBook.txt_year.ReadOnly = False
    '    ReturnBook.txt_pubcom.ReadOnly = False
    '    ReturnBook.txt_datetoreturn.ReadOnly = False
    '    ReturnBook.txt_reason.ReadOnly = False
    '    ReturnBook.txt_namee.ReadOnly = False
    '    ReturnBook.txt_idno.ReadOnly = False
    '    ReturnBook.txt_matno.ReadOnly = False
    '    ReturnBook.txt_matname.ReadOnly = False

    '    ReturnBook.txt_matname.Enabled = True
    '    ReturnBook.txt_matno.Enabled = True
    '    ReturnBook.txt_isbnn1.Enabled = True
    '    ReturnBook.txt_titlee1.Enabled = True
    '    ReturnBook.txt_bookno.Enabled = True
    '    ReturnBook.txt_authorr1.Enabled = True
    '    ReturnBook.txt_year.Enabled = True
    '    ReturnBook.txt_classnum.Enabled = True
    '    ReturnBook.txt_pubcom.Enabled = True
    '    ReturnBook.cmb_ddc.Enabled = True
    '    ReturnBook.cmb_categooory1.Enabled = True
    'End Sub

    'Private Sub NonPrintedMaterialToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialToolStripMenuItem2.Click
    '    ReturnNonPrinted.txt_datetoreturn.Text = ""
    '    ReturnNonPrinted.MdiParent = Me
    '    ReturnNonPrinted.Show()
    '    ReturnNonPrinted.txt_matno.Focus()
    'End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        'AUTOINCREMENT AND AUTOFILL BOOK NUMBER
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim strsql = "Select booknumber from tbl_book where booknumber=(select max(booknumber)from tbl_book)"
        Dim cmddd1 As New MySqlCommand(strsql, conn)
        Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
        If myreader.Read() Then
            Add_Book.txt_booknum.Text = myreader("booknumber") + 1
        End If
        conn.Close()

        Add_Book.MdiParent = Me
        Add_Book.Show()
        Add_Book.txt_quantity.Focus()
        Add_Book.cmb_categoory.Text = ""
        Add_Book.cmb_ddc.Text = ""
        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_book", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()

        'Refresh DataTable
        Dim cmd131 As New MySqlCommand("Select * From tbl_ddc", conn)
        Dim daw131 As New MySqlDataAdapter
        daw131.SelectCommand = cmd131
        Dim dt131 As New DataTable
        dt131.Clear()
        daw131.Fill(dt131)

        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Add_Book.cmb_categoory.DataSource = dt
                Add_Book.cmb_categoory.DisplayMember = "category"
                Add_Book.cmb_categoory.ValueMember = ""
                'cmb_category.DataSource = dt
                Add_Book.cmb_categoory.SelectedIndex = -1
                Add_Book.cmb_categoory.Refresh()
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
        conn.Close()
    End Sub

    'Private Sub UpdateBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookToolStripMenuItem.Click
    '    Update_Book.MdiParent = Me
    '    Update_Book.Show()
    '    Update_Book.txt_search.Focus()
    'End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        'AUTOINCREMENT AND AUTOFILL BOOK NUMBER
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim strsql = "Select materialnumber from tbl_nonprinted where materialnumber=(select max(materialnumber)from tbl_nonprinted)"
        Dim cmddd1 As New MySqlCommand(strsql, conn)
        Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
        If myreader.Read() Then
            AddNonPrinted.txt_matno.Text = myreader("materialnumber") + 1
        End If
        conn.Close()

        AddNonPrinted.MdiParent = Me
        AddNonPrinted.Show()
        AddNonPrinted.txt_quantity.Focus()

        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_nonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Update_Book.MdiParent = Me
        Update_Book.Show()
        Update_Book.txt_search.Focus()
        Update_Book.cmb_category.Text = ""
        Update_Book.cmb_ddc.Text = ""
        Update_Book.txt_search.Clear()
        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_book", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        AddAdmin.MdiParent = Me
        AddAdmin.Show()
        AddAdmin.txt_pword1.Text = "password"

        'Refresh tblusers
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

        'Refresh tbl_admin
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_admin", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem2.Click
        UpdateAdmin.MdiParent = Me
        UpdateAdmin.Show()
        UpdateAdmin.txt_unames.Focus()

        'Refresh tblusers
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

        'Refresh tbl_admin
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_admin", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem3.Click
        AddFaculty.MdiParent = Me
        AddFaculty.Show()
        AddFaculty.txt_pword1.Text = "password"

        'Refresh tblusers
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

        'Refresh tbl_faculty
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_faculty", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem3.Click
        UpdateFaculty.MdiParent = Me
        UpdateFaculty.Show()
        UpdateFaculty.txt_unames.Focus()

        'Refresh tblusers
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

        'Refresh tbl_faculty
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_faculty", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub AddToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem4.Click
        AddStudent.MdiParent = Me
        AddStudent.Show()
        AddStudent.txt_pword1.Text = "password"

        'Refresh tblusers
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

        'Refresh tbl_student
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_student", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem4.Click
        UpdateStudent.MdiParent = Me
        UpdateStudent.Show()
        UpdateStudent.txt_unames.Focus()

        'Refresh tblusers
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

        'Refresh tbl_student
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_student", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        conn.Close()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        SearchBook.MdiParent = Me
        SearchBook.Show()
        SearchBook.txt_isbn1.Focus()
        SearchBook.DataGridView1.ClearSelection()

        'Refresh tbl_book
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_book", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub

    Private Sub SearchToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem2.Click
        SearchNonPrinted.MdiParent = Me
        SearchNonPrinted.Show()
        SearchNonPrinted.txt_isbn1.Focus()
        SearchNonPrinted.DataGridView1.ClearSelection()
        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_nonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub

    'Private Sub ViewBooksToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    ViewBook.MdiParent = Me
    '    ViewBook.Show()

    '    'Refresh tbl_book
    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If
    '    conn.Open()
    '    Dim cmd013 As New MySqlCommand("Select * From tbl_book", conn)
    '    Dim daw013 As New MySqlDataAdapter
    '    daw013.SelectCommand = cmd013
    '    Dim dt013 As New DataTable
    '    dt013.Clear()
    '    daw013.Fill(dt013)
    '    conn.Close()
    'End Sub

    'Private Sub ViewNonPrintedMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    ViewNonPrinted.MdiParent = Me
    '    ViewNonPrinted.Show()

    '    'Refresh tbl_inventory
    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If
    '    conn.Open()
    '    Dim cmd013 As New MySqlCommand("Select * From tbl_inventory", conn)
    '    Dim daw013 As New MySqlDataAdapter
    '    daw013.SelectCommand = cmd013
    '    Dim dt013 As New DataTable
    '    dt013.Clear()
    '    daw013.Fill(dt013)
    '    conn.Close()
    'End Sub

    Private Sub BackUpRestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpRestoreToolStripMenuItem.Click
        BackUpandRestore.MdiParent = Me
        BackUpandRestore.Show()
        BackUpandRestore.TextBox1.Focus()
        BackUpandRestore.TextBox1.Clear()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        UserManualForm.MdiParent = Me
        UserManualForm.Show()

    End Sub

    Private Sub BooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem.Click
        BorrowedBook.MdiParent = Me
        BorrowedBook.Show()
        BorrowedBook.dt1.CustomFormat = " "
        BorrowedBook.dt2.CustomFormat = " "
        BorrowedBook.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("select ISBN,Title,Author,Category,DateBorrowed,DatetoReturn,Username,Name,ContactNo From tbl_borrowedbooks", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        BorrowedBook.DataGridView1.DataSource = dt01
        conn.Close()
    End Sub

    Private Sub BooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem1.Click
        ReturnedBook.MdiParent = Me
        ReturnedBook.Show()
        ReturnedBook.dt1.CustomFormat = " "
        ReturnedBook.dt2.CustomFormat = " "
        ReturnedBook.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("select ISBN,Title,Author,Category,DateReturned,Username,Name From tbl_returnedbooks", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        ReturnedBook.DataGridView1.DataSource = dt01
        conn.Close()
    End Sub

    Private Sub BooksToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem2.Click
        OverdueBook.MdiParent = Me
        OverdueBook.Show()
        OverdueBook.dt1.CustomFormat = " "
        OverdueBook.dt2.CustomFormat = " "
        OverdueBook.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd5 As New MySqlCommand("Select BookNumber,ISBN,Title,Author,Category,DatetoReturn,DateReturned from tbl_overduebooks", conn)
        Dim daw5 As New MySqlDataAdapter
        daw5.SelectCommand = cmd5
        Dim dt5 As New DataTable
        dt5.Clear()
        daw5.Fill(dt5)
        OverdueBook.DataGridView1.DataSource = dt5
        conn.Close()
    End Sub

    Private Sub BooksToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem3.Click
        DamagedBook.MdiParent = Me
        DamagedBook.Show()
        DamagedBook.dt1.CustomFormat = " "
        DamagedBook.dt2.CustomFormat = " "
        DamagedBook.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open() 'Refresh DamagedBook Form DataGridView
        Dim cmd5 As New MySqlCommand("Select BookNumber,ISBN,Title,Author,Category,Name,DateReturned from tbl_damagedbooks", conn)
        Dim daw5 As New MySqlDataAdapter
        daw5.SelectCommand = cmd5
        Dim dt5 As New DataTable
        dt5.Clear()
        daw5.Fill(dt5)
        DamagedBook.DataGridView1.DataSource = dt5
        conn.Close()
    End Sub

    Private Sub BooksToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem4.Click
        LostBook.MdiParent = Me
        LostBook.Show()
        LostBook.dt1.CustomFormat = " "
        LostBook.dt2.CustomFormat = " "
        LostBook.DataGridView1.ClearSelection()
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select BookNumber,ISBN,Title,Author,Category,Name,DatetoReturn from tbl_lostbooks", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        LostBook.DataGridView1.DataSource = dt013
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem.Click
        BorrowedNonPrinted.MdiParent = Me
        BorrowedNonPrinted.Show()
        BorrowedNonPrinted.dt1.CustomFormat = " "
        BorrowedNonPrinted.dt2.CustomFormat = " "
        BorrowedNonPrinted.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_borrowednonprinted", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        BorrowedNonPrinted.DataGridView1.DataSource = dt01
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem1.Click
        ReturnedNonPrinted.MdiParent = Me
        ReturnedNonPrinted.Show()
        ReturnedNonPrinted.dt1.CustomFormat = " "
        ReturnedNonPrinted.dt2.CustomFormat = " "
        ReturnedNonPrinted.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_returnednonprinted", conn)
        Dim daw01 As New MySqlDataAdapter
        daw01.SelectCommand = cmd01
        Dim dt01 As New DataTable
        dt01.Clear()
        daw01.Fill(dt01)
        ReturnedNonPrinted.DataGridView1.DataSource = dt01
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem2.Click
        OverdueNonPrinted.MdiParent = Me
        OverdueNonPrinted.Show()
        OverdueNonPrinted.dt1.CustomFormat = " "
        OverdueNonPrinted.dt2.CustomFormat = " "
        OverdueNonPrinted.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd5 As New MySqlCommand("Select * From tbl_overduenonprinted", conn)
        Dim daw5 As New MySqlDataAdapter
        daw5.SelectCommand = cmd5
        Dim dt5 As New DataTable
        dt5.Clear()
        daw5.Fill(dt5)
        OverdueNonPrinted.DataGridView1.DataSource = dt5
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem3.Click
        DamagedNonPrinted.MdiParent = Me
        DamagedNonPrinted.Show()
        DamagedNonPrinted.dt1.CustomFormat = " "
        DamagedNonPrinted.dt2.CustomFormat = " "
        DamagedNonPrinted.DataGridView1.ClearSelection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open() 'Refresh DamagedBook Form DataGridView
        Dim cmd5 As New MySqlCommand("Select * From tbl_damagednonprinted", conn)
        Dim daw5 As New MySqlDataAdapter
        daw5.SelectCommand = cmd5
        Dim dt5 As New DataTable
        dt5.Clear()
        daw5.Fill(dt5)
        DamagedNonPrinted.DataGridView1.DataSource = dt5
        conn.Close()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem4.Click
        Lost_NonPrinted.MdiParent = Me
        Lost_NonPrinted.Show()
        Lost_NonPrinted.dt1.CustomFormat = " "
        Lost_NonPrinted.dt2.CustomFormat = " "
        Lost_NonPrinted.DataGridView1.ClearSelection()
        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_lostnonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        Lost_NonPrinted.DataGridView1.DataSource = dt013
        conn.Close()
    End Sub

    Private Sub ManageBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBookToolStripMenuItem.Click

    End Sub

    Private Sub SendSMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendSMSToolStripMenuItem.Click
        DueMaterials.MdiParent = Me
        DueMaterials.Show()
        DueMaterials.DataGridView1.ClearSelection()
        DueMaterials.DataGridView1.Refresh()
        DueMaterials.Refresh()
        'Refresh tbl_borrowreturn
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_borrowreturnnonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()

        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01300 As New MySqlCommand("Select * From tbl_borrowreturnbooks", conn)
        Dim daw01300 As New MySqlDataAdapter
        daw01300.SelectCommand = cmd01300
        Dim dt01300 As New DataTable
        dt01300.Clear()
        daw01300.Fill(dt01300)
        conn.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
        UpdateNonPrinted.MdiParent = Me
        UpdateNonPrinted.Show()
        UpdateNonPrinted.txt_search.Focus()

        'Refresh tbl_inventory
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_nonprinted", conn)
        Dim daw013 As New MySqlDataAdapter
        daw013.SelectCommand = cmd013
        Dim dt013 As New DataTable
        dt013.Clear()
        daw013.Fill(dt013)
        conn.Close()
    End Sub

    Private Sub AdminMainForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Restore.MdiParent = Me
        Restore.Show()
        Restore.TextBox2.Focus()
        Restore.TextBox2.Clear()
    End Sub
End Class