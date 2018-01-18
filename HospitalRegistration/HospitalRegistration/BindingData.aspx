<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BindingData.aspx.cs" Inherits="HospitalRegistration.BindingData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="DataGridView" runat="server" AllowSorting="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" Height="276px" OnRowEditing="DataGridView_RowEditing" OnRowUpdated="DataGridView_RowUpdated" Width="557px">
        </asp:GridView>
    </form>
</body>
</html>
