Public Class HOME
    Private Sub Lbl_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lbl_home.TextAlign = ContentAlignment.MiddleCenter
        Lbl_home.AutoSize = False
        Lbl_home.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_home.Width) \ 2
        Lbl_home.Location = New Point(centerX, Lbl_home.Location.Y)

    End Sub





End Class
