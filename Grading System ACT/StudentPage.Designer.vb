<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentPage))
        gradesofeachstudent = New DataGridView()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        namestudent = New Label()
        studentdepartment = New Label()
        pointsgrades = New Button()
        subjectgrades = New Button()
        logoutstudent = New Button()
        semestergrades = New ComboBox()
        CType(gradesofeachstudent, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gradesofeachstudent
        ' 
        gradesofeachstudent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gradesofeachstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradesofeachstudent.Location = New Point(219, 12)
        gradesofeachstudent.Name = "gradesofeachstudent"
        gradesofeachstudent.Size = New Size(751, 628)
        gradesofeachstudent.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 165)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 17)
        Label1.TabIndex = 18
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 17)
        Label2.TabIndex = 19
        Label2.Text = "Department:"
        ' 
        ' namestudent
        ' 
        namestudent.AutoSize = True
        namestudent.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        namestudent.Location = New Point(73, 199)
        namestudent.Name = "namestudent"
        namestudent.Size = New Size(29, 13)
        namestudent.TabIndex = 20
        namestudent.Text = "N/A"
        ' 
        ' studentdepartment
        ' 
        studentdepartment.AutoSize = True
        studentdepartment.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentdepartment.Location = New Point(115, 228)
        studentdepartment.Name = "studentdepartment"
        studentdepartment.Size = New Size(29, 13)
        studentdepartment.TabIndex = 21
        studentdepartment.Text = "N/A"
        ' 
        ' pointsgrades
        ' 
        pointsgrades.BackColor = SystemColors.ActiveCaptionText
        pointsgrades.FlatAppearance.BorderColor = Color.White
        pointsgrades.FlatAppearance.BorderSize = 0
        pointsgrades.FlatStyle = FlatStyle.Flat
        pointsgrades.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pointsgrades.ForeColor = SystemColors.ControlLight
        pointsgrades.Location = New Point(23, 292)
        pointsgrades.Name = "pointsgrades"
        pointsgrades.RightToLeft = RightToLeft.No
        pointsgrades.Size = New Size(171, 43)
        pointsgrades.TabIndex = 22
        pointsgrades.Text = "Points of Grades"
        pointsgrades.UseVisualStyleBackColor = False
        ' 
        ' subjectgrades
        ' 
        subjectgrades.BackColor = SystemColors.ActiveCaptionText
        subjectgrades.FlatAppearance.BorderColor = Color.White
        subjectgrades.FlatAppearance.BorderSize = 0
        subjectgrades.FlatStyle = FlatStyle.Flat
        subjectgrades.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subjectgrades.ForeColor = SystemColors.ControlLight
        subjectgrades.Location = New Point(23, 358)
        subjectgrades.Name = "subjectgrades"
        subjectgrades.RightToLeft = RightToLeft.No
        subjectgrades.Size = New Size(171, 43)
        subjectgrades.TabIndex = 23
        subjectgrades.Text = "Grades"
        subjectgrades.UseVisualStyleBackColor = False
        ' 
        ' logoutstudent
        ' 
        logoutstudent.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        logoutstudent.BackColor = Color.Red
        logoutstudent.FlatAppearance.BorderColor = Color.White
        logoutstudent.FlatAppearance.BorderSize = 0
        logoutstudent.FlatStyle = FlatStyle.Flat
        logoutstudent.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutstudent.ForeColor = SystemColors.ControlLightLight
        logoutstudent.Location = New Point(23, 600)
        logoutstudent.Name = "logoutstudent"
        logoutstudent.RightToLeft = RightToLeft.No
        logoutstudent.Size = New Size(171, 40)
        logoutstudent.TabIndex = 24
        logoutstudent.Text = "Log out"
        logoutstudent.UseVisualStyleBackColor = False
        ' 
        ' semestergrades
        ' 
        semestergrades.FormattingEnabled = True
        semestergrades.Location = New Point(23, 430)
        semestergrades.Name = "semestergrades"
        semestergrades.Size = New Size(171, 23)
        semestergrades.TabIndex = 25
        ' 
        ' StudentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 652)
        Controls.Add(semestergrades)
        Controls.Add(logoutstudent)
        Controls.Add(subjectgrades)
        Controls.Add(pointsgrades)
        Controls.Add(studentdepartment)
        Controls.Add(namestudent)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(gradesofeachstudent)
        Name = "StudentPage"
        Text = "StudentPage"
        WindowState = FormWindowState.Maximized
        CType(gradesofeachstudent, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gradesofeachstudent As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namestudent As Label
    Friend WithEvents studentdepartment As Label
    Friend WithEvents pointsgrades As Button
    Friend WithEvents subjectgrades As Button
    Friend WithEvents logoutstudent As Button
    Friend WithEvents semestergrades As ComboBox
End Class
