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
        backtoclass2 = New Button()
        regnowadmin = New Button()
        Label7 = New Label()
        addepartment = New ComboBox()
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
        SuspendLayout()
        ' 
        ' backtoclass2
        ' 
        backtoclass2.BackColor = Color.Red
        backtoclass2.FlatAppearance.BorderColor = Color.White
        backtoclass2.FlatAppearance.BorderSize = 0
        backtoclass2.FlatStyle = FlatStyle.Flat
        backtoclass2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass2.ForeColor = SystemColors.ControlLightLight
        backtoclass2.Location = New Point(168, 593)
        backtoclass2.Margin = New Padding(3, 4, 3, 4)
        backtoclass2.Name = "backtoclass2"
        backtoclass2.RightToLeft = RightToLeft.No
        backtoclass2.Size = New Size(206, 47)
        backtoclass2.TabIndex = 29
        backtoclass2.Text = "Back"
        backtoclass2.UseVisualStyleBackColor = False
        ' 
        ' regnowadmin
        ' 
        regnowadmin.BackColor = SystemColors.ActiveCaptionText
        regnowadmin.FlatAppearance.BorderColor = Color.White
        regnowadmin.FlatAppearance.BorderSize = 0
        regnowadmin.FlatStyle = FlatStyle.Flat
        regnowadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowadmin.ForeColor = SystemColors.ControlLightLight
        regnowadmin.Location = New Point(168, 521)
        regnowadmin.Margin = New Padding(3, 4, 3, 4)
        regnowadmin.Name = "regnowadmin"
        regnowadmin.RightToLeft = RightToLeft.No
        regnowadmin.Size = New Size(206, 47)
        regnowadmin.TabIndex = 28
        regnowadmin.Text = "Register Now"
        regnowadmin.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(50, 416)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 27
        Label7.Text = "Department:"
        ' 
        ' addepartment
        ' 
        addepartment.FormattingEnabled = True
        addepartment.Location = New Point(141, 412)
        addepartment.Margin = New Padding(3, 4, 3, 4)
        addepartment.Name = "addepartment"
        addepartment.Size = New Size(138, 28)
        addepartment.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(73, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 23
        Label5.Text = "Position:"
        ' 
        ' adid
        ' 
        adid.Location = New Point(141, 280)
        adid.Margin = New Padding(3, 4, 3, 4)
        adid.Name = "adid"
        adid.Size = New Size(274, 27)
        adid.TabIndex = 22
        ' 
        ' adgender
        ' 
        adgender.Location = New Point(320, 209)
        adgender.Margin = New Padding(3, 4, 3, 4)
        adgender.Name = "adgender"
        adgender.Size = New Size(94, 27)
        adgender.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(258, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 20
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 19
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 18
        Label2.Text = "Fullname:"
        ' 
        ' adage
        ' 
        adage.Location = New Point(141, 209)
        adage.Margin = New Padding(3, 4, 3, 4)
        adage.Name = "adage"
        adage.Size = New Size(99, 27)
        adage.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(168, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 37)
        Label1.TabIndex = 16
        Label1.Text = "Admin Register"
        ' 
        ' adname
        ' 
        adname.Location = New Point(141, 143)
        adname.Margin = New Padding(3, 4, 3, 4)
        adname.Name = "adname"
        adname.Size = New Size(274, 27)
        adname.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(39, 344)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 20)
        Label8.TabIndex = 31
        Label8.Text = "Verification ID:"
        ' 
        ' adveri
        ' 
        adveri.Location = New Point(141, 340)
        adveri.Margin = New Padding(3, 4, 3, 4)
        adveri.Name = "adveri"
        adveri.Size = New Size(274, 27)
        adveri.TabIndex = 30
        ' 
        ' Admin_register
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 700)
        Controls.Add(Label8)
        Controls.Add(adveri)
        Controls.Add(backtoclass2)
        Controls.Add(regnowadmin)
        Controls.Add(Label7)
        Controls.Add(addepartment)
        Controls.Add(Label5)
        Controls.Add(adid)
        Controls.Add(adgender)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(adage)
        Controls.Add(Label1)
        Controls.Add(adname)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Admin_register"
        Text = "Admin_register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backtoclass2 As Button
    Friend WithEvents regnowadmin As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents addepartment As ComboBox
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
End Class
