
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim textbox As New HtmlTextArea
        textbox.ID = "txtArea"
        textbox.Rows = 5
        container.Controls.Add(textbox)

        Dim input As New HtmlInputSubmit
        input.ID = "btnSubmit"
        input.Value = "Modify TextBox"

        AddHandler input.ServerClick, AddressOf ModifyTextBox
        container.Controls.Add(input)
    End Sub

    Public Sub ModifyTextBox()
        CType(container.FindControl("txtArea"), HtmlTextArea).Value = "Hello World!"
        CType(container.FindControl("txtArea"), HtmlTextArea).Style.Add("color", "red")
        CType(container.FindControl("txtArea"), HtmlTextArea).Style.Add("font-family", "arial")
    End Sub

End Class
