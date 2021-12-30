<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="reporte_accidentes_incidentes.aspx.vb" Inherits="sspbi.reporte_accidentes_incidentes" MasterPageFile="~/Main_Menu.Master" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content runat="server" ContentPlaceHolderID="head">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolderBody">

    <style type="text/css">
        .auto-style15 {
            width: 175px;
        }

        .auto-style34 {
            font-family: "Segoe UI";
            color: #FFFFFF;
            background-color: #000099;
        }

        .auto-style35 {
            width: 189px;
            height: 195px;
        }

        .auto-style36 {
            height: 23px;
        }

        .auto-style37 {
            height: 33px;
        }

        .auto-style38 {
            width: 190px;
        }
        .auto-style39 {
            height: 33px;
            width: 94px;
        }
        .auto-style40 {
            height: 23px;
            width: 94px;
        }
        .auto-style41 {
            width: 94px;
        }
        .auto-style42 {
            width: 94px;
            height: 108px;
        }
        .auto-style43 {
            height: 108px;
        }
    </style>


    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <div>

        <table>
            <tr>
                <td class="auto-style38">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" ShowCollapseButton="false" Theme="Glass" Width="200px" Border-BorderColor="Black" ShowHeader="False">
                                    <PanelCollection>
                                        <dx:PanelContent runat="server">
                                              <table style="height: 41px;">
                        <tr>
                            <td class="auto-style39"></td>
                            <td colspan="4" class="auto-style37">
                                
                                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="FORMULARIO RIPO (REPORTE OBLIGATORIO DE ACCIDENTES, INCIDENTES RSOO-01)" BackColor="#CCCCCC" Font-Bold="True" Font-Size="Large" ForeColor="Black" Theme="Glass">
                                </dx:ASPxLabel>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style40"></td>
                            <td colspan="4" class="auto-style36">

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="1. Datos del Notificante" Font-Bold="False" Font-Italic="True" Font-Size="Medium" Theme="Glass">
                                </dx:ASPxLabel>

                                <br />

                                <br />
                                Esta notificación se recibe sólo con fines de gestión y mejora continua de la seguridad operacional. RSOO-01<br />


                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td>

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Nombre y Apellido:" Font-Size="Medium">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxTextBox ID="ASPxTextBoxNombreApellido" runat="server" Width="170px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="El nombre es requerido" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>

                            </td>
                            <td colspan="2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td>

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="E-mail:" Font-Size="Medium">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxTextBox ID="ASPxTextBoxEmail" runat="server" Width="170px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="El correo es requerido" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>

                            </td>
                            <td colspan="2">&nbsp;</td>
                            <td>

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Teléfono:" Font-Size="Medium" Theme="Glass">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxTextBox ID="ASPxTextBoxTelefono" runat="server" Width="170px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="El telefono es requerido" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td colspan="4">

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="2. Detalle del Incidente/ Accidente " Font-Italic="True" Font-Size="Medium">
                                </dx:ASPxLabel>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style41" rowspan="3">&nbsp;</td>
                            <td rowspan="2">

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Lugar:" Font-Size="Medium">
                                </dx:ASPxLabel>
                                <br />
                                <br />
                                <dx:ASPxComboBox ID="ASPxComboBoxAeropuertos" runat="server" DataSourceID="SqlDataSourceAeropuertos" Theme="Glass" ValueField="id">
                                    <Columns>
                                        <dx:ListBoxColumn Caption="Codigo OACI" FieldName="punto_ruta_oaci" Name="OACI" />
                                        <dx:ListBoxColumn Caption="Codigo_IATA" FieldName="punto_ruta_iata" Name="Codigo_IATA" />
                                        <dx:ListBoxColumn Caption="Ciudad" FieldName="ciudad" Name="Ciudad" />
                                        <dx:ListBoxColumn Caption="Aeropuerto" FieldName="aerodromo" Name="Aeropuerto" />
                                    </Columns>
                                    <ValidationSettings>
                                        <RequiredField ErrorText="El lugar es requerido" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxComboBox>
                                <asp:SqlDataSource ID="SqlDataSourceAeropuertos" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT id, ciudad, pais, aeropuerto, aerodromo, punto_ruta_oaci, punto_ruta_iata, aerop_descrip, latitud, longitud, verificable FROM Vista_aeropuertos WHERE (verificable = 1)"></asp:SqlDataSource>

                                <br />
                                <dx:ASPxLabel ID="ASPxLabel12" runat="server" Font-Size="Medium" Text="Latitud:">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxTextBox ID="ASPxTextBoxLatitud" runat="server" Theme="Glass" Width="170px">
                                </dx:ASPxTextBox>

                            </td>
                            <td colspan="2" rowspan="3">&nbsp;</td>
                            <td>

                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />

                            </td>
                        </tr>
                                                  <tr>
                                                      <td>
                                                          <asp:RadioButtonList ID="RadioButtonListLatitudNorteSur" runat="server">
                                                              <asp:ListItem Value="NORTE">Norte</asp:ListItem>
                                                              <asp:ListItem Value="SUR">Sur</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td>
                                                          <dx:ASPxLabel ID="ASPxLabel13" runat="server" Font-Size="Medium" Text="Longitud:">
                                                          </dx:ASPxLabel>
                                                          <br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxLongitud" runat="server" Theme="Glass" Width="170px">
                                                          </dx:ASPxTextBox>
                                                      </td>
                                                      <td>
                                                          <asp:RadioButtonList ID="RadioButtonListLongitudEsteOeste" runat="server">
                                                              <asp:ListItem Value="ESTE">Este</asp:ListItem>
                                                              <asp:ListItem Value="OESTE">Oeste</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                      </td>
                                                  </tr>
                        <tr>
                            <td class="auto-style41"></td>
                            <td>

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Fecha (UTC):" Font-Size="Medium">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxDateEdit ID="ASPxDateEditFechaIncidente" runat="server" Theme="Glass">
                                </dx:ASPxDateEdit>

                            </td>
                            <td colspan="2">&nbsp;</td>
                            <td>

                                <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Hora (UTC):" Font-Size="Medium">
                                </dx:ASPxLabel>
                                <br />
                                <dx:ASPxTimeEdit ID="ASPxTimeEditHora" runat="server" Theme="Glass">
                                </dx:ASPxTimeEdit>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td colspan="4">

                                <br />

                                <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Severidad:" Font-Size="Medium">
                                </dx:ASPxLabel>

                            </td>
                        </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="4"><span style="color: rgb(102, 102, 102); font-family: sans-serif; font-size: 11.05px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgba(233, 231, 231, 0.7); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Muestra la gravedad del accidente/incidente en base a los daños humanos y materiales sufridos.</span></td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">
                                                          <dx:ASPxLabel ID="ASPxLabel14" runat="server" Font-Size="Small" Text="Tripulantes:">
                                                          </dx:ASPxLabel>
                                                      </td>
                                                      <td colspan="2">
                                                          <dx:ASPxLabel ID="ASPxLabel15" runat="server" Font-Size="Small" Text="Pasajeros:">
                                                          </dx:ASPxLabel>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">
                                                          <table>
                                                              <tr>
                                                                  <td><br />
                                                          Fatalidad:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxFatalidadT" runat="server" Width="170px" Theme="Glass">
                                                          </dx:ASPxTextBox>
                                                          <br /></td>
                                                              </tr>
                                                              <tr>
                                                                  <td> Graves:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxGravesT" runat="server" Width="170px" Theme="Glass">
                                                          </dx:ASPxTextBox>
                                                          <br /></td>
                                                              </tr>
                                                              <tr>
                                                                  <td> Menores:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxMenoresT" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br /></td>
                                                              </tr>  
                                                               <tr>
                                                                  <td> Ninguno:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxNingunoT" runat="server" Width="170px">
                                                          </dx:ASPxTextBox></td>
                                                              </tr>                                                                
                                                          </table>
                                                          
                                                         
                                                         
                                                         
                                                      </td>
                                                      <td colspan="2">Fatalidad:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxFatalidadP" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Menores:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxMenoresP" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Ninguno:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxNingunoP" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style42"></td>
                                                      <td class="auto-style43" colspan="2">
                                                          <br />
                                                          Daños Aeronave:<br />
                                                          <asp:RadioButtonList ID="RadioButtonListDanoAeronave" runat="server">
                                                              <asp:ListItem Value="DESTRUIDA">Destruida</asp:ListItem>
                                                              <asp:ListItem Value="SUSTANCIAL">Sustancial</asp:ListItem>
                                                              <asp:ListItem Value="MENOR">Menor</asp:ListItem>
                                                              <asp:ListItem Value="NINGUNA">Ninguna</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                          &nbsp;</td>
                                                      <td class="auto-style43" colspan="2"></td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="4">
                                                          <br />
                                                          <br />
                                                          Daños a Terceros (Especifique daño y cantidad si aplica)
                                                          <dx:ASPxMemo ID="ASPxMemoTercerosEsp" runat="server" Height="68px" Width="534px">
                                                          </dx:ASPxMemo>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="4">&nbsp;</td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">Condiciones Meteorológicas:<br />
                                                          <asp:RadioButtonList ID="RadioButtonCondicionesMet" runat="server">
                                                              <asp:ListItem>IMC</asp:ListItem>
                                                              <asp:ListItem>VMC</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                          <br />
                                                      </td>
                                                      <td colspan="2">Condiciones de Luz:<br />
                                                          <asp:RadioButtonList ID="RadioButtonCondicionesLuz" runat="server">
                                                              <asp:ListItem Value="ALBA">Alba</asp:ListItem>
                                                              <asp:ListItem Value="LUZ_DEL_DIA">Luz del Día</asp:ListItem>
                                                              <asp:ListItem Value="CREPUSCULO">Crepúsculo</asp:ListItem>
                                                              <asp:ListItem Value="NOCHE">Noche</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="4">
                                                          <dx:ASPxLabel ID="ASPxLabel16" runat="server" Font-Italic="True" Font-Size="Medium" Text="Identificación de la Aeronave">
                                                          </dx:ASPxLabel>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">
                                                          <br />
                                                          Tipo / Modelo:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxTipoModelo" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Operador:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxOperador" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Aeródromo Destino:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxAerodromoDestino" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Duración del Vuelo:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxDuracionVuelo" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                      </td>
                                                      <td colspan="2">Matrícula:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxMatricula" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Aeródromo de Salida:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxAerodromoSalida" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Fase Vuelo:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxFaseVuelo" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                          Num. Vuelo:<br />
                                                          <dx:ASPxTextBox ID="ASPxTextBoxNumVuelo" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                      </td>
                                                  </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">
                                                          <br />
                                                          Tipo de Operación <br />
                                                          <asp:RadioButtonList ID="RadioButtonTipoOperacion" runat="server">
                                                              <asp:ListItem Value="ENTRENAMIENTO">Entrenamiento</asp:ListItem>
                                                              <asp:ListItem Value="FUMIGACION">Fumigación</asp:ListItem>
                                                              <asp:ListItem Value="PASAJEROS">Pasajeros</asp:ListItem>
                                                              <asp:ListItem Value="CARGA">Carga</asp:ListItem>
                                                              <asp:ListItem Value="PRIVADO">Privado</asp:ListItem>
                                                              <asp:ListItem Value="OTROS">Otros</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                          <dx:ASPxTextBox ID="ASPxTextBoxOtros" runat="server" Width="170px">
                                                          </dx:ASPxTextBox>
                                                          <br />
                                                      </td>
                                                      <td colspan="2">
                                                          <br />
                                                          Categoría de Vuelo:<asp:RadioButtonList ID="RadioButtonCategoriaVuelo" runat="server">
                                                              <asp:ListItem Value="VFR">VFR</asp:ListItem>
                                                              <asp:ListItem Value="IFR">IFR</asp:ListItem>
                                                          </asp:RadioButtonList>
                                                      </td>
                                                  </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td colspan="4">

                                Descripción Narrativa:<br />
                                <dx:ASPxMemo ID="ASPxMemoDescripcion" runat="server" Height="150px" Width="500px">
                                </dx:ASPxMemo>

                            </td>
                        </tr>
                                                  <tr>
                                                      <td class="auto-style41">&nbsp;</td>
                                                      <td colspan="2">&nbsp;<dx:ASPxButton ID="ASPxButtonEnviar" runat="server" Height="52px" Text="Enviar" Theme="Glass" Width="157px">
                                                          <ClientSideEvents Click="function(s, e) {
	}" />
                                                          </dx:ASPxButton>
                                                      </td>
                                                      <td colspan="2">
                                                          <dx:ASPxUploadControl ID="ASPxUploadControlArchivo" runat="server" Width="280px">
                                                          </dx:ASPxUploadControl>
                                                      </td>
                                                  </tr>
                        <tr>
                            <td class="auto-style41">&nbsp;</td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                    </table>
                                        </dx:PanelContent>
                                                                                </PanelCollection>

