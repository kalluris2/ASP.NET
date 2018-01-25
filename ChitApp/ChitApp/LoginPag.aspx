<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPag.aspx.cs" Inherits="ChitApp.LoginPag" MasterPageFile="~/Sites.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="auto-style2">
            <em><strong>Employee Login Page</strong></em></div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="auto-style2">
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
           </tr>
              <tr>
                <td class="auto-style2">* fields are mandatory</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
           </tr>
           <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
           </tr>
            <tr>
                <td class="auto-style7">* Employee Id:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="EmployeeIdTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Employee Id" ControlToValidate="EmployeeIdTextBox"></asp:RequiredFieldValidator>
                   
                </td>
            </tr>
            <tr>
                <td class="auto-style7">*&nbsp;&nbsp; Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>                    
                    
                </td>
            </tr>
            <tr>
                <td class="">
                    &nbsp;</td>
                <td class="">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="ClearButton" runat="server" Text="Clear" />
                </td>
                <td>&nbsp;</td>
           </tr>
                  <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
           </tr>
           <tr>
                <td class="">&nbsp;</td>
                <td>&nbsp; </td>
                <td>&nbsp;</td>
           </tr>
        </table>
    </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            text-align: right;
        }
    </style>
</asp:Content>


