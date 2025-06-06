<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" runat="server">
            <label>Rows:</label>
            <input id="rows" type="text" name="rows" runat="server" />
            <label>Cols:</label>
            <input id="cols" type="text" name="cols" runat="server"/><br />
            <input id="border_op" type="checkbox" name="border" runat="server"/>Put Border Around Cells<br />
            <input id="create" type="submit" name="create" value="Create" runat="server"/>
        </div>
        <asp:table id="table1" runat="server"/>
    </form>
</body>
</html>
