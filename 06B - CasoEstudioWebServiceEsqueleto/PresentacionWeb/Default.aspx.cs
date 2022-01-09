using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
//AGREGO REFERENCIA WEB
using ServicioWeb;



public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnListar_Click(object sender, EventArgs e)
    {
     }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        Articulo unarticulo = null;
        try
        {
            //creo objeto que me permita trabajar con el WS
            ServicioArticulos Larticulos = new ServicioArticulos();
            //ultilizo la operacion del WS
            unarticulo = Larticulos.BuscarArticulo(Convert.ToInt32(txtCodigo.Text));
            if (unarticulo == null)
            {
                //no existe articulo es un alta, limpio campos
                txtNombre.Text = "";
                txtPrecio.Text = "";
                BtnAlta.Enabled = true;
                BtnBaja.Enabled = false;
                BtnModificar.Enabled = false;
            }
            else
            {
                //existe cargo y permito eliminar o modificar
                txtNombre.Text = unarticulo.Nombre;
                txtPrecio.Text = unarticulo.Precio.ToString();
                BtnAlta.Enabled = false;
                BtnBaja.Enabled = true;
                BtnModificar.Enabled = true;
            }
        }
        catch (System.Web.Services.Protocols.SoapException ex)//no cae en un catch exception
        {
            lblError.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
           
       
    }

    protected void BtnAlta_Click(object sender, EventArgs e)
    {
        try
        {
            ServicioArticulos Larticulos = new ServicioArticulos();
            Articulo art = new Articulo();
            art.Codigo = Convert.ToInt32(txtCodigo.Text);
            art.Nombre = txtNombre.Text.Trim();
            art.Precio = Convert.ToDecimal(txtPrecio.Text);


            Larticulos.AgregarArticulo(art);
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;
            txtNombre.Text = "";
            txtPrecio.Text = "";



            lblError.Text = "Alta con Exito";
        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            lblError.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
