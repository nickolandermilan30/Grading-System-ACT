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
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        addsubject = New Button()
        addstudent = New Button()
        closebtn = New Button()
        Label1 = New Label()
        name = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(176, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(559, 380)
        DataGridView1.TabIndex = 0
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
        addsubject.Location = New Point(12, 235)
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
        addstudent.Location = New Point(12, 300)
        addstudent.Name = "addstudent"
        addstudent.RightToLeft = RightToLeft.No
        addstudent.Size = New Size(146, 43)
        addstudent.TabIndex = 11
        addstudent.Text = "Add Student"
        addstudent.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Red
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 0
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(12, 398)
        closebtn.Name = "closebtn"
        closebtn.RightToLeft = RightToLeft.No
        closebtn.Size = New Size(146, 40)
        closebtn.TabIndex = 12
        closebtn.Text = "Close"
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
        ' name
        ' 
        name.AutoSize = True
        name.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        name.Location = New Point(238, 22)
        name.Name = "name"
        name.Size = New Size(31, 17)
        name.TabIndex = 14
        name.Text = "N/A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(653, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 17)
        Label2.TabIndex = 16
        Label2.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(549, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 15
        Label3.Text = "Department:"
        ' 
        ' TeacherPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 450)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(name)
        Controls.Add(Label1)
        Controls.Add(closebtn)
        Controls.Add(addstudent)
        Controls.Add(addsubject)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Name = "TeacherPage"
        Text = "TeacherPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addsubject As Button
    Friend WithEvents addstudent As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
