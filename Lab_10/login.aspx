<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <div id="msg" runat="server"></div>
            <input id="username" type="text" runat="server" name="name" value="" placeholder="enter your cnic"/>
            <input id="password" type="password" runat="server" name="password" value="" />
            <input id="login_btn" type="submit" value="Login" runat="server" />
        </div>
    </form>
</body>
</html>
