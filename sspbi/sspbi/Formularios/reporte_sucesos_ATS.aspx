<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main_Menu.Master" CodeBehind="reporte_sucesos_ATS.aspx.vb" Inherits="sspbi.reporte_sucesos_ATS" %>
<%@ Register TagName="formulario_ATS" TagPrefix="form_ATS" Src="~/Formularios/Controles/formulario_ATS.ascx" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderForms" runat="server">
    <div class="container">  
                <form_ATS:formulario_ATS ID="formulario_ATS" runat="server" UpdateMode="Conditional"/>
    </div>                 
</asp:Content>
