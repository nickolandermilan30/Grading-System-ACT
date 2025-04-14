Imports MySql.Data.MySqlClient

Public Class Add_subject
    Public TeacherNameFromMain As String
    Public TeacherDeptFromMain As String

    Private Sub inputsubject_TextChanged(sender As Object, e As EventArgs) Handles inputsubject.TextChanged
    End Sub

    Private Sub addsubjecttolist_Click(sender As Object, e As EventArgs) Handles addsubjecttolist.Click
        Dim subject As String = inputsubject.Text.Trim()

        If subject <> "" Then
            subjectlist.Items.Add(subject)
            inputsubject.Clear()
        Else
            MessageBox.Show("Please enter a subject name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub doneaddsubjecttogrid_Click(sender As Object, e As EventArgs) Handles doneaddsubjecttogrid.Click
        If subjectlist.CheckedItems.Count > 0 Then
            Try
                OpenConnection()

                For Each subject In subjectlist.CheckedItems
                    Dim query As String = "INSERT INTO subjects (subject_name) VALUES (@SubjectName)"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubjectName", subject.ToString())
                    cmd.ExecuteNonQuery()
                Next

                MessageBox.Show("All selected subjects saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error saving subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try

            ' Go back to TeacherPage
            Dim teacherPageForm As New TeacherPage(TeacherNameFromMain, TeacherDeptFromMain)
            teacherPageForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Please check at least one subject to save.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub subjectlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectlist.SelectedIndexChanged
        Dim selectedSubject As String = subjectlist.SelectedItem.ToString()
    End Sub

    Private Sub backtomainsub_Click(sender As Object, e As EventArgs) Handles backtomainsub.Click
        ' Create a new instance of TeacherPage with the teacher's name and department
        Dim teacherName As String = "Teacher Name" ' Replace with the actual teacher name if available
        Dim teacherDept As String = "Teacher Dept" ' Replace with the actual department if available

        ' Show the TeacherPage and close Add_subject form
        Dim teacherPageForm As New TeacherPage(teacherName, teacherDept)
        teacherPageForm.Show()

        ' Close the current Add_subject form
        Me.Close()
    End Sub
End Class