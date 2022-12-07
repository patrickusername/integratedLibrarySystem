Imports MySql.Data.MySqlClient
Public Class TeacherMainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Ask As MsgBoxResult = MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel)
        If Ask = MsgBoxResult.Ok Then
            Form1.Show()
            Me.Hide()
            Form1.txt_uname.Clear()
            Form1.txt_pword.Clear()
            Form1.txt_uname.Focus()
        End If
    End Sub

    Private Sub BorrowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowersToolStripMenuItem.Click
        ClassBorrower.MdiParent = Me
        ClassBorrower.Show()
    End Sub

    Private Sub UpdateNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateNToolStripMenuItem.Click
        ''Refresh DataTable
        'Dim cmddd As New MySqlCommand("Select * From Tbl_faculty", conn)
        'Dim daw As New MySqlDataAdapter
        'daw.SelectCommand = cmddd
        'Dim dt As New DataTable
        'dt.Clear()
        'daw.Fill(dt)


        ''Refresh DataTable
        'Dim cmddd1 As New MySqlCommand("Select * From Tbl_Users", conn)
        'Dim daw1 As New MySqlDataAdapter
        'daw1.SelectCommand = cmddd1
        'Dim dt1 As New DataTable
        'dt1.Clear()
        'daw1.Fill(dt1)

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim qstr As String = "SELECT * FROM tbl_faculty WHERE Name = '" & lbl_name.Text & "'"
        Dim cmd1 As New MySqlCommand(qstr, conn)
        Dim data As MySqlDataReader = cmd1.ExecuteReader
        If data.Read Then
            If data(1) = lbl_name.Text Then
                Update_Faculty.txt_studuname.Text = data(0)
                Update_Faculty.txt_studname.Text = data(1)
                Update_Faculty.txt_studcontact.Text = data(2)
                Update_Faculty.txt_advisory.Text = data(3)
                Update_Faculty.txt_studpword.Text = data(4)
                'Update_Faculty.MdiParent = Me
                Update_Faculty.Show()
            End If
            conn.Close()
        End If
    End Sub
    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        SearchBook2.MdiParent = Me
        SearchBook2.Show()
        SearchBook2.txt_isbn1.Focus()
    End Sub

    Private Sub NonPrintedMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialToolStripMenuItem.Click
        SearchNonPrinted2.MdiParent = Me
        SearchNonPrinted2.Show()
        SearchNonPrinted2.txt_isbn1.Focus()
    End Sub

    Private Sub TeacherMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        UserManualForm.MdiParent = Me
        UserManualForm.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        UserManualForm.MdiParent = Me
        UserManualForm.Show()
    End Sub
    Private Sub PrintedMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintedMaterialsToolStripMenuItem.Click
        UnreturnedBooks.MdiParent = Me
        UnreturnedBooks.Show()
    End Sub

    Private Sub NonPrintedMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialsToolStripMenuItem.Click
        UnreturnedMaterials.MdiParent = Me
        UnreturnedMaterials.Show()
    End Sub
End Class