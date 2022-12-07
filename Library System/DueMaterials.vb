Imports MySql.Data.MySqlClient
Public Class DueMaterials

    Dim message As String
    Dim contNum As String
    Dim frmSendSMS As New SendMessage

    Private Sub bind_data()
        Dim conn As New MySqlConnection("server=localhost;uid=root;Database=db_system;Integrated security=true;")
        Dim cmd As New MySqlCommand("Select BookNumber, Title, DateBorrowed, DatetoReturn, Username, Name, ContactNo From tbl_borrowreturnbooks Union All Select MaterialNumber, MaterialName, DateBorrowed, DatetoReturn, Username, Name, ContactNo from tbl_borrowreturnnonprinted", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.ClearSelection()

        DataGridView1.Columns(0).HeaderText = "Material Number"
        DataGridView1.Columns(1).HeaderText = "Material Name"
        DataGridView1.Columns(2).HeaderText = "Date Borrowed"
        DataGridView1.Columns(3).HeaderText = "Date to Return"
        DataGridView1.Columns(6).HeaderText = "Contact Number"
    End Sub
    Private Sub DueMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        'DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        'Dim conn As New MySqlConnection(connString)
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("Select BookNumber, ISBN, Title, DateBorrowed, DateToReturn, Username, name, contactno from tbl_borrowreturnbooks WHERE datetoreturn>='" & DateTime.Now().ToString("yyyy-MM-dd") & "'", conn)
        'dt.Clear()
        'da.Fill(dt)
        'DataGridView1.DataSource = dt
        'DataGridView1.ClearSelection()
        Me.Refresh()
        bind_data()
        DataGridView1.Refresh()
        DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Me.Hide()
        frmSendSMS.smContactNumber = contNum
        frmSendSMS.smTextMessage = message
        frmSendSMS.Show()
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Try
    '        Dim index = e.RowIndex

    '        Dim contNumStr As String = DataGridView1.Rows(index).Cells(6).Value.ToString()
    '        Dim contNumTmp = contNumStr.Replace("-", "")
    '        contNumTmp = contNumTmp.Replace("(+63)", "+63")
    '        contNumTmp = contNumTmp.Replace(" ", "")

    '        Dim name As String = DataGridView1.Rows(index).Cells(5).Value.ToString()
    '        Dim dtb As String = DataGridView1.Rows(index).Cells(2).Value.ToString()
    '        Dim dtr As String = DataGridView1.Rows(index).Cells(3).Value.ToString()
    '        Dim sliceDr = dtr.Substring(0, 10).Split("/")
    '        'Dim dateReturned = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
    '        'Dim dateBorrowed = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
    '        Dim tmpMessage = String.Format(smsTemplate, name, dtb, dtr)

    '        'MsgBox(contNumStr)

    '        message = tmpMessage
    '        contNum = contNumTmp
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        DataGridView1.ClearSelection()
        AdminMainForms.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Try
        Dim index = e.RowIndex

        Dim contNumStr As String = DataGridView1.Rows(index).Cells(6).Value.ToString()
        Dim contNumTmp = contNumStr.Replace("-", "")
        contNumTmp = contNumTmp.Replace("(+63)", "+63")
        contNumTmp = contNumTmp.Replace(" ", "")

        Dim name As String = DataGridView1.Rows(index).Cells(5).Value.ToString()
        Dim dtb As String = DataGridView1.Rows(index).Cells(2).Value.ToString()
        Dim dtr As String = DataGridView1.Rows(index).Cells(3).Value.ToString()
        Dim sliceDr = dtr.Substring(0, 10).Split("/")
        'Dim dateReturned = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
        'Dim dateBorrowed = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
        Dim tmpMessage = String.Format(smsTemplate, name, dtb, dtr)

        'MsgBox(contNumStr)

        message = tmpMessage
        contNum = contNumTmp
        'Catch ex As Exception
        'End Try
    End Sub
End Class