<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOrderDisplay.aspx.cs" Inherits="PPFrontEnd.AdminOrderDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btHomepage" runat="server" OnClick="btHomepage_Click" style="z-index: 1; left: 10px; top: 256px; position: absolute" Text="Homepage" />
        <asp:ListBox ID="lbOrderList" runat="server" style="z-index: 1; left: 19px; top: 15px; position: absolute; height: 211px; width: 415px"></asp:ListBox>
        <asp:Button ID="btGetRecords" runat="server" OnClick="btGetRecords_Click" style="z-index: 1; left: 127px; top: 255px; position: absolute" Text="Get Records" />
        <asp:Button ID="btDeleteRecord" runat="server" OnClick="btDeleteRecord_Click" style="z-index: 1; left: 259px; top: 256px; position: absolute" Text="Delete Records" />
    </form>
</body>
</html>
