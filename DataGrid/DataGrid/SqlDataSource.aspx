<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataSource.aspx.cs" Inherits="DataGrid.SqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RegistrationId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="RegistrationId" HeaderText="RegistrationId" ReadOnly="True" SortExpression="RegistrationId" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="AdmittedDate" HeaderText="AdmittedDate" SortExpression="AdmittedDate" />
                    <asp:BoundField DataField="AdmittedWard" HeaderText="AdmittedWard" SortExpression="AdmittedWard" />
                    <asp:BoundField DataField="Reason" HeaderText="Reason" SortExpression="Reason" />
                    <asp:BoundField DataField="DischargeDate" HeaderText="DischargeDate" SortExpression="DischargeDate" />
                    <asp:BoundField DataField="MovedTo" HeaderText="MovedTo" SortExpression="MovedTo" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HospitalConnectionString %>" SelectCommand="SELECT * FROM [PatientInformation]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
