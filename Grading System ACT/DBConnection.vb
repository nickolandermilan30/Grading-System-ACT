﻿Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As New MySqlConnection("server=localhost;userid=root;password=;database=gradingsystem")

    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
