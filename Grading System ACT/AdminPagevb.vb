Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class AdminPagevb
    Private conn As MySqlConnection
    Private adminName As String
    Private adminDept As String

    Public Sub New(ByVal name As String, ByVal dept As String)
        InitializeComponent()
        adminName = name
        adminDept = dept
    End Sub
    Private Sub AdminPagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign values to labels
        nameadmin.Text = adminName
        departmentadminname.Text = adminDept

        ' Load other data
        LoadTeachers()
        LoadPivotedGrades()
        LoadDetailedGrades() ' this one for allgradespoints
        LoadMaleStudents()
        LoadFemaleStudents()
        LoadSubjectsToComboBox()
    End Sub

    Private Sub LoadSubjectsToComboBox()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            Dim query As String = "SELECT subject_name FROM subjects"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            subjectlistadmin.Items.Clear()

            While reader.Read()
                subjectlistadmin.Items.Add(reader("subject_name").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub


    Private Sub LoadFemaleStudents()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            Dim query As String = "SELECT fullname, identifier, age FROM users WHERE gender = 'F' AND user_level = 'Student' ORDER BY fullname"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            femaleliststudent.Items.Clear()
            femaleliststudent.View = View.Details
            femaleliststudent.OwnerDraw = True

            If femaleliststudent.Columns.Count = 0 Then
                femaleliststudent.Columns.Add("Full Name", 150)
                femaleliststudent.Columns.Add("Student ID", 150)
                femaleliststudent.Columns.Add("Age", 150)
            End If

            Dim femaleStudentCount As Integer = 0

            While reader.Read()
                Dim item As New ListViewItem(reader("fullname").ToString())
                item.SubItems.Add(reader("identifier").ToString())
                item.SubItems.Add(reader("age").ToString())
                femaleliststudent.Items.Add(item)
                femaleStudentCount += 1
            End While

            reader.Close()

            ' ✅ Update female count label
            femalecount.Text = femaleStudentCount.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading female students: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub



    Private Sub LoadMaleStudents()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            Dim query As String = "SELECT fullname, identifier, age FROM users WHERE gender = 'M' AND user_level = 'Student' ORDER BY fullname"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            malestudentlist.Items.Clear()
            malestudentlist.View = View.Details

            ' Enable owner draw for custom header coloring
            malestudentlist.OwnerDraw = True

            ' Only add columns if they don’t already exist
            If malestudentlist.Columns.Count = 0 Then
                malestudentlist.Columns.Add("Full Name", 150)
                malestudentlist.Columns.Add("Student ID", 150)
                malestudentlist.Columns.Add("Age", 150)
            End If

            ' Track the number of students
            Dim maleStudentCount As Integer = 0

            While reader.Read()
                Dim item As New ListViewItem(reader("fullname").ToString())
                item.SubItems.Add(reader("identifier").ToString())
                item.SubItems.Add(reader("age").ToString()) ' Add age as a third column
                malestudentlist.Items.Add(item)

                ' Increment the count for each male student
                maleStudentCount += 1
            End While

            reader.Close()

            ' Update the malecount label with the number of male students
            malecount.Text = maleStudentCount.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading male students: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
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

    Private Sub LoadTeachers()
        Try
            ' Open MySQL connection
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            ' Query to get all teachers
            Dim query As String = "SELECT fullname FROM users WHERE user_level = 'Teacher' ORDER BY fullname"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear current items in the ComboBox or ListBox
            teacherlist.Items.Clear()

            ' Populate with teacher names
            While reader.Read()
                teacherlist.Items.Add(reader("fullname").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading teachers: " & ex.Message)
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

    Private Sub malestudentlist_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles malestudentlist.DrawColumnHeader
        ' Soft blue background with some transparency
        Using headerBrush As New SolidBrush(Color.FromArgb(100, 0, 120, 215))
            e.Graphics.FillRectangle(headerBrush, e.Bounds)
        End Using

        ' Black text
        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub malestudentlist_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles malestudentlist.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub malestudentlist_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles malestudentlist.DrawSubItem
        e.DrawDefault = True
    End Sub

    Private Sub malecount_Click(sender As Object, e As EventArgs) Handles malecount.Click

    End Sub

    Private Sub femaleliststudent_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles femaleliststudent.DrawColumnHeader
        Using headerBrush As New SolidBrush(Color.FromArgb(100, 255, 105, 180)) ' Soft pink
            e.Graphics.FillRectangle(headerBrush, e.Bounds)
        End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
    End Sub


    Private Sub femaleliststudent_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles femaleliststudent.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub femaleliststudent_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles femaleliststudent.DrawSubItem
        e.DrawDefault = True
    End Sub

    Private Sub femalecount_Click(sender As Object, e As EventArgs) Handles femalecount.Click
    End Sub

    Private Sub subjectlistadmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectlistadmin.SelectedIndexChanged
        ' You can do something here if needed
        ' For example, show a MessageBox:
        ' MessageBox.Show("You selected: " & subjectlistadmin.SelectedItem.ToString())
    End Sub


    Private Sub deletesubject_Click(sender As Object, e As EventArgs) Handles deletesubject.Click
        ' Check if a subject is selected
        If subjectlistadmin.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a subject to delete.")
            Exit Sub
        End If

        ' Get the selected subject name
        Dim selectedSubject As String = subjectlistadmin.SelectedItem.ToString()

        ' Ask for confirmation
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the subject '{selectedSubject}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Exit Sub

        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            ' Delete subject from the subjects table
            Dim query As String = "DELETE FROM subjects WHERE subject_name = @subjectName"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@subjectName", selectedSubject)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Subject deleted successfully.")
            Else
                MessageBox.Show("Subject not found or already deleted.")
            End If

            ' Reload the updated subject list
            LoadSubjectsToComboBox()

        Catch ex As Exception
            MessageBox.Show("Error deleting subject: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub accounts_Click(sender As Object, e As EventArgs) Handles accounts.Click
        Dim accForm As New Accounts
        accForm.Show()
    End Sub

    Private Sub logoutadmin_Click(sender As Object, e As EventArgs) Handles logoutadmin.Click
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub messageteacher_Click(sender As Object, e As EventArgs) Handles messageteacher.Click
        Dim msgForm As New Message(adminName)
        msgForm.Show()
    End Sub

    Private Sub teachergradeddone_Click(sender As Object, e As EventArgs) Handles teachergradeddone.Click
        Dim gradedForm As New Graded_Finish()
        gradedForm.Show()
    End Sub

End Class
