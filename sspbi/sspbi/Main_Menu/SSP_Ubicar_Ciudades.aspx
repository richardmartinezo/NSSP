<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SSP_Ubicar_Ciudades.aspx.vb" Inherits="sspbi.sspbi" MasterPageFile="~/Main_Menu.Master" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style2 {
            text-decoration: underline;
            font-size: xx-large;
        }

        .dxgvControl,
        .dxgvDisabled {
            border: 1px Solid #9F9F9F;
            font: 12px Tahoma, Geneva, sans-serif;
            background-color: #F2F2F2;
            color: Black;
            cursor: default;
        }

        .dxgvSearchPanel {
            padding: 7px;
            border-bottom: 1px solid #9F9F9F;
        }

        .dxeTrackBar,
        .dxeIRadioButton,
        .dxeButtonEdit,
        .dxeTextBox,
        .dxeRadioButtonList,
        .dxeCheckBoxList,
        .dxeMemo,
        .dxeListBox,
        .dxeCalendar,
        .dxeColorTable {
            -webkit-tap-highlight-color: rgba(0,0,0,0);
        }

        .dxeTextBox,
        .dxeButtonEdit,
        .dxeIRadioButton,
        .dxeRadioButtonList,
        .dxeCheckBoxList {
            cursor: default;
        }

        .dxeButtonEdit {
            background-color: white;
            border: 1px solid #9F9F9F;
            font: 12px Tahoma, Geneva, sans-serif;
        }

        .dxeTextBoxDefaultWidthSys,
        .dxeButtonEditSys {
            width: 170px;
        }

        .dxeButtonEdit .dxeEditArea {
            background-color: white;
        }

        .dxeEditArea {
            border: 1px solid #A0A0A0;
        }

        .dxeEditAreaSys {
            border: 0px !important;
            background-position: 0 0; /* iOS Safari */
            -webkit-box-sizing: content-box; /*Bootstrap correction*/
            -moz-box-sizing: content-box; /*Bootstrap correction*/
            box-sizing: content-box; /*Bootstrap correction*/
        }

        .dxeButtonEditButton.dxeButtonEditClearButton,
        .dxeButtonEditButton.dxeButtonEditClearButton:hover {
            background: none;
            border-width: 0;
            padding-top: 2px;
        }

        .dxeButtonEditSys .dxeButton,
        .dxeButtonEditSys .dxeButtonLeft {
            line-height: 100%;
        }

        .dxeButtonEditButton,
        .dxeSpinLargeIncButton,
        .dxeButtonEditButton {
            padding: 0px 2px 1px 3px;
        }

        .dxeButtonEditButton,
        .dxeCalendarButton,
        .dxeSpinIncButton,
        .dxeSpinDecButton,
        .dxeSpinLargeIncButton,
        .dxeSpinLargeDecButton,
        .dxeColorEditButton {
            vertical-align: middle;
            border: 1px solid #7f7f7f;
            cursor: pointer;
            text-align: center;
            white-space: nowrap;
        }

        .dxgvGroupPanel {
            padding: 7px 4px 8px 6px;
            white-space: nowrap;
        }

        .dxgvAdaptiveGroupPanel,
        .dxgvGroupPanel {
            background-color: #EDEDED;
            color: #8D8D8D;
            border-bottom: 1px Solid #9F9F9F;
        }

        .dxgvTable {
            -webkit-tap-highlight-color: rgba(0,0,0,0);
        }

        .dxgvTable {
            background-color: White;
            border-width: 0;
            border-collapse: separate !important;
            overflow: hidden;
        }

        .dxgvHeader {
            cursor: pointer;
            white-space: nowrap;
            padding: 4px 6px;
            border: 1px Solid #9F9F9F;
            background-color: #DCDCDC;
            overflow: hidden;
            font-weight: normal;
            text-align: left;
        }

        .dxgvFilterRow {
            background-color: #E7E7E7;
        }

        .dxeTextBox {
            background-color: white;
            border: 1px solid #9f9f9f;
            font: 12px Tahoma, Geneva, sans-serif;
        }

        .dxeTextBoxSys,
        .dxeMemoSys {
            border-collapse: separate !important;
        }

        .dxeTextBox .dxeEditArea {
            background-color: white;
        }

        .dxgvDataRowAlt {
            background-color: #EDEDEB;
        }

        .dxgvEmptyDataRow {
            color: Gray;
        }

        .dxgvPagerTopPanel,
        .dxgvPagerBottomPanel {
            padding-top: 4px;
            padding-bottom: 4px;
        }

        .dxgvStatusBar {
            border-top: 1px Solid #9F9F9F;
        }

        .dxgvCommandColumn {
            padding: 2px;
            white-space: nowrap;
        }

        .dxbButton {
            color: #000000;
            font: 12px Tahoma, Geneva, sans-serif;
            border: 1px solid #7F7F7F;
            padding: 1px;
        }

        .dxbButtonSys /*Bootstrap correction*/ {
            -webkit-box-sizing: content-box;
            -moz-box-sizing: content-box;
            box-sizing: content-box;
        }

        .dxbButtonSys {
            cursor: pointer;
            display: inline-block;
            text-align: center;
            white-space: nowrap;
        }

        .dxgvControl .dxgvErrorCell {
            padding-left: 5px;
            width: 1px;
        }
    </style>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolderBody">
    <div>

        <dx:ASPxButton ID="ASPxButtonAdministracionUsuarios" runat="server" Text="Administración de Usuarios" Theme="Glass">
        </dx:ASPxButton>

        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2"><strong>&nbsp;Gestión de la información SNSSO</strong></span><br />
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="Sql_SSP" KeyFieldName="id">
            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
            <Templates>
                <DetailRow>
                    <dx:ASPxGridView ID="DetailGridView" runat="server" AutoGenerateColumns="False" DataSourceID="Sql_SSP3" KeyFieldName="master_id" OnBeforePerformDataSelect="ASPxGridView2_BeforePerformDataSelect" OnCellEditorInitialize="DetailGridView_CellEditorInitialize" OnCustomUnboundColumnData="DetailGridView_CustomUnboundColumnData">
                        <SettingsEditing Mode="Batch">
                        </SettingsEditing>
                        <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                        <SettingsDataSecurity AllowEdit="False" />
                        <SettingsSearchPanel Visible="True" />
                        <EditFormLayoutProperties ColCount="3">
                        </EditFormLayoutProperties>
                        <Columns>
                            <dx:GridViewCommandColumn VisibleIndex="0">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="id_formulario" ReadOnly="True" VisibleIndex="1">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="master_id" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="path" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <Styles>
                            <AlternatingRow BackColor="#FFCC99">
                            </AlternatingRow>
                        </Styles>
                    </dx:ASPxGridView>
                    <br />
                    <dx:ASPxUploadControl ID="SSP_Upload_Control" runat="server" UploadMode="Auto" Width="280px" EnableTheming="True" ShowProgressPanel="True" ShowUploadButton="True" Theme="Moderno">
                        <AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="True" EnableMultiSelect="True">
                        </AdvancedModeSettings>
                        <FileSystemSettings UploadFolder="C:\SSP_Test" />
                    </dx:ASPxUploadControl>
                </DetailRow>
            </Templates>
            <SettingsEditing Mode="Batch">
            </SettingsEditing>
            <Settings ShowFilterRow="True" ShowGroupPanel="True" />
            <SettingsSearchPanel Visible="True" />
            <EditFormLayoutProperties ColCount="3">
            </EditFormLayoutProperties>
            <Columns>
                <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
                    <CustomButtons>
                        <dx:GridViewCommandColumnCustomButton Text="Boton">
                        </dx:GridViewCommandColumnCustomButton>
                    </CustomButtons>
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="1">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="form_id" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="entry_id" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="lugar" VisibleIndex="10" Caption="Lugar (Formulario)">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="fecha" VisibleIndex="5" Caption="Fecha Evento">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataComboBoxColumn FieldName="lugar_id" VisibleIndex="4" Caption="Lugar_Suceso">
                    <PropertiesComboBox DataSourceID="Sql_SSP1" TextField="Categoria" ValueField="Id">
                        <Columns>
                            <dx:ListBoxColumn FieldName="ciudad"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="aerodromo"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="aeropuerto"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="pais"></dx:ListBoxColumn>
                            <dx:ListBoxColumn FieldName="punto_ruta_oaci"></dx:ListBoxColumn>
                        </Columns>
                    </PropertiesComboBox>
                    <PropertiesComboBox DataSourceID="Sql_SSP0" EnableCallbackMode="True" FilterMinLength="3" LoadDropDownOnDemand="True" TextField="ciudad" ValueField="id" ValueType="System.Int32">
                        <Columns>
                            <dx:ListBoxColumn FieldName="ciudad" />
                            <dx:ListBoxColumn FieldName="aerodromo" />
                            <dx:ListBoxColumn FieldName="aeropuerto" />
                            <dx:ListBoxColumn FieldName="pais" />
                            <dx:ListBoxColumn FieldName="punto_ruta_oaci" />
                        </Columns>
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataCheckColumn FieldName="Validado" VisibleIndex="66">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataDateColumn FieldName="entry_date_created" VisibleIndex="6" Caption="Fecha de Ingreso">
                    <PropertiesDateEdit DisplayFormatString="">
                    </PropertiesDateEdit>
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataTextColumn FieldName="Gestion" VisibleIndex="9" Caption="Observaciones / Gestión">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Responsable" VisibleIndex="64">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn FieldName="id_categorias" VisibleIndex="7" Caption="Categorias">
                    <PropertiesComboBox DataSourceID="Sql_SSP2" TextField="Estado" ValueField="id">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataComboBoxColumn FieldName="Estado" VisibleIndex="8">
                </dx:GridViewDataComboBoxColumn>
            </Columns>

            <Styles>
                <AlternatingRow BackColor="#FFCC99">
                </AlternatingRow>
            </Styles>
        </dx:ASPxGridView>
        <br />
        <asp:SqlDataSource ID="Sql_SSP" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" DeleteCommand="DELETE FROM [Reportes_SSP_Master] WHERE [id] = @id" SelectCommand="SELECT id, form_id, entry_id, entry_date_created, nombre_formulario, fecha_creacion, nombre, email, telefono, ubicacion, lugar, lugar_id, fecha, hora, descripcion, [01_02_Explotador], [03_04_Marca_Modelo_de_Aeronave], [05_06_Marca_Modelo_de_Motor], [07_Matricula_de_Aeronave], [08_Fecha_del_Choque], [08_Fecha], [09_Hora], [10_Condiciones_de_Luz], [11_12_Nombre_del_Aerodromo], [11_12_14_Aerodromo_Posicion_si_se_conoce], [13_Pista_Utilizada], [14_Posicion_si_fue_en_ruta], [15_Altura_pies], [16_Velocidad_Indicada_nudos], [17_Fase_de_vuelo], [37_Condiciones_del_Cielo], [41_Especie_de_Ave], [42_Observadas], [43_Golpeadas], [44_Tamano_de_las_Aves], [45_Se_Advirtio_del_Peligro], [46_47_Observaciones], [52_Tiempo_Aeronave_Fuera_Servicio], [53_Costes_Estimado_para_Reparacion_o_Sustitucion], [54_Otros_Costes_Estimados], A1, A2, AD1, AD2, Adjuntar_Archivo, Aerodromo_Destino, Aerodromo_Salida, AI_Motor_1, AI_Motor_2, AS1, AS2, Carga_Trabajo_ATC, Categoria_Vuelo, CCO_ATC, Clase_de_Espacio_Aereo, Condiciones_de_Luz, Condiciones_Meteorologicas_Relevantes, Condiciones_Meteorologicas, CSR1, CSR2, Danadas, Dano_Aeronave, Duracion_Vuelo, Fase_Vuelo, Fatalidad_P, Fatalidad_T, Frecuencia_RTF, Golpeados, Graves_P, Graves_T, [Horizontal_(NM)], Jornada_Trabajo, Latitud, Lic_ATC, Longitud, M1, M2, Matricula, Menores_P, Menores_T, Modelo_Matricula, MSAW, MSR1, MSR2, Ninguno_P, Ninguno_T, Nombre_Espacio_Aereo, Nombre_Sector_ATC, Nombre_Unidad_ATS, NV1, NV2, O1, O2, Operador, Otras_Consecuencias_Vuelo, Otras_Danadas, Otras_Golpeadas, Otros_TO, PE_Motor_1, PE_Motor_2, RV1, RV2, Servicio_ATC_Provisto, STCA, Tipo_Espacio_Aereo, Tipo_Informacion_Trafico_Provisto, Tipo_de_Operacion, Tipo_Modulo, V1, V2, Vertical_FT, Validado, date, Gestion, Responsable, Adjuntos, Estado, id_categorias FROM Reportes_SSP_Master ORDER BY fecha, [08_Fecha], [08_Fecha_del_Choque]" UpdateCommand="UPDATE Reportes_SSP_Master SET lugar_id = @lugar_id, Validado = @Validado, Gestion = @Gestion, Responsable = @Responsable, Adjuntos = @Adjuntos, Estado = @Estado, id_categorias = @id_categorias WHERE (id = @id)">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int64" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="lugar_id" Type="Int64" />
                <asp:Parameter Name="Validado" />
                <asp:Parameter Name="Gestion" />
                <asp:Parameter Name="Responsable" />
                <asp:Parameter Name="Adjuntos" />
                <asp:Parameter Name="Estado" />
                <asp:Parameter Name="id_categorias" />
                <asp:Parameter Name="id" Type="Int64" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="Sql_SSP0" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" EnableCaching="True" SelectCommand="SELECT * FROM [Vista_aeropuertos]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="Sql_SSP1" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" EnableCaching="True" SelectCommand="SELECT * FROM [Categorias]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="Sql_SSP2" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" EnableCaching="True" SelectCommand="SELECT * FROM [Estado]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="Sql_SSP3" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT [id_formulario], [master_id], [path] FROM [Archivos_Formularios] where (master_id LIKE @master_id)
"
            InsertCommand="INSERT INTO Archivos_Formularios(master_id, path) VALUES (@master_id_insert, @path_insert)">
            <InsertParameters>
                <asp:Parameter Name="master_id_insert" />
                <asp:Parameter Name="path_insert" />
            </InsertParameters>
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="master_id" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
</asp:Content>
