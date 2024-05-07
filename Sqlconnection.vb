Imports MySql.Data.MySqlClient

Module Sqlconnection
    Public Conn As New MySqlConnection
    Dim StrConn As String = "server=localhost; user=root; password=; database=inventorymate;"
    Dim StrConnBackup As String = "server=localhost; user=root; password=; database=back_up;"

    Public Function openDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.ConnectionString = If(CheckDatabaseExists("inventorymate"), StrConn, StrConnBackup)
                Conn.Open() ' Open the connection after setting the connection string
            End If
            Return True ' Return true if connection is opened successfully
        Catch ex As Exception
            ' Throw an error message if connection fails
            Throw New Exception("Failed to connect to the database: " & ex.Message)
            Return False ' Return false (optional, as the code will not reach here if an exception is thrown)
        End Try
    End Function

    Public Function CheckDatabaseExists(databaseName As String) As Boolean
        Dim exists As Boolean = False
        Try
            Using checkConn As New MySqlConnection(StrConn)
                checkConn.Open()
                Dim cmd As New MySqlCommand("SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @dbName", checkConn)
                cmd.Parameters.AddWithValue("@dbName", databaseName)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    exists = True ' Database exists
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions if needed, such as logging errors
        End Try
        Return exists
    End Function

    Public Sub closeDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub


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
