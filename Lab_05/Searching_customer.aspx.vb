Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub Default_Load(sender As Object, e As EventArgs) Handles search.ServerClick
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= PVFCARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT PERSON_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NO, GENDER, CITY, STATE, POSTAL_CODE, COUNTRY, ROLE, PASSWORD FROM PERSON WHERE FIRST_NAME = '"
        cmd.CommandText += search_name.Value + "'"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            result.InnerHtml = ""
            While dr.Read()
                result.InnerHtml += dr("PERSON_ID") & "&nbsp&nbsp&nbsp&nbsp" & dr("FIRST_NAME") & "&nbsp&nbsp&nbsp&nbsp" & dr("LAST_NAME") & "&nbsp&nbsp&nbsp&nbsp" & dr("EMAIL") & "&nbsp&nbsp&nbsp&nbsp" & dr("PHONE_NO") & "&nbsp&nbsp&nbsp&nbsp" & dr("GENDER") & "&nbsp&nbsp&nbsp&nbsp" & dr("CITY") & "&nbsp&nbsp&nbsp&nbsp" & dr("STATE") & "&nbsp&nbsp&nbsp&nbsp" & dr("POSTAL_CODE") & "&nbsp&nbsp&nbsp&nbsp" & dr("COUNTRY") & "&nbsp&nbsp&nbsp&nbsp" & dr("ROLE") & "<br>"
            End While
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
            cmd.Dispose()
        End Try

    End Sub
End Class
