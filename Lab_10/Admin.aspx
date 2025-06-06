<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin.aspx.vb" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Admin</h1>
<div id="message_box" runat="server">
</div>
            <input id="allteachers" type="submit" value="All Teachers" runat="server" />
            <input id="allstudents" type="submit" value="All Students" runat="server" />
            <asp:GridView ID="gridview1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
