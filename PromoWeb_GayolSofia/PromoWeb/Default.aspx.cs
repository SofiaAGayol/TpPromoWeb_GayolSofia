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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonValidar_Click(object sender, EventArgs e)
        {
            Voucher voucher;
            VoucherNegocio voucherNegocio = new VoucherNegocio();           
            string codigoVoucher = validacionVoucher.Text;

            try
            {
                voucher = new Voucher(codigoVoucher, 0, null, 0);

                if (voucherNegocio.ValidarVoucher(voucher))
                {
                    Session["voucherActual"] = voucher;
                    Response.Redirect("Premios.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Este código es inválido o ya ha sido utilizado.');", true);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}