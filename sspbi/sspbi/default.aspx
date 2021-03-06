<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main_Menu.Master" CodeBehind="default.aspx.vb" Inherits="sspbi._default" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style type="text/css">

        .imagen_menu {
            width: 134px;
            height: 133px;
            align-items: center;
            border:thin black;
            text-align: center;
            align-content: center;
        }   
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Height="100%" Width="100%" Theme="Moderno"  ShowHeader="False">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <div class="row text-lg-left">
                    <div class="col-xs-6 col-md-3 text-center">
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_accidentes_incidentes_RIPO.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_ripo.jpg"  />
                            </a>
                            <div class="caption">
                            <h5>Notificación RIPO</h5>
                            <p>Formulario NSSP-01</p>
                            <p>Notificación: Reporte de Incidentes y Peligros Operacionales</p>

                        </div>
                    </div>
                  </div>

                    <div class="col-xs-6 col-md-3 text-center">
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_sucesos_ATS.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_ats.jpg"  />
                            </a>
                            <div class="caption">
                            <h5>Notificación ATS</h5>
                            <p>Formulario NSSP-02</p>
                            <p>Notificación de sucesos <br /> de tránsito aéreo</p>
                            
                        </div>
                    </div>
                  </div>
                    
                    <div class="col-xs-6 col-md-3 text-center">
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_impacto_aviario_IBIS.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_ibis.jpg"  />
                          </a>
                            <div class="caption">
                            <h5>Notificación IBIS</h5>
                             <p>Formulario NSSP-03</p>
                            <p>Notificación de <br /> Impactos de aves</p>
                            
                        </div>
                    </div>
                  </div>

                    <div class="col-xs-6 col-md-3 text-center">
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_aero.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_aero.jpg"  />
                            </a>
                            <div class="caption">
                            <h5>Notificación AERO</h5>
                            <p>Formulario NSSP-04</p>
                            <p>Notificación de fallas de sistemas o componentes de una aeronave</p>            
                        </div>

                    </div>
                       
                  </div>

                    

                    <div class="col-xs-6 col-md-3 text-center">
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_voluntario.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_libre.jpg"  />
                            </a>
                            <div class="caption">
                            <h5>Notificación Libre</h5>
                                <p>Formulario NSSP-06</p>
                            <p> Notificación libre y voluntaria de <br /> actividades que podrían <br />afectar a la seguridad</p>
                            
                        </div>
                        
                    </div>
                  </div>

                    <div class="col-xs-6 col-md-3 text-center">
                        
                        <div class="thumbnail">
                          <a href="../Formularios/reporte_LHD.aspx" role="button">
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_lhd.jpg"  />
                           </a>
                            <div class="caption">
                            <h5>Notificación LHD</h5>
                             <p>Formulario NSSP-07</p>
                            <p>Notificación de grandes<br /> desviaciones de altitud</p>
                            
                        </div>
                    </div>
                  </div>

                    <div class="col-xs-6 col-md-3 text-center">
                       
                        <div class="thumbnail">     
                            <a href="../Formularios/reporte_MERC.aspx" role="button">                   
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_merc.jpg"  />  
                                </a>                         
                            <div class="caption">
                            <h5>Notificación MERC</h5>
                                <p>Formulario NSSP-08</p>
                            <p> Notificación de sucesos <br /> relacionados <br /> con el transporte de <br />mercancías peligrosas</p>                          
                            </div>
                    </div>
                  </div>
                     <div class="col-xs-6 col-md-3 text-center">
                       
                        <div class="thumbnail">    
                            <a href="Formularios/reporte_ACTIL.aspx">          
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_actil.jpeg"  />   
                                </a>                                  
                            <div class="caption">
                            <h5>Notificación ACTIL</h5>
                                <p>Formulario NSSP-09</p>
                            <p> Notificación Obligatoria ACTIL </p>                          
                            </div>
                    </div>

                  </div>
                      <div class="col-xs-6 col-md-3 text-center">
                       
                        <div class="thumbnail">    
                            <a href="Formularios/reporte_voluntario_ATS.aspx">          
                          <img alt="" class="imagen_menu" src="Images/main_menu/main_ats_vol.jpg"  />   
                                </a>                                  
                            <div class="caption">
                            <h5>Notificación VOL-ATS</h5>
                                <p>Formulario NSSP-10</p>
                            <p> Notificación libre y voluntaria ATS de <br /> actividades que podrían <br />afectar a la seguridad</p>                          
                            </div>
                    </div>

                  </div>

                </div>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</asp:Content>

