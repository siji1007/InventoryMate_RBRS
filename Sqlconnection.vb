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

End Module
