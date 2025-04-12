

Imports MySql.Data.MySqlClient
Public Class Admin_register
    Private Sub Backtoclass2_Click(sender As Object, e As EventArgs) Handles backtoclass2.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowadmin_Click(sender As Object, e As EventArgs) Handles regnowadmin.Click
        Try



            OpenConnection()

            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, position, department, user_level, password) 
                                     VALUES (@fullname, @age, @gender, @identifier, @position, @department, 'Admin', @password)", conn)


            cmd.Parameters.AddWithValue("@fullname", adname.Text)
            cmd.Parameters.AddWithValue("@age", CInt(adage.Text))
            cmd.Parameters.AddWithValue("@gender", adgender.Text)
            cmd.Parameters.AddWithValue("@identifier", adveri.Text)
            cmd.Parameters.AddWithValue("@position", adid.Text)
            cmd.Parameters.AddWithValue("@department", addepartment.Text)
            cmd.Parameters.AddWithValue("@password", "default123")

            cmd.ExecuteNonQuery()
            MessageBox.Show("Admin registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            adname.Clear()
            adgender.Clear()
            adid.Clear()
            adage.Clear()
            adveri.Clear()
            addepartment.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class