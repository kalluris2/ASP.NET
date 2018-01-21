<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ChitApplication.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="EmployeeIdLabel" runat="server" Text="Employee Id:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="EmployeeIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ClearButton" runat="server" Text="Clear" />
        </div>
    </form>
</body>
</html>
