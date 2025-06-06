<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Searching_customer.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Searching Customer</title>
    <link rel="stylesheet" href="stylesheet.css" type="text/css" />
</head>
<body>
    <form class="registration-form" id="form1" runat="server">
        <div runat="server">
            <h1>Search for a customer</h1>
             <label for="search_name">Enter Name of customer:</label>
             <input class="input-data" id="search_name" type="text" name="search_name" value="" runat="server"/><br />

             <input class="submit-button" id="search" type="submit" value="Submit" runat="server"/><br />
        </div>
       
    </form>
     <div id="result" runat="server">

 </div>
</body>
</html>
