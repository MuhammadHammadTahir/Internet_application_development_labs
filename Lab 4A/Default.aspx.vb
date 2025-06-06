Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= PVFC; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Select *"
        cmd.CommandText &= "From Customer_t"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read()
                Response.Write(dr("Customer_id") & "&nbsp&nbsp&nbsp&nbsp" & dr("Customer_name") & "<br>")
            End While
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
            cmd.Dispose()
        End Try
    End Sub
End Class
