Imports System.IO

Public Class Student_Portal

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Student_Grades.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Student_Connectivity.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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


        Throw New NotImplementedException()
    End Sub

    Private Sub Student_Portal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.Add("System Development")
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button6.Hide()
        Button8.Hide()


    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedModule As String = ListBox1.SelectedItem.ToString()

        ListBox2.Items.Clear()
        Select Case selectedModule
            Case "System Development"
                ListBox2.Items.Add("Module 1")
                ListBox2.Items.Add("Module 2")
                ListBox2.Items.Add("Module 3)")
                ListBox2.Items.Add("Module 4")
                ListBox2.Items.Add("Module 5")
                ListBox2.Items.Add("Module 6")
            Case "Systems Support"
                ListBox2.Items.Add("Computerbehuizingen & accessoires")
                ListBox2.Items.Add("Moederborden & opties")
                ListBox2.Items.Add("Processoren & opties")
                ListBox2.Items.Add("Geheugenmodules")
                ListBox2.Items.Add("Grafische adapters & opties")
                ListBox2.Items.Add("Interfacekaarten/-adapters")

        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button6.Show()
        Button8.Show()

        Button7.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button6.Hide()
        Button8.Hide()
        Button7.Show()
    End Sub
End Class