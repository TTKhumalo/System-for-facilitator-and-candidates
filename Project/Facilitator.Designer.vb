<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facilitator
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Facilitator))
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        panelTop = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelLeft = New Panel()
        Logout = New Button()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        panelTop.SuspendLayout()
        PanelLeft.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonShadow
        Button6.FlatAppearance.BorderColor = Color.DarkGray
        Button6.FlatAppearance.BorderSize = 0
        Button6.Location = New Point(2, 184)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(108, 25)
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
        Button5.Location = New Point(2, 157)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(108, 23)
        Button5.TabIndex = 3
        Button5.Text = "Practicals"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonShadow
        Button4.FlatAppearance.BorderColor = Color.DarkGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.Location = New Point(2, 132)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 21)
        Button4.TabIndex = 2
        Button4.Text = "Sammatives"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.FlatAppearance.BorderColor = Color.DarkGray
        Button3.Location = New Point(2, 106)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 22)
        Button3.TabIndex = 1
        Button3.Text = "Formatives"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.FlatAppearance.BorderColor = Color.DarkGray
        Button2.Location = New Point(2, 78)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 24)
        Button2.TabIndex = 0
        Button2.Text = "Modules"
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
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Margin = New Padding(2)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(945, 72)
        panelTop.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2, 5)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 5
        Label3.Text = "NameOfUser"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(2, 20)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 4
        Label2.Text = "SurnameOfUser"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 45)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 1
        Label1.Text = "FACILITATOR"
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = SystemColors.ButtonShadow
        PanelLeft.Controls.Add(Logout)
        PanelLeft.Controls.Add(Button6)
        PanelLeft.Controls.Add(Button5)
        PanelLeft.Controls.Add(Button4)
        PanelLeft.Controls.Add(Button3)
        PanelLeft.Controls.Add(Button2)
        PanelLeft.Dock = DockStyle.Right
        PanelLeft.Location = New Point(945, 0)
        PanelLeft.Margin = New Padding(2)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(118, 450)
        PanelLeft.TabIndex = 3
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.MenuHighlight
        Logout.Cursor = Cursors.AppStarting
        Logout.ForeColor = SystemColors.ButtonHighlight
        Logout.Location = New Point(2, 213)
        Logout.Margin = New Padding(2)
        Logout.Name = "Logout"
        Logout.Size = New Size(54, 27)
        Logout.TabIndex = 17
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 78)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(0, 196)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(107, 93)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(882, 78)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 42)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(823, 85)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 35)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.images__5_
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(764, 85)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 35)
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' Facilitator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 450)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(panelTop)
        Controls.Add(PanelLeft)
        Controls.Add(PictureBox1)
        Name = "Facilitator"
        Text = "Facilitator"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        PanelLeft.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logout As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
