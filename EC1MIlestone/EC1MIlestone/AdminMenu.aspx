<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="EC1MIlestone.AdminMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Add Product" OnClick="Button1_Click" /><br />
    <asp:Button ID="Button2" runat="server" Text="Update Product" OnClick="Button2_Click" /><br />
    <asp:Button ID="Button3" runat="server" Text="Delete Product" OnClick="Button3_Click" /><br />
</asp:Content>
