
Partial Class Default2
    Inherits System.Web.UI.Page
    Private Sub create_table(sender As Object, e As EventArgs) Handles create.ServerClick
        table1.Controls.Clear()
        For i As Integer = 0 To (rows.Value - 1)
            Dim row As New TableRow()
            For j As Integer = 0 To (cols.Value - 1)
                Dim cell As New TableCell()
                Dim label As New Label()
                label.Text = "Example Cell(" & i & "," & j & ")"
                Dim img As New Image()
                img.ImageUrl = "./img.png"
                cell.Controls.Add(label)
                cell.Controls.Add(img)
                row.Controls.Add(cell)
                If border_op.Checked Then
                    cell.BorderStyle = BorderStyle.Inset
                    cell.BorderWidth = Unit.Pixel(1)
                End If
            Next
            table1.Controls.Add(row)
        Next

        If border_op.Checked Then
            table1.BorderStyle = BorderStyle.Inset
            table1.BorderWidth = Unit.Pixel(1)

        End If
    End Sub
End Class
