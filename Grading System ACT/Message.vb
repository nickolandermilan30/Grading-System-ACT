Imports MySql.Data.MySqlClient

Public Class Message
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
    Private adminOrTeacherName As String

    ' Constructor with name parameter
    Public Sub New(senderName As String)
        InitializeComponent()
        adminOrTeacherName = senderName
    End Sub

    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminname.Text = adminOrTeacherName
        LoadTeacherNames()
        LoadStudentList()
        LoadSemesterOptions()
        SetTabOrder() ' <-- tawagin dito

        teachernamemessage.DropDownStyle = ComboBoxStyle.DropDownList
        semestermsg.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub SetTabOrder()
        teachernamemessage.TabIndex = 0
        semestermsg.TabIndex = 1
        quizmessage.TabIndex = 2
        exercisesmessage.TabIndex = 3
        assigmentmessage.TabIndex = 4
        projectevalutionmessage.TabIndex = 5
        classparticipationmessage.TabIndex = 6
        activitymessage.TabIndex = 7
        projectmessage.TabIndex = 8
        exammessage.TabIndex = 9
        messagebox.TabIndex = 10
        sendmessage.TabIndex = 11
        backbtnmessage.TabIndex = 12
    End Sub



    Private Sub LoadSemesterOptions()
        semestermsg.Items.Clear()
        semestermsg.Items.Add("Prelim")
        semestermsg.Items.Add("Midterm")
        semestermsg.Items.Add("Semi-Finals")
        semestermsg.Items.Add("Finals")
    End Sub

    Private Sub LoadTeacherNames()
        Try
            conn.Open()
            Dim query As String = "SELECT fullname FROM users WHERE user_level = 'Teacher'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            teachernamemessage.Items.Clear()
            While reader.Read()
                teachernamemessage.Items.Add(reader("fullname").ToString())
            End While
            reader.Close()
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadStudentList()
        Try
            conn.Open()
            Dim query As String = "SELECT id, fullname, age, gender, identifier, department FROM users WHERE user_level = 'Student'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            studentlistmessage.Columns.Clear()
            studentlistmessage.DataSource = Nothing

            Dim checkboxColumn As New DataGridViewCheckBoxColumn()
            checkboxColumn.HeaderText = ""
            checkboxColumn.Name = "SelectStudent"
            studentlistmessage.Columns.Add(checkboxColumn)

            studentlistmessage.DataSource = dt

            studentlistmessage.Columns("id").HeaderText = "ID"
            studentlistmessage.Columns("fullname").HeaderText = "Full Name"
            studentlistmessage.Columns("age").HeaderText = "Age"
            studentlistmessage.Columns("gender").HeaderText = "Gender"
            studentlistmessage.Columns("identifier").HeaderText = "Student ID"
            studentlistmessage.Columns("department").HeaderText = "Department"

        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub studentlistmessage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentlistmessage.CellContentClick
        If e.ColumnIndex = studentlistmessage.Columns("SelectStudent").Index AndAlso e.RowIndex >= 0 Then
            Dim isChecked As Boolean = Convert.ToBoolean(studentlistmessage.Rows(e.RowIndex).Cells("SelectStudent").EditedFormattedValue)
            studentlistmessage.Rows(e.RowIndex).Selected = isChecked
        End If
    End Sub

    Private Sub sendmessage_Click(sender As Object, e As EventArgs) Handles sendmessage.Click
        If teachernamemessage.SelectedItem Is Nothing OrElse semestermsg.SelectedItem Is Nothing Then
            Return
        End If

        Dim teacherName = teachernamemessage.SelectedItem.ToString
        Dim semester = semestermsg.SelectedItem.ToString
        Dim quiz = quizmessage.Text
        Dim exercises = exercisesmessage.Text
        Dim assignment = assigmentmessage.Text
        Dim projectEvaluation = projectevalutionmessage.Text
        Dim classParticipation = classparticipationmessage.Text
        Dim activity = activitymessage.Text
        Dim project = projectmessage.Text
        Dim exam = exammessage.Text
        Dim messageText = messagebox.Text

        Dim studentsSelected = False

        Try
            conn.Open()

            For Each row As DataGridViewRow In studentlistmessage.Rows
                If Convert.ToBoolean(row.Cells("SelectStudent").Value) = True Then
                    studentsSelected = True
                    Dim studentName = row.Cells("fullname").Value.ToString

                    Dim query = "INSERT INTO message_teacher (teacher_name, student_name, semester, quiz, exercises, assignment, project_evaluation, class_participation, activity, project, exam, message) " &
                                      "VALUES (@teacher, @student, @semester, @quiz, @exercises, @assignment, @projEval, @classPart, @activity, @project, @exam, @message)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@teacher", teacherName)
                        cmd.Parameters.AddWithValue("@student", studentName)
                        cmd.Parameters.AddWithValue("@semester", semester)
                        cmd.Parameters.AddWithValue("@quiz", quiz)
                        cmd.Parameters.AddWithValue("@exercises", exercises)
                        cmd.Parameters.AddWithValue("@assignment", assignment)
                        cmd.Parameters.AddWithValue("@projEval", projectEvaluation)
                        cmd.Parameters.AddWithValue("@classPart", classParticipation)
                        cmd.Parameters.AddWithValue("@activity", activity)
                        cmd.Parameters.AddWithValue("@project", project)
                        cmd.Parameters.AddWithValue("@exam", exam)
                        cmd.Parameters.AddWithValue("@message", messageText)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            If studentsSelected Then
            Else
            End If

        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub


    ' Optional: Other TextChanged events can be removed or left empty
    Private Sub quizmessage_TextChanged(sender As Object, e As EventArgs) Handles quizmessage.TextChanged
    End Sub

    Private Sub exercisesmessage_TextChanged(sender As Object, e As EventArgs) Handles exercisesmessage.TextChanged
    End Sub

    Private Sub assigmentmessage_TextChanged(sender As Object, e As EventArgs) Handles assigmentmessage.TextChanged
    End Sub

    Private Sub projectevalutionmessage_TextChanged(sender As Object, e As EventArgs) Handles projectevalutionmessage.TextChanged
    End Sub

    Private Sub classparticipationmessage_TextChanged(sender As Object, e As EventArgs) Handles classparticipationmessage.TextChanged
    End Sub

    Private Sub activitymessage_TextChanged(sender As Object, e As EventArgs) Handles activitymessage.TextChanged
    End Sub

    Private Sub projectmessage_TextChanged(sender As Object, e As EventArgs) Handles projectmessage.TextChanged
    End Sub

    Private Sub exammessage_TextChanged(sender As Object, e As EventArgs) Handles exammessage.TextChanged
    End Sub

    Private Sub messagebox_TextChanged(sender As Object, e As EventArgs) Handles messagebox.TextChanged
    End Sub

    Private Sub adminname_Click(sender As Object, e As EventArgs) Handles adminname.Click

    End Sub

    Private Sub semestermsg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semestermsg.SelectedIndexChanged

    End Sub

    Private Sub backbtnmessage_Click(sender As Object, e As EventArgs) Handles backbtnmessage.Click
        Me.Close()
    End Sub

    Private Sub teachernamemessage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teachernamemessage.SelectedIndexChanged

    End Sub
End Class
