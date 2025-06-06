<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RegisterEmployee.aspx.vb" Inherits="Admin_RegisterEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Register a Employee</title>
     <link rel="icon" type="image/png" href="../logo_new.png" />
     <link rel="stylesheet" type="text/css" href="../StyleSheet.css" />
</head>
<body>
     <img accesskey="" src="logo_new.png" alt="logo" id="logo" />

 <form id="form1" runat="server">
     
     <div id="message_box" runat="server"></div>
     
     <h2>Register a Employee</h2>
      

     <div class="grid-container">
         <div runat="server">
             <label for="person_id">CNIC:</label>
             <input id="person_id" type="text" placeholder="e.g., 12345-1234567-1" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="first_name">First Name:</label>
             <input id="first_name" type="text" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="last_name">Last Name:</label>
             <input id="last_name" type="text" class="form-control" runat="server" />
         </div>

         <div runat="server">
             <label for="email">Email:</label>
             <input id="email" type="email" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="phone">Phone No:</label>
             <input id="phone" type="text" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="gender">Gender:</label>
             <select id="gender" class="form-control" runat="server" required>
                 <option value="M">M</option>
                 <option value="F">F</option>
                 <option value="O">O</option>
             </select>
         </div>

         <div runat="server">
             <label for="city">City:</label>
             <input id="city" type="text" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="state">State:</label>
             <input id="state" type="text" placeholder="e.g., CA" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="postal_code">Postal Code:</label>
             <input id="postal_code" type="text" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="country">Country:</label>
             <input id="country" type="text" class="form-control" runat="server" required />
         </div>

         <div runat="server">
             <label for="password">Password:</label>
             <input id="password" type="password" class="form-control" runat="server" required />
         </div>
     </div>

     <div class="submit-container" runat="server">
         <input id="add" type="submit" value="Submit" runat="server" />
     </div>
 </form>
</body>
</html>
