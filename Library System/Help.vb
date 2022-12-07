Public Class Help
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "nd_overview" Then
            RichTextBox1.Text = "The Integrated Library System with SMS Notification aims to establish a computerized system for Bail National High School to improve library management and library services. It also creates a database for a convenient way of encoding, storing, and tracking records. With the help of a barcode scanner, the encoding of records will be faster and human error will be avoided. 
Using SMS, the borrowers will be reminded of the due date of their borrowed materials."

        End If

        If e.Node.Name = "nd_managein" Then
            RichTextBox1.Text = "Try2"
        End If

        If e.Node.Name = "nd_printed" Then
            RichTextBox1.Text = "HOW TO ADD PRINTED MATERIALS 
1. Click Manage from the menu bar.
2. Select Add from Printed Materials to open the Add form.
3. Fill out all of the information needed.
4. Click the add button to successfully add and save the printed material.


HOW TO UPDATE PRINTED MATERIALS
1. Click Manage from the menu bar.
2. Select Update from Printed Materials to open the Update form.
3. You may manually enter the Printed Material's Number to search the printed material that you wanted to update or you may use the barcode scanner for easier and faster searching. 
4. Click the search button
5. Update the printed material’s information and then click the update button to successfully save the changes.


HOW TO SEARCH PRINTED MATERIALS
1. Click Manage from the menu bar.
2. If you are looking for a book, select Printed Materials. Click Search to open the search form
3. In the search box, you may enter the printed materials' information such as title, author, publisher, book number, etc to find it.  
4. The printed material will be shown in the box below if it is present in the library. 
5. Books and non-printed materials are labeled as Available indicating that it is open to be borrowed. 
"
        End If

        If e.Node.Name = "nd_non" Then
            RichTextBox1.Text = "HOW TO ADD NON-PRINTED MATERIALS
1. Click Manage from the menu bar.
2. Select Add from Non-Printed Materials to open the Add form.
3. Fill out all of the information needed.
4. Click the add button to successfully add And save the non-printed material.


HOW TO UPDATE NON-PRINTED MATERIALS
1. Click Manage from the menu bar.
2. Select Update from Non-Printed Materials to open the Update form.
3. You may manually enter the Non-Printed Material's Number to search the non-printed material that you wanted to update or you may use the barcode scanner for easier and faster searching. 
4. Click the search button
5. Update the non-printed material’s information and then click the update button to successfully save the changes.


HOW TO SEARCH NON-PRINTED MATERIALS
1. Click Manage from the menu bar.
2. If you are looking for a book, select Non-Printed Materials. Click Search to open the search form
3. In the search box, you may enter the non-printed materials' material number or material name to find it.  
4. The non-printed material will be shown in the box below if it is present in the library. 
5. Non-printed materials are labeled as Available indicating that it is open to be borrowed. 
"
        End If

        If e.Node.Name = "nd_borrow" Then
            RichTextBox1.Text = "HOW TO BORROW MATERIALS

1. Click Borrow from the menu bar to open borrow form.
2. Select material type.
3. Fill out material information and borrower information.
4. Click the save button to add the borrow record to the borrow list.
5. Click the borrow button to successfully save the borrow record stored in the list. You may click the borrow button after saving all borrow records in the list especially if books or non-printed materials are being borrowed one after another in order to save all borrow record at one time.
"
        End If

        If e.Node.Name = "nd_ret" Then
            RichTextBox1.Text = "HOW TO RETURN MATERIALS 

1. Click Return from the menu bar to open the return form.
2. Select the material type.
3. Select the material status.
4. Fill out the required information either manually or you may scan the book number of the book or the material number of the non-printed material with the use of the barcode scanner, in order to automatically fill out the required information. 
5. Click the save button to add the return record to the return list.
6. Click the return button to successfully save the records stored in the return list. You may click the return button after saving all records in the list especially if books or non-printed materials are being returned one after another in order to save all record in the list at one time.
"
        End If

        If e.Node.Name = "nd_lost" Then
            RichTextBox1.Text = "HOW TO ADD LOST MATERIALS

1. Click Lost from the menu bar to open the Lost window.
2. Select Printed Material or Non-Printed Material.
3. Fill out the required information.
4. Click add button to successfully save the book or non-printed material to the list of lost book or non-printed materials.
"
        End If

        If e.Node.Name = "nd_report" Then
            RichTextBox1.Text = "HOW TO GENERATE REPORT

1. Click Reports from the menu bar and select the report that you want to view or print.
2. Filter the list by setting the date of the specific record that you want to view or print and click Search button.
3. Click Refresh button to remove the filter of the list. 
4. Click Print button to generate the report.
5. From the generated report, you may click the icon with a single arrow located in the upper left of the window, which symbolizes for Export button, to save a softcopy of the report. 
6. Click the Print Report button beside the export button to print a hardcopy of the report.
7. Click the double arrow icon to refresh the generate report.
8. Click the exit button to go back to the report form.
"
        End If

        If e.Node.Name = "nd_manageus" Then
            RichTextBox1.Text = "HOW TO ADD USER
1. Click User Management from the menu bar.
2. Select a specific user management.
3. Click Add button from the chosen user management to open the add user form.
4. Fill out all required information.
5. Click Save button to add the newly created user to the list.
6. Click Add button to successfully add the user records stored in the list. You may add multiple users by saving the users in the list first before clicking the Add button.


HOW TO UPDATE USER
1. Click User Management from the menu bar.
2. Select a specific user management
3. Click Update button from the chosen user management to open the update user form.
4. Enter the Username of the user and click the Search button.
5. Update the information of the user and click Update button to successfully save the updated user information.
"
        End If

        If e.Node.Name = "nd_backres" Then
            RichTextBox1.Text = "HOW TO BACKUP AND RESTORE

