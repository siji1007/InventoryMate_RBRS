
Imports MySql.Data.MySqlClient

Public Class USERS
    Private Sub GroupBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadUser()
    End Sub


    Private Sub LoadUser()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT u.Employee_ID, e.Emp_name, e.Emp_Status, u.Privilege FROM users u INNER JOIN employee e ON u.Employee_ID = e.Emp_ID", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim rowIndex As Integer = usersDt.Rows.Add(dr.Item("Employee_ID"), dr.Item("Emp_name"), dr.Item("Privilege"), dr.Item("Emp_Status"))
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub


End Class
