<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AllCustomers.aspx.vb" Inherits="AllCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Customer</title>
    <link rel="stylesheet" href="stylesheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>All Customer Data</h1>
        <div runat="server">
            <table runat="server" id="display">
                <tr>
                    <th>PERSON_ID</th>
                    <th>FIRST_NAME</th>
                    <th>LAST_NAME</th>
                    <th>EMAIL</th>
                    <th>PHONE_NO</th>
                    <th>GENDER</th>
                    <th>CITY</th>
                    <th>STATE</th>
                    <th>POSTAL_CODE</th>
                    <th>COUNTRY</th>
                    <th>ROLE</th>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
