Imports MySql.Data.MySqlClient

Public Class Teacher_register

    Private Sub Teacher_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate departments
        teachdepartment.Items.Clear()
        teachdepartment.Items.Add("BSBA")
        teachdepartment.Items.Add("BEED")
        teachdepartment.Items.Add("ACT")
        teachdepartment.Items.Add("BSED")
    End Sub

    Private Sub backtoclass3_Click(sender As Object, e As EventArgs) Handles backtoclass3.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowteacher_Click(sender As Object, e As EventArgs) Handles regnowteacher.Click
        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, major_subject, department, user_level, password, email)
                                     VALUES (@fullname, @age, @gender, @identifier, @major_subject, @department, 'Teacher', @password, @email)", conn)

            cmd.Parameters.AddWithValue("@fullname", teachname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(teachage.Text))
            cmd.Parameters.AddWithValue("@gender", teachgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", teachid.Text.Trim())
            cmd.Parameters.AddWithValue("@major_subject", teachmajor.Text.Trim())
            cmd.Parameters.AddWithValue("@department", teachdepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@password", teachpassword.Text.Trim())
            cmd.Parameters.AddWithValue("@email", emailteach.Text.Trim())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Redirect to login page (Form1)
            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub emailteach_TextChanged(sender As Object, e As EventArgs) Handles emailteach.TextChanged
        Try
            If teachid.Text.Trim() <> "" Then
                OpenConnection()
                Dim cmd As New MySqlCommand("UPDATE users SET email = @email WHERE identifier = @identifier", conn)
                cmd.Parameters.AddWithValue("@identifier", teachid.Text.Trim())
                cmd.Parameters.AddWithValue("@email", emailteach.Text.Trim())
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            ' Silent fail or log
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub teachpassword_TextChanged(sender As Object, e As EventArgs) Handles teachpassword.TextChanged
        Try
            If teachid.Text.Trim() <> "" Then
                OpenConnection()
                Dim cmd As New MySqlCommand("UPDATE users SET password = @password WHERE identifier = @identifier", conn)
                cmd.Parameters.AddWithValue("@identifier", teachid.Text.Trim())
                cmd.Parameters.AddWithValue("@password", teachpassword.Text.Trim())
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            ' Silent fail or log
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub teachdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teachdepartment.SelectedIndexChanged
        ' Optional: Pwede mag-display ng selection message
        ' MessageBox.Show("Department selected: " & teachdepartment.Text)
    End Sub

End Class
