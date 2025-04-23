Imports MySql.Data.MySqlClient

Public Class Student_register

    Private Sub Student_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studdepartment.Items.Clear()
        studdepartment.Items.Add("BSBA")
        studdepartment.Items.Add("BEED")
        studdepartment.Items.Add("ACT")
        studdepartment.Items.Add("BSED")
        regnowstudent.Enabled = False
    End Sub

    Private Sub backtoclass_Click(sender As Object, e As EventArgs) Handles backtoclass.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowstudent_Click(sender As Object, e As EventArgs) Handles regnowstudent.Click
        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("INSERT INTO users (fullname, age, gender, identifier, section, department, year, user_level, password, email) 
VALUES (@fullname, @age, @gender, @identifier, @section, @department, @year, 'Student', @password, @email)", conn)


            cmd.Parameters.AddWithValue("@fullname", studname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(studage.Text))
            cmd.Parameters.AddWithValue("@gender", studgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", studid.Text.Trim())
            cmd.Parameters.AddWithValue("@section", studsection.Text.Trim())
            cmd.Parameters.AddWithValue("@department", studdepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@year", year.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passstud.Text.Trim())
            cmd.Parameters.AddWithValue("@email", emailstud.Text.Trim())


            cmd.ExecuteNonQuery()
            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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


    Private Sub studid_TextChanged(sender As Object, e As EventArgs) Handles studid.TextChanged
        Dim studentID As String = studid.Text.Trim()
        If studentID = "" Then
            regnowstudent.Enabled = False
            Exit Sub
        End If

        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE identifier = @identifier", conn)
            cmd.Parameters.AddWithValue("@identifier", studentID)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                regnowstudent.Enabled = False
                MessageBox.Show("Student ID already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                regnowstudent.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error checking student ID: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub emailstud_TextChanged(sender As Object, e As EventArgs) Handles emailstud.TextChanged
        ' Optional: remove silent update logic since we only update after full registration
    End Sub

    Private Sub passstud_TextChanged(sender As Object, e As EventArgs) Handles passstud.TextChanged
        ' Optional: same as above
    End Sub

    Private Sub studdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studdepartment.SelectedIndexChanged
        ' Do nothing or handle dynamically if needed
    End Sub

    Private Sub year_TextChanged(sender As Object, e As EventArgs) Handles year.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
