Module Queries
    Public ReadOnly getBorrowDataQuery = "Select BookNumber, ISBN, Title, DateBorrowed, DateToReturn, Username, name, contactno,Category from tbl_borrowreturnbooks WHERE DatetoReturn >='" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
    Public ReadOnly getBorrowDataForNonPrintedQuery = "Select * from tbl_borrowreturnnonprinted WHERE DatetoReturn >='" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
    Public ReadOnly checkIfExistQuery = "SELECT * FROM cronsent WHERE bookNumber='{0}' and borrowerName='{1}'"
    Public ReadOnly smsTemplate2 As String = "Hi {0}," + vbLf + "the book/non-printed material you had borrowed on {1} is due today {2}." + vbLf + "Please return it on time." + vbLf + "Thank You!"
    Public ReadOnly smsTemplateTomorrow As String = "Hi {0}," + vbLf + "the book/non-printed material you had borrowed on {1} is due tomorrow {2}." + vbLf + "Please return it on time." + vbLf + "Thank You!"
    Public ReadOnly smsApiKey As String = "d590ce731d137e0324e20c8bd0be35a8"
    Public ReadOnly insertCronSentQuery = "INSERT INTO cronsent (bookNumber,borrowerName,date) VALUES('{0}','{1}','{2}')"
    Public ReadOnly updateCronSettings = "UPDATE cron_settings Set runinbackground={0} where settingID=1"
End Module
