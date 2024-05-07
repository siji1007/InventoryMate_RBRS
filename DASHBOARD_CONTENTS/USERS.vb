
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
                        Dim status As String = dr.Item("Emp_Status").ToString()
                        Dim color As Color = If(status = "ACTIVE", Color.Green, Color.Red)
                        Dim rowIndex As Integer = usersDt.Rows.Add(dr.Item("Employee_ID"), dr.Item("Emp_name"), dr.Item("Privilege"), dr.Item("Emp_Status"))
                        usersDt.Rows(rowIndex).DefaultCellStyle.BackColor = color
                    End While
                End Using


            Else
                MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub


    Private Sub usersDt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersDt.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = usersDt.Rows(e.RowIndex)

            Dim UserId As String = selectedRow.Cells("userID").Value.ToString()
            Dim EmpName As String = selectedRow.Cells("EmpName").Value.ToString()
            Dim JobPos As String = selectedRow.Cells("jobpos").Value.ToString()
            Dim Status As String = selectedRow.Cells("status").Value.ToString()


            For Each row As DataGridViewRow In usersDt.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next

            Cb_Jobpos.Text = JobPos

        End If
    End Sub

    Private Sub Btn_Hired_Click(sender As Object, e As EventArgs) Handles Btn_Hired.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed with hiring this pending request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                If openDB() Then
                    ' Get the selected employee's User ID
                    Dim selectedRow As DataGridViewRow = usersDt.SelectedRows(0)
                    Dim userId As String = selectedRow.Cells("userID").Value.ToString()

                    ' Update the Emp_Status to 'ACTIVE' for the corresponding employee in the employee table
                    Dim query As New MySqlCommand("UPDATE employee SET Emp_Status = 'ACTIVE' WHERE Emp_ID = (SELECT Employee_ID FROM users WHERE Employee_ID = @Employee_ID)", Conn)
                    query.Parameters.AddWithValue("@Employee_ID", userId)

                    Dim rowsAffected As Integer = query.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("User status hired successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        usersDt.Rows.Clear()
                        LoadUser()

                    Else
                        MessageBox.Show("No rows updated. Employee ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating employee status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Btn_Fired_Click(sender As Object, e As EventArgs) Handles Btn_Fired.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go ahead with dismissing this pending request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                If openDB() Then
                    ' Get the selected employee's User ID
                    Dim selectedRow As DataGridViewRow = usersDt.SelectedRows(0)
                    Dim userId As String = selectedRow.Cells("userID").Value.ToString()

                    ' Update the Emp_Status to 'ACTIVE' for the corresponding employee in the employee table
                    Dim query As New MySqlCommand("UPDATE employee SET Emp_Status = 'OFFLINE' WHERE Emp_ID = (SELECT Employee_ID FROM users WHERE Employee_ID = @Employee_ID)", Conn)
                    query.Parameters.AddWithValue("@Employee_ID", userId)

                    Dim rowsAffected As Integer = query.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("User status fired successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        usersDt.Rows.Clear()
                        LoadUser()

                    Else
                        MessageBox.Show("No rows updated. Employee ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating employee status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Btn_promote_Click(sender As Object, e As EventArgs) Handles Btn_promote.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to promote the selected employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try
                Dim selectedRowIndex As Integer = usersDt.CurrentCell.RowIndex
                Dim selectedEmployeeID As Integer = Convert.ToInt32(usersDt.Rows(selectedRowIndex).Cells("userID").Value)
                Dim selectedPrivilege As String = Cb_Jobpos.SelectedItem.ToString()

                If openDB() Then
                    Dim query As New MySqlCommand("UPDATE users SET Privilege = @Privilege WHERE Employee_ID = @Employee_ID", Conn)
                    query.Parameters.AddWithValue("@Privilege", selectedPrivilege)
                    query.Parameters.AddWithValue("@Employee_ID", selectedEmployeeID)
                    Dim rowsAffected As Integer = query.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Privilege updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        usersDt.Rows.Clear()
                        LoadUser()

                    Else
                        MessageBox.Show("Failed to update Privilege.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating Privilege: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



End Class
