Imports MySql.Data.MySqlClient
Public Class CategoryManagement2
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cmb_category.Text = ""
        cmb_category.SelectedIndex = -1
        txt_categoryid.Clear()
        txt_days.Clear()
        txt_days.Text = ""
        txt_categoryid.Text = ""
        AdminMainForms.Show()
        Me.Hide()
    End Sub

    Private Sub CategoryManagement2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmb_category.SelectedItem = Nothing Then
            txt_categoryid.Clear()
            txt_days.Clear()
            txt_days.Text = ""
            txt_categoryid.Text = ""
        End If

        cmb_category.Text = ""
        cmb_category.SelectedIndex = -1
        txt_categoryid.Clear()
        txt_days.Clear()
        txt_days.Text = ""
        txt_categoryid.Text = ""
        conn.Open()
        Try
            Dim str As String = "Select category FROM tbl_category"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb_category.DataSource = dt
                cmb_category.DisplayMember = "category"
                cmb_category.ValueMember = ""
                'cmb_category.DataSource = dt
                cmb_category.SelectedIndex = -1
                cmb_category.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        conn.Open()

        If cmb_category.Text = "" Then
            MsgBox("Please Select Category", MsgBoxStyle.Critical)
            cmb_category.Focus()
        ElseIf txt_days.Text = "" Then
            MsgBox("Please Enter Days to Borrow", MsgBoxStyle.Critical)
            txt_days.Focus()
        ElseIf MsgBox("Are you sure you want To save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim qstr100 As String = "UPDATE tbl_category Set Category='" & cmb_category.Text & "' , DaystoBorrow='" & txt_days.Text & "' WHERE category_id = '" & txt_categoryid.Text & "'"
            Dim cmd100 As New MySqlCommand(qstr100, conn)
            Dim dat100 As MySqlDataReader = cmd100.ExecuteReader
            dat100.Close()

            MsgBox("Category has been Updated!", MsgBoxStyle.Information)
            cmb_category.SelectedIndex = -1
            cmb_category.SelectedItem = ""
            txt_categoryid.Clear()
            txt_days.Clear()
            txt_days.Text = ""
            txt_categoryid.Text = ""
            AdminMainForms.Show()
            Me.Hide()
        End If
        conn.Close()
    End Sub

    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim qstr1 As String = "SELECT * FROM tbl_category WHERE category = '" & cmb_category.Text & "'"
        Dim cmd1 As New MySqlCommand(qstr1, conn)
        Dim data1 As MySqlDataReader = cmd1.ExecuteReader
        If data1.Read Then
            If cmb_category.SelectedIndex = -1 Then
                txt_categoryid.Clear()
                txt_days.Clear()
                txt_days.Text = ""
                txt_categoryid.Text = ""
            ElseIf data1(1) = cmb_category.Text Then
                txt_categoryid.Text = data1(0)
                cmb_category.Text = data1(1)
                cmb_category.Focus()
                txt_days.Text = data1(2)
            End If
        End If
        conn.Close()
    End Sub
    Private Sub txt_days_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_days.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
        Else
            If e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9" Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class