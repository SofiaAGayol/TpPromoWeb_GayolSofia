using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class Exito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            if (voucher == null)
            {
                Response.Redirect("Default.aspx");
                return;
            }

            string codigoVoucher = (string)voucher.CodigoVoucher;
            int idArticulo = Convert.ToInt32(voucher.IdArticulo);
            int idCliente = Convert.ToInt32(voucher.IdCliente);

            Voucher nuevoVoucher = new Voucher
            {
                CodigoVoucher = codigoVoucher,
                IdCliente = idCliente,
                FechaCanje = DateTime.Now,
                IdArticulo = idArticulo
            };

            voucherNegocio.agregarVoucher(nuevoVoucher);



            voucher.FechaCanje = DateTime.Now;

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente cliente = clienteNegocio.buscarPorID(voucher.IdCliente);

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = articuloNegocio.listar();

            int idArticuloSeleccionado = voucher.IdArticulo;
            Articulo articuloSeleccionado = listaArticulos.FirstOrDefault(a => a.Id == idArticuloSeleccionado);

            if (cliente != null)
            {
                lblNombre.Text = cliente.Nombre;
                lblApellido.Text = cliente.Apellido;
            }

            lblCodigoVoucher.Text = voucher.CodigoVoucher;
            lblArticulo.Text = articuloSeleccionado != null ? articuloSeleccionado.Nombre : "Artículo no seleccionado";
        }
    }

}