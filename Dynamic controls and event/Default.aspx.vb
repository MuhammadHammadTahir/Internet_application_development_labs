
Imports System.Diagnostics
Partial Class _Default
    Inherits System.Web.UI.Page

    Public Sub tablemaker() Handles tablegenrate.ServerClick
        If rows.Value <= "1" Or columns.Value <= "1" Then
            result.InnerText = "Please enter a correct rows and colums number greater than 0"
            result.Style.Add("color", "red")
            result.Style.Add("text-align", "center")
            'Debug.WriteLine(rows.Value & columns.Value)
        Else
            result.InnerText = ""
            Dim rowno As Integer = rows.Value
            Dim colno As Integer = columns.Value
            Dim table As New HtmlTable
            For i As Integer = 1 To rowno
                Dim row As New HtmlTableRow
                For j As Integer = 1 To colno
                    Dim cell As New HtmlTableCell
                    cell.InnerText = "( Row " & i & " Cell " & j & " )"
                    row.Cells.Add(cell)
                Next
                If i Mod 2 = 0 Then
                    row.BgColor = "lightgray"
                End If
                table.Rows.Add(row)
            Next
            If borderoption.Checked Then
                table.Border = 1
                table.BorderColor = "black"
                table.CellPadding = 10
                table.Align = "center"
                table.Style.Add("border-collapse", "collapse")
            End If
            result.Controls.Add(table)

            'Debug.WriteLine(borderoption.Checked)
        End If
    End Sub

End Class
