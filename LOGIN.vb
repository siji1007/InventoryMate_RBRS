Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class LOGIN
    Public Event SignInClicked()

    Private Sub Btn_SignIn_Click(sender As Object, e As EventArgs) Handles Btn_SignIn.Click
        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text

        Try
            If openDB() Then
                ' Check user credentials
                Dim query As New MySqlCommand("SELECT * FROM Users WHERE Username=@Username;", Conn)
                query.Parameters.AddWithValue("@Username", username)

                Dim userStatus As String = ""

                Using reader As MySqlDataReader = query.ExecuteReader()
                    If reader.Read() Then
                        Dim userID As Integer = reader.GetInt32("UserID")
                        Dim hashedPassword As String = reader.GetString("PasswordHash")
                        Dim enteredPassword As String = HashPassword(password)

                        If hashedPassword = enteredPassword Then
                            userStatus = reader.GetString("Status")
                        Else
                            MessageBox.Show("Incorrect password. Please try again.")
                        End If
                    Else
                        MessageBox.Show("Invalid username. Please try again.")
                    End If
                End Using

                ' Close the data reader after reading user credentials
                ' and before checking user status or updating status
                If userStatus = "OFFLINE" Then
                    ' Begin transaction for updating user status
                    Using transaction As MySqlTransaction = Conn.BeginTransaction()
                        Try
                            ' Update user status to 'ACTIVE'
                            Dim updateQuery As New MySqlCommand("UPDATE Users SET Status='ACTIVE' WHERE Username=@Username;", Conn, transaction)
                            updateQuery.Parameters.AddWithValue("@Username", username)
                            updateQuery.ExecuteNonQuery()



                            ' Commit transaction if all operations succeed
                            transaction.Commit()

                            MessageBox.Show("LOGIN SUCCESSFULLY!")

                            Dim mainForm As MAIN_FORM = TryCast(Me.ParentForm, MAIN_FORM)
                            mainForm.SwitchToDashboard()



                        Catch ex As Exception
                            ' Rollback transaction if an error occurs
                            transaction.Rollback()
                            MessageBox.Show("Error updating user status: " & ex.Message)
                        End Try
                    End Using


                End If
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB()
        End Try

    End Sub


    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Compute the hash value from the password
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Convert the hashed bytes to a hexadecimal string
            Dim sb As New StringBuilder()
            For Each b As Byte In hashedBytes
                sb.Append(b.ToString("x2"))
            Next

            ' Return the hashed password as a string
            Return sb.ToString()
        End Using
    End Function

    Private Sub Pass_show_Click(sender As Object, e As EventArgs) Handles Pass_show.Click
        If txt_password.PasswordChar = Char.MinValue Then
            ' If password masking is disabled, enable it with '*'
            txt_password.PasswordChar = "*"
        Else
            ' If password masking is enabled, disable it
            txt_password.PasswordChar = Char.MinValue
        End If
    End Sub
End Class
