Imports MySql.Data.MySqlClient

Public Class HOME
    Private Sub Lbl_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lbl_home.TextAlign = ContentAlignment.MiddleCenter
        Lbl_home.AutoSize = False
        Lbl_home.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_home.Width) \ 2
        Lbl_home.Location = New Point(centerX, Lbl_home.Location.Y)


        daily_date.Text = Date.Now.ToString("yyyy-MMMM-dd")
        LoadDailySales()
    End Sub

    Private Sub LoadDailySales()
        Try
            If openDB() Then
                Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd") ' Get the current date in the required format

                Dim query As New MySqlCommand("
                SELECT 
                    t.Prod_ID, 
                    CONCAT(p.prod_name, '-', p.prod_model) AS ProductName, 
                    t.Quantity, 
                    c.Cust_name AS CustomerName, 
                    CONCAT(w.War_Duration, ' ', w.War_DurationUnit) AS WarrantyDuration, 
                    CASE 
                        WHEN w.War_DurationUnit = 'Days' THEN DATE_ADD(t.Transact_date, INTERVAL w.War_Duration DAY)
                        WHEN w.War_DurationUnit = 'Months' THEN DATE_ADD(t.Transact_date, INTERVAL w.War_Duration MONTH)
                        WHEN w.War_DurationUnit = 'Years' THEN DATE_ADD(t.Transact_date, INTERVAL w.War_Duration YEAR)
                        ELSE t.Transact_date 
                    END AS ExpirationDate
                FROM 
                    Transactions t 
                INNER JOIN 
                    products p ON t.Prod_ID = p.prod_id 
                INNER JOIN 
                    customer c ON t.Customer_ID = c.Cust_ID 
                INNER JOIN 
                    warranty w ON t.Warr_ID = w.War_ID
                WHERE 
                    DATE(t.Transact_date) = @CurrentDate
            ", Conn)

                query.Parameters.AddWithValue("@CurrentDate", currentDate) ' Add the current date as a parameter

                Using dr As MySqlDataReader = query.ExecuteReader()
                    While dr.Read()
                        Dim expirationDate As Date = Convert.ToDateTime(dr("ExpirationDate"))

                        Dim rowIndex As Integer = daily_datagridview.Rows.Add(dr("ProductName"), dr("Quantity"), dr("CustomerName"), expirationDate)

                        If expirationDate.Date = currentDate Then
                            daily_datagridview.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red ' Set row background color to red
                        End If

                    End While
                End Using
                UpdateTopSaleLabel()
                TotalCost()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try
    End Sub


    Private Sub TotalCost()
        Try
            If openDB() Then
                Dim query As String = "SELECT SUM(Total_cost) AS TotalCost FROM Transactions WHERE DATE(Transact_date) = CURDATE()"

                Using cmd As New MySqlCommand(query, Conn)
                    Dim totalCostResult As Object = cmd.ExecuteScalar()
                    If totalCostResult IsNot Nothing AndAlso Not DBNull.Value.Equals(totalCostResult) Then
                        Dim formattedTotalCost As String = Convert.ToDecimal(totalCostResult).ToString("#,##0.00")
                        Total_cost.Text = "₱" & formattedTotalCost
                    Else
                        Total_cost.Text = "₱ 0.00"
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try
    End Sub





    Private Sub UpdateTopSaleLabel()
        Try
            If openDB() Then
                ' Query to get the top-selling product name
                Dim topSaleQuery As New MySqlCommand("
            SELECT 
                p.prod_name
            FROM 
                Transactions t 
            INNER JOIN 
                products p ON t.Prod_ID = p.prod_id 
            GROUP BY 
                t.Prod_ID
            ORDER BY 
                COUNT(t.Prod_ID) DESC
            LIMIT 1
            ", Conn)

                ' Execute the query to get the top-selling product name
                Dim topSaleProductName As String = Convert.ToString(topSaleQuery.ExecuteScalar())

                ' Update the label with the top-selling product name
                Top_sale.Text = topSaleProductName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try
    End Sub







End Class
