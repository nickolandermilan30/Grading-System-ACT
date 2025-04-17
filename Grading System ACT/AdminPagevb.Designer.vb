<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPagevb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPagevb))
        PictureBox1 = New PictureBox()
        allgradelist = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        subjectlistadmin = New CheckedListBox()
        Label3 = New Label()
        deletesubject = New Button()
        logoutadmin = New Button()
        teacherlist = New CheckedListBox()
        Label4 = New Label()
        malecount = New Label()
        femalecount = New Label()
        femaleliststudent = New ListView()
        malestudentlist = New ListView()
        Label5 = New Label()
        nameadmin = New Label()
        departmentadminname = New Label()
        Label7 = New Label()
        accounts = New Button()
        allgradespoints = New DataGridView()
        prelim = New Button()
        midterm = New Button()
        semifinals = New Button()
        finals = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(allgradelist, ComponentModel.ISupportInitialize).BeginInit()
        CType(allgradespoints, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' allgradelist
        ' 
        allgradelist.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        allgradelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        allgradelist.Location = New Point(211, 298)
        allgradelist.Name = "allgradelist"
        allgradelist.Size = New Size(648, 262)
        allgradelist.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(885, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 20
        Label1.Text = "Male Student"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(885, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 21
        Label2.Text = "Female Student"
        ' 
        ' subjectlistadmin
        ' 
        subjectlistadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        subjectlistadmin.FormattingEnabled = True
        subjectlistadmin.Location = New Point(885, 554)
        subjectlistadmin.Name = "subjectlistadmin"
        subjectlistadmin.Size = New Size(345, 202)
        subjectlistadmin.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(885, 522)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 23
        Label3.Text = "Subjects"
        ' 
        ' deletesubject
        ' 
        deletesubject.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        deletesubject.BackColor = Color.Red
        deletesubject.FlatAppearance.BorderColor = Color.White
        deletesubject.FlatAppearance.BorderSize = 0
        deletesubject.FlatStyle = FlatStyle.Flat
        deletesubject.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deletesubject.ForeColor = SystemColors.ControlLightLight
        deletesubject.Location = New Point(885, 767)
        deletesubject.Name = "deletesubject"
        deletesubject.RightToLeft = RightToLeft.No
        deletesubject.Size = New Size(345, 40)
        deletesubject.TabIndex = 24
        deletesubject.Text = "Delete Subject"
        deletesubject.UseVisualStyleBackColor = False
        ' 
        ' logoutadmin
        ' 
        logoutadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        logoutadmin.BackColor = Color.Red
        logoutadmin.FlatAppearance.BorderColor = Color.White
        logoutadmin.FlatAppearance.BorderSize = 0
        logoutadmin.FlatStyle = FlatStyle.Flat
        logoutadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutadmin.ForeColor = SystemColors.ControlLightLight
        logoutadmin.Location = New Point(25, 767)
        logoutadmin.Name = "logoutadmin"
        logoutadmin.RightToLeft = RightToLeft.No
        logoutadmin.Size = New Size(164, 40)
        logoutadmin.TabIndex = 25
        logoutadmin.Text = "Log out"
        logoutadmin.UseVisualStyleBackColor = False
        ' 
        ' teacherlist
        ' 
        teacherlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        teacherlist.FormattingEnabled = True
        teacherlist.Location = New Point(211, 96)
        teacherlist.Name = "teacherlist"
        teacherlist.Size = New Size(648, 184)
        teacherlist.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(211, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 27
        Label4.Text = "Teachers"
        ' 
        ' malecount
        ' 
        malecount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        malecount.AutoSize = True
        malecount.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        malecount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        malecount.Location = New Point(1191, 25)
        malecount.Name = "malecount"
        malecount.Size = New Size(39, 20)
        malecount.TabIndex = 28
        malecount.Text = "N/A"
        ' 
        ' femalecount
        ' 
        femalecount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        femalecount.AutoSize = True
        femalecount.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        femalecount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        femalecount.Location = New Point(1191, 279)
        femalecount.Name = "femalecount"
        femalecount.Size = New Size(39, 20)
        femalecount.TabIndex = 29
        femalecount.Text = "N/A"
        ' 
        ' femaleliststudent
        ' 
        femaleliststudent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        femaleliststudent.Location = New Point(885, 314)
        femaleliststudent.Name = "femaleliststudent"
        femaleliststudent.Size = New Size(345, 195)
        femaleliststudent.TabIndex = 31
        femaleliststudent.UseCompatibleStateImageBehavior = False
        ' 
        ' malestudentlist
        ' 
        malestudentlist.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        malestudentlist.Location = New Point(885, 61)
        malestudentlist.Name = "malestudentlist"
        malestudentlist.Size = New Size(345, 195)
        malestudentlist.TabIndex = 32
        malestudentlist.UseCompatibleStateImageBehavior = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(211, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 33
        Label5.Text = "Name:"
        ' 
        ' nameadmin
        ' 
        nameadmin.AutoSize = True
        nameadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameadmin.Location = New Point(272, 28)
        nameadmin.Name = "nameadmin"
        nameadmin.Size = New Size(31, 17)
        nameadmin.TabIndex = 34
        nameadmin.Text = "N/A"
        ' 
        ' departmentadminname
        ' 
        departmentadminname.AutoSize = True
        departmentadminname.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentadminname.Location = New Point(679, 28)
        departmentadminname.Name = "departmentadminname"
        departmentadminname.Size = New Size(31, 17)
        departmentadminname.TabIndex = 36
        departmentadminname.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(575, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 20)
        Label7.TabIndex = 35
        Label7.Text = "Department:"
        ' 
        ' accounts
        ' 
        accounts.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        accounts.BackColor = Color.Green
        accounts.FlatAppearance.BorderColor = Color.White
        accounts.FlatAppearance.BorderSize = 0
        accounts.FlatStyle = FlatStyle.Flat
        accounts.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        accounts.ForeColor = SystemColors.ControlLightLight
        accounts.Location = New Point(25, 707)
        accounts.Name = "accounts"
        accounts.RightToLeft = RightToLeft.No
        accounts.Size = New Size(164, 40)
        accounts.TabIndex = 37
        accounts.Text = "Accounts"
        accounts.UseVisualStyleBackColor = False
        ' 
        ' allgradespoints
        ' 
        allgradespoints.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        allgradespoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        allgradespoints.Location = New Point(211, 589)
        allgradespoints.Name = "allgradespoints"
        allgradespoints.Size = New Size(648, 218)
        allgradespoints.TabIndex = 38
        ' 
        ' prelim
        ' 
        prelim.BackColor = SystemColors.ActiveCaptionText
        prelim.FlatAppearance.BorderColor = Color.White
        prelim.FlatAppearance.BorderSize = 0
        prelim.FlatStyle = FlatStyle.Flat
        prelim.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prelim.ForeColor = SystemColors.ControlLightLight
        prelim.Location = New Point(12, 306)
        prelim.Name = "prelim"
        prelim.RightToLeft = RightToLeft.No
        prelim.Size = New Size(177, 43)
        prelim.TabIndex = 39
        prelim.Text = "Prelim"
        prelim.UseVisualStyleBackColor = False
        ' 
        ' midterm
        ' 
        midterm.BackColor = SystemColors.ActiveCaptionText
        midterm.FlatAppearance.BorderColor = Color.White
        midterm.FlatAppearance.BorderSize = 0
        midterm.FlatStyle = FlatStyle.Flat
        midterm.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midterm.ForeColor = SystemColors.ControlLightLight
        midterm.Location = New Point(12, 373)
        midterm.Name = "midterm"
        midterm.RightToLeft = RightToLeft.No
        midterm.Size = New Size(177, 43)
        midterm.TabIndex = 40
        midterm.Text = "Midterm"
        midterm.UseVisualStyleBackColor = False
        ' 
        ' semifinals
        ' 
        semifinals.BackColor = SystemColors.ActiveCaptionText
        semifinals.FlatAppearance.BorderColor = Color.White
        semifinals.FlatAppearance.BorderSize = 0
        semifinals.FlatStyle = FlatStyle.Flat
        semifinals.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        semifinals.ForeColor = SystemColors.ControlLightLight
        semifinals.Location = New Point(12, 440)
        semifinals.Name = "semifinals"
        semifinals.RightToLeft = RightToLeft.No
        semifinals.Size = New Size(177, 43)
        semifinals.TabIndex = 41
        semifinals.Text = "Semi Finals"
        semifinals.UseVisualStyleBackColor = False
        ' 
        ' finals
        ' 
        finals.BackColor = SystemColors.ActiveCaptionText
        finals.FlatAppearance.BorderColor = Color.White
        finals.FlatAppearance.BorderSize = 0
        finals.FlatStyle = FlatStyle.Flat
        finals.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        finals.ForeColor = SystemColors.ControlLightLight
        finals.Location = New Point(12, 509)
        finals.Name = "finals"
        finals.RightToLeft = RightToLeft.No
        finals.Size = New Size(177, 43)
        finals.TabIndex = 42
        finals.Text = "Finals"
        finals.UseVisualStyleBackColor = False
        ' 
        ' AdminPagevb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1242, 838)
        Controls.Add(finals)
        Controls.Add(semifinals)
        Controls.Add(midterm)
        Controls.Add(prelim)
        Controls.Add(allgradespoints)
        Controls.Add(accounts)
        Controls.Add(departmentadminname)
        Controls.Add(Label7)
        Controls.Add(nameadmin)
        Controls.Add(Label5)
        Controls.Add(malestudentlist)
        Controls.Add(femaleliststudent)
        Controls.Add(femalecount)
        Controls.Add(malecount)
        Controls.Add(Label4)
        Controls.Add(teacherlist)
        Controls.Add(logoutadmin)
        Controls.Add(deletesubject)
        Controls.Add(Label3)
        Controls.Add(subjectlistadmin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(allgradelist)
        Controls.Add(PictureBox1)
        Name = "AdminPagevb"
        Text = "AdminPagevb"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(allgradelist, ComponentModel.ISupportInitialize).EndInit()
        CType(allgradespoints, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents allgradelist As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subjectlistadmin As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents deletesubject As Button
    Friend WithEvents logoutadmin As Button
    Friend WithEvents teacherlist As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents malecount As Label
    Friend WithEvents femalecount As Label
    Friend WithEvents femaleliststudent As ListView
    Friend WithEvents malestudentlist As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents nameadmin As Label
    Friend WithEvents departmentadminname As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents accounts As Button
    Friend WithEvents allgradespoints As DataGridView
    Friend WithEvents prelim As Button
    Friend WithEvents midterm As Button
    Friend WithEvents semifinals As Button
    Friend WithEvents finals As Button
End Class
