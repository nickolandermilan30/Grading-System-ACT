Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Form1

    Private Shared attemptCounter As Integer = 0
    Private Shared cooldownSeconds As Integer = 0
    Private Shared WithEvents cooldownTimer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cooldownTimer.Interval = 1000 ' 1 second interval

        ' Eto yung bago: manually subscribe
        AddHandler cooldownTimer.Tick, AddressOf cooldownTimer_Tick

        If cooldownSeconds > 0 Then
            passwordinput.Enabled = False
            loginbtn.Enabled = False
            cooldownTimer.Start()
            UpdateCooldownLabel()
        End If

        Me.AcceptButton = loginbtn
    End Sub



    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If String.IsNullOrWhiteSpace(emailinput.Text) OrElse String.IsNullOrWhiteSpace(passwordinput.Text) Then
            MessageBox.Show("Please enter both Username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE email = @Email AND password = @Password", conn)
            cmd.Parameters.AddWithValue("@Email", emailinput.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", passwordinput.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Check if the account is active
                Dim isActive As Boolean = Convert.ToBoolean(reader("active"))
                If Not isActive Then
                    MessageBox.Show("Your account has been deactivated. Please contact the administrator.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If



                Dim userLevel As String = reader("user_level").ToString()

                MessageBox.Show("Login successful as " & userLevel, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Select Case userLevel
                    Case "Admin"
                        Dim adminName As String = reader("fullname").ToString()
                        Dim adminDept As String = reader("department").ToString()
                        Dim adminForm As New AdminPagevb(adminName, adminDept)
                        adminForm.Show()

                    Case "Student"
                        Dim studentName As String = reader("fullname").ToString()
                        Dim studentDept As String = reader("department").ToString()
                        Dim studentForm As New StudentPage(studentName, studentDept)
                        studentForm.Show()

                    Case "Teacher"
                        Dim teacherName As String = reader("fullname").ToString()
                        Dim teacherDept As String = reader("department").ToString()
                        Dim teacherForm As New TeacherPage(teacherName, teacherDept)
                        teacherForm.Show()
                End Select

                Me.Hide()
                attemptCounter = 0

            Else
                attemptCounter += 1
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                attemp.Text = $"Attempts: {attemptCounter}/5"

                If attemptCounter = 3 Then
                    StartCooldown()
                ElseIf attemptCounter >= 5 Then
                    MessageBox.Show("Too many failed attempts. Closing application.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Application.Exit()
                End If
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub StartCooldown()
        cooldownSeconds = 60 ' 1 minute
        passwordinput.Enabled = False
        loginbtn.Enabled = False
        cooldownTimer.Start()
        UpdateCooldownLabel()
    End Sub

    Private Sub UpdateCooldownLabel()
        Dim minutes As Integer = cooldownSeconds \ 60
        Dim seconds As Integer = cooldownSeconds Mod 60
        attemp.Text = $"Cooldown: {minutes}m {seconds}s"
    End Sub


    Private Sub cooldownTimer_Tick(sender As Object, e As EventArgs)
        cooldownSeconds -= 1
        If cooldownSeconds <= 0 Then
            cooldownTimer.Stop()
            passwordinput.Enabled = True
            loginbtn.Enabled = True
            attemp.Text = $"Attempts: {attemptCounter}/5"
        Else
            UpdateCooldownLabel()
        End If
    End Sub



    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim regForm As New Resgister_Type()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Forgotbtn_Click(sender As Object, e As EventArgs) Handles forgotbtn.Click
        Dim forgotForm As New Forgot_Password()
        forgotForm.Show()
        Me.Hide()
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Close()
    End Sub

    Private Sub seepass_CheckedChanged(sender As Object, e As EventArgs) Handles seepass.CheckedChanged
        If seepass.Checked Then
            passwordinput.PasswordChar = ControlChars.NullChar ' Shows the actual text
        Else
            passwordinput.PasswordChar = "*"c ' Hides the text as *
        End If
    End Sub

    ' Not used anymore since we update label in login logic
    Private Sub attemp_Click(sender As Object, e As EventArgs) Handles attemp.Click
    End Sub

    Private Sub passwordinput_TextChanged(sender As Object, e As EventArgs) Handles passwordinput.TextChanged
    End Sub

End Class
