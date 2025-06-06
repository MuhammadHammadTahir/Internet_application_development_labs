
Imports System.Data
Imports System.Data.SqlClient

Partial Class Admin
    Inherits System.Web.UI.Page
    Private Sub veiw_teachers(sender As Object, e As EventArgs) Handles allteachers.ServerClick
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM PERSON WHERE ROLE = 'teacher'"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(dr)

            gridview1.DataSource = dt
            gridview1.DataBind()

        Catch ex As Exception
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = ex.Message
        Finally

            con.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub veiw_students(sender As Object, e As EventArgs) Handles allstudents.ServerClick
        Dim constr As String
        constr = "Data Source= localhost; Initial Catalog= ARTVAULT; User ID=Hammad; Password= Hammad"
        Dim con As New SqlConnection
        con.ConnectionString = constr
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM PERSON WHERE ROLE = 'student'"
        Dim dr As SqlDataReader
        Try
            con.Open()
            dr = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(dr)

            gridview1.DataSource = dt
            gridview1.DataBind()

        Catch ex As Exception
            message_box.Style.Add("opacity", "1")
            message_box.InnerText = ex.Message
        Finally

            con.Close()
            cmd.Dispose()
        End Try
    End Sub
End Class

