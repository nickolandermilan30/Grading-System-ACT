<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        studname = New TextBox()
        Label1 = New Label()
        studage = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        studgender = New TextBox()
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
        SuspendLayout()
        ' 
        ' studname
        ' 
        studname.Location = New Point(112, 108)
        studname.Name = "studname"
        studname.Size = New Size(240, 23)
        studname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(136, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 30)
        Label1.TabIndex = 1
        Label1.Text = "Student Register"
        ' 
        ' studage
        ' 
        studage.Location = New Point(112, 188)
        studage.Name = "studage"
        studage.Size = New Size(87, 23)
        studage.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "Fullname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 4
        Label3.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(215, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 5
        Label4.Text = "Gender:"
        ' 
        ' studgender
        ' 
        studgender.Location = New Point(269, 188)
        studgender.Name = "studgender"
        studgender.Size = New Size(83, 23)
        studgender.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 8
        Label5.Text = "Student ID:"
        ' 
        ' studid
        ' 
        studid.Location = New Point(112, 234)
        studid.Name = "studid"
        studid.Size = New Size(240, 23)
        studid.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(57, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 10
        Label6.Text = "Section:"
        ' 
        ' studsection
        ' 
        studsection.Location = New Point(112, 272)
        studsection.Name = "studsection"
        studsection.Size = New Size(240, 23)
        studsection.TabIndex = 9
        ' 
        ' studdepartment
        ' 
        studdepartment.FormattingEnabled = True
        studdepartment.Location = New Point(112, 354)
        studdepartment.Name = "studdepartment"
        studdepartment.Size = New Size(121, 23)
        studdepartment.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 357)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 12
        Label7.Text = "Department:"
        ' 
        ' regnowstudent
        ' 
        regnowstudent.BackColor = SystemColors.ActiveCaptionText
        regnowstudent.FlatAppearance.BorderColor = Color.White
        regnowstudent.FlatAppearance.BorderSize = 0
        regnowstudent.FlatStyle = FlatStyle.Flat
        regnowstudent.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowstudent.ForeColor = SystemColors.ControlLightLight
        regnowstudent.Location = New Point(136, 392)
        regnowstudent.Name = "regnowstudent"
        regnowstudent.RightToLeft = RightToLeft.No
        regnowstudent.Size = New Size(180, 35)
        regnowstudent.TabIndex = 13
        regnowstudent.Text = "Register Now"
        regnowstudent.UseVisualStyleBackColor = False
        ' 
        ' backtoclass
        ' 
        backtoclass.BackColor = Color.Red
        backtoclass.FlatAppearance.BorderColor = Color.White
        backtoclass.FlatAppearance.BorderSize = 0
        backtoclass.FlatStyle = FlatStyle.Flat
        backtoclass.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass.ForeColor = SystemColors.ControlLightLight
        backtoclass.Location = New Point(136, 446)
        backtoclass.Name = "backtoclass"
        backtoclass.RightToLeft = RightToLeft.No
        backtoclass.Size = New Size(180, 35)
        backtoclass.TabIndex = 14
        backtoclass.Text = "Back"
        backtoclass.UseVisualStyleBackColor = False
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(47, 152)
        Email.Name = "Email"
        Email.Size = New Size(39, 15)
        Email.TabIndex = 16
        Email.Text = "Email:"
        ' 
        ' emailstud
        ' 
        emailstud.Location = New Point(114, 149)
        emailstud.Name = "emailstud"
        emailstud.Size = New Size(240, 23)
        emailstud.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(47, 314)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 18
        Label8.Text = "Password:"
        ' 
        ' passstud
        ' 
        passstud.Location = New Point(112, 311)
        passstud.Name = "passstud"
        passstud.Size = New Size(240, 23)
        passstud.TabIndex = 17
        ' 
        ' Student_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 525)
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
        Controls.Add(studgender)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(studage)
        Controls.Add(Label1)
        Controls.Add(studname)
        FormBorderStyle = FormBorderStyle.None
        Name = "Student_register"
        Text = "Student_register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studgender As TextBox
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
End Class
