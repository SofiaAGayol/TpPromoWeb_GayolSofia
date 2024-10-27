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
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];

            if (voucher == null)
            {
                //redirijo si no hay nada en la sesion
                string script = "alert('No hay ningun voucher ingresado.');" +
                         "window.location.href='Default.aspx';";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        public List<Cliente> ListaClientes { get; set; }

        protected void btnDNI_Click(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];

            int dniCliente = Convert.ToInt32(txtDNI.Text);
            ClienteNegocio clienteNegocio = new ClienteNegocio();


            List<Cliente> clientes = clienteNegocio.buscarPorDNI(dniCliente);
            Cliente cliente = clientes.FirstOrDefault();

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
                txtCiudad.Text = cliente.Ciudad;
                txtCP.Text = cliente.CP.ToString();

                voucher.IdCliente = cliente.Id;
                Session["voucherActual"] = voucher;

                //    string script = $"alert('Usted ya se encuentra registrado: {cliente.Nombre} {cliente.Apellido} {cliente.Email} {cliente.Direccion} {cliente.Ciudad} {cliente.CP.ToString()}.');" +
                //                "window.location.href='Exito.aspx';";
                //    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente registrado en el sistema. Presione PARTICIPAR.');", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No hay un cliente registrad con ese DNi. Debe completar los datos.');", true);

            }
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];

            int dniCliente = Convert.ToInt32(txtDNI.Text);
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            Cliente cliente = null;

            if (cliente == null)
            {
                cliente = new Cliente
                {
                    Documento = dniCliente,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    CP = Convert.ToInt32(txtCP.Text)
                };

                clienteNegocio.agregarCliente(cliente);

                List<Cliente> clientes = clienteNegocio.buscarPorDNI(dniCliente);
                cliente = clientes.FirstOrDefault();

                voucher.IdCliente = cliente.Id;
                Session["voucherActual"] = voucher;

                string script = $"alert('Cliente registrado exitosamente: {cliente.Nombre} {cliente.Apellido}.');" +
                                "window.location.href='Exito.aspx';";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
            else
            {
                Response.Redirect("Exito.aspx");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El cliente ya está registrado.');", true);
            }
        }
    }
}
