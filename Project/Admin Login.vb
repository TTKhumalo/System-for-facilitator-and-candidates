Public Class Admin_Login
    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If userNameText.Text = "admin" Then
            If passtext.Text = "admin" Then

                Dim a As DialogResult
                a = MessageBox.Show("Admin login successful", "Login form", MessageBoxButtons.OK)
                Me.Close()
                Admin.Show()

            Else
                Dim a As DialogResult
                a = MessageBox.Show("Wrong Password", "error", MessageBoxButtons.RetryCancel)

            End If
        Else
            Dim a As DialogResult
            a = MessageBox.Show("Wrong Username", "error", MessageBoxButtons.RetryCancel)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState Then
            passtext.UseSystemPasswordChar = False
        Else
            passtext.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MMMM-yyyy hh:mm")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class