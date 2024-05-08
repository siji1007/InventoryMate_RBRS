Imports MySql.Data.MySqlClient

Public Class PRODUCTS
    Private dashboardForm As DASHBOARD

    Private Sub Lbl_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_product.TextAlign = ContentAlignment.MiddleCenter
        Lbl_product.AutoSize = False
        Lbl_product.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_product.Width) \ 2
        Lbl_product.Location = New Point(centerX, Lbl_product.Location.Y)



        LoadDataAndSort()
        LoadWarranty()
        LoadSupplier()


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

            If userPrivilege = "EMPLOYEE" AndAlso userStatus = "ACTIVE" Then
                Btn_delete_prod.Enabled = False
                Btn_update_prod.Enabled = False
            End If
        Else
            MessageBox.Show("The connection of database failed")


        End If
    End Sub


    Private Sub Btn_add_prod_Click(sender As Object, e As EventArgs) Handles Btn_add_prod.Click
        Dim P_name As String = txt_product_name.Text.Trim()
        Dim P_model As String = txt_product_model.Text.Trim()
        Dim P_color As String = txt_product_color.Text.Trim()
        Dim P_stocks As Integer
        Dim P_price As Integer
        Dim W_ID As Integer
        Dim Supp_ID As Integer

        If String.IsNullOrWhiteSpace(P_name) OrElse IsNumeric(P_name) Then
            MessageBox.Show("Please enter a product name.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(P_model) Then
            MessageBox.Show("Please enter a product model.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(txt_stocks.Text.Trim(), P_stocks) Then
            MessageBox.Show("Please enter a valid number for stocks.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(txt_price.Text.Trim(), P_price) Then
            MessageBox.Show("Please enter a valid number for price.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(show_id.Text.Trim(), W_ID) Then
            MessageBox.Show("Please select a valid warranty details", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(Sup_ID.Text.Trim(), Supp_ID) Then
            MessageBox.Show("Please select a valid supplier details", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                If openDB() Then
                    ' Check if the product already exists in the database
                    If ProductExist(P_name, P_model, P_color, P_stocks, P_price, W_ID, Supp_ID) Then
                        MessageBox.Show("Product with the same name, model, color, stocks, and price already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            openDB()

                            Dim query As String = "INSERT INTO products (prod_name, Warranty_ID,sup_ID, prod_model, prod_color, prod_stocks, prod_price)
                                                    VALUES (@P_name, @Warranty_ID,@Supplier_ID, @P_model, @P_color, @P_stocks, @P_price)"

                            Using cmdInsert As New MySqlCommand(query, Conn)
                                cmdInsert.Parameters.AddWithValue("@P_name", P_name.ToUpper())
                                cmdInsert.Parameters.AddWithValue("@Warranty_ID", W_ID) ' Use W_ID as the Warranty_ID value
                                cmdInsert.Parameters.AddWithValue("@Supplier_ID", Supp_ID)
                                cmdInsert.Parameters.AddWithValue("@P_model", P_model.ToUpper())
                                cmdInsert.Parameters.AddWithValue("@P_color", P_color.ToUpper())
                                cmdInsert.Parameters.AddWithValue("@P_stocks", P_stocks)
                                cmdInsert.Parameters.AddWithValue("@P_price", P_price)

                                cmdInsert.ExecuteNonQuery()
                                MessageBox.Show("Product added successfully.")
                                prod_datagridview.Rows.Clear()
                                LoadDataAndSort()

                                ' Clear textboxes after successful insertion
                                txt_product_name.Clear()
                                txt_product_model.Clear()
                                txt_product_color.Clear()
                                txt_stocks.Clear()
                                txt_price.Clear()
                                show_id.Text = "ID"
                                Cb_warranty.SelectedIndex = -1
                                Cb_supplier.SelectedIndex = -1
                                Sup_ID.Text = "ID"

                            End Using
                            closeDB()
                        End If
                    End If
                Else
                    MessageBox.Show("Failed to connect to the database.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding product: " & ex.Message)
            Finally
                closeDB() ' Close the database after the insertion
            End Try
        End If
    End Sub

    Private Function ProductExist(ByVal productName As String, ByVal productModel As String, ByVal productColor As String, ByVal productStocks As Integer, ByVal productPrice As Decimal, ByVal warID As String, ByVal supID As String) As Boolean
        Dim productExistsQuery As String = "SELECT COUNT(*) FROM products WHERE prod_name = @P_name AND prod_model = @P_model AND prod_color = @P_color AND prod_stocks = @P_stocks AND prod_price = @P_price AND Warranty_ID=@WarID AND sup_ID = @SupID"
        Try
            If openDB() Then
                Using cmdCheck As New MySqlCommand(productExistsQuery, Conn)
                    cmdCheck.Parameters.AddWithValue("@P_name", productName)
                    cmdCheck.Parameters.AddWithValue("@P_model", productModel)
                    cmdCheck.Parameters.AddWithValue("@P_color", productColor)
                    cmdCheck.Parameters.AddWithValue("@P_stocks", productStocks)
                    cmdCheck.Parameters.AddWithValue("@P_price", productPrice)
                    cmdCheck.Parameters.AddWithValue("@WarID", warID)
                    cmdCheck.Parameters.AddWithValue("@SupID", supID)

                    Dim productCount As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    Return productCount > 0
                End Using
            Else
                MessageBox.Show("Failed to open database connection.")
                Return False ' Return false if database connection couldn't be opened
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking product existence: " & ex.Message)
            Return False ' Return false in case of an exception
        Finally
            closeDB()
        End Try
    End Function





    Private Sub LoadDataAndSort()
        Try
            If openDB() Then ' Check if database connection is successful
                Dim query As New MySqlCommand("SELECT p.*, w.War_ID AS Warranty_ID FROM products p LEFT JOIN warranty w ON p.Warranty_ID = w.War_ID;", Conn) ' Assuming Conn is your MySqlConnection object from openDB()
                Using dr As MySqlDataReader = query.ExecuteReader
                    Dim dataTable As New DataTable()
                    dataTable.Load(dr) ' Load data into DataTable

                    ' Sort the DataTable based on the "prod_stocks" column in ascending order
                    Dim sortedRows = dataTable.Select("", "prod_stocks ASC")

                    ' Clear the DataGridView before adding sorted rows
                    prod_datagridview.Rows.Clear()

                    ' Add sorted rows to the DataGridView
                    For Each row In sortedRows
                        Dim price As Double = Convert.ToDouble(row("prod_price"))
                        Dim formattedPrice As String = FormatPrice(price) ' Format the price with peso sign and commas

                        Dim rowIndex As Integer = prod_datagridview.Rows.Add(row("prod_id"), row("Warranty_ID"), row("prod_name"), row("prod_model"), row("prod_color"), row("prod_stocks"), formattedPrice)

                        ' Check and set row color based on prod_stocks value
                        Dim stocks As Integer = Convert.ToInt32(row("prod_stocks"))
                        If stocks = 0 Then
                            prod_datagridview.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
                        End If
                    Next
                End Using
            Else
                MessageBox.Show("Failed to connect to the database.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Function FormatPrice(price As Double) As String
        ' Format the price with peso sign and commas
        Return "₱" & price.ToString("N0")
    End Function




    Private Sub prod_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prod_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Check if a valid cell is clicked
            Dim selectedRow As DataGridViewRow = prod_datagridview.Rows(e.RowIndex)

            ' Access the data in the selected row as needed
            Dim prodId As String = selectedRow.Cells("prod_id").Value.ToString()
            Dim WarId As String = selectedRow.Cells("war_id").Value.ToString()
            Dim prodName As String = selectedRow.Cells("prod_name_dt").Value.ToString()
            Dim prodModel As String = selectedRow.Cells("prod_model_dt").Value.ToString()
            Dim prodColor As String = selectedRow.Cells("prod_color_dt").Value.ToString()
            Dim prodStocks As Integer = Convert.ToInt32(selectedRow.Cells("prod_stocks_dt").Value)
            Dim prodPriceFormatted As String = selectedRow.Cells("prod_price_dt").Value.ToString()

            For Each row As DataGridViewRow In prod_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next

            ' Extract the numeric part of the formatted price (remove peso sign and commas)
            Dim prodPriceNumeric As Decimal
            If Decimal.TryParse(prodPriceFormatted.Replace("₱", "").Replace(",", ""), prodPriceNumeric) Then
                ' Update TextBoxes with data
                txt_product_name.Text = prodName
                show_id.Text = WarId
                txt_product_model.Text = prodModel
                txt_product_color.Text = prodColor
                txt_stocks.Text = prodStocks.ToString()
                txt_price.Text = prodPriceNumeric.ToString() ' Display the numeric price in the TextBox

                ' Fetch sup_ID from the database based on prodId
                Dim supId As String = GetSupplierId(prodId) ' Replace GetSupplierId with your database query function
                Sup_ID.Text = supId ' Display the supplier ID in Sup_ID.Text
            Else
                ' Handle invalid formatted price
                MessageBox.Show("Invalid price format.")
            End If
        End If
    End Sub

    Private Function GetSupplierId(prodId As String) As String
        Dim supId As String = "" ' Initialize supId variable to store the supplier ID

        ' Open database connection
        If openDB() Then
            ' Define your SQL query to fetch sup_ID based on prodId
            Dim query As String = "SELECT sup_ID FROM products WHERE prod_id = @ProdId"

            ' Create a SqlCommand object with the query and connection
            Using cmd As New MySqlCommand(query, Conn)
                ' Add parameter for ProdId
                cmd.Parameters.AddWithValue("@ProdId", prodId)

                ' Execute the query and fetch sup_ID
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' If a record is found, get the sup_ID value
                    supId = reader("sup_ID").ToString()
                End If
                reader.Close()
            End Using

            ' Close the database connection
            closeDB()
        End If

        ' Return the supId value
        Return supId
    End Function


    Private Sub Btn_update_prod_Click(sender As Object, e As EventArgs) Handles Btn_update_prod.Click
        Dim P_id As Integer ' Assuming you have a product ID to identify the record to update
        If Integer.TryParse(prod_datagridview.CurrentRow.Cells("prod_id").Value.ToString(), P_id) Then
            Dim P_name As String = txt_product_name.Text
            Dim WarId As String = show_id.Text

            Dim SupplierID As String = Sup_ID.Text
            Dim P_model As String = txt_product_model.Text
            Dim P_color As String = txt_product_color.Text
            Dim P_stocks As Integer
            Dim P_price As Integer

            If String.IsNullOrWhiteSpace(P_name) OrElse IsNumeric(P_name) OrElse String.IsNullOrWhiteSpace(P_model) OrElse Not Integer.TryParse(txt_stocks.Text, P_stocks) OrElse Not Integer.TryParse(txt_price.Text, P_price) Then
                MessageBox.Show("Please fill all information properly.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                If ProductExist(P_name, P_model, P_color, P_stocks, P_price, WarId, SupplierID) Then
                    MessageBox.Show("Product with the same name, model, color, stocks, and price already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        If openDB() Then

                            Dim query As String = "UPDATE products SET prod_name = @P_name,Warranty_ID = @WarID,sup_ID = @SupplierID ,prod_model = @P_model,
                                                    prod_color = @P_color, prod_stocks = @P_stocks, prod_price = @P_price WHERE prod_id = @P_id"

                            Dim cmd As New MySqlCommand(query, Conn)
                            cmd.Parameters.AddWithValue("@P_id", P_id)
                            cmd.Parameters.AddWithValue("@WarID", WarId)
                            cmd.Parameters.AddWithValue("@SupplierID", SupplierID)
                            cmd.Parameters.AddWithValue("@P_name", P_name.ToUpper())
                            cmd.Parameters.AddWithValue("@P_model", P_model.ToUpper())
                            cmd.Parameters.AddWithValue("@P_color", P_color.ToUpper())
                            cmd.Parameters.AddWithValue("@P_stocks", P_stocks)
                            cmd.Parameters.AddWithValue("@P_price", P_price)

                            Try
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Product updated successfully.")
                                prod_datagridview.Rows.Clear() ' Clear the DataGridView
                                LoadDataAndSort() ' Reload data into the DataGridView

                                ' Clear textboxes after updating
                                txt_product_name.Clear()
                                show_id.Text = "ID"
                                txt_product_model.Clear()
                                txt_product_color.Clear()
                                txt_stocks.Clear()
                                txt_price.Clear()
                                Sup_ID.Text = "ID"
                                Cb_supplier.SelectedIndex = -1




                            Catch ex As Exception
                                MessageBox.Show("Error updating product: " & ex.Message)
                            Finally
                                closeDB() ' Close the database after updating
                            End Try
                        Else
                            MessageBox.Show("Failed to connect to the database.")
                        End If
                    End If

                End If

            End If
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub


    Private Sub Btn_delete_prod_Click(sender As Object, e As EventArgs) Handles Btn_delete_prod.Click
        If prod_datagridview.SelectedRows.Count > 0 Then ' Check if any row is selected
            Dim selectedRow As DataGridViewRow = prod_datagridview.SelectedRows(0)
            Dim prodId As Integer = Convert.ToInt32(selectedRow.Cells("prod_id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If openDB() Then
                    Dim query As String = "DELETE FROM products WHERE prod_id = @prodId"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@prodId", prodId)

                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Product deleted successfully.")
                        prod_datagridview.Rows.Remove(selectedRow) ' Remove the selected row from the DataGridView

                        ' Clear textboxes after deletion
                        txt_product_name.Clear()
                        show_id.Text = "ID"
                        txt_product_model.Clear()
                        txt_product_color.Clear()
                        txt_stocks.Clear()
                        txt_price.Clear()
                        Sup_ID.Text = "ID"
                        Cb_supplier.SelectedIndex = -1

                    Catch ex As Exception
                        MessageBox.Show("Error deleting product: " & ex.Message)
                    Finally
                        closeDB() ' Close the database after deletion
                    End Try
                Else
                    MessageBox.Show("Failed to connect to the database.")
                End If

            End If

        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

    Private Sub Btn_clear_prod_Click(sender As Object, e As EventArgs) Handles Btn_clear_prod.Click
        ' Clear the selected row in the DataGridView
        If prod_datagridview.SelectedRows.Count > 0 Then
            prod_datagridview.ClearSelection()
        End If

        ' Clear all textboxes
        txt_product_name.Clear()
        show_id.Text = "ID"
        txt_product_model.Clear()
        txt_product_color.Clear()
        txt_stocks.Clear()
        txt_price.Clear()
        Sup_ID.Text = "ID"
        Cb_supplier.SelectedIndex = -1


    End Sub

    Private Sub prod_search_TextChanged(sender As Object, e As EventArgs) Handles prod_search.TextChanged
        Dim searchValue As String = prod_search.Text.Trim().ToLower()
        For Each row As DataGridViewRow In prod_datagridview.Rows
            ' Check if the row is not a new row and then perform search filtering
            If Not row.IsNewRow Then
                Dim productName As String = row.Cells("prod_name_dt").Value.ToString().ToLower()
                If searchValue = "" OrElse productName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next
    End Sub



    Private Sub LoadWarranty()
        If openDB() Then
            Dim query_warranty = "SELECT CONCAT(War_ID,'-',War_Duration, '-', War_DurationUnit,
                                '-', War_Type, '-', War_Coverage) AS warranty_info FROM warranty"
            Using cmd As New MySqlCommand(query_warranty, Conn)
                Try
                    Using reader = cmd.ExecuteReader
                        If reader.HasRows Then
                            While reader.Read
                                Cb_warranty.Items.Add(reader("warranty_info").ToString)
                            End While
                        End If
                        reader.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message & "WARRANTY LOAD")
                Finally
                    closeDB()

                End Try

            End Using
        Else
            MessageBox.Show("The Database failed to connect.")
        End If
    End Sub







    Private Sub Cb_warranty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_warranty.SelectedIndexChanged
        If Cb_warranty.SelectedIndex <> -1 Then
            Try
                If openDB() Then
                    Dim selectedWarranty As String = Cb_warranty.SelectedItem.ToString()
                    Dim warId As String = selectedWarranty.Split("-"c)(0).Trim() ' Extracting the ID from the selected item

                    Dim queryWarranty As String = "SELECT War_Duration, War_DurationUnit, War_Type, War_Coverage FROM warranty WHERE War_ID = @WarID"

                    Using cmd As New MySqlCommand(queryWarranty, Conn)
                        cmd.Parameters.AddWithValue("@WarID", warId)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            Dim duration As Integer = reader.GetInt32("War_Duration")
                            Dim durationUnit As String = reader.GetString("War_DurationUnit")
                            Dim warType As String = reader.GetString("War_Type")
                            Dim coverage As String = reader.GetString("War_Coverage")


                            ' Store the War_ID in show_id.Text
                            show_id.Text = warId
                        Else
                            MessageBox.Show("Warranty details not found.")
                        End If

                        reader.Close()
                    End Using

                    closeDB()
                Else
                    MessageBox.Show("THE DATABASE IS NOT CONNECTED")
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching warranty details: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Cb_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_supplier.SelectedIndexChanged
        ' Check if an item is selected in the ComboBox
        If Cb_supplier.SelectedIndex <> -1 Then
            ' Get the selected supplier name from the ComboBox
            Dim selectedSupplierName As String = Cb_supplier.SelectedItem.ToString()

            ' Check if the database connection is open
            If openDB() Then
                ' Define the SQL query to fetch specific details of the selected supplier
                Dim query_supplier As String = "SELECT Supp_ID, Supp_store, Supp_address, Supp_email, Supp_cnumber FROM supplier WHERE Supp_name = @supplierName"

                Using command As New MySqlCommand(query_supplier, Conn)
                    ' Add parameter for supplier name to the query
                    command.Parameters.AddWithValue("@supplierName", selectedSupplierName)

                    Try
                        ' Execute the SQL query and get the results
                        Dim reader As MySqlDataReader = command.ExecuteReader()

                        ' Check if data is retrieved
                        If reader.Read() Then
                            ' Update the TextBoxes with the retrieved supplier information
                            Sup_ID.Text = reader("Supp_ID").ToString()

                        Else
                            MessageBox.Show("Supplier information not found.")
                        End If

                        reader.Close() ' Close the reader after use
                    Catch ex As Exception
                        MessageBox.Show("Error retrieving supplier information: " & ex.Message)
                    End Try
                End Using

                ' Close the database connection after use
                closeDB()
            Else
                MessageBox.Show("Database connection failed.")
            End If
        End If
    End Sub


    Private Sub LoadSupplier()
        Cb_supplier.Items.Clear()

        ' Check if the database connection is open
        If openDB() Then
            Dim query_supplier As String = "SELECT Supp_name FROM supplier"

            Using command As New MySqlCommand(query_supplier, Conn)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the results and add supplier information to the ComboBox
                While reader.Read()
                    Dim supplierName As String = reader("Supp_name").ToString()


                    ' Format the supplier information for display in the ComboBox
                    Dim displayText As String = $"{supplierName}"
                    Cb_supplier.Items.Add(displayText)
                End While

                reader.Close()
            End Using

            closeDB() ' Close the database connection after use
        Else
            MessageBox.Show("Database connection failed.")
        End If
    End Sub

    Private Sub txt_stocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stocks.KeyPress
        ' Check if the pressed key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a digit or control key, handle the event to prevent the character from being entered
            e.Handled = True
        End If
    End Sub
    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        ' Check if the pressed key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a digit or control key, handle the event to prevent the character from being entered
            e.Handled = True
        End If
    End Sub

End Class
