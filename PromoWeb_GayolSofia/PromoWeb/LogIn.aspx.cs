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
        private List<Cliente> ListaClientes;
        protected void Page_Load(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];
                        
            if (voucher == null)
            {
                string script = "alert('No hay ningun voucher ingresado.');" +
                         "window.location.href='Default.aspx';";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }            
        }


        protected void btnDNI_Click(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucherActual"];

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Por favor, ingrese su DNI.');", true);
                return;
            }
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El DNI debe ser un número válido.');", true);
                return;
            }

            dniCliente = Convert.ToInt32(txtDNI.Text);

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            ListaClientes = clienteNegocio.buscarPorDNI(dniCliente);
            Cliente cliente = ListaClientes.FirstOrDefault();

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

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) || string.IsNullOrWhiteSpace(txtCP.Text) )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Por favor, complete todos los campos.');", true);
                return;
            }
            if (!int.TryParse(txtCP.Text, out int codigoPostal))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El Código Postal debe ser un número válido.');", true);
                return;
            }

            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El DNI debe ser un número válido.');", true);
                return;
            }

            dniCliente = Convert.ToInt32(txtDNI.Text);
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente cliente = clienteNegocio.buscarPorDNI(dniCliente).FirstOrDefault();

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
                    CP = codigoPostal
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
            }
        }
    }
}
