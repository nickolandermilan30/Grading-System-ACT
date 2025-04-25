<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_subject))
        subjectlist = New CheckedListBox()
        backtomainsub = New Button()
        addsubjecttolist = New Button()
        PictureBox1 = New PictureBox()
        inputsubject = New TextBox()
        Label1 = New Label()
        doneaddsubjecttogrid = New Button()
        nameteacheraddsubject = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' subjectlist
        ' 
        subjectlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        subjectlist.BackColor = SystemColors.Window
        subjectlist.FormattingEnabled = True
        subjectlist.Location = New Point(231, 62)
        subjectlist.Name = "subjectlist"
        subjectlist.Size = New Size(328, 364)
        subjectlist.TabIndex = 0
        ' 
        ' backtomainsub
        ' 
        backtomainsub.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        backtomainsub.BackColor = Color.Red
        backtomainsub.FlatAppearance.BorderColor = Color.White
        backtomainsub.FlatAppearance.BorderSize = 0
        backtomainsub.FlatStyle = FlatStyle.Flat
        backtomainsub.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtomainsub.ForeColor = SystemColors.ControlLightLight
        backtomainsub.Location = New Point(12, 386)
        backtomainsub.Name = "backtomainsub"
        backtomainsub.RightToLeft = RightToLeft.No
        backtomainsub.Size = New Size(190, 40)
        backtomainsub.TabIndex = 13
        backtomainsub.Text = "Back"
        backtomainsub.UseVisualStyleBackColor = False
        ' 
        ' addsubjecttolist
        ' 
        addsubjecttolist.BackColor = SystemColors.ActiveCaptionText
        addsubjecttolist.FlatAppearance.BorderColor = Color.White
        addsubjecttolist.FlatAppearance.BorderSize = 0
        addsubjecttolist.FlatStyle = FlatStyle.Flat
        addsubjecttolist.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addsubjecttolist.ForeColor = SystemColors.ControlLight
        addsubjecttolist.Location = New Point(12, 278)
        addsubjecttolist.Name = "addsubjecttolist"
        addsubjecttolist.RightToLeft = RightToLeft.No
        addsubjecttolist.Size = New Size(190, 43)
        addsubjecttolist.TabIndex = 14
        addsubjecttolist.Text = "Add Subject"
        addsubjecttolist.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(35, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' inputsubject
        ' 
        inputsubject.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inputsubject.ForeColor = Color.Black
        inputsubject.Location = New Point(17, 220)
        inputsubject.Multiline = True
        inputsubject.Name = "inputsubject"
        inputsubject.Size = New Size(185, 40)
        inputsubject.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 20)
        Label1.TabIndex = 17
        Label1.Text = "Input Your subject here"
        ' 
        ' doneaddsubjecttogrid
        ' 
        doneaddsubjecttogrid.BackColor = Color.Green
        doneaddsubjecttogrid.FlatAppearance.BorderColor = Color.White
        doneaddsubjecttogrid.FlatAppearance.BorderSize = 0
        doneaddsubjecttogrid.FlatStyle = FlatStyle.Flat
        doneaddsubjecttogrid.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        doneaddsubjecttogrid.ForeColor = SystemColors.ControlLight
        doneaddsubjecttogrid.Location = New Point(12, 332)
        doneaddsubjecttogrid.Name = "doneaddsubjecttogrid"
        doneaddsubjecttogrid.RightToLeft = RightToLeft.No
        doneaddsubjecttogrid.Size = New Size(190, 43)
        doneaddsubjecttogrid.TabIndex = 18
        doneaddsubjecttogrid.Text = "Done"
        doneaddsubjecttogrid.UseVisualStyleBackColor = False
        ' 
        ' nameteacheraddsubject
        ' 
        nameteacheraddsubject.AutoSize = True
        nameteacheraddsubject.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameteacheraddsubject.Location = New Point(292, 28)
        nameteacheraddsubject.Name = "nameteacheraddsubject"
        nameteacheraddsubject.Size = New Size(31, 17)
        nameteacheraddsubject.TabIndex = 24
        nameteacheraddsubject.Text = "N/A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(231, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 23
        Label2.Text = "Name:"
        ' 
        ' Add_subject
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 450)
        Controls.Add(nameteacheraddsubject)
        Controls.Add(Label2)
        Controls.Add(doneaddsubjecttogrid)
        Controls.Add(Label1)
        Controls.Add(inputsubject)
        Controls.Add(PictureBox1)
        Controls.Add(addsubjecttolist)
        Controls.Add(backtomainsub)
        Controls.Add(subjectlist)
        Name = "Add_subject"
        Text = "Add_subject"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents subjectlist As CheckedListBox
    Friend WithEvents backtomainsub As Button
    Friend WithEvents addsubjecttolist As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents inputsubject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents doneaddsubjecttogrid As Button
    Friend WithEvents nameteacheraddsubject As Label
    Friend WithEvents Label2 As Label
End Class
