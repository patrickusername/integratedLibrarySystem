Imports MySql.Data.MySqlClient
Module Module1
    Public lv_contents(6) As String
    Public connString As String = "server=localhost;uid=root;database=db_system;password=Develop@2021;integrated security = true"
    Public ReadOnly apiSmsKey = "d590ce731d137e0324e20c8bd0be35a8"
    Public ReadOnly smsTemplate As String = "Hi {0}, the printed/non-printed material you had borrowed on {1} is due tomorrow {2}. Please return it on time. Thank You!"
    Friend conpath As String = connString
    Friend conn As New MySqlConnection(conpath)
    Friend Sub query(ByVal str As String)
    End Sub
    Public Function getConnection()
        Dim conn As New MySqlConnection(connString)
        Return conn
    End Function
    Public Function updateQuery(query As String) As Boolean
        Dim isUpdate As Boolean = False

        Dim conn = getConnection()
        Try
            Using (conn)
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                Dim affectedRows = cmd.ExecuteNonQuery()
                If affectedRows > 0 Then
                    isUpdate = True
                Else
                    isUpdate = False
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox("insert >>> " & ex.Message)
            conn.Close()
        End Try
        Return isUpdate
    End Function


    Public Function getConfiguration() As Boolean
        Dim runInBg As Boolean = False
        Dim dt As New DataTable
        Try
            Dim conn = getConnection()
            Using (conn)
                conn.Open()
                Dim da As New MySqlDataAdapter
                Dim cmd As New MySqlCommand("SELECT * FROM cron_settings LIMIT 1", conn)
                da.SelectCommand = cmd
                da.Fill(dt)
                conn.Close()
            End Using
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("runinbackground").ToString() = 1 Then
                    runInBg = True
                End If
            Next
        Catch ex As Exception

        End Try


        Return runInBg
    End Function

    Public Function getBorrowData() As List(Of ReturnBooks)
        Dim list As New List(Of ReturnBooks)

        Try
            Dim conn = getConnection()
            Using (conn)
                conn.Open()
                Dim newReturnBook = New ReturnBooks()
                Dim cmd As New MySqlCommand(getBorrowDataQuery, conn)
                Dim dr = cmd.ExecuteReader()
                While dr.Read()
                    newReturnBook = New ReturnBooks()
                    newReturnBook.setBookNumber(dr.Item("BookNumber").ToString())
                    newReturnBook.setISBN(dr.Item("ISBN").ToString())
                    newReturnBook.setBookTitle(dr.Item("Title").ToString())
                    newReturnBook.setCategory(dr.Item("Category").ToString())


                    Dim sliceDb = dr.Item("DateBorrowed").ToString().Substring(0, 10).Split("/")
                    Dim dateBorrowed = sliceDb(2) & "-" & sliceDb(1) & "-" & sliceDb(0)
                    newReturnBook.setDateBorrowed(dateBorrowed)

                    newReturnBook.setOriginalDateToReturn(dr.Item("DateToReturn").ToString())
                    Dim sliceDr = dr.Item("DateToReturn").ToString().Substring(0, 10).Split("/")
                    Dim dateReturned = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
                    newReturnBook.setDateToReturn(dateReturned)

                    newReturnBook.setBorrowerName(dr.Item("name").ToString())
                    Dim contNum = dr.Item("contactno").ToString().Replace("-", "")
                    contNum = contNum.Replace("(+63)", "+63")
                    contNum = contNum.Replace(" ", "")
                    newReturnBook.setContactNumber(contNum)

                    list.Add(newReturnBook)

                End While

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list

    End Function

    Public Function checkIfMsgExist(bnum As String, name As String) As Boolean
        Dim isExist As Boolean = False

        Try
            Dim conn = getConnection()
            Using (conn)
                conn.Open()
                Dim query = String.Format(checkIfExistQuery, bnum, name)
                Dim cmd As New MySqlCommand(query, conn)
                Dim dr = cmd.ExecuteReader()
                While dr.Read()
                    If dr.Item("bookNumber").ToString().Equals(bnum) And dr.Item("borrowerName").ToString().Equals(name) Then
                        isExist = True
                        Exit While
                    End If
                End While
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return isExist
    End Function
    Public Function insert(query As String)
        Dim isSaved As Boolean = False
        Dim conn = getConnection()
        Try

            Using (conn)
                conn.Open()

                Dim cmd As New MySqlCommand(query, conn)
                Dim affectedRows = cmd.ExecuteNonQuery()
                If affectedRows > 0 Then
                    isSaved = True
                Else
                    isSaved = False
                End If

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox("insert >>> " & ex.Message)
            conn.Close()
        End Try

        Return isSaved
    End Function
    Public Function getBorrowForNonPrintedData() As List(Of ReturnBooks)
        Dim list As New List(Of ReturnBooks)

        Try
            Dim conn = getConnection()
            Using (conn)
                conn.Open()
                Dim newReturnBook = New ReturnBooks()
                Dim cmd As New MySqlCommand(getBorrowDataForNonPrintedQuery, conn)
                Dim dr = cmd.ExecuteReader()
                While dr.Read()
                    newReturnBook = New ReturnBooks()
                    newReturnBook.setBookNumber(dr.Item("MaterialNumber").ToString())
                    newReturnBook.setBookTitle(dr.Item("MaterialName").ToString())


                    Dim sliceDb = dr.Item("DateBorrowed").ToString().Substring(0, 10).Split("/")
                    Dim dateBorrowed = sliceDb(2) & "-" & sliceDb(1) & "-" & sliceDb(0)
                    newReturnBook.setDateBorrowed(dateBorrowed)

                    newReturnBook.setOriginalDateToReturn(dr.Item("DateToReturn").ToString())
                    Dim sliceDr = dr.Item("DateToReturn").ToString().Substring(0, 10).Split("/")
                    Dim dateReturned = sliceDr(2) & "-" & sliceDr(1) & "-" & sliceDr(0)
                    newReturnBook.setDateToReturn(dateReturned)

                    newReturnBook.setBorrowerName(dr.Item("Name").ToString())
                    Dim contNum = dr.Item("ContactNo").ToString().Replace("-", "")
                    contNum = contNum.Replace("(+63)", "+63")
                    contNum = contNum.Replace(" ", "")
                    newReturnBook.setContactNumber(contNum)

                    list.Add(newReturnBook)

                End While

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list

    End Function


End Module