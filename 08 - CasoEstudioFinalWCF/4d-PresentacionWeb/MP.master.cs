using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using ServicioWeb;



public partial class MP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( !(Session["Usuario"] is Cliente))
            Response.Redirect("~/Default.aspx");
    }

    protected void BtnSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}
