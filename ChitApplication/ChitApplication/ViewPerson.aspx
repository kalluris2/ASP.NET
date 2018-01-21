<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPerson.aspx.cs" Inherits="ChitApplication.ViewPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="PeopleRegisteredLabel" runat="server" Text="To list Total No Of Peolpe registered"></asp:Label>
&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                <asp:ListItem Value="">--Select ChitId--</asp:ListItem>
                <asp:ListItem Text="2lks" Value="2lks"></asp:ListItem>
                <asp:ListItem Text="1lk" Value="1lk"></asp:ListItem>
                <asp:ListItem Text="50k" Value="50k"></asp:ListItem>
                <asp:ListItem Text="25k" Value="25k"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
