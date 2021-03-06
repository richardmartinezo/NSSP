<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="formulario_RIPO.ascx.vb" Inherits="sspbi.formulario_RIPO" %>
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
    background-color: #339933;
    }
    .fondoCuerpoC {
    background-color: #99FF66;
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

    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
<div id="DivPrincipal">

<div class="container">
        <%--azul--%>   
      <div class="row">
          <div class="col-12">
              <p class="font-italic">  Formulario RIPO, Reporte de Incidentes y Peligros Operacionales</p>
          </div>
          <div class="col-6 fondoTabla text-white"><strong>Notificación RIPO</strong></div>
          <div class="col-6 text-right fondoTabla text-white"></div>
    </div>
      <div class="row tablaCuerpo">       
            <div class="col-md-6">
                <h6><u>Datos del Notificante</u></h6>
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
                                    <h6>Actividad a la que se dedica:</h6>
                                      <dx:ASPxRadioButtonList ID="ASPxRadioButtonListActividadDedica" runat="server" RepeatColumns="3">
                                    <Items>
                                        <dx:ListEditItem Text="Piloto" Value="Piloto" />
                                        <dx:ListEditItem Text="ATCo" Value="ATCo" />
                                        <dx:ListEditItem Text="Despachador" Value="Despachador" />
                                        <dx:ListEditItem Text="Mecánico" Value="Mecánico" />
                                        <dx:ListEditItem Text="Handling" Value="Handling" />
                                        <dx:ListEditItem Text="Técnico Aeronáutico" Value="Técnico_Aeronáutico" />
                                        <dx:ListEditItem Text="Inspector" Value="Inspector" />
                                        <dx:ListEditItem Text="Personal de rampa" Value="Personal_de_rampa" />
                                        <dx:ListEditItem Text="Operaciones" Value="Operaciones" />
                                        <dx:ListEditItem Text="Adm. AD" Value="Adm._AD" />
                                        <dx:ListEditItem Text="Adm. Operador" Value="Adm._Operador" />
                                        <dx:ListEditItem Text="Otro" Value="Otro" />
                                    </Items>
                                </dx:ASPxRadioButtonList>
                                    <p></p> 
                                         <div class="justify-content-end d-flex">
                                            <dx:ASPxTextBox ID="ASPxTextBoxActividadOtro" runat="server" Text="Ingrese otra posición...." CssClass="form-control form-control-sm align-self-end" Width="50%"  Native="True" onkeydown="return soloNumeros(event);">
                                            </dx:ASPxTextBox>   
                                       </div>

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

                <h6><u>Lugar del Suceso</u></h6>
                <h6>Aeródromo:</h6>
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertos" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm" Width="80%">
                    <Columns>
                        <dx:ListBoxColumn FieldName="punto_ruta_oaci">
                        </dx:ListBoxColumn>
                        <dx:ListBoxColumn FieldName="aerodromo">
                        </dx:ListBoxColumn>
                        <dx:ListBoxColumn FieldName="aeropuerto">
                        </dx:ListBoxColumn>
                    </Columns>
                </dx:ASPxComboBox>
                <asp:SqlDataSource ID="SqlDataSourceAeropuertos" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT Vista_aeropuertos.* FROM Vista_aeropuertos where verificable_ssp = 1"></asp:SqlDataSource>                                    
                
                <h6>Coordenadas:</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxCoordenadas" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                </dx:ASPxTextBox>

                <h6>Otro:</h6>            
                 <dx:ASPxTextBox ID="ASPxTextBoxCoordenadasOtros" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                 </dx:ASPxTextBox>

            </div>
            <div class="col-md-9 tablaCuerpoA">
                <h6><u>Severidad</u></h6>
                     <div class="row">
                    <div class="col-md-4">
                            <h6><strong>Tripulación</strong></h6>

                            <h6>Fatalidades</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxFatalidadT" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                            </dx:ASPxTextBox>
                            <h6>Graves </h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxGravesT" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                            </dx:ASPxTextBox>

                            <h6>Menores</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxMenoresT" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                            </dx:ASPxTextBox>
                
                            <h6>Ninguno</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxNingunoT" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                            </dx:ASPxTextBox>


                    </div>
                    <div class="col-md-4">
                        <h6><strong>Pasajeros</strong></h6>

                        <h6>Fatalidades</h6>
                       <dx:ASPxTextBox ID="ASPxTextBoxFatalidadP" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                       </dx:ASPxTextBox>

                        <h6>Graves </h6>
                       <dx:ASPxTextBox ID="ASPxTextBoxGravesP" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                       </dx:ASPxTextBox>

                        <h6>Menores</h6>
                        <dx:ASPxTextBox ID="ASPxTextBoxMenoresP" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                        </dx:ASPxTextBox>

                        <h6>Ninguno</h6>
                        <dx:ASPxTextBox ID="ASPxTextBoxNingunoP" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0">
                        </dx:ASPxTextBox>
                    </div>
                    <div class="col-md-4">
                        <h6><strong>Daños a la aeronave</strong></h6>
                       <dx:ASPxRadioButtonList ID="ASPxRadioButtonListDaniosAeronave" runat="server" SelectedIndex="3">
                                <Items>
                                    <dx:ListEditItem Text="Destruida" Value="Destruida" />
                                    <dx:ListEditItem Text="Sustancial" Value="Sustancial" />
                                    <dx:ListEditItem Text="Menor" Value="Menor" />
                                    <dx:ListEditItem Text="Ninguno" Value="Ninguno" Selected="True" />
                                </Items>
                       </dx:ASPxRadioButtonList>
                    </div>
                    <div class="col-12"><p></p></div> 
                </div>
                     <div class="row">
                     <div class="col-md-4">
                   <h6><strong>Daños a terceros (Especifique daño y cantidad si aplica)</strong></h6>
                   <dx:ASPxMemo ID="ASPxMemoDanosTerceros" runat="server" Height="104px" CssClass="form-control form-control-sm"  Width="90%"  Native="True" EnableTheming="True" Text="0">
                    </dx:ASPxMemo>
               </div>
                     <div class="col-md-4">
                  <h6><strong>Condiciones ambientales y meteorológicas</strong></h6>
                   <h6>Condiciones MET</h6> 
                  <dx:ASPxComboBox ID="ASPxComboBoxCondicionesMET" runat="server" DataSourceID="SqlDataSourceCondicionesMET" TextField="Condiciones_MET" ValueField="Condiciones_MET" CssClass="form-control form-control-sm"  Width="80%"  Native="True">
                      <Columns>
                          <dx:ListBoxColumn FieldName="Condiciones_MET">
                          </dx:ListBoxColumn>
                      </Columns>
                  </dx:ASPxComboBox>
                  <asp:SqlDataSource ID="SqlDataSourceCondicionesMET" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT Condiciones_MET.* FROM Condiciones_MET"></asp:SqlDataSource>
            
                  <h6>Condiciones de Luz</h6>
                    <dx:ASPxComboBox ID="ASPxComboBoxCondicionesLuz" runat="server" RepeatColumns="2" CssClass="form-control form-control-sm"  Width="80%"  Native="True">
                        <Items>
                        <dx:ListEditItem Text="Alba" Value="Alba" />
                        <dx:ListEditItem Text="Luz de Día" Value="Luz_de_Día" />
                        <dx:ListEditItem Text="Crepúsculo" Value="Crepúsculo" />
                        <dx:ListEditItem Text="Noche" Value="Noche" />
                        </Items>
                    </dx:ASPxComboBox>   
                     
                  </div>
                    <div class="col-12 tablaCuerpoA"><p></p></div> 
               </div>   
                          
           </div>
            
        </div>
        
        <%--naranja--%>
        <div class="row">
        <div class="col-12 fondoTablaB"><strong>Identificación de la aeronave</strong></div>
            <div class="col-md-4 fondoCuerpoB">
            <h6>Identificación (Matrícula / Num de vuelo)</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxIdentificacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
            </dx:ASPxTextBox>

            <h6>Operador</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxOperador" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
            </dx:ASPxTextBox>

            <h6>Tipo de aeronave</h6>
              <dx:ASPxTextBox ID="ASPxTextBoxTipoAeronave" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
              </dx:ASPxTextBox>

            <h6>Reglas de vuelo</h6>
            <dx:ASPxComboBox ID="ASPxComboBoxReglasVuelo" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                    <Items>
                    <dx:ListEditItem Text="IFR" Value="IFR" />
                    <dx:ListEditItem Text="VFR" Value="VFR" />
                    </Items>
            </dx:ASPxComboBox>
            </div>
            <div class="col-md-4 fondoCuerpoB">
                <h6>Aeródromo de salida</h6>           
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertosSalida" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                </dx:ASPxComboBox>

                <h6>Aeródromo de destino</h6>
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertosDestino" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                </dx:ASPxComboBox>

                <h6>Altitud / nivel de vuelo</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxAltitudNivelVuelo" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                </dx:ASPxTextBox>

                <h6>Tipo de operación</h6>
                <dx:ASPxComboBox ID="ASPxComboBoxTipoOperacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                <Items>
                    <dx:ListEditItem Text="Centro de Instrucción" Value="Centro de Instrucción" />
                    <dx:ListEditItem Text="Entrenamiento" Value="Entrenamiento" />
                    <dx:ListEditItem Text="Fumigación" Value="Fumigación" />
                    <dx:ListEditItem Text="Pasajeros Regular" Value="Pasajeros_Regular" />
                    <dx:ListEditItem Text="Pasajeros NO Regular" Value="Pasajeros_NO_Regular" />
                    <dx:ListEditItem Text="Carga Regular" Value="Carga_Regular" />
                    <dx:ListEditItem Text="Carga NO Regular" Value="Carga_NO_Regular" />
                    <dx:ListEditItem Text="Privado" Value="Privado" />
                    <dx:ListEditItem Text="Deportivo" Value="Deportivo" />
                    <dx:ListEditItem Text="Otro" Value="Otro" />
                </Items>
            </dx:ASPxComboBox>
            </div>
            <div class="col-md-4 fondoCuerpoB">
                <h6>Fase de Vuelo</h6>
                 <dx:ASPxRadioButtonList ID="ASPxRadioButtonListFaseVuelo" runat="server" RepeatColumns="3" TabIndex="-1">
                <Items>
                    <dx:ListEditItem Text="Estacionado" Value="Estacionado" />
                    <dx:ListEditItem Text="Retroceso" Value="Retroceso" />
                    <dx:ListEditItem Text="Puesta en marcha" Value="Puesta_en_marcha" />
                    <dx:ListEditItem Text="Rodaje" Value="Rodaje" />
                    <dx:ListEditItem Text="Despegue" Value="Despegue" />
                    <dx:ListEditItem Text="Ascenso" Value="Ascenso" />
                    <dx:ListEditItem Text="Crucero" Value="Crucero" />
                    <dx:ListEditItem Text="Descenso" Value="Descenso" />
                    <dx:ListEditItem Text="Aproximación" Value="Aproximación" />
                    <dx:ListEditItem Text="Aterrizaje" Value="Aterrizaje" />
                    <dx:ListEditItem Text="Espera" Value="Espera" />
                    <dx:ListEditItem Text="Circuito de tránsito" Value="Circuito_de_tránsito" />
                    <dx:ListEditItem Text="Remolque" Value="Remolque" />
                    <dx:ListEditItem Text="Otro" Value="Otro" />
                </Items>
            </dx:ASPxRadioButtonList>
             <p></p> 
            <div class="justify-content-end d-flex">
            <dx:ASPxTextBox ID="ASPxTextBoxFaseVueloOtro" runat="server" Text="Ingrese otra opción...." CssClass="form-control form-control-sm align-self-end" Width="50%"  Native="True">
            </dx:ASPxTextBox>
            </div>

            </div>
            <div class="col-12 fondoCuerpoB"><p></p></div>
        </div> 
        
        <%--verde--%>
        <div class="row">
            <div class="col-12 fondoTablaC"><strong>Descripción del Suceso</strong></div>
             <div class="col-12 fondoCuerpoC"><p></p></div>
              <div class="col-md-3 fondoCuerpoC">
                  <h6 class="text-justify font-italic">Describa el suceso con el mayor detalle posible, incluya aquellos aspectos 
                    que usted considere relevantes, o aquellos factores presumiblemente fueron la causa del evento o suceso</h6>         
              </div>
              <div class="col-md-5 fondoCuerpoC">
             <dx:ASPxMemo ID="ASPxMemoDescripcion" runat="server"  Height="104px" CssClass="form-control form-control-sm"  Width="90%"  Native="True" EnableTheming="True" Style="text-align: center">
            </dx:ASPxMemo>
            </div>
              <div class="col-md-4 fondoCuerpoC">         
               <h6>Adjuntar archivo</h6>
                <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnUploadControlArchivo">
                </dx:ASPxUploadControl>
                  <p></p> 
                <dx:ASPxButton ID="ASPxButtonEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnEnviar">
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
                              

              " />
                 </dx:ASPxButton>
              </div>
            <div class="col-12 fondoCuerpoC"><p><dx:ASPxHiddenField runat="server" ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor"></dx:ASPxHiddenField></p></div>  
        </div>
    
</div>

<%--popup--%>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Width="400px" Height="400px" ClientInstanceName="popupcontrol2" HeaderText="Formulario RIPO" Theme="Glass"
        AllowDragging="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter">
                <ClientSideEvents PopUp="function(s, e) {
	//BtnUploadControlArchivo.SetEnabled(false);
//BtnEnviar.SetEnabled(false);

}" />
                <ContentCollection>
            <dx:PopupControlContentControl runat="server">
               <table class="dxflInternalEditorTable_SoftOrange" style="height: 146px; width: 50%">
                    <caption>
                        <h6>Formulario Enviado Correctamente</h6>
                        <tr>
                            <td class="auto-style34">
                                <img alt="" class="" src="../../Images/ok.jpg" />
                                <dx:ASPxButton ID="ASPxButtonRegresar" runat="server" CssClass="btn btn-primary" Height="40px" Native="True" Text="Inicio" Width="180px">
                                    <ClientSideEvents Click="function(s, e) {
	
	window.location = &quot;../default.aspx&quot;;

}" />
                                </dx:ASPxButton>
                            </td>
                        </tr>
                    </caption>

                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>


</div>
