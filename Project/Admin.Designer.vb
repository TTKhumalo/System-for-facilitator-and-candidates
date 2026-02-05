<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin))
        PanelLeft = New Panel()
        Button1 = New Button()
        Logout = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        panelTop = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PanelLeft.SuspendLayout()
        panelTop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = SystemColors.ButtonShadow
        PanelLeft.Controls.Add(Button1)
        PanelLeft.Controls.Add(Logout)
        PanelLeft.Controls.Add(Button6)
        PanelLeft.Controls.Add(Button5)
        PanelLeft.Controls.Add(Button4)
        PanelLeft.Controls.Add(Button3)
        PanelLeft.Controls.Add(Button2)
        PanelLeft.Dock = DockStyle.Right
        PanelLeft.Location = New Point(1342, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(169, 630)
        PanelLeft.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.FlatAppearance.BorderColor = Color.DarkGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.Location = New Point(3, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 42)
        Button1.TabIndex = 22
        Button1.Text = "Upload"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.MenuHighlight
        Logout.Cursor = Cursors.AppStarting
        Logout.ForeColor = SystemColors.ButtonHighlight
        Logout.Location = New Point(3, 396)
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
        Button6.Location = New Point(3, 300)
        Button6.Name = "Button6"
        Button6.Size = New Size(154, 42)
        Button6.TabIndex = 4
        Button6.Text = "Connectivity"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonShadow
        Button5.FlatAppearance.BorderColor = Color.DarkGray
        Button5.FlatAppearance.BorderSize = 0
        Button5.Location = New Point(3, 255)
        Button5.Name = "Button5"
        Button5.Size = New Size(154, 38)
        Button5.TabIndex = 3
        Button5.Text = "Finances"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonShadow
        Button4.FlatAppearance.BorderColor = Color.DarkGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.Location = New Point(3, 213)
        Button4.Name = "Button4"
        Button4.Size = New Size(154, 35)
        Button4.TabIndex = 2
        Button4.Text = "Courses"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.FlatAppearance.BorderColor = Color.DarkGray
        Button3.Location = New Point(3, 170)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 37)
        Button3.TabIndex = 1
        Button3.Text = "Dashboard"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.FlatAppearance.BorderColor = Color.DarkGray
        Button2.Location = New Point(3, 123)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 40)
        Button2.TabIndex = 0
        Button2.Text = "Applications"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelTop
        ' 
        panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelTop.BackColor = Color.Red
        panelTop.Controls.Add(Label3)
        panelTop.Controls.Add(Label2)
        panelTop.Controls.Add(Label1)
        panelTop.Controls.Add(PictureBox1)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(1342, 120)
        panelTop.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 25)
        Label3.TabIndex = 5
        Label3.Text = "NameOfUser"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 25)
        Label2.TabIndex = 4
        Label2.Text = "SurnameOfUser"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 25)
        Label1.TabIndex = 1
        Label1.Text = "ADMINSTRATOR"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1186, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(1176, 140)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(76, 58)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(1260, 128)
        PictureBox4.Margin = New Padding(4, 5, 4, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(76, 70)
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.images__5_
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(1091, 140)
        PictureBox5.Margin = New Padding(4, 5, 4, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(76, 58)
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1511, 630)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(panelTop)
        Controls.Add(PanelLeft)
        Name = "Admin"
        Text = "Admin"
        PanelLeft.ResumeLayout(False)
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
End Class
