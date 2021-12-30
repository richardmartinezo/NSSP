<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main_Menu.Master" CodeBehind="reporte_aero.aspx.vb" Inherits="sspbi.reporte_aero" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagName="formulario_aero" TagPrefix="form_aero" Src="~/Formularios/Controles/formulario_aero.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderForms" runat="server">
    <div class="container">  
            <form_aero:formulario_aero ID="formulario_aero" runat="server" UpdateMode="Conditional"/>
    </div>
</asp:Content>
