Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class AdminPagevb
    Private conn As MySqlConnection

    Private Sub AdminPagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPivotedGrades()
        LoadDetailedGrades() ' this one for allgradespoints
    End Sub

    Private Sub LoadDetailedGrades(Optional semesterFilter As String = "")
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            ' Step 1: Get distinct student names (filter if semester is selected)
            Dim students As New List(Of String)
            Dim studentQuery As String = "SELECT DISTINCT student_name FROM grading_for_admin_page"
            If semesterFilter <> "" Then
                studentQuery &= " WHERE semester_name = @semester"
            End If
            studentQuery &= " ORDER BY student_name"

            Dim studentCmd As New MySqlCommand(studentQuery, conn)
            If semesterFilter <> "" Then
                studentCmd.Parameters.AddWithValue("@semester", semesterFilter)
            End If
            Dim studentReader As MySqlDataReader = studentCmd.ExecuteReader()
            While studentReader.Read()
                students.Add(studentReader("student_name").ToString())
            End While
            studentReader.Close()

            ' Step 2: Get filtered grade records
            Dim gradesQuery As String = "SELECT * FROM grading_for_admin_page"
            If semesterFilter <> "" Then
                gradesQuery &= " WHERE semester_name = @semester"
            End If
            gradesQuery &= " ORDER BY subject_name, student_name"

            Dim cmd As New MySqlCommand(gradesQuery, conn)
            If semesterFilter <> "" Then
                cmd.Parameters.AddWithValue("@semester", semesterFilter)
            End If
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim fields As String() = {
            "quiz", "class_participation", "exercises", "activity", "assignment", "project",
            "project_evaluation", "exam", "total_grade", "standing_grade", "semester_name", "date_encoded", "time_encoded"
        }

            ' Step 3: Organize Data
            Dim subjectData As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))()
            While reader.Read()
                Dim subject As String = reader("subject_name").ToString()
                Dim student As String = reader("student_name").ToString()

                If Not subjectData.ContainsKey(subject) Then
                    subjectData(subject) = New Dictionary(Of String, Dictionary(Of String, String))()
                End If
                If Not subjectData(subject).ContainsKey(student) Then
                    subjectData(subject)(student) = New Dictionary(Of String, String)()
                End If

                For Each field In fields
                    If field = "date_encoded" Then
                        Dim datetimeValue As DateTime
                        If DateTime.TryParse(reader("date_encoded").ToString(), datetimeValue) Then
                            subjectData(subject)(student)("date_encoded") = datetimeValue.ToString("yyyy-MM-dd")
                            subjectData(subject)(student)("time_encoded") = datetimeValue.ToString("HH:mm:ss")
                        Else
                            subjectData(subject)(student)("date_encoded") = "-"
                            subjectData(subject)(student)("time_encoded") = "-"
                        End If
                    ElseIf field <> "time_encoded" Then
                        subjectData(subject)(student)(field) = reader(field).ToString()
                    End If
                Next
            End While
            reader.Close()

            ' Step 4: Build DataGridView
            allgradespoints.Columns.Clear()
            allgradespoints.Rows.Clear()

            allgradespoints.Columns.Add("StudentName", "Student Name")
            For Each field In fields
                allgradespoints.Columns.Add(field, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(field.Replace("_", " ")))
            Next

            For Each subject In subjectData.Keys
                Dim subjectRow As New DataGridViewRow()
                subjectRow.CreateCells(allgradespoints)
                subjectRow.Cells(0).Value = "Subject: " & subject
                subjectRow.DefaultCellStyle.Font = New Font(allgradespoints.Font, FontStyle.Bold)
                subjectRow.DefaultCellStyle.BackColor = Color.LightGray
                allgradespoints.Rows.Add(subjectRow)

                For Each student In students
                    Dim row As New DataGridViewRow()
                    row.CreateCells(allgradespoints)
                    row.Cells(0).Value = student

                    For i = 0 To fields.Length - 1
                        Dim field = fields(i)
                        If subjectData(subject).ContainsKey(student) AndAlso subjectData(subject)(student).ContainsKey(field) Then
                            row.Cells(i + 1).Value = subjectData(subject)(student)(field)
                        Else
                            row.Cells(i + 1).Value = "-"
                        End If
                    Next

                    allgradespoints.Rows.Add(row)
                Next
            Next

            For Each column As DataGridViewColumn In allgradespoints.Columns
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading detailed grades: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub



    Private Sub LoadPivotedGrades(Optional semesterFilter As String = "")
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            ' Get all students with filter
            Dim students As New List(Of String)
            Dim studentQuery As String = "SELECT DISTINCT student_name FROM grading_for_admin_page"
            If semesterFilter <> "" Then
                studentQuery &= " WHERE semester_name = @semester"
            End If
            studentQuery &= " ORDER BY student_name"

            Dim studentCmd As New MySqlCommand(studentQuery, conn)
            If semesterFilter <> "" Then
                studentCmd.Parameters.AddWithValue("@semester", semesterFilter)
            End If
            Dim studentReader As MySqlDataReader = studentCmd.ExecuteReader()
            While studentReader.Read()
                students.Add(studentReader("student_name").ToString())
            End While
            studentReader.Close()

            ' Get subject, student, grade with filter
            Dim gradeQuery As String = "SELECT subject_name, student_name, standing_grade FROM grading_for_admin_page"
            If semesterFilter <> "" Then
                gradeQuery &= " WHERE semester_name = @semester"
            End If
            gradeQuery &= " ORDER BY subject_name, student_name"

            Dim cmd As New MySqlCommand(gradeQuery, conn)
            If semesterFilter <> "" Then
                cmd.Parameters.AddWithValue("@semester", semesterFilter)
            End If
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim subjectGrades As New Dictionary(Of String, Dictionary(Of String, Tuple(Of String, String)))()
            While reader.Read()
                Dim subject As String = reader("subject_name").ToString()
                Dim student As String = reader("student_name").ToString()
                Dim gradeStr As String = reader("standing_grade").ToString()
                Dim gradeValue As Double
                Dim remarks As String = "-"

                If Double.TryParse(gradeStr, gradeValue) Then
                    If gradeValue >= 1.0 AndAlso gradeValue <= 2.25 Then
                        remarks = "Passing"
                    ElseIf gradeValue >= 2.5 AndAlso gradeValue <= 3.0 Then
                        remarks = "Incomplete"
                    ElseIf gradeValue > 3.0 Then
                        remarks = "Failing"
                    Else
                        remarks = "Invalid Grade"
                    End If
                End If

                If Not subjectGrades.ContainsKey(subject) Then
                    subjectGrades(subject) = New Dictionary(Of String, Tuple(Of String, String))()
                End If
                subjectGrades(subject)(student) = Tuple.Create(gradeStr, remarks)
            End While
            reader.Close()

            ' Build DataGridView
            allgradelist.Columns.Clear()
            allgradelist.Rows.Clear()

            allgradelist.Columns.Add("Subject", "Subject")
            For Each student In students
                allgradelist.Columns.Add(student, student)
            Next

            For Each subject In subjectGrades.Keys
                Dim gradeRow As New DataGridViewRow()
                gradeRow.CreateCells(allgradelist)
                gradeRow.Cells(0).Value = subject
                For i = 0 To students.Count - 1
                    Dim student = students(i)
                    If subjectGrades(subject).ContainsKey(student) Then
                        gradeRow.Cells(i + 1).Value = subjectGrades(subject)(student).Item1
                    Else
                        gradeRow.Cells(i + 1).Value = "-"
                    End If
                Next
                allgradelist.Rows.Add(gradeRow)

                Dim remarkRow As New DataGridViewRow()
                remarkRow.CreateCells(allgradelist)
                remarkRow.Cells(0).Value = "Remarks"
                remarkRow.DefaultCellStyle.Font = New Font(allgradelist.Font, FontStyle.Italic)
                For i = 0 To students.Count - 1
                    Dim student = students(i)
                    If subjectGrades(subject).ContainsKey(student) Then
                        remarkRow.Cells(i + 1).Value = subjectGrades(subject)(student).Item2
                    Else
                        remarkRow.Cells(i + 1).Value = "-"
                    End If
                Next
                allgradelist.Rows.Add(remarkRow)
            Next

            For Each column As DataGridViewColumn In allgradelist.Columns
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading admin grades: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub



    Private Sub prelim_Click(sender As Object, e As EventArgs) Handles prelim.Click
        LoadDetailedGrades("Prelim")
        LoadPivotedGrades("Prelim")
    End Sub

    Private Sub midterm_Click(sender As Object, e As EventArgs) Handles midterm.Click
        LoadDetailedGrades("Midterm")
        LoadPivotedGrades("Midterm")
    End Sub

    Private Sub semifinals_Click(sender As Object, e As EventArgs) Handles semifinals.Click
        LoadDetailedGrades("Semi-Finals")
        LoadPivotedGrades("Semi-Finals")
    End Sub

    Private Sub finals_Click(sender As Object, e As EventArgs) Handles finals.Click
        LoadDetailedGrades("Finals")
        LoadPivotedGrades("Finals")
    End Sub

    Private Sub teacherlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teacherlist.SelectedIndexChanged


    End Sub



End Class
