Public Class UserManualForm
    Private Sub usermanual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'Dim keywords As New AutoCompleteStringCollection
        'keywords.Add("How to")
        'keywords.Add("borrow")
        'keywords.Add("search")
        'keywords.Add("add book")
        'keywords.Add("printed")
        'keywords.Add("non-printed")
        'keywords.Add("student")
        'keywords.Add("generate report")

        'txt_search.AutoCompleteCustomSource = keywords
        'txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txt_search.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub btn_manage_Click(sender As Object, e As EventArgs) Handles btn_manage.Click
        'UM_manage.Show()
        'switchPanel(UM_manage)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Clear()
        UM_Manage.Show()
        switchPanel(UM_Manage)
        UM_Manage.gb_nonp.Show()
        UM_Manage.gb_nonprinted.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox2.Clear()
        UM_Borrow.Show()
        switchPanel(UM_Borrow)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.ToString = "Printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "PRINTED" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "Add Printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "add printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "ADD PRINTED" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_update.Focus()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.lbl_q1.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "Update Printed" Then
            switchPanel(UM_Manage)
            UM_Manage.gb_update.Focus()
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.lbl_q1.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "update printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_update.Show()
            'UM_Manage.gb_update.Focus()
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.lbl_q1.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "UPDATE PRINTED" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_search.Hide()
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "HOW TO UPDATE PRINTED" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to update printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to update printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "HOW TO UPDATE PRINTED MATERIAL" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to update printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to update printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to add printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to add printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Manage" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "manage" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "MANAGE" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Manage inventory" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "manage invenotory" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "MANAGE INVENTORY" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Manage Printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "manage printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "MANAGE PRINTED" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_nonp.Hide()
            'UM_Manage.gb_nonprinted.Hide()
        ElseIf TextBox2.Text.ToString = "Manage Non-Printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_nonp.Show()
            'UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "manage non-printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_nonp.Show()
            'UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "MANAGE NON-PRINTED" Then
            UM_Manage.gb_printed.Hide()
            UM_Manage.gb_update.Hide()
            UM_Manage.gb_nonp.Show()
            UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "Non-Printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_nonp.Show()
            'UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "non-printed" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_nonp.Show()
            'UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "NON-PRINTED" Then
            switchPanel(UM_Manage)
            'UM_Manage.gb_printed.Hide()
            'UM_Manage.gb_update.Hide()
            'UM_Manage.gb_nonp.Show()
            'UM_Manage.gb_nonprinted.Show()
        ElseIf TextBox2.Text.ToString = "UPDATE NON-PRINTED" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Update non-printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "update non-printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "HOW TO UPDATE NON-PRINTED" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to update non-printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to update non-printed" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "HOW TO UPDATE NON-PRINTED MATERIAL" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to update non-printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to update non-printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to add non-printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to add non-printed material" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "add book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Add book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to add book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to add book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "update book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "Update book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "how to update book" Then
            switchPanel(UM_Manage)
        ElseIf TextBox2.Text.ToString = "How to update book" Then
            switchPanel(UM_Manage)

        ElseIf TextBox2.Text.ToString = "Borrow" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "BORROW" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "borrow" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "Borrow material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "BORROW material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "borrow material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "Borrow printed material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "BORROW PRINTED MATERIAL" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "borrow printed material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "Borrow non-printed material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "BORROW non-printed material" Then
            switchPanel(UM_Borrow)
        ElseIf TextBox2.Text.ToString = "borrow non-printed material" Then
            switchPanel(UM_Borrow)

        ElseIf TextBox2.Text.ToString = "Return" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "return" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "RETURN" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "Return material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "RETURN material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "return material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "Return printed material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "RETURN PRINTED MATERIAL" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "return printed material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "Return non-printed material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "RETURN NON-PRINTED MATERIAL" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "return non-printed material" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "how to return materials" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "How to return materials" Then
            switchPanel(UM_Return)
        ElseIf TextBox2.Text.ToString = "HOW TO RETURN MATERIALS" Then
            switchPanel(UM_Return)

        ElseIf TextBox2.Text.ToString = "LOST MATERIALS" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "Lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "LOST MATERIAL" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "Lost material" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "lost material" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "Add lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "add lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "ADD LOST MATERIALS" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "how to add lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "How to add lost materials" Then
            switchPanel(UM_lost)
        ElseIf TextBox2.Text.ToString = "HOW TO ADD LOST MATERIALS" Then
            switchPanel(UM_lost)

        ElseIf TextBox2.Text.ToString = "send sms" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "Send SMS" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "Send sms" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "SEND SMS" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "how to send sms notification" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "How to send sms notification" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "HOW TO SEND SMS NOTIFICATION" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "how to send sms" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "How to send sms" Then
            switchPanel(UM_sms)
        ElseIf TextBox2.Text.ToString = "HOW TO SEND SMS" Then
            switchPanel(UM_sms)

        ElseIf TextBox2.Text.ToString = "How to generate reports" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "how to generate reports" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "generate reports" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "Generate reports" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "GENERATE REPORTS" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "generate report" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "Generate report" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "print report" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "print report" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "how to generate report" Then
            switchPanel(UM_Reports)
        ElseIf TextBox2.Text.ToString = "How to generate report" Then
            switchPanel(UM_Reports)

        ElseIf TextBox2.Text.ToString = "how to manage user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "how to manage user information" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "how to manage user profile" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "How to manage user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "manage user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "manage users" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "Manage user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "Manage users" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "add user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "ADD USER" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "Add user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "how to add user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "How to add user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "update user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "Update user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "UPDATE USER" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "how to update user" Then
            switchPanel(UM_UserManagement)
        ElseIf TextBox2.Text.ToString = "How to update user" Then
            switchPanel(UM_UserManagement)

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Clear()
        UM_Return.Show()
        switchPanel(UM_Return)
        'UM_Return.gb_nonp.Show()
        'UM_Return.gb_nonprinted.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Clear()
        UM_lost.Show()
        switchPanel(UM_lost)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Clear()
        UM_Reports.Show()
        switchPanel(UM_Reports)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Clear()
        UM_UserManagement.Show()
        switchPanel(UM_UserManagement)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Clear()
        UM_sms.Show()
        switchPanel(UM_sms)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
    End Sub

    'Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
    '    If TextBox2.Text.ToString = "Printed" Then

    '        switchPanel(UM_Manage)
    '        UM_Manage.gb_nonp.Hide()
    '    End If
    'End Sub
End Class