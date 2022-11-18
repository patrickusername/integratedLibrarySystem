Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class AdminMainForms
    'Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
    '    Add_Book.MdiParent = Me
    '    Add_Book.Show()
    '    Add_Book.txt_booknum.Focus()

    '    'Refresh DataTable
    '    'Dim cmd13 As New MySqlCommand("Select * From tbl_category", conn)
    '    'Dim daw13 As New MySqlDataAdapter
    '    'daw13.SelectCommand = cmd13
    '    'Dim dt13 As New DataTable
    '    'dt13.Clear()
    '    'daw13.Fill(dt13)
    'End Sub

    Private Sub BorrowBookToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'BorrowBook.MdiParent = Me
        'BorrowBook.Show()
        'BorrowBook.txt_isbnn.Focus()
        Borrow.dtp_datetorett.CustomFormat = " "
        'Borrow.dtp_datetorett.Text = ""
        'Borrow.MdiParent = Me
        Borrow.Show()
        Borrow.txt_isbnn.Focus()
        Borrow.Label3.Enabled = True
        Borrow.Label9.Enabled = True
        Borrow.txt_gradesecc.Enabled = True
        Borrow.txt_teacher.Enabled = True

        'AUTOINCREMENT AND AUTOFILL BOOK NUMBER
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim strsql = "Select book_number from tbl_borrowedbooks where book_number=(select max(book_number)from tbl_borrowedbooks)"
        Dim cmddd1 As New MySqlCommand(strsql, conn)
        Dim myreader As MySqlDataReader = cmddd1.ExecuteReader
        If myreader.Read() Then
            Borrow.txt_bookno.Text = myreader("book_number") + 1
        End If
        conn.Close()
    End Sub

    Private Sub BorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBooksToolStripMenuItem.Click
        'BorrowedBook.MdiParent = Me
        'BorrowedBook.Show()
        'BorrowedBook.dt1.CustomFormat = " "
        'BorrowedBook.dt2.CustomFormat = " "

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim cmd01 As New MySqlCommand("Select * From tbl_borrowedbooks", conn)
        'Dim daw01 As New MySqlDataAdapter
        'daw01.SelectCommand = cmd01
        'Dim dt01 As New DataTable
        'dt01.Clear()
        'daw01.Fill(dt01)
        'BorrowedBook.DataGridView1.DataSource = dt01
        'conn.Close()
    End Sub

    Private Sub ReturnedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedBooksToolStripMenuItem.Click
        'ReturnedBook.MdiParent = Me
        'ReturnedBook.Show()
        'ReturnedBook.dt1.CustomFormat = " "
        'ReturnedBook.dt2.CustomFormat = " "

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim cmd01 As New MySqlCommand("Select * From tbl_returnedbooks", conn)
        'Dim daw01 As New MySqlDataAdapter
        'daw01.SelectCommand = cmd01
        'Dim dt01 As New DataTable
        'dt01.Clear()
        'daw01.Fill(dt01)
        'ReturnedBook.DataGridView1.DataSource = dt01
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

    Private Sub OverdueBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverdueBooksToolStripMenuItem.Click
        'OverdueBook.MdiParent = Me
        'OverdueBook.Show()
        'OverdueBook.dt1.CustomFormat = " "
        'OverdueBook.dt2.CustomFormat = " "

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim cmd5 As New MySqlCommand("Select * From tbl_overduebooks", conn)
        'Dim daw5 As New MySqlDataAdapter
        'daw5.SelectCommand = cmd5
        'Dim dt5 As New DataTable
        'dt5.Clear()
        'daw5.Fill(dt5)
        'OverdueBook.DataGridView1.DataSource = dt5
        'conn.Close()
    End Sub

    Private Sub DamagedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamagedBooksToolStripMenuItem.Click
        'DamagedBook.MdiParent = Me
        'DamagedBook.Show()
        'DamagedBook.dt1.CustomFormat = " "
        'DamagedBook.dt2.CustomFormat = " "

        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open() 'Refresh DamagedBook Form DataGridView
        'Dim cmd5 As New MySqlCommand("Select * From tbl_damagedbooks", conn)
        'Dim daw5 As New MySqlDataAdapter
        'daw5.SelectCommand = cmd5
        'Dim dt5 As New DataTable
        'dt5.Clear()
        'daw5.Fill(dt5)
        'DamagedBook.DataGridView1.DataSource = dt5
        'conn.Close()
    End Sub

    Private Sub LostBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LostBooksToolStripMenuItem.Click
        'LostBook.MdiParent = Me
        'LostBook.Show()
        'LostBook.dt1.CustomFormat = " "
        'LostBook.dt2.CustomFormat = " "

        ''Refresh LOST BOOK FORM DataGridView
        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'Dim cmd013 As New MySqlCommand("Select * From tbl_lostbooks", conn)
        'Dim daw013 As New MySqlDataAdapter
        'daw013.SelectCommand = cmd013
        'Dim dt013 As New DataTable
        'dt013.Clear()
        'daw013.Fill(dt013)
        'LostBook.DataGridView1.DataSource = dt013
        'conn.Close()

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

    'Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
    '    Search.MdiParent = Me
    '    Search.Show()
    '    Search.DataGridView1.Sort(Search.DataGridView1.Columns(0), ListSortDirection.Descending)
    '    Search.txt_isbn1.Focus()

    'End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        'StudentBorrower.MdiParent = Me
        StudentBorrower.Show()
        StudentBorrower.dt1.CustomFormat = " "
        StudentBorrower.dt2.CustomFormat = " "
        'Borrowers.MdiParent = Me
        'Borrowers.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        'FacultyBorrowers.MdiParent = Me
        FacultyBorrowers.Show()
        FacultyBorrowers.dt1.CustomFormat = " "
        FacultyBorrowers.dt2.CustomFormat = " "
        'Borrowers2.MdiParent = Me
        'Borrowers2.Show()
    End Sub

    'Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    Borrowers.MdiParent = Me
    '    Borrowers.Show()
    'End Sub

    'Private Sub FacultyToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    Borrowers2.MdiParent = Me
    '    Borrowers2.Show()
    'End Sub

    'Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
    '    UpdateAdmin.MdiParent = Me
    '    UpdateAdmin.Show()
    '    UpdateAdmin.txt_unames.Focus()


    '    'Update_Search.MdiParent = Me
    '    'Update_Search.Show()

    'End Sub


    'Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
    '    'Add_Admin.MdiParent = Me
    '    'Add_Admin.Show()
    '    'Add_Admin.txt_pword1.Text = "password"
    'End Sub

    'Private Sub TeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherToolStripMenuItem.Click
    '    Add_Student.MdiParent = Me
    '    Add_Student.Show()
    '    Add_Student.txt_studpword.Text = "password"
    'End Sub

    'Private Sub FacultyToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem2.Click
    '    Add_Faculty.MdiParent = Me
    '    Add_Faculty.Show()
    '    Add_Faculty.txt_faculpword.Text = "password"
    'End Sub

    'Private Sub StudentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem2.Click
    '    UpdateStudent.MdiParent = Me
    '    UpdateStudent.Show()
    '    UpdateStudent.txt_unames.Focus()

    'End Sub

    'Private Sub FacultyToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem3.Click
    '    UpdateFaculty.MdiParent = Me
    '    UpdateFaculty.Show()
    '    UpdateFaculty.txt_unames.Focus()

    'End Sub

    Private Sub AddAdminToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'AddUser.MdiParent = Me
        'AddUser.Show()
        'AddUser.txt_pword1.Text = "password"
        'AddUser.lbl_faculadvi.Enabled = True
        'AddUser.cmb_faculadvi.Enabled = True
        'AddUser.lbl_studgs.Enabled = True
        'AddUser.cmb_studgs.Enabled = True
        'AddUser.lbl_studtea.Enabled = True
        'AddUser.cmb_studtea.Enabled = True
    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'UpdateUser.MdiParent = Me
        'UpdateUser.Show()

    End Sub

    'Private Sub UpdateBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookToolStripMenuItem.Click
    '    Update_Book.MdiParent = Me
    '    Update_Book.Show()
    '    Update_Book.txt_search.Focus()
    'End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'BorrowBook.MdiParent = Me
        'BorrowBook.Show()
        'BorrowBook.txt_isbnn.Focus()
        Borrow.dtp_datetorett.CustomFormat = " "
        'Borrow.dtp_datetorett.Text = ""
        Borrow.MdiParent = Me
        Borrow.Show()
        Borrow.txt_bookno.Focus()
        Borrow.Label3.Enabled = True
        Borrow.Label9.Enabled = True
        Borrow.txt_gradesecc.Enabled = True
        Borrow.txt_teacher.Enabled = True
        Borrow.txt_matname.Enabled = True
        Borrow.txt_matno.Enabled = True
        Borrow.txt_isbnn.Enabled = True
        Borrow.txt_titlee.Enabled = True
        Borrow.txt_bookno.Enabled = True
        Borrow.txt_authorr.Enabled = True
        Borrow.txt_year.Enabled = True
        Borrow.txt_address.Enabled = True
        Borrow.txt_copyright.Enabled = True
        Borrow.txt_pubcom.Enabled = True
        Borrow.cmb_ddc.Enabled = True
        Borrow.cmb_categooory.Enabled = True
        Borrow.txt_isbnn.ReadOnly = False
        Borrow.txt_titlee.ReadOnly = False
        Borrow.txt_authorr.ReadOnly = False
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

        ''BorrowBook.MdiParent = Me
        ''BorrowBook.Show()
        ''BorrowBook.txt_isbnn.Focus()
        'Borrow.dtp_datetorett.CustomFormat = " "
        ''Borrow.dtp_datetorett.Text = ""
        ''Borrow.MdiParent = Me
        'Borrow.Show()
        'Borrow.txt_bookno.Focus()
        'Borrow.Label3.Enabled = True
        'Borrow.Label9.Enabled = True
        'Borrow.txt_gradesecc.Enabled = True
        'Borrow.txt_teacher.Enabled = True

        'Borrow.txt_isbnn.ReadOnly = False
        'Borrow.txt_titlee.ReadOnly = False
        'Borrow.txt_authorr.ReadOnly = False
        'Borrow.txt_year.ReadOnly = False
        'Borrow.txt_idno.ReadOnly = False
        'Borrow.txt_namee.ReadOnly = False
        'Borrow.txt_num.ReadOnly = False
        'Borrow.txt_gradesecc.ReadOnly = False
        'Borrow.txt_teacher.ReadOnly = False
        'Borrow.txt_classnum.ReadOnly = False
        'Borrow.txt_bookno.ReadOnly = False
        'Borrow.txt_pubcom.ReadOnly = False
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

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ReturnBook.txt_datetoreturn.Text = ""
        ReturnBook.MdiParent = Me
        ReturnBook.Show()
        ReturnBook.txt_bookno.Focus()
        ReturnBook.txt_reason.Enabled = False
        ReturnBook.txt_isbnn1.ReadOnly = False
        ReturnBook.txt_titlee1.ReadOnly = False
        ReturnBook.txt_authorr1.ReadOnly = False
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
        ReturnBook.txt_authorr1.Enabled = True
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
        Add_Book.MdiParent = Me
        Add_Book.Show()
        Add_Book.txt_booknum.Focus()


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

    'Private Sub UpdateBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookToolStripMenuItem.Click
    '    Update_Book.MdiParent = Me
    '    Update_Book.Show()
    '    Update_Book.txt_search.Focus()
    'End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        AddNonPrinted.MdiParent = Me
        AddNonPrinted.Show()
        AddNonPrinted.txt_matno.Focus()

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

    Private Sub UpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
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

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Update_Book.MdiParent = Me
        Update_Book.Show()
        Update_Book.txt_search.Focus()

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

        'BackupRestore.MdiParent = Me
        'BackupRestore.Show()

        'backupandrestore3.MdiParent = Me
        'backupandrestore3.Show()

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

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_borrowedbooks", conn)
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

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd01 As New MySqlCommand("Select * From tbl_returnedbooks", conn)
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

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd5 As New MySqlCommand("Select * From tbl_overduebooks", conn)
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

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open() 'Refresh DamagedBook Form DataGridView
        Dim cmd5 As New MySqlCommand("Select * From tbl_damagedbooks", conn)
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

        'Refresh LOST BOOK FORM DataGridView
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd013 As New MySqlCommand("Select * From tbl_lostbooks", conn)
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

End Class