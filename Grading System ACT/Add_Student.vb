Imports MySql.Data.MySqlClient

Public Class Add_Student
    Public Property TeacherName As String
    Public Property TeacherDept As String

    Private Sub Add_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentList()
    End Sub

    Private Sub LoadStudentList()
        studentlist.Items.Clear()

        Try
            OpenConnection()
            Dim query As String = "SELECT fullname, gender, identifier, department, year FROM users WHERE user_level = 'Student'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim name As String = reader("fullname").ToString()
                Dim gender As String = reader("gender").ToString()
                Dim studentId As String = reader("identifier").ToString()
                Dim department As String = reader("department").ToString()
                Dim year As String = reader("year").ToString()

                Dim display As String = $"{name} - {gender} - {studentId} - {department} - {year}"
                studentlist.Items.Add(display)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub



    Private Sub studentlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentlist.SelectedIndexChanged
        ' Optional: Display selected student name or load additional info
        Dim selectedStudent As String = studentlist.SelectedItem.ToString()
    End Sub

    Private Sub addstudenttocolumn_Click(sender As Object, e As EventArgs) Handles addstudenttocolumn.Click
        If studentlist.CheckedItems.Count = 0 Then
            MessageBox.Show("Please check at least one student to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim addedCount As Integer = 0

        Try
            OpenConnection()

            For Each item As String In studentlist.CheckedItems
                Dim parts() As String = item.Split(" - ")

                If parts.Length = 5 Then
                    Dim fullname As String = parts(0).Trim()
                    Dim gender As String = parts(1).Trim()
                    Dim studentId As String = parts(2).Trim()
                    Dim department As String = parts(3).Trim()
                    Dim year As String = parts(4).Trim()

                    ' Check if student is active
                    Dim checkQuery As String = "SELECT active FROM users WHERE identifier = @id"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@id", studentId)
                        Dim result = checkCmd.ExecuteScalar()

                        If result IsNot Nothing AndAlso Convert.ToInt32(result) = 0 Then
                            MessageBox.Show($"{fullname} is currently banned and cannot be added.", "Student Banned", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Continue For
                        End If
                    End Using

                    ' Insert student if active
                    Dim query As String = "INSERT INTO selected_students (fullname, gender, student_id, department, year) VALUES (@fullname, @gender, @student_id, @department, @year)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@fullname", fullname)
                        cmd.Parameters.AddWithValue("@gender", gender)
                        cmd.Parameters.AddWithValue("@student_id", studentId)
                        cmd.Parameters.AddWithValue("@department", department)
                        cmd.Parameters.AddWithValue("@year", year)
                        cmd.ExecuteNonQuery()
                        addedCount += 1
                    End Using
                End If
            Next

            If addedCount > 0 Then
                MessageBox.Show("Selected students saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub




    Private Sub backtomainsub2_Click(sender As Object, e As EventArgs) Handles backtomainsub2.Click
        Me.Close()
    End Sub

End Class