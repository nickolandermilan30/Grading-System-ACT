Imports MySql.Data.MySqlClient

Public Class Student_register

    Private Sub Student_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studdepartment.Items.Clear()
        studdepartment.Items.AddRange({"BSBA", "BEED", "ACT", "BSED"})

        year.Items.Clear()
        year.Items.AddRange({"1st Year", "2nd Year", "3rd Year", "4th Year"})

        studgender.Items.Clear()
        studgender.Items.AddRange({"M", "F"})

        studentstatus.Items.Clear()
        studentstatus.Items.AddRange({"Scholar", "Irregular", "Regular", "New Enrolled"})


        studdepartment.DropDownStyle = ComboBoxStyle.DropDownList
        studentstatus.DropDownStyle = ComboBoxStyle.DropDownList
        studgender.DropDownStyle = ComboBoxStyle.DropDownList
        year.DropDownStyle = ComboBoxStyle.DropDownList


        ' Set tab order
        studname.TabIndex = 0
        year.TabIndex = 1
        emailstud.TabIndex = 2
        studage.TabIndex = 3
        studgender.TabIndex = 4
        studid.TabIndex = 5
        studsection.TabIndex = 6
        passstud.TabIndex = 7
        studentstatus.TabIndex = 8
        studdepartment.TabIndex = 9
        regnowstudent.TabIndex = 10

        regnowstudent.Enabled = True
    End Sub



    Private Sub backtoclass_Click(sender As Object, e As EventArgs) Handles backtoclass.Click
        Resgister_Type.Show()
        Me.Close()
    End Sub

    Private Sub Regnowstudent_Click(sender As Object, e As EventArgs) Handles regnowstudent.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(studname.Text) OrElse
        String.IsNullOrWhiteSpace(studage.Text) OrElse
        String.IsNullOrWhiteSpace(studgender.Text) OrElse
        String.IsNullOrWhiteSpace(studid.Text) OrElse
        String.IsNullOrWhiteSpace(studsection.Text) OrElse
        String.IsNullOrWhiteSpace(studdepartment.Text) OrElse
        String.IsNullOrWhiteSpace(year.Text) OrElse
        String.IsNullOrWhiteSpace(passstud.Text) OrElse
        String.IsNullOrWhiteSpace(emailstud.Text) OrElse
        String.IsNullOrWhiteSpace(studentstatus.Text) OrElse
        String.IsNullOrWhiteSpace(contactno.Text) Then

            MessageBox.Show("Please complete all fields before registering.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Validate contact number format
        If Not System.Text.RegularExpressions.Regex.IsMatch(contactno.Text.Trim(), "^09\d{9}$") Then
            MessageBox.Show("Invalid contact number format. It must start with '09' and contain exactly 11 digits.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Rest of your database saving logic...
        Try
            OpenConnection()



            ' Check for existing fullname, email, or student ID
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE fullname = @fullname OR email = @email OR identifier = @identifier", conn)
            checkCmd.Parameters.AddWithValue("@fullname", studname.Text.Trim())
            checkCmd.Parameters.AddWithValue("@email", emailstud.Text.Trim())
            checkCmd.Parameters.AddWithValue("@identifier", studid.Text.Trim())

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("This account already exists. Full Name, Username, or Student ID is already in use.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Proceed with registration if no duplicates found
            Dim cmd As New MySqlCommand("INSERT INTO users 
(fullname, age, gender, identifier, section, department, year, user_level, password, email, student_status, contactno) 
VALUES 
(@fullname, @age, @gender, @identifier, @section, @department, @year, 'Student', @password, @email, @student_status, @contactno)", conn)

            cmd.Parameters.AddWithValue("@fullname", studname.Text.Trim())
            cmd.Parameters.AddWithValue("@age", CInt(studage.Text))
            cmd.Parameters.AddWithValue("@gender", studgender.Text.Trim())
            cmd.Parameters.AddWithValue("@identifier", studid.Text.Trim())
            cmd.Parameters.AddWithValue("@section", studsection.Text.Trim())
            cmd.Parameters.AddWithValue("@department", studdepartment.Text.Trim())
            cmd.Parameters.AddWithValue("@year", year.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passstud.Text.Trim())
            cmd.Parameters.AddWithValue("@email", emailstud.Text.Trim())
            cmd.Parameters.AddWithValue("@student_status", studentstatus.Text.Trim())
            cmd.Parameters.AddWithValue("@contactno", contactno.Text.Trim())


            cmd.ExecuteNonQuery()
            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub studname_TextChanged(sender As Object, e As EventArgs) Handles studname.TextChanged

    End Sub

    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged

    End Sub

    Private Sub emailstud_TextChanged(sender As Object, e As EventArgs) Handles emailstud.TextChanged

    End Sub

    Private Sub studage_TextChanged(sender As Object, e As EventArgs) Handles studage.TextChanged

    End Sub

    Private Sub studgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studgender.SelectedIndexChanged

    End Sub

    Private Sub studsection_TextChanged(sender As Object, e As EventArgs) Handles studsection.TextChanged

    End Sub

    Private Sub passstud_TextChanged(sender As Object, e As EventArgs) Handles passstud.TextChanged

    End Sub

    Private Sub studentstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentstatus.SelectedIndexChanged

    End Sub

    Private Sub studdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studdepartment.SelectedIndexChanged

    End Sub

    Private Sub contactno_TextChanged(sender As Object, e As EventArgs) Handles contactno.TextChanged

    End Sub
End Class