1. Click Utilities from the menu bar and select Backup and Restore.
2. Click Browse button.
3. Locate or select a folder where you can backup or restore system files.
4. Click Backup button or Restore button to successfully execute backup and restore.
"
        End If

    End Sub



    'Private mlstSearchResult() As TreeNode

    'Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

    '    Dim strSearchFor As String = InputBox("Search for")
    '    mlstSearchResult = TreeView1.Nodes.Find(strSearchFor, True)

    '    'lbxSearchResults.Items.Clear() ' Clear previous search result.
    '    For Each n As TreeNode In mlstSearchResult
    '        RichTextBox1.AppendText(n.Text)
    '    Next
    'End Sub

    'Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    '    TreeView1.SelectedNode = mlstSearchResult(RichTextBox1.Text)
    '    TreeView1.SelectedNode.EnsureVisible()
    'End Sub

    'Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
    '    Dim key As String = TreeView1.SelectedNode.Name
    '    Dim searchAllChildren As Boolean = True
    '    Dim returnValue As TreeNode()

    '    returnValue = TreeView1.Nodes.Find(key, searchAllChildren)

    '    MsgBox(returnValue(0).Text)
    'End Sub

    'Private Function FindNode(ByVal SearchText As String, ByVal NodesToSearch As TreeNodeCollection, ByVal TreeToSearch As TreeView) As TreeNode

    '    Dim ReturnNode As TreeNode = Nothing
    '    Try
    '        For Each Node As TreeNode In NodesToSearch
    '            If String.Compare(Node.Text, SearchText, True) = 0 Then
    '                Node.Expand()
    '                ReturnNode = Node
    '                Exit For
    '            End If
    '            If ReturnNode Is Nothing Then ReturnNode = FindNode(SearchText, Node.Nodes, TreeToSearch)
    '        Next
    '    Catch ex As Exception
    '        Throw
    '    End Try
    '    Return ReturnNode
    'End Function

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    ClearBackColor()
    '    FindByText()
    'End Sub

    'Private Sub FindByText()
    '    Dim nodes As TreeNodeCollection = TreeView1.Nodes
    '    Dim n As TreeNode
    '    For Each n In nodes
    '        FindRecursive(n)
    '    Next
    'End Sub

    'Private Sub FindRecursive(ByVal tNode As TreeNode)
    '    If TextBox1.Text = "" Then
    '        TreeView1.CollapseAll()
    '        TreeView1.BackColor = Color.White
    '        'ExpandToLevel(TreeView1.Nodes, 1)
    '    Else
    '        Dim tn As TreeNode
    '        For Each tn In tNode.Nodes
    '            ' if the text properties match, color the item
    '            If tn.Text.Contains(TextBox1.Text) Then
    '                tn.BackColor = Color.Yellow
    '                tn.EnsureVisible()        'Scroll the control to the item
    '            End If

    '            FindRecursive(tn)
    '        Next
    '    End If
    'End Sub

    'Private Sub ClearBackColor()
    '    Dim nodes As TreeNodeCollection
    '    nodes = TreeView1.Nodes
    '    Dim n As TreeNode
    '    For Each n In nodes
    '        ClearRecursive(n)
    '    Next
    'End Sub

    'Private Sub ClearRecursive(ByVal treeNode As TreeNode)
    '    Dim tn As TreeNode
    '    For Each tn In treeNode.Nodes
    '        tn.BackColor = Color.White
    '        ClearRecursive(tn)
    '    Next
    'End Sub

    '    Function searchTreeview(ByVal SearchString As String, ByVal Nodes As TreeNodeCollection,
    'Optional ByVal ExactMatch As Boolean = False,
    'Optional ByVal Recursive As Boolean = True) _
    'As TreeNode
    '        Dim ret As TreeNode
    '        For Each tn As TreeNode In Nodes
    '            If ExactMatch = True Then
    '                If tn.Text = SearchString Then Return tn
    '            Else
    '                If tn.Text.IndexOf(SearchString) <> -1 Then Return tn
    '            End If

    '            If Recursive = True Then
    '                If tn.Nodes.Count > 0 Then
    '                    ret = searchTreeview(SearchString, tn.Nodes, ExactMatch, Recursive)
    '                    If Not ret Is Nothing Then Return ret
    '                End If
    '            End If
    '        Next
    '        Return Nothing
    '    End Function

    '    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

    '        Dim Key As String
    '        Key = "A 5B 1"

    '        Dim tn As TreeNode = searchTreeview(TextBox1.Text, TreeView1.Nodes, False, True)
    '        If Not tn Is Nothing Then
    '            TreeView1.SelectedNode = tn
    '        Else
    '            MsgBox("no match")
    '        End If



    'Dim SearchNode = TreeView1.Nodes.Find(Key, True)
    'If SearchNode.Count > 0 Then
    '    MsgBox("find")

    '    TreeView1.SelectedNode = SearchNode
    '    TreeView1.ExpandAll()
    '    TreeView1.Focus()

    'Else
    '    MsgBox("not found")
    'End If

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim SelectedNode As TreeNode
        SelectedNode = TreeView1.SelectedNode



        Dim startText As Integer = 0
        Dim endText As Integer
        endText = RichTextBox1.Text.LastIndexOf(TextBox1.Text)

        RichTextBox1.SelectAll()
        'RichTextBox1.SelectionBackColor = Color.White

        While startText < endText

            RichTextBox1.Find(TextBox1.Text, startText, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.LightBlue

            startText = RichTextBox1.Text.IndexOf(TextBox1.Text, startText) + 1
        End While
    End Sub

End Class