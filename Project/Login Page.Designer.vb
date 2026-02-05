<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Timer1 = New Timer(components)
        exitButton = New Button()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Right
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(873, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 10
        Label1.Text = "Label1"
        ' 
        ' Timer1
        ' 
        ' 
        ' exitButton
        ' 
        exitButton.BackColor = Color.Red
        exitButton.Cursor = Cursors.AppStarting
        exitButton.ForeColor = SystemColors.ButtonHighlight
        exitButton.Location = New Point(424, 280)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(81, 45)
        exitButton.TabIndex = 6
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.DarkGray
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(424, 170)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(148, 33)
        ComboBox1.TabIndex = 11
        ComboBox1.Tag = "ITEMS"
        ComboBox1.Text = "Login as..."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OrangeRed
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(936, 442)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(exitButton)
        ForeColor = SystemColors.ActiveCaption
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents exitButton As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
