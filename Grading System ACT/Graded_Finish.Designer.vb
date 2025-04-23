<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graded_Finish
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
        donemsglist = New DataGridView()
        backtomainsub2 = New Button()
        CType(donemsglist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' donemsglist
        ' 
        donemsglist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        donemsglist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        donemsglist.Location = New Point(26, 22)
        donemsglist.Name = "donemsglist"
        donemsglist.Size = New Size(779, 445)
        donemsglist.TabIndex = 22
        ' 
        ' backtomainsub2
        ' 
        backtomainsub2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        backtomainsub2.BackColor = Color.Red
        backtomainsub2.FlatAppearance.BorderColor = Color.White
        backtomainsub2.FlatAppearance.BorderSize = 0
        backtomainsub2.FlatStyle = FlatStyle.Flat
        backtomainsub2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtomainsub2.ForeColor = SystemColors.ControlLightLight
        backtomainsub2.Location = New Point(26, 480)
        backtomainsub2.Name = "backtomainsub2"
        backtomainsub2.RightToLeft = RightToLeft.No
        backtomainsub2.Size = New Size(779, 40)
        backtomainsub2.TabIndex = 23
        backtomainsub2.Text = "Close"
        backtomainsub2.UseVisualStyleBackColor = False
        ' 
        ' Graded_Finish
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(831, 540)
        Controls.Add(backtomainsub2)
        Controls.Add(donemsglist)
        Name = "Graded_Finish"
        Text = "Graded_Finish"
        CType(donemsglist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents donemsglist As DataGridView
    Friend WithEvents backtomainsub2 As Button
End Class
