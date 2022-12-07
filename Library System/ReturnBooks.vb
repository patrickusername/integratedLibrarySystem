Public Class ReturnBooks
    Private bookNumber As String
    Private isbn As String
    Private bookTitle As String
    Private borrowerName As String
    Private dateToReturn As String
    Private originalDateToReturn As String
    Private dateBorrowed As String
    Private contactNum As String
    Private category As String


    Public Sub setBookNumber(bn As String)
        bookNumber = bn
    End Sub

    Public Function getBookNumber() As String
        Return bookNumber
    End Function

    Public Sub setISBN(bn As String)
        isbn = bn
    End Sub

    Public Function getISBN() As String
        Return isbn
    End Function

    Public Sub setBookTitle(bt As String)
        bookTitle = bt
    End Sub

    Public Function getBookTitle() As String
        Return bookTitle
    End Function

    Public Sub setBorrowerName(bn As String)
        borrowerName = bn
    End Sub

    Public Function getBorrowerName() As String
        Return borrowerName
    End Function

    Public Sub setDateToReturn(dtr As String)
        dateToReturn = dtr
    End Sub

    Public Function getDateToReturn() As String
        Return dateToReturn
    End Function


    Public Sub setDateBorrowed(db As String)
        dateBorrowed = db
    End Sub

    Public Function getDateBorrowed() As String
        Return dateBorrowed
    End Function

    Public Sub setContactNumber(cn As String)
        contactNum = cn
    End Sub

    Public Function getContactNumber() As String
        Return contactNum
    End Function

    Public Sub setCategory(cat As String)
        category = cat
    End Sub

    Public Function getCategory() As String
        Return category
    End Function

    Public Sub setOriginalDateToReturn(det As String)
        originalDateToReturn = det
    End Sub

    Public Function getOriginalDateToReturn() As String
        Return originalDateToReturn
    End Function
End Class
