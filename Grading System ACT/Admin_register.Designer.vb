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
        adid = New TextBox()
        adgender = New TextBox()
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
        Label10 = New Label()
        PictureBox1 = New PictureBox()
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
        backtoclass2.Location = New Point(312, 772)
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
        regnowadmin.Location = New Point(665, 772)
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
        Label5.Location = New Point(404, 544)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 23
        Label5.Text = "Position:"
        ' 
        ' adid
        ' 
        adid.Anchor = AnchorStyles.Top
        adid.Location = New Point(493, 536)
        adid.Name = "adid"
        adid.Size = New Size(331, 23)
        adid.TabIndex = 22
        ' 
        ' adgender
        ' 
        adgender.Anchor = AnchorStyles.Top
        adgender.Location = New Point(652, 481)
        adgender.Name = "adgender"
        adgender.Size = New Size(83, 23)
        adgender.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(598, 484)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 20
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(405, 484)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 19
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(405, 433)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 18
        Label2.Text = "Fullname:"
        ' 
        ' adage
        ' 
        adage.Anchor = AnchorStyles.Top
        adage.Location = New Point(495, 481)
        adage.Name = "adage"
        adage.Size = New Size(87, 23)
        adage.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(370, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 72)
        Label1.TabIndex = 16
        Label1.Text = "Admin Register"
        ' 
        ' adname
        ' 
        adname.Anchor = AnchorStyles.Top
        adname.Location = New Point(493, 430)
        adname.Name = "adname"
        adname.Size = New Size(331, 23)
        adname.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(404, 604)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 31
        Label8.Text = "Verification ID:"
        ' 
        ' adveri
        ' 
        adveri.Anchor = AnchorStyles.Top
        adveri.Location = New Point(493, 601)
        adveri.Name = "adveri"
        adveri.Size = New Size(331, 23)
        adveri.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(404, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 33
        Label6.Text = "Email:"
        ' 
        ' ademail
        ' 
        ademail.Anchor = AnchorStyles.Top
        ademail.Location = New Point(493, 383)
        ademail.Name = "ademail"
        ademail.Size = New Size(331, 23)
        ademail.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Location = New Point(404, 662)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 15)
        Label9.TabIndex = 35
        Label9.Text = "Password:"
        ' 
        ' adpassword
        ' 
        adpassword.Anchor = AnchorStyles.Top
        adpassword.Location = New Point(493, 659)
        adpassword.Name = "adpassword"
        adpassword.Size = New Size(331, 23)
        adpassword.TabIndex = 34
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(660, 507)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 13)
        Label10.TabIndex = 36
        Label10.Text = "M or F Only"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(230, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' Admin_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 844)
        Controls.Add(PictureBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(adpassword)
        Controls.Add(Label6)
        Controls.Add(ademail)
        Controls.Add(Label8)
        Controls.Add(adveri)
        Controls.Add(backtoclass2)
        Controls.Add(regnowadmin)
        Controls.Add(Label5)
        Controls.Add(adid)
        Controls.Add(adgender)
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
    Friend WithEvents adid As TextBox
    Friend WithEvents adgender As TextBox
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
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
