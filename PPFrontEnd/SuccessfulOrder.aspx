<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccessfulOrder.aspx.cs" Inherits="PPFrontEnd.SuccessfulOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbOrderSuccesful" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Order Successful"></asp:Label>
        <p>
            <asp:Button ID="btHomepage" runat="server" OnClick="btHomepage_Click" style="z-index: 1; left: 20px; top: 96px; position: absolute" Text="Go back to Homepage" />
        </p>
    </form>
</body>
</html>