<Border BorderColor="Black"></Border>
                                </dx:ASPxRoundPanel>
                  
                </td>
            </tr>

        </table>




    </div>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Width="462px" ClientInstanceName="popupcontrol2" HeaderText="Atención" Theme="Glass">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <table class="dxflInternalEditorTable_SoftOrange" style="height: 246px; width: 102%">
                    <tr>
                        <td class="auto-style15" rowspan="2">&nbsp;<img alt="" class="auto-style35" src="../Images/Formulario-enviado.png" /></td>
                        <td class="auto-style34">FORMULARIO DE REPORTE OBLIGATORIO DE ACCIDENTES, INCIDENTES Y PELIGROS OPERACIONALES RSOO-01 HA SIDO REMITIDO /
                             OBLIGATORY REPORT OF ACCIDENTS, INCIDENTES AND OPERATIONAL HAZARDS RSOO-01 FORM HAS BEEN SUBMITTED</td>
                    </tr>
                    <tr>
                        <td>Su información del FORMULARIO DE REPORTE OBLIGATORIO DE ACCIDENTES, INCIDENTES Y PELIGROS OPERACIONALES RSOO-01 HA SIDO REMITIDO.<br />
                            Your information from the OBLIGATORY REPORT OF ACCIDENTS, INCIDENTES AND OPERATIONAL HAZARDS RSOO-01 FORM HAS BEEN SUBMITTED.</td>
                    </tr>
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td rowspan="2">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Regresar!" Theme="Glass">
                                    </dx:ASPxButton>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
