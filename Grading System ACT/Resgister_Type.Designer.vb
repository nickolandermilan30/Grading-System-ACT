<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resgister_Type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resgister_Type))
        studentbtn = New PictureBox()
        adminbtn = New PictureBox()
        teacherbtn = New PictureBox()
        Student = New Label()
        Admin = New Label()
        Label1 = New Label()
        stubtn = New Button()
        adbtn = New Button()
        teachbtn = New Button()
        backtologin = New Button()
        CType(studentbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(adminbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(teacherbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' studentbtn
        ' 
        studentbtn.Image = My.Resources.Resources.idea
        studentbtn.Location = New Point(56, 89)
        studentbtn.Name = "studentbtn"
        studentbtn.Size = New Size(165, 195)
        studentbtn.SizeMode = PictureBoxSizeMode.Zoom
        studentbtn.TabIndex = 0
        studentbtn.TabStop = False
        ' 
        ' adminbtn
        ' 
        adminbtn.Image = CType(resources.GetObject("adminbtn.Image"), Image)
        adminbtn.Location = New Point(276, 89)
        adminbtn.Name = "adminbtn"
        adminbtn.Size = New Size(165, 195)
        adminbtn.SizeMode = PictureBoxSizeMode.Zoom
        adminbtn.TabIndex = 1
        adminbtn.TabStop = False
        ' 
        ' teacherbtn
        ' 
        teacherbtn.Image = CType(resources.GetObject("teacherbtn.Image"), Image)
        teacherbtn.Location = New Point(495, 89)
        teacherbtn.Name = "teacherbtn"
        teacherbtn.Size = New Size(165, 195)
        teacherbtn.SizeMode = PictureBoxSizeMode.Zoom
        teacherbtn.TabIndex = 2
        teacherbtn.TabStop = False
        ' 
        ' Student
        ' 
        Student.AutoSize = True
        Student.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student.Location = New Point(111, 306)
        Student.Name = "Student"
        Student.Size = New Size(64, 20)
        Student.TabIndex = 3
        Student.Text = "Student"
        ' 
        ' Admin
        ' 
        Admin.AutoSize = True
        Admin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Admin.Location = New Point(327, 306)
        Admin.Name = "Admin"
        Admin.Size = New Size(56, 20)
        Admin.TabIndex = 4
        Admin.Text = "Admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(554, 306)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 5
        Label1.Text = "Teacher"
        ' 
        ' stubtn
        ' 
        stubtn.BackColor = SystemColors.ActiveCaptionText
        stubtn.FlatAppearance.BorderColor = Color.White
        stubtn.FlatAppearance.BorderSize = 0
        stubtn.FlatStyle = FlatStyle.Flat
        stubtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stubtn.ForeColor = SystemColors.ControlLightLight
        stubtn.Location = New Point(50, 356)
        stubtn.Name = "stubtn"
        stubtn.RightToLeft = RightToLeft.No
        stubtn.Size = New Size(180, 35)
        stubtn.TabIndex = 10
        stubtn.Text = "Student Register"
        stubtn.UseVisualStyleBackColor = False
        ' 
        ' adbtn
        ' 
        adbtn.BackColor = SystemColors.ActiveCaptionText
        adbtn.FlatAppearance.BorderColor = Color.White
        adbtn.FlatAppearance.BorderSize = 0
        adbtn.FlatStyle = FlatStyle.Flat
        adbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        adbtn.ForeColor = SystemColors.ControlLightLight
        adbtn.Location = New Point(272, 356)
        adbtn.Name = "adbtn"
        adbtn.RightToLeft = RightToLeft.No
        adbtn.Size = New Size(180, 35)
        adbtn.TabIndex = 11
        adbtn.Text = "Admin Register"
        adbtn.UseVisualStyleBackColor = False
        ' 
        ' teachbtn
        ' 
        teachbtn.BackColor = SystemColors.ActiveCaptionText
        teachbtn.FlatAppearance.BorderColor = Color.White
        teachbtn.FlatAppearance.BorderSize = 0
        teachbtn.FlatStyle = FlatStyle.Flat
        teachbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        teachbtn.ForeColor = SystemColors.ControlLightLight
        teachbtn.Location = New Point(492, 356)
        teachbtn.Name = "teachbtn"
        teachbtn.RightToLeft = RightToLeft.No
        teachbtn.Size = New Size(180, 35)
        teachbtn.TabIndex = 12
        teachbtn.Text = "Teacher Register"
        teachbtn.UseVisualStyleBackColor = False
        ' 
        ' backtologin
        ' 
        backtologin.BackColor = Color.Red
        backtologin.FlatAppearance.BorderColor = Color.White
        backtologin.FlatAppearance.BorderSize = 0
        backtologin.FlatStyle = FlatStyle.Flat
        backtologin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtologin.ForeColor = SystemColors.ControlLightLight
        backtologin.Location = New Point(272, 423)
        backtologin.Name = "backtologin"
        backtologin.RightToLeft = RightToLeft.No
        backtologin.Size = New Size(180, 35)
        backtologin.TabIndex = 13
        backtologin.Text = "Back"
        backtologin.UseVisualStyleBackColor = False
        ' 
        ' Resgister_Type
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 479)
        Controls.Add(backtologin)
        Controls.Add(teachbtn)
        Controls.Add(adbtn)
        Controls.Add(stubtn)
        Controls.Add(Label1)
        Controls.Add(Admin)
        Controls.Add(Student)
        Controls.Add(teacherbtn)
        Controls.Add(adminbtn)
        Controls.Add(studentbtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Resgister_Type"
        Text = "Resgister_Type"
        CType(studentbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(adminbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(teacherbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studentbtn As PictureBox
    Friend WithEvents adminbtn As PictureBox
    Friend WithEvents teacherbtn As PictureBox
    Friend WithEvents Student As Label
    Friend WithEvents Admin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents stubtn As Button
    Friend WithEvents adbtn As Button
    Friend WithEvents teachbtn As Button
    Friend WithEvents backtologin As Button
End Class
