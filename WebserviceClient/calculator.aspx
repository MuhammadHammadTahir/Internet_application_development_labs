<%@ Page Language="VB" AutoEventWireup="false" CodeFile="calculator.aspx.vb" Inherits="calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Math Service Client</title>
    <style>
        body {
            font-family: Arial;
            margin: 20px;
        }

        .calculator {
            width: 300px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .input-group {
            margin-bottom: 15px;
        }

        label {
            display: inline-block;
            width: 80px;
        }

        input[type="text"] {
            width: 150px;
            padding: 5px;
        }

        .btn {
            padding: 8px 15px;
            background: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .btn:hover {
                background: #45a049;
        }

        .result {
            margin-top: 20px;
            font-weight: bold;
            background-color: aqua;
        }

        .error {
            color: red;
        }
    </style>
</head>
<body>
    <div class="calculator">
        <h2>Math Service Client</h2>
        <form id="form1" runat="server">
            <div class="input-group">
                <label for="txtNum1">Number 1:</label>
                <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            </div>
            <div class="input-group">
                <label for="txtNum2">Number 2:</label>
                <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn" />
                <asp:Button ID="btnSubtract" runat="server" Text="Subtract" CssClass="btn" />
                <asp:Button ID="btnMultiply" runat="server" Text="Multiply" CssClass="btn" />
                <asp:Button ID="btnDivide" runat="server" Text="Divide" CssClass="btn" />
            </div>

            <div class="result">
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
