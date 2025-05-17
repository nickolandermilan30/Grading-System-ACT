Imports MySql.Data.MySqlClient
Public Class Admin_register

    Private Sub Admin_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prevent typing in dropdowns
        adgender.DropDownStyle = ComboBoxStyle.DropDownList
        adid.DropDownStyle = ComboBoxStyle.DropDownList

        ' Setup gender dropdown
        adgender.Items.Clear()
        adgender.Items.Add("M")
        adgender.Items.Add("F")

        ' Setup position dropdown
        adid.Items.Clear()
        adid.Items.Add("Academic Coordinator")
        adid.Items.Add("Department Head")
        adid.Items.Add("Registrar")
        adid.Items.Add("Grading System Administrator")
        adid.Items.Add("Curriculum Coordinator")
        adid.Items.Add("Academic Dean")
        adid.Items.Add("Head Teacher")
        adid.Items.Add("School Secretary")

        ' Set tab order
        ademail.TabIndex = 0
        adname.TabIndex = 1
        adage.TabIndex = 2
        adgender.TabIndex = 3
        adid.TabIndex = 4
        adveri.TabIndex = 5
        adpassword.TabIndex = 6
        regnowadmin.TabIndex = 7
    End Sub



    Private Sub Backtoclass2_Click(sender As Object, e As EventArgs) Handles backtoclass2.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowadmin_Click(sender As Object, e As EventArgs) Handles regnowadmin.Click
        Try
            OpenConnection()

            ' ❗ Check if fullname already exists
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE fullname = @fullname", conn)
            checkCmd.Parameters.AddWithValue("@fullname", adname.Text.Trim())

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingCount > 0 Then
                MessageBox.Show("An account with the same full name already exists. Please use a unique name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' ✅ Insert new admin
            Dim insertCmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, position, department, user_level, password, email) 
            VALUES (@fullname, @age, @gender, @identifier, @position, 'Admin', 'Admin', @password, @email)", conn)

            insertCmd.Parameters.AddWithValue("@fullname", adname.Text.Trim())
            insertCmd.Parameters.AddWithValue("@age", CInt(adage.Text))
            insertCmd.Parameters.AddWithValue("@gender", adgender.Text.Trim())
            insertCmd.Parameters.AddWithValue("@identifier", adveri.Text.Trim())
            insertCmd.Parameters.AddWithValue("@position", adid.Text.Trim())
            insertCmd.Parameters.AddWithValue("@password", adpassword.Text.Trim())
            insertCmd.Parameters.AddWithValue("@email", ademail.Text.Trim())

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Admin registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Close()

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

    Private Sub adgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles adgender.SelectedIndexChanged

    End Sub

    Private Sub adid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles adid.SelectedIndexChanged

    End Sub
End Class
