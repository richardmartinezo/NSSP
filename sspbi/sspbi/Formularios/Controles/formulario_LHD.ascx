<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="formulario_LHD.ascx.vb" Inherits="sspbi.formulario_LHD" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<style type="text/css">

  
    .fondoTabla {
    background-color: #000066;
    }
    .tablaCuerpo {
     background-color: #0099cc;
    }
    .tablaCuerpoA {
        background-color: #FFFF99;
     } 
    .fondoTablaA {
       background-color: #FFCC00;
    } 
    .fondoTablaB {
       background-color: #FF6600;
    }
    .fondoCuerpoB {
    background-color: #FFFF99;
    }
    .fondoTablaC {
    background-color: #33CC33;
    }
    .fondoCuerpoC {
    background-color: #99FF66
    }
    .ajuste {
     padding-left: 20px;
     }
      .fondoForm {
            position: relative;
            width: 80%;
            height: 80%;
            background-color: #ceffff; 
        }
        </style>


<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

<div class="container">
        <%--azul--%>   
    <div class="row">
          <div class="col-12">
              <p class="font-italic"> Formulario LHD</p>
          </div>
          <div class="col-6 fondoTabla text-white"><strong>Notificación LHD</strong></div>
          <div class="col-6 text-right fondoTabla text-white"></div>
    </div>
    <div class="row tablaCuerpo">
        <div class="col-md-6">
            <h6>Datos del Notificante</h6>
                            <h6>Nombre y Apellido:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxNombreApellido" runat="server" CssClass="form-control form-control-sm"  Width="80%"  Native="True" onkeydown="return soloLetra(event);" ClientInstanceName="txtnombreapellido">
                               
                           </dx:ASPxTextBox>
            <div class="row">
            <div class="col-md-6">
                <h6>E-mail:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxEmail" runat="server" CssClass="form-control form-control-sm" Width="80%"  Native="True" ClientInstanceName="txtemail"> 
                                
                            </dx:ASPxTextBox>
                                   <asp:RegularExpressionValidator Font-Size="12px"
                                         ControlToValidate="ASPxTextBoxEmail"
                                         Text="Correo invalido."
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                         Runat="Server" />
            </div>
            <div class="col-md-6">
                             <h6>Teléfono:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxTelefono" runat="server" CssClass="form-control form-control-sm" Width="80%"  Native="True" onkeydown="return soloNumeros(event);" ClientInstanceName="txttelefono">
                              
                            </dx:ASPxTextBox>
            </div>
          </div>
        </div>
        <div class="col-md-6">
            <p></p>
             <h6>Licencia ATC:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxLicenciaATC" runat="server" CssClass="form-control form-control-sm" Width="80%"  Native="True" >
                               
                            </dx:ASPxTextBox>
        </div>
