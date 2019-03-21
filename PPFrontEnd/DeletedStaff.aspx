<%@ Page Title="" Language="C#" MasterPageFile="~/PizzaProject.Master" AutoEventWireup="true" CodeBehind="DeletedStaff.aspx.cs" Inherits="PPFrontEnd.DeletedStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblDelete" runat="server" style="z-index: 1; left: 354px; top: 81px; position: absolute" Text="Are you sure you want to delete this staff member?"></asp:Label>
    <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 354px; top: -27px; position: absolute; height: 33px; width: 97px" Text="Yes" />
    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 485px; top: -25px; position: absolute; height: 29px; width: 91px" Text="No" />
</asp:Content>
