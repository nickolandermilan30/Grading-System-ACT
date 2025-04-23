<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher_register))
        backtoclass3 = New Button()
        regnowteacher = New Button()
        Label7 = New Label()
        teachdepartment = New ComboBox()
        Label6 = New Label()
        teachmajor = New TextBox()
        Label5 = New Label()
        teachid = New TextBox()
        teachgender = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        teachage = New TextBox()
        teachname = New TextBox()
        teachemail = New Label()
        emailteach = New TextBox()
        Label8 = New Label()
        teachpassword = New TextBox()
        Label9 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backtoclass3
        ' 
        backtoclass3.Anchor = AnchorStyles.Top
        backtoclass3.BackColor = Color.Red
        backtoclass3.FlatAppearance.BorderColor = Color.White
        backtoclass3.FlatAppearance.BorderSize = 0
        backtoclass3.FlatStyle = FlatStyle.Flat
        backtoclass3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass3.ForeColor = SystemColors.ControlLightLight
        backtoclass3.Location = New Point(314, 776)
        backtoclass3.Name = "backtoclass3"
        backtoclass3.RightToLeft = RightToLeft.No
        backtoclass3.Size = New Size(326, 35)
        backtoclass3.TabIndex = 29
        backtoclass3.Text = "Back"
        backtoclass3.UseVisualStyleBackColor = False
        ' 
        ' regnowteacher
        ' 
        regnowteacher.Anchor = AnchorStyles.Top
        regnowteacher.BackColor = SystemColors.ActiveCaptionText
        regnowteacher.FlatAppearance.BorderColor = Color.White
        regnowteacher.FlatAppearance.BorderSize = 0
        regnowteacher.FlatStyle = FlatStyle.Flat
        regnowteacher.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowteacher.ForeColor = SystemColors.ControlLightLight
        regnowteacher.Location = New Point(707, 776)
        regnowteacher.Name = "regnowteacher"
        regnowteacher.RightToLeft = RightToLeft.No
        regnowteacher.Size = New Size(326, 35)
        regnowteacher.TabIndex = 28
        regnowteacher.Text = "Register Now"
        regnowteacher.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Location = New Point(393, 681)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 27
        Label7.Text = "Department:"
        ' 
        ' teachdepartment
        ' 
        teachdepartment.Anchor = AnchorStyles.Top
        teachdepartment.FormattingEnabled = True
        teachdepartment.Location = New Point(472, 678)
        teachdepartment.Name = "teachdepartment"
        teachdepartment.Size = New Size(331, 23)
        teachdepartment.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(383, 626)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 25
        Label6.Text = "Major Subject:"
        ' 
        ' teachmajor
        ' 
        teachmajor.Anchor = AnchorStyles.Top
        teachmajor.Location = New Point(472, 623)
        teachmajor.Name = "teachmajor"
        teachmajor.Size = New Size(331, 23)
        teachmajor.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(401, 514)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 23
        Label5.Text = "Teacher ID:"
        ' 
        ' teachid
        ' 
        teachid.Anchor = AnchorStyles.Top
        teachid.Location = New Point(472, 511)
        teachid.Name = "teachid"
        teachid.Size = New Size(331, 23)
        teachid.TabIndex = 22
        ' 
        ' teachgender
        ' 
        teachgender.Anchor = AnchorStyles.Top
        teachgender.Location = New Point(628, 455)
        teachgender.Name = "teachgender"
        teachgender.Size = New Size(83, 23)
        teachgender.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(574, 458)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 20
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(434, 458)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 19
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(407, 358)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 18
        Label2.Text = "Fullname:"
        ' 
        ' teachage
        ' 
        teachage.Anchor = AnchorStyles.Top
        teachage.Location = New Point(471, 455)
        teachage.Name = "teachage"
        teachage.Size = New Size(87, 23)
        teachage.TabIndex = 17
        ' 
        ' teachname
        ' 
        teachname.Anchor = AnchorStyles.Top
        teachname.Location = New Point(472, 355)
        teachname.Name = "teachname"
        teachname.Size = New Size(331, 23)
        teachname.TabIndex = 15
        ' 
        ' teachemail
        ' 
        teachemail.Anchor = AnchorStyles.Top
        teachemail.AutoSize = True
        teachemail.Location = New Point(407, 408)
        teachemail.Name = "teachemail"
        teachemail.Size = New Size(39, 15)
        teachemail.TabIndex = 31
        teachemail.Text = "Email:"
        ' 
        ' emailteach
        ' 
        emailteach.Anchor = AnchorStyles.Top
        emailteach.Location = New Point(472, 405)
        emailteach.Name = "emailteach"
        emailteach.Size = New Size(331, 23)
        emailteach.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(401, 569)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 33
        Label8.Text = "Password:"
        ' 
        ' teachpassword
        ' 
        teachpassword.Anchor = AnchorStyles.Top
        teachpassword.Location = New Point(472, 566)
        teachpassword.Name = "teachpassword"
        teachpassword.Size = New Size(331, 23)
        teachpassword.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(636, 481)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 13)
        Label9.TabIndex = 34
        Label9.Text = "M or F Only"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(339, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(563, 72)
        Label1.TabIndex = 35
        Label1.Text = "Teacher Register"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(230, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' Teacher_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 844)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(teachpassword)
        Controls.Add(teachemail)
        Controls.Add(emailteach)
        Controls.Add(backtoclass3)
        Controls.Add(regnowteacher)
        Controls.Add(Label7)
        Controls.Add(teachdepartment)
        Controls.Add(Label6)
        Controls.Add(teachmajor)
        Controls.Add(Label5)
        Controls.Add(teachid)
        Controls.Add(teachgender)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(teachage)
        Controls.Add(teachname)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Teacher_register"
        Text = "Teacher_register"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backtoclass3 As Button
    Friend WithEvents regnowteacher As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents teachdepartment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents teachmajor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents teachid As TextBox
    Friend WithEvents teachgender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents teachage As TextBox
    Friend WithEvents teachname As TextBox
    Friend WithEvents teachemail As Label
    Friend WithEvents emailteach As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents teachpassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
