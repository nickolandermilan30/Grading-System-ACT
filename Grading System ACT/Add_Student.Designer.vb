<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Student))
        PictureBox1 = New PictureBox()
        studentlist = New CheckedListBox()
        addstudenttocolumn = New Button()
        backtomainsub2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 165)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' studentlist
        ' 
        studentlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        studentlist.FormattingEnabled = True
        studentlist.Location = New Point(208, 22)
        studentlist.Name = "studentlist"
        studentlist.Size = New Size(345, 400)
        studentlist.TabIndex = 17
        ' 
        ' addstudenttocolumn
        ' 
        addstudenttocolumn.BackColor = Color.Green
        addstudenttocolumn.FlatAppearance.BorderColor = Color.White
        addstudenttocolumn.FlatAppearance.BorderSize = 0
        addstudenttocolumn.FlatStyle = FlatStyle.Flat
        addstudenttocolumn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addstudenttocolumn.ForeColor = SystemColors.ControlLight
        addstudenttocolumn.Location = New Point(12, 304)
        addstudenttocolumn.Name = "addstudenttocolumn"
        addstudenttocolumn.RightToLeft = RightToLeft.No
        addstudenttocolumn.Size = New Size(171, 43)
        addstudenttocolumn.TabIndex = 19
        addstudenttocolumn.Text = "Add Student"
        addstudenttocolumn.UseVisualStyleBackColor = False
        ' 
        ' backtomainsub2
        ' 
        backtomainsub2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        backtomainsub2.BackColor = Color.Red
        backtomainsub2.FlatAppearance.BorderColor = Color.White
        backtomainsub2.FlatAppearance.BorderSize = 0
        backtomainsub2.FlatStyle = FlatStyle.Flat
        backtomainsub2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtomainsub2.ForeColor = SystemColors.ControlLightLight
        backtomainsub2.Location = New Point(12, 382)
        backtomainsub2.Name = "backtomainsub2"
        backtomainsub2.RightToLeft = RightToLeft.No
        backtomainsub2.Size = New Size(171, 40)
        backtomainsub2.TabIndex = 20
        backtomainsub2.Text = "Back"
        backtomainsub2.UseVisualStyleBackColor = False
        ' 
        ' Add_Student
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 450)
        Controls.Add(backtomainsub2)
        Controls.Add(addstudenttocolumn)
        Controls.Add(studentlist)
        Controls.Add(PictureBox1)
        Name = "Add_Student"
        Text = "Add_Student"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents studentlist As CheckedListBox
    Friend WithEvents addstudenttocolumn As Button
    Friend WithEvents backtomainsub2 As Button
End Class
