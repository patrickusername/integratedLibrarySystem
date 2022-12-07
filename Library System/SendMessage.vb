Public Class SendMessage

    Public smTextMessage As String = ""
    Public smContactNumber As String = ""
    Function SMP(apiKey As String, number As String, message As String, sender As String)
        Dim responseBody As String
        Using client As New Net.WebClient()
            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://semaphore.co/api/v4/messages"
            parameter.Add("apikey", apiKey)
            parameter.Add("number", number)
            parameter.Add("message", message)
            parameter.Add("sendername", sender)
            Dim rpb = client.UploadValues(url, "POST", parameter)
            responseBody = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
        Return responseBody
    End Function

    Private Sub SendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_message.Text = smTextMessage
        txt_recipient.Text = smContactNumber
        'txt_recipient.ReadOnly = True
        'txt_message.ReadOnly = True
        DueMaterials.DataGridView1.ClearSelection()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        AdminMainForms.Show()
        Me.Hide()
        DueMaterials.DataGridView1.ClearSelection()
        txt_message.Clear()
        txt_recipient.Clear()
        DueMaterials.DataGridView1.Refresh()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        If txt_message.Text = "" Then
            MsgBox("Please Enter Your Message", MsgBoxStyle.Critical)
        ElseIf txt_recipient.Text = "" Then
            MsgBox("Please Enter Recipient", MsgBoxStyle.Critical)
        Else
            Try
                Dim result = SMP(apiSmsKey, txt_recipient.Text, txt_message.Text, "BAILNHSLIB")
                MsgBox("Successfully Sent Message", vbInformation, "BAILNHSLIB")
                txt_message.Clear()
                txt_recipient.Clear()
                AdminMainForms.Show()
                Me.Hide()
                DueMaterials.DataGridView1.ClearSelection()
                DueMaterials.DataGridView1.Refresh()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class