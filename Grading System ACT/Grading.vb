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

            Dim query As String = "INSERT INTO grades (
            student_name, subject_name, quiz, class_participation, exercises,
            activity, assignment, project, project_evaluation, exam,
            total_grade, standing_grade, semester_name
        ) VALUES (
            @student_name, @subject_name, @quiz, @class_participation, @exercises,
            @activity, @assignment, @project, @project_evaluation, @exam,
            @total_grade, @standing_grade, @semester_name
        )"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@student_name", studentName)
            cmd.Parameters.AddWithValue("@subject_name", subjectName)
            cmd.Parameters.AddWithValue("@quiz", GetSafeDouble(quiz.Text))
            cmd.Parameters.AddWithValue("@class_participation", GetSafeDouble(classparticipation.Text))
            cmd.Parameters.AddWithValue("@exercises", GetSafeDouble(exercises.Text))
            cmd.Parameters.AddWithValue("@activity", GetSafeDouble(activity.Text))
            cmd.Parameters.AddWithValue("@assignment", GetSafeDouble(assigment.Text))
            cmd.Parameters.AddWithValue("@project", GetSafeDouble(project.Text))
            cmd.Parameters.AddWithValue("@project_evaluation", GetSafeDouble(projectevalution.Text))
            cmd.Parameters.AddWithValue("@exam", GetSafeDouble(exam.Text))
            cmd.Parameters.AddWithValue("@total_grade", total)
            cmd.Parameters.AddWithValue("@standing_grade", standing)
            cmd.Parameters.AddWithValue("@semester_name", semesterName)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Grades saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
