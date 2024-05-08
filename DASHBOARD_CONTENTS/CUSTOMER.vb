Imports MySql.Data.MySqlClient

Public Class CUSTOMER
    Private Sub Lbl_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_customer.TextAlign = ContentAlignment.MiddleCenter
        Lbl_customer.AutoSize = False
        Lbl_customer.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_customer.Width) \ 2
        Lbl_customer.Location = New Point(centerX, Lbl_customer.Location.Y)


        LoadDataCustomer()


    End Sub


    'LOAD HERE THE DATA FROM DATABASE TO DATAGRIDVIEW 
    Private Sub LoadDataCustomer()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM customer", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim Cust_cnumber As String = dr.Item("Cust_cnumber").ToString()
                        ' Check if the contact number does not start with "+63" and add it
                        If Not Cust_cnumber.StartsWith("+63") Then
                            Cust_cnumber = "+63" & Cust_cnumber ' Add "+63" prefix
                        End If

                        Dim rowIndex As Integer = customer_datagridview.Rows.Add(dr.Item("Cust_ID"), dr.Item("Cust_name"), dr.Item("Cust_address"), dr.Item("Cust_email"), Cust_cnumber)
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub customer_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles customer_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = customer_datagridview.Rows(e.RowIndex)

            'Access the data in the selected row as needed 
            Dim CustID As String = selectedRow.Cells("cl_ID").Value.ToString()
            Dim CustName As String = selectedRow.Cells("CL_NAME").Value.ToString()
            Dim CustAddress As String = selectedRow.Cells("CL_ADDRESS").Value.ToString()
            Dim CustEmail As String = selectedRow.Cells("CL_EMAIL").Value.ToString()
            Dim CustCnumber As String = selectedRow.Cells("CL_CNUMBER").Value.ToString()



            For Each row As DataGridViewRow In customer_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next


            'Display the selected row on its corresponding txtbox 

            txt_cname.Text = CustName
            txt_caddress.Text = CustAddress
            txt_cemail.Text = CustEmail
            txt_cnumber.Text = CustCnumber

        End If
    End Sub



    Private Sub Add_cust_btn_Click(sender As Object, e As EventArgs) Handles Add_cust_btn.Click
        Dim Cust_name As String = txt_cname.Text.Trim()
        Dim Cust_address As String = txt_caddress.Text.Trim()
        Dim Cust_email As String = txt_cemail.Text.Trim()
        Dim Cust_cnumber As String = txt_cnumber.Text.Trim()

        ' Check if the contact number starts with "+63" and remove it
        If Cust_cnumber.StartsWith("+63") AndAlso Cust_cnumber.Length > 3 Then
            Cust_cnumber = Cust_cnumber.Substring(3) ' Remove "+63"
        End If

        If String.IsNullOrWhiteSpace(Cust_name) OrElse
        String.IsNullOrWhiteSpace(Cust_address) OrElse
        String.IsNullOrWhiteSpace(Cust_email) OrElse
        String.IsNullOrWhiteSpace(Cust_cnumber) OrElse
        Cust_cnumber.Length <> 10 OrElse
        Not IsValidEmail(Cust_email) OrElse
        IsNumeric(Cust_name) Then

            MessageBox.Show("Please fill the information properly.")
        Else
            ' Check if the customer already exists in the database
            If CustomerExist(Cust_name, Cust_address, Cust_email) Then
                MessageBox.Show("This customer already exists.", "Duplicate Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    If openDB() Then
                        Dim query As String = "INSERT INTO customer VALUES(NULL, @C_name, @C_address, @C_email, @C_cnumber)"
                        Dim cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("@C_name", Cust_name.ToUpper())
                        cmd.Parameters.AddWithValue("@C_address", Cust_address.ToUpper())
                        cmd.Parameters.AddWithValue("@C_email", Cust_email.ToUpper())
                        cmd.Parameters.AddWithValue("@C_cnumber", Cust_cnumber)

                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Customer added successfully!")
                            customer_datagridview.Rows.Clear()
                            LoadDataCustomer()

                            txt_cname.Clear()
                            txt_caddress.Clear()
                            txt_cemail.Clear()
                            txt_cnumber.Clear()

                        Catch ex As Exception
                            MessageBox.Show("Error adding customer: " & ex.Message)
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("Failed to connect to the database!")
                    End If
                End If
            End If
        End If
    End Sub


    Private Function CustomerExist(ByVal name As String, ByVal address As String, ByVal email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM customer WHERE Cust_name = @name AND Cust_address = @address AND Cust_email = @email "

        Try

            If openDB() Then

                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@email", email)
                    Dim customerCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return customerCount > 0
                End Using

            Else
                MessageBox.Show("Failed to connect to the database.")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try



        Return True ' Default return value if an exception occurs
    End Function


    Private Function IsValidEmail(ByVal email As String) As Boolean
        ' Custom email validation function that accepts variations in case for the domain part
        Dim parts() As String = email.Split("@"c)
        If parts.Length = 2 AndAlso parts(1).Equals("gmail.com", StringComparison.OrdinalIgnoreCase) Then
            Return True
        End If
        Return False
    End Function


    Private Sub Update_cust_btn_Click(sender As Object, e As EventArgs) Handles Update_cust_btn.Click
        ' Check if a customer is selected
        If customer_datagridview.CurrentRow IsNot Nothing Then
            Dim Cust_id As Integer
            If Integer.TryParse(customer_datagridview.CurrentRow.Cells("cl_ID").Value.ToString(), Cust_id) Then
                Dim Cust_name As String = txt_cname.Text
                Dim Cust_address As String = txt_caddress.Text
                Dim Cust_email As String = txt_cemail.Text
                Dim Cust_cnumber As String = txt_cnumber.Text.Trim()

                ' Check if the contact number starts with "+63" and remove it
                If Cust_cnumber.StartsWith("+63") AndAlso Cust_cnumber.Length > 3 Then
                    Cust_cnumber = Cust_cnumber.Substring(3) ' Remove "+63"
                End If

                If String.IsNullOrWhiteSpace(Cust_name) OrElse
            String.IsNullOrWhiteSpace(Cust_address) OrElse
            String.IsNullOrWhiteSpace(Cust_email) OrElse
            String.IsNullOrWhiteSpace(Cust_cnumber) OrElse
            Cust_cnumber.Length <> 10 OrElse
            Not IsValidEmail(Cust_email) OrElse
            IsNumeric(Cust_name) Then
                    MessageBox.Show("Please fill the information properly.")
                Else
                    ' Check if the customer already exists in the database
                    If CustomerExist(Cust_name, Cust_address, Cust_email) Then
                        MessageBox.Show("This customer already exists.", "Duplicate Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            If openDB() Then
                                Dim query As String = "UPDATE customer SET Cust_name = @Cname, Cust_address = @C_address, Cust_email = @C_email, Cust_cnumber = @C_cnumber WHERE Cust_ID = @C_ID"
                                Dim cmd As New MySqlCommand(query, Conn)
                                cmd.Parameters.AddWithValue("@C_ID", Cust_id)
                                cmd.Parameters.AddWithValue("@Cname", Cust_name.ToUpper())
                                cmd.Parameters.AddWithValue("@C_address", Cust_address.ToUpper())
                                cmd.Parameters.AddWithValue("@C_email", Cust_email.ToUpper())
                                cmd.Parameters.AddWithValue("@C_cnumber", Cust_cnumber)

                                Try
                                    cmd.ExecuteNonQuery()
                                    MessageBox.Show("Customer updated successfully!")
                                    customer_datagridview.Rows.Clear()
                                    LoadDataCustomer()

                                    txt_cname.Clear()
                                    txt_caddress.Clear()
                                    txt_cemail.Clear()
                                    txt_cnumber.Clear()
                                Catch ex As Exception
                                    MessageBox.Show("Error updating customer: " & ex.Message)
                                Finally
                                    closeDB()
                                End Try
                            Else
                                MessageBox.Show("Failed to connect to the database")
                            End If
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Invalid customer ID")
            End If
        Else
            MessageBox.Show("Please select a customer to update")
        End If
    End Sub



    Private Sub Delete_cust_btn_Click(sender As Object, e As EventArgs) Handles Delete_cust_btn.Click
        If customer_datagridview.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = customer_datagridview.SelectedRows(0)
            Dim Cust_ID As Integer = Convert.ToInt32(selectedRow.Cells("cl_ID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer, it may affect the transaction belong with this customer data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If openDB() Then
                    ' First, delete related transactions
                    If DeleteRelatedTransactions(Cust_ID) Then
                        ' Related transactions deleted successfully, now delete the customer
                        Dim query As String = "DELETE FROM customer WHERE Cust_ID = @c_id"
                        Dim cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("@c_id", Cust_ID)


                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the data in the DataGridView and clear input fields
                            customer_datagridview.Rows.Clear()
                            LoadDataCustomer()

                            txt_cname.Clear()
                            txt_caddress.Clear()
                            txt_cemail.Clear()
                            txt_cnumber.Clear()
                        Catch ex As Exception
                            MessageBox.Show("Error deleting customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("Error deleting related transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Failed to connect to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a customer to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function DeleteRelatedTransactions(customerID As Integer) As Boolean
        ' Delete related transactions for the given customer ID
        Dim query As String = "DELETE FROM transactions WHERE Customer_ID = @customerID"
        Dim cmd As New MySqlCommand(query, Conn)
        cmd.Parameters.AddWithValue("@customerID", customerID)

        Try
            cmd.ExecuteNonQuery()
            Return True ' Deletion successful
        Catch ex As Exception
            MessageBox.Show("Error deleting related transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Deletion failed
        End Try
    End Function


    Private Sub Clear_cust_btn_Click(sender As Object, e As EventArgs) Handles Clear_cust_btn.Click
        If customer_datagridview.SelectedRows.Count > 0 Then
            customer_datagridview.ClearSelection()
        End If


        txt_cname.Clear()
        txt_caddress.Clear()
        txt_cemail.Clear()
        txt_cnumber.Clear()

    End Sub


    Private Sub Cust_search_TextChanged(sender As Object, e As EventArgs) Handles Cust_search.TextChanged
        Dim searchValue As String = Cust_search.Text.Trim().ToLower()
        For Each row As DataGridViewRow In customer_datagridview.Rows
            If Not row.IsNewRow Then
                Dim CustomerName As String = row.Cells("CL_NAME").Value.ToString().ToLower()
                If searchValue = "" OrElse CustomerName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If



        Next
    End Sub









End Class
