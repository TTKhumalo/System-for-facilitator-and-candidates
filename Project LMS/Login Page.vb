Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ComboBox1.Items.Add("STUDENT")
        ComboBox1.Items.Add("FACILITATOR")
        ComboBox1.Items.Add("ADMIN")

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedText As String = ComboBox1.SelectedItem.ToString()
        If ComboBox1.SelectedItem = "STUDENT" Then

            Dim a As DialogResult
            a = MessageBox.Show("Welcome student", "Press ok if you have your credintials to log in", MessageBoxButtons.OK)

            Student_Login.Show()

        ElseIf ComboBox1.SelectedItem = "FACILITATOR" Then

            Dim a As DialogResult
            a = MessageBox.Show("Welcome Facilitator", "Press ok if you have your credintials to log in", MessageBoxButtons.OK)

            Facilitator_Login.Show()
        ElseIf ComboBox1.SelectedItem = "ADMIN" Then

            Dim a As DialogResult
            a = MessageBox.Show("Welcome Admin", "Press ok if you have your credintials to log in", MessageBoxButtons.OK)

            Admin_Login.Show()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MMMM-yyyy hh:mm")
    End Sub

End Class
