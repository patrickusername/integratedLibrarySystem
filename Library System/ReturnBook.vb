Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class ReturnBook
    Public conn As New MySqlConnection("server=localhost;uid=root;database=db_system")
    Private Sub bind_data()
        Dim con As New MySqlConnection("server=localhost;uid=root;database=db_system")
        con.Open()
        Dim cmd As New MySqlCommand("Select * from tbl_borrowreturnbooks", con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)

    End Sub
    Private Sub btn_cncl1_Click(sender As Object, e As EventArgs) Handles btn_cncl1.Click
        AdminMainForms.Show()
        Me.Hide()
        rb_nonprinted.Checked = False
        rb_printed.Checked = False
        txt_isbnn1.Clear()
        txt_titlee1.Clear()
        txt_authorr1.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory1.SelectedIndex = -1
        txt_pubcom.Clear()
        rb_good.Checked = False
        rb_damaged.Checked = False
        txt_idno.Clear()
        txt_namee.Clear()
        txt_bookno.Clear()
        txt_pubcom.Clear()
        txt_year.Clear()
        txt_datetoreturn.Clear()
        txt_reason.Clear()
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_authorr1.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_reason.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
    End Sub

    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ListView1.Columns.Add("Material", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("MaterialNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("MaterialName", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("BookNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("ISBN", 80, HorizontalAlignment.Left)
        'ListView1.Columns.Add("ClassNumber", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Title", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Author", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("YearofPublication", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Publisher", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Address", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Copyright", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Classification", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Category", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("DatetoReturn", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("DateReturned", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Username", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("MaterialStatus", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Reason", 80, HorizontalAlignment.Left)

        'DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        'bind_data()
        'DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        'Me.WindowState = FormWindowState.Maximized

        Dim theDate As Date
        theDate = Format(Now(), "dd-MM-yyyy")
        txt_dateret.Text = theDate

        conn.Open()
        Try
            Dim str As String = "SELECT category FROM tbl_book GROUP BY category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_categooory1.DataSource = dt
                cmb_categooory1.DisplayMember = "category"
                cmb_categooory1.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_categooory1.SelectedIndex = -1
                cmb_categooory1.Refresh()
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

        'txt_reason.Enabled = True
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_authorr1.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        'txt_reason.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
    End Sub



    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_isbnn1.Clear()
        txt_titlee1.Clear()
        txt_authorr1.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_categooory1.SelectedIndex = -1
        txt_pubcom.Clear()
        rb_good.Checked = False
        rb_damaged.Checked = False
        'chb_no.Checked = False
        txt_reason.Clear()
        txt_idno.Clear()
        txt_namee.Clear()
        txt_bookno.Clear()
        txt_pubcom.Clear()
        txt_year.Clear()
        txt_datetoreturn.Clear()
        txt_address.Clear()
        txt_copyright.Clear()
        txt_matname.Clear()
        txt_matno.Clear()

        'txt_num.Clear()
        rb_printed.Checked = False
        rb_nonprinted.Checked = False
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_authorr1.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_reason.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn1.Enabled = True
        txt_titlee1.Enabled = True
        txt_bookno.Enabled = True
        txt_authorr1.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory1.Enabled = True
        txt_reason.Enabled = False
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_authorr1.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_reason.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False

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

    'Private Sub txt_datetoreturn_TextChanged(sender As Object, e As EventArgs) Handles txt_datetoreturn.TextChanged
    '    If txt_datetoreturn.Text < txt_dateret.Text Then
    '        txt_reason.Enabled = False
    '    End If
    'End Sub

    Private Sub txt_bookno_TextChanged(sender As Object, e As EventArgs) Handles txt_bookno.TextChanged

    End Sub

    Private Sub txt_bookno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bookno.KeyPress
        If e.KeyChar = ChrW(13) Then


            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_borrowreturnbooks WHERE booknumber = '" & txt_bookno.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                If data(0) = txt_bookno.Text Then
                    txt_bookno.Text = data(0)
                    txt_bookno.ReadOnly = True
                    txt_isbnn1.Text = data(1)
                    txt_isbnn1.ReadOnly = True
                    txt_titlee1.Text = data(2)
                    txt_titlee1.ReadOnly = True
                    txt_authorr1.Text = data(3)
                    txt_authorr1.ReadOnly = True
                    cmb_ddc.Text = data(4)
                    cmb_categooory1.Text = data(5)
                    'cmb_categooory1.DropDownStyle = True
                    txt_year.Text = data(6)
                    txt_year.ReadOnly = True
                    txt_address.Text = data(8)
                    txt_address.ReadOnly = True
                    txt_copyright.Text = data(9)
                    txt_copyright.ReadOnly = True
                    txt_datetoreturn.Text = data(11)
                    txt_datetoreturn.ReadOnly = True
                    txt_pubcom.Text = data(7)
                    txt_pubcom.ReadOnly = True
                    txt_idno.Text = data(12)
                    txt_idno.ReadOnly = True
                    txt_namee.Text = data(13)
                    txt_namee.ReadOnly = True
                End If
            End If
        End If
        conn.Close()
    End Sub

    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.TextChanged
        Dim currentYear As String = System.DateTime.Now.Year
        If txt_year.Text > currentYear Then
            MsgBox("Invalid Year", MsgBoxStyle.Information)
            txt_year.Clear()
            txt_year.Focus()
        End If
    End Sub

    Private Sub btn_save0_Click(sender As Object, e As EventArgs) Handles btn_save0.Click

        If rb_printed.Checked Then

            If txt_bookno.Text = "" Then
                MsgBox("Please Enter BookNumber", MsgBoxStyle.Critical)
                txt_bookno.Focus()
            ElseIf txt_isbnn1.Text = "" Then
                MsgBox("Please Enter ISBN", MsgBoxStyle.Critical)
                txt_isbnn1.Focus()
            ElseIf txt_titlee1.Text = "" Then
                MsgBox("Please Enter Title", MsgBoxStyle.Critical)
                txt_titlee1.Focus()
            ElseIf txt_authorr1.Text = "" Then
                MsgBox("Please Enter Author", MsgBoxStyle.Critical)
                txt_authorr1.Focus()
            ElseIf cmb_ddc.Text = "" Then
                MsgBox("Please Enter Dewey Decimal Classification", MsgBoxStyle.Critical)
                cmb_ddc.Focus()
            ElseIf cmb_categooory1.Text = "" Then
                MsgBox("Please Enter Category", MsgBoxStyle.Critical)
                cmb_categooory1.Focus()
            ElseIf txt_year.Text = "" Then
                MsgBox("Please Enter Year", MsgBoxStyle.Critical)
                txt_year.Focus()
            ElseIf txt_pubcom.Text = "" Then
                MsgBox("Please Enter Publisher", MsgBoxStyle.Critical)
                txt_pubcom.Focus()
            ElseIf txt_datetoreturn.Text = " " Then
                MsgBox("Please Enter Due Date", MsgBoxStyle.Critical)
                txt_datetoreturn.Focus()
            ElseIf txt_address.Text = "" Then
                MsgBox("Please Enter Address", MsgBoxStyle.Critical)
                txt_address.Focus()
            ElseIf txt_copyright.Text = "" Then
                MsgBox("Please Enter Copyright", MsgBoxStyle.Critical)
                txt_copyright.Focus()
            ElseIf rb_good.Checked = False And rb_damaged.Checked = False Then
                MsgBox("Please Select Material Status", MsgBoxStyle.Critical)

            ElseIf txt_idno.Text = "" Then
                MsgBox("Please Enter No.", MsgBoxStyle.Critical)
                txt_idno.Focus()
            ElseIf txt_namee.Text = "" Then
                MsgBox("Please Enter Name", MsgBoxStyle.Critical)
                txt_namee.Focus()
                'ElseIf txt_num.Text = "(+63)    -    -" Then
                '    MsgBox("Please Enter Number", MsgBoxStyle.Critical)
                '    txt_num.Focus()
            ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                '[VALIDATE BOOK]SELECT BOOK BORROWED FROM TBL_BORROWRETURNBOOKS
                Dim bo As String = "SELECT booknumber,isbn,title,author,deweydecimalclassification,category,yearofpublication,publisher,address,copyright,datetoreturn,username,name from tbl_borrowreturnbooks where booknumber= '" & txt_bookno.Text & "' AND isbn= '" & txt_isbnn1.Text & "' AND title= '" & txt_titlee1.Text & "' AND author= '" & txt_authorr1.Text & "' AND DeweyDecimalClassification= '" & cmb_ddc.Text & "' AND category= '" & cmb_categooory1.Text & "' AND YearofPublication= '" & txt_year.Text & "' AND publisher= '" & txt_pubcom.Text & "' AND address= '" & txt_address.Text & "' AND copyright= '" & txt_copyright.Text & "' AND datetoreturn= '" & txt_datetoreturn.Text & "' AND username= '" & txt_idno.Text & "' AND name= '" & txt_namee.Text & "'"
                Dim commm As New MySqlCommand(bo, conn)
                Dim userCounter As Integer = commm.ExecuteScalar
                Dim da2 As MySqlDataReader = commm.ExecuteReader

                If da2.Read Then
                    If userCounter > 0 Then
                        da2.Close()

                        Dim newitem As New ListViewItem(rb_printed.Text)
                        newitem.SubItems.Add("")
                        newitem.SubItems.Add("")
                        newitem.SubItems.Add(txt_bookno.Text)
                        newitem.SubItems.Add(txt_isbnn1.Text)
                        newitem.SubItems.Add(txt_address.Text)
                        newitem.SubItems.Add(txt_copyright.Text)
                        newitem.SubItems.Add(txt_titlee1.Text)
                        newitem.SubItems.Add(txt_authorr1.Text)
                        newitem.SubItems.Add(txt_year.Text)
                        newitem.SubItems.Add(txt_pubcom.Text)
                        newitem.SubItems.Add(cmb_ddc.Text)
                        newitem.SubItems.Add(cmb_categooory1.Text)
                        newitem.SubItems.Add(txt_datetoreturn.Text)
                        newitem.SubItems.Add(txt_dateret.Text)
                        newitem.SubItems.Add(txt_idno.Text)
                        newitem.SubItems.Add(txt_namee.Text)

                        If rb_good.Checked Then
                            newitem.SubItems.Add(rb_good.Text)

                        ElseIf rb_damaged.Checked Then
                            newitem.SubItems.Add(rb_damaged.Text)
                        End If
                        newitem.SubItems.Add(txt_reason.Text)
                        ListView1.Items.Add(newitem)

                        rb_printed.Checked = False
                        rb_nonprinted.Checked = False
                        txt_matno.Clear()
                        txt_matname.Clear()
                        txt_bookno.Clear()
                        txt_isbnn1.Clear()
                        txt_address.Clear()
                        txt_copyright.Clear()
                        txt_titlee1.Clear()
                        txt_authorr1.Clear()
                        txt_year.Clear()
                        txt_pubcom.Clear()
                        cmb_ddc.ResetText()
                        cmb_categooory1.ResetText()
                        txt_idno.Clear()
                        txt_namee.Clear()
                        txt_datetoreturn.Clear()
                        rb_damaged.Checked = False
                        rb_good.Checked = False
                        txt_reason.Clear()
                        txt_reason.Enabled = False
                        cmb_ddc.SelectedIndex = -1
                        cmb_categooory1.SelectedIndex = -1
                        txt_matname.Enabled = True
                        txt_matno.Enabled = True
                        txt_isbnn1.Enabled = True
                        txt_titlee1.Enabled = True
                        txt_bookno.Enabled = True
                        txt_authorr1.Enabled = True
                        txt_year.Enabled = True
                        txt_address.Enabled = True
                        txt_copyright.Enabled = True
                        txt_pubcom.Enabled = True
                        cmb_ddc.Enabled = True
                        cmb_categooory1.Enabled = True
                        txt_reason.Enabled = False
                        txt_isbnn1.ReadOnly = False
                        txt_titlee1.ReadOnly = False
                        txt_authorr1.ReadOnly = False
                        txt_year.ReadOnly = False
                        txt_pubcom.ReadOnly = False
                        txt_datetoreturn.ReadOnly = False
                        txt_reason.ReadOnly = False
                        txt_namee.ReadOnly = False
                        txt_idno.ReadOnly = False
                        txt_matno.ReadOnly = False
                        txt_matname.ReadOnly = False
                        txt_bookno.ReadOnly = False
                        txt_address.ReadOnly = False
                        txt_copyright.ReadOnly = False
                    End If
                Else
                    MsgBox("Book not found!", MsgBoxStyle.Critical)
                End If
            End If
            txt_matname.Enabled = True
            txt_matno.Enabled = True
            txt_isbnn1.Enabled = True
            txt_titlee1.Enabled = True
            txt_bookno.Enabled = True
            txt_authorr1.Enabled = True
            txt_year.Enabled = True
            txt_address.Enabled = True
            txt_copyright.Enabled = True
            txt_pubcom.Enabled = True
            cmb_ddc.Enabled = True
            cmb_categooory1.Enabled = True
            txt_reason.Enabled = False
            txt_isbnn1.ReadOnly = False
            txt_titlee1.ReadOnly = False
            txt_authorr1.ReadOnly = False
            txt_year.ReadOnly = False
            txt_pubcom.ReadOnly = False
            txt_datetoreturn.ReadOnly = False
            txt_reason.ReadOnly = False
            txt_namee.ReadOnly = False
            txt_idno.ReadOnly = False
            txt_matno.ReadOnly = False
            txt_matname.ReadOnly = False
            txt_bookno.ReadOnly = False
            txt_address.ReadOnly = False
            txt_copyright.ReadOnly = False

        ElseIf rb_nonprinted.Checked Then

            If txt_matno.Text = "" Then
                MsgBox("Please Enter Material Number", MsgBoxStyle.Critical)
                txt_matno.Focus()
            ElseIf txt_matname.Text = "" Then
                MsgBox("Please Material Name", MsgBoxStyle.Critical)
                txt_matname.Focus()
            ElseIf txt_datetoreturn.Text = "" Then
                MsgBox("Please Due Date", MsgBoxStyle.Critical)
                txt_datetoreturn.Focus()
            ElseIf txt_idno.Text = "" Then
                MsgBox("Please Enter No.", MsgBoxStyle.Critical)
                txt_idno.Focus()
            ElseIf txt_namee.Text = "" Then
                MsgBox("Please Enter Name", MsgBoxStyle.Critical)
                txt_namee.Focus()

            ElseIf MsgBox("Are you sure you want to add this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                '[VALIDATE BOOK]SELECT MATERIAL BORROWED FROM TBL_BORROWRETURNNONPRINTED
                Dim bo1 As String = "SELECT materialnumber,materialname,datetoreturn,username,name from tbl_borrowreturnnonprinted where materialnumber= '" & txt_matno.Text & "' AND materialname= '" & txt_matname.Text & "' AND datetoreturn= '" & txt_datetoreturn.Text & "' AND username= '" & txt_idno.Text & "' AND name= '" & txt_namee.Text & "'"
                Dim commm1 As New MySqlCommand(bo1, conn)
                Dim userCounter1 As Integer = commm1.ExecuteScalar
                Dim da21 As MySqlDataReader = commm1.ExecuteReader

                If da21.Read Then
                    If userCounter1 > 0 Then
                        da21.Close()

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
                        newitem.SubItems.Add(txt_datetoreturn.Text)
                        newitem.SubItems.Add(txt_dateret.Text)
                        newitem.SubItems.Add(txt_idno.Text)
                        newitem.SubItems.Add(txt_namee.Text)

                        If rb_good.Checked Then
                            newitem.SubItems.Add(rb_good.Text)

                        ElseIf rb_damaged.Checked Then
                            newitem.SubItems.Add(rb_damaged.Text)
                        End If
                        newitem.SubItems.Add(txt_reason.Text)
                        ListView1.Items.Add(newitem)

                        rb_printed.Checked = False
                        rb_nonprinted.Checked = False
                        txt_matno.Clear()
                        txt_matname.Clear()
                        txt_bookno.Clear()
                        txt_isbnn1.Clear()
                        txt_address.Clear()
                        txt_copyright.Clear()
                        txt_titlee1.Clear()
                        txt_authorr1.Clear()
                        txt_year.Clear()
                        txt_pubcom.Clear()
                        cmb_ddc.ResetText()
                        cmb_categooory1.ResetText()
                        txt_idno.Clear()
                        txt_namee.Clear()
                        txt_datetoreturn.Clear()
                        rb_damaged.Checked = False
                        rb_good.Checked = False
                        txt_reason.Clear()
                        txt_reason.Enabled = False


                        cmb_ddc.SelectedIndex = -1
                        cmb_categooory1.SelectedIndex = -1
                        txt_matname.Enabled = True
                        txt_matno.Enabled = True
                        txt_isbnn1.Enabled = True
                        txt_titlee1.Enabled = True
                        txt_bookno.Enabled = True
                        txt_authorr1.Enabled = True
                        txt_year.Enabled = True
                        txt_address.Enabled = True
                        txt_copyright.Enabled = True
                        txt_pubcom.Enabled = True
                        cmb_ddc.Enabled = True
                        cmb_categooory1.Enabled = True
                        txt_reason.Enabled = False
                        txt_isbnn1.ReadOnly = False
                        txt_titlee1.ReadOnly = False
                        txt_authorr1.ReadOnly = False
                        txt_year.ReadOnly = False
                        txt_pubcom.ReadOnly = False
                        txt_datetoreturn.ReadOnly = False
                        txt_reason.ReadOnly = False
                        txt_namee.ReadOnly = False
                        txt_idno.ReadOnly = False
                        txt_matno.ReadOnly = False
                        txt_matname.ReadOnly = False
                        txt_bookno.ReadOnly = False
                        txt_address.ReadOnly = False
                        txt_copyright.ReadOnly = False
                    End If
                Else
                    MsgBox("Material not found!", MsgBoxStyle.Critical)
                End If
            End If
        End If
        txt_matname.Enabled = True
        txt_matno.Enabled = True
        txt_isbnn1.Enabled = True
        txt_titlee1.Enabled = True
        txt_bookno.Enabled = True
        txt_authorr1.Enabled = True
        txt_year.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory1.Enabled = True
        txt_reason.Enabled = False
        txt_isbnn1.ReadOnly = False
        txt_titlee1.ReadOnly = False
        txt_authorr1.ReadOnly = False
        txt_year.ReadOnly = False
        txt_pubcom.ReadOnly = False
        txt_datetoreturn.ReadOnly = False
        txt_reason.ReadOnly = False
        txt_namee.ReadOnly = False
        txt_idno.ReadOnly = False
        txt_matno.ReadOnly = False
        txt_matname.ReadOnly = False
        txt_bookno.ReadOnly = False
        txt_address.ReadOnly = False
        txt_copyright.ReadOnly = False
    End Sub

    Private Sub rb_printed_CheckedChanged(sender As Object, e As EventArgs) Handles rb_printed.CheckedChanged
        txt_bookno.Focus()
        txt_bookno.Enabled = True
        txt_isbnn1.Enabled = True
        txt_address.Enabled = True
        txt_copyright.Enabled = True
        txt_titlee1.Enabled = True
        txt_authorr1.Enabled = True
        txt_year.Enabled = True
        txt_pubcom.Enabled = True
        cmb_ddc.Enabled = True
        cmb_categooory1.Enabled = True
        txt_matno.Enabled = False
        txt_matname.Enabled = False
    End Sub

    Private Sub rb_nonprinted_CheckedChanged(sender As Object, e As EventArgs) Handles rb_nonprinted.CheckedChanged
        txt_matno.Focus()
        txt_bookno.Enabled = False
        txt_isbnn1.Enabled = False
        txt_address.Enabled = False
        txt_copyright.Enabled = False
        txt_titlee1.Enabled = False
        txt_authorr1.Enabled = False
        txt_year.Enabled = False
        txt_pubcom.Enabled = False
        cmb_ddc.Enabled = False
        cmb_categooory1.Enabled = False
        txt_matno.Enabled = True
        txt_matname.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If MsgBox("Are you sure you want to borrow these materials?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            For Each lvitem As ListViewItem In ListView1.Items

                If lvitem.SubItems(0).Text = "Printed" Then 'save to tbl_returnedbooks
                    Dim conn As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds As New MySqlCommand("Insert Into tbl_returnedbooks (BookNumber,ISBN,Title,Author,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,DateReturned,Username,Name) VALUES (@BookNumber,@ISBN,@Title,@Author,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@DateReturned,@Username,@Name)", conn)
                    cmmds.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                    cmmds.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                    cmmds.Parameters.AddWithValue("@Title", lvitem.SubItems(5).Text)
                    cmmds.Parameters.AddWithValue("@Author", lvitem.SubItems(6).Text)
                    cmmds.Parameters.AddWithValue("@Classification", lvitem.SubItems(11).Text)
                    cmmds.Parameters.AddWithValue("@Category", lvitem.SubItems(12).Text)
                    cmmds.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(7).Text)
                    cmmds.Parameters.AddWithValue("@Publisher", lvitem.SubItems(8).Text)
                    cmmds.Parameters.AddWithValue("@Address", lvitem.SubItems(9).Text)
                    cmmds.Parameters.AddWithValue("@Copyright", lvitem.SubItems(10).Text)
                    cmmds.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(14).Text)
                    cmmds.Parameters.AddWithValue("@Username", lvitem.SubItems(15).Text)
                    cmmds.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                    conn.Open()
                    cmmds.ExecuteNonQuery()
                    conn.Close()

                    If lvitem.SubItems(16).Text = "Damaged" Then 'save to tbl_damagedbooks
                        Dim conn2 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds2 As New MySqlCommand("Insert Into tbl_damagedbooks (BookNumber,ISBN,Title,Author,DeweyDecimalClassification,Category,YearofPublication,Publisher,Address,Copyright,Name,DateReturned) VALUES (@BookNumber,@ISBN,@Title,@Author,@Classification,@Category,@YearofPublication,@Publisher,@Address,@Copyright,@Name,@DateReturned)", conn2)
                        cmmds2.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds2.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                        cmmds2.Parameters.AddWithValue("@Title", lvitem.SubItems(5).Text)
                        cmmds2.Parameters.AddWithValue("@Author", lvitem.SubItems(6).Text)
                        cmmds2.Parameters.AddWithValue("@Classification", lvitem.SubItems(11).Text)
                        cmmds.Parameters.AddWithValue("@Category", lvitem.SubItems(12).Text)
                        cmmds2.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(7).Text)
                        cmmds2.Parameters.AddWithValue("@Publisher", lvitem.SubItems(8).Text)
                        cmmds2.Parameters.AddWithValue("@Address", lvitem.SubItems(9).Text)
                        cmmds2.Parameters.AddWithValue("@Copyright", lvitem.SubItems(10).Text)
                        cmmds2.Parameters.AddWithValue("@Name", lvitem.SubItems(16).Text)
                        cmmds2.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(14).Text)
                        conn2.Open()
                        cmmds2.ExecuteNonQuery()
                        conn2.Close()
                    End If

                    If lvitem.SubItems(12).Text < lvitem.SubItems(13).Text Then
                        Dim conn4 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds4 As New MySqlCommand("Insert Into tbl_overduebooks (BookNumber,ISBN,Title,Author,DeweyDecimalClassification,Category,YearofPublication,DatetoReturn,DateReturned) VALUES (@BookNumber,@ISBN,@Title,@Author,@Classification,@Category,@YearofPublication,@DatetoReturn,@DateReturned)", conn4)
                        cmmds4.Parameters.AddWithValue("@BookNumber", lvitem.SubItems(3).Text)
                        cmmds4.Parameters.AddWithValue("@ISBN", lvitem.SubItems(4).Text)
                        cmmds4.Parameters.AddWithValue("@Title", lvitem.SubItems(6).Text)
                        cmmds4.Parameters.AddWithValue("@Author", lvitem.SubItems(7).Text)
                        cmmds4.Parameters.AddWithValue("@Classification", lvitem.SubItems(10).Text)
                        cmmds4.Parameters.AddWithValue("@YearofPublication", lvitem.SubItems(8).Text)
                        cmmds4.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(12).Text)
                        cmmds4.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                        conn4.Open()
                        cmmds4.ExecuteNonQuery()
                        conn4.Close()

                        Dim conn5 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds5 As New MySqlCommand("Insert Into tbl_delinquentborrowers (ItemNumber,Username,Name,DatetoReturn,DateReturned,Reason) VALUES (@ItemNumber,@Username,@Name,@DatetoReturn,@DateReturned,@Reason)", conn5)
                        cmmds5.Parameters.AddWithValue("@ItemNumber", lvitem.SubItems(3).Text)
                        cmmds5.Parameters.AddWithValue("@Username", lvitem.SubItems(14).Text)
                        cmmds5.Parameters.AddWithValue("@Name", lvitem.SubItems(15).Text)
                        cmmds5.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(12).Text)
                        cmmds5.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                        cmmds5.Parameters.AddWithValue("@Reason", lvitem.SubItems(17).Text)
                        conn5.Open()
                        cmmds5.ExecuteNonQuery()
                        conn5.Close()
                    End If

                    Dim conn8 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds8 As New MySqlCommand("Update tbl_book set status = 'Available' where BookNumber= '" & lvitem.SubItems(3).Text & "' ", conn8)
                    conn8.Open()
                    cmmds8.ExecuteNonQuery()
                    conn8.Close()

                    Dim conn9 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds9 As New MySqlCommand("delete from tbl_borrowreturnbooks where BookNumber= '" & lvitem.SubItems(3).Text & "' ", conn9)
                    conn9.Open()
                    cmmds9.ExecuteNonQuery()
                    conn9.Close()

                ElseIf lvitem.SubItems(0).Text = "Non-Printed" Then 'save to tbl_returnednonprinted
                    Dim conn1 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds1 As New MySqlCommand("Insert Into tbl_returnednonprinted (MaterialNumber,MaterialName,DateReturned,Username,Name) VALUES (@MaterialNumber,@MaterialName,@DateReturned,@Username,@Name)", conn1)
                    cmmds1.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                    cmmds1.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                    cmmds1.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                    cmmds1.Parameters.AddWithValue("@Username", lvitem.SubItems(14).Text)
                    cmmds1.Parameters.AddWithValue("@Name", lvitem.SubItems(15).Text)
                    conn1.Open()
                    cmmds1.ExecuteNonQuery()
                    conn1.Close()

                    If lvitem.SubItems(16).Text = "Damaged" Then 'save to tbl_damagednonprinted
                        Dim conn3 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds3 As New MySqlCommand("Insert Into tbl_damagednonprinted (MaterialNumber,MaterialName,Name,DateReturned) VALUES (@MaterialNumber,@MaterialName,@Name,@DateReturned)", conn3)
                        cmmds3.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds3.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds3.Parameters.AddWithValue("@Name", lvitem.SubItems(15).Text)
                        cmmds3.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                        conn3.Open()
                        cmmds3.ExecuteNonQuery()
                        conn3.Close()
                    End If

                    If lvitem.SubItems(12).Text < lvitem.SubItems(13).Text Then
                        Dim conn6 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds6 As New MySqlCommand("Insert Into tbl_overduenonprinted (MaterialNumber,MaterialName,DatetoReturn,DateReturned) VALUES (@MaterialNumber,@MaterialName,@DatetoReturn,@DateReturned)", conn6)
                        cmmds6.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds6.Parameters.AddWithValue("@MaterialName", lvitem.SubItems(2).Text)
                        cmmds6.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(12).Text)
                        cmmds6.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                        conn6.Open()
                        cmmds6.ExecuteNonQuery()
                        conn6.Close()



                        Dim conn7 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                        Dim cmmds7 As New MySqlCommand("Insert Into tbl_delinquentborrowers (ItemNumber,Username,Name,DatetoReturn,DateReturned,Reason) VALUES (@MaterialNumber,@Username,@Name,@DatetoReturn,@DateReturned,@Reason)", conn7)
                        cmmds7.Parameters.AddWithValue("@MaterialNumber", lvitem.SubItems(1).Text)
                        cmmds7.Parameters.AddWithValue("@Username", lvitem.SubItems(14).Text)
                        cmmds7.Parameters.AddWithValue("@Name", lvitem.SubItems(15).Text)
                        cmmds7.Parameters.AddWithValue("@DatetoReturn", lvitem.SubItems(12).Text)
                        cmmds7.Parameters.AddWithValue("@DateReturned", lvitem.SubItems(13).Text)
                        cmmds7.Parameters.AddWithValue("@Reason", lvitem.SubItems(17).Text)
                        conn7.Open()
                        cmmds7.ExecuteNonQuery()
                        conn7.Close()
                    End If

                    Dim conn10 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds10 As New MySqlCommand("Update tbl_nonprinted set status = 'Available' where MaterialNumber= '" & lvitem.SubItems(1).Text & "' ", conn10)
                    conn10.Open()
                    cmmds10.ExecuteNonQuery()
                    conn10.Close()

                    Dim conn11 As New MySqlConnection("server=localhost; uid=root;database=db_system")
                    Dim cmmds11 As New MySqlCommand("delete from tbl_borrowreturnnonprinted where MaterialNumber= '" & lvitem.SubItems(1).Text & "' ", conn11)
                    conn11.Open()
                    cmmds11.ExecuteNonQuery()
                    conn11.Close()

                End If
            Next
            MsgBox("Returned successfully", MsgBoxStyle.Information)
            ListView1.Items.Clear()
            AdminMainForms.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub txt_datetoreturn_TextChanged(sender As Object, e As EventArgs) Handles txt_datetoreturn.TextChanged

        If txt_datetoreturn.Text < txt_dateret.Text Then
            txt_reason.Enabled = True

        ElseIf txt_datetoreturn.Text > txt_dateret.Text Then
            txt_reason.Enabled = False

        ElseIf txt_datetoreturn.Text = "" Then
            txt_reason.Enabled = False
        End If
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

    Private Sub txt_bookno_Click(sender As Object, e As EventArgs) Handles txt_bookno.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_classnum_Click(sender As Object, e As EventArgs)
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_isbnn1_Click(sender As Object, e As EventArgs) Handles txt_isbnn1.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_titlee1_Click(sender As Object, e As EventArgs) Handles txt_titlee1.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txt_authorr1_Click(sender As Object, e As EventArgs) Handles txt_authorr1.Click
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

    Private Sub txt_datetoreturn_Click(sender As Object, e As EventArgs) Handles txt_datetoreturn.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_idno_Click(sender As Object, e As EventArgs) Handles txt_idno.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_namee_Click(sender As Object, e As EventArgs) Handles txt_namee.Click
        If rb_printed.Checked = False And rb_nonprinted.Checked = False Then
            MsgBox("Please Select Material", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub txt_matno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matno.KeyPress
        If e.KeyChar = ChrW(13) Then


            conn.Open()
            Dim qstr As String = "SELECT * FROM tbl_borrowreturnnonprinted WHERE materialnumber = '" & txt_matno.Text & "'"
            Dim cmd As New MySqlCommand(qstr, conn)
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                If data(0) = txt_matno.Text Then
                    txt_matno.Text = data(0)
                    txt_matno.ReadOnly = True
                    txt_matname.Text = data(1)
                    txt_matname.ReadOnly = True
                    txt_datetoreturn.Text = data(3)
                    txt_datetoreturn.ReadOnly = True
                    txt_idno.Text = data(4)
                    txt_idno.ReadOnly = True
                    txt_namee.Text = data(5)
                    txt_namee.ReadOnly = True
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