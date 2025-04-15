<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        emailinput = New TextBox()
        passwordinput = New TextBox()
        Email = New Label()
        Label2 = New Label()
        loginbtn = New Button()
        registerbtn = New Button()
        forgotbtn = New Button()
        seepass = New CheckBox()
        PictureBox1 = New PictureBox()
        closebtn = New Button()
        attemp = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' emailinput
        ' 
        emailinput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        emailinput.Location = New Point(52, 153)
        emailinput.Name = "emailinput"
        emailinput.Size = New Size(346, 23)
        emailinput.TabIndex = 0
        ' 
        ' passwordinput
        ' 
        passwordinput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        passwordinput.Location = New Point(52, 223)
        passwordinput.Name = "passwordinput"
        passwordinput.Size = New Size(346, 23)
        passwordinput.TabIndex = 1
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(52, 125)
        Email.Name = "Email"
        Email.Size = New Size(36, 15)
        Email.TabIndex = 2
        Email.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' loginbtn
        ' 
        loginbtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        loginbtn.BackColor = SystemColors.ActiveCaptionText
        loginbtn.FlatAppearance.BorderColor = Color.White
        loginbtn.FlatAppearance.BorderSize = 0
        loginbtn.FlatStyle = FlatStyle.Flat
        loginbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = SystemColors.ControlLightLight
        loginbtn.Location = New Point(25, 316)
        loginbtn.Name = "loginbtn"
        loginbtn.RightToLeft = RightToLeft.No
        loginbtn.Size = New Size(180, 35)
        loginbtn.TabIndex = 4
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' registerbtn
        ' 
        registerbtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        registerbtn.BackColor = SystemColors.ActiveCaptionText
        registerbtn.FlatAppearance.BorderColor = Color.White
        registerbtn.FlatAppearance.BorderSize = 0
        registerbtn.FlatStyle = FlatStyle.Flat
        registerbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registerbtn.ForeColor = SystemColors.ControlLightLight
        registerbtn.Location = New Point(234, 316)
        registerbtn.Name = "registerbtn"
        registerbtn.RightToLeft = RightToLeft.No
        registerbtn.Size = New Size(180, 35)
        registerbtn.TabIndex = 5
        registerbtn.Text = "Register"
        registerbtn.UseVisualStyleBackColor = False
        ' 
        ' forgotbtn
        ' 
        forgotbtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        forgotbtn.BackColor = SystemColors.ActiveCaptionText
        forgotbtn.FlatAppearance.BorderColor = Color.White
        forgotbtn.FlatAppearance.BorderSize = 0
        forgotbtn.FlatStyle = FlatStyle.Flat
        forgotbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        forgotbtn.ForeColor = SystemColors.ControlLightLight
        forgotbtn.Location = New Point(25, 377)
        forgotbtn.Name = "forgotbtn"
        forgotbtn.RightToLeft = RightToLeft.No
        forgotbtn.Size = New Size(180, 35)
        forgotbtn.TabIndex = 6
        forgotbtn.Text = "Forgot Password"
        forgotbtn.UseVisualStyleBackColor = False
        ' 
        ' seepass
        ' 
        seepass.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        seepass.AutoSize = True
        seepass.Location = New Point(301, 264)
        seepass.Name = "seepass"
        seepass.Size = New Size(97, 19)
        seepass.TabIndex = 7
        seepass.Text = "See password"
        seepass.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(175, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' closebtn
        ' 
        closebtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        closebtn.BackColor = Color.Red
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 0
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(234, 377)
        closebtn.Name = "closebtn"
        closebtn.RightToLeft = RightToLeft.No
        closebtn.Size = New Size(180, 35)
        closebtn.TabIndex = 9
        closebtn.Text = "Close"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' attemp
        ' 
        attemp.AutoSize = True
        attemp.Location = New Point(52, 264)
        attemp.Name = "attemp"
        attemp.Size = New Size(79, 15)
        attemp.TabIndex = 10
        attemp.Text = "Attempts: 0/5"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 446)
        Controls.Add(attemp)
        Controls.Add(closebtn)
        Controls.Add(PictureBox1)
        Controls.Add(seepass)
        Controls.Add(forgotbtn)
        Controls.Add(registerbtn)
        Controls.Add(loginbtn)
        Controls.Add(Label2)
        Controls.Add(Email)
        Controls.Add(passwordinput)
        Controls.Add(emailinput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Log In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents emailinput As TextBox
    Friend WithEvents passwordinput As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents registerbtn As Button
    Friend WithEvents forgotbtn As Button
    Friend WithEvents seepass As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closebtn As Button
    Friend WithEvents attemp As Label

End Class
