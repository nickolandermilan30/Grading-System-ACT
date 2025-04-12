Imports MySql.Data.MySqlClient

Public Class Teacher_register
    Private Sub backtoclass3_Click(sender As Object, e As EventArgs) Handles backtoclass3.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowteacher_Click(sender As Object, e As EventArgs) Handles regnowteacher.Click
        Try

            OpenConnection()


            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, major_subject, department, user_level, password)
                                         VALUES (@fullname, @age, @gender, @identifier, @major_subject, @department, 'Teacher', @password)", conn)

            cmd.Parameters.AddWithValue("@fullname", teachname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(teachage.Text))
            cmd.Parameters.AddWithValue("@gender", teachgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", teachid.Text.Trim())
            cmd.Parameters.AddWithValue("@major_subject", teachmajor.Text.Trim())
            cmd.Parameters.AddWithValue("@department", teachdepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@password", "default123")

            cmd.ExecuteNonQuery()
            MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form fields
            teachname.Clear()
            teachage.Clear()
            teachgender.Clear()
            teachid.Clear()
            teachmajor.Clear()
            teachdepartment.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
