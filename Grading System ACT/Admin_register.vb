Imports MySql.Data.MySqlClient
Public Class Admin_register

    Private Sub Admin_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate department choices
        addepartment.Items.Clear()
        addepartment.Items.Add("BSBA")
        addepartment.Items.Add("BEED")
        addepartment.Items.Add("ACT")
        addepartment.Items.Add("BSED")
    End Sub

    Private Sub Backtoclass2_Click(sender As Object, e As EventArgs) Handles backtoclass2.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowadmin_Click(sender As Object, e As EventArgs) Handles regnowadmin.Click
        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, position, department, user_level, password, email) 
                                         VALUES (@fullname, @age, @gender, @identifier, @position, @department, 'Admin', @password, @email)", conn)

            cmd.Parameters.AddWithValue("@fullname", adname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(adage.Text))
            cmd.Parameters.AddWithValue("@gender", adgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", adveri.Text.Trim())
            cmd.Parameters.AddWithValue("@position", adid.Text.Trim())
            cmd.Parameters.AddWithValue("@department", addepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@password", adpassword.Text.Trim())
            cmd.Parameters.AddWithValue("@email", ademail.Text.Trim())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Admin registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields
            adname.Clear()
            adgender.Clear()
            adid.Clear()
            adage.Clear()
            adveri.Clear()
            adpassword.Clear()
            ademail.Clear()
            addepartment.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ademail_TextChanged(sender As Object, e As EventArgs) Handles ademail.TextChanged
        Try
            If adveri.Text.Trim() <> "" Then
                OpenConnection()
                Dim cmd As New MySqlCommand("UPDATE users SET email = @email WHERE identifier = @identifier", conn)
                cmd.Parameters.AddWithValue("@identifier", adveri.Text.Trim())
                cmd.Parameters.AddWithValue("@email", ademail.Text.Trim())
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            ' Optional: silently handle
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub adpassword_TextChanged(sender As Object, e As EventArgs) Handles adpassword.TextChanged
        Try
            If adveri.Text.Trim() <> "" Then
                OpenConnection()
                Dim cmd As New MySqlCommand("UPDATE users SET password = @password WHERE identifier = @identifier", conn)
                cmd.Parameters.AddWithValue("@identifier", adveri.Text.Trim())
                cmd.Parameters.AddWithValue("@password", adpassword.Text.Trim())
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            ' Optional: silently handle
        Finally
            CloseConnection()
        End Try
    End Sub

End Class
