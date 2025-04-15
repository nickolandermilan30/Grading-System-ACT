<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grading))
        PictureBox1 = New PictureBox()
        classparticipation = New TextBox()
        Label2 = New Label()
        activity = New TextBox()
        Label3 = New Label()
        quiz = New TextBox()
        ba = New Label()
        project = New TextBox()
        Label5 = New Label()
        exercises = New TextBox()
        Label6 = New Label()
        assigment = New TextBox()
        Label8 = New Label()
        exam = New TextBox()
        Label9 = New Label()
        projectevalution = New TextBox()
        Label10 = New Label()
        subjectgrading = New Label()
        closebtn = New Button()
        applycolumn = New Button()
        Label4 = New Label()
        totalgrade = New Label()
        standinggrade = New Label()
        Label12 = New Label()
        namegrading = New Label()
        semester = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' classparticipation
        ' 
        classparticipation.Location = New Point(349, 254)
        classparticipation.Name = "classparticipation"
        classparticipation.Size = New Size(51, 23)
        classparticipation.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(236, 257)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 13
        Label2.Text = "Class Participation:"
        ' 
        ' activity
        ' 
        activity.Location = New Point(303, 300)
        activity.Name = "activity"
        activity.Size = New Size(97, 23)
        activity.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(236, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 17
        Label3.Text = " Activities:"
        ' 
        ' quiz
        ' 
        quiz.Location = New Point(93, 257)
        quiz.Name = "quiz"
        quiz.Size = New Size(122, 23)
        quiz.TabIndex = 16
        ' 
        ' ba
        ' 
        ba.AutoSize = True
        ba.Location = New Point(51, 260)
        ba.Name = "ba"
        ba.Size = New Size(34, 15)
        ba.TabIndex = 15
        ba.Text = "Quiz:"
        ' 
        ' project
        ' 
        project.Location = New Point(294, 347)
        project.Name = "project"
        project.Size = New Size(106, 23)
        project.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(236, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 21
        Label5.Text = "Projects:"
        ' 
        ' exercises
        ' 
        exercises.Location = New Point(113, 304)
        exercises.Name = "exercises"
        exercises.Size = New Size(102, 23)
        exercises.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(51, 307)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 19
        Label6.Text = "Exercises:"
        ' 
        ' assigment
        ' 
        assigment.Location = New Point(135, 354)
        assigment.Name = "assigment"
        assigment.Size = New Size(80, 23)
        assigment.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(51, 357)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 23
        Label8.Text = "Assignments:"
        ' 
        ' exam
        ' 
        exam.Location = New Point(278, 400)
        exam.Name = "exam"
        exam.Size = New Size(122, 23)
        exam.TabIndex = 30
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(236, 403)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 29
        Label9.Text = "Exam:"
        ' 
        ' projectevalution
        ' 
        projectevalution.Location = New Point(156, 400)
        projectevalution.Name = "projectevalution"
        projectevalution.Size = New Size(59, 23)
        projectevalution.TabIndex = 28
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(51, 403)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 15)
        Label10.TabIndex = 27
        Label10.Text = "Project Evaluation:"
        ' 
        ' subjectgrading
        ' 
        subjectgrading.AutoSize = True
        subjectgrading.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        subjectgrading.Location = New Point(237, 75)
        subjectgrading.Name = "subjectgrading"
        subjectgrading.Size = New Size(86, 30)
        subjectgrading.TabIndex = 31
        subjectgrading.Text = "Subject"
        ' 
        ' closebtn
        ' 
        closebtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        closebtn.BackColor = Color.Red
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 0
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(254, 470)
        closebtn.Name = "closebtn"
        closebtn.RightToLeft = RightToLeft.No
        closebtn.Size = New Size(146, 40)
        closebtn.TabIndex = 32
        closebtn.Text = "Back"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' applycolumn
        ' 
        applycolumn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        applycolumn.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        applycolumn.FlatAppearance.BorderColor = Color.White
        applycolumn.FlatAppearance.BorderSize = 0
        applycolumn.FlatStyle = FlatStyle.Flat
        applycolumn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        applycolumn.ForeColor = SystemColors.ControlLightLight
        applycolumn.Location = New Point(69, 470)
        applycolumn.Name = "applycolumn"
        applycolumn.RightToLeft = RightToLeft.No
        applycolumn.Size = New Size(146, 40)
        applycolumn.TabIndex = 33
        applycolumn.Text = "Apply"
        applycolumn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(237, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 34
        Label4.Text = "Total:"
        ' 
        ' totalgrade
        ' 
        totalgrade.AutoSize = True
        totalgrade.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalgrade.Location = New Point(303, 129)
        totalgrade.Name = "totalgrade"
        totalgrade.Size = New Size(48, 25)
        totalgrade.TabIndex = 35
        totalgrade.Text = "N/A"
        ' 
        ' standinggrade
        ' 
        standinggrade.AutoSize = True
        standinggrade.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        standinggrade.Location = New Point(303, 173)
        standinggrade.Name = "standinggrade"
        standinggrade.Size = New Size(61, 32)
        standinggrade.TabIndex = 37
        standinggrade.Text = "N/A"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(51, 31)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 21)
        Label12.TabIndex = 38
        Label12.Text = "Name:"
        ' 
        ' namegrading
        ' 
        namegrading.AutoSize = True
        namegrading.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        namegrading.Location = New Point(117, 29)
        namegrading.Name = "namegrading"
        namegrading.Size = New Size(37, 21)
        namegrading.TabIndex = 39
        namegrading.Text = "N/A"
        ' 
        ' semester
        ' 
        semester.AutoSize = True
        semester.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        semester.Location = New Point(347, 24)
        semester.Name = "semester"
        semester.Size = New Size(102, 30)
        semester.TabIndex = 40
        semester.Text = "Semester"
        ' 
        ' Grading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(461, 537)
        Controls.Add(semester)
        Controls.Add(namegrading)
        Controls.Add(Label12)
        Controls.Add(standinggrade)
        Controls.Add(totalgrade)
        Controls.Add(Label4)
        Controls.Add(applycolumn)
        Controls.Add(closebtn)
        Controls.Add(subjectgrading)
        Controls.Add(exam)
        Controls.Add(Label9)
        Controls.Add(projectevalution)
        Controls.Add(Label10)
        Controls.Add(assigment)
        Controls.Add(Label8)
        Controls.Add(project)
        Controls.Add(Label5)
        Controls.Add(exercises)
        Controls.Add(Label6)
        Controls.Add(activity)
        Controls.Add(Label3)
        Controls.Add(quiz)
        Controls.Add(ba)
        Controls.Add(classparticipation)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Grading"
        Text = "Grading"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents classparticipation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents activity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents quiz As TextBox
    Friend WithEvents ba As Label
    Friend WithEvents project As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents exercises As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents assigment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents exam As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents projectevalution As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents subjectgrading As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents applycolumn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents totalgrade As Label
    Friend WithEvents standinggrade As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents namegrading As Label
    Friend WithEvents semester As Label
End Class
