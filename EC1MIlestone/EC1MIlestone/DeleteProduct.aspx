<%@ Page Title="Delete Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="EC1MIlestone.DeleteProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Delete Product</h3>
    Product ID: <asp:TextBox ID="Product" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Item" />
</asp:Content>
