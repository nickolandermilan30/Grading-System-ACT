Imports MySql.Data.MySqlClient

Public Class TeacherPage
    Private teacherName As String
    Private teacherDept As String

    Public Sub New(teacherName As String, teacherDept As String)
        InitializeComponent()

        ' Set teacher details
        Me.teacherName = teacherName
        Me.teacherDept = teacherDept
        nameteachpage.Text = teacherName
        departmentteachpage.Text = teacherDept

        ' Add semester options to ComboBox
        semesterteachpage.Items.AddRange(New String() {"Prelim", "Midterm", "Semi-Finals", "Finals"})

        ' Set default selected item to Prelim
        semesterteachpage.SelectedItem = "Prelim"

        ' Generate default grid columns
        GenerateSemesterColumns("Prelim")

        ' Load student data into grid
        LoadStudentData()
    End Sub

    Public Sub RefreshStudentGrades()
        ' This will reload the grid with updated standing grades
        Dim currentSemester As String = semesterteachpage.SelectedItem.ToString()
        GenerateSemesterColumns(currentSemester)
        LoadStudentData()
        LoadGradesIntoGrid(currentSemester)
    End Sub

    Private Sub LoadGradesIntoGrid(semester As String)
        Try
            OpenConnection()

            ' For each row (student), retrieve and populate standing grades for each subject and semester
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For

                Dim studentName As String = row.Cells("name").Value.ToString()

                ' Query to fetch grades for the specific student and semester from the 'grades' table
                Dim query As String = "SELECT subject_name, standing_grade FROM grades WHERE student_name = @studentName AND semester_name = @semester"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentName", studentName)
                cmd.Parameters.AddWithValue("@semester", semester)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim subject As String = reader("subject_name").ToString()
                        Dim standing As String = reader("standing_grade").ToString()

                        ' Create column name based on subject and semester
                        Dim colKey As String = subject & "_" & semester.Replace("-", "")
                        If grid.Columns.Contains(colKey) Then
                            row.Cells(colKey).Value = standing
                        End If
                    End While
                End Using
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading grades: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub



    Private Sub LoadStudentData()
        ' Clear any existing rows
        grid.Rows.Clear()

        Try
            ' Open connection
            OpenConnection()

            ' Fetch student data from the 'selected_students' table
            Dim query As String = "SELECT fullname, gender, student_id FROM selected_students"
            Dim cmd As New MySqlCommand(query, conn)

            ' Read student data
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim row As String() = {
                    reader("fullname").ToString(),
                    reader("gender").ToString(),
                    reader("student_id").ToString()
                }
                    grid.Rows.Add(row)
                    grid.AllowUserToAddRows = False
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ' ✅ Load grades after students are added
        LoadGradesIntoGrid(semesterteachpage.SelectedItem.ToString())
    End Sub




    Private Sub addsubject_Click(sender As Object, e As EventArgs) Handles addsubject.Click
        Dim addSubjectForm As New Add_subject()
        addSubjectForm.TeacherNameFromMain = Me.teacherName
        addSubjectForm.TeacherDeptFromMain = Me.teacherDept
        addSubjectForm.Show()
        Me.Hide()
    End Sub


    Private Sub semesterteachpage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semesterteachpage.SelectedIndexChanged  ' Get the selected semester and generate the columns accordingly
        Dim selectedSemester As String = semesterteachpage.SelectedItem.ToString()
        GenerateSemesterColumns(selectedSemester)
        LoadStudentData()
        RefreshStudentGrades()
    End Sub

    Private Sub GenerateSemesterColumns(semester As String)
        ' Clear existing grid
        grid.Columns.Clear()
        grid.Rows.Clear()

        ' Add student info columns (name, gender, student ID)
        grid.Columns.Add("name", "Name")
        grid.Columns.Add("gender", "Gender")
        grid.Columns.Add("studentId", "Student ID")

        ' Add semester-specific columns for each subject
        Try
            OpenConnection()

            ' Fetch subject names from the 'subjects' table
            Dim query As String = "SELECT subject_name FROM subjects"
            Dim cmd As New MySqlCommand(query, conn)

            ' Read subject names and create semester-specific columns
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim subject As String = reader("subject_name").ToString()

                    ' Add subject columns for the selected semester
                    Select Case semester
                        Case "Prelim"
                            grid.Columns.Add(subject & "_Prelim", subject & " (Prelim)")
                        Case "Midterm"
                            grid.Columns.Add(subject & "_Midterm", subject & " (Midterm)")
                        Case "Semi-Finals"
                            grid.Columns.Add(subject & "_SemiFinals", subject & " (Semi-Finals)")
                        Case "Finals"
                            grid.Columns.Add(subject & "_Finals", subject & " (Finals)")
                    End Select
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            CloseConnection()
        End Try
    End Sub




Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
        Dim clickedColumnName As String = grid.Columns(e.ColumnIndex).Name

        ' Skip if it's not a subject column
        If clickedColumnName = "name" OrElse clickedColumnName = "gender" OrElse clickedColumnName = "studentId" Then
            Return
        End If

        ' Get student name
        Dim studentName As String = grid.Rows(e.RowIndex).Cells("name").Value.ToString()

        ' Extract subject name (removing "_Prelim", "_Midterm", etc.)
        Dim subjectRaw As String = clickedColumnName
        Dim subjectName As String = subjectRaw.Split("_"c)(0)

            ' Open Grading form and pass data
            Dim gradingForm As New Grading()
            Dim selectedSemester As String = semesterteachpage.SelectedItem.ToString()
            gradingForm.SetStudentAndSubject(studentName, subjectName, selectedSemester)
            gradingForm.SetTeacherPageRef(Me) ' Pass current form
            gradingForm.Show()
            Me.Hide()

        End If
End Sub





    Private Sub addstudent_Click(sender As Object, e As EventArgs) Handles addstudent.Click
        Dim addStudentForm As New Add_Student()
        addStudentForm.Show()
        Me.Hide() ' Optional: hide the current TeacherPage form if needed
    End Sub

End Class
