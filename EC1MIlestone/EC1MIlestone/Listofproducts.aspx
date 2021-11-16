<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listofproducts.aspx.cs" Inherits="EC1MIlestone.Listofproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EC1AConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    <div class="col">
        <asp:GridView ID="Gridview2" runat="server" AutoGenerateColumns="False" DataKeyNames="product_id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="Gridview2_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="product_id" HeaderText="ID" ReadOnly="true" SortExpression="product_id" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col-lg-10">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_name") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12">

                                            Price:<asp:Label ID="Label2" runat="server" Text='<%# Eval("price") %>'></asp:Label>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12">

                                            Category:
                                            <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text='<%# Eval("category") %>'></asp:Label>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12">

                                            Description:<asp:Label ID="Label4" runat="server" Text='<%# Eval("product_dis") %>'></asp:Label>
                                            <br />
                                            <asp:Label ID="Label5" runat="server" Text="QuantityL"></asp:Label>
                                            <asp:DropDownList ID="Quantity" runat="server">
                                                <asp:ListItem>1</asp:ListItem>
                                                <asp:ListItem>2</asp:ListItem>
                                                <asp:ListItem>3</asp:ListItem>
                                                <asp:ListItem>4</asp:ListItem>
                                                <asp:ListItem>5</asp:ListItem>
                                            </asp:DropDownList>
                                            
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12">
                                            
                                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" CommandName="add" CommandArgument=<%# Eval("product_id") %> />
                                            
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-2">
                                    <asp:Image class="img-fluid p-2" ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>
    </div>
</asp:Content>
