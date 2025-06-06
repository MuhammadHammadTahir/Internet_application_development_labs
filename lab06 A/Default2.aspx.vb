Partial Class Default2
    Inherits System.Web.UI.Page

    <Serializable()>
    Public Class Customer
        Private _firstName As String
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                _firstName = value
            End Set
        End Property

        Private _lastName As String
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                _lastName = value
            End Set
        End Property

        Public Sub New(ByVal firstName As String, ByVal lastName As String)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim customer1 As New Customer("ali", "raza")
        Dim customer2 As New Customer("Hammad", "Tahir")
        Dim customer3 As New Customer("ali", "Ahmad")

        ViewState("Customer1") = customer1
        ViewState("Customer2") = customer2
        ViewState("Customer3") = customer3

        Dim customer1_retrived As Customer = CType(ViewState("Customer1"), Customer)
        Dim customer2_retrived As Customer = CType(ViewState("Customer2"), Customer)
        Dim customer3_retrived As Customer = CType(ViewState("Customer3"), Customer)

        Response.Write("Customer1: " & customer1_retrived.FirstName & " " & customer1_retrived.LastName & "<br />")
        Response.Write("Customer2: " & customer2_retrived.FirstName & " " & customer2_retrived.LastName & "<br />")
        Response.Write("Customer3: " & customer3_retrived.FirstName & " " & customer3_retrived.LastName & "<br />")

    End Sub
End Class
