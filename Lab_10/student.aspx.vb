Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.ServiceModel.Channels

Partial Class student
    Inherits System.Web.UI.Page

    Dim is_error As Boolean = False

    Private Sub student_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM questions"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read()
                Dim ques_num As String = dr("ques_num")
                Dim question As String = dr("ques")
                Dim option1 As New ListItem(dr("option1"), dr("option1"))
                Dim option2 As New ListItem(dr("option2"), dr("option2"))
                Dim option3 As New ListItem(dr("option3"), dr("option3"))
                Dim option4 As New ListItem(dr("option4"), dr("option4"))

                Dim question_box As New HtmlGenericControl("div")
                Dim question_div As New HtmlGenericControl("div")
                question_div.InnerText = ques_num + ". " + dr("ques")
                Dim options As New RadioButtonList()
                options.ID = "options_" + ques_num
                options.Items.Add(option1)
                options.Items.Add(option2)
                options.Items.Add(option3)
                options.Items.Add(option4)
                question_box.Controls.Add(question_div)
                question_box.Controls.Add(options)
                question_paper.Controls.Add(question_box)
            End While
        Catch ex As Exception
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = ex.Message
            is_error = True
        Finally

            con.Close()
            cmd.Dispose()
            'from here use if else statments to redirect to the respective page

        End Try
    End Sub

    Private Sub submit_questions(sender As Object, e As EventArgs) Handles submit_button.ServerClick

        Dim score As Integer = 0
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM questions"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read()
                Dim ques_num As String = dr("ques_num")
                Dim correct_answer As String = dr("correct").ToString()
                Dim questiontocheck As RadioButtonList = CType(question_paper.FindControl("options_" & ques_num), RadioButtonList)
                If questiontocheck.SelectedItem IsNot Nothing Then
                    If questiontocheck.SelectedValue = correct_answer Then
                        score += 1
                    End If
                End If
            End While
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = "Your score is: " + score.ToString()
        Catch ex As Exception
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try
    End Sub

End Class