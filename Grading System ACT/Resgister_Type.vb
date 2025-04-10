Public Class Resgister_Type
    Private Sub Resgister_Type_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backtologin_Click(sender As Object, e As EventArgs) Handles backtologin.Click
        Form1.Show() ' show back the login form
        Me.Close() ' close the current register form
    End Sub

    Private Sub stubtn_Click(sender As Object, e As EventArgs) Handles stubtn.Click
        Dim stuForm As New Student_register()
        stuForm.Show()
        Me.Hide() ' optional: itago yung current Register_Type form
    End Sub

    Private Sub adbtn_Click(sender As Object, e As EventArgs) Handles adbtn.Click
        Dim stuForm As New Admin_register()
        stuForm.Show()
        Me.Hide()
    End Sub

    Private Sub teachbtn_Click(sender As Object, e As EventArgs) Handles teachbtn.Click
        Dim stuForm As New Teacher_register()
        stuForm.Show()
        Me.Hide()
    End Sub
End Class