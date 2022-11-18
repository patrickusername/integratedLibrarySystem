Imports MySql.Data.MySqlClient
Public Class Main_Form

    'Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
    '    Searchhhhhh.MdiParent = Me
    '    Searchhhhhh.Show()
    '    Searchhhhhh.txt_isbn1.Focus()

    'End Sub

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

    Private Sub UpdateInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInformationToolStripMenuItem.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim qstr As String = "SELECT * FROM tbl_student WHERE Name = '" & lbl_name.Text & "'"
        Dim cmd1 As New MySqlCommand(qstr, conn)
        Dim data As MySqlDataReader = cmd1.ExecuteReader
        If data.Read Then
            If data(1) = lbl_name.Text Then
                Update_Student.txt_studuname.Text = data(0)
                Update_Student.txt_studname.Text = data(1)
                Update_Student.txt_studcontact.Text = data(2)
                Update_Student.txt_studgs.Text = data(3)
                Update_Student.txt_studtea.Text = data(4)
                Update_Student.txt_studpword.Text = data(5)
                'Update_Student.MdiParent = Me
                Update_Student.Show()
            End If
            conn.Close()
            'Update_Student.txt_studname.Focus()
        End If
    End Sub

    'Private Sub ViewNonPrintedMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewNonPrintedMaterialsToolStripMenuItem.Click
    '    ViewNonPrinted3.MdiParent = Me
    '    ViewNonPrinted3.Show()

    'End Sub

    'Private Sub ViewBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBooksToolStripMenuItem.Click
    '    ViewBook3.MdiParent = Me
    '    ViewBook3.Show()
    'End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'SearchBook3.MdiParent = Me
        'SearchBook3.Show()
        'SearchBook3.txt_isbn1.Focus()
    End Sub

    Private Sub SearchToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        SearchNonPrinted3.MdiParent = Me
        SearchNonPrinted3.Show()
        SearchNonPrinted3.txt_isbn1.Focus()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        SearchBook3.MdiParent = Me
        SearchBook3.Show()
        SearchBook3.txt_isbn1.Focus()
    End Sub

    Private Sub NonPrintedMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonPrintedMaterialToolStripMenuItem.Click
        SearchNonPrinted3.MdiParent = Me
        SearchNonPrinted3.Show()
        SearchNonPrinted3.txt_isbn1.Focus()
    End Sub
End Class