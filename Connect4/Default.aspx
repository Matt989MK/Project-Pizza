<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="z-index: 102; left: 99px; width: 165px; position: absolute; top: 341px;
            height: 29px">
            <asp:Label ID="lblRed" runat="server" Style="z-index: 100; left: 0px; position: absolute;
                top: 0px" Text="Enter a number 1 - 7"></asp:Label>
            <br />
            <asp:TextBox ID="txtRed" runat="server" Width="55px"></asp:TextBox><asp:Button ID="btnRed" runat="server" Text="Go" /><br />
            <br />
            <asp:Image ID="imgRed" runat="server" ImageUrl="~/red.gif" />&nbsp;</div>
        <asp:Label ID="lblMessage" runat="server" Style="z-index: 100; left: 100px; position: absolute;
            top: 316px" Width="394px" ForeColor="Red"></asp:Label>
        <div style="z-index: 103; left: 285px; width: 163px; position: absolute; top: 341px;
            height: 100px">
            <asp:Label ID="lblYellow" runat="server" Style="z-index: 100; left: 0px; position: absolute;
                top: 0px" Text="Enter a number 1 - 7"></asp:Label>
            <br />
            <asp:TextBox ID="txtYellow" runat="server" Width="55px"></asp:TextBox>
            <asp:Button ID="btnYellow" runat="server" Text="Go" />
            <br />
            <br />
            <asp:Image ID="imgYellow" runat="server" ImageUrl="~/yellow.gif" /></div>
        &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" Style="z-index: 104; left: 245px; position: absolute;
            top: 464px" Text="Clear The Board" Width="137px" />
    
    </div>
    </form>
</body>
</html>
