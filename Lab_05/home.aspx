<%@ Page Language="VB" AutoEventWireup="false" CodeFile="home.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ARTVAULT</title>
    <link rel="stylesheet" href="stylesheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ART VAULT</h1>
            <ul>
                <li><a href="./Customer_reg.aspx">Customer Registration</a></li>
                <li><a href="./Searching_customer.aspx">Searching for Customer</a></li>
                <li><a href="./AllCustomers.aspx">Show All Customers</a></li>
                <li><a href="./Update_Customer.aspx">Update Customer Data</a></li>
            </ul>
        </div>
        <div>
            <p>
                <strong>IAD Problem Statement</strong><br />
                Consider the database development project developed during previous semester. A complete database design and development was carried out in previous semester project as detailed in your project report in printed form. 
                In addition during one of previous labs (see reference below) you were required to develop web interfaces on paper and then develop html prototypes for various functionalities of your database project mentioned as above. 
                Now the next task is to transform paper based and html based prototype interfaces into full scale working web forms for realization of various functionalities of your project. Ideally you are required to develop all web forms for implementing various project functionalities. 
                <br /><strong> Reference: Lab 3 Q1) </strong>
                Consider the Pine Valley Furniture Company database designed and implemented using structured query language
                during previous semester. Try to recall major relations in the database (CUSTOMER_T, ORDER_T, ORDER_LINE_T,
                and PRODUCT_T).
                <br />
                <br />
                There is a need to implement a web-based solution for the above-mentioned database. The web-based solution must
                incorporate the following functionalities:
                <br />
                i) New Customer Registration
                <br />
                ii) Searching of Products
                <br />
                iii) Products Selection and Order Placement
                <br />
                iv) Product Catalog Update
                <br />
                v) Payment Provision
                <br />
                <br />
                As a first step, design the above-mentioned (i) to (v) user interfaces using paper and pencil.
                Then write appropriate HTML for creating the interface prototypes.
                Create links for navigation among pages, design a styled menu, add help pages,
                and test interfaces in the browser. Experiment with style sheets.
            </p>
        </div>
    </form>
</body>
</html>
