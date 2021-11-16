<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="EC1MIlestone.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Enter the Product ID of the part you want to change<br />
    Product ID<asp:TextBox ID="Productid" runat="server"></asp:TextBox>
    <br />
    Product Name <asp:TextBox ID="Product" runat="server"></asp:TextBox>
    <br />
    Price <asp:TextBox ID="Price" runat="server"></asp:TextBox>
    <br />
    Category <asp:TextBox ID="Category" runat="server"></asp:TextBox>
    <br />
    Description <asp:TextBox ID="prodis" runat="server"></asp:TextBox><br />
    Quantity <asp:TextBox ID="Quantity" runat="server"></asp:TextBox><br />
    <asp:FileUpload ID="pic" runat="server" accept=".png,.jpg,.jpeg,.gif"  /><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Item" />
</asp:Content>
