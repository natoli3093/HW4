
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click

        'Specify constant tax rates
        Dim TAX_RATE As Decimal

        'Create variables to hold values entered by the user
        Dim w As Decimal = Wage.Text
        Dim h As Decimal = Hours.Text
        Dim pt As Decimal = PTDeduct.Text
        Dim at As Decimal = ATDeduct.Text

        Dim salary = w * h
        Dim ptsalary As Decimal
        ptsalary = salary - pt

        If ptsalary >= 500 Then
            TAX_RATE = 0.22
        End If

        If ptsalary < 500 Then
            TAX_RATE = 0.18
        End If
        Dim atsalary As Decimal
        atsalary = ptsalary - (ptsalary * TAX_RATE)

        Dim np As Decimal
        np = atsalary - at


        

        NetPay.Text = "your Net Pay for the week is $" & np.ToString("#,###.##")












    End Sub
End Class
