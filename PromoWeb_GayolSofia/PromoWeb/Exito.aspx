<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="PromoWeb.Exito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡YA ESTÁS PARTICIPANDO!</h1>

    <asp:Panel ID="PanelConfirmacion" runat="server">
        <h3>Datos del Cliente</h3>
        <p><strong>Nombre:</strong> <asp:Label ID="lblNombre" runat="server"></asp:Label></p>
        <p><strong>Apellido:</strong> <asp:Label ID="lblApellido" runat="server"></asp:Label></p>

        <h3>Datos del Artículo</h3>
        <p><strong>Artículo Seleccionado:</strong> <asp:Label ID="lblArticulo" runat="server"></asp:Label></p>

        <h3>Datos del Voucher</h3>
        <p><strong>Código de Voucher:</strong> <asp:Label ID="lblCodigoVoucher" runat="server"></asp:Label></p>
    </asp:Panel>

</asp:Content>
