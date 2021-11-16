<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LOP.aspx.cs" Inherits="EC1MIlestone.LOP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style class="fr">
        .atc {
            background-color: #008CBA;
            border: white;
            color: red;
            padding: 5px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            width:fit-content;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 5px;
            border-style: double;
        }
        .td{
            border-color:black;
        }
        .fr{
            text-align:right;
            }
    </style>
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    
    <div class="container-fluid" >
        <table class="table table-bordered border-dark">
            <!-- Loop probably start -->
            <tr class="bg-primary">
                <td>
                    <img src="Assets/Adjustable_Shocks_Shock_Absorber.jpeg" alt="ASSA" class="img-fluid"/>
                    <br />
                    <p><strong>Adjustable Shocks Shock Absorber</strong></p>
                    <p class="bg-warning">
                        <strong id="price1" runat="server">$ 600.00</strong>
                        <asp:Button ID="Button1" runat="server" Text="Add to Cart" Class="fr" OnClick="Button1_Click" CausesValidation="False" />
                        <!--<asp:Button ID="Button7" runat="server" Text="Add to Cart" Class="fr" OnClick="Button1_Click"/>-->
                        
                    </p>
                    <p><strong>Product ID:</strong>1000</p>
                    <p><strong>Category:</strong> Font-End</p>
                    <asp:Label ID="Quantity1_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate" runat="server" Text="Calculate" OnClick="calculate_Click" /><br />
                    <asp:TextBox ID="Product" runat="server"></asp:TextBox>
                    <br />
                    
                    <p><strong>Discription:</strong>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                
                </td>
                <td>
                   <img src="Assets/Brake_Pads.jpeg" alt="ASSA" class="img-fluid"/>
                    <br />
                    <p><strong>Brake Pads</strong></p>
                    <p class="bg-warning">
                        <strong>$ 500.00</strong>
                        <asp:Button ID="Button2" runat="server" Text="Add to cart" OnClick="Button2_Click" />
                    </p>
                    <p><strong>Product ID: </strong>1001</p>
                    <p><Strong>Category:</Strong></p> 
                    <asp:Label ID="Quantity2_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity1" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate1" runat="server" Text="Calculate" OnClick="calculate_Click1" /><br />
                    <asp:TextBox ID="Product1" runat="server"></asp:TextBox>
                    <p><strong>Discription:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
                </td>
                <td>
                    <img src="Assets/Brake_Shoes.jpeg" alt="ASSA" class="img-fluid"/>
                    <br />
                    <p><strong>Brake Shoes</strong></p>
                    <p class="bg-warning">
                        <strong>$ 400.00</strong>
                        <asp:Button ID="Button3" runat="server" Text="Add to cart" OnClick="Button3_Click" />
                    </p>
                    <p><strong>Product ID: </strong>1002</p>
                    <p><Strong>Category:</Strong></p>
                    <asp:Label ID="Quantity3_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity2" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate2" runat="server" Text="Calculate" OnClick="calculate_Click2" /><br />
                    <asp:TextBox ID="Product2" runat="server"></asp:TextBox>
                    <p><strong>Discription:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </td>
            </tr>
            <tr class="bg-primary">
                <td>
                    <img src="Assets/camshaft.jpeg" alt="ASSA" class="img-fluid"/>
                    <br />
                    <p><strong>Camshaft</strong></p>
                    <p class="bg-warning">
                        <strong>$ 100.00</strong>
                        <asp:Button ID="Button4" runat="server" Text="Add to cart" OnClick="Button4_Click" />
                    </p>
                    <p><strong>Product ID: </strong>1003</p>
                    <p><Strong>Category:</Strong></p>
                    <asp:Label ID="Quantity4_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity3" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate3" runat="server" Text="Calculate" OnClick="calculate_Click3" /><br />
                    <asp:TextBox ID="Product3" runat="server"></asp:TextBox>
                    <p><strong>Discription:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </td>
                <td>
                    <img src="Assets/Cylinder_Head_Gasket.jpeg" alt="ASSA" class="img-fluid"/>
                    <br /> 
                    <p><strong>Cylinder Head Gasket</strong></p>
                    <p class="bg-warning">
                        <strong>$ 200.00</strong>
                        <asp:Button ID="Button5" runat="server" Text="Add to cart" OnClick="Button5_Click" />
                    </p>
                    <p><strong>Product ID: </strong>1004</p>
                    <p><Strong>Category:</Strong></p>
                    <asp:Label ID="Quantity5_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity4" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate4" runat="server" Text="Calculate" OnClick="calculate_Click4" /><br />
                    <asp:TextBox ID="Product4" runat="server"></asp:TextBox>
                    <p><strong>Discription:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </td>
                <td>
                    <img src="Assets/Piston.jpeg" alt="ASSA" class="img-fluid"/>
                    <br />
                    <p><strong>Piston</strong></p>
                    <p class="bg-warning">
                        <strong>$ 300.00</strong>
                        <asp:Button ID="Button6" runat="server" Text="Add to cart" OnClick="Button6_Click" />
                    </p>
                    <p><strong>Product ID: </strong>1005</p>
                    <p><Strong>Category:</Strong></p>
                    <asp:Label ID="Quantity6_label" runat="server" Text="Quantity:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="Quantity5" runat="server"></asp:TextBox><br />
                    <asp:Button ID="calculate5" runat="server" Text="Calculate" OnClick="calculate_Click5" /><br />
                    <asp:TextBox ID="Product5" runat="server"></asp:TextBox>
                    <p><strong>Discription:</strong>Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </td>
            </tr>
        </table>
    </div>
    <br />
</asp:Content>
