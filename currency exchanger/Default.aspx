<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Currency Converter</h1>
            <h2>Enter the value in Dollars to convert</h2>
            <input id="Amount" type="number" step="0.01" min="0" name="name" placeholder="Enter Amount" runat="server" />
            <select id="currency" runat="server"></select>
            <input type="submit" id="convert" value="convert" runat="server"/> 
            <div id="result" runat="server"></div>
        </div>
    </form>
</body>
</html>
