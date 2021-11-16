<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="EC1MIlestone.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="UserNameLabel" runat="server" Text="Username"></asp:Label><br />
    <asp:TextBox ID="Username" runat="server"></asp:TextBox><br />
    <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label><br />
    <asp:TextBox ID="Password" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label><br />
    <asp:TextBox ID="ConfirmPassword" runat="server"></asp:TextBox><br />
    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="These password do not match" ControlToCompare="Password" ControlToValidate="ConfirmPassword"></asp:CompareValidator><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="This password is not strong" ValidationExpression="^(?=.*[A-Z].*[A-Z])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$" ControlToValidate="Password"></asp:RegularExpressionValidator><br />
    <!--<asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="1">Staff</asp:ListItem>
        <asp:ListItem Value="2">Customer</asp:ListItem>
    </asp:RadioButtonList>-->
    <asp:Button ID="Sign_Up" runat="server" Text="Sign Up" OnClick="Sign_Up_Click" />
    <asp:Label ID="StatusMessage" runat="server" Text=""></asp:Label>
</asp:Content>
