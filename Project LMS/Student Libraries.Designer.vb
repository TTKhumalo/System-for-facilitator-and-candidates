<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Libraries
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Student_Libraries))
        Button1 = New Button()
        Logout = New Button()
        Button6 = New Button()
        Button3 = New Button()
        panelTop = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelLeft = New Panel()
        NotifyIcon1 = New NotifyIcon(components)
        PictureBox5 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button2 = New Button()
        panelTop.SuspendLayout()
        PanelLeft.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.FlatAppearance.BorderColor = Color.DarkGray
        Button1.Location = New Point(4, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 37)
        Button1.TabIndex = 19
        Button1.Text = "Tests/Exams"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.MenuHighlight
        Logout.Cursor = Cursors.AppStarting
        Logout.ForeColor = SystemColors.ButtonHighlight
        Logout.Location = New Point(4, 304)
        Logout.Name = "Logout"
        Logout.Size = New Size(77, 45)
        Logout.TabIndex = 18
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonShadow
        Button6.FlatAppearance.BorderColor = Color.DarkGray
        Button6.FlatAppearance.BorderSize = 0
        Button6.Location = New Point(4, 256)
        Button6.Name = "Button6"
        Button6.Size = New Size(154, 42)
        Button6.TabIndex = 4
        Button6.Text = "Connectivity"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.FlatAppearance.BorderColor = Color.DarkGray
        Button3.Location = New Point(4, 213)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 37)
        Button3.TabIndex = 1
        Button3.Text = "Grades"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' panelTop
        ' 
        panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelTop.BackColor = Color.Red
        panelTop.Controls.Add(Label3)
        panelTop.Controls.Add(Label2)
        panelTop.Controls.Add(Label1)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(839, 120)
        panelTop.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 25)
        Label3.TabIndex = 5
        Label3.Text = "NameOfUser"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 25)
        Label2.TabIndex = 4
        Label2.Text = "SurnameOfUser"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(341, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 25)
        Label1.TabIndex = 1
        Label1.Text = "STUDENT PORTAL"
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = SystemColors.ButtonShadow
        PanelLeft.Controls.Add(Button2)
        PanelLeft.Controls.Add(Button1)
        PanelLeft.Controls.Add(Logout)
        PanelLeft.Controls.Add(Button6)
        PanelLeft.Controls.Add(Button3)
        PanelLeft.Dock = DockStyle.Right
        PanelLeft.Location = New Point(839, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(170, 750)
        PanelLeft.TabIndex = 9
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.images__5_
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(1089, 150)
        PictureBox5.Margin = New Padding(4, 5, 4, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(76, 58)
        PictureBox5.TabIndex = 15
        PictureBox5.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(17, 328)
        PictureBox3.Margin = New Padding(4, 5, 4, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(153, 155)
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(1257, 138)
        PictureBox4.Margin = New Padding(4, 5, 4, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(76, 70)
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(1173, 150)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(76, 58)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.FlatAppearance.BorderColor = Color.DarkGray
        Button2.Location = New Point(3, 127)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 37)
        Button2.TabIndex = 20
        Button2.Text = "Home Page"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Student_Libraries
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 750)
        Controls.Add(panelTop)
        Controls.Add(PanelLeft)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Student_Libraries"
        Text = "Student_Libraries"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        PanelLeft.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
End Class
