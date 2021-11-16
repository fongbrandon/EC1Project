<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="EC1MIlestone.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Product Name <asp:TextBox ID="Product" runat="server"></asp:TextBox>
    <br />
    Product ID<asp:TextBox ID="Productid" runat="server"></asp:TextBox>
    <br />
    Price <asp:TextBox ID="Price" runat="server"></asp:TextBox>
    <br />
    Category <asp:TextBox ID="Category" runat="server"></asp:TextBox>
    <br />
    Description <asp:TextBox ID="prodis" runat="server"></asp:TextBox><br />
    Quantity <asp:TextBox ID="Quantity" runat="server"></asp:TextBox><br />
    <asp:FileUpload ID="pic" runat="server" accept=".png,.jpg,.jpeg,.gif"  /><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Item" />
&nbsp;
</asp:Content>
