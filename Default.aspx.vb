﻿
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

        'math logic formulas to compute salary after pretax
        Dim salary = w * h
        Dim ptsalary As Decimal
        ptsalary = salary - pt

        'assume tax rate if higher/eqaual or lower than $500 after pre tax
        If ptsalary >= 500 Then
            TAX_RATE = 0.22
        End If

        If ptsalary < 500 Then
            TAX_RATE = 0.18
        End If
        Dim atsalary As Decimal
        atsalary = ptsalary - (ptsalary * TAX_RATE)

        'create net pay variable and formula
        Dim np As Decimal
        np = atsalary - at

        'display result
        lbl_Result.Text = "your Net Pay for the week is $" & np.ToString("#,###.##")

    End Sub

    Protected Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click

        'clear all textboxes and labels
        Wage.Text = String.Empty
        Hours.Text = String.Empty
        PTDeduct.Text = String.Empty
        ATDeduct.Text = String.Empty
        lbl_Result.Text = String.Empty

    End Sub
End Class
