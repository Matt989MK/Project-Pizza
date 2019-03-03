<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="PPFrontEnd.CustomerDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 145px; top: 208px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 47px; top: 249px; position: absolute; height: 19px; width: 76px" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 48px; top: 292px; position: absolute" Text="Email Address:"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 48px; top: 209px; position: absolute" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 144px; top: 249px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 153px; top: 289px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 144px; top: 333px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 50px; top: 333px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblPhoneNO" runat="server" style="z-index: 1; left: 50px; top: 373px; position: absolute" Text="Phone No:"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 145px; top: 376px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomers" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 50px; top: 161px; position: absolute; height: 37px; width: 345px" Text="Enter Customers Details"></asp:Label>
        <asp:Button ID="btnBackToHomepage" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 53px; top: 439px; position: absolute" Text="Back To Homepage" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnSignUp" runat="server" style="z-index: 1; left: 294px; top: 443px; position: absolute" Text="Sing Up" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
