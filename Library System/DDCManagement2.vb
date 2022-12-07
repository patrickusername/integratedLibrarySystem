Imports MySql.Data.MySqlClient
Public Class DDCManagement2
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cmb_ddc.Text = ""
        cmb_ddc.SelectedIndex = -1
        txt_ddcid.Clear()
        AdminMainForms.Show()
        Me.Hide()
    End Sub

    Private Sub DDCManagement2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txt_ddcid.Clear()
        cmb_ddc.SelectedIndex = -1
        cmb_ddc.SelectedItem = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        conn.Open()

        If cmb_ddc.Text = "" Then
            MsgBox("Please Select Dewey Decimal Classification", MsgBoxStyle.Critical)
            cmb_ddc.Focus()
        ElseIf MsgBox("Are you sure you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim qstr100 As String = "UPDATE tbl_ddc SET DeweyDecimalClassification='" & cmb_ddc.Text & "' WHERE ddc_id = '" & txt_ddcid.Text & "'"
            Dim cmd100 As New MySqlCommand(qstr100, conn)
            Dim dat100 As MySqlDataReader = cmd100.ExecuteReader
            dat100.Close()

            'Dim qstr As String = "UPDATE tbl_book SET DeweyDecimalClassification='" & cmb_ddc.Text & "' WHERE Deweydecimalclassification = '" & cmb_ddc.Text & "'"
            'Dim cm As New MySqlCommand(qstr, conn)
            'Dim dat As MySqlDataReader = cm.ExecuteReader
            'dat.Close()

            MsgBox("Dewey Decimal Classification has been Updated!", MsgBoxStyle.Information)
            cmb_ddc.SelectedIndex = -1
            cmb_ddc.SelectedItem = ""
            txt_ddcid.Clear()
            AdminMainForms.Show()
            Me.Hide()
        End If
        conn.Close()
    End Sub

    Private Sub cmb_ddc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ddc.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim qstr1 As String = "SELECT * FROM tbl_ddc WHERE deweydecimalclassification = '" & cmb_ddc.Text & "'"
        Dim cmd1 As New MySqlCommand(qstr1, conn)
        Dim data1 As MySqlDataReader = cmd1.ExecuteReader
        If data1.Read Then
            If cmb_ddc.Text = "" Then
                txt_ddcid.Clear()
            ElseIf data1(1) = cmb_ddc.Text Then
                txt_ddcid.Text = data1(0)
                cmb_ddc.Text = data1(1)
            End If
        End If
        conn.Close()
    End Sub
End Class