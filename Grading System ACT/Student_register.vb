Imports MySql.Data.MySqlClient
Public Class Student_register

    Private Sub backtoclass_Click(sender As Object, e As EventArgs) Handles backtoclass.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowstudent_Click(sender As Object, e As EventArgs) Handles regnowstudent.Click
        Try


            OpenConnection()


            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, section, department, user_level, password) 
                                         VALUES (@fullname, @age, @gender, @identifier, @section, @department, 'Student', @password)", conn)

            cmd.Parameters.AddWithValue("@fullname", studname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(studage.Text))
            cmd.Parameters.AddWithValue("@gender", studgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", studid.Text.Trim())
            cmd.Parameters.AddWithValue("@section", studsection.Text.Trim())
            cmd.Parameters.AddWithValue("@department", studdepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@password", "default123")

            cmd.ExecuteNonQuery()
            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form fields+
            studname.Clear()
            studage.Clear()
            studgender.Clear()
            studid.Clear()
            studsection.Clear()
            studdepartment.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
