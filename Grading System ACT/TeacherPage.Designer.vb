<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherPage))
        grid = New DataGridView()
        PictureBox1 = New PictureBox()
        addsubject = New Button()
        addstudent = New Button()
        closebtn = New Button()
        Label1 = New Label()
        nameteachpage = New Label()
        departmentteachpage = New Label()
        Label3 = New Label()
        semesterteachpage = New ComboBox()
        refresh = New Button()
        msgbtn = New Button()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grid
        ' 
        grid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid.Location = New Point(176, 58)
        grid.Name = "grid"
        grid.Size = New Size(604, 480)
        grid.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' addsubject
        ' 
        addsubject.BackColor = SystemColors.ActiveCaptionText
        addsubject.FlatAppearance.BorderColor = Color.White
        addsubject.FlatAppearance.BorderSize = 0
        addsubject.FlatStyle = FlatStyle.Flat
        addsubject.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addsubject.ForeColor = SystemColors.ControlLightLight
        addsubject.Location = New Point(12, 212)
        addsubject.Name = "addsubject"
        addsubject.RightToLeft = RightToLeft.No
        addsubject.Size = New Size(146, 43)
        addsubject.TabIndex = 10
        addsubject.Text = "Add Subject"
        addsubject.UseVisualStyleBackColor = False
        ' 
        ' addstudent
        ' 
        addstudent.BackColor = SystemColors.ActiveCaptionText
        addstudent.FlatAppearance.BorderColor = Color.White
        addstudent.FlatAppearance.BorderSize = 0
        addstudent.FlatStyle = FlatStyle.Flat
        addstudent.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addstudent.ForeColor = SystemColors.ControlLightLight
        addstudent.Location = New Point(12, 277)
        addstudent.Name = "addstudent"
        addstudent.RightToLeft = RightToLeft.No
        addstudent.Size = New Size(146, 43)
        addstudent.TabIndex = 11
        addstudent.Text = "Add Student"
        addstudent.UseVisualStyleBackColor = False
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
        closebtn.Location = New Point(12, 498)
        closebtn.Name = "closebtn"
        closebtn.RightToLeft = RightToLeft.No
        closebtn.Size = New Size(146, 40)
        closebtn.TabIndex = 12
        closebtn.Text = "Log out"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(177, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 13
        Label1.Text = "Name:"
        ' 
        ' nameteachpage
        ' 
        nameteachpage.AutoSize = True
        nameteachpage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameteachpage.Location = New Point(238, 22)
        nameteachpage.Name = "nameteachpage"
        nameteachpage.Size = New Size(31, 17)
        nameteachpage.TabIndex = 14
        nameteachpage.Text = "N/A"
        ' 
        ' departmentteachpage
        ' 
        departmentteachpage.AutoSize = True
        departmentteachpage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentteachpage.Location = New Point(612, 23)
        departmentteachpage.Name = "departmentteachpage"
        departmentteachpage.Size = New Size(31, 17)
        departmentteachpage.TabIndex = 16
        departmentteachpage.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(508, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 15
        Label3.Text = "Department:"
        ' 
        ' semesterteachpage
        ' 
        semesterteachpage.FormattingEnabled = True
        semesterteachpage.Location = New Point(12, 165)
        semesterteachpage.Name = "semesterteachpage"
        semesterteachpage.Size = New Size(146, 23)
        semesterteachpage.TabIndex = 17
        ' 
        ' refresh
        ' 
        refresh.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        refresh.BackColor = Color.Orange
        refresh.FlatAppearance.BorderColor = Color.White
        refresh.FlatAppearance.BorderSize = 0
        refresh.FlatStyle = FlatStyle.Flat
        refresh.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        refresh.ForeColor = SystemColors.ControlLightLight
        refresh.Location = New Point(12, 441)
        refresh.Name = "refresh"
        refresh.RightToLeft = RightToLeft.No
        refresh.Size = New Size(146, 40)
        refresh.TabIndex = 18
        refresh.Text = "Refresh"
        refresh.UseVisualStyleBackColor = False
        ' 
        ' msgbtn
        ' 
        msgbtn.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        msgbtn.FlatAppearance.BorderColor = Color.White
        msgbtn.FlatAppearance.BorderSize = 0
        msgbtn.FlatStyle = FlatStyle.Flat
        msgbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        msgbtn.ForeColor = SystemColors.ControlLightLight
        msgbtn.Location = New Point(12, 339)
        msgbtn.Name = "msgbtn"
        msgbtn.RightToLeft = RightToLeft.No
        msgbtn.Size = New Size(146, 43)
        msgbtn.TabIndex = 19
        msgbtn.Text = "Message"
        msgbtn.UseVisualStyleBackColor = False
        ' 
        ' TeacherPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 550)
        Controls.Add(msgbtn)
        Controls.Add(refresh)
        Controls.Add(semesterteachpage)
        Controls.Add(departmentteachpage)
        Controls.Add(Label3)
        Controls.Add(nameteachpage)
        Controls.Add(Label1)
        Controls.Add(closebtn)
        Controls.Add(addstudent)
        Controls.Add(addsubject)
        Controls.Add(PictureBox1)
        Controls.Add(grid)
        Name = "TeacherPage"
        Text = "TeacherPage"
        WindowState = FormWindowState.Maximized
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addsubject As Button
    Friend WithEvents addstudent As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nameteachpage As Label
    Friend WithEvents departmentteachpage As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents semesterteachpage As ComboBox
    Friend WithEvents refresh As Button
    Friend WithEvents msgbtn As Button
End Class
