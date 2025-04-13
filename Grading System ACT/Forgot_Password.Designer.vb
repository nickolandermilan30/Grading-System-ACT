<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgot_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgot_Password))
        PictureBox1 = New PictureBox()
        seepassforgot = New CheckBox()
        Label2 = New Label()
        Email = New Label()
        passwordforgot = New TextBox()
        emailforgot = New TextBox()
        changepassword = New Button()
        backtomain = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(166, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' seepassforgot
        ' 
        seepassforgot.AutoSize = True
        seepassforgot.Location = New Point(292, 286)
        seepassforgot.Name = "seepassforgot"
        seepassforgot.Size = New Size(97, 19)
        seepassforgot.TabIndex = 13
        seepassforgot.Text = "See password"
        seepassforgot.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 12
        Label2.Text = "Password"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(43, 147)
        Email.Name = "Email"
        Email.Size = New Size(36, 15)
        Email.TabIndex = 11
        Email.Text = "Email"
        ' 
        ' passwordforgot
        ' 
        passwordforgot.Location = New Point(43, 245)
        passwordforgot.Name = "passwordforgot"
        passwordforgot.Size = New Size(346, 23)
        passwordforgot.TabIndex = 10
        ' 
        ' emailforgot
        ' 
        emailforgot.Location = New Point(43, 175)
        emailforgot.Name = "emailforgot"
        emailforgot.Size = New Size(346, 23)
        emailforgot.TabIndex = 9
        ' 
        ' changepassword
        ' 
        changepassword.BackColor = SystemColors.ActiveCaptionText
        changepassword.FlatAppearance.BorderColor = Color.White
        changepassword.FlatAppearance.BorderSize = 0
        changepassword.FlatStyle = FlatStyle.Flat
        changepassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        changepassword.ForeColor = SystemColors.ControlLightLight
        changepassword.Location = New Point(43, 337)
        changepassword.Name = "changepassword"
        changepassword.RightToLeft = RightToLeft.No
        changepassword.Size = New Size(346, 35)
        changepassword.TabIndex = 15
        changepassword.Text = "Change Password"
        changepassword.UseVisualStyleBackColor = False
        ' 
        ' backtomain
        ' 
        backtomain.BackColor = Color.Red
        backtomain.FlatAppearance.BorderColor = Color.White
        backtomain.FlatAppearance.BorderSize = 0
        backtomain.FlatStyle = FlatStyle.Flat
        backtomain.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtomain.ForeColor = SystemColors.ControlLightLight
        backtomain.Location = New Point(43, 387)
        backtomain.Name = "backtomain"
        backtomain.RightToLeft = RightToLeft.No
        backtomain.Size = New Size(346, 35)
        backtomain.TabIndex = 16
        backtomain.Text = "Back"
        backtomain.UseVisualStyleBackColor = False
        ' 
        ' Forgot_Password
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 446)
        Controls.Add(backtomain)
        Controls.Add(changepassword)
        Controls.Add(PictureBox1)
        Controls.Add(seepassforgot)
        Controls.Add(Label2)
        Controls.Add(Email)
        Controls.Add(passwordforgot)
        Controls.Add(emailforgot)
        FormBorderStyle = FormBorderStyle.None
        Name = "Forgot_Password"
        Text = "   "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seepassforgot As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As Label
    Friend WithEvents passwordforgot As TextBox
    Friend WithEvents emailforgot As TextBox
    Friend WithEvents changepassword As Button
    Friend WithEvents backtomain As Button
End Class
