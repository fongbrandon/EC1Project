<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="EC1MIlestone.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Login</p><br />
    <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="Usernameentry" runat="server" TextMode="SingleLine"></asp:TextBox>
    <br />
    <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Passwordentry" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" /><br />
    <asp:Label ID="StatusMessage" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>
