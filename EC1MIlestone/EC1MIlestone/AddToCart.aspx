<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="EC1MIlestone.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }
    </style>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EC1AConnectionString %>" SelectCommand="SELECT * FROM [Cart]"></asp:SqlDataSource>
    <div class="col">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="cartID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="cartID" HeaderText="cartID" InsertVisible="False" ReadOnly="True" SortExpression="cartID" />
                <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                <asp:BoundField DataField="total_amount" HeaderText="total_amount" SortExpression="total_amount" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
                <asp:BoundField DataField="USERID" HeaderText="USERID" SortExpression="USERID" />
                <asp:BoundField DataField="price_" HeaderText="price_" SortExpression="price_" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
