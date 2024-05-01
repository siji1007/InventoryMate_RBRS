Imports MySql.Data.MySqlClient

Public Class PURCHASE

    Public ProductForm As New PRODUCTS()

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click

        ProductForm.Purchase_panel()
        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub Lbl_purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_purchase.TextAlign = ContentAlignment.MiddleCenter
        Lbl_purchase.AutoSize = False
        Lbl_purchase.Width = ClientSize.Width ' Adjust this if needed
        Dim centerX = (ClientSize.Width - Lbl_purchase.Width) \ 2
        Lbl_purchase.Location = New Point(centerX, Lbl_purchase.Location.Y)
        LoadWarranty()
        LoadProducts()
        LoadSupplier()
    End Sub


    Private Sub Cb_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Products.SelectedIndexChanged
        ' Check if a product is selected in the ComboBox
        If Cb_Products.SelectedIndex <> -1 Then
            ' Get the selected product name from the ComboBox
            Dim selectedProduct As String = Cb_Products.SelectedItem.ToString()

            ' Check if the database connection is open
            If openDB() Then
                ' Query to retrieve the stock, price, model, color, and warranty ID of the selected product
                Dim queryStockPriceWarranty As String = "SELECT prod_id, prod_stocks, prod_model, prod_color, prod_price, Warranty_ID, sup_ID FROM products WHERE CONCAT(prod_name, ' - ', prod_model) = @productName"

                Using commandStockPriceWarranty As New MySqlCommand(queryStockPriceWarranty, Conn)
                    commandStockPriceWarranty.Parameters.AddWithValue("@productName", selectedProduct)

                    Try
                        Dim readerStockPriceWarranty As MySqlDataReader = commandStockPriceWarranty.ExecuteReader()

                        If readerStockPriceWarranty.Read() Then
                            Dim prodID As Integer = Convert.ToInt32(readerStockPriceWarranty("prod_id"))
                            Dim availableStock As Integer = Convert.ToInt32(readerStockPriceWarranty("prod_stocks"))
                            Dim price As Decimal = Convert.ToDecimal(readerStockPriceWarranty("prod_price"))
                            Dim model As String = readerStockPriceWarranty("prod_model").ToString()
                            Dim color As String = readerStockPriceWarranty("prod_color").ToString()
                            Dim warrantyID As Integer = Convert.ToInt32(readerStockPriceWarranty("Warranty_ID"))
                            Dim suppID As Integer = Convert.ToInt32(readerStockPriceWarranty("sup_ID"))

                            ' Update the labels with the retrieved information
                            prod_id.Text = prodID
                            lbl_stock.Text = "Available Stock: " & availableStock.ToString()
                            txt_price.Text = price.ToString()
                            txt_product_model.Text = model
                            txt_product_color.Text = color
                            Sup_ID.Text = suppID



                            ' Now, query the warranty information based on the retrieved warranty ID
                            Dim queryWarrantyInfo As String = "SELECT CONCAT(War_Duration, '-', War_DurationUnit) AS warranty_info, War_Type FROM warranty WHERE War_ID = @warrantyID"

                            Using commandWarrantyInfo As New MySqlCommand(queryWarrantyInfo, Conn)
                                commandWarrantyInfo.Parameters.AddWithValue("@warrantyID", warrantyID)
                                readerStockPriceWarranty.Close()

                                Dim readerWarrantyInfo As MySqlDataReader = commandWarrantyInfo.ExecuteReader()

                                If readerWarrantyInfo.Read() Then
                                    Dim warrantyInfo As String = readerWarrantyInfo("warranty_info")
                                    Dim WarrantyType As String = readerWarrantyInfo("War_Type")

                                    readerWarrantyInfo.Close()
                                    ' Set the ComboBox value to the retrieved warranty info
                                    Cb_warranty.Text = warrantyInfo & "-" & WarrantyType
                                    show_id.Text = show_id.Text
                                    war_type.Text = WarrantyType


                                Else
                                    MessageBox.Show("Warranty information not found")
                                End If

                                readerWarrantyInfo.Close()
                            End Using
                            readerStockPriceWarranty.Close()
                        Else
                            lbl_stock.Text = "Stock information not found"
                            txt_price.Text = "Price information not found"
                            war_type.Text = "Warranty type information not found"
                        End If

                        readerStockPriceWarranty.Close() ' Close the data reader here
                    Catch ex As Exception
                        MessageBox.Show("Error retrieving stock and price information: " & ex.Message)
                    End Try
                End Using

                ' Close the database connection
                closeDB()
            Else
                MessageBox.Show("Database connection failed")
            End If
        End If
    End Sub

    Private Sub Cb_warranty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_warranty.SelectedIndexChanged
        If Cb_warranty.SelectedIndex <> -1 Then
            Try
                If openDB() Then
                    Dim selectedWarranty As String = Cb_warranty.SelectedItem.ToString()
                    Dim warrantyParts As String() = selectedWarranty.Split("-"c)
                    Dim duration As Integer = Integer.Parse(warrantyParts(0).Trim())
                    Dim durationUnit As String = warrantyParts(1).Trim()
                    Dim warType As String = warrantyParts(2).Trim()

                    Dim queryWarrantyId As String = "SELECT War_ID FROM warranty WHERE War_Duration = @Duration AND War_DurationUnit = @DurationUnit AND War_Type = @WarType"

                    Using cmd As New MySqlCommand(queryWarrantyId, Conn)
                        cmd.Parameters.AddWithValue("@Duration", duration)
                        cmd.Parameters.AddWithValue("@DurationUnit", durationUnit)
                        cmd.Parameters.AddWithValue("@WarType", warType)

                        Dim warrantyId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If warrantyId > 0 Then
                            ' Set the ID in show_id.Text
                            show_id.Text = warrantyId.ToString()
                            war_type.Text = warType
                        Else
                            MessageBox.Show("Warranty ID not found.")
                        End If

                    End Using

                    closeDB()
                Else
                    MessageBox.Show("THE DATABASE IS NOT CONNECTED")
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching warranty ID: " & ex.Message)
            End Try
        End If
    End Sub





    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        ' Get the raw product name from the ComboBox
        Dim rawProdName As String = Cb_Products.Text

        ' Trim the product name to remove text after "-"
        Dim hyphenIndex As Integer = rawProdName.IndexOf("-")
        Dim ProdName As String = If(hyphenIndex <> -1, rawProdName.Substring(0, hyphenIndex).Trim(), rawProdName.Trim())

        ' Get the other values from the form controls
        Dim ProdModel As String = txt_product_model.Text
        Dim ProdColor As String = txt_product_color.Text
        Dim ProdQuantity As Integer = Convert.ToInt32(txt_stocks.Text) ' Convert to Integer for quantity
        Dim ProdPrice As Decimal = Convert.ToDecimal(txt_price.Text) ' Convert to Decimal for price

        ' Get the product ID based on the selected product name and model
        Dim ProdID As Integer = GetProductID(ProdName, ProdModel)

        ' Update the product stocks in the database

        ' Create a new row for the DataGridView with product ID included
        Dim row As String() = {ProdID.ToString(), ProdName, ProdModel, ProdColor, ProdQuantity.ToString(), ProdPrice.ToString()}

        ' Add the new row to the DataGridView
        dt_purchase.Rows.Add(row)

    End Sub



    Private Sub Btn_purchase_Click(sender As Object, e As EventArgs) Handles Btn_purchase.Click

        Dim ProdModeltxt As String = txt_product_model.Text.Trim()
        Dim ProdColortxt As String = txt_product_color.Text.Trim()
        Dim ProdQuantitytxt As Integer = txt_stocks.Text.Trim()
        Dim ProdPricetxt As Integer = txt_price.Text.Trim()

        If dt_purchase.Rows.Count < 1 Then ' Assuming the DataGridView has headers, so at least one row is required
            MessageBox.Show("Please add products to the purchase list.")
            Exit Sub
        End If
        If Cb_Products.SelectedIndex = -1 OrElse
           String.IsNullOrEmpty(Cb_Products.Text) OrElse
           String.IsNullOrEmpty(ProdModeltxt) OrElse
           String.IsNullOrEmpty(ProdColortxt) OrElse
           Not Integer.TryParse(ProdQuantitytxt, Nothing) OrElse
           Not Integer.TryParse(ProdPricetxt, Nothing) Then

            MessageBox.Show("Please fill the product details properly")
        Else
            For Each row As DataGridViewRow In dt_purchase.Rows
                If Not row.IsNewRow Then ' Skip the new row if any
                    Dim ProdID As Integer = Convert.ToInt32(row.Cells("prodID").Value) ' Adjust column name as per your DataGridView
                    Dim ProdQuantity As Integer = Convert.ToInt32(row.Cells("prodStock").Value) ' Adjust column name as per your DataGridView

                    If ProdID = 0 Then
                        ' Get other product details from the DataGridView
                        Dim ProdName As String = row.Cells("prodName").Value.ToString()
                        Dim ProdModel As String = row.Cells("prodModel").Value.ToString()
                        Dim ProdColor As String = row.Cells("prodColor").Value.ToString()
                        Dim ProdPrice As Decimal = Convert.ToDecimal(row.Cells("prodPrice").Value) ' Assuming the price is in a decimal format

                        ' Check if a supplier is selected
                        If Cb_supplier.SelectedIndex = -1 Then
                            ' Supplier not selected, so show a message to select a supplier
                            MessageBox.Show("Please select a supplier.")
                            Exit Sub
                        End If

                        ' Check if warranty ID is selected
                        If show_id.Text = "" Then
                            ' Warranty ID not selected, show a message
                            MessageBox.Show("Please select a warranty.")
                            Exit Sub
                        End If

                        Dim supplierId As Integer
                        If Cb_supplier.SelectedIndex = Cb_supplier.Items.Count - 1 Then
                            ' The last item in the ComboBox is for adding a new supplier
                            ' Insert the new supplier into the database and get the new supplier ID
                            supplierId = InsertSupplier(Cb_supplier.Text, txt_store_name.Text, txt_sup_address.Text, txt_sup_email.Text, txt_sup_cnumber.Text)
                        Else
                            ' Get the selected supplier ID from Cb_supplier
                            supplierId = GetSupplierID(Cb_supplier.Text) ' Modify GetSupplierID function as needed
                        End If

                        ' Insert the new product into the database with supplier ID and warranty ID
                        If Not InsertProduct(ProdName, ProdModel, ProdColor, ProdQuantity, ProdPrice, supplierId, Convert.ToInt32(show_id.Text)) Then
                            MessageBox.Show("Failed to insert new product.")
                            Exit Sub ' Exit the loop if insert fails
                        End If

                    Else
                        ' Update the product stocks in the database
                        If Not UpdateProductStocks(ProdID, ProdQuantity) Then
                            MessageBox.Show("Failed to update product stocks.")
                            Exit Sub ' Exit the loop if update fails
                        End If

                    End If
                End If
            Next
            MessageBox.Show("Purchase completed successfully.")
        End If        ' Assuming dt_purchase is the DataGridView containing the purchase details
    End Sub









    Private Function InsertSupplier(ByVal supplierName As String, ByVal storeName As String, ByVal storeAddress As String, ByVal supplierEmail As String, ByVal supplierContactNumber As String) As Integer
        Dim supplierId As Integer = 0 ' Initialize to a default value

        ' Assuming you have a connection named Conn
        If openDB() Then
            ' Insert query to add the new supplier to the database
            Dim insertQuery As String = "INSERT INTO supplier (Supp_name, Supp_store, Supp_address, Supp_email, Supp_cnumber) VALUES (@supplierName, @storeName, @storeAddress, @supplierEmail, @supplierContactNumber); SELECT LAST_INSERT_ID()"

            Using command As New MySqlCommand(insertQuery, Conn)
                command.Parameters.AddWithValue("@supplierName", supplierName)
                command.Parameters.AddWithValue("@storeName", storeName)
                command.Parameters.AddWithValue("@storeAddress", storeAddress)
                command.Parameters.AddWithValue("@supplierEmail", supplierEmail)
                command.Parameters.AddWithValue("@supplierContactNumber", supplierContactNumber)

                Try
                    ' Execute the insert query and get the last inserted ID
                    supplierId = Convert.ToInt32(command.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error inserting new supplier: " & ex.Message)
                End Try
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return supplierId
    End Function







    Private Function InsertProduct(ByVal productId As Integer, ByVal productName As String, ByVal productModel As String, ByVal productColor As String, ByVal productStock As Integer, ByVal productPrice As Decimal, ByVal supplierId As Integer) As Boolean
        Dim success As Boolean = False

        ' Assuming you have a connection named Conn
        If openDB() Then
            ' Insert query to add the new product to the database
            Dim insertQuery As String = "INSERT INTO products (prod_id, prod_name, prod_model, prod_color, prod_stocks, prod_price, sup_ID) VALUES (@productId, @productName, @productModel, @productColor, @productStock, @productPrice, @supplierId)"

            Using command As New MySqlCommand(insertQuery, Conn)
                command.Parameters.AddWithValue("@productId", productId)
                command.Parameters.AddWithValue("@productName", productName)
                command.Parameters.AddWithValue("@productModel", productModel)
                command.Parameters.AddWithValue("@productColor", productColor)
                command.Parameters.AddWithValue("@productStock", productStock)
                command.Parameters.AddWithValue("@productPrice", productPrice)
                command.Parameters.AddWithValue("@supplierId", supplierId)

                Try
                    command.ExecuteNonQuery()
                    success = True ' Insert successful
                Catch ex As Exception
                    MessageBox.Show("Error inserting new product: " & ex.Message)
                End Try
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return success
    End Function







    Private Function GetSupplierID(ByVal supplierName As String) As Integer
        Dim supplierId As Integer = 0

        ' Assuming you have a connection named Conn
        If openDB() Then
            Dim query As String = "SELECT Supp_ID FROM supplier WHERE Supp_name = @supplierName"

            Using command As New MySqlCommand(query, Conn)
                command.Parameters.AddWithValue("@supplierName", supplierName)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    supplierId = Convert.ToInt32(reader("Supp_ID"))
                End If
                reader.Close()
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return supplierId
    End Function



    Private Function ProductExists(ByVal productId As Integer) As Boolean
        Dim exists As Boolean = False

        ' Check if the product exists in the database
        ' Assuming you have a connection named Conn
        If openDB() Then
            Dim query As String = "SELECT COUNT(*) FROM products WHERE prod_id = @productId"

            Using command As New MySqlCommand(query, Conn)
                command.Parameters.AddWithValue("@productId", productId)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                exists = (count > 0)
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return exists
    End Function







    Private Function UpdateProductStocks(ByVal productId As Integer, ByVal quantity As Integer) As Boolean
        Dim success As Boolean = False

        ' Assuming you have a connection named Conn
        If openDB() Then
            ' Update query to increment the product stocks by the purchased quantity
            Dim updateQuery As String = "UPDATE products SET prod_stocks = prod_stocks + @quantity WHERE prod_id = @productId"

            Using command As New MySqlCommand(updateQuery, Conn)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@productId", productId)

                Try
                    command.ExecuteNonQuery()
                    success = True ' Update successful
                Catch ex As Exception
                    MessageBox.Show("Error updating product stocks: " & ex.Message)
                End Try
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return success
    End Function






    ' Function to retrieve the product ID based on the product name
    Private Function GetProductID(ByVal productName As String, ByVal productModel As String) As Integer
        Dim productId As Integer = 0 ' Initialize to a default value

        ' Assuming you have a connection named Conn
        If openDB() Then
            Dim query As String = "SELECT prod_id FROM products WHERE prod_name LIKE @productName AND prod_model = @productModel"

            Using command As New MySqlCommand(query, Conn)
                ' Using LIKE in case the product name in the database is not exactly the same
                command.Parameters.AddWithValue("@productName", productName & "%")
                command.Parameters.AddWithValue("@productModel", productModel)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    productId = Convert.ToInt32(reader("prod_id"))
                End If
                reader.Close()
            End Using

            closeDB() ' Close the database connection after use
        End If

        Return productId
    End Function








    Private Sub LoadWarranty()
        If openDB() Then
            Dim query_warranty = "SELECT CONCAT(War_Duration, '-', War_DurationUnit, '-', War_Type) AS warranty_info FROM warranty"
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


    Private Sub LoadProducts()
        Cb_Products.Items.Clear()

        If openDB() Then
            Dim query_product = "SELECT CONCAT(prod_name, ' - ', prod_model) AS product_info FROM products WHERE prod_stocks > 0"
            Using Command As New MySqlCommand(query_product, Conn)
                Try
                    Using reader = Command.ExecuteReader
                        While reader.Read
                            ' Add the concatenated product information to the ComboBox items
                            Cb_Products.Items.Add(reader("product_info").ToString)
                        End While
                        reader.Close()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message & " product load")
                Finally
                    closeDB()
                End Try
            End Using
        Else
            MessageBox.Show("The database is not connected.")
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
                            txt_store_name.Text = reader("Supp_store").ToString()
                            txt_sup_address.Text = reader("Supp_address").ToString()
                            txt_sup_email.Text = reader("Supp_email").ToString()
                            txt_sup_cnumber.Text = reader("Supp_cnumber").ToString()
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
    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        If dt_purchase.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dt_purchase.SelectedRows(0)
            dt_purchase.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select a row to clear.")
        End If
    End Sub


    Private Sub dt_purchase_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_purchase.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dt_purchase.Rows(e.RowIndex)

            Dim ProdID As String = selectedRow.Cells("prodID").Value.ToString()
            Dim ProdName As String = selectedRow.Cells("prodName").Value.ToString()
            Dim ProdModel As String = selectedRow.Cells("prodModel").Value.ToString()
            Dim ProdColor As String = selectedRow.Cells("prodColor").Value.ToString()
            Dim ProdQuantity As String = selectedRow.Cells("prodStock").Value.ToString()
            Dim ProdPrice As String = selectedRow.Cells("prodPrice").Value.ToString()

            For Each row As DataGridViewRow In dt_purchase.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = True
                End If
            Next
        End If
    End Sub



End Class
