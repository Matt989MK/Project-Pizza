﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOrderDisplay.aspx.cs" Inherits="PPFrontEnd.AdminOrderDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="tbDisplayRecords" runat="server" OnTextChanged="tbDisplayRecords_TextChanged" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 270px; width: 920px" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>
