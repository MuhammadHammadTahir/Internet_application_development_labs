<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Update_Customer.aspx.vb" Inherits="Update_Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Customer</title>
    <link rel="stylesheet" href="stylesheet.css" type="text/css" />
</head>
<body>
    <form class="registration-form" id="form1" runat="server">
        <div runat="server">
            <h1>Update Customer</h1>
            <label for="search_cutomer">Enter Customer ID:</label>
            <input class="input-data" id="search_customer" type="text" name="search_customer" value="" runat="server" /><br />

            <input class="submit-button" id="search" type="submit" value="Find Customer" runat="server" /><br />

            <div runat="server" id="MessageBox">

            </div>

            <label>
                First Name:
            <input type="text" id="first_name" name="first_name" class="input-data" runat="server" /></label><br />
            <label>
                Last Name:
            <input type="text" id="last_name" name="last_name" class="input-data" runat="server" /></label><br />
            <label>
                Email:
            <input type="email" id="email" name="email" class="input-data" runat="server" /></label><br />
            <label>
                Phone Number:
            <input type="text" id="phone" name="phone" class="input-data" runat="server" /></label><br />
            <label>
                City:
            <input type="text" id="city" name="city" class="input-data" runat="server" /></label><br />
            <label>
                State (2-letter):
            <input type="text" id="state" name="state" class="input-data" maxlength="2" runat="server" /></label><br />
            <label>
                Postal Code:
            <input type="text" id="postal_code" name="postal_code" class="input-data" runat="server" /></label><br />
            <label>
                Country:
            <input type="text" id="country" name="country" class="input-data" runat="server" /></label><br />
            <label for="password">
                Password:
        <input type="text" id="password" name="password" class="input-data" runat="server" /></label><br />
            <input id="update_btn" class="submit-button" type="submit" runat="server" value="Update Customer" />
        </div>

    </form>
</body>
</html>
