<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="reporte_voluntario.aspx.vb" Inherits="sspbi.reporte_voluntario" MasterPageFile="~/Main_Menu.Master" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content runat="server" ContentPlaceHolderID="head">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolderBody">

    <style type="text/css">
            .fondoForm {
            position: relative;
            width: 80%;
            height: 80%;
            background-color: #ceffff; 
        }
          .titulo {
          position : absolute;
          left : 415px;
          top  : 185px;

          font : 1em "typewriter", sans-serif;
        }

    </style>


    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <dx:ASPxCallback ID="ASPxCallbackVoluntarios" runat="server" ClientInstanceName="ASPxCallbackVoluntarios">
    </dx:ASPxCallback>
 <div class="container" id="div_main">       

    <div class="row mx-auto fondoForm">
        <div class="col-xs-6 col-md-10 mt-5 mx-auto">
            <h4>Formulario de Notificacion Voluntaria</h4>
            <p></p>
        </div>

        <div class="col-xs-6 col-md-8 mx-auto">
            <h5 class="font-italic">1. Datos de del Notificante</h5>
        </div>
 
        <div class="row col-xs-6 col-md-8 mx-auto">
            <div class="col-xs-6 col-md-6">
                    <h6>Nombre y Apellido:</h6>
                    <dx:ASPxTextBox ID="ASPxTextBoxNombreApellido" runat="server" CssClass="form-control"  Width="80%"  Native="True" onkeydown="return soloLetra(event);" ClientInstanceName="txtnombreapellido">
                        <ValidationSettings EnableCustomValidation="True"  SetFocusOnError="True"
                            ErrorDisplayMode="Text" ErrorTextPosition="Bottom" CausesValidation="True">
                                <RequiredField ErrorText="*Nombre/Apellido requiredo" IsRequired="True"/>
                                    <ErrorFrameStyle Font-Size="12px">
                                    <ErrorTextPaddings PaddingLeft="0px" />
                                    </ErrorFrameStyle>
                        </ValidationSettings>
                   </dx:ASPxTextBox>
                    <p></p>
                </div>
            <div class="col-xs-6 col-md-6">
                    <h6>E-mail:</h6>
                    <dx:ASPxTextBox ID="ASPxTextBoxEmail" runat="server" CssClass="form-control" Width="80%"  Native="True" ClientInstanceName="txtemail"> 
                        
                    </dx:ASPxTextBox>
                           <asp:RegularExpressionValidator Font-Size="12px"
                                 ControlToValidate="ASPxTextBoxEmail"
                                 Text="Correo invalido."
                                 ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                 Runat="Server" />

                <p></p>
            </div>
            <div class="col-xs-6 col-md-6">
                    <h6>Teléfono:</h6>
                    <dx:ASPxTextBox ID="ASPxTextBoxTelefono" runat="server" CssClass="form-control" Width="80%"  Native="True" onkeydown="return soloNumeros(event);" ClientInstanceName="txttelefono">
                        
                    </dx:ASPxTextBox>
                <p></p>
            </div>
        </div> 
 
        <div class="col-xs-6 col-md-8 mx-auto">
            <p></p>   
        <h5 class="font-italic">2. Detalle de la Ocurrencia</h5>
        </div>      
        <div class="row col-xs-6 col-md-8 mx-auto">
            <div class="col-xs-3 col-md-6">
                    <h6>Lugar:</h6>
                    <dx:ASPxComboBox ID="ASPxComboBoxAeropuertos" runat="server" DataSourceID="SqlDataSourceAeropuertos" CssClass="form-control" Width="100%" ValueField="id" Native="True">
                        <Columns>
                            <dx:ListBoxColumn Caption="Codigo OACI" FieldName="punto_ruta_oaci" Name="OACI" />
                            <dx:ListBoxColumn Caption="Codigo_IATA" FieldName="punto_ruta_iata" Name="Codigo_IATA" />
                            <dx:ListBoxColumn Caption="Ciudad" FieldName="ciudad" Name="Ciudad" />
                            <dx:ListBoxColumn Caption="Aeropuerto" FieldName="aerodromo" Name="Aeropuerto" />
                        </Columns>
                       
                    </dx:ASPxComboBox>
                    <p></p>
                    <asp:SqlDataSource ID="SqlDataSourceAeropuertos" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT id, ciudad, pais, aeropuerto, aerodromo, punto_ruta_oaci, punto_ruta_iata, aerop_descrip, latitud, longitud, verificable FROM Vista_aeropuertos WHERE (verificable = 1)"></asp:SqlDataSource>
                </div>
            <div class="col-xs-6 col-md-6">
                    <h6>Prov. Serv./Oper. Aéreo:</h6>
                    <dx:ASPxTextBox ID="ASPxTextBoxProveedorServicios" runat="server" CssClass="form-control" Width="100%" Native="True">
                    </dx:ASPxTextBox>
                    <p></p>
            </div>
            <div class="col-xs-6 col-md-6">
                    <h6>Fecha:</h6>
                    <dx:ASPxDateEdit ID="ASPxDateEditFecha" runat="server" CssClass="form-control" Width="80%">
                    </dx:ASPxDateEdit>
                    <p></p>
            </div>
            <div class="col-xs-6 col-md-6">
                    <h6>Hora UTC:</h6>
                    <dx:ASPxTimeEdit ID="ASPxTimeEditHora" runat="server" CssClass="form-control" Width="80%">
                    </dx:ASPxTimeEdit>
                    <p></p>    
            </div>
            <div class="col-xs-6 col-md-12">
                    <h6>Descripción Narrativa:</h6>
                    <dx:ASPxMemo ID="ASPxMemoDescripcionNarrativa" runat="server" EnableTheming="True" CssClass="form-control" Height="50%" Width="100%" Native="True">
                    </dx:ASPxMemo>
                    <p></p>
            </div>
            <div class="col-xs-6 col-md-6">
                <dx:ASPxUploadControl ID="ASPxUploadControlArchivo" runat="server" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnUploadControlArchivo">
                </dx:ASPxUploadControl>
                <p></p>    
            </div>   
            <div class="col-xs-6 col-md-6">
                <dx:ASPxButton ID="ASPxButtonEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" Height="50px" Width="180px" Native="True" ClientInstanceName="BtnEnviar" >
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
                <p>
                    
                    <dx:ASPxHiddenField ID="HiddenFieldValor" ClientInstanceName="HiddenFieldValor" runat="server">

                    </dx:ASPxHiddenField>
                </p>
            </div>       
        </div>      
         
       </div> 
    </div>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Width="375px" ClientInstanceName="popupcontrol2" HeaderText="Formulario Voluntario" Theme="Glass"
        llowDragging="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="268px">
        <ClientSideEvents PopUp="function(s, e) {


	
}" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
               <table class="dxflInternalEditorTable_SoftOrange" style="height: 146px; width: 50%">
                    <tr>
                         <td class="auto-style34">
                               <img alt="" class="" src="../Images/ok.jpg" />
                                   &nbsp;<asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                     
                                <ContentTemplate>
                                     <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Inicio" CssClass="btn btn-primary" Height="40px" Width="180px" Native="True">
                                       </dx:ASPxButton>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>

                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>

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

           
            function OnClick(s, e) {
                e.processOnServer = !isPostbackInitiated;
                isPostbackInitiated = true;
                BtnEnviar.SetEnabled = false;
            }


        </script>

</asp:Content>
