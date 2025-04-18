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
        Dim query As String = "SELECT student_name, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name FROM message_teacher WHERE teacher_name = @teacherName"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            conn.Open()
            adapter.SelectCommand.Parameters.AddWithValue("@teacherName", teacherName)
            adapter.Fill(table)
            studentlist.DataSource = table

            studentlist.Columns("student_name").HeaderText = "Student Name"
            studentlist.Columns("quiz").HeaderText = "Quiz"
            studentlist.Columns("exercises").HeaderText = "Exercises"
            studentlist.Columns("assignment").HeaderText = "Assignment"
            studentlist.Columns("project_evaluation").HeaderText = "Project Eval."
            studentlist.Columns("class_participation").HeaderText = "Class Part."
            studentlist.Columns("activity").HeaderText = "Activity"
            studentlist.Columns("project").HeaderText = "Project"
            studentlist.Columns("exam").HeaderText = "Exam"
            studentlist.Columns("message").HeaderText = "Message"
            studentlist.Columns("teacher_name").HeaderText = "Teacher Name" ' Added teacher_name column header

            ' Set column width for the new "teacher_name" column if necessary
            studentlist.Columns("teacher_name").Width = 150 ' Adjust width as necessary

            ' Set wider column width for message
            studentlist.Columns("message").Width = 300 ' You can change 300 to any value you like

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
End Class
