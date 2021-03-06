<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="formulario_ACTIL.ascx.vb" Inherits="sspbi.formulario_ACTIL" %>
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
              <p class="font-italic">  Formulario ACTIL</p>
          </div>
          <div class="col-6 fondoTabla text-white"><strong>Notificación ACTIL</strong></div>
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
                <asp:SqlDataSource ID="SqlDataSourceAeropuertos" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT Vista_aeropuertos.* FROM Vista_aeropuertos where verificable_ssp = 1"></asp:SqlDataSource>                                    
                
               

            </div>
            <div class="col-md-9 tablaCuerpoA">
               
                     <div class="row">
                    <div class="col-md-4">
                        <p>

                        </p>
                        <h6>Instalación:</h6>
                         <dx:ASPxTextBox ID="ASPxTextBoxInstalacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">

                         </dx:ASPxTextBox>
                        <h6>Aeronave:</h6>
                        <dx:ASPxTextBox ID="ASPxTextBoxAeronave" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">

                         </dx:ASPxTextBox>
                        

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
        <div class="col-12 fondoTablaB"><strong>Identificación de la aeronave</strong></div>
            <div class="col-md-4 fondoCuerpoB">
            <h6>Identificación (Matrícula / Num de vuelo)</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxIdentificacion" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
            </dx:ASPxTextBox>

            <h6>Operador/ Aerolínea</h6>
            <dx:ASPxTextBox ID="ASPxTextBoxOperador" runat="server" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
            </dx:ASPxTextBox>

           
            
            </div>
            <div class="col-md-4 fondoCuerpoB">
                <h6>Aeródromo de salida</h6>           
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertosSalida" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                </dx:ASPxComboBox>

                <h6>Aeródromo de destino</h6>
                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertosDestino" runat="server" DataSourceID="SqlDataSourceAeropuertos" TextField="punto_ruta_oaci" ValueField="id" CssClass="form-control form-control-sm"  Width="90%"  Native="True">
                </dx:ASPxComboBox>

               

            </div>
            <div class="col-md-4 fondoCuerpoB">
             
             <p></p> 
            <div class="justify-content-end d-flex">
            
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
                              

              "/>
                 </dx:ASPxButton>
                  <dx:ASPxHiddenField runat="server" ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor">

                  </dx:ASPxHiddenField>
              </div>
            <div class="col-12 fondoCuerpoC"><p></p></div>  
        </div>
    
</div>

<%--popup--%>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Width="400px" Height="400px" ClientInstanceName="popupcontrol2" HeaderText="Formulario ACTIL" Theme="Glass"
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
