Imports MySql.Data.MySqlClient

Public Class StudentPage
    Private studentName As String
    Private studentDept As String
    Private conn As MySqlConnection ' MySQL connection
    Private isPointsView As Boolean = False

    ' Constructor to initialize student name and department
    Public Sub New(name As String, dept As String)
        InitializeComponent()
        studentName = name
        studentDept = dept
    End Sub

    ' On load, display student info and grades in DataGridView
    Private Sub StudentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display student name and department
        namestudent.Text = studentName
        studentdepartment.Text = studentDept
        semestergrades.DropDownStyle = ComboBoxStyle.DropDownList


        ' Initialize the DataGridView columns
        InitializeDataGridViewColumns()

        ' Load grades from the database for this student
        LoadStudentGrades()

        ' Populate the semester dropdown (assuming this is a ComboBox)
        semestergrades.Items.Add("Prelim")
        semestergrades.Items.Add("Midterm")
        semestergrades.Items.Add("Semi-Finals")
        semestergrades.Items.Add("Finals")
    End Sub

    ' Method to initialize DataGridView columns for grades
    Private Sub InitializeDataGridViewColumns()
        ' Clear any existing columns
        gradesofeachstudent.Columns.Clear()

        ' Add columns to the DataGridView
        gradesofeachstudent.Columns.Add("subject_name", "Subject")
        gradesofeachstudent.Columns.Add("quiz", "Quiz")
        gradesofeachstudent.Columns.Add("class_participation", "Class Participation")
        gradesofeachstudent.Columns.Add("exercises", "Exercises")
        gradesofeachstudent.Columns.Add("activity", "Activity")
        gradesofeachstudent.Columns.Add("assignment", "Assignment")
        gradesofeachstudent.Columns.Add("project", "Project")
        gradesofeachstudent.Columns.Add("project_evaluation", "Project Evaluation")
        gradesofeachstudent.Columns.Add("exam", "Exam")
        gradesofeachstudent.Columns.Add("total_grade", "Total Grade")
        gradesofeachstudent.Columns.Add("standing_grade", "Standing Grade")
        gradesofeachstudent.Columns.Add("semester_name", "Semester")

        ' Center align the content of each column
        For Each column As DataGridViewColumn In gradesofeachstudent.Columns
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub


    ' Method to load student grades from the database
    Private Sub LoadStudentGrades(Optional semester As String = "")
        Try
            ' Open the connection to the database
            OpenConnection()

            ' SQL query to fetch grades for the student based on semester
            Dim query As String
            If String.IsNullOrEmpty(semester) Then
                query = "SELECT subject_name, quiz, class_participation, exercises, 
                                activity, assignment, project, project_evaluation, exam, 
                                total_grade, standing_grade, semester_name 
                         FROM grading_for_student_page 
                         WHERE student_name = @student_name"
            Else
                query = "SELECT subject_name, quiz, class_participation, exercises, 
                                activity, assignment, project, project_evaluation, exam, 
                                total_grade, standing_grade, semester_name 
                         FROM grading_for_student_page 
                         WHERE student_name = @student_name AND semester_name = @semester"
            End If

            ' Create a command to execute the query
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@student_name", studentName)

            If Not String.IsNullOrEmpty(semester) Then
                cmd.Parameters.AddWithValue("@semester", semester)
            End If

            ' Execute the query and fetch the data into a reader
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear any existing rows in the DataGridView
            gradesofeachstudent.Rows.Clear()

            ' Loop through the reader and add each row to the DataGridView
            While reader.Read()
                ' Add each grade entry to the DataGridView
                gradesofeachstudent.Rows.Add(reader("subject_name"),
                                             reader("quiz"),
                                             reader("class_participation"),
                                             reader("exercises"),
                                             reader("activity"),
                                             reader("assignment"),
                                             reader("project"),
                                             reader("project_evaluation"),
                                             reader("exam"),
                                             reader("total_grade"),
                                             reader("standing_grade"),
                                             reader("semester_name"))
            End While

            ' Close the reader
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading grades: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Method to handle connection opening
    Private Sub OpenConnection()
        ' Update this with your actual connection string
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
        conn.Open()
    End Sub

    ' Method to handle connection closing
    Private Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' This event handles clicks on cells in the DataGridView
    Private Sub gradesofeachstudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gradesofeachstudent.CellContentClick
        ' Get the clicked row (check that the click is on a valid cell)
        If e.RowIndex >= 0 Then
            ' Handle the cell click here (e.g., show details, edit grades, etc.)
            Dim subjectName As String = gradesofeachstudent.Rows(e.RowIndex).Cells("subject_name").Value.ToString()
            MessageBox.Show("Clicked on subject: " & subjectName)
        End If
    End Sub

    ' This event handles the semester selection in the dropdown
    Private Sub semestergrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semestergrades.SelectedIndexChanged
        Dim selectedSemester As String = semestergrades.SelectedItem.ToString()

        If isPointsView Then
            ' If currently in points view, switch back to full detailed view with semester filter
            isPointsView = False
            InitializeDataGridViewColumns()
        End If

        LoadStudentGrades(selectedSemester)
    End Sub


    ' Method to initialize DataGridView columns for points grades
    Private Sub InitializeDataGridViewColumnsForPoints()
        ' Clear any existing columns
        gradesofeachstudent.Columns.Clear()

        ' Add columns for subject, total grade, standing grade, remarks, and semester
        gradesofeachstudent.Columns.Add("subject_name", "Subject")
        gradesofeachstudent.Columns.Add("total_grade", "Total Grade")
        gradesofeachstudent.Columns.Add("standing_grade", "Standing Grade")
        gradesofeachstudent.Columns.Add("remarks", "Remarks")
        gradesofeachstudent.Columns.Add("semester_name", "Semester") ' ✅ added

        ' Center align the content of each column
        For Each column As DataGridViewColumn In gradesofeachstudent.Columns
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub


    ' Method to load student grades with only subject, total grade, standing grade, and remarks
    Private Sub LoadStudentPointsGrades()
        Try
            OpenConnection()

            ' Include semester_name in the SELECT
            Dim query As String = "SELECT subject_name, total_grade, standing_grade, semester_name 
                               FROM grading_for_student_page 
                               WHERE student_name = @student_name"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@student_name", studentName)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            gradesofeachstudent.Rows.Clear()

            While reader.Read()
                Dim totalGrade As Double = Convert.ToDouble(reader("total_grade"))
                Dim standingGrade As Double = Convert.ToDouble(reader("standing_grade"))
                Dim semester As String = reader("semester_name").ToString()
                Dim remarks As String

                ' Determine remarks
                If standingGrade >= 1.0 AndAlso standingGrade <= 2.25 Then
                    remarks = "Passing"
                ElseIf standingGrade >= 2.5 AndAlso standingGrade <= 3.0 Then
                    remarks = "Incomplete"
                ElseIf standingGrade > 3.0 Then
                    remarks = "Failing"
                Else
                    remarks = "Invalid Grade"
                End If

                gradesofeachstudent.Rows.Add(reader("subject_name"),
                                 totalGrade.ToString("F2"),
                                 standingGrade.ToString("F2"),
                                 remarks,
                                 semester)
            End While


            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading grades: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub



    ' This event handles the points grades button click
    Private Sub pointsgrades_Click(sender As Object, e As EventArgs) Handles pointsgrades.Click
        isPointsView = True ' ✅ we're in points view
        InitializeDataGridViewColumnsForPoints()
        LoadStudentPointsGrades()
    End Sub



    Private Sub subjectgrades_Click(sender As Object, e As EventArgs) Handles subjectgrades.Click
        isPointsView = False ' ✅ switch back to detailed view
        InitializeDataGridViewColumns()
        LoadStudentGrades()
    End Sub

    Private Sub logoutstudent_Click(sender As Object, e As EventArgs) Handles logoutstudent.Click
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close()
    End Sub
End Class
