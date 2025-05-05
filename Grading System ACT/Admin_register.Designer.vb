<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_register))
        backtoclass2 = New Button()
        regnowadmin = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        adage = New TextBox()
        Label1 = New Label()
        adname = New TextBox()
        Label8 = New Label()
        adveri = New TextBox()
        Label6 = New Label()
        ademail = New TextBox()
        Label9 = New Label()
        adpassword = New TextBox()
        PictureBox1 = New PictureBox()
        adgender = New ComboBox()
        adid = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backtoclass2
        ' 
        backtoclass2.Anchor = AnchorStyles.Top
        backtoclass2.BackColor = Color.Red
        backtoclass2.FlatAppearance.BorderColor = Color.White
        backtoclass2.FlatAppearance.BorderSize = 0
        backtoclass2.FlatStyle = FlatStyle.Flat
        backtoclass2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass2.ForeColor = SystemColors.ControlLightLight
        backtoclass2.Location = New Point(323, 633)
        backtoclass2.Name = "backtoclass2"
        backtoclass2.RightToLeft = RightToLeft.No
        backtoclass2.Size = New Size(326, 35)
        backtoclass2.TabIndex = 29
        backtoclass2.Text = "Back"
        backtoclass2.UseVisualStyleBackColor = False
        ' 
        ' regnowadmin
        ' 
        regnowadmin.Anchor = AnchorStyles.Top
        regnowadmin.BackColor = SystemColors.ActiveCaptionText
        regnowadmin.FlatAppearance.BorderColor = Color.White
        regnowadmin.FlatAppearance.BorderSize = 0
        regnowadmin.FlatStyle = FlatStyle.Flat
        regnowadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowadmin.ForeColor = SystemColors.ControlLightLight
        regnowadmin.Location = New Point(676, 633)
        regnowadmin.Name = "regnowadmin"
        regnowadmin.RightToLeft = RightToLeft.No
        regnowadmin.Size = New Size(326, 35)
        regnowadmin.TabIndex = 28
        regnowadmin.Text = "Register Now"
        regnowadmin.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(415, 405)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 23
        Label5.Text = "Position:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(609, 345)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 20
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(416, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 19
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(416, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 18
        Label2.Text = "Fullname:"
        ' 
        ' adage
        ' 
        adage.Anchor = AnchorStyles.Top
        adage.Location = New Point(506, 342)
        adage.Name = "adage"
        adage.Size = New Size(87, 23)
        adage.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(381, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 72)
        Label1.TabIndex = 16
        Label1.Text = "Admin Register"
        ' 
        ' adname
        ' 
        adname.Anchor = AnchorStyles.Top
        adname.Location = New Point(504, 291)
        adname.Name = "adname"
        adname.Size = New Size(331, 23)
        adname.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(415, 465)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 31
        Label8.Text = "Verification ID:"
        ' 
        ' adveri
        ' 
        adveri.Anchor = AnchorStyles.Top
        adveri.Location = New Point(504, 462)
        adveri.Name = "adveri"
        adveri.Size = New Size(331, 23)
        adveri.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(415, 247)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 33
        Label6.Text = "Email:"
        ' 
        ' ademail
        ' 
        ademail.Anchor = AnchorStyles.Top
        ademail.Location = New Point(504, 244)
        ademail.Name = "ademail"
        ademail.Size = New Size(331, 23)
        ademail.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Location = New Point(415, 523)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 15)
        Label9.TabIndex = 35
        Label9.Text = "Password:"
        ' 
        ' adpassword
        ' 
        adpassword.Anchor = AnchorStyles.Top
        adpassword.Location = New Point(504, 520)
        adpassword.Name = "adpassword"
        adpassword.Size = New Size(331, 23)
        adpassword.TabIndex = 34
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(194, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' adgender
        ' 
        adgender.Anchor = AnchorStyles.Top
        adgender.FormattingEnabled = True
        adgender.Location = New Point(676, 342)
        adgender.Name = "adgender"
        adgender.Size = New Size(62, 23)
        adgender.TabIndex = 38
        ' 
        ' adid
        ' 
        adid.Anchor = AnchorStyles.Top
        adid.FormattingEnabled = True
        adid.Location = New Point(506, 402)
        adid.Name = "adid"
        adid.Size = New Size(329, 23)
        adid.TabIndex = 39
        ' 
        ' Admin_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 806)
        Controls.Add(adid)
        Controls.Add(adgender)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(adpassword)
        Controls.Add(Label6)
        Controls.Add(ademail)
        Controls.Add(Label8)
        Controls.Add(adveri)
        Controls.Add(backtoclass2)
        Controls.Add(regnowadmin)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(adage)
        Controls.Add(Label1)
        Controls.Add(adname)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Admin_register"
        Text = "Admin_register"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backtoclass2 As Button
    Friend WithEvents regnowadmin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents adname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents adveri As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ademail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents adpassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents adgender As ComboBox
    Friend WithEvents adid As ComboBox
End Class
