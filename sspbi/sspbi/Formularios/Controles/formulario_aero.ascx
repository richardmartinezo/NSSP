<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="formulario_aero.ascx.vb" Inherits="sspbi.formulario_aero" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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

<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div class="container">
        <%--azul--%>   
        <div class="row">
          <div class="col-12">
              <p class="font-italic">  Formulario AERO, Notificación de fallas de sistemas o componentes de una aeronave.</p>
          </div>
          <div class="col-6 fondoTabla text-white"><strong>Notificación AÉRO</strong></div>
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
                                <ValidationSettings EnableCustomValidation="True"  SetFocusOnError="True"
                                    ErrorDisplayMode="Text" ErrorTextPosition="Bottom" CausesValidation="True">
                                        <RequiredField ErrorText="*Teléfono requiredo" IsRequired="True"/>
                                            <ErrorFrameStyle Font-Size="12px">
                                            <ErrorTextPaddings PaddingLeft="0px" />
                                            </ErrorFrameStyle>
                                </ValidationSettings>
                            </dx:ASPxTextBox>
            </div>
          </div>
        </div>
            <div class="col-md-6">
                                    <h6>Actividad:</h6>
                                    
                                        <dx:ASPxRadioButtonList ID="ASPxRadioButtonListEnviadoPor" runat="server" RepeatColumns="3">
                                            <Items>
                                                <dx:ListEditItem Text="OMA" Value="OMA" />
                                                <dx:ListEditItem Text="Explotador" Value="EXPLOTADOR" />
                                                <dx:ListEditItem Text="Técnico" Value="TECNICO" />
                                                <dx:ListEditItem Text="Taxi Aéreo" Value="TAXI_AEREO" />
                                                <dx:ListEditItem Text="Fabricante" Value="FABRICANTE" />
                                                <dx:ListEditItem Text="AAC" Value="AAC" />
                                                <dx:ListEditItem Text="Otro" Value="Otro" />
                                            </Items>
                                        </dx:ASPxRadioButtonList>                                       
                                        
                                        <p></p> 

        </div>
        </div> 
      <%--amarillo--%>
         <div class="row fondoTablaA">
                <div class="col-12"><strong>Información del suceso</strong></div>
                <div class="col-md-4 tablaCuerpoA">
                    <h6><u>Fecha</u></h6>
                    <p></p>
                    <h6>Día / Mes / Año (UTC):</h6>
                        <dx:ASPxDateEdit runat="server" ID="ASPxDateEditFecha" CssClass="form-control form-control-sm" Width="80%" native="false"></dx:ASPxDateEdit> 
                <h6>Hora:</h6>
                     <dx:ASPxTimeEdit runat="server" ID="ASPxTimeEditHora" CssClass="form-control form-control-sm" Width="80%" native="false" ClientInstanceName="timehora"></dx:ASPxTimeEdit>
                
                </div>
                <div class="col-md-8 tablaCuerpoA">
                    <h6><u>Identificador del Componente Mayor</u></h6>
                    <p></p>
                    <h6><strong>Aeronave</strong></h6>
                    <div class="row">
                         <div class="col-md-4">
                            <h6>Fabricante:</h6>
                            <dx:ASPxTextBox runat="server"  ID="ASPxTextBoxFabricanteAeronave" Width="90%" CssClass="form-control form-control-sm" Native="True">
                        <ValidationSettings>
                        </ValidationSettings>
                        </dx:ASPxTextBox>
                        </div>
                         <div class="col-md-4">
                         <h6>Modelo:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxModeloAeronave" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                         <div class="col-md-4">
                         <h6>No Serie:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNumeroSerieAeronave" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                    </div> 

                    <h6><strong>Motor</strong></h6>
                    <div class="row">
                         <div class="col-md-4">
                            <h6>Fabricante:</h6>
                            <dx:ASPxTextBox runat="server"  ID="ASPxTextBoxFabricanteMotor" Width="90%" CssClass="form-control form-control-sm" Native="True">
                        <ValidationSettings>
                        </ValidationSettings>
                        </dx:ASPxTextBox>
                        </div>
                         <div class="col-md-4">
                         <h6>Modelo:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxModeloMotor" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                         <div class="col-md-4">
                         <h6>No Serie:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNumeroSerieMotor" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                    </div> 
            
                    <h6><strong>Helice</strong></h6>
                    <div class="row">
                         <div class="col-md-4">
                            <h6>Fabricante:</h6>
                            <dx:ASPxTextBox runat="server"  ID="ASPxTextBoxFabricanteHelice" Width="90%" CssClass="form-control form-control-sm" Native="True">
                        <ValidationSettings>
                        </ValidationSettings>
                        </dx:ASPxTextBox>
                        </div>
                         <div class="col-md-4">
                         <h6>Modelo:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxModeloHelice" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                         <div class="col-md-4">
                         <h6>No Serie:</h6>
                            <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNumeroSerieHelice" Width="90%" CssClass="form-control form-control-sm" Native="True">
                            <ValidationSettings>
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                           </div>
                    </div> 

                    <h6>Fases de Funcionamiento / Mantenimiento</h6>

                       <dx:ASPxRadioButtonList ID="ASPxRadioButtonListFasesFuncionamiento" runat="server" Theme="Glass" RepeatColumns="3" TabIndex="1">
                                            <Items>
                                                <dx:ListEditItem Text="Tierra" Value="TIERRA" />
                                                <dx:ListEditItem Text="Rodaje" Value="RODAJE" />
                                                <dx:ListEditItem Text="Despegue" Value="DESPEGUE" />
                                                <dx:ListEditItem Text="Ascenso" Value="ASCENSO" />
                                                <dx:ListEditItem Text="Crucero" Value="CRUCERO" />
                                                <dx:ListEditItem Text="Descenso" Value="DESCENSO" />
                                                <dx:ListEditItem Text="Aterrizaje" Value="ATERRIZAJE" />
                                                <dx:ListEditItem Text="Otro" Value="Otro" />
                                            </Items>
                                </dx:ASPxRadioButtonList>    
                </div>
                <div class="col-12 tablaCuerpoA"><p></p></div>
        </div> 
    
    <%--amarillo2--%> 
        <div class="row">
        <div class="col-12 fondoTablaA"><strong>Parte específica (componente) que causó el problema</strong></div>
        </div>
        <div class="row tablaCuerpoA">
                <div class="col-sm-4">
                     <h6>Nombre de la Parte:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNombreParte" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>

                     <h6>Ubicación de la parte / defecto:</h6>
                     <dx:ASPxTextBox runat="server" ID="ASPxTextBoxUbicacionParte" Width="90%" CssClass="form-control form-control-sm" Native="True">    
                     </dx:ASPxTextBox>

                    <h6>Tiempo desde OVH (TSO):</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxTiempoOVH" Width="90%" CssClass="form-control form-control-sm" Native="True">
                   </dx:ASPxTextBox>

                    <h6>Nº parte / modelo del fabricante:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxModeloFabricante" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>             
                </div>
                <div class="col-sm-4">
                     <h6>Nº de parte del fabricante:</h6>
                     <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNumeroParteFabricante" Width="90%" CssClass="form-control form-control-sm" Native="True">                                  
                     </dx:ASPxTextBox> 

                    <h6>Componente / sistema en el que está instalada la parte:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxComponenteSistema" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>
                    
                     <h6>Nombre del componente / sistema:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNombreComponente" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>

                     <h6>Nº de serie:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxNumSerie" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>
               </div>
                <div class="col-sm-4">

                     <h6>Condición de la parte:</h6>
                     <dx:ASPxTextBox runat="server" ID="ASPxTextBoxCondicionParte" Width="90%" CssClass="form-control form-control-sm" Native="True">  
                     </dx:ASPxTextBox> 

                     
                    <h6>Tiempo Total (TT):</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxTiempoTotal" Width="90%" CssClass="form-control form-control-sm" Native="True">               
                    </dx:ASPxTextBox>

                    
                    <h6>Fabricante:</h6>
                    <dx:ASPxTextBox runat="server" ID="ASPxTextBoxFabricante" Width="90%" CssClass="form-control form-control-sm" Native="True">
                    </dx:ASPxTextBox>
                    
                    
                    
                </div> 
                <div class="col-12 fondoCuerpoA"><p></p></div>              
            </div>
        
    <%--verde--%>
        <div class="row">
        <div class="col-12 fondoTablaC"><strong>Descripción del Problema:</strong></div>
        </div>    
        <div class="row fondoCuerpoC">
            <div class="col-12 fondoCuerpoC"><p></p></div> 
            <div class="col-md-8">
               <dx:ASPxMemo ID="ASPxMemoTexto" runat="server" Height="104px" CssClass="form-control form-control-sm"  Width="90%"  Native="True" EnableTheming="True">
               </dx:ASPxMemo>
            </div>
            <div class="col-md-4 ">
                <h6>Adjuntar Archivo:</h6>
               <dx:ASPxUploadControl ID="ASPxUploadControlArchivos" runat="server" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnUploadControlArchivo">
               </dx:ASPxUploadControl>
                <p></p> 
               <dx:ASPxButton runat="server" Text="Enviar" ID="ASPxButtonEnviarFormulario" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnEnviar">
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
            <div class="col-12 fondoCuerpoC"><p>
                <dx:ASPxHiddenField runat="server" ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor">

                </dx:ASPxHiddenField>
                                             </p></div>
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
                                        
                                                        <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Inicio" CssClass="btn btn-primary" Height="40px" Width="180px" Native="True">
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

<%--fin--%>





  









