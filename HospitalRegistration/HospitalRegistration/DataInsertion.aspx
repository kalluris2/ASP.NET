<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataInsertion.aspx.cs" Inherits="HospitalRegistration.DataInsertion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:GridView ID="insertDataGridView" runat="server" AutoGenerateColumns="false" Height="316px" Width="631px">
               <Columns>
                   <asp:TemplateField HeaderText="RegistrationId">
				        <ItemTemplate>
					        <asp:Label ID="lable1" runat="server" Text='<%# Eval("RegistrationId") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="FirstName">
				        <ItemTemplate>
					        <asp:Label ID="lable2" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="LastName">
				        <ItemTemplate>
					        <asp:Label ID="lable3" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="AdmittedDate">
				        <ItemTemplate>
					        <asp:Label ID="lable4" runat="server" Text='<%# Eval("AdmittedDate") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="AdmittedWard">
				        <ItemTemplate>
					        <asp:Label ID="lable5" runat="server" Text='<%# Eval("AdmittedWard") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="Reason">
				        <ItemTemplate>
					        <asp:Label ID="lable6" runat="server" Text='<%# Eval("Reason") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="Wardshiftedto">
				        <ItemTemplate>
					        <asp:Label ID="lable7" runat="server" Text='<%# Eval("Wardshiftedto") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
                   <asp:TemplateField HeaderText="Dischargedate">
				        <ItemTemplate>
					        <asp:Label ID="lable8" runat="server" Text='<%# Eval("Dischargedate") %>'></asp:Label>
				        </ItemTemplate>
			       </asp:TemplateField>
               </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />
            <br />
            <br />
           
        </div>
    </form>
</body>
</html>
