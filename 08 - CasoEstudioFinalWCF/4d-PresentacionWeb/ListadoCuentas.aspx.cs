using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListadoCuentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                RpCuentas.DataSource = new ServicioWeb.WcfServiceClient().ListaCuentasDeCliente((ServicioWeb.Cliente)Session["Usuario"]);
                RpCuentas.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

    }

    protected void RpCuentas_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Listar")
        {
            try
            {
                ServicioWeb.Cuenta _unaCuenta = new ServicioWeb.WcfServiceClient().BuscarCuenta(Convert.ToInt32(((TextBox)(e.Item.Controls[1])).Text));
                List<ServicioWeb.Movimiento> _miLista = new ServicioWeb.WcfServiceClient().ListarMovimientosDeCuenta(_unaCuenta).ToList();
                s.DataSource = _miLista;
                s.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }
}