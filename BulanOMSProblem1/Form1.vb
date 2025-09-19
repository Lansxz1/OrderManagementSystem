Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Try
            Dim selectedBeverage = ComboBox1.SelectedItem.ToString()
            Dim quantity = NumericUpDown1.Value
            Dim total As Double
            Dim subtotal As Double
            Dim totalAmount As Double
            Dim name As String = TextBox1.Text.Trim()

            Select Case selectedBeverage
                Case "Espresso: 120 PHP"
                    totalAmount = ((total) + 120 * quantity)
                Case "Latte: 150 PHP"
                    totalAmount = ((total) + 150 * quantity)
                Case "Cappuccino :  160 PHP"
                    totalAmount = ((total) + 160 * quantity)
                Case "Americano: 130 PHP"
                    totalAmount = ((total) + 130 * quantity)
                Case "Mocha: 170 PHP"
                    totalAmount = ((total) + 170 * quantity)
                    Exit Sub
            End Select
            lblCustomer.Text = "Customer Name: " & name
            lblTotal.Text = "Final Total: " & totalAmount.ToString() & " PHP"

            If (CheckBox1.Checked) Then
                subtotal = totalAmount - 10%
                lblSubtotal.Text = "Subtotal: " & subtotal.ToString() & " PHP with Discount"
            End If

        Catch
            MsgBox("Input Beverage and Amount")
        End Try


    End Sub
End Class
