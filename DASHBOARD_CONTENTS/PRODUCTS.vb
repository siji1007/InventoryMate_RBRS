Public Class PRODUCTS
    Private Sub Lbl_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_product.TextAlign = ContentAlignment.MiddleCenter
        Lbl_product.AutoSize = False
        Lbl_product.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_product.Width) \ 2
        Lbl_product.Location = New Point(centerX, Lbl_product.Location.Y)
    End Sub





End Class
