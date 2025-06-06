
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Init(sender As Object, e As EventArgs) Handles Me.Init
        testing.InnerHtml += "webpage initillzed</br>"
    End Sub

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        testing.InnerHtml += "webpage loaded</br>"
    End Sub

    Private Sub _Default_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        testing.InnerHtml += "Webpage prerendered</br>"
    End Sub

    Private Sub _Default_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        testing.InnerHtml = "webpage unloaded"
    End Sub
End Class
