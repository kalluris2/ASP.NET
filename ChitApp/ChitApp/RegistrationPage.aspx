<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="ChitApp.RegistrationForm" MasterPageFile="~/Sites.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="font-family: 'Eras Medium ITC'; font-size: medium; height:2px; font-style: oblique">
             <strong>Customer Registration Form</strong></div>
    <table align="left" class ="auto-style11">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" style="text-align: center">* fields are mandatory</td>
            <td class="">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
     
        <tr>
            <td class="auto-style9">* Registration Number :&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="RegistrationIdTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RegistrationIdTextBox" ErrorMessage="Enter Registration Number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">* First Name :</td>
            <td class="auto-style5">
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FirstNameTextBox" ErrorMessage="Enter First Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">* Last Name :</td>
            <td class="auto-style5">
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LastNameTextBox" ErrorMessage="Enter Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Email :</td>
            <td class="auto-style5">
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Enter Proper Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">* Phone Number :</td>
            <td class="auto-style5">
                <asp:TextBox ID="PhnoTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PhnoTextBox" ErrorMessage="Enter Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Address :</td>
            <td class="auto-style5">
                <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
     
        <tr>
            <td class="auto-style9">* ChitId :</td>
            <td class="auto-style5">
                <asp:TextBox ID="ChitIdTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="ChitIdTextBox" runat ="server" ErrorMessage="Enter ChitId" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
     
            <tr>
            <td class="auto-style7">
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
                </td>
            <td class="auto-style10">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ClearButton" runat="server" Text="Clear" />
                </td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
   </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            height:15%;
            text-align: right;
        }
        .auto-style9 {
            height:5%;
            text-align:right;
        }
        .auto-style10 {
            height: auto;
            width: 181px;
        }
        .auto-style11{
            height: 30%;
            width: 75%;
        }
    </style>
</asp:Content>




