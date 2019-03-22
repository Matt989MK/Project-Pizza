<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePage.aspx.cs" Inherits="PPFrontEnd.DeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btDelete" runat="server" OnClick="btDelete_Click" style="z-index: 1; left: 10px; top: 173px; position: absolute" Text="Delete" />
        <asp:Button ID="btBack" runat="server" style="z-index: 1; left: 145px; top: 189px; position: absolute" Text="Back" OnClick="btBack_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Find a record number"></asp:Label>
        <asp:ListBox ID="lstDeleteRecord" runat="server" DataSourceID="SqlDataSource1" DataTextField="OrderId" DataValueField="OrderId" style="z-index: 1; left: 22px; top: 84px; position: absolute; height: 82px; width: 104px"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT [OrderId] FROM [tblOrder]"></asp:SqlDataSource>
        <asp:Label ID="lbError" runat="server" style="z-index: 1; left: 63px; top: 273px; position: absolute"></asp:Label>
    </form>
</body>
</html>
