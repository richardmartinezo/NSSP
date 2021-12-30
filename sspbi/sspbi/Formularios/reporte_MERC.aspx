<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="reporte_MERC.aspx.vb" Inherits="sspbi.reporte_MERC" MasterPageFile="~/Main_Menu.Master" %>
<%@ Register TagName="formulario_MERC" TagPrefix="form_MERC" Src="~/Formularios/Controles/formulario_MERC.ascx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content runat="server" ContentPlaceHolderID="head">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</asp:Content>
  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderForms" runat="server">
      <div class="container"> 
        <form_MERC:formulario_MERC ID="formulario_MERC" runat="server" UpdateMode="Conditional"/>
      </div>
</asp:Content>
