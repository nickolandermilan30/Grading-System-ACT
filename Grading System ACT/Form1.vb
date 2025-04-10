Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim regForm As New Resgister_Type()
        regForm.Show()
        Me.Hide() ' Optional: itago ang current form
    End Sub


    Private Sub forgotbtn_Click(sender As Object, e As EventArgs) Handles forgotbtn.Click

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

End Class
