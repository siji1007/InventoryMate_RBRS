
Imports MySql.Data.MySqlClient

Public Class SUPPLIER
    Private Sub Lbl_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_supplier.TextAlign = ContentAlignment.MiddleCenter
        Lbl_supplier.AutoSize = False
        Lbl_supplier.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_supplier.Width) \ 2
        Lbl_supplier.Location = New Point(centerX, Lbl_supplier.Location.Y)

        LoadDataSup()

    End Sub


    Private Sub LoadDataSup()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM supplier", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim formattedCnumber As String = "+63" & dr.Item("Supp_cnumber").ToString()
                        Dim rowIndex As Integer = sup_datagridview.Rows.Add(dr.Item("Supp_ID"), dr.Item("Supp_name"), dr.Item("Supp_store"), dr.Item("Supp_address"), dr.Item("Supp_email"), formattedCnumber)
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub sup_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles sup_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim SelectedRow As DataGridViewRow = sup_datagridview.Rows(e.RowIndex)
            Dim supId As String = SelectedRow.Cells("Supp_ID").Value.ToString()
            Dim supName As String = SelectedRow.Cells("Supp_name").Value.ToString()
            Dim supStore As String = SelectedRow.Cells("Supp_store").Value.ToString()
            Dim supAddress As String = SelectedRow.Cells("Supp_address").Value.ToString()
            Dim supEmail As String = SelectedRow.Cells("Supp_email").Value.ToString()
            Dim supContact As String = SelectedRow.Cells("Supp_cnumber").Value.ToString()

            For Each row_sup As DataGridViewRow In sup_datagridview.Rows
                If row_sup.Index = e.RowIndex Then
                    row_sup.Selected = True
                Else
                    row_sup.Selected = False
                End If
            Next

            txt_sup_name.Text = supName
            txt_store_name.Text = supStore
            txt_sup_address.Text = supAddress
            txt_sup_email.Text = supEmail
            txt_sup_cnumber.Text = supContact ' Assuming supContact already has the country code
        End If
    End Sub


    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        Dim S_name As String = txt_sup_name.Text.Trim()
        Dim S_store As String = txt_store_name.Text.Trim()
        Dim S_address As String = txt_sup_address.Text.Trim()
        Dim S_email As String = txt_sup_email.Text.Trim()

        Dim S_contact As String = txt_sup_cnumber.Text.Trim()
        If S_contact.StartsWith("+63") Then
            S_contact = S_contact.Substring(3) ' Remove "+63" prefix
        End If

        ' Validate contact number format (optional)
        Dim isValidContact As Boolean = S_contact.All(AddressOf Char.IsDigit) AndAlso S_contact.Length = 10

        If String.IsNullOrWhiteSpace(S_name) OrElse IsNumeric(S_name) OrElse String.IsNullOrWhiteSpace(S_store) OrElse String.IsNullOrWhiteSpace(S_address) OrElse Not IsValidEmail(S_email) Then
            MessageBox.Show("Please fill all information properly.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Not isValidContact Then
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If SupplierExist(S_name, S_store, S_address, S_email, S_contact) Then

                    MessageBox.Show("Supplier with the same name, store, email ,and contact number already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        If openDB() Then
                            Dim query As String = "INSERT INTO supplier VALUES(NULL, @S_name, @S_store, @S_address, @S_email, @S_contact)"
                            Dim cmd As New MySqlCommand(query, Conn)
                            cmd.Parameters.AddWithValue("@S_name", S_name.ToUpper())
                            cmd.Parameters.AddWithValue("@S_store", S_store.ToUpper())
                            cmd.Parameters.AddWithValue("@S_address", S_address.ToUpper())
                            cmd.Parameters.AddWithValue("@S_email", S_email.ToUpper())
                            cmd.Parameters.AddWithValue("@S_contact", S_contact)

                            Try
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                sup_datagridview.Rows.Clear()
                                LoadDataSup()
                                txt_sup_name.Clear()
                                txt_store_name.Clear()
                                txt_sup_address.Clear()
                                txt_sup_email.Clear()
                                txt_sup_cnumber.Clear()
                            Catch ex As Exception
                                MessageBox.Show("An error occurred while adding the supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Finally
                                closeDB()
                            End Try
                        Else
                            MessageBox.Show("Failed to connect to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                End If


            End If

        End If

    End Sub

    Private Function IsValidEmail(ByVal Email As String) As Boolean
        ' Custom email validation function that accepts variations in case for the domain part
        Dim parts() As String = Email.Split("@"c)
        If parts.Length = 2 AndAlso parts(1).Equals("gmail.com", StringComparison.OrdinalIgnoreCase) Then
            Return True
        End If
        Return False
    End Function

    Private Function SupplierExist(ByVal name As String, ByVal store As String, ByVal address As String, ByVal email As String, ByVal contact As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM supplier WHERE Supp_name = @name AND Supp_store = @store AND Supp_address = @address AND Supp_email = @email AND Supp_cnumber= @contact"

        Try
            If openDB() Then
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@name", name.ToUpper())
                    cmd.Parameters.AddWithValue("@store", store.ToUpper())
                    cmd.Parameters.AddWithValue("@address", address.ToUpper())
                    cmd.Parameters.AddWithValue("@email", email.ToUpper())
                    cmd.Parameters.AddWithValue("@contact", contact)


                    Dim supplierCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return supplierCount > 0
                End Using
            Else
                MessageBox.Show("Failed to connect to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking supplier existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeDB()
        End Try

        ' Default return value if an exception occurs or connection fails
        Return True
    End Function







    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        Dim S_id As Integer
        If Integer.TryParse(sup_datagridview.CurrentRow.Cells("Supp_ID").Value.ToString(), S_id) Then
            Dim S_name As String = txt_sup_name.Text
            Dim S_store As String = txt_store_name.Text
            Dim S_address As String = txt_sup_address.Text
            Dim S_email As String = txt_sup_email.Text
            Dim S_contact As String = txt_sup_cnumber.Text.Trim()

            ' Check if the contact number starts with "+63" and remove it
            If S_contact.StartsWith("+63") AndAlso S_contact.Length > 3 Then
                S_contact = S_contact.Substring(3) ' Remove "+63"
            End If




            Dim isValidContact As Boolean = S_contact.All(AddressOf Char.IsDigit) AndAlso S_contact.Length = 10

            If String.IsNullOrWhiteSpace(S_name) OrElse IsNumeric(S_name) OrElse String.IsNullOrWhiteSpace(S_store) OrElse String.IsNullOrWhiteSpace(S_address) OrElse Not IsValidEmail(S_email) Then
                MessageBox.Show("Please fill all information properly.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Not isValidContact Then
                    MessageBox.Show("Please enter a valid 10-digit contact number.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If SupplierExist(S_name, S_store, S_address, S_email, S_contact) Then

                        MessageBox.Show("Supplier with the same name, store, email ,and contact number already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            If openDB() Then
                                Dim query As String = "UPDATE supplier SET Supp_name = @S_name, Supp_store = @S_store, Supp_address = @S_address, Supp_email = @S_email, Supp_cnumber = @S_contact WHERE Supp_ID = @S_id"
                                Dim cmd As New MySqlCommand(query, Conn)
                                cmd.Parameters.AddWithValue("@S_id", S_id)
                                cmd.Parameters.AddWithValue("@S_name", S_name.ToUpper())
                                cmd.Parameters.AddWithValue("@S_store", S_store.ToUpper())
                                cmd.Parameters.AddWithValue("@S_address", S_address.ToUpper())
                                cmd.Parameters.AddWithValue("@S_email", S_email.ToUpper())
                                cmd.Parameters.AddWithValue("@S_contact", S_contact)

                                Try
                                    cmd.ExecuteNonQuery()
                                    MessageBox.Show("Supplier updated successfully.")
                                    sup_datagridview.Rows.Clear()
                                    LoadDataSup()

                                    txt_sup_name.Clear()
                                    txt_store_name.Clear()
                                    txt_sup_address.Clear()
                                    txt_sup_email.Clear()
                                    txt_sup_cnumber.Clear()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                Finally
                                    closeDB()
                                End Try
                            Else
                                MessageBox.Show("Failed to connect to the database.")
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub




    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If sup_datagridview.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = sup_datagridview.SelectedRows(0)
            Dim S_id As Integer = Convert.ToInt32(selectedRow.Cells("Supp_ID").Value)


            If openDB() Then
                Dim query As String = "DELETE FROM supplier WHERE Supp_ID = @S_id"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@S_id", S_id)


                txt_sup_name.Clear()
                txt_store_name.Clear()
                txt_sup_address.Clear()
                txt_sup_email.Clear()
                txt_sup_cnumber.Clear()


                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Supplier deleted successfully")
                    sup_datagridview.Rows.Remove(selectedRow)


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB()

                End Try


            Else
                MessageBox.Show("Failed to connect to database")


            End If

        Else
            MessageBox.Show("Please select a supplier to delete")

        End If

    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        If sup_datagridview.SelectedRows.Count > 0 Then
            sup_datagridview.ClearSelection()
        End If

        txt_sup_name.Clear()
        txt_store_name.Clear()
        txt_sup_address.Clear()
        txt_sup_email.Clear()
        txt_sup_cnumber.Text = "+63"

    End Sub

    Private Sub Search_supplier_TextChanged(sender As Object, e As EventArgs) Handles Search_supplier.TextChanged
        Dim searchValue As String = Search_supplier.Text.Trim().ToLower()
        For Each row As DataGridViewRow In sup_datagridview.Rows
            If Not row.IsNewRow Then
                Dim SupplierName As String = row.Cells("supp_name").Value.ToString().ToLower()
                If searchValue = "" OrElse SupplierName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next


    End Sub



End Class
