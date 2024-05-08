Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel


Public Class EMPLOYEE

    Private selectedStatus As String = ""

    Private Sub lbl_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust label properties
        lbl_employee.Anchor = AnchorStyles.None
        lbl_employee.TextAlign = ContentAlignment.MiddleCenter
        lbl_employee.AutoSize = False
        lbl_employee.Width = Me.ClientSize.Width

        ' Center the label horizontally
        Dim centerX As Integer = (Me.ClientSize.Width - lbl_employee.Width) \ 2
        lbl_employee.Location = New Point(centerX, lbl_employee.Location.Y)

        ' Load employee data
        DataLoadEmployee()

        Try
            If openDB() Then
                ' Check user privilege and status
                Dim query As New MySqlCommand("SELECT Privilege, Status FROM Users WHERE Status = 'ACTIVE';", Conn)

                Dim userPrivilege As String = ""
                Dim userStatus As String = ""

                Using reader = query.ExecuteReader
                    If reader.Read Then
                        userPrivilege = reader.GetString("Privilege")

                    End If

                    ' Disable update button if user privilege is EMPLOYEE
                    If userPrivilege = "EMPLOYEE" Then
                        Btn_update.Enabled = False
                        GeneRate.Visible = False
                    ElseIf userPrivilege = "OWNER" Then
                        Btn_update.Enabled = True
                        GeneRate.Visible = True

                    End If

                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try
    End Sub



    Private Sub DataLoadEmployee()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT Emp_ID, Emp_name, Emp_address, Emp_cnumber, DATE_FORMAT(Emp_bdate, '%b-%e-%Y') AS Emp_bdate, Emp_status FROM employee", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        ' Concatenate "+63" to the beginning of Emp_cnumber
                        Dim formattedCnumber As String = "+63" & dr.Item("Emp_cnumber").ToString()
                        Dim formattedDate As String = dr.Item("Emp_bdate").ToString() ' Convert date to string
                        Dim rowIndex As Integer = emp_datagridview.Rows.Add(dr.Item("Emp_ID"), dr.Item("Emp_name"), dr.Item("Emp_address"), formattedCnumber, formattedDate, dr.Item("Emp_status"))


                        Dim Status As String = dr.Item("Emp_status")
                        If Status = "OFFLINE" Then
                            emp_datagridview.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
                        End If

                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to database")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        status_menu.Show(Button1, 0, Button1.Height)
    End Sub

    Private Sub MenuItem_Click(sender As Object, e As EventArgs) Handles ACTIVE.Click, OFFLINE.Click
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Button1.Text = menuItem.Text
        selectedStatus = menuItem.Text
    End Sub


    'THIS IS FOR ADD BUTTON 
    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Dim selectedDate As Date = emp_birthdate.Value
        ' Format the date correctly for MySQL
        Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")

        ' Trim the textbox 
        Dim Emp_name As String = txt_emp_name.Text.Trim()
        Dim Emp_address As String = txt_emp_address.Text.Trim()

        Dim Emp_cnumber As String = txt_emp_cnumber.Text.Trim()
        If Emp_cnumber.StartsWith("+63") Then
            Emp_cnumber = Emp_cnumber.Substring(3) ' Remove "+63"
        End If

        ' Ensure Emp_cnumber contains exactly 10 digits
        If String.IsNullOrEmpty(Emp_name) OrElse String.IsNullOrEmpty(Emp_address) OrElse Emp_cnumber.Length <> 10 OrElse Not Emp_cnumber.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Please fill the information properly.")
        Else
            If EmployeeExist(Emp_name, Emp_address, Emp_cnumber) Then
                MessageBox.Show("Employee with the same name, address, and contact number already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If openDB() Then
                        Dim query As String = "INSERT INTO employee (Emp_name, Emp_address, Emp_cnumber, Emp_bdate, Emp_status) VALUES (@Emp_name, @Emp_address, @Emp_cnumber, STR_TO_DATE(@Emp_bdate, '%Y-%m-%d'), @Emp_status)"
                        Dim cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("@Emp_name", Emp_name.ToUpper())
                        cmd.Parameters.AddWithValue("@Emp_address", Emp_address.ToUpper())
                        cmd.Parameters.AddWithValue("@Emp_cnumber", Emp_cnumber)
                        cmd.Parameters.AddWithValue("@Emp_bdate", formattedDate) ' Use formatted date
                        cmd.Parameters.AddWithValue("@Emp_status", selectedStatus.ToUpper())

                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Successfully added")
                            emp_datagridview.Rows.Clear()
                            DataLoadEmployee()

                            txt_emp_name.Clear()
                            txt_emp_address.Clear()
                            txt_emp_cnumber.Clear()
                            emp_birthdate.Value = DateTime.Today
                            Button1.Text = ">>"

                        Catch ex As Exception
                            MessageBox.Show("Error adding customer : " & ex.Message)
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("The database is not connected")
                    End If
                End If
            End If
        End If
    End Sub

    Private Function EmployeeExist(ByVal name As String, ByVal address As String, ByVal cNumber As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM employee WHERE Emp_name = @name AND Emp_address = @address AND Emp_cnumber = @cNumber"

        If openDB() Then
            Using cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@name", name.ToUpper())
                cmd.Parameters.AddWithValue("@address", address.ToUpper())
                cmd.Parameters.AddWithValue("@cNumber", cNumber)


                Dim employeeCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return employeeCount > 0
            End Using
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If

        Return True ' Default return value if an exception occurs
    End Function





    'DATAGRIDVIEW EVENTS BY CLICKING ONE FOR ALL ROWS 
    Private Sub emp_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles emp_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = emp_datagridview.Rows(e.RowIndex)

            Dim EmpId As String = selectedRow.Cells("Emp_ID").Value.ToString()
            Dim EmpName As String = selectedRow.Cells("Emp_name").Value.ToString()
            Dim EmpAddress As String = selectedRow.Cells("Emp_address").Value.ToString()
            Dim EmpCnumber As Long = Convert.ToInt64(selectedRow.Cells("Emp_cnumber").Value)
            Dim EmpBdate As String = selectedRow.Cells("Emp_bdate").Value.ToString()
            Dim EmpStatus As String = selectedRow.Cells("Emp_status").Value.ToString()



            For Each row As DataGridViewRow In emp_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If

            Next


            'Add the selected value in datagrid in their corresponding textbox 
            txt_emp_name.Text = EmpName
            txt_emp_address.Text = EmpAddress
            txt_emp_cnumber.Text = "+" & EmpCnumber
            emp_birthdate.Value = EmpBdate
            Button1.Text = EmpStatus

        End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        Dim selectedDate As Date = emp_birthdate.Value
        Dim Emp_ID As String ' Change data type to String for phone numbers

        Emp_ID = emp_datagridview.CurrentRow.Cells("Emp_ID").Value.ToString() ' Assuming Emp_ID is a String

        Dim Emp_name As String = txt_emp_name.Text
        Dim Emp_address As String = txt_emp_address.Text
        Dim Emp_cnumber As String = txt_emp_cnumber.Text.Trim() ' Remove leading/trailing whitespace

        ' Remove "+63" prefix if present
        If Emp_cnumber.StartsWith("+63") Then
            Emp_cnumber = Emp_cnumber.Substring(3) ' Remove "+63" prefix
        End If

        Dim Emp_bdate As String = selectedDate.ToString("yyyy-MM-dd")
        Dim Emp_status As String = selectedStatus

        If String.IsNullOrEmpty(Emp_name) OrElse String.IsNullOrEmpty(Emp_address) OrElse Emp_cnumber.Length <> 10 OrElse Not Emp_cnumber.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Please fill the information properly.")
        Else
            If EmployeeExist(Emp_name, Emp_address, Emp_cnumber) Then
                MessageBox.Show("Employee with the same name, address, and contact number already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Valid phone number format
                    If openDB() Then
                        Dim query As String = "UPDATE employee SET Emp_name = @Emp_name, Emp_address = @Emp_address, Emp_cnumber = @Emp_cnumber, Emp_bdate = @Emp_bdate, Emp_status = @Emp_status WHERE Emp_ID = @Emp_ID"
                        Dim cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("@Emp_ID", Emp_ID)
                        cmd.Parameters.AddWithValue("@Emp_name", Emp_name.ToUpper())
                        cmd.Parameters.AddWithValue("@Emp_address", Emp_address.ToUpper())
                        cmd.Parameters.AddWithValue("@Emp_cnumber", Emp_cnumber)
                        cmd.Parameters.AddWithValue("@Emp_bdate", Emp_bdate)
                        cmd.Parameters.AddWithValue("@Emp_status", Emp_status)
                        Try
                            cmd.ExecuteNonQuery()

                            emp_datagridview.Rows.Clear()
                            DataLoadEmployee()

                            txt_emp_name.Clear()
                            txt_emp_address.Clear()
                            txt_emp_cnumber.Text = "63"
                            emp_birthdate.Value = DateTime.Today
                            Button1.Text = ">>"



                            MessageBox.Show("Employee successfully updated!")
                        Catch ex As Exception
                            MessageBox.Show($"Error: {ex.Message}")
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("The database failed to connect!")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim searchValue As String = txt_search.Text.Trim().ToLower()

        For Each row As DataGridViewRow In emp_datagridview.Rows
            If Not row.IsNewRow Then
                Dim EmpName As String = row.Cells("Emp_name").Value.ToString().ToLower()
                If searchValue = "" OrElse EmpName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next



    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If emp_datagridview.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = emp_datagridview.SelectedRows(0)
            Dim EmpId As Integer = Convert.ToInt32(selectedRow.Cells("Emp_ID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If openDB() Then
                    Dim query As String = "DELETE FROM employee WHERE Emp_ID = @EmpId"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@EmpId", EmpId)
                    Try
                        cmd.ExecuteNonQuery()
                        emp_datagridview.Rows.Clear()
                        DataLoadEmployee()

                        txt_emp_name.Clear()
                        txt_emp_address.Clear()
                        txt_emp_cnumber.Text = "63"
                        emp_birthdate.Value = DateTime.Today
                        Button1.Text = ">>"


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        closeDB()

                    End Try
                Else
                    MessageBox.Show("Failed to connect to database")

                End If
            End If



        End If
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        If emp_datagridview.SelectedRows.Count > 0 Then
            emp_datagridview.ClearSelection()
        End If

        txt_emp_name.Clear()
        txt_emp_address.Clear()
        txt_emp_cnumber.Text = "+63"
        emp_birthdate.Value = DateTime.Today
        Button1.Text = ">>"
    End Sub

    Private Sub GeneRate_Click(sender As Object, e As EventArgs) Handles GeneRate.Click
        Try
            If openDB() Then
                Dim query As String = "SELECT * FROM employee"
                Dim adapter As New MySqlDataAdapter(query, Conn)
                Dim ds As New DataSet()

                adapter.Fill(ds, "employee")

                ' Export to Excel
                Dim excelApp As New Excel.Application()
                Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
                Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Sheet1"), Excel.Worksheet)

                ' Add column headers
                For i As Integer = 0 To ds.Tables("employee").Columns.Count - 1
                    excelWorksheet.Cells(1, i + 1) = ds.Tables("employee").Columns(i).ColumnName
                Next

                ' Add data
                For rowIndex As Integer = 0 To ds.Tables("employee").Rows.Count - 1
                    For colIndex As Integer = 0 To ds.Tables("employee").Columns.Count - 1
                        excelWorksheet.Cells(rowIndex + 2, colIndex + 1) = ds.Tables("employee").Rows(rowIndex)(colIndex).ToString()
                    Next
                Next

                ' Auto fit columns
                excelWorksheet.Columns.AutoFit()

                ' Save Excel file
                Dim excelFilePath As String = "C:\Users\XtiaN\Documents\RBRS GADGET CENTER\InventoryMate_RBRS\REPORTS\EmployeeReport.xlsx"
                excelWorkbook.SaveAs(excelFilePath)
                excelWorkbook.Close()
                excelApp.Quit()

                ReleaseComObject(excelWorksheet)
                ReleaseComObject(excelWorkbook)
                ReleaseComObject(excelApp)

                ' Open Excel file after saving
                ShellExecute(IntPtr.Zero, "open", excelFilePath, Nothing, Nothing, 1)

                MessageBox.Show("Data exported successfully to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As IntPtr, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As IntPtr

    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub txt_emp_cnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_emp_cnumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class