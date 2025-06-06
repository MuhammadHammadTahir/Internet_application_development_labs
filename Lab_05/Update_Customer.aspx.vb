
Imports System.Data.SqlClient
Imports ASP

Partial Class Update_Customer
    Inherits System.Web.UI.Page
    Private Sub Default_Load(sender As Object, e As EventArgs) Handles search.ServerClick
        Dim constr As String
        Dim person_id As String
        constr = "Data Source= localhost; Initial Catalog= PVFCARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT PERSON_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE_NO, GENDER, CITY, STATE, POSTAL_CODE, COUNTRY, ROLE, PASSWORD FROM PERSON WHERE PERSON_ID = '"
        cmd.CommandText += search_customer.Value + "'"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                person_id = dr("PERSON_ID").ToString()
                first_name.Value = dr("FIRST_NAME").ToString()
                last_name.Value = dr("LAST_NAME").ToString()
                email.Value = dr("EMAIL").ToString()
                phone.Value = dr("PHONE_NO").ToString
                city.Value = dr("CITY").ToString()
                state.Value = dr("STATE").ToString()
                postal_code.Value = dr("POSTAL_CODE").ToString()
                country.Value = dr("COUNTRY").ToString()
                password.Value = dr("PASSWORD").ToString()

                update_btn.Visible = True
            Else
                update_btn.Visible = False
            End If

            'Result.InnerHtml = ""
            'While dr.Read()
            'Result.InnerHtml += dr("PERSON_ID") & "&nbsp&nbsp&nbsp&nbsp" & dr("FIRST_NAME") & "&nbsp&nbsp&nbsp&nbsp" & dr("LAST_NAME") & "&nbsp&nbsp&nbsp&nbsp" & dr("EMAIL") & "&nbsp&nbsp&nbsp&nbsp" & dr("PHONE_NO") & "&nbsp&nbsp&nbsp&nbsp" & dr("GENDER") & "&nbsp&nbsp&nbsp&nbsp" & dr("CITY") & "&nbsp&nbsp&nbsp&nbsp" & dr("STATE") & "&nbsp&nbsp&nbsp&nbsp" & dr("POSTAL_CODE") & "&nbsp&nbsp&nbsp&nbsp" & dr("COUNTRY") & "&nbsp&nbsp&nbsp&nbsp" & dr("ROLE") & "<br>"
            ' End While
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
            cmd.Dispose()
        End Try

    End Sub

    Private Sub update_date(sender As Object, e As EventArgs) Handles update_btn.ServerClick
        Dim constr As String

        constr = "Data Source= localhost; Initial Catalog= PVFCARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "UPDATE PERSON SET FIRST_NAME = '"
        cmd.CommandText += first_name.Value + "', LAST_NAME = '"
        cmd.CommandText += last_name.Value + "', EMAIL = '"
        cmd.CommandText += email.Value + "', PHONE_NO = '"
        cmd.CommandText += phone.Value + "', CITY = '"
        cmd.CommandText += city.Value + "', STATE = '"
        cmd.CommandText += state.Value + "', POSTAL_CODE = '"
        cmd.CommandText += postal_code.Value + "', COUNTRY = '"
        cmd.CommandText += country.Value + "', PASSWORD = '"
        cmd.CommandText += password.Value + "' WHERE PERSON_ID = '"
        cmd.CommandText += search_customer.Value + "'"

        Try
            con.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.InnerText = "Record updated successfully."
            Else
                MessageBox.InnerText = "Record did not updated."
            End If
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub Update_Customer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim check As Boolean = False
        update_btn.Visible = False
    End Sub

End Class
