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
        SuspendLayout()
        ' 
        ' studname
        ' 
        studname.Location = New Point(128, 144)
        studname.Margin = New Padding(3, 4, 3, 4)
        studname.Name = "studname"
        studname.Size = New Size(274, 27)
        studname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(155, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 37)
        Label1.TabIndex = 1
        Label1.Text = "Student Register"
        ' 
        ' studage
        ' 
        studage.Location = New Point(128, 211)
        studage.Margin = New Padding(3, 4, 3, 4)
        studage.Name = "studage"
        studage.Size = New Size(99, 27)
        studage.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 3
        Label2.Text = "Fullname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(86, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 4
        Label3.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(246, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 5
        Label4.Text = "Gender:"
        ' 
        ' studgender
        ' 
        studgender.Location = New Point(307, 211)
        studgender.Margin = New Padding(3, 4, 3, 4)
        studgender.Name = "studgender"
        studgender.Size = New Size(94, 27)
        studgender.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 8
        Label5.Text = "Student ID:"
        ' 
        ' studid
        ' 
        studid.Location = New Point(128, 272)
        studid.Margin = New Padding(3, 4, 3, 4)
        studid.Name = "studid"
        studid.Size = New Size(274, 27)
        studid.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(65, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 20)
        Label6.TabIndex = 10
        Label6.Text = "Section:"
        ' 
        ' studsection
        ' 
        studsection.Location = New Point(128, 341)
        studsection.Margin = New Padding(3, 4, 3, 4)
        studsection.Name = "studsection"
        studsection.Size = New Size(274, 27)
        studsection.TabIndex = 9
        ' 
        ' studdepartment
        ' 
        studdepartment.FormattingEnabled = True
        studdepartment.Location = New Point(128, 421)
        studdepartment.Margin = New Padding(3, 4, 3, 4)
        studdepartment.Name = "studdepartment"
        studdepartment.Size = New Size(138, 28)
        studdepartment.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(38, 425)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
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
        regnowstudent.Location = New Point(155, 523)
        regnowstudent.Margin = New Padding(3, 4, 3, 4)
        regnowstudent.Name = "regnowstudent"
        regnowstudent.RightToLeft = RightToLeft.No
        regnowstudent.Size = New Size(206, 47)
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
        backtoclass.Location = New Point(155, 595)
        backtoclass.Margin = New Padding(3, 4, 3, 4)
        backtoclass.Name = "backtoclass"
        backtoclass.RightToLeft = RightToLeft.No
        backtoclass.Size = New Size(206, 47)
        backtoclass.TabIndex = 14
        backtoclass.Text = "Back"
        backtoclass.UseVisualStyleBackColor = False
        ' 
        ' Student_register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 700)
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
        Margin = New Padding(3, 4, 3, 4)
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
End Class
