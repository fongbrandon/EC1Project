<%@ Page Title="List of Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LOPTest.aspx.cs" Inherits="EC1MIlestone.LOPTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EC1AConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater1_ItemCommand" >
        <ItemTemplate>
            <div class="row justify-content-center" style="width:50%">
                <asp:Image class="img-fluid" style="max-width:25%" ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' />
                <div class="row-fluid">ID:<asp:Label ID="Label5" runat="server" Text='<%# Eval("product_id") %>'></asp:Label></div>
                <strong><asp:Label ID="Label1" runat="server" Text='<%# Eval("product_name") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label></strong><br />
                <div class="row-fluid">Price: <asp:Label ID="Label2" runat="server" Text='<%# Eval("price") %>'></asp:Label></div><br />
                <div class="row-fluid">Category: <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text='<%# Eval("category") %>'></asp:Label></div><br />
                <div class="row-fluid">Description:<asp:Label ID="Label4" runat="server" Text='<%# Eval("product_dis") %>'></asp:Label></div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" CommandName="add" CommandArgument=<%# Eval("product_id") %> />
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
