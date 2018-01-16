<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="HospitalRegistration.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Information</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="registrationnumberLabel" runat="server" Text="Registration No:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="registrationTextBox" runat="server" Height="17px" style="margin-top: 16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="movedToLabel" runat="server" Text="Ward Shifted To:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="movedToTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="dischargedLabel" runat="server" Text="Discharged ON:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="dischargedDateTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submittButton" runat="server" OnClick="submittButton_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="exitButton" runat="server" OnClick="exitButton_Click" Text="Exit" />
            <br />
        </div>
    </form>
</body>
</html>
