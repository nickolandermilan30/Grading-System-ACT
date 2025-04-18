<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        exammessage = New TextBox()
        Label9 = New Label()
        projectevalutionmessage = New TextBox()
        Label10 = New Label()
        assigmentmessage = New TextBox()
        Label8 = New Label()
        projectmessage = New TextBox()
        Label5 = New Label()
        exercisesmessage = New TextBox()
        Label6 = New Label()
        activitymessage = New TextBox()
        Label3 = New Label()
        quizmessage = New TextBox()
        ba = New Label()
        classparticipationmessage = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        studentlistmessage = New DataGridView()
        messagebox = New TextBox()
        sendmessage = New Button()
        teachernamemessage = New ComboBox()
        Label4 = New Label()
        adminname = New Label()
        CType(studentlistmessage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' exammessage
        ' 
        exammessage.Location = New Point(351, 260)
        exammessage.Name = "exammessage"
        exammessage.Size = New Size(122, 23)
        exammessage.TabIndex = 46
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(309, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 45
        Label9.Text = "Exam:"
        ' 
        ' projectevalutionmessage
        ' 
        projectevalutionmessage.Location = New Point(180, 257)
        projectevalutionmessage.Name = "projectevalutionmessage"
        projectevalutionmessage.Size = New Size(59, 23)
        projectevalutionmessage.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(75, 260)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 15)
        Label10.TabIndex = 43
        Label10.Text = "Project Evaluation:"
        ' 
        ' assigmentmessage
        ' 
        assigmentmessage.Location = New Point(159, 211)
        assigmentmessage.Name = "assigmentmessage"
        assigmentmessage.Size = New Size(80, 23)
        assigmentmessage.TabIndex = 42
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(75, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 41
        Label8.Text = "Assignments:"
        ' 
        ' projectmessage
        ' 
        projectmessage.Location = New Point(367, 214)
        projectmessage.Name = "projectmessage"
        projectmessage.Size = New Size(106, 23)
        projectmessage.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(309, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 39
        Label5.Text = "Projects:"
        ' 
        ' exercisesmessage
        ' 
        exercisesmessage.Location = New Point(137, 168)
        exercisesmessage.Name = "exercisesmessage"
        exercisesmessage.Size = New Size(102, 23)
        exercisesmessage.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(75, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 37
        Label6.Text = "Exercises:"
        ' 
        ' activitymessage
        ' 
        activitymessage.Location = New Point(376, 171)
        activitymessage.Name = "activitymessage"
        activitymessage.Size = New Size(97, 23)
        activitymessage.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(309, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 35
        Label3.Text = " Activities:"
        ' 
        ' quizmessage
        ' 
        quizmessage.Location = New Point(117, 126)
        quizmessage.Name = "quizmessage"
        quizmessage.Size = New Size(122, 23)
        quizmessage.TabIndex = 34
        ' 
        ' ba
        ' 
        ba.AutoSize = True
        ba.Location = New Point(75, 129)
        ba.Name = "ba"
        ba.Size = New Size(34, 15)
        ba.TabIndex = 33
        ba.Text = "Quiz:"
        ' 
        ' classparticipationmessage
        ' 
        classparticipationmessage.Location = New Point(422, 129)
        classparticipationmessage.Name = "classparticipationmessage"
        classparticipationmessage.Size = New Size(51, 23)
        classparticipationmessage.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(309, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 31
        Label2.Text = "Class Participation:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(50, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 21)
        Label1.TabIndex = 47
        Label1.Text = "Teachers Name:"
        ' 
        ' studentlistmessage
        ' 
        studentlistmessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        studentlistmessage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentlistmessage.Location = New Point(36, 310)
        studentlistmessage.Name = "studentlistmessage"
        studentlistmessage.Size = New Size(465, 150)
        studentlistmessage.TabIndex = 49
        ' 
        ' messagebox
        ' 
        messagebox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        messagebox.Location = New Point(36, 466)
        messagebox.Multiline = True
        messagebox.Name = "messagebox"
        messagebox.Size = New Size(465, 135)
        messagebox.TabIndex = 50
        ' 
        ' sendmessage
        ' 
        sendmessage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        sendmessage.BackColor = Color.Green
        sendmessage.FlatAppearance.BorderColor = Color.White
        sendmessage.FlatAppearance.BorderSize = 0
        sendmessage.FlatStyle = FlatStyle.Flat
        sendmessage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sendmessage.ForeColor = SystemColors.ControlLightLight
        sendmessage.Location = New Point(36, 625)
        sendmessage.Name = "sendmessage"
        sendmessage.RightToLeft = RightToLeft.No
        sendmessage.Size = New Size(465, 40)
        sendmessage.TabIndex = 51
        sendmessage.Text = "Send"
        sendmessage.UseVisualStyleBackColor = False
        ' 
        ' teachernamemessage
        ' 
        teachernamemessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        teachernamemessage.FormattingEnabled = True
        teachernamemessage.Location = New Point(183, 82)
        teachernamemessage.Name = "teachernamemessage"
        teachernamemessage.Size = New Size(290, 23)
        teachernamemessage.TabIndex = 52
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 21)
        Label4.TabIndex = 53
        Label4.Text = "Admin Name:"
        ' 
        ' adminname
        ' 
        adminname.AutoSize = True
        adminname.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminname.Location = New Point(183, 39)
        adminname.Name = "adminname"
        adminname.Size = New Size(39, 20)
        adminname.TabIndex = 54
        adminname.Text = "N/A"
        ' 
        ' Message
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 697)
        Controls.Add(adminname)
        Controls.Add(Label4)
        Controls.Add(teachernamemessage)
        Controls.Add(sendmessage)
        Controls.Add(messagebox)
        Controls.Add(studentlistmessage)
        Controls.Add(Label1)
        Controls.Add(exammessage)
        Controls.Add(Label9)
        Controls.Add(projectevalutionmessage)
        Controls.Add(Label10)
        Controls.Add(assigmentmessage)
        Controls.Add(Label8)
        Controls.Add(projectmessage)
        Controls.Add(Label5)
        Controls.Add(exercisesmessage)
        Controls.Add(Label6)
        Controls.Add(activitymessage)
        Controls.Add(Label3)
        Controls.Add(quizmessage)
        Controls.Add(ba)
        Controls.Add(classparticipationmessage)
        Controls.Add(Label2)
        Name = "Message"
        Text = "Message"
        CType(studentlistmessage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents exammessage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents projectevalutionmessage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents assigmentmessage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents projectmessage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents exercisesmessage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents activitymessage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents quizmessage As TextBox
    Friend WithEvents ba As Label
    Friend WithEvents classparticipationmessage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentlistmessage As DataGridView
    Friend WithEvents messagebox As TextBox
    Friend WithEvents sendmessage As Button
    Friend WithEvents teachernamemessage As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adminname As Label
End Class
