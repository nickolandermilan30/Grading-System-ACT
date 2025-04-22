Imports MySql.Data.MySqlClient

Public Class Graded_Finish
    Private Sub Graded_Finish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoneAndMessageData()
    End Sub

    Private Sub LoadDoneAndMessageData()
        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=gradingsystem")
        Dim table As New DataTable()
        table.Columns.Add("Student Name")
        table.Columns.Add("Semester")
        table.Columns.Add("Quiz")
        table.Columns.Add("Exercises")
        table.Columns.Add("Assignment")
        table.Columns.Add("Project Eval.")
        table.Columns.Add("Class Part.")
        table.Columns.Add("Activity")
        table.Columns.Add("Project")
        table.Columns.Add("Exam")
        table.Columns.Add("Message")
        table.Columns.Add("Teacher Name")
        table.Columns.Add("Progress")

        Try
            conn.Open()

            ' Load Done messages
            Dim doneQuery As String = "SELECT student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name FROM done_copy_teacher"
            Dim doneCmd As New MySqlCommand(doneQuery, conn)
            Dim reader As MySqlDataReader = doneCmd.ExecuteReader()

            While reader.Read()
                table.Rows.Add(reader("student_name"), reader("semester"), reader("quiz"), reader("exercises"),
                               reader("assignment"), reader("project_evaluation"), reader("class_participation"),
                               reader("activity"), reader("project"), reader("exam"), reader("message"),
                               reader("teacher_name"), "Done")
            End While
            reader.Close()

            ' Add separator row
            table.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "")

            ' Load Not Done messages
            Dim msgQuery As String = "SELECT student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message, teacher_name FROM message_teacher"
            Dim msgCmd As New MySqlCommand(msgQuery, conn)
            Dim reader2 As MySqlDataReader = msgCmd.ExecuteReader()

            While reader2.Read()
                table.Rows.Add(reader2("student_name"), reader2("semester"), reader2("quiz"), reader2("exercises"),
                               reader2("assignment"), reader2("project_evaluation"), reader2("class_participation"),
                               reader2("activity"), reader2("project"), reader2("exam"), reader2("message"),
                               reader2("teacher_name"), "Not Done")
            End While
            reader2.Close()

            donemsglist.DataSource = table

            ' Optional: set column widths
            donemsglist.Columns("Message").Width = 300
            donemsglist.Columns("Teacher Name").Width = 150
            donemsglist.Columns("Semester").Width = 100
            donemsglist.Columns("Progress").Width = 100

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
