<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_Message
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
        departmentmsgpage = New Label()
        Label3 = New Label()
        namemsgpage = New Label()
        Label1 = New Label()
        studentlist = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        messagesee = New TextBox()
        CType(studentlist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' departmentmsgpage
        ' 
        departmentmsgpage.AutoSize = True
        departmentmsgpage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentmsgpage.Location = New Point(466, 27)
        departmentmsgpage.Name = "departmentmsgpage"
        departmentmsgpage.Size = New Size(31, 17)
        departmentmsgpage.TabIndex = 20
        departmentmsgpage.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(362, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 19
        Label3.Text = "Department:"
        ' 
        ' namemsgpage
        ' 
        namemsgpage.AutoSize = True
        namemsgpage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        namemsgpage.Location = New Point(83, 27)
        namemsgpage.Name = "namemsgpage"
        namemsgpage.Size = New Size(31, 17)
        namemsgpage.TabIndex = 18
        namemsgpage.Text = "N/A"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 17
        Label1.Text = "Name:"
        ' 
        ' studentlist
        ' 
        studentlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        studentlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentlist.Location = New Point(22, 112)
        studentlist.Name = "studentlist"
        studentlist.Size = New Size(1105, 362)
        studentlist.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(22, 496)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 54
        Label4.Text = "Message"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 55
        Label5.Text = "Student"
        ' 
        ' messagesee
        ' 
        messagesee.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        messagesee.Location = New Point(22, 529)
        messagesee.Multiline = True
        messagesee.Name = "messagesee"
        messagesee.Size = New Size(1105, 194)
        messagesee.TabIndex = 56
        ' 
        ' Teacher_Message
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1139, 754)
        Controls.Add(messagesee)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(studentlist)
        Controls.Add(departmentmsgpage)
        Controls.Add(Label3)
        Controls.Add(namemsgpage)
        Controls.Add(Label1)
        Name = "Teacher_Message"
        Text = "Teacher_Message"
        CType(studentlist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents departmentmsgpage As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namemsgpage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentlist As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents messagesee As TextBox
End Class
