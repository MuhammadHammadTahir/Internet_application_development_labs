<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="display:flex; flex-direction:column; align-items:center; justify-content:center">
    <h2 style="font-family:Arial; justify-content:center; display: flex">Table Generator</h2>
    <form id="form1" runat="server">
        <div style="display:flex; align-items:center; justify-content:center">
            <input style="padding: 10px; width: 200px;" type="number" id="rows" name="rows" placeholder="Enter Number of rows" runat="server"/>
            <input style="margin-left:10px; padding: 10px; width: 200px;" type="number" id="columns" name="cols" placeholder="Enter Number of columns" runat="server"/>
            <input style="width: 20px; height: 20px; transform: scale(1); margin-left: 10px " type="checkbox" id="borderoption" runat="server" /> 
            <label for="borderoption">Table Formatting</label></br>
        </div>
        <div style="width: 100%; display: flex; justify-content: center; padding: 20px;">
            <input style="padding: 10px 20px; font-size: 16px; cursor: pointer; background-color: #007bff; color: white; border: none; transition: background 0.3s; border-radius: 5px;" type="submit" id="tablegenrate" value="Create" runat="server" />
        </div>    
        <div style="font-family:Arial" id="result" runat="server"></div>
    </form>
</body>
</html>
