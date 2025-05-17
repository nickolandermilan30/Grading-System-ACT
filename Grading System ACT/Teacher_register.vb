Imports MySql.Data.MySqlClient

Public Class Teacher_register

    Private Sub Teacher_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate departments
        teachdepartment.Items.Clear()
        teachdepartment.Items.Add("BSBA")
        teachdepartment.Items.Add("BEED")
        teachdepartment.Items.Add("ACT")
        teachdepartment.Items.Add("BSED")

        ' Populate gender
        teachgender.Items.Clear()
        teachgender.Items.Add("M")
        teachgender.Items.Add("F")

        ' Set tab order
        teachname.TabIndex = 0
        emailteach.TabIndex = 1
        teachage.TabIndex = 2
        teachgender.TabIndex = 3
        teachid.TabIndex = 4
        teachpassword.TabIndex = 5
        teachmajor.TabIndex = 6
        teachdepartment.TabIndex = 7
        regnowteacher.TabIndex = 8

        teachgender.DropDownStyle = ComboBoxStyle.DropDownList
        teachdepartment.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub


    Private Sub backtoclass3_Click(sender As Object, e As EventArgs) Handles backtoclass3.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowteacher_Click(sender As Object, e As EventArgs) Handles regnowteacher.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(teachname.Text) OrElse
       String.IsNullOrWhiteSpace(emailteach.Text) OrElse
       String.IsNullOrWhiteSpace(teachage.Text) OrElse
       String.IsNullOrWhiteSpace(teachgender.Text) OrElse
       String.IsNullOrWhiteSpace(teachid.Text) OrElse
       String.IsNullOrWhiteSpace(teachpassword.Text) OrElse
       String.IsNullOrWhiteSpace(teachmajor.Text) OrElse
       String.IsNullOrWhiteSpace(teachdepartment.Text) Then

            MessageBox.Show("Please complete all fields before registering.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check for duplicates before registration
        Try
            OpenConnection()

            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE fullname = @fullname OR email = @email OR identifier = @identifier", conn)
            checkCmd.Parameters.AddWithValue("@fullname", teachname.Text.Trim())
            checkCmd.Parameters.AddWithValue("@email", emailteach.Text.Trim())
            checkCmd.Parameters.AddWithValue("@identifier", teachid.Text.Trim())

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingCount > 0 Then
                MessageBox.Show("A teacher with the same name, username, or ID already exists. Please use unique values.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Proceed with registration
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

    Private Sub teachname_TextChanged(sender As Object, e As EventArgs) Handles teachname.TextChanged

    End Sub

    Private Sub teachage_TextChanged(sender As Object, e As EventArgs) Handles teachage.TextChanged

    End Sub

    Private Sub teachgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teachgender.SelectedIndexChanged

    End Sub

    Private Sub teachid_TextChanged(sender As Object, e As EventArgs) Handles teachid.TextChanged

    End Sub

    Private Sub teachmajor_TextChanged(sender As Object, e As EventArgs) Handles teachmajor.TextChanged

    End Sub

    Private Sub teachdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teachdepartment.SelectedIndexChanged

    End Sub
End Class
