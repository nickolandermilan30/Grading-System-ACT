﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_register))
        studname = New TextBox()
        studage = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        studid = New TextBox()
        Label6 = New Label()
        studsection = New TextBox()
        studdepartment = New ComboBox()
        Label7 = New Label()
        regnowstudent = New Button()
        backtoclass = New Button()
        Email = New Label()
        emailstud = New TextBox()
        Label8 = New Label()
        passstud = New TextBox()
        Label10 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        year = New ComboBox()
        studgender = New ComboBox()
        Label9 = New Label()
        studentstatus = New ComboBox()
        Label11 = New Label()
        contactno = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' studname
        ' 
        studname.Anchor = AnchorStyles.Top
        studname.Location = New Point(480, 208)
        studname.Name = "studname"
        studname.Size = New Size(334, 23)
        studname.TabIndex = 0
        ' 
        ' studage
        ' 
        studage.Anchor = AnchorStyles.Top
        studage.Location = New Point(483, 341)
        studage.Name = "studage"
        studage.Size = New Size(87, 23)
        studage.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(415, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "Fullname:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(443, 344)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 4
        Label3.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(586, 344)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 5
        Label4.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(412, 432)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 8
        Label5.Text = "Student ID:"
        ' 
        ' studid
        ' 
        studid.Anchor = AnchorStyles.Top
        studid.Location = New Point(483, 429)
        studid.Name = "studid"
        studid.Size = New Size(331, 23)
        studid.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(428, 474)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 10
        Label6.Text = "Section:"
        ' 
        ' studsection
        ' 
        studsection.Anchor = AnchorStyles.Top
        studsection.Location = New Point(483, 471)
        studsection.Name = "studsection"
        studsection.Size = New Size(331, 23)
        studsection.TabIndex = 9
        ' 
        ' studdepartment
        ' 
        studdepartment.Anchor = AnchorStyles.Top
        studdepartment.FormattingEnabled = True
        studdepartment.Location = New Point(483, 616)
        studdepartment.Name = "studdepartment"
        studdepartment.Size = New Size(331, 23)
        studdepartment.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Location = New Point(404, 619)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 12
        Label7.Text = "Department:"
        ' 
        ' regnowstudent
        ' 
        regnowstudent.Anchor = AnchorStyles.Top
        regnowstudent.BackColor = SystemColors.ActiveCaptionText
        regnowstudent.FlatAppearance.BorderColor = Color.White
        regnowstudent.FlatAppearance.BorderSize = 0
        regnowstudent.FlatStyle = FlatStyle.Flat
        regnowstudent.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowstudent.ForeColor = SystemColors.ControlLightLight
        regnowstudent.Location = New Point(713, 712)
        regnowstudent.Name = "regnowstudent"
        regnowstudent.RightToLeft = RightToLeft.No
        regnowstudent.Size = New Size(326, 35)
        regnowstudent.TabIndex = 13
        regnowstudent.Text = "Register Now"
        regnowstudent.UseVisualStyleBackColor = False
        ' 
        ' backtoclass
        ' 
        backtoclass.Anchor = AnchorStyles.Top
        backtoclass.BackColor = Color.Red
        backtoclass.FlatAppearance.BorderColor = Color.White
        backtoclass.FlatAppearance.BorderSize = 0
        backtoclass.FlatStyle = FlatStyle.Flat
        backtoclass.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass.ForeColor = SystemColors.ControlLightLight
        backtoclass.Location = New Point(321, 712)
        backtoclass.Name = "backtoclass"
        backtoclass.RightToLeft = RightToLeft.No
        backtoclass.Size = New Size(326, 35)
        backtoclass.TabIndex = 14
        backtoclass.Text = "Back"
        backtoclass.UseVisualStyleBackColor = False
        ' 
        ' Email
        ' 
        Email.Anchor = AnchorStyles.Top
        Email.AutoSize = True
        Email.Location = New Point(411, 297)
        Email.Name = "Email"
        Email.Size = New Size(63, 15)
        Email.TabIndex = 16
        Email.Text = "Username:"
        ' 
        ' emailstud
        ' 
        emailstud.Anchor = AnchorStyles.Top
        emailstud.Location = New Point(482, 294)
        emailstud.Name = "emailstud"
        emailstud.Size = New Size(329, 23)
        emailstud.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(418, 516)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 18
        Label8.Text = "Password:"
        ' 
        ' passstud
        ' 
        passstud.Anchor = AnchorStyles.Top
        passstud.Location = New Point(483, 513)
        passstud.Name = "passstud"
        passstud.Size = New Size(331, 23)
        passstud.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Location = New Point(440, 252)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 15)
        Label10.TabIndex = 21
        Label10.Text = "Year:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(346, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(566, 72)
        Label1.TabIndex = 24
        Label1.Text = "Student Register"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(176, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' year
        ' 
        year.Anchor = AnchorStyles.Top
        year.FormattingEnabled = True
        year.Location = New Point(480, 249)
        year.Name = "year"
        year.Size = New Size(121, 23)
        year.TabIndex = 26
        ' 
        ' studgender
        ' 
        studgender.Anchor = AnchorStyles.Top
        studgender.FormattingEnabled = True
        studgender.Location = New Point(652, 341)
        studgender.Name = "studgender"
        studgender.Size = New Size(62, 23)
        studgender.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Location = New Point(394, 568)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 15)
        Label9.TabIndex = 29
        Label9.Text = "Student Status:"
        ' 
        ' studentstatus
        ' 
        studentstatus.Anchor = AnchorStyles.Top
        studentstatus.FormattingEnabled = True
        studentstatus.Location = New Point(483, 565)
        studentstatus.Name = "studentstatus"
        studentstatus.Size = New Size(331, 23)
        studentstatus.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Location = New Point(374, 391)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 15)
        Label11.TabIndex = 30
        Label11.Text = "Contatct Number:"
        ' 
        ' contactno
        ' 
        contactno.Anchor = AnchorStyles.Top
        contactno.Location = New Point(483, 388)
        contactno.Name = "contactno"
        contactno.Size = New Size(331, 23)
        contactno.TabIndex = 31
        ' 
        ' Student_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 806)
        Controls.Add(contactno)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(studentstatus)
        Controls.Add(studgender)
        Controls.Add(year)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(passstud)
        Controls.Add(Email)
        Controls.Add(emailstud)
        Controls.Add(backtoclass)
        Controls.Add(regnowstudent)
        Controls.Add(Label7)
        Controls.Add(studdepartment)
        Controls.Add(Label6)
        Controls.Add(studsection)
        Controls.Add(Label5)
        Controls.Add(studid)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(studage)
        Controls.Add(studname)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Student_register"
        Text = "Student_register"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studname As TextBox
    Friend WithEvents studage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents studid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents studsection As TextBox
    Friend WithEvents studdepartment As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents regnowstudent As Button
    Friend WithEvents backtoclass As Button
    Friend WithEvents Email As Label
    Friend WithEvents emailstud As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents passstud As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents year As ComboBox
    Friend WithEvents studgender As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents studentstatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents contactno As TextBox
End Class
