<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PromoWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-3 needs-validation" novalidate="">
        <div class="col-12 position-relative">
            <asp:Label for="validacionVoucher" class="form-label" runat="server" Text="Label">¡Ingresá el código de tu voucher!</asp:Label>
            <asp:TextBox ID="validacionVoucher" type="text" class="form-control" placeholder="XXXXXXXXX" required="" runat="server"></asp:TextBox>
            <div class="invalid-tooltip">
                El código ingresado es inválido.
            </div>
        </div>
        <div class="col-12">
            <asp:Button id="botonValidar" class="btn btn-primary" type="submit" runat="server" Text="SIGUIENTE" Onclick="botonValidar_Click"/>
        </div>
    </div>

</asp:Content>