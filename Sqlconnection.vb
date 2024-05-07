Imports MySql.Data.MySqlClient

Module Sqlconnection
    Public Conn As New MySqlConnection
    Dim StrConn As String = "server=localhost; user=root; password=; database=inventorymate;"

    Public Function openDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.ConnectionString = StrConn
                Conn.Open()
            End If
            Return True ' Return true if connection is opened successfully
        Catch ex As Exception
            ' Throw an error message if connection fails
            Throw New Exception("Failed to connect to the database: " & ex.Message)
            Return False ' Return false (optional, as the code will not reach here if an exception is thrown)
        End Try
    End Function

    Public Sub closeDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Public Function CheckDatabaseExists(databaseName As String) As Boolean
        Try
            openDB()
            Dim cmd As New MySqlCommand("SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @dbName", Conn)
            cmd.Parameters.AddWithValue("@dbName", databaseName)
            Dim result As Object = cmd.ExecuteScalar()
            closeDB()
            If result IsNot Nothing Then
                Return True ' Database exists
            Else
                Return False ' Database does not exist
            End If
        Catch ex As MySqlException
            ' Handle MySQL-specific exceptions
            If ex.Number = 0 Then
                Throw New Exception("Server is not reachable. Please check your MySQL server and try again.")
            Else
                Throw New Exception("MySQL Error: " & ex.Message)
            End If
            Return False
        Catch ex As Exception
            ' Handle other exceptions
            Throw New Exception("Error checking database existence: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function IsXAMPPRunning() As Boolean
        ' Check if XAMPP Control Panel process is running
        Dim xamppProcessName As String = "xampp-control"
        Dim processes() As Process = Process.GetProcessesByName(xamppProcessName)

        If processes.Length > 0 Then
            ' XAMPP Control Panel process is running
            Return True
        Else
            ' XAMPP Control Panel process is not running
            Return False
        End If
    End Function

    Public Sub RestoreDatabaseFromBackup(backupFilePath As String)
        Try
            ' Check if XAMPP Control Panel is running
            If Not IsXAMPPRunning() Then
                Throw New Exception("XAMPP Control Panel is not running. Please start XAMPP before restoring the database.")
            End If

            ' Check if the database exists on the local XAMPP server
            Dim dbName As String = "inventorymate"
            If CheckDatabaseExists(dbName) Then
                ' Database exists on local XAMPP server, perform operations here
                MessageBox.Show("Database 'inventorymate' exists on the local server.", "Database Existence", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Add your code here for operations on the local server
            Else
                ' Database does not exist on local XAMPP server, handle accordingly
                MessageBox.Show("Database 'inventorymate' does not exist on the local server or there was an error connecting.", "Database Existence", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
