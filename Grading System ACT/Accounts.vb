Imports MySql.Data.MySqlClient

Public Class Accounts
    Private conn As MySqlConnection

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
        LoadDeactivatedAccounts
    End Sub

    Private Sub LoadDeactivatedAccounts()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            Dim query As String =
            "SELECT fullname, age, gender, identifier, section, position, " &
            "major_subject, department, user_level, email FROM users WHERE active = 0"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Clear columns and add checkbox to deactivelist
            deactivelist.Columns.Clear()
            Dim chk As New DataGridViewCheckBoxColumn() With {
            .Name = "Select",
            .HeaderText = "",
            .Width = 30,
            .ReadOnly = False
        }
            deactivelist.Columns.Add(chk)

            deactivelist.DataSource = table

            ' Style
            deactivelist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            deactivelist.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            deactivelist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each col As DataGridViewColumn In deactivelist.Columns
                If col.Name = "Select" Then
                    col.Width = 30
                Else
                    col.MinimumWidth = 100
                    col.Width = 130
                End If
            Next

            deactivelist.AllowUserToResizeColumns = True
            deactivelist.RowHeadersVisible = False
            deactivelist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            deactivelist.MultiSelect = False

        Catch ex As Exception
            MessageBox.Show("Error loading deactivated accounts: " & ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub LoadAccounts()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            ' Query WITHOUT the id column
            Dim query As String =
    "SELECT fullname, age, gender, identifier, section, position, " &
    "major_subject, department, user_level, email FROM users WHERE active = 1"


            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Clear existing columns and add checkbox column
            accountlist.Columns.Clear()
            Dim chk As New DataGridViewCheckBoxColumn() With {
                .Name = "Select",
                .HeaderText = "",
                .Width = 30,
                .ReadOnly = False
            }
            accountlist.Columns.Add(chk)

            ' Bind data
            accountlist.DataSource = table

            ' Set column widths and center alignment
            accountlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            accountlist.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            accountlist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each col As DataGridViewColumn In accountlist.Columns
                If col.Name = "Select" Then
                    col.Width = 30
                Else
                    col.MinimumWidth = 100
                    col.Width = 130
                End If
            Next

            accountlist.AllowUserToResizeColumns = True
            accountlist.RowHeadersVisible = False
            accountlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            accountlist.MultiSelect = False

        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub accountlist_CellContentClick(sender As Object,
                                            e As DataGridViewCellEventArgs) _
                                            Handles accountlist.CellContentClick
        If e.RowIndex >= 0 AndAlso accountlist.Columns(e.ColumnIndex).Name = "Select" Then
            Dim currentValue = accountlist.Rows(e.RowIndex).Cells("Select").Value
            Dim isChecked = If(IsDBNull(currentValue), False, CBool(currentValue))

            ' Toggle checkbox manually
            accountlist.Rows(e.RowIndex).Cells("Select").Value = Not isChecked

            ' Select or deselect the row based on the checkbox state
            accountlist.Rows(e.RowIndex).Selected = Not isChecked
        End If
    End Sub

    Private Sub deleteaccount_Click(sender As Object, e As EventArgs) Handles deleteaccount.Click
        Dim accountsToDelete As New List(Of String) ' Will hold identifiers (you can change this to a different unique field if needed)

        ' Collect selected rows
        For Each row As DataGridViewRow In accountlist.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                ' Use a unique value to identify accounts (here, we use "identifier")
                accountsToDelete.Add(row.Cells("identifier").Value.ToString())
            End If
        Next

        If accountsToDelete.Count = 0 Then
            MessageBox.Show("Please select at least one account to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmation prompt
        Dim confirmResult = MessageBox.Show("Are you sure you want to delete the selected account(s)?",
                                            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Delete from database
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            For Each identifier As String In accountsToDelete
                Dim deleteQuery As String = "DELETE FROM users WHERE identifier = @identifier"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@identifier", identifier)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Selected account(s) deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAccounts() ' Refresh the table

        Catch ex As Exception
            MessageBox.Show("Error deleting accounts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub deactiveaccount_Click(sender As Object, e As EventArgs) Handles deactiveaccount.Click
        Dim accountsToDeactivate As New List(Of String) ' Will hold identifiers of accounts to deactivate

        ' Collect selected rows
        For Each row As DataGridViewRow In accountlist.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                ' Use a unique value to identify accounts (here, we use "identifier")
                accountsToDeactivate.Add(row.Cells("identifier").Value.ToString)
            End If
        Next

        If accountsToDeactivate.Count = 0 Then
            MessageBox.Show("Please select at least one account to deactivate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmation prompt
        Dim confirmResult = MessageBox.Show("Are you sure you want to deactivate the selected account(s)?",
                                            "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Deactivate the accounts in the database
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            For Each identifier In accountsToDeactivate
                Dim updateQuery = "UPDATE users SET active = 0 WHERE identifier = @identifier"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@identifier", identifier)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Selected account(s) deactivated successfully.", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAccounts() ' Refresh the table

        Catch ex As Exception
            MessageBox.Show("Error deactivating accounts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub deactivelist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles deactivelist.CellContentClick

    End Sub

    Private Sub activeaccount_Click(sender As Object, e As EventArgs) Handles activeaccount.Click
        Dim accountsToActivate As New List(Of String) ' Will hold identifiers of accounts to activate

        ' Collect selected rows
        For Each row As DataGridViewRow In deactivelist.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                accountsToActivate.Add(row.Cells("identifier").Value.ToString())
            End If
        Next

        If accountsToActivate.Count = 0 Then
            MessageBox.Show("Please select at least one account to activate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmation prompt
        Dim confirmResult = MessageBox.Show("Are you sure you want to activate the selected account(s)?",
                                            "Confirm Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return
        End If

        ' Activate the accounts in the database
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")
            conn.Open()

            For Each identifier In accountsToActivate
                Dim updateQuery = "UPDATE users SET active = 1 WHERE identifier = @identifier"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@identifier", identifier)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Selected account(s) activated successfully.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAccounts() ' Refresh the active list
            LoadDeactivatedAccounts() ' Refresh the deactivated list

        Catch ex As Exception
            MessageBox.Show("Error activating accounts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub backbtntoadmin_Click(sender As Object, e As EventArgs) Handles backbtntoadmin.Click
        Me.Close()
    End Sub

    Private Sub refreshadmin_Click(sender As Object, e As EventArgs) Handles refreshadmin.Click
        Try
            LoadAccounts()
            LoadDeactivatedAccounts()
            accountlist.ClearSelection()
            deactivelist.ClearSelection()
        Catch ex As Exception
        End Try
    End Sub

End Class
