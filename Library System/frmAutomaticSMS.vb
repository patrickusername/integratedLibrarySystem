Imports Microsoft.Win32
Public Class frmAutomaticSMS
    Private runInBG As Boolean = False
    Private Sub cbRunBG_CheckedChanged(sender As Object, e As EventArgs) Handles cbRunBG.CheckedChanged
        If cbRunBG.CheckState = CheckState.Checked Then
            runInBG = True
        Else
            runInBG = False
        End If
    End Sub

    Private Sub btnSaveSetting_Click(sender As Object, e As EventArgs) Handles btnSaveSetting.Click
        MsgBox("If run in background is checked the cronjob will start and this form will hide", vbInformation)
        Dim query = String.Format(updateCronSettings, runInBG)
        Dim isUpdate = updateQuery(query)
        If isUpdate Then
        Else
            runInBG = False
            MsgBox("Failed To Update, Can't run the cron as of the moment, Please seek help from your system administrator", vbCritical)
        End If
        loadService()
    End Sub

    Private Sub loadService()
        If runInBG Then
            Me.Hide()


            Dim seconds As Integer = 0

            Do
                If seconds.Equals(10000) Then
                    Dim runbg = getConfiguration()
                    If runbg <> True Then
                        runInBG = False
                        cbRunBG.CheckState = CheckState.Unchecked
                        Me.Show()
                        Exit Do
                    End If
                    seconds = 0
                    Dim list As List(Of ReturnBooks) = getBorrowData()
                    For i As Integer = 0 To list.Count - 1
                        Dim rBook As ReturnBooks = list(i)
                        If rBook.getContactNumber() = "" Then
                            Continue For
                        End If



                        Dim exist As Boolean = checkIfMsgExist(rBook.getBookNumber(), rBook.getBorrowerName())

                        If exist Then
                            Continue For
                        End If

                        If rBook.getCategory().ToLower().Equals("textbook") Then
                            Dim dets As New Date
                            Date.TryParse(rBook.getDateToReturn, dets)
                            Dim betweenDays = DateAndTime.DateDiff(DateInterval.Day, Date.Parse(Date.Now().ToShortDateString()), dets)
                            If betweenDays = 1 Then
                                Dim message = String.Format(smsTemplateTomorrow, rBook.getBorrowerName, rBook.getBookTitle, rBook.getOriginalDateToReturn)
                                Try
                                    Dim result = SMP(smsApiKey, rBook.getContactNumber, message, "BAILNHSLIB")
                                    insert(String.Format(insertCronSentQuery, rBook.getBookNumber, rBook.getBorrowerName, rBook.getDateToReturn))
                                Catch ex As Exception
                                    ' MsgBox(ex.Message)
                                End Try
                            End If

                        End If
                        If rBook.getCategory().ToLower().Equals("general reference") Then
                            Try
                                Dim sliceTime = rBook.getOriginalDateToReturn().Split("-")
                                Dim hoursAndMinutes = sliceTime(1).Split(":")
                                Dim hours As String = hoursAndMinutes(0).Trim()
                                Dim sliceMins = hoursAndMinutes(1).Split(" ")
                                Dim amPm = sliceMins(1).Trim()
                                Dim mins = sliceMins(0).Trim()
                                If mins = "00" Then
                                    mins = "00"
                                End If
                                If amPm.ToLower().Equals("pm") Then
                                    hours = hours + 12
                                End If

                                If amPm.ToLower().Equals("am") Then
                                    If hours.ToLower().Equals("12") Then
                                        hours = "00"
                                    End If
                                End If
                                Dim mDate = Date.Parse(rBook.getDateToReturn())
                                Dim dets As DateTime = New DateTime(mDate.Year, mDate.Month, mDate.Day, hours, mins, 0)
                                Dim currentHour = DateTime.Now().Hour
                                Dim dueHour = Integer.Parse(hours)
                                Dim hourDiff = dueHour - currentHour
                                If hourDiff <= 12 Then
                                    Dim message = String.Format(smsTemplate, rBook.getBorrowerName, rBook.getBookTitle, rBook.getOriginalDateToReturn)
                                    Try
                                        Dim result = SMP(smsApiKey, rBook.getContactNumber, message, "BAILNHSLIB")
                                        insert(String.Format(insertCronSentQuery, rBook.getBookNumber, rBook.getBorrowerName, rBook.getDateToReturn))
                                    Catch ex As Exception
                                        ' MsgBox(ex.Message)
                                    End Try
                                End If



                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        End If

                    Next


                    ' For non printed
                    Dim nonPrintedList As List(Of ReturnBooks) = getBorrowForNonPrintedData()
                    For x As Integer = 0 To nonPrintedList.Count - 1
                        Dim rBook As ReturnBooks = nonPrintedList(x)
                        If rBook.getContactNumber() = "" Then
                            Continue For
                        End If
                        Dim exist As Boolean = checkIfMsgExist(rBook.getBookNumber(), rBook.getBorrowerName())
                        If exist Then
                            Continue For
                        End If

                        Try
                            Dim sliceTime = rBook.getOriginalDateToReturn().Split("-")
                            Dim hoursAndMinutes = sliceTime(1).Split(":")
                            Dim hours As String = hoursAndMinutes(0).Trim()
                            Dim sliceMins = hoursAndMinutes(1).Split(" ")
                            Dim amPm = sliceMins(1).Trim()
                            Dim mins = sliceMins(0).Trim()
                            If mins = "00" Then
                                mins = "00"
                            End If
                            If amPm.ToLower().Equals("pm") Then
                                hours = hours + 12
                            End If

                            If amPm.ToLower().Equals("am") Then
                                If hours.ToLower().Equals("12") Then
                                    hours = "00"
                                End If
                            End If
                            Dim mDate = Date.Parse(rBook.getDateToReturn())
                            Dim dets As DateTime = New DateTime(mDate.Year, mDate.Month, mDate.Day, hours, mins, 0)
                            Dim currentHour = DateTime.Now().Hour
                            Dim dueHour = Integer.Parse(hours)
                            Dim hourDiff = dueHour - currentHour
                            If hourDiff = 1 Then
                                Dim message = String.Format(smsTemplate2, rBook.getBorrowerName, rBook.getBookTitle, rBook.getOriginalDateToReturn)
                                Try
                                    Dim result = SMP(smsApiKey, rBook.getContactNumber, message, "BAILNHSLIB")
                                    insert(String.Format(insertCronSentQuery, rBook.getBookNumber, rBook.getBorrowerName, rBook.getDateToReturn))
                                Catch ex As Exception
                                    ' MsgBox(ex.Message)
                                End Try
                            End If



                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    Next
                End If
                seconds += 1
            Loop
        End If
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
End Class