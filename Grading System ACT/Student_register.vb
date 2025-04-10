Public Class Student_register
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub backtoclass_Click(sender As Object, e As EventArgs) Handles backtoclass.Click
        Resgister_Type.Show() ' show back the login form
        Me.Close() ' close the current register form
    End Sub
End Class