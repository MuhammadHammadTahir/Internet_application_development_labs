
Imports System.Web.Services.Description
Imports MathLibService


Partial Class calculator
    Inherits System.Web.UI.Page

    Dim service As New MathLibServiceSoapClient
    Dim value As String


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num1 As Double = Double.Parse(txtNum1.Text)
        Dim num2 As Double = Double.Parse(txtNum2.Text)
        value = service.AddNumbers(num1, num2).ToString()
        lblResult.Text = value
        lblError.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim num1 As Double = Double.Parse(txtNum1.Text)
        Dim num2 As Double = Double.Parse(txtNum2.Text)
        value = service.SubtractNumbers(num1, num2).ToString()
        lblResult.Text = value
        lblError.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim num1 As Double = Double.Parse(txtNum1.Text)
        Dim num2 As Double = Double.Parse(txtNum2.Text)
        value = service.MultiplyNumbers(num1, num2).ToString()
        lblResult.Text = value
        lblError.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If Integer.Parse(txtNum2.Text) = 0 Then
            lblResult.Text = ""
            lblError.Text = "Division by 0 is not Allowed"
            Exit Sub
        End If
        Dim num1 As Double = Double.Parse(txtNum1.Text)
        Dim num2 As Double = Double.Parse(txtNum2.Text)
        value = service.DivideNumbers(num1, num2).ToString()
        lblResult.Text = value
        lblError.Text = ""
    End Sub


End Class
