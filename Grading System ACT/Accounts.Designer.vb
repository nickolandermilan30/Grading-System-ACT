<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        PictureBox1 = New PictureBox()
        backbtntoadmin = New Button()
        deactiveaccount = New Button()
        accountlist = New DataGridView()
        activeaccount = New Button()
        deactivelist = New DataGridView()
        Label1 = New Label()
        refreshadmin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(accountlist, ComponentModel.ISupportInitialize).BeginInit()
        CType(deactivelist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' backbtntoadmin
        ' 
        backbtntoadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        backbtntoadmin.BackColor = Color.Red
        backbtntoadmin.FlatAppearance.BorderColor = Color.White
        backbtntoadmin.FlatAppearance.BorderSize = 0
        backbtntoadmin.FlatStyle = FlatStyle.Flat
        backbtntoadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backbtntoadmin.ForeColor = SystemColors.ControlLightLight
        backbtntoadmin.Location = New Point(12, 570)
        backbtntoadmin.Name = "backbtntoadmin"
        backbtntoadmin.RightToLeft = RightToLeft.No
        backbtntoadmin.Size = New Size(164, 40)
        backbtntoadmin.TabIndex = 28
        backbtntoadmin.Text = "Close"
        backbtntoadmin.UseVisualStyleBackColor = False
        ' 
        ' deactiveaccount
        ' 
        deactiveaccount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        deactiveaccount.BackColor = Color.Red
        deactiveaccount.FlatAppearance.BorderColor = Color.White
        deactiveaccount.FlatAppearance.BorderSize = 0
        deactiveaccount.FlatStyle = FlatStyle.Popup
        deactiveaccount.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deactiveaccount.ForeColor = SystemColors.ControlLightLight
        deactiveaccount.Location = New Point(12, 267)
        deactiveaccount.Name = "deactiveaccount"
        deactiveaccount.RightToLeft = RightToLeft.No
        deactiveaccount.Size = New Size(164, 40)
        deactiveaccount.TabIndex = 39
        deactiveaccount.Text = "Deactive"
        deactiveaccount.UseVisualStyleBackColor = False
        ' 
        ' accountlist
        ' 
        accountlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        accountlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        accountlist.Location = New Point(205, 19)
        accountlist.Name = "accountlist"
        accountlist.Size = New Size(651, 591)
        accountlist.TabIndex = 40
        ' 
        ' activeaccount
        ' 
        activeaccount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        activeaccount.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        activeaccount.FlatAppearance.BorderColor = Color.White
        activeaccount.FlatAppearance.BorderSize = 0
        activeaccount.FlatStyle = FlatStyle.Flat
        activeaccount.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        activeaccount.ForeColor = SystemColors.ControlLightLight
        activeaccount.Location = New Point(12, 201)
        activeaccount.Name = "activeaccount"
        activeaccount.RightToLeft = RightToLeft.No
        activeaccount.Size = New Size(164, 40)
        activeaccount.TabIndex = 41
        activeaccount.Text = "Active "
        activeaccount.UseVisualStyleBackColor = False
        ' 
        ' deactivelist
        ' 
        deactivelist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        deactivelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        deactivelist.Location = New Point(862, 60)
        deactivelist.Name = "deactivelist"
        deactivelist.Size = New Size(310, 550)
        deactivelist.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(862, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 43
        Label1.Text = "Deactive account"
        ' 
        ' refreshadmin
        ' 
        refreshadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        refreshadmin.BackColor = Color.Green
        refreshadmin.FlatAppearance.BorderColor = Color.White
        refreshadmin.FlatAppearance.BorderSize = 0
        refreshadmin.FlatStyle = FlatStyle.Flat
        refreshadmin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        refreshadmin.ForeColor = SystemColors.ControlLightLight
        refreshadmin.Location = New Point(12, 512)
        refreshadmin.Name = "refreshadmin"
        refreshadmin.RightToLeft = RightToLeft.No
        refreshadmin.Size = New Size(164, 40)
        refreshadmin.TabIndex = 44
        refreshadmin.Text = "Refresh"
        refreshadmin.UseVisualStyleBackColor = False
        ' 
        ' Accounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 647)
        Controls.Add(refreshadmin)
        Controls.Add(Label1)
        Controls.Add(deactivelist)
        Controls.Add(activeaccount)
        Controls.Add(accountlist)
        Controls.Add(deactiveaccount)
        Controls.Add(backbtntoadmin)
        Controls.Add(PictureBox1)
        Name = "Accounts"
        Text = "Accounts"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(accountlist, ComponentModel.ISupportInitialize).EndInit()
        CType(deactivelist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents backbtntoadmin As Button
    Friend WithEvents deactiveaccount As Button
    Friend WithEvents accountlist As DataGridView
    Friend WithEvents activeaccount As Button
    Friend WithEvents deactivelist As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents refreshadmin As Button
End Class
