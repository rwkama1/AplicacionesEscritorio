using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using servicio
using ServicioWcf;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Session["Art"] = null;
           
        }
    }
    protected void btnbuscarart_Click(object sender, EventArgs e)
    {
        Articulo art = null;
        try
        {
            IServicioArticulo SArticulo = new ServicioArticuloClient();
            //ultilizo la operacdion del WS
            art = SArticulo.BuscarArticulo(Convert.ToInt32(txtcodigo.Text));
            //determino accion
            if (art == null)
            {
                //no existe articulo es un alta,limpio campos
                txtnobmre.Text = "";
                txtprecio.Text = "";
                btnaltaart.Enabled = true;
                btnbajaart.Enabled = false;
                btnmodart.Enabled = false;
            }
            else
            {
                Session["Art"] = art;
                //existe cargo y permito eliminar o modificar
                txtnobmre.Text = art.Nombre;
                txtcodigo.Text=art.Codigo.ToString();
                txtprecio.Text=art.Precio.ToString();
                btnaltaart.Enabled = false;
                btnbajaart.Enabled = true;
                btnmodart.Enabled = true;
            }

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;

        }

    }
    protected void btnaltaart_Click(object sender, EventArgs e)
    {
        try
        {
            IServicioArticulo AArticulo = new ServicioArticuloClient();
            Articulo art = new Articulo();
            art.Codigo = Convert.ToInt32(txtcodigo.Text);
            art.Nombre =txtnobmre.Text.Trim();
            art.Precio = Convert.ToDecimal(txtprecio.Text);


            AArticulo.AgregarArticulo(art);
           btnaltaart.Enabled = true;
                btnbajaart.Enabled = false;
                btnmodart.Enabled = false;

                txtnobmre.Text = "";
                txtprecio.Text = "";



            lblerror.Text = "Alta con Exito";
        }
     
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void btnbajaart_Click(object sender, EventArgs e)
    {
        try
        {
            IServicioArticulo BArticulo = new ServicioArticuloClient();
            Articulo art = (Articulo)Session["Art"];

            BArticulo.EliminarArticulo(art);
            
            lblerror.Text = "Baja con Exito";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void btnmodart_Click(object sender, EventArgs e)
    {
        try
        {
            IServicioArticulo BArticulo = new ServicioArticuloClient();
            Articulo artm = new Articulo();
            artm.Codigo = Convert.ToInt32(txtcodigo.Text);
            artm.Nombre =txtnobmre.Text;
            artm.Precio = Convert.ToDecimal(txtprecio.Text);

            BArticulo.ModificarArticulos(artm);

            lblerror.Text = "Modificacion con Exito";
            lblerror.Text = "";
        }
       
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }

    }
    protected void btnlistarart_Click(object sender, EventArgs e)
    {
        IServicioArticulo ListarArticulo = new ServicioArticuloClient();
        List<Articulo> _lista = ListarArticulo.ListarArticulos().ToList();

        GVarticulos.DataSource = _lista;
        GVarticulos.DataBind();
    }
}