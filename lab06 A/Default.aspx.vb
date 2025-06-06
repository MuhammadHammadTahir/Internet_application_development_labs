
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub incrementer(ByVal sender As Object, ByVal e As EventArgs) Handles incr.ServerClick
        Dim Contents As String
        If Me.IsPostBack = True Then
            Contents = CType(Me.ViewState("Text"), String)
        Else
            Contents = "0"
        End If


        txtName.Value = CInt(Contents) + 2
        Contents = txtName.Value
        Me.ViewState("Text") = Contents


    End Sub

End Class
