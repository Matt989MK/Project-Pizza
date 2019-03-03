<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PPFrontEnd.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lbCardExpiryDate" runat="server" style="z-index: 1; left: 34px; top: 47px; position: absolute" Text="Card Expiry Date"></asp:Label>
            <asp:TextBox ID="tbAddress" runat="server" style="z-index: 1; left: 465px; top: 46px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btApplyVoucher" runat="server" style="z-index: 1; left: 970px; top: 15px; position: absolute" Text="Apply Voucher" OnClick="btApplyVoucher_Click" />
            <asp:TextBox ID="tbVoucherCode" runat="server" style="z-index: 1; left: 773px; top: 18px; position: absolute"></asp:TextBox>
            <asp:Label ID="lbCardSecurityCode" runat="server" style="z-index: 1; left: 35px; top: 89px; position: absolute" Text="Card Security Code"></asp:Label>
            <asp:Label ID="lbAddress" runat="server" style="z-index: 1; left: 396px; top: 47px; position: absolute" Text="Address"></asp:Label>
        </p>
        <asp:TextBox ID="tbCardExpiryDate" runat="server" style="z-index: 1; left: 186px; top: 46px; position: absolute" OnTextChanged="tbCardExpiryDate_TextChanged"></asp:TextBox>
        <asp:Label ID="lbCardNumber" runat="server" style="z-index: 1; left: 36px; top: 132px; position: absolute" Text="Card Number"></asp:Label>
        <asp:TextBox ID="tbCardSecurityCode" runat="server" style="z-index: 1; left: 203px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="tbCardNumber" runat="server" style="z-index: 1; left: 165px; top: 129px; position: absolute"></asp:TextBox>
        <asp:Label ID="lbDeliveryTime" runat="server" style="z-index: 1; left: 38px; top: 170px; position: absolute" Text="Delivery Time"></asp:Label>
        <asp:Label ID="lbOrderPrice" runat="server" style="z-index: 1; left: 38px; top: 208px; position: absolute" Text="Order Price"></asp:Label>
        <asp:Label ID="lbDeliveryTimeDisplay" runat="server" style="z-index: 1; left: 169px; top: 174px; position: absolute; height: 23px; width: 37px;" Text="---"></asp:Label>
        <asp:Label ID="lbVoucherCode" runat="server" style="z-index: 1; left: 641px; top: 20px; position: absolute; right: 260px;" Text="Voucher Code"></asp:Label>
        <asp:Label ID="lbOrderPriceDisplay" runat="server" style="z-index: 1; left: 168px; top: 202px; position: absolute; width: 36px" Text="---"></asp:Label>
        <asp:TextBox ID="tbOrders" runat="server" style="z-index: 1; left: 691px; top: 78px; position: absolute; height: 151px; width: 255px; margin-top: 0px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="lbOrder" runat="server" style="z-index: 1; left: 691px; top: 54px; position: absolute" Text="Order"></asp:Label>
        <asp:Button ID="btOrder" runat="server" style="z-index: 1; top: 245px; position: absolute" Text="Order" OnClick="btOrder_Click" />
        <asp:Button ID="btBack" runat="server" style="z-index: 1; left: 97px; top: 245px; position: absolute" Text="Back" OnClick="btBack_Click" />
        <asp:Button ID="btRemoveFromOrderList" runat="server" style="z-index: 1; left: 976px; top: 120px; position: absolute" Text="Remove" OnClick="btRemoveFromOrderList_Click" />
        <asp:Button ID="btAddToOrder" runat="server" style="z-index: 1; left: 975px; top: 83px; position: absolute; width: 68px" Text="Add" OnClick="btAddToOrder_Click" />
        <asp:TextBox ID="tbPhoneNumber" runat="server" style="z-index: 1; left: 491px; top: 82px; position: absolute"></asp:TextBox>
        <asp:Label ID="lbPhoneNumber" runat="server" style="z-index: 1; left: 366px; top: 82px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="lbEmail" runat="server" style="z-index: 1; left: 363px; top: 129px; position: absolute; height: 20px;" Text="Email"></asp:Label>
        <asp:TextBox ID="tbEmail" runat="server" style="z-index: 1; left: 421px; top: 128px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>