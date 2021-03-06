<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="sspbi.Login"  MasterPageFile="~/Main_Menu.Master" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style type="text/css">
       
        .auto-style11 {
            font-size: large;
        }
        .wrapper {	
	        margin-top: 2%;
          margin-bottom: 2%;
        }
        .form-signin {
              max-width: 50%;
              /*padding: 45px 35px 45px;*/
              margin: 0 auto;
              background-color: #fff;
              /*border: 1px solid rgba(0,0,0,0.1);*/ 
	       }
       .imgLogin{
             max-width: 400%;
             height: auto;
            }
        
    </style> 
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolderBody">
 
  <div class="wrapper">
    <div class="form-signin">
        <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="SSP tableros de Mando y Control"  Theme="Glass">
           <PanelCollection>
            <dx:PanelContent runat="server">
              <div class="container">
                <div class="row justify-content-between">
                    <div class="col col-lg-2">
                        <div class="mt-md-none mt-3 d-none d-md-block">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/logo_header.png"/>
                            </div>
                        <div class="mt-md-none mt-3 d-none d-lg-block">   
                            <asp:Image ID="Image3" runat="server" src="../Images/sap-lumira.jpg" CssClass="imgLogin"/> 
                        </div>     
                                                     
                    </div>

                    <div class="col col-lg-6 align-self-center mt-md-0 mt-2">
                        <strong><span class="auto-style11"><span class="auto-style7">Sistema de información de reportes del SSP DGAC&nbsp;.</span></span></strong>
                         <p></p>
                            <h6>Usuario:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxUsuario" runat="server" CssClass="form-control" Width="80%"  Native="True">
                            </dx:ASPxTextBox>

                            <h6>Password:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxPassword" TextMode="Password" runat="server" CssClass="form-control password-input" Width="80%" Native="True" Password="True">
                            </dx:ASPxTextBox>
                        <p></p>
                       <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Ingresar al sistema" Theme="SoftOrange" CssClass="btn" Height="40px" Width="150px">
                       </dx:ASPxButton>

                   </div>
                </div>

            </div>
               

   
    

            </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel> 
    </div>
 </div>
<script type="text/javascript">
    $('.password-input').bind('click', function () {
        if ($(this).val() === "Please enter your Password") {
            this.type = "password";
            $(this).val('');
        }
    });

    $('.password-input').bind('blur', function () {
        if ($(this).val() === "") {
            this.type = "text";
            $(this).val('Please enter your Password');
        }
    });

</script>

    </asp:Content>