</div>   

    <%--amarillo--%>
         <div class="row">
        <div class="col-12 fondoTablaA"><strong>Información del suceso</strong></div>
        <div class="col-md-3 tablaCuerpoA">
            <h6><u>Fecha y Hora</u></h6>
            <p></p>
            <h6>Día / Mes / Año (UTC):</h6>
                <dx:ASPxDateEdit runat="server" ID="ASPxDateEditFecha" CssClass="form-control form-control-sm" Width="80%" native="false"></dx:ASPxDateEdit> 
            <h6>Hora (UTC):</h6>
                <dx:ASPxTimeEdit runat="server" ID="ASPxTimeEditHora" CssClass="form-control form-control-sm" Width="80%" native="false"></dx:ASPxTimeEdit>
            <p></p>
            <p class="font-italic text-justify">Para el sistema NSSP es importante contar con la mayor cantidad de información del suceso, con el fin de identificar situaciones que afectan la seguridad operacional.</p>
        
        </div>
        <div class="col-md-4 tablaCuerpoA">
            <h6><u>Lugar del Suceso</u></h6>
            <p></p>
                        
            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT id, ciudad, pais, aeropuerto, aerodromo, punto_ruta_oaci, punto_ruta_iata, aerop_descrip, latitud, longitud, verificable, verificable_ssp FROM Vista_aeropuertos WHERE (verificable_ssp = 1)" ID="SqlDataSourceAeropuertos"></asp:SqlDataSource>
            
                    
 
            <h6>Ruta / Aerovía:</h6>
            <dx:ASPxComboBox runat="server" ValueField="Ruta_Aerovia" CssClass="form-control form-control-sm" Native="True" ID="ASPxComboBoxRutaAerovia" Width="100%" DataSourceID="SqlDataSourceRutaAerovia" TextField="Ruta_Aerovia">
                       
            </dx:ASPxComboBox>

            <asp:SqlDataSource ID="SqlDataSourceRutaAerovia" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT * FROM [Ruta_Aerovia]"></asp:SqlDataSource>
           
            <h6>Distancia entre las 2 aeronaves:</h6>
            <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxDistanciaAeronaves" Text="0" onkeydown="return soloNumeros(event);">
                                    </dx:ASPxTextBox>
            <div class="row">
 
              
            </div>         

        </div>
        <div class="col-md-5 tablaCuerpoA">
                <h6><u>Condiciones ambientales y meteorólogicos</u></h6>
                <p></p>
             <div class="row">
              <div class="col-6">
                    <h6>Condiciones MET:</h6>
                            <dx:ASPxComboBox runat="server" ValueField="Condiciones_MET" CssClass="form-control form-control-sm" Native="True" ID="ASPxComboBoxCondicionesMET" Width="100%" DataSourceID="SqlDataSourceCondicionesMET" TextField="Condiciones_MET">
                                <Columns></Columns>
                               
                            </dx:ASPxComboBox>
                            <asp:SqlDataSource ID="SqlDataSourceCondicionesMET" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT Condiciones_MET.* FROM Condiciones_MET"></asp:SqlDataSource>
                     
              </div>
              <div class="col-md-6">
                         <h6>Visualizado en SSR:</h6>
                            
                             <dx:ASPxRadioButtonList ID="ASPxRadioButtonListVisualizadoSSR" runat="server" RepeatColumns="2">
                                <Items>
                                <dx:ListEditItem Text="SI" Value="SI" />
                                <dx:ListEditItem Text="NO" Value="NO"/>
                                
                                </Items>
                            </dx:ASPxRadioButtonList>
                         <h6>FL Autorizado:</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxFLautorizado" runat="server" Width="70%" CssClass="form-control form-control-sm" Native="True" Text="0">
                            </dx:ASPxTextBox>
                        <h6>Tiempo estimado en el FL incorrecto(segundos):</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxFLincorrecto" runat="server" Width="70%" CssClass="form-control form-control-sm" Native="True" Text="0" onkeydown="return soloNumeros(event);">
                            </dx:ASPxTextBox>
              </div>
            <p></p>
              <div class="row ajuste">
                  
                  <div class="col-12 ajuste">
                     </div>
 
              <div class="col-md-6">
                         </div>
              <div class="col-md-6">
                      </div>
            </div>

              <div class="col-10">
                   <p></p>
                
                   <p></p>
                  </div> 
                 
                 
            </div>
            <p></p>
            </div>

             
           

        </div>
       
    </div>
    <%--naranja--%>
         <div class="row">
        <div class="col-12 fondoTablaB"><strong>Aeronave 1</strong></div>
        
              <div class="col-md-6 fondoCuerpoB">
                                    <h6>Identificación (Matrícula / Num Vuelo):</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxVuelo1" Text="0">
                                    </dx:ASPxTextBox>
   
                                     <h6>Operador:</h6>                               
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxOperadorO1" Text="0">
                                    </dx:ASPxTextBox>
                                     <h6>Tipo de aeronave:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxTipoAeronave1" Text="0">
                                    </dx:ASPxTextBox>

                                    <h6>Registro:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxRegistro1" Text="0">
                                    </dx:ASPxTextBox>
                                    
                                    <h6>Modelo:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxModelo1" Text="0">
                                    </dx:ASPxTextBox>
                                    
                                    
                                    
                                   <p></p>
                               
                             
                  </div>

               <div class="col-md-6 fondoCuerpoB">
            <h6> Aeródromo Salida:</h6>
              <dx:ASPxComboBox runat="server" DataSourceID="SqlDataSourceAeropuertos" ValueField="id" CssClass="form-control form-control-sm"  Width="70%"  Native="True" ID="ASPxComboBoxAeropuertos1Salida" TextField="punto_ruta_oaci" ClientInstanceName="ComboAerodromoSalida1"><Columns>
            <dx:ListBoxColumn FieldName="punto_ruta_oaci" Name="OACI" Caption="Codigo OACI"></dx:ListBoxColumn>
            <dx:ListBoxColumn FieldName="punto_ruta_iata" Name="Codigo_IATA" Caption="Codigo_IATA"></dx:ListBoxColumn>
            <dx:ListBoxColumn FieldName="ciudad" Name="Ciudad" Caption="Ciudad"></dx:ListBoxColumn>
            <dx:ListBoxColumn FieldName="aerodromo" Name="Aeropuerto" Caption="Aeropuerto"></dx:ListBoxColumn>
            </Columns>
                      
            </dx:ASPxComboBox>

           <h6>Aeródromo Destino:</h6> 
              <dx:ASPxComboBox runat="server" DataSourceID="SqlDataSourceAeropuertos" ValueField="id" CssClass="form-control form-control-sm"  Width="70%" ID="ASPxComboBoxAeropuertos1Destino" TextField="punto_ruta_oaci" ClientInstanceName="ComboAerodromoDestino1"><Columns>
                            <dx:ListBoxColumn FieldName="punto_ruta_oaci" Name="OACI" Caption="Codigo OACI"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="punto_ruta_iata" Name="Codigo_IATA" Caption="Codigo_IATA"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="ciudad" Name="Ciudad" Caption="Ciudad"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="aerodromo" Name="Aeropuerto" Caption="Aeropuerto"></dx:ListBoxColumn>
                            </Columns>
                              
                            </dx:ASPxComboBox>
          
            <p></p>                        
        </div>
             <div class="col-12 fondoCuerpoB"><p></p></div>
    </div>   
         <div class="row">
        <div class="col-12 fondoTablaB"><strong>Aeronave 2</strong></div>
        
              <div class="col-md-6 fondoCuerpoB">
                                    <h6>Identificación (Matrícula / Num Vuelo):</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxVuelo2" Text="0">
                                    </dx:ASPxTextBox>
 
                                     <h6>Operador:</h6>                               
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxOperadorO2" Text="0">
                                    </dx:ASPxTextBox>

                                    <h6>Tipo de aeronave:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxTipoAeronave2" Text="0">
                                    </dx:ASPxTextBox>
                                   
                   
                                   <p></p>
                                    <h6>Registro:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxRegistro2" Text="0">
                                    </dx:ASPxTextBox>
                                    
                                    <h6>Modelo:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxModelo2" Text="0">
                                    </dx:ASPxTextBox>

                             
                  </div>

               <div class="col-md-6 fondoCuerpoB">
            <h6> Aeródromo Salida:</h6>
                <dx:ASPxComboBox runat="server" DataSourceID="SqlDataSourceAeropuertos" ValueField="id" CssClass="form-control form-control-sm"  Width="70%"  Native="True" ID="ASPxComboBoxAeropuertos2Salida" TextField="punto_ruta_oaci"><Columns>
                <dx:ListBoxColumn FieldName="punto_ruta_oaci" Name="OACI" Caption="Codigo OACI"></dx:ListBoxColumn>
                <dx:ListBoxColumn FieldName="punto_ruta_iata" Name="Codigo_IATA" Caption="Codigo_IATA"></dx:ListBoxColumn>
                <dx:ListBoxColumn FieldName="ciudad" Name="Ciudad" Caption="Ciudad"></dx:ListBoxColumn>
                <dx:ListBoxColumn FieldName="aerodromo" Name="Aeropuerto" Caption="Aeropuerto"></dx:ListBoxColumn>
                </Columns>

                       
                </dx:ASPxComboBox>


           <h6>Aeródromo Destino:</h6> 
              <dx:ASPxComboBox runat="server" DataSourceID="SqlDataSourceAeropuertos" ValueField="id" CssClass="form-control form-control-sm"  Width="70%" ID="ASPxComboBoxAeropuertos2Destino" TextField="punto_ruta_oaci"><Columns>
                            <dx:ListBoxColumn FieldName="punto_ruta_oaci" Name="OACI" Caption="Codigo OACI"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="punto_ruta_iata" Name="Codigo_IATA" Caption="Codigo_IATA"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="ciudad" Name="Ciudad" Caption="Ciudad"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="aerodromo" Name="Aeropuerto" Caption="Aeropuerto"></dx:ListBoxColumn>
                            </Columns>

                          
                            </dx:ASPxComboBox>
           
        </div>
                <div class="col-12 fondoCuerpoB"> 
                                    
                    <p></p></div>
                                   
    </div> 
    
      <div class="row">
        <div class="col-12 fondoTablaB"><strong>Después de restaurada la desviación</strong></div>
        
              <div class="col-md-6 fondoCuerpoB">

                                    <h6>Latitud:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxLatitud" Text="0" onkeydown="return soloNumeros(event);">
                                    </dx:ASPxTextBox>
                                    <h6>Longitud:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxLongitud" Text="0" onkeydown="return soloNumeros(event);">
                                    </dx:ASPxTextBox>

                                    <h6>Nivel de Vuelo Observado o Reportado:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxNivelVuelo" Text="0">
                                    </dx:ASPxTextBox>
   
                                     <h6>Fuente de Información:</h6> 
                                     <dx:ASPxRadioButtonList ID="ASPxRadioButtonListFuenteInformacion" runat="server" RepeatColumns="2">
                                        <Items>
                                        <dx:ListEditItem Text="Modo C/S" Value="Modo_C/S" />
                                        <dx:ListEditItem Text="Piloto" Value="Piloto"/>
                                        </Items>
                                    </dx:ASPxRadioButtonList>
                                                              
                                    <h6>Otro:</h6>
                                    <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxFuenteInformacionOtro" Text="0">
                                    </dx:ASPxTextBox>

                                  
                             
                  </div>

               <div class="col-md-6 fondoCuerpoB">
           
          
              <h6>El FL final cumplió con las tablas de crucero del ANEXO 2:</h6>
                                     <dx:ASPxRadioButtonList ID="ASPxRadioButtonListcumpliranexo2" runat="server" RepeatColumns="2">
                                        <Items>
                                        <dx:ListEditItem Text="SI" Value="SI" />
                                        <dx:ListEditItem Text="NO" Value="NO"/>
                                        </Items>
                                    </dx:ASPxRadioButtonList>

                                     <h6>Carga de Trabajo:</h6>
                                     <dx:ASPxRadioButtonList ID="ASPxRadioButtonListCargaTrabajo" runat="server" RepeatColumns="2">
                                        <Items>
                                        <dx:ListEditItem Text="Ligera" Value="Ligera" />
                                        <dx:ListEditItem Text="Mediana" Value="Mediana"/>
                                            <dx:ListEditItem Text="Pesada" Value="Pesada"/>
                                        </Items>
                                    </dx:ASPxRadioButtonList>
                                   <h6>Causas de la Desviación:</h6> 
                   <dx:ASPxTextBox runat="server" CssClass="form-control form-control-sm"  Width="50%"  Native="True" ID="ASPxTextBoxCausasDesviacion" Text="0">
                    </dx:ASPxTextBox>
                                    
                                   <p></p>
                                                  
        </div>
             <div class="col-12 fondoCuerpoB"><p></p></div>
    </div>   

    <%--verde--%>  

    
        
      
           
            

         <div class="row">
          <div class="col-6 fondoTablaC"><strong>Descripción del Suceso</strong></div>
          <div class="col-6 text-right fondoTablaC"><strong>Adjuntar Archivo</strong></div>
        </div>
         <div class="row">  
        <div class="col-12 fondoCuerpoC"><p></p></div>     
              <div class="col-md-3 fondoCuerpoC">
                  <h6 class="text-justify font-italic"> Describa el suceso con el mayor detalle posible, incluya aquellos aspectos que usted considere relevantes, o aquellos factores presumiblemente fueron la causa del evento o suceso.</h6>         
              </div>

              <div class="col-md-5 fondoCuerpoC">
           
             <dx:ASPxMemo runat="server" Height="104px" CssClass="form-control form-control-sm"  Width="90%"  Native="True" EnableTheming="True" ID="ASPxMemoDescripcionNarrativa" Style="text-align: center"></dx:ASPxMemo>
        </div>
              
              <div class="col-md-4 fondoCuerpoC">              
                    <dx:ASPxUploadControl ID="ASPxUploadControlArchivos" runat="server" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnUploadControlArchivo">
                    </dx:ASPxUploadControl>
                      <p></p>          
                    <dx:ASPxButton runat="server" Text="Enviar" ID="ASPxButtonEnviar" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnEnviar">
                    <ClientSideEvents Click="function(s, e) {
