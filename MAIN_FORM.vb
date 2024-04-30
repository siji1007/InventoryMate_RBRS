Imports MySql.Data.MySqlClient

Public Class MAIN_FORM
    Private WithEvents loginControl As LOGIN
    Private dashboardControl As DASHBOARD

    Private Sub MAIN_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ShowLogin()
    End Sub

    Public Sub ShowLogin()
        loginControl = New LOGIN()
        ' Set the LOGIN UserControl to fill the main_panel panel
        loginControl.Dock = DockStyle.Fill
        ' Add LOGIN UserControl to main_panel panel and show it
        mainPanel.Controls.Add(loginControl)
        loginControl.BringToFront()
        loginControl.Show()
    End Sub

    Private Sub LoginControl_SignInClicked() Handles loginControl.SignInClicked
        ' Remove the LOGIN UserControl from main_panel
        mainPanel.Controls.Remove(loginControl)
        loginControl.Dispose()

        ' Create and show the DASHBOARD UserControl
        dashboardControl = New DASHBOARD()
        dashboardControl.Dock = DockStyle.Fill
        mainPanel.Controls.Add(dashboardControl)
        dashboardControl.BringToFront()
        dashboardControl.Show()
    End Sub




    Private Sub MAIN_FORMClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If openDB() Then
                Dim updateQuery As New MySqlCommand("UPDATE Users SET Status='OFFLINE' WHERE Status = 'ACTIVE'", Conn)
                updateQuery.ExecuteNonQuery()
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating user status: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub








End Class
