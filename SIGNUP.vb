Imports System.Text
Imports Org.BouncyCastle.Tls
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.ComponentModel.DataAnnotations
Public Class SIGNUP

    Private Sub Sign_up_Click(sender As Object, e As EventArgs) Handles Sign_up.Click
        ' Get data from form controls
        Dim empName As String = txt_name.Text.Trim()
        Dim empAddress As String = txt_address.Text.Trim()
        Dim empContact As String = txt_contact.Text.Trim()
        Dim empBDate As Date = birthdate.Value
        Dim username As String = txt_username.Text.Trim()
        Dim password As String = HashPassword(txt_password.Text)
        Dim position As String = cb_position.Text.Trim()

        ' Validate empContact to accept only 10-digit numbers


        If String.IsNullOrWhiteSpace(empName) OrElse String.IsNullOrWhiteSpace(empAddress) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse Not IsNumeric(empContact) OrElse empContact.Length <> 10 Then
            MessageBox.Show("Please check the information above. Error signing up!")
        Else
            If txt_password.Text.Trim() = txt_passCheck.Text.Trim() Then
                If Not UsernameExists(username) Then
                    Dim empQuery As String = "INSERT INTO Employee (Emp_name, Emp_address, Emp_cnumber, Emp_bdate, Emp_status) " &
                     "VALUES (@Name, @Address, @Contact, @BDate, 'ACTIVE');"

                    ' Insert into Users table
                    Dim userQuery As String = "INSERT INTO Users (Employee_ID, Username, PasswordHash, Privilege, Status) " &
                          "VALUES (@EmpID, @Username, @Password, @Position, 'OFFLINE');"

                    If openDB() Then
                        Try
                            ' Insert into Employee table
                            Using empCmd As New MySqlCommand(empQuery, Conn)
                                empCmd.Parameters.AddWithValue("@Name", empName)
                                empCmd.Parameters.AddWithValue("@Address", empAddress)
                                empCmd.Parameters.AddWithValue("@Contact", empContact)
                                empCmd.Parameters.AddWithValue("@BDate", empBDate)
                                empCmd.ExecuteNonQuery()
                            End Using

                            ' Get the last inserted Employee ID
                            Dim empID As Integer = CInt(New MySqlCommand("SELECT LAST_INSERT_ID();", Conn).ExecuteScalar())

                            ' Insert into Users table
                            Using userCmd As New MySqlCommand(userQuery, Conn)
                                userCmd.Parameters.AddWithValue("@EmpID", empID)
                                userCmd.Parameters.AddWithValue("@Username", username)
                                userCmd.Parameters.AddWithValue("@Password", password)
                                userCmd.Parameters.AddWithValue("@Position", position)
                                userCmd.ExecuteNonQuery()
                            End Using

                            ' Sign up successful
                            MessageBox.Show("Sign up successful!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("The database is not connected")
                    End If
                Else
                    MessageBox.Show("Username already exists. Please choose a different username.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Ensure the passwords match to proceed. Thank you.")
            End If
        End If
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Dim query As New MySqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username;", Conn)
        query.Parameters.AddWithValue("@Username", username)

        If openDB() Then
            Dim count As Integer = CInt(query.ExecuteScalar())
            closeDB()
            Return count > 0
        Else
            MessageBox.Show("The database is not connected")
            Return False
        End If
    End Function



    Private Function HashPassword(password As String) As String
        ' Create an instance of the SHA256 hashing algorithm
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


End Class