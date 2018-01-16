<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientRegistration.aspx.cs" Inherits="HospitalRegistration.PatientRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 120px">
            <asp:Label ID="registrationNumberLabel" runat="server" Text="Registration No:"></asp:Label>
&nbsp;
            <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="firstNameLable" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="firstNameTextBox" runat="server" style="margin-left: 28px" Width="159px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lastNameLable" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="admittedDateLable" runat="server" Text="Admitted Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="admittedDateTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="admittedWardLabel" runat="server" Text="Admitted Ward:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="admittedWardTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="reasonLabel" runat="server" Text="Reason:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="reasonTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="To Update Patient Info Click Update"></asp:Label>
            <br />
            <br />
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
