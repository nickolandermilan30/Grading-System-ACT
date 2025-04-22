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
        CType(donemsglist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' donemsglist
        ' 
        donemsglist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        donemsglist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        donemsglist.Location = New Point(26, 22)
        donemsglist.Name = "donemsglist"
        donemsglist.Size = New Size(779, 495)
        donemsglist.TabIndex = 22
        ' 
        ' Graded_Finish
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(831, 540)
        Controls.Add(donemsglist)
        Name = "Graded_Finish"
        Text = "Graded_Finish"
        CType(donemsglist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents donemsglist As DataGridView
End Class
