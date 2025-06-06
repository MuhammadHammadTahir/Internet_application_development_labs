Imports System.Web.UI

Partial Class _Default
    Inherits Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then
            Amount.Value = "Enter Amount"
            result.InnerText = ""
            currency.Items.Add(New ListItem("Euro", "0.96"))
            currency.Items.Add(New ListItem("Pakistani Ruppee", "279.61"))
            currency.Items.Add(New ListItem("Qatari Riyal", "3.65"))
            currency.Items.Add(New ListItem("Chinese Yuan", "7.25"))

        End If
    End Sub
    Private Sub Currency_Conversion(ByVal sender As Object, ByVal e As EventArgs) Handles convert.ServerClick
        Dim amount_input As Double = Val(Amount.Value)
        Dim currency_rate As Double = Val(currency.Items(currency.SelectedIndex).Value)
        Dim converted_amount As Double = amount_input * currency_rate
        result.Style("color") = "blue"
        result.InnerText = amount_input.ToString() & " Dollars is equal to " & converted_amount.ToString() & " " & currency.Items(currency.SelectedIndex).Text

    End Sub

End Class
