Imports MySql.Data.MySqlClient

Public Class Teacher_Message
    Private teacherName As String
    Private teacherDept As String

    Public Sub New(name As String, dept As String)
        InitializeComponent()

        teacherName = name
        teacherDept = dept

        namemsgpage.Text = teacherName
        departmentmsgpage.Text = teacherDept

        LoadStudentNames()
    End Sub

    Private Sub LoadStudentNames()
        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=gradingsystem")
        Dim query As String = "SELECT student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name FROM message_teacher WHERE teacher_name = @teacherName"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            conn.Open()
            adapter.SelectCommand.Parameters.AddWithValue("@teacherName", teacherName)
            adapter.Fill(table)
            studentlist.DataSource = table

            studentlist.Columns("student_name").HeaderText = "Student Name"
            studentlist.Columns("semester").HeaderText = "Semester"
            studentlist.Columns("quiz").HeaderText = "Quiz"
            studentlist.Columns("exercises").HeaderText = "Exercises"
            studentlist.Columns("assignment").HeaderText = "Assignment"
            studentlist.Columns("project_evaluation").HeaderText = "Project Eval."
            studentlist.Columns("class_participation").HeaderText = "Class Part."
            studentlist.Columns("activity").HeaderText = "Activity"
            studentlist.Columns("project").HeaderText = "Project"
            studentlist.Columns("exam").HeaderText = "Exam"
            studentlist.Columns("message").HeaderText = "Message"
            studentlist.Columns("teacher_name").HeaderText = "Teacher Name"

            ' Optional: Set column widths
            studentlist.Columns("message").Width = 300
            studentlist.Columns("semester").Width = 100
            studentlist.Columns("teacher_name").Width = 150

        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub




    Private Sub namemsgpage_Click(sender As Object, e As EventArgs) Handles namemsgpage.Click
        namemsgpage.Text = teacherName
    End Sub

    Private Sub departmentmsgpage_Click(sender As Object, e As EventArgs) Handles departmentmsgpage.Click
        departmentmsgpage.Text = teacherDept
    End Sub



    Private Sub studentlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentlist.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = studentlist.Rows(e.RowIndex)
            Dim selectedStudent As String = selectedRow.Cells("student_name").Value.ToString()
            Dim studentMessage As String = selectedRow.Cells("message").Value.ToString()

            ' Display message in the TextBox (messagesee)
            messagesee.Text = studentMessage

            ' Optional: Show message box with student name
            ' MessageBox.Show("Selected student: " & selectedStudent)
        End If
    End Sub

    Private Sub messagesee_TextChanged(sender As Object, e As EventArgs) Handles messagesee.TextChanged

    End Sub

    Private Sub donecopy_Click(sender As Object, e As EventArgs) Handles donecopy.Click
        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=gradingsystem")

        Try
            conn.Open()

            ' Step 1: Insert data from message_teacher to done_copy_teacher
            Dim insertQuery As String = "INSERT INTO done_copy_teacher (student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name) " &
                                        "SELECT student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name " &
                                        "FROM message_teacher WHERE teacher_name = @teacherName"

            Using insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@teacherName", teacherName)
                insertCmd.ExecuteNonQuery()
            End Using

            ' Step 2: Delete the copied data from message_teacher
            Dim deleteQuery As String = "DELETE FROM message_teacher WHERE teacher_name = @teacherName"
            Using deleteCmd As New MySqlCommand(deleteQuery, conn)
                deleteCmd.Parameters.AddWithValue("@teacherName", teacherName)
                deleteCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Messages successfully moved to done_copy_teacher.")

            ' Optional: Refresh grid after done copy
            LoadStudentNames()

        Catch ex As Exception
            MessageBox.Show("Error during done copy: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
