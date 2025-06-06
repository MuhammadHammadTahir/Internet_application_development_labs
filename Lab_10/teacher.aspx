<%@ Page Language="VB" AutoEventWireup="false" CodeFile="teacher.aspx.vb" Inherits="teacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="msg" runat="server">
            <h1>teacher</h1>
            <div id="message_box" runat="server"></div>
             <label id="num" runat="server">Question no</label>
            <input id="ques_num" runat="server" />
            <label id="ques" runat="server">Write Question</label>
            <textarea id="question" runat="server"></textarea>
            <label id="op1" runat="server">option1</label>
            <input id="option1" type="text" name="option1" value="" runat="server" />
            <label id="op2" runat="server">option2</label>
            <input id="option2" type="text" name="option2" value="" runat="server" />
            <label id="op3" runat="server">option3</label>
            <input id="option3" type="text" name="option3" value="" runat="server" />
            <label id="op4" runat="server">option4</label>
            <input id="option4" type="text" name="option4" value="" runat="server" />
            <label id="corr" runat="server">correct answer</label>
            <input id="correct" type="text" name="correct" value="" runat="server" />
            <input id="add" type="submit" value="Add" runat="server" /> 

        </div>
    </form>
</body>
</html>
