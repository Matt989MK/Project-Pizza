﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FailedOrder.aspx.cs" Inherits="PPFrontEnd.FailedOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbOrderFailed" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Order Failed"></asp:Label>
        <asp:Button ID="btTryAgain" runat="server" OnClick="btTryAgain_Click" style="z-index: 1; left: 224px; top: 118px; position: absolute" Text="Try to pay again" />
        <asp:Button ID="btHomepage" runat="server" OnClick="btHomepage_Click" style="z-index: 1; left: 12px; top: 116px; position: absolute" Text="Go back to homepage" />
    </form>
</body>
</html>
