Imports System.Data.SqlClient

Partial Class AllCustomers
    Inherits System.Web.UI.Page

    Private Sub AllCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= PVFCARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT PERSON_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NO, GENDER, CITY, STATE, POSTAL_CODE, COUNTRY, ROLE, PASSWORD FROM PERSON "
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read()
                Dim row As HtmlTableRow = New HtmlTableRow()
                row.Attributes.Add("class", "row")
                Dim PERSON_ID As New HtmlTableCell()
                PERSON_ID.InnerText = dr("PERSON_ID").ToString()
                Dim FIRST_NAME As New HtmlTableCell()
                FIRST_NAME.InnerText = dr("FIRST_NAME").ToString()
                Dim LAST_NAME As New HtmlTableCell()
                LAST_NAME.InnerText = dr("LAST_NAME").ToString()
                Dim EMAIL As New HtmlTableCell()
                EMAIL.InnerText = dr("EMAIL").ToString()
                Dim PHONE_NO As New HtmlTableCell()
                PHONE_NO.InnerText = dr("PHONE_NO").ToString()
                Dim GENDER As New HtmlTableCell()
                GENDER.InnerText = dr("GENDER").ToString()
                Dim CITY As New HtmlTableCell()
                CITY.InnerText = dr("CITY").ToString()
                Dim STATE As New HtmlTableCell()
                STATE.InnerText = dr("STATE").ToString()
                Dim POSTAL_CODE As New HtmlTableCell()
                POSTAL_CODE.InnerText = dr("POSTAL_CODE").ToString()
                Dim COUNTRY As New HtmlTableCell()
                COUNTRY.InnerText = dr("COUNTRY").ToString()
                Dim ROLE As New HtmlTableCell()
                ROLE.InnerText = dr("ROLE").ToString()
                row.Cells.Add(PERSON_ID)
                row.Cells.Add(FIRST_NAME)
                row.Cells.Add(LAST_NAME)
                row.Cells.Add(EMAIL)
                row.Cells.Add(PHONE_NO)
                row.Cells.Add(GENDER)
                row.Cells.Add(CITY)
                row.Cells.Add(STATE)
                row.Cells.Add(POSTAL_CODE)
                row.Cells.Add(COUNTRY)
                row.Cells.Add(ROLE)
                display.Rows.Add(row)
            End While
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
            cmd.Dispose()
        End Try
    End Sub
End Class
