Public Class Grading
    Private studentName As String
    Private subjectName As String

    Public Sub SetStudentAndSubject(name As String, subject As String)
        studentName = name
        subjectName = subject

        ' Optional: i-display sa label kung gusto mo
        namegrading.Text = studentName
        subjectgrading.Text = subjectName
    End Sub

    Private Sub Grading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pwede mong gamitin yung studentName at subjectName dito
    End Sub
End Class
