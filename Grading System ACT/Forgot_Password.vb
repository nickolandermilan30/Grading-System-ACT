Imports MySql.Data.MySqlClient

Public Class Forgot_Password

    Private userEmail As String = ""
    Private newPassword As String = ""

    Private Sub emailforgot_TextChanged(sender As Object, e As EventArgs) Handles emailforgot.TextChanged
        userEmail = emailforgot.Text.Trim()
    End Sub

    Private Sub passwordforgot_TextChanged(sender As Object, e As EventArgs) Handles passwordforgot.TextChanged
        newPassword = passwordforgot.Text.Trim()
    End Sub

    Private Sub changepassword_Click(sender As Object, e As EventArgs) Handles changepassword.Click
        If String.IsNullOrWhiteSpace(userEmail) OrElse String.IsNullOrWhiteSpace(newPassword) Then
            MessageBox.Show("Please enter both email and new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            OpenConnection()

            ' Check if email exists first
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @Email", conn)
            checkCmd.Parameters.AddWithValue("@Email", userEmail)

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count = 0 Then
                MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Update password
                Dim updateCmd As New MySqlCommand("UPDATE users SET password = @Password WHERE email = @Email", conn)
                updateCmd.Parameters.AddWithValue("@Email", userEmail)
                updateCmd.Parameters.AddWithValue("@Password", newPassword)
                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Optionally clear fields
                emailforgot.Clear()
                passwordforgot.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub backtomain_Click(sender As Object, e As EventArgs) Handles backtomain.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub seepassforgot_CheckedChanged(sender As Object, e As EventArgs) Handles seepassforgot.CheckedChanged
        If seepassforgot.Checked Then
            passwordforgot.UseSystemPasswordChar = False ' Show password
        Else
            passwordforgot.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub


    Private Sub Forgot_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordforgot.UseSystemPasswordChar = True ' Hide by default
    End Sub

End Class
