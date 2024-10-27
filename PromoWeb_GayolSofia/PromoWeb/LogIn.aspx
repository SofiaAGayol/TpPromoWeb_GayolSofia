<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PromoWeb.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>



    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <div class="row g-3" novalidate="">

                <div class="col-12">
                    <asp:Label for="txtDNI" class="form-label" runat="server" Text="Label">Igrese su DNI sin puntos ni guiones</asp:Label>
                    <div class="input-group md-3">
                        <asp:TextBox CausesValidation="false" ID="txtDNI" type="text" class="form-control" placeholder="12345678" runat="server" AutoPostBack="true" aria-describedby="btnDNI"></asp:TextBox>
                        <asp:Button ID="btnDNI" class="btn btn-outline-secondary" type="button" runat="server" Text="Validar DNI" OnClick="btnDNI_Click" />
                    </div>
                </div>

                <div class="col-md-4 position-relative">
                    <asp:Label for="txtNombre" class="form-label" runat="server" Text="Label">Nombre</asp:Label>
                    <asp:TextBox AutoPostBack="true" ID="txtNombre" type="text" class="form-control" value="Juan" runat="server"></asp:TextBox>
                </div>


                <div class="col-md-4 position-relative">
                    <asp:Label for="txtApellido" class="form-label" runat="server" Text="Label">Apellido</asp:Label>
                    <asp:TextBox AutoPostBack="true" ID="txtApellido" type="text" class="form-control" placeholder="Argento" runat="server"></asp:TextBox>
                </div>


                <div class="col-md-4 position-relative">
                    <asp:Label for="txtEmail" class="form-label" runat="server" Text="Label">Email</asp:Label>
                    <div class="input-group has-validation">
                        <span class="input-group-text" id="txtEmailPrepend">@</span>
                        <asp:TextBox AutoPostBack="true" ID="txtEmail" type="text" class="form-control" placeholder="12345678" aria-describedby="validationTooltipUsernamePrepend" runat="server"></asp:TextBox>
                    </div>
                </div>


                <div class="col-md-6 position-relative">
                    <asp:Label for="txtDireccion" class="form-label" runat="server" Text="Label">Direccion</asp:Label>
                    <asp:TextBox AutoPostBack="true" ID="txtDireccion" type="text" class="form-control" placeholder="Mi ciudad"  runat="server"></asp:TextBox>
                </div>


                <div class="col-md-3 position-relative">
                    <asp:Label for="txtCiudad" class="form-label" runat="server" Text="Label">Ciudad</asp:Label>
                    <asp:TextBox AutoPostBack="true" ID="txtCiudad" type="text" class="form-control" placeholder="Mi ciudad"  runat="server"></asp:TextBox>
                </div>


                <div class="col-md-3 position-relative">
                    <asp:Label for="txtCP" class="form-label" runat="server" Text="Label">CP</asp:Label>
                    <asp:TextBox AutoPostBack="true" ID="txtCP" type="text" class="form-control" placeholder="XXXX"  runat="server"></asp:TextBox>
                </div>

                <div class="col-12">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="" id="chkTerminos">
                        <asp:Label class="form-check-label" for="chkTerminos" runat="server" Text="Label">Acepto los terminos y condiciones.</asp:Label>
                        <div class="invalid-feedback">
                            Debe estar de acuerdo antes de enviar los datos.
                        </div>
                    </div>
                </div>


                <div class="col-12">
                    <asp:Button ID="btnParticipar" class="btn btn-primary" type="submit" runat="server" Text="PARTICIPAR" OnClick="btnParticipar_Click" />
                </div>

            </div>

<%--        </ContentTemplate>
    </asp:UpdatePanel>--%>

</asp:Content>
