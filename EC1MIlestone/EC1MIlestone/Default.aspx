<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EC1MIlestone._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .pp{
            color:red;
            
        }
        .hh{
            color:red;
            font-weight:bold;
        }
        .translucent{
            background: rgba(0%, 255%, 222%, 0.75);
            padding-top:5px;
            padding-bottom:5px;
            border-radius: 25px;
        }
    </style>
    <div class="jumbotron">
        <h1>G-Tab</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <div class="container body-content">
            <h1>Welcome to G-Tab Auto Parts</h1>
            <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="Assets/Adjustable_Shocks_Shock_Absorber.jpeg" class="d-block w-100" alt="schoksabsorber" height="600" width="100%">
                    <div class="carousel-caption d-none d-md-block">
                        <div class="translucent">
                            <h5 class="hh">Adjustable Shocks Shock Absorber</h5>
                            <p class="pp">Some representative placeholder content for the first slide.</p>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                  <img src="Assets/Brake_Pads.jpeg" class="d-block w-100" alt="brakepads" height="600" width="100%">
                  <div class="carousel-caption d-none d-md-block">
                      <div class="translucent">
                            <h5 class="hh">Brake Pads</h5>
                            <p class="pp">Some representative placeholder content for the second slide.</p>
                      </div>
                  </div>
                </div>
                <div class="carousel-item">
                  <img src="Assets/Brake_Shoes.jpeg" class="d-block w-100" alt="brakeshoes"height="600" width="100%" />
                  <div class="carousel-caption d-none d-md-block">
                    <div class="translucent">
                        <h5 class="hh">Brake Shoes</h5>
                        <p class="pp">Some representative placeholder content for the third slide.</p>
                    </div>
                  </div>
                </div>
          </div>
              <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
              </button>
              <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
              </button>
        </div>
    </div>
</asp:Content>
