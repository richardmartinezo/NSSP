<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="formulario_IBIS.ascx.vb" Inherits="sspbi.formulario_IBIS" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
  <script type="text/javascript">
      var isPostbackInitiated = false;
      var repeticion = 0;
      function soloNumeros(evt) {
          var key = evt.keyCode;
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

      function __doPostBack(eventTarget, eventArgument) {
          if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
              theForm.__EVENTTARGET.value = eventTarget;
              theForm.__EVENTARGUMENT.value = eventArgument;
              theForm.submit();
          }
      }


     

        </script>

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
<div class="container">
        <%--azul--%>   
      <div class="row">
          <div class="col-12">
              <p class="font-italic">  Formulario IBIS, Notificación Impacto Aviario.</p>
          </div>
          <div class="col-6 fondoTabla text-white"><strong>Notificación IBIS</strong></div>
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
                                      <dx:ASPxRadioButtonList ID="ASPxRadioButtonListActividadDedica" runat="server" RepeatColumns="3" ClientInstanceName="rdlistaactividaddedica">
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
                                         <div class="justify-content-end d-flex">
                                       </div>

            </div>

        </div>

        <%--amarillo--%>
      <div class="row">
            <div class="col-12 fondoTablaA"><strong>Información General</strong></div>
            <div class="col-md-3 tablaCuerpoA">
                <h6><u>Fecha y Hora</u></h6>
                <p></p>
                <h6>Día / Mes / Año (UTC):</h6>
                    <dx:ASPxDateEdit runat="server" ID="ASPxDateEditFecha" CssClass="form-control form-control-sm" Width="80%" native="false" ClientInstanceName="datefecha"></dx:ASPxDateEdit> 
                <h6>Hora (UTC):</h6>
                    <dx:ASPxTimeEdit runat="server" ID="ASPxTimeEditHora" CssClass="form-control form-control-sm" Width="80%" native="false" ClientInstanceName="timehora"></dx:ASPxTimeEdit>
                <p></p>

                <h6><u>Lugar del Suceso</u></h6>
                <h6>Aeródromo:</h6>
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertos" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm" Width="80%" ClientInstanceName="comboaeropuertos">
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
                
                <h6>Pista:</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxPista" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" ClientInstanceName="txtpista">
                </dx:ASPxTextBox>
                <h6>Coordenadas:</h6>
                
                <dx:ASPxTextBox ID="ASPxTextBoxCoordenadas" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" onkeydown="return soloNumeros(event);" ClientInstanceName="txtcoordenadas">
                    <MaskSettings Mask="000.00.00" />
                </dx:ASPxTextBox>
                 <dx:ASPxRadioButtonList ID="ASPxRadioButtonCoordenadasNorteSur" runat="server" SelectedIndex="1" ClientInstanceName="txtcoordenadasnortesur">
                                <Items>
                                    <dx:ListEditItem Text="Norte" Value="Norte" Selected="True" />
                                    <dx:ListEditItem Text="Sur" Value="Sur" />
                                    
                                </Items>
                       </dx:ASPxRadioButtonList>
              


               <div class="fondoTablaA"><p></p></div>

            </div>
            <div class="col-md-9 tablaCuerpoA">
              <!--  <h6><u>Severidad</u></h6> -->
                     <div class="row">
                    <div class="col-md-4">
                            
                         <h6>Altura (ft) NO ALTITUD</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxAlturaPies" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0" onkeydown="return soloNumeros(event);" ClientInstanceName="txtaltitud">
                            </dx:ASPxTextBox>
                            <h6>Velocidad Indicada Kt</h6>
                            <dx:ASPxTextBox ID="ASPxTextBoxVelocidadIndicada" runat="server" CssClass="form-control form-control-sm" Width="80%" native="false" Text="0" onkeydown="return soloNumeros(event);" ClientInstanceName="txtvelocidadindicada">
                            </dx:ASPxTextBox>
                          <h6>Condiciones de Luz</h6>
                    <dx:ASPxComboBox ID="ASPxComboBoxCondicionesLuz" runat="server" RepeatColumns="2" CssClass="form-control form-control-sm"  Width="80%"  Native="True" ClientInstanceName="cmbcondicionesluz">
                        <Items>
                        <dx:ListEditItem Text="Alba" Value="Alba" />
                        <dx:ListEditItem Text="Luz de Día" Value="Luz_de_Día" />
                        <dx:ListEditItem Text="Crepúsculo" Value="Crepúsculo" />
                        <dx:ListEditItem Text="Noche" Value="Noche" />
                        </Items>
                    </dx:ASPxComboBox>   
                           

                           


                    </div>
                    <div class="col-md-4">
                       
                    </div>
                    <div class="col-md-4">
                        

                       
                    </div>
                    <div class="col-12"><p></p></div> 
                </div>
                     <div class="row">
                     <div class="col-md-4">
                   
               </div>
                     <div class="col-md-4">
                
                     
                     </div>
                    <div class="col-12 tablaCuerpoA"><p></p></div> 
               </div>   
                          
           </div>
            
        </div>
        
        <%--naranja--%>
        <div class="row">
        <div class="col-12 fondoTablaB"><strong>Descripción del Evento y la Aeronave</strong></div>
            <div class="col-md-4 fondoCuerpoB">
            <h6>Identificación (Matrícula / Num de vuelo)</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxIdentificacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" ClientInstanceName="txtidentificacion">
            </dx:ASPxTextBox>

            <h6>Operador / Explotador</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxOperador" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" ClientInstanceName="txtoperador">
            </dx:ASPxTextBox>

            <h6>Marca / Modelo de Aeronave (Tipo de aeronave)</h6>
              <dx:ASPxTextBox ID="ASPxTextBoxTipoAeronave" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" ClientInstanceName="txtmarcamodeloaeronave">
              </dx:ASPxTextBox>

             <h6>Marca / Modelo de Motor</h6>
              <dx:ASPxTextBox ID="ASPxTextBoxModeloMotor" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
              </dx:ASPxTextBox>
              
             <h6>Posición si fue en ruta</h6>
              <dx:ASPxTextBox ID="ASPxTextBoxPosicionRuta" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
              </dx:ASPxTextBox>
              <p></p>

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
                  <h6>Cantidad de Aves (fauna) observadas</h6>
                 <dx:ASPxRadioButtonList ID="ASPxRadioButtonListCantidadAvesObservadas" runat="server" RepeatColumns="3" TabIndex="-1">
                <Items>
                    <dx:ListEditItem Text="1" Value="1" />
                    <dx:ListEditItem Text="2-10" Value="2-10" />
                    <dx:ListEditItem Text="11-100" Value="11-100" />
                    <dx:ListEditItem Text="Mas" Value="Mas" />
                    
                </Items>
            </dx:ASPxRadioButtonList>
            
            </div>
            <div class="col-md-4 fondoCuerpoB">
                <h6>Partes Golpeadas de la Aeronave</h6>
                <dx:ASPxCheckBoxList ID="ASPxCheckBoxListPartesGolpeadas" runat="server" ValueType="System.Boolean" RepeatColumns="2" RepeatDirection="Horizontal">
                        <Items>
                            
                            <dx:ListEditItem Text="Radomo Golpeado" Value="False" />
                            <dx:ListEditItem Text="Radomo Dañado" Value="False" />
                            <dx:ListEditItem Text="Parabrisas Golpeado" Value="False" />
                            <dx:ListEditItem Text="Parabrisas Dañado" Value="False" />
                            <dx:ListEditItem Text="Proa Golpeada" Value="False" />
                            <dx:ListEditItem Text="Proa Dañada" Value="False" />
                            <dx:ListEditItem Text="Motor1 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor1 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor2 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor2 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor3 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor3 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor4 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor4 Dañado" Value="False" />
                            <dx:ListEditItem Text="Hélice Golpeada" Value="False" />
                            <dx:ListEditItem Text="Hélice Dañada" Value="False" />
                            <dx:ListEditItem Text="Ala/Rotor Golpeado" Value="False" />
                             <dx:ListEditItem Text="Ala/Rotor Dañado" Value="False" />
                              <dx:ListEditItem Text="Fuselaje Golpeado" Value="False" />
                              <dx:ListEditItem Text="Fuselaje Dañado" Value="False" />
                             <dx:ListEditItem Text="Tren-de-Aterrizaje Golpeado" Value="False" />
                            <dx:ListEditItem Text="Tren-de-Aterrizaje Dañado" Value="False" />
                            <dx:ListEditItem Text="Cola Golpeada" Value="False" />
                             <dx:ListEditItem Text="Cola Dañada" Value="False" />
                            <dx:ListEditItem Text="Luces Golpeadas" Value="False" />
                            <dx:ListEditItem Text="Luces Dañadas" Value="False" />
                            <dx:ListEditItem Text="Otros" Value="False" />
                        </Items>
                    </dx:ASPxCheckBoxList>
                  <h6>Consecuencias de Vuelo</h6>
                <dx:ASPxCheckBoxList ID="ASPxCheckBoxListConsecuenciasVuelo" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                        <Items>
                            
                            <dx:ListEditItem Text="Ninguna" Value="Ninguna" />
                            <dx:ListEditItem Text="Despegue Interrumpido" Value="Despegue_Interrumpido" />
                            <dx:ListEditItem Text="Aterrizaje por Precaución" Value="Aterrizaje_por_Precaución" />
                            <dx:ListEditItem Text="Se Apagaron Motores" Value="Se_Apagaron_Motores" />
                            
                            
                        </Items>
                    </dx:ASPxCheckBoxList>
                <h6>Condiciones del Cielo</h6>
                <dx:ASPxCheckBoxList ID="ASPxCheckBoxListCondicionesCielo" runat="server" ValueType="System.String" RepeatColumns="2" RepeatDirection="Horizontal">
                        <Items>
                            
                            <dx:ListEditItem Text="Cielo Despejado" Value="Cielo Despejado" />
                            <dx:ListEditItem Text="Algunas Nubes" Value="Algunas Nubes" />
                            <dx:ListEditItem Text="Cielo Cubierto" Value="Cielo Cubierto" />
                           
                            
                            
                        </Items>
                    </dx:ASPxCheckBoxList>
                 <h6>Cantidad de Aves (fauna) golpeadas</h6>
                 <dx:ASPxRadioButtonList ID="ASPxRadioButtonListCantidadAvesGolpeadas" runat="server" RepeatColumns="3" TabIndex="-1">
                <Items>
                     <dx:ListEditItem Text="1" Value="1" />
                    <dx:ListEditItem Text="2-10" Value="2-10" />
                    <dx:ListEditItem Text="11-100" Value="11-100" />
                    <dx:ListEditItem Text="Mas" Value="Mas" />
                    
                </Items>
            </dx:ASPxRadioButtonList>
               
                <h6>Identificación de la especie de ave /fauna</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxIdentificacionfauna" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
            </dx:ASPxTextBox>
                <p></p>
            </div>
            <div class="col-md-4 fondoCuerpoB">
                 <h6>Partes Dañadas de la Aeronave</h6>
                <dx:ASPxCheckBoxList ID="ASPxCheckBoxListPartesDaniadas" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" ValueType="System.Boolean">
                        <Items>
                            
                            <dx:ListEditItem Text="Radomo Golpeado" Value="False" />
                            <dx:ListEditItem Text="Radomo Dañado" Value="False" />
                            <dx:ListEditItem Text="Parabrisas Golpeado" Value="False" />
                            <dx:ListEditItem Text="Parabrisas Dañado" Value="False" />
                            <dx:ListEditItem Text="Proa Golpeada" Value="False" />
                            <dx:ListEditItem Text="Proa Dañada" Value="False" />
                            <dx:ListEditItem Text="Motor1 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor1 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor2 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor2 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor3 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor3 Dañado" Value="False" />
                            <dx:ListEditItem Text="Motor4 Golpeado" Value="False" />
                            <dx:ListEditItem Text="Motor4 Dañado" Value="False" />
                            <dx:ListEditItem Text="Hélice Golpeada" Value="False" />
                            <dx:ListEditItem Text="Hélice Dañada" Value="False" />
                            <dx:ListEditItem Text="Ala/Rotor Golpeado" Value="False" />
                             <dx:ListEditItem Text="Ala/Rotor Dañado" Value="False" />
                              <dx:ListEditItem Text="Fuselaje Golpeado" Value="False" />
                              <dx:ListEditItem Text="Fuselaje Dañado" Value="False" />
                             <dx:ListEditItem Text="Tren-de-Aterrizaje Golpeado" Value="False" />
                            <dx:ListEditItem Text="Tren-de-Aterrizaje Dañado" Value="False" />
                            <dx:ListEditItem Text="Cola Golpeada" Value="False" />
                             <dx:ListEditItem Text="Cola Dañada" Value="False" />
                            <dx:ListEditItem Text="Luces Golpeadas" Value="False" />
                            <dx:ListEditItem Text="Luces Dañadas" Value="False" />
                            <dx:ListEditItem Text="Otros" Value="False" />
                        </Items>
                    </dx:ASPxCheckBoxList>
                <h6>Precipitación</h6>
                <dx:ASPxCheckBoxList ID="ASPxCheckBoxListPrecipitacion" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                        <Items>
                            
                            <dx:ListEditItem Text="Niebla" Value="Niebla" />
                            <dx:ListEditItem Text="Lluvia" Value="Lluvia" />
                            <dx:ListEditItem Text="Nieve" Value="Nieve" />
                           
                            
                            
                        </Items>
                    </dx:ASPxCheckBoxList>
                 <h6>Tamaño de las Aves (Fauna)</h6>
                <dx:ASPxRadioButtonList ID="ASPxRadioButtonListTamanioAves" runat="server" RepeatColumns="3" TabIndex="-1">
                <Items>
                     <dx:ListEditItem Text="Pequeñas" Value="Pequenias" />
                    <dx:ListEditItem Text="Medianas" Value="Medianas" />
                    <dx:ListEditItem Text="Grandes" Value="Grandes" />
                   
                    
                </Items>
               </dx:ASPxRadioButtonList>

                 <h6>Se advirtió al piloto del peligro?</h6>
                <dx:ASPxRadioButtonList ID="ASPxRadioButtonListAdvertenciaPiloto" runat="server" RepeatColumns="3" TabIndex="-1">
                <Items>
                     <dx:ListEditItem Text="Si" Value="Si" />
                    <dx:ListEditItem Text="No" Value="No" />
                   
                </Items>
               </dx:ASPxRadioButtonList>
                <div class="justify-content-end d-flex">
                   
                </div>

                    
               

            </div>
            
        </div> 
        
        <%--verde--%>
        <div class="row">
            <div class="col-12 fondoTablaC"><strong>Descripción del Suceso</strong></div>
             <div class="col-12 fondoCuerpoC"><p></p></div>
              <div class="col-md-3 fondoCuerpoC">
                   <h6>Tiempo que la aeronave estuvo fuera de servicio (horas)</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxTiempoFueraServicioAeronave" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" onkeydown="return soloNumeros(event);">
                </dx:ASPxTextBox>
                  <p></p> 
                  
                  <h6 class="text-justify font-italic">Describa el suceso con el mayor detalle posible, incluya aquellos aspectos 
                    que usted considere relevantes, o aquellos factores presumiblemente fueron la causa del evento o suceso</h6> 
                  
                         
              </div>

              <div class="col-md-5 fondoCuerpoC">
                   <h6>Costo estimado de la reparación o sustitución (en miles de USD)</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxCostoReparacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" onkeydown="return soloNumeros(event);">
                </dx:ASPxTextBox>
                  <p></p> 

             <dx:ASPxMemo ID="ASPxMemoDescripcion" runat="server"  Height="104px" CssClass="form-control form-control-sm"  Width="90%"  Native="True" EnableTheming="True" Style="text-align: center">
            </dx:ASPxMemo>
            </div>
              <div class="col-md-4 fondoCuerpoC">     
                   <h6>Otros Costos (en miles de USD)</h6>
                <dx:ASPxTextBox ID="ASPxTextBoxOtrosCostos" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True" onkeydown="return soloNumeros(event);">
                </dx:ASPxTextBox>
                  <p></p>    
               <h6>Adjuntar archivo</h6>
                <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnUploadControlArchivo">
                </dx:ASPxUploadControl>
                  <p></p> 
                <dx:ASPxButton ID="ASPxButtonEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnEnviar" OnClick="ASPxButton1_Click">
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
                              

              " Init="function(s, e) {
	BtnRecargar.SetVisible(false);

}" />
                 </dx:ASPxButton>
              </div>
            <div class="col-12 fondoCuerpoC"><p><dx:ASPxHiddenField runat="server" ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor"></dx:ASPxHiddenField></p></div>  
        </div>
    
</div>

<%--popup--%>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Width="215px" ClientInstanceName="popupcontrol2" HeaderText="Formulario IBIS" Theme="Glass"
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
                                     <dx:ASPxButton ID="ASPxButtonRegresar" runat="server" Text="Inicio" CssClass="btn btn-primary" Height="40px" Width="180px" Native="True">
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


