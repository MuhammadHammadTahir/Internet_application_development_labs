Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.ServiceModel.Channels

Partial Class teacher
    Inherits System.Web.UI.Page

    Dim is_error As Boolean = False
    Private Sub create_paper(sender As Object, e As EventArgs) Handles add.ServerClick
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO QUESTIONS (ques_num, ques, option1, option2, option3, option4, correct) VALUES ('"
        cmd.CommandText += ques_num.Value + "', '" + question.Value + "', '" + option1.Value + "', '" + option2.Value + "', '" + option3.Value + "', '" + option4.Value + "', '" + correct.Value + "')"

        Try
            con.Open()
            Dim insert As Integer = cmd.ExecuteNonQuery()
            If insert > 0 Then
                message_box.Style.Add("opacity", "1")
                message_box.InnerText = "Record Inserted Successfully"
            Else
                message_box.Style.Add("opacity", "1")
                message_box.InnerText = insert + " Record Inserted"
            End If
        Catch ex As Exception
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = ex.Message
            is_error = True
        Finally
            con.Close()
            cmd.Dispose()
            Response.Redirect("teacher.aspx")
        End Try

    End Sub


End Class