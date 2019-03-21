<%@ Page Title="" Language="C#" MasterPageFile="~/PizzaProject.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="PPFrontEnd.AddStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="TxtFirstName" runat="server" style="z-index: 1; left: 114px; top: 68px; position: absolute; width: 231px;"></asp:TextBox>
    <br />
    <br />

    <br />
    <br />
    <br />
    <asp:Label ID="LblFirstName" runat="server" style="z-index: 1; left: 291px; top: 152px; position: absolute; width: 110px" Text="First Name:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 290px; top: 207px; position: absolute; width: 91px" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 112px; top: 126px; position: absolute; width: 241px"></asp:TextBox>
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 590px; top: 164px; position: absolute; width: 113px" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <asp:Label ID="lblSex" runat="server" style="z-index: 1; left: 292px; top: 258px; position: absolute" Text="Sex:"></asp:Label>
    <asp:TextBox ID="txtSex" runat="server" style="z-index: 1; left: 59px; top: 175px; position: absolute; width: 132px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 292px; top: 305px; position: absolute; width: 117px; margin-bottom: 0px" Text="Date Of Birth:"></asp:Label>
    <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 141px; top: 221px; position: absolute; width: 223px"></asp:TextBox>
    <br />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 590px; top: 214px; position: absolute; width: 115px" Text="Cancel" OnClick="btnCancel_Click" />
    <br />
    <br />
    <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 291px; top: 354px; position: absolute; width: 80px" Text="Address:"></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 88px; top: 270px; position: absolute; width: 360px"></asp:TextBox>
    <br />
    <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 293px; top: 399px; position: absolute; width: 85px" Text="Email:"></asp:Label>
    <br />
    <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 84px; top: 316px; position: absolute; width: 334px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 292px; top: 445px; position: absolute" Text="Phone Number:"></asp:Label>
    <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 143px; top: 363px; position: absolute; width: 268px"></asp:TextBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 693px; top: 509px; position: absolute; width: 157px">Error</asp:Label>
    <br />
    <br />
    <br />
    <br />

</asp:Content>
