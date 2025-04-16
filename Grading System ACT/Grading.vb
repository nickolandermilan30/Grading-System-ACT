Imports MySql.Data.MySqlClient

Public Class Grading
    Private studentName As String
    Private subjectName As String
    Private teacherPageRef As TeacherPage
    Private currentSemester As String
    Private semesterName As String


    Public Sub SetStudentAndSubject(name As String, subject As String, semValue As String)
        studentName = name
        subjectName = subject
        semesterName = semValue

        namegrading.Text = studentName
        subjectgrading.Text = subjectName
        semester.Text = semesterName ' Now no conflict!
    End Sub



    Public Sub SetTeacherPageRef(ref As TeacherPage)
        teacherPageRef = ref
    End Sub


    Private Sub Grading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make semester box read-only
        semester.Enabled = False

        ' Update grade calculations on load
        UpdateGrades()
    End Sub


    Private Sub UpdateGrades()
        Dim total As Double = ComputeTotalGrade()
        Dim standing As String = GetStandingGrade(total)

        ' Display on labels or buttons (based on your design)
        totalgrade.Text = total.ToString("F2")
        standinggrade.Text = standing
    End Sub

    Private Function ComputeTotalGrade() As Double
        Dim values As New List(Of Double)
        Dim inputs() As TextBox = {
            quiz, classparticipation, exercises,
            activity, assigment, project,
            projectevalution, exam
        }

        For Each input As TextBox In inputs
            Dim value As Double
            If Double.TryParse(input.Text, value) Then
                values.Add(value)
            Else
                values.Add(0)
            End If
        Next

        Dim total As Double = values.Sum()
        Dim average As Double = total / values.Count
        Return average
    End Function

    Private Function GetStandingGrade(total As Double) As String
        Select Case total
            Case >= 95
                Return "1.00"
            Case >= 90
                Return "1.25"
            Case >= 85
                Return "1.50"
            Case >= 80
                Return "1.75"
            Case >= 75
                Return "2.00"
            Case >= 70
                Return "2.50"
            Case >= 65
                Return "3.00"
            Case >= 60
                Return "4.00"
            Case Else
                Return "5.00"
        End Select
    End Function

    ' === TextChanged Events ===
    Private Sub quiz_TextChanged(sender As Object, e As EventArgs) Handles quiz.TextChanged
        UpdateGrades()
    End Sub

    Private Sub classparticipation_TextChanged(sender As Object, e As EventArgs) Handles classparticipation.TextChanged
        UpdateGrades()
    End Sub

    Private Sub exercises_TextChanged(sender As Object, e As EventArgs) Handles exercises.TextChanged
        UpdateGrades()
    End Sub

    Private Sub activity_TextChanged(sender As Object, e As EventArgs) Handles activity.TextChanged
        UpdateGrades()
    End Sub

    Private Sub assigment_TextChanged(sender As Object, e As EventArgs) Handles assigment.TextChanged
        UpdateGrades()
    End Sub

    Private Sub project_TextChanged(sender As Object, e As EventArgs) Handles project.TextChanged
        UpdateGrades()
    End Sub

    Private Sub projectevalution_TextChanged(sender As Object, e As EventArgs) Handles projectevalution.TextChanged
        UpdateGrades()
    End Sub

    Private Sub exam_TextChanged(sender As Object, e As EventArgs) Handles exam.TextChanged
        UpdateGrades()
    End Sub

    Private Sub applycolumn_Click(sender As Object, e As EventArgs) Handles applycolumn.Click
        Try
            OpenConnection()

            Dim total As Double = ComputeTotalGrade()
            Dim standing As String = GetStandingGrade(total)

            ' Query for inserting into the grades table
            Dim query1 As String = "INSERT INTO grades (
            student_name, subject_name, quiz, class_participation, exercises,
            activity, assignment, project, project_evaluation, exam,
            total_grade, standing_grade, semester_name
        ) VALUES (
            @student_name, @subject_name, @quiz, @class_participation, @exercises,
            @activity, @assignment, @project, @project_evaluation, @exam,
            @total_grade, @standing_grade, @semester_name
        )"

            ' Query for inserting into the grading_for_student_page table
            Dim query2 As String = "INSERT INTO grading_for_student_page (
            student_name, subject_name, quiz, class_participation, exercises,
            activity, assignment, project, project_evaluation, exam,
            total_grade, standing_grade, semester_name
        ) VALUES (
            @student_name, @subject_name, @quiz, @class_participation, @exercises,
            @activity, @assignment, @project, @project_evaluation, @exam,
            @total_grade, @standing_grade, @semester_name
        )"

            ' Query for inserting into the grading_for_admin_page table
            Dim query3 As String = "INSERT INTO grading_for_admin_page (
    student_name, subject_name, quiz, class_participation, exercises,
    activity, assignment, project, project_evaluation, exam,
    total_grade, standing_grade, semester_name
) VALUES (
    @student_name, @subject_name, @quiz, @class_participation, @exercises,
    @activity, @assignment, @project, @project_evaluation, @exam,
    @total_grade, @standing_grade, @semester_name
)"

            ' Prepare the command for the third query (grading_for_admin_page table)
            Dim cmd3 As New MySqlCommand(query3, conn)
            cmd3.Parameters.AddWithValue("@student_name", studentName)
            cmd3.Parameters.AddWithValue("@subject_name", subjectName)
            cmd3.Parameters.AddWithValue("@quiz", GetSafeDouble(quiz.Text))
            cmd3.Parameters.AddWithValue("@class_participation", GetSafeDouble(classparticipation.Text))
            cmd3.Parameters.AddWithValue("@exercises", GetSafeDouble(exercises.Text))
            cmd3.Parameters.AddWithValue("@activity", GetSafeDouble(activity.Text))
            cmd3.Parameters.AddWithValue("@assignment", GetSafeDouble(assigment.Text))
            cmd3.Parameters.AddWithValue("@project", GetSafeDouble(project.Text))
            cmd3.Parameters.AddWithValue("@project_evaluation", GetSafeDouble(projectevalution.Text))
            cmd3.Parameters.AddWithValue("@exam", GetSafeDouble(exam.Text))
            cmd3.Parameters.AddWithValue("@total_grade", total)
            cmd3.Parameters.AddWithValue("@standing_grade", standing)
            cmd3.Parameters.AddWithValue("@semester_name", semesterName)

            ' Execute the third query
            cmd3.ExecuteNonQuery()

            ' Prepare the command for the first query (grades table)
            Dim cmd1 As New MySqlCommand(query1, conn)
            cmd1.Parameters.AddWithValue("@student_name", studentName)
            cmd1.Parameters.AddWithValue("@subject_name", subjectName)
            cmd1.Parameters.AddWithValue("@quiz", GetSafeDouble(quiz.Text))
            cmd1.Parameters.AddWithValue("@class_participation", GetSafeDouble(classparticipation.Text))
            cmd1.Parameters.AddWithValue("@exercises", GetSafeDouble(exercises.Text))
            cmd1.Parameters.AddWithValue("@activity", GetSafeDouble(activity.Text))
            cmd1.Parameters.AddWithValue("@assignment", GetSafeDouble(assigment.Text))
            cmd1.Parameters.AddWithValue("@project", GetSafeDouble(project.Text))
            cmd1.Parameters.AddWithValue("@project_evaluation", GetSafeDouble(projectevalution.Text))
            cmd1.Parameters.AddWithValue("@exam", GetSafeDouble(exam.Text))
            cmd1.Parameters.AddWithValue("@total_grade", total)
            cmd1.Parameters.AddWithValue("@standing_grade", standing)
            cmd1.Parameters.AddWithValue("@semester_name", semesterName)

            ' Prepare the command for the second query (grading_for_student_page table)
            Dim cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@student_name", studentName)
            cmd2.Parameters.AddWithValue("@subject_name", subjectName)
            cmd2.Parameters.AddWithValue("@quiz", GetSafeDouble(quiz.Text))
            cmd2.Parameters.AddWithValue("@class_participation", GetSafeDouble(classparticipation.Text))
            cmd2.Parameters.AddWithValue("@exercises", GetSafeDouble(exercises.Text))
            cmd2.Parameters.AddWithValue("@activity", GetSafeDouble(activity.Text))
            cmd2.Parameters.AddWithValue("@assignment", GetSafeDouble(assigment.Text))
            cmd2.Parameters.AddWithValue("@project", GetSafeDouble(project.Text))
            cmd2.Parameters.AddWithValue("@project_evaluation", GetSafeDouble(projectevalution.Text))
            cmd2.Parameters.AddWithValue("@exam", GetSafeDouble(exam.Text))
            cmd2.Parameters.AddWithValue("@total_grade", total)
            cmd2.Parameters.AddWithValue("@standing_grade", standing)
            cmd2.Parameters.AddWithValue("@semester_name", semesterName)

            ' Execute both queries
            cmd1.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Grades saved successfully to both tables!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Return to TeacherPage and refresh
            Me.Close()
            If teacherPageRef IsNot Nothing Then
                teacherPageRef.Show()
                teacherPageRef.RefreshStudentGrades()
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving grades: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub




    Private Function GetSafeDouble(input As String) As Double
        Dim value As Double
        If Double.TryParse(input, value) Then
            Return value
        Else
            Return 0
        End If
    End Function
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        If teacherPageRef IsNot Nothing Then
            teacherPageRef.RefreshStudentGrades() ' Refresh grades on return
            teacherPageRef.Show()
        End If
        Me.Close()
    End Sub

    Private Sub semester_Click(sender As Object, e As EventArgs) Handles semester.Click

    End Sub
End Class
