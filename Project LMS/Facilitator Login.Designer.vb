<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facilitator_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Facilitator_Login))
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        exitButton = New Button()
        Button2 = New Button()
        Login = New Button()
        userNameText = New TextBox()
        passtext = New TextBox()
        password = New Label()
        userName = New Label()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Right
        Label1.Location = New Point(781, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 21
        Label1.Text = "Label1"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(721, 258)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(22, 21)
        CheckBox1.TabIndex = 20
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.BackColor = Color.Red
        exitButton.Cursor = Cursors.AppStarting
        exitButton.ForeColor = SystemColors.ButtonHighlight
        exitButton.Location = New Point(454, 373)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(77, 42)
        exitButton.TabIndex = 18
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tomato
        Button2.Cursor = Cursors.AppStarting
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(584, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 43)
        Button2.TabIndex = 17
        Button2.Text = "Forgot Password"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        Login.BackColor = SystemColors.MenuHighlight
        Login.Cursor = Cursors.AppStarting
        Login.ForeColor = SystemColors.ButtonHighlight
        Login.Location = New Point(454, 323)
        Login.Name = "Login"
        Login.Size = New Size(77, 43)
        Login.TabIndex = 16
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' userNameText
        ' 
        userNameText.Cursor = Cursors.IBeam
        userNameText.Location = New Point(453, 168)
        userNameText.Name = "userNameText"
        userNameText.PlaceholderText = "Username/ Email"
        userNameText.Size = New Size(301, 31)
        userNameText.TabIndex = 15
        ' 
        ' passtext
        ' 
        passtext.Cursor = Cursors.IBeam
        passtext.Location = New Point(453, 252)
        passtext.Name = "passtext"
        passtext.PlaceholderText = "Password"
        passtext.Size = New Size(301, 31)
        passtext.TabIndex = 14
        passtext.UseSystemPasswordChar = True
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        password.Location = New Point(291, 258)
        password.Name = "password"
        password.Size = New Size(110, 26)
        password.TabIndex = 13
        password.Text = "Password"
        ' 
        ' userName
        ' 
        userName.AutoSize = True
        userName.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        userName.Location = New Point(291, 175)
        userName.Name = "userName"
        userName.Size = New Size(125, 26)
        userName.TabIndex = 12
        userName.Text = "User Name"
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(448, 138)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Facilitator_Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 427)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox2)
        Controls.Add(exitButton)
        Controls.Add(Button2)
        Controls.Add(Login)
        Controls.Add(userNameText)
        Controls.Add(passtext)
        Controls.Add(password)
        Controls.Add(userName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Facilitator_Login"
        Text = "Facilitator_Login"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents exitButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Login As Button
    Friend WithEvents userNameText As TextBox
    Friend WithEvents passtext As TextBox
    Friend WithEvents password As Label
    Friend WithEvents userName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
