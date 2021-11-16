<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="EC1MIlestone.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Login</p><br />
    <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="Usernameentry" runat="server" TextMode="SingleLine"></asp:TextBox>
    <br />
    <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Passwordentry" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>
