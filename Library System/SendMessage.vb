Public Class SendMessage
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        If txt_message.Text = "" Or txt_recipient.Text = "" Then
            MsgBox("Please Don't Leave Empty Fields")
        Else
            Try
                Dim result = SMP(apiSmsKey, txt_recipient.Text, txt_message.Text, "SEMAPHORE")
                MsgBox("Successfully Sent Message", vbInformation, "BAILNHSLIB")
                clearFields()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub clearFields()
        txt_message.Clear()
        txt_recipient.Clear()
    End Sub
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

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        txt_message.Text = String.Format(smsTemplate, "<name>", "<date borrowed>", "<date to return>")
    End Sub
End Class