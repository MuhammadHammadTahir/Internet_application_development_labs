<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Customer_reg.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Customer Registration</title>
    <link rel="stylesheet" href="stylesheet.css" type="text/css" />
</head>
<body>
    <form class="registration-form" id="form1" runat="server">
        <h1>New Customer Registration</h1>
        <div id="message_box" runat="server"></div>
        <label>
            Customer ID:
            <input type="text" id="person_id" name="customer_id" class="input-data" required="required" runat="server" /></label><br />
        <label>
            First Name:
            <input type="text" id="first_name" name="first_name" class="input-data" required="required" runat="server" /></label><br />
        <label>
            Last Name:
            <input type="text" id="last_name" name="last_name" class="input-data" required="required" runat="server" /></label><br />
        <label>
            Email:
            <input type="email" id="email" name="email" class="input-data" required="required" runat="server" /></label><br />
        <label>
            Phone Number:
            <input type="text" id="phone" name="phone" class="input-data" required="required" runat="server" /></label><br />
        <label>
            Gender:
                <select id="gender" name="gender" class="input-data" required="required" runat="server">
                    <option value="M">Male</option>
                    <option value="F">Female</option>
                    <option value="O">Other</option>
                </select>
        </label>
        <br />
        <label>
            City:
            <input type="text" id="city" name="city" class="input-data" required="required" runat="server" /></label><br />
        <label>
            State (2-letter):
            <input type="text" id="state" name="state" class="input-data" maxlength="2" required="required" runat="server" /></label><br />
        <label>
            Postal Code:
            <input type="text" id="postal_code" name="postal_code" class="input-data" required="required" runat="server" /></label><br />
        <label>
            Country:
            <input type="text" id="country" name="country" class="input-data" required="required" runat="server" /></label><br />
        <label for="role">Role:</label>
        <select id="role" class="input-data" runat="server" required>
            <option value="" selected disabled>User</option>
            <option value="Artist">Artist</option>
            <option value="Customer">Customer</option>
        </select>
        Password:
            <input type="password" id="password" name="password" class="input-data" required="required" runat="server" /></label><br />
        <input id="add" class="submit-button" type="submit" runat="server">Register</input>
    </form>

</body>
</html>
