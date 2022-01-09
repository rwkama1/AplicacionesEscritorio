using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using ServicioWeb;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Usuario"] = null;
    }

    protected void Logueo_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try
        {
            string _Usu = Logueo.UserName.Trim();
            string _Pass = Logueo.Password.Trim();
            Cliente _unCliente = new ServicioWeb.WcfServiceClient().LogueoCliente(_Usu, _Pass);

            if (_unCliente == null)
                LblError.Text = "Usuario o Pass Invalidos";
            else
            {
                Session["Usuario"] = _unCliente;
                Response.Redirect("~/PaginaInicialCliente.aspx");
            }
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }

    }

}