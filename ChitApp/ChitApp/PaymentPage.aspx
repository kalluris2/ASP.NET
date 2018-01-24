<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" MasterPageFile="~/Sites.Master" Inherits="ChitApp.PaymentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="font-family: 'Lucida Calligraphy'; font-size: medium; font-style: inherit" class="auto-style9">
            <strong>Payment Page</strong></div>
    <table align="center" class="auto-style12">

        <tr>
            <td class="auto-style13">* fields are mandatory</td>
            <td class="">&nbsp;</td>
            <td class="">&nbsp;</td>
        </tr>
        <tr>
            <td class="">&nbsp;</td>
            <td class="">&nbsp;</td>
            <td class="">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">* Payment Id :</td>
            <td class="auto-style4">
                <asp:TextBox ID="PaymentIdTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="PaymentIdTextBox" runat="server" ErrorMessage="Enter Payment Id" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">* Registration Number :</td>
            <td class="auto-style7">
                <asp:TextBox ID="RegistrationNoTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="RegistrationNoTextBox"  runat="server" ErrorMessage="Enter Registration Number" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">* Payment Amount :</td>
            <td class="auto-style4">
                <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="AmountTextBox" runat="server" ErrorMessage="Enter Amount" ForeColor="#FF3300" ValidationExpression="&quot;[0-9]&quot;"></asp:RegularExpressionValidator>
            </td>
        </tr>
               <tr>
            <td class="auto-style14">* Payment Date :</td>
            <td class="auto-style4">
                <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/calender.jpg" OnClick="ImageButton1_Click" />
&nbsp;
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Width="220px" OnDayRender="Calendar1_DayRender">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
                   </td>
            <td class="auto-style16">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="DateTextBox" runat="server" ErrorMessage="Enter Date" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
        </tr>
        <tr>
            <td class="auto-style14">* EMI Number :</td>
            <td class="auto-style4">
                <asp:TextBox ID="EmiTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="EmiTextBox" runat="server" ErrorMessage="Enter Emi number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">* Paid By :</td>
            <td class="auto-style4">
                <asp:TextBox ID="PaidByTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PaidByTextBox" ErrorMessage="Enter Paid By" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
               <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="PayButton" runat="server" Text="Pay" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 
            </td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
    </table>
  </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style13 {
            width: 70%;
            height: 30%;
        }
        .auto-style14 {
            height: auto;
            width: auto;
            text-align:right;
        }
        .auto-style16 {
            width: 169px;
        }
    </style>
</asp:Content>


