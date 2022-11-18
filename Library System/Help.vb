Public Class Help
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node0" Then
            RichTextBox1.Text = "The Integrated Library System with SMS Notification aims to establish a computerized system for Bail National High School to improve library management and library services. It also creates a database for a convenient way of encoding, storing, and tracking records. With the help of a barcode scanner, the encoding of records will be faster and human error will be avoided. Using SMS, the borrowers will be reminded of the due date of their borrowed materials."
        End If

        If e.Node.Name = "Node1" Then
            RichTextBox1.Text = "Try2"
        End If

        If e.Node.Name = "Node2" Then
            RichTextBox1.Text = "Try3"
        End If

        If e.Node.Name = "Node3" Then
            RichTextBox1.Text = "Try4"
        End If
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class