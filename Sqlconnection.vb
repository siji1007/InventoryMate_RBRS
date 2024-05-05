Imports System.IO
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

    Public Sub RestoreDatabaseFromBackup(backupFilePath As String)
        Try
            ' Read the SQL content from the backup file
            Dim sqlContent As String = File.ReadAllText(backupFilePath)

            ' Establish a connection to your MySQL server (XAMPP)
            Dim connectionString As String = "server=localhost; user=root; password=; database=mysql;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Split the SQL commands if multiple commands exist in the backup file
                Dim sqlCommands As String() = sqlContent.Split(New String() {";" & Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                For Each command As String In sqlCommands
                    Try
                        ' Execute each SQL command
                        Dim cmd As New MySqlCommand(command, conn)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        ' Handle command execution errors
                        MessageBox.Show($"Error executing SQL command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next

                ' Close the connection
                conn.Close()

                MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show($"Error restoring database from backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Module
