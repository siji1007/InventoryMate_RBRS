Imports MySql.Data.MySqlClient

Public Class HISTORY_TRANSACTION
    Private Sub HISTORY_TRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        History()

    End Sub

    Private Sub History()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT t.Transac_ID as TransactionID, t.Transact_date as TransactionDate, c.Cust_name as CustomerName FROM transactions t JOIN customer c ON t.Customer_ID = c.Cust_ID", Conn)

                Using dr As MySqlDataReader = query.ExecuteReader()
                    While dr.Read() ' Advance the reader to the first row and loop through all rows
                        Dim rowIndex As Integer = History_Dt.Rows.Add(dr("TransactionID"), dr("CustomerName"), dr("TransactionDate"))
                    End While
                End Using
            Else
                MessageBox.Show("DATABASE CONNECTION LOST.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Enum MonthOption
        January
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        December
    End Enum



    Private Sub Cb_FilterMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_FilterMonth.SelectedIndexChanged
        Dim filterMonth As MonthOption = CType(Cb_FilterMonth.SelectedIndex, MonthOption) ' Convert selected index to MonthOption enum

        For Each row As DataGridViewRow In History_Dt.Rows
            Dim transactionDate As Date = Convert.ToDateTime(row.Cells("TransDate").Value)
            Dim transactionMonth As MonthOption = CType(transactionDate.Month - 1, MonthOption) ' Convert month to MonthOption enum

            If filterMonth = transactionMonth Then
                row.Visible = True ' Show rows with matching month
            Else
                row.Visible = False ' Hide rows with non-matching month
            End If
        Next
    End Sub

    Private Sub Search_history_TextChanged(sender As Object, e As EventArgs) Handles Search_history.TextChanged
        Dim searchValue As String = Search_history.Text.Trim().ToLower()
        For Each row As DataGridViewRow In History_Dt.Rows
            If Not row.IsNewRow Then
                Dim CustomerName As String = row.Cells("CustName").Value.ToString().ToLower()

                If searchValue = "" OrElse CustomerName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub History_Dt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles History_Dt.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = History_Dt.Rows(e.RowIndex)
            Dim TransID As String = selectedRow.Cells("Trans_ID").Value.ToString()
            Dim CustName As String = selectedRow.Cells("CustName").Value.ToString()
            Dim TransDate As String = selectedRow.Cells("TransDate").Value.ToString()

            For Each row_history As DataGridViewRow In History_Dt.Rows
                If row_history.Index = e.RowIndex Then
                    row_history.Selected = True
                Else
                    row_history.Selected = False
                End If
            Next


        End If
    End Sub

    Private Sub ShowReceipt_Click(sender As Object, e As EventArgs) Handles ShowReceipt.Click

        If History_Dt.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = History_Dt.SelectedRows(0)
            Dim TransID As String = selectedRow.Cells("Trans_ID").Value.ToString()
            Dim TransDate As String = selectedRow.Cells("TransDate").Value.ToString()
            MessageBox.Show(TransDate)
            Dim excelFilePath As String = $"C:\Users\XtiaN\Documents\RBRS GADGET CENTER\InventoryMate_RBRS\AllReceipts\TransReceipt_{TransID}_{TransDate}.xlsx"
            Process.Start(excelFilePath)
        Else
            MessageBox.Show("Please select a row first.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class