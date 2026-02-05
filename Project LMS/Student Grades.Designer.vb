<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Grades
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Student_Grades))
        panelTop = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        PanelLeft = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Logout = New Button()
        Button6 = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        panelTop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PanelLeft.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        panelTop.Size = New Size(1341, 120)
        panelTop.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 25)
        Label3.TabIndex = 5
        Label3.Text = "NameOfUser"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 33)
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
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
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
        PictureBox4.TabIndex = 13
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
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.images__5_
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(1089, 150)
        PictureBox5.Margin = New Padding(4, 5, 4, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(76, 58)
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = SystemColors.ButtonShadow
        PanelLeft.Controls.Add(Button3)
        PanelLeft.Controls.Add(Button2)
        PanelLeft.Controls.Add(Button1)
        PanelLeft.Controls.Add(Logout)
        PanelLeft.Controls.Add(Button6)
        PanelLeft.Dock = DockStyle.Right
        PanelLeft.Location = New Point(1341, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(170, 750)
        PanelLeft.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.FlatAppearance.BorderColor = Color.DarkGray
        Button3.Location = New Point(6, 83)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 37)
        Button3.TabIndex = 26
        Button3.Text = "Home Page"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.FlatAppearance.BorderColor = Color.DarkGray
        Button2.Location = New Point(3, 127)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 37)
        Button2.TabIndex = 25
        Button2.Text = "Libraries"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.FlatAppearance.BorderColor = Color.DarkGray
        Button1.Location = New Point(3, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 37)
        Button1.TabIndex = 24
        Button1.Text = "Tests/Exams"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.MenuHighlight
        Logout.Cursor = Cursors.AppStarting
        Logout.ForeColor = SystemColors.ButtonHighlight
        Logout.Location = New Point(3, 491)
        Logout.Name = "Logout"
        Logout.Size = New Size(77, 45)
        Logout.TabIndex = 23
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonShadow
        Button6.FlatAppearance.BorderColor = Color.DarkGray
        Button6.FlatAppearance.BorderSize = 0
        Button6.Location = New Point(3, 213)
        Button6.Name = "Button6"
        Button6.Size = New Size(154, 42)
        Button6.TabIndex = 22
        Button6.Text = "Grades"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(320, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(725, 327)
        DataGridView1.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1099, 291)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1099, 328)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1099, 365)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 18
        ' 
        ' Student_Grades
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1511, 750)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox5)
        Controls.Add(panelTop)
        Controls.Add(PanelLeft)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Student_Grades"
        Text = "Student_Grades"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PanelLeft.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
