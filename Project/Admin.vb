Imports System.IO

Public Class Admin

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Applications.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Admin_Dashboard.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Admin_Courses.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Admin_Finances.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Admin_Connectivity.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open a file dialog to select a question paper file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            UploadFile(filePath)
        End If
    End Sub

    Private Sub UploadFile(filePath As String)

        Dim destination As String = "C:\Uploads"
        Dim fileName As String = Guid.NewGuid().ToString() + ".pdf"
        Dim destinationPath As String = Path.Combine(destination, fileName)
        File.Copy(filePath, destinationPath)

        MessageBox.Show("File uploaded successfully")


        'Throw New NotImplementedException()
    End Sub
End Class