var textoNombre = txtnombreapellido.lastChangedValue;
var textoTelefono = txttelefono.lastChangedValue;
var textoEmail=txtemail.lastChangedValue;
                  
          if (textoNombre == null) {            
BtnEnviar.SetVisible(true);       
              alert('Ingrese Nombre y Apellido');
HiddenFieldValor.Set('valor','vacio');
              return false;
          } else  if (textoTelefono == null) {     
BtnEnviar.SetVisible(true);              
              alert('Ingrese Telefono');
HiddenFieldValor.Set('valor','vacio');
              return false;
          }else  if(textoEmail==null){
BtnEnviar.SetVisible(true);
alert('Ingrese e-mail');
HiddenFieldValor.Set('valor','vacio');
return false;
} else {
BtnEnviar.SetVisible(false);
HiddenFieldValor.Set('valor','lleno');
BtnEnviar.Click();

return true;

}
	
}
                              

              "></ClientSideEvents>
                    </dx:ASPxButton>
             </div>  
             <div class="col-12 fondoCuerpoC"><p><dx:ASPxHiddenField runat="server" ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor">

                                                 </dx:ASPxHiddenField></p></div>
    </div>   

    </div>

                  



<dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" ClientInstanceName="popupcontrol2" HeaderText="Atención" Theme="Glass"
        llowDragging="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter">
                                    <ClientSideEvents PopUp="function(s, e) {
	BtnUploadControlArchivo.SetEnabled(false);
