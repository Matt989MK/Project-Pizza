<%@ Page Title="" Language="C#" MasterPageFile="~/PizzaProject.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="PPFrontEnd.Staff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Button ID="btnAddStaff" runat="server" style="z-index: 1; left: 94px; top: 96px; position: absolute; width: 135px; height: 31px;" Text="Add Staff" OnClick="btnAddStaff_Click" />
        <asp:Button ID="btnDeleteStaff" runat="server" style="z-index: 1; left: 253px; top: 94px; position: absolute; width: 125px; height: 34px" Text="Delete Staff" OnClick="btnDeleteStaff_Click" />
        <asp:Button ID="btnUpdateStaff" runat="server" style="z-index: 1; left: 410px; top: 95px; position: absolute; width: 122px; height: 31px; right: 807px;" Text="Update Staff" />
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 93px; top: 163px; position: absolute; height: 252px; width: 431px"></asp:ListBox>
    </p>
</asp:Content>
