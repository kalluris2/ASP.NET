<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentForm.aspx.cs" Inherits="ChitApplication.PaymentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="PaymentIdLabel" runat="server" Text="Payment ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PaymentIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="RegistrationNumberLabel" runat="server" Text="Registration Number:"></asp:Label>
&nbsp;
            <asp:TextBox ID="RegistrationTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Chit Id:"></asp:Label>
&nbsp;&nbsp;
            <asp:RadioButtonList ID="ChitIdRadioButton" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="2lks" Value="2lks"></asp:ListItem>
                <asp:ListItem Text="1lk" Value="1lk"></asp:ListItem>
                <asp:ListItem Text="50k" Value="50k"></asp:ListItem>
                <asp:ListItem Text="25k" Value="25k"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="AmountPaidLabel" runat="server" Text="Amount Paid:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="AmountPaidTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PaidDateLabel" runat="server" Text="Paid Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PaidDateTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PaidByLabel" runat="server" Text="Paid By:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PaidByTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="EMI No:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="EmiNoTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="PayButton" runat="server" OnClick="PayButton_Click" Text="Pay" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ClearButton" runat="server" Text="clear" />
            <br />
        </div>
    </form>
</body>
</html>
