
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            If String.IsNullOrWhiteSpace(emailinput.Text) OrElse String.IsNullOrWhiteSpace(passwordinput.Text) Then
                MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE identifier = @identifier AND password = @password", conn)
            cmd.Parameters.AddWithValue("@identifier", emailinput.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passwordinput.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim userLevel As String = reader("user_level").ToString()

                MessageBox.Show("Login successful as " & userLevel, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'GoTo to userlevel shitS
                Select Case userLevel
                    Case "Admin"

                        Dim adminForm As New AdminPagevb()
                        adminForm.Show()

                    Case "Student"
                        Dim studentForm As New StudentPage()
                        studentForm.Show()

                    Case "Teacher"
                        Dim teacherForm As New TeacherPage()
                        teacherForm.Show()
                End Select

                Me.Hide()

            Else
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim regForm As New Resgister_Type()
        regForm.Show()
        Me.Hide()
    End Sub


    Private Sub Forgotbtn_Click(sender As Object, e As EventArgs) Handles forgotbtn.Click

    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub


End Class
