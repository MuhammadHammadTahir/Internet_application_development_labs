
Imports System.ComponentModel

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim list As New CheckBoxList
        'Dim list As New RadioButtonList
        list.ID = "CheckBoxList1"
        List.Items.Add("C")
        list.Items.Add("C++")
        list.Items.Add("C#")
        list.Items.Add("VB.NET")
        list.Items.Add("Pascal")
        form1.Controls.Add(list)
        Dim button As New Button
        button.ID = "Button1"
        button.Text = "OK"
        AddHandler button.Click, AddressOf Button1_Click
        form1.Controls.Add(button)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim list As CheckBoxList = CType(form1.FindControl("CheckBoxList1"), CheckBoxList)
        'Dim list As RadioButtonList = CType(form1.FindControl("CheckBoxList1"), RadioButtonList)
        Dim display As New HtmlGenericControl("div")

        Dim lable_1 As New Label
        lable_1.ID = "Label1"
        lable_1.Text = "You choose:<br>"
        display.Controls.Add(lable_1)
        form1.Controls.Add(display)

        'Dim selecteditems As New RadioButtonList

        For Each item As ListItem In list.Items
            If item.Selected = True Then
                Dim selectedItem As New Label
                selectedItem.Text = item.Text & "<br>"
                display.Controls.Add(selectedItem)
                'selecteditems.Items.Add(item)
            End If
        Next

        'For Each item As ListItem In selecteditems.Items
        'list.Items.Remove(item)
        'Next
    End Sub
End Class
