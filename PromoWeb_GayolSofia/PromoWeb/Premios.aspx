<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="PromoWeb.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-3">

        <asp:Repeater ID="RepeaterArticulos" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card h-100">
                        <asp:Image ID="Image1" alt="Imagen del artículo" runat="server" CssClass="card-img-top" />
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><%# Eval("Descripcion") %></p>
                            <asp:Button ID="botonElegir" class="btn btn-primary" runat="server" Text="¡QUIERO ESTE!" CommandArgument='<%# Eval("Id") %>' OnClick="botonElegir_Click" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
    <hr />

</asp:Content>