BtnEnviar.SetEnabled(false);

}" />
                                    <ContentCollection>
                                        <dx:PopupControlContentControl runat="server">
                                            <table class="dxflInternalEditorTable_SoftOrange" style="height: 146px; width: 50%">
                                                <tr>
                                                   <td class="auto-style34">
                                                    <img alt="" class="" src="../../Images/ok.jpg" /> 
                                                        <dx:ASPxButton ID="ASPxButtonRegresoMenu" runat="server" Text="Inicio" CssClass="btn btn-primary" Height="40px" Width="180px" Native="True">
                                                            <ClientSideEvents Click="function(s, e) {
                                                                window.location = &quot;../default.aspx&quot;;
                                         }" />
                                                        </dx:ASPxButton>
                                                   </td>
                                                </tr>
                                            </table>
                                        </dx:PopupControlContentControl>
                                    </ContentCollection>
                                </dx:ASPxPopupControl>

<script type="text/javascript">
    function soloNumeros(evt) {
        var key = evt.keyCode;
        console.log(key);
        return (((key >= 37 && key <= 40) || (key >= 46 && key <= 57) || (key >= 96 && key <= 105) || (key == 8) || (key == 32)));
    }

    function soloLetra(evt) {
        var key = evt.keyCode;
        return (((key >= 65 && key <= 90) || (key > 25 && key < 28) || (key == 8) || (key == 32)));
    }

    function ValidEmail(valor) {
        if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3,4})+$/.test(valor)) {
            alert("La dirección de email " + valor + " es correcta.");
        } else {
            alert("La dirección de email es incorrecta.");
        }
    }

        </script>                        