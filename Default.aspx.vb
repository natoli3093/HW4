
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click

        'Specify constant tax rates
        Const TAX_RATE As Decimal = 0.18
        Const GROSS_TAX_RATE As Decimal = 0.22

        'Create variables to hold values entered by the user
        Dim w As Decimal = Wage.Text
        Dim h As Decimal = Hours.Text
        Dim pt As Decimal = PTDeduct.Text
        Dim at As Decimal = ATDeduct.Text
        Dim np As Decimal = NetPay.Text

        Dim salary = w * h

        'Dim netpay As Decimal
        'netpay = salary - pt - at

        If salary < 500 Then pt = salary * TAX_RATE
        ElseIf salary >= 500 then pt = salary * GROSS_TAX_RATE


        np = salary - pt - at

        NetPay.Text = "your Net Pay for the week is $" & np.ToString("#,###.##")


         









    End Sub
End Class
