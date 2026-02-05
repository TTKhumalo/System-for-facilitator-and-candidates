Imports System.Diagnostics
Public Class Student_Grades
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Student_Libraries.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Student_TestAndExams.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        ' Get student name and grade from textboxes


        Dim moduleName As String = TextBox1.Text
        Dim grade As String = TextBox2.Text
        Dim percentage As String = TextBox3.Text

        ' Add the data to the DataGridView
        DataGridView1.Rows.Add(moduleName, grade, percentage)

        ' Clear the textboxes for the next entry
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' Replace the URL with your Microsoft Teams meeting link
        Dim teamsLink As String = "https://www.microsoft.com/en-us/microsoft-teams"

        Try
            ' Use Process.Start to open the default web browser with the Teams link
            Process.Start(teamsLink)
        Catch ex As Exception
            ' Handle any exceptions that may occur, such as if there is no default web browser
            MessageBox.Show("An error occurred while opening Microsoft Teams: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Student_Portal.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Student_Grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "Module Name"
        DataGridView1.Columns(1).Name = "Grade"
        DataGridView1.Columns(2).Name = "Percentage"
    End Sub
End Class