<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main_Menu.Master" CodeBehind="Usuarios.aspx.vb" Inherits="sspbi.Usuarios" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

        <dx:ASPxButton ID="ASPxButtonRegresar" runat="server" Text="Regresar" Theme="Glass">
        </dx:ASPxButton>

        <dx:ASPxGridView ID="ASPxGridViewUsuarios" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceUsuarios" EnableTheming="True" KeyFieldName="id" Theme="Glass">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="usuario" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="password" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewCommandColumn Caption="Comandos" ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="True" ShowUpdateButton="True" VisibleIndex="0">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="mail" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="nivel_acceso" VisibleIndex="5">
                <PropertiesComboBox DataSourceID="SqlDataSourceNivelAcceso" TextField="permiso" ValueField="permiso">
                    <Columns>
                        <dx:ListBoxColumn FieldName="permiso">
                        </dx:ListBoxColumn>
                        <dx:ListBoxColumn FieldName="descripcion">
                        </dx:ListBoxColumn>
                    </Columns>
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" DeleteCommand="UPDATE Usuarios_SSP SET estado = 'inactivo', nivel_acesso = 'N/A' WHERE (id = @id)" InsertCommand="INSERT INTO Usuarios_SSP(usuario, password, mail, nivel_acceso) VALUES (@usuario, @password, @mail, @nivel_acceso)" SelectCommand="SELECT id, usuario, password, mail, nivel_acceso FROM Usuarios_SSP WHERE (estado = 'activo')" UpdateCommand="UPDATE Usuarios_SSP SET usuario = @usuario, password = @password , mail = @mail, nivel_acceso=@nivel_acceso WHERE (id = @id)">
        <DeleteParameters>
            <asp:Parameter Name="id" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="usuario" />
            <asp:Parameter Name="password" />
            <asp:Parameter Name="mail" />
            <asp:Parameter Name="nivel_acceso" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="usuario" />
            <asp:Parameter Name="password" />
            <asp:Parameter Name="mail" />
            <asp:Parameter Name="nivel_acceso" />
            <asp:Parameter Name="id" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceNivelAcceso" runat="server" ConnectionString="<%$ ConnectionStrings:SSP_BIConnectionString2 %>" SelectCommand="SELECT Nivel_Acceso.* FROM Nivel_Acceso">
    </asp:SqlDataSource>
</asp:Content>
