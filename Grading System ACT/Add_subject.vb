Imports MySql.Data.MySqlClient

Public Class Add_subject
    Public TeacherNameFromMain As String
    Public TeacherDeptFromMain As String

    Private Sub Add_subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameteacheraddsubject.Text = TeacherNameFromMain
    End Sub


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
                Dim addedCount As Integer = 0
                Dim skippedCount As Integer = 0

                For Each subject In subjectlist.CheckedItems
                    Dim subjectName As String = subject.ToString().Trim()

                    ' Check if subject already exists in the database
                    Dim checkQuery As String = "SELECT COUNT(*) FROM subjects WHERE subject_name = @subjectName"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@subjectName", subjectName)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        If count > 0 Then
                            skippedCount += 1
                            Continue For
                        End If
                    End Using

                    ' Insert subject and teacher's name if not duplicate
                    Dim insertQuery As String = "INSERT INTO subjects (subject_name, teacher_name) VALUES (@SubjectName, @TeacherName)"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@SubjectName", subjectName)
                        insertCmd.Parameters.AddWithValue("@TeacherName", TeacherNameFromMain) ' Save teacher's name
                        insertCmd.ExecuteNonQuery()
                        addedCount += 1
                    End Using
                Next

                If addedCount > 0 Then
                    MessageBox.Show($"{addedCount} subject(s) saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If skippedCount > 0 Then
                    MessageBox.Show($"{skippedCount} duplicate subject(s) were skipped.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Error saving subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try

            ' Return to TeacherPage
            Dim teacherPageForm As New TeacherPage(TeacherNameFromMain, TeacherDeptFromMain)
            Me.Close()
        Else
            MessageBox.Show("Please check at least one subject to save.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub subjectlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectlist.SelectedIndexChanged
        Dim selectedSubject As String = subjectlist.SelectedItem.ToString()
    End Sub

    Private Sub backtomainsub_Click(sender As Object, e As EventArgs) Handles backtomainsub.Click
        Me.Close()
    End Sub

    Private Sub nameteacheraddsubject_Click(sender As Object, e As EventArgs) Handles nameteacheraddsubject.Click

    End Sub
End Class