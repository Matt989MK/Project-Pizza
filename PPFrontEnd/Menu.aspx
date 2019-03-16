<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PPFrontEnd.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btCheckout" runat="server" OnClick="btCheckout_Click" style="z-index: 1; left: 18px; top: 263px; position: absolute" Text="Checkout" />
        <asp:Label ID="lbPizza2" runat="server" style="z-index: 1; left: 9px; top: 71px; position: absolute" Text="Pizza 2"></asp:Label>
        <asp:Label ID="lbPizza1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 300px" Text="Pizza 1"></asp:Label>
        <asp:Button ID="btPizza1Add" runat="server" style="z-index: 1; left: 137px; top: 33px; position: absolute" Text="+" />
        <div>
        </div>
        <p>
            <asp:Button ID="btPizza2Add" runat="server" style="z-index: 1; left: 134px; top: 73px; position: absolute" Text="+" />
            <asp:Button ID="btPizza1Remove" runat="server" style="z-index: 1; left: 78px; top: 33px; position: absolute; margin-right: 22px; height: 26px; width: 19px;" Text="-" />
        </p>
        <p>
            <asp:Label ID="lbPizza3" runat="server" style="z-index: 1; left: 11px; top: 110px; position: absolute" Text="Pizza 3"></asp:Label>
            <asp:Button ID="btPizza3Add" runat="server" style="z-index: 1; left: 135px; top: 105px; position: absolute" Text="+" />
            <asp:Button ID="btPizza3Remove" runat="server" style="z-index: 1; left: 78px; top: 106px; position: absolute" Text="-" />
            <asp:TextBox ID="tbCurrentOrder" runat="server" style="z-index: 1; left: 291px; top: 48px; position: absolute; height: 103px; width: 222px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 308px; position: absolute; height: 23px; margin-top: 0px" Text="Products in basket"></asp:Label>
            <asp:Button ID="btPizza2Remove" runat="server" style="z-index: 1; left: 79px; top: 76px; position: absolute; width: 17px; height: 20px" Text="-" />
        </p>
        <asp:Label ID="lbProductsInBasket" runat="server" style="z-index: 1; left: 146px; top: 308px; position: absolute" Text="0"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 292px; top: 22px; position: absolute" Text="Current Order"></asp:Label>
    </form>
</body>
</html>
