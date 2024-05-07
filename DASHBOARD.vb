Imports System.Transactions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC

Public Class DASHBOARD




    Private isHomeFormOpen As Boolean = False
    Private isProductFormOpen As Boolean = False
    Private isWarrantyFormOpen As Boolean = False
    Private isCustomerFormOpen As Boolean = False
    Private isSupplierFormOpen As Boolean = False
    Private isEmployeeFormOpen As Boolean = False
    Private isTransactionFromOpen As Boolean = False
    Private isUserFromOpen As Boolean = False

    Private Function ReadFileValueAndNotify() As Integer
        Dim filePath As String = "C:\Users\XtiaN\Documents\RBRS GADGET CENTER\InventoryMate_RBRS\transac\transaction_status.txt" ' Replace with the actual file path
        Dim fileValue As Integer = 0

        Try
            ' Read the value from the text file
            If System.IO.File.Exists(filePath) Then
                Using reader As New System.IO.StreamReader(filePath)
                    Dim fileContent As String = reader.ReadLine()
                    If Integer.TryParse(fileContent, fileValue) Then
                        ' Successfully parsed the value from the file and it's greater than 0

                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading file: " & ex.Message)
        End Try

        ' Return the file value
        Return fileValue
    End Function

    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_name_Load()

        Try
            If openDB() Then
                ' Assuming Product, Warranty, Customer, Supplier, and Employee are the names of your buttons

                ' Check user privilege and status
                Dim query As New MySqlCommand("SELECT Privilege, Status FROM Users WHERE Status = 'ACTIVE';", Conn)


                Dim userPrivilege = ""
                Dim userStatus = ""

                Using reader = query.ExecuteReader
                    If reader.Read Then
                        userPrivilege = reader.GetString("Privilege")
                        userStatus = reader.GetString("Status")
                    End If
                End Using

                ' Hide buttons based on user privilege and status
                If userPrivilege = "ADMIN" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on admin privilege
                    Btn_home.Visible = True
                    Btn_product.Visible = True
                    Btn_warranty.Visible = True
                    Btn_customer.Visible = True
                    Btn_supplier.Visible = True
                    Btn_employee.Visible = True
                    Btn_transaction.Visible = True




                ElseIf userPrivilege = "EMPLOYEE" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on employee privilege
                    Btn_home.Visible = True
                    Btn_product.Visible = True
                    Btn_warranty.Visible = False
                    Btn_customer.Visible = False
                    Btn_supplier.Visible = False
                    Btn_employee.Visible = False
                    Btn_transaction.Visible = True


                    Btn_transaction.Location = New Point(0, 358)








                ElseIf userPrivilege = "OWNER" AndAlso userStatus = "ACTIVE" Then
                    Btn_home.Visible = True
                    Btn_product.Visible = True
                    Btn_warranty.Visible = False
                    Btn_customer.Visible = False
                    Btn_supplier.Visible = False
                    Btn_employee.Visible = False
                    Btn_transaction.Visible = True
                    Btn_transaction.Location = New Point(0, 358)

                Else
                    ' Hide all buttons if user privilege or status doesn't match
                    Btn_home.Visible = True
                    Btn_product.Visible = True
                    Btn_warranty.Visible = False
                    Btn_customer.Visible = False
                    Btn_supplier.Visible = False
                    Btn_employee.Visible = False
                    Btn_transaction.Visible = True
                End If

                Dim HomeForm As New HOME()
                HomeForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(HomeForm)
                HomeForm.BringToFront()
                HomeForm.Show()



            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB()
        End Try

    End Sub



    Private Sub Btn_home_Click(sender As Object, e As EventArgs) Handles Btn_home.Click


        If isHomeFormOpen = True Then
            MessageBox.Show("The HOME form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim fileValue As Integer = ReadFileValueAndNotify()

            ' Check if the file value is greater than zero
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                ' Set the LOGIN UserControl to fill the main_panel panel

                Dim HomeForm As New HOME()
                HomeForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(HomeForm)
                HomeForm.BringToFront()
                HomeForm.Show()



                ' Update form status
                isHomeFormOpen = True
                isProductFormOpen = False
                isWarrantyFormOpen = False
                isCustomerFormOpen = False
                isSupplierFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If
        End If

    End Sub

    Private Sub Btn_product_Click(sender As Object, e As EventArgs) Handles Btn_product.Click
        If isProductFormOpen Then
            MessageBox.Show("The PRODUCT form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim fileValue As Integer = ReadFileValueAndNotify()

            ' Check if the file value is greater than zero
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                Dim productForm As New PRODUCTS()
                productForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(productForm)
                productForm.BringToFront()
                productForm.Show()

                ' Update form status
                isHomeFormOpen = False
                isProductFormOpen = True
                isWarrantyFormOpen = False
                isCustomerFormOpen = False
                isSupplierFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If
        End If
    End Sub

    Friend Function Boolean_panel() As Object
        isProductFormOpen = False
        Return True
    End Function


    Private Sub txt_name_Load()
        ' Check if the database connection is successful
        If openDB() Then
            Dim query As String = "SELECT e.Emp_name, u.Privilege FROM users u INNER JOIN employee e ON u.Employee_ID = e.Emp_ID WHERE u.Status = 'ACTIVE'"
            Using cmd As New MySqlCommand(query, Conn)
                Try
                    ' Execute the query and open a data reader
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Read the data from the reader and display it in txt_name
                            Dim employeeName As String = reader("Emp_name").ToString()
                            Dim userPrivilege As String = reader("Privilege").ToString()
                            txt_name.Text = $"    |{userPrivilege}| {employeeName}"
                        Else
                            MessageBox.Show("No active employee found.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error executing query: " & ex.Message)
                End Try
            End Using
            ' Close the database connection after the operation is complete
            closeDB()
        Else
            MessageBox.Show("Failed to open database connection.")
        End If
    End Sub




    Private Sub Btn_warranty_Click(sender As Object, e As EventArgs) Handles Btn_warranty.Click

        If isWarrantyFormOpen Then
            MessageBox.Show("The WARRANTY form Is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Dim fileValue As Integer = ReadFileValueAndNotify()
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                ' Proceed with opening the PRODUCT form
                Dim warrantyForm As New WARRANTY()
                warrantyForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(warrantyForm)
                warrantyForm.BringToFront()
                warrantyForm.Show()

                ' Update form status
                isHomeFormOpen = False
                isWarrantyFormOpen = True
                isCustomerFormOpen = False
                isProductFormOpen = False
                isEmployeeFormOpen = False
                isSupplierFormOpen = False
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If

        End If
    End Sub


    Private Sub Btn_customer_Click(sender As Object, e As EventArgs) Handles Btn_customer.Click
        If isCustomerFormOpen Then
            MessageBox.Show("The Customer form Is already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim FileValue As Integer = ReadFileValueAndNotify()

            If FileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                Dim customerForm As New CUSTOMER()
                customerForm.Dock = DockStyle.Fill
                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(customerForm)
                customerForm.BringToFront()
                customerForm.Show()

                isHomeFormOpen = False
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = True
                isEmployeeFormOpen = False
                isSupplierFormOpen = False
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If
        End If
    End Sub

    Private Sub Btn_supplier_Click(sender As Object, e As EventArgs) Handles Btn_supplier.Click
        If isSupplierFormOpen Then
            MessageBox.Show("The Supplier form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim fileValue = ReadFileValueAndNotify()

            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                Dim supplierForm As New SUPPLIER()
                supplierForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(supplierForm)
                supplierForm.BringToFront()
                supplierForm.Show()


                isHomeFormOpen = False
                isSupplierFormOpen = True
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If
        End If
    End Sub

    Private Sub Btn_employee_Click(sender As Object, e As EventArgs) Handles Btn_employee.Click

        If isEmployeeFormOpen Then
            MessageBox.Show("The Employee form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim FileValue As Integer = ReadFileValueAndNotify()

            If FileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim employeeForm As New EMPLOYEE()
                employeeForm.Dock = DockStyle.Fill

                ' Add PRODUCT form to Panel_Contents and show it
                Panel_Contents.Controls.Add(employeeForm)
                employeeForm.BringToFront()
                employeeForm.Show()

                isHomeFormOpen = False
                isSupplierFormOpen = False
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = False
                isEmployeeFormOpen = True
                isTransactionFromOpen = False
                isUserFromOpen = False
            End If


        End If

    End Sub

    Friend Function Product() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Btn_transaction_Click(sender As Object, e As EventArgs) Handles Btn_transaction.Click
        If isTransactionFromOpen Then
            MessageBox.Show("The Transaction form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim TRANSForm As New TRANSACTION()
            TRANSForm.Dock = DockStyle.Fill

            ' Add PRODUCT form to Panel_Contents and show it
            Panel_Contents.Controls.Add(TRANSForm)
            TRANSForm.BringToFront()
            TRANSForm.Show()


            isHomeFormOpen = False
            isSupplierFormOpen = False
            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = False
            isEmployeeFormOpen = False
            isTransactionFromOpen = True
            isUserFromOpen = False


        End If


    End Sub
    Private Sub ShowUser_Click(sender As Object, e As EventArgs) Handles ShowUser.Click
        If isUserFromOpen Then
            MessageBox.Show("The USERS form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim isUserFrom As New USERS()
            isUserFrom.Dock = DockStyle.Fill

            ' Add PRODUCT form to Panel_Contents and show it
            Panel_Contents.Controls.Add(isUserFrom)
            isUserFrom.BringToFront()
            isUserFrom.Show()


            isHomeFormOpen = False
            isSupplierFormOpen = False
            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = False
            isEmployeeFormOpen = False
            isTransactionFromOpen = False
            isUserFromOpen = True
        End If


    End Sub




    Private Sub Btn_logout_Click(sender As Object, e As EventArgs) Handles Btn_logout.Click
        ' Display a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Get the reference to the MainForm
        Dim mainForm As MAIN_FORM = TryCast(Me.ParentForm, MAIN_FORM)

        ' If user confirms logout
        If result = DialogResult.Yes Then
            Try
                If openDB() Then
                    ' Update user status to OFFLINE
                    Dim updateQuery As New MySqlCommand("UPDATE Users SET Status='OFFLINE' WHERE Status= 'ACTIVE';", Conn)
                    updateQuery.ExecuteNonQuery()
                Else
                    MessageBox.Show("Failed to connect to the database")
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating user status: " & ex.Message)
            Finally
                closeDB()
            End Try

            ' Hide the UserControl (dashboard)
            Me.Hide()

            ' Show the login form in the MainForm
            mainForm.ShowLogin()
        Else
            ' User clicked No, do nothing or handle accordingly
        End If
    End Sub



End Class
