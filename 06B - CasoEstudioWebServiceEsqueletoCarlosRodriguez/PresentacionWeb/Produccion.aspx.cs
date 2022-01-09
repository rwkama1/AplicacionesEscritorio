using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
using System.Xml;
using System.Xml.XPath;
public partial class Produccion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
  
            
                ServicioArticulos web = new ServicioArticulos();
               
                XmlNode _MiDoc = web.ListadoArticulosXML();

              
                XmlDocument _documento = new XmlDocument();
                _documento.LoadXml(_MiDoc.OuterXml);
                Session["XML"] = _documento;
               _documento = (XmlDocument)Session["XML"];

               
               Xml1.DocumentContent = _documento.OuterXml;
          

        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            lblerror.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }

    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        Articulo unarticulo = null;
        try
        {
          
            ServicioArticulos Larticulos = new ServicioArticulos();
       

            unarticulo = Larticulos.BuscarArticulo(Convert.ToInt32(txtcod.Text));

            ServicioWeb.Produccion produccion = ((ServicioWeb.Produccion)unarticulo);
            if (unarticulo == null)
            {

                lblerror.Text = "NO existe";
            }
            else
            {

                txtcod.Text = produccion.Codigo.ToString();
                txtnombre.Text = produccion.Nombre;
                txtPrecio.Text = produccion.Precio.ToString();
                txtfecha.Text = produccion.Fecha.ToString();

            }

        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            lblerror.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }

    }
    protected void btnmodificar_Click(object sender, EventArgs e)
    {
        try
        {
            ServicioArticulos web = new ServicioArticulos();
            ServicioWeb.Produccion pro = new ServicioWeb.Produccion();
            pro.Codigo = Convert.ToInt32(txtcod.Text);
            pro.Nombre = txtnombre.Text;
            pro.Precio = Convert.ToDecimal(txtPrecio.Text);
            pro.Fecha = Convert.ToDateTime(txtfecha.Text);
          web.ModificarArticulo(pro);
           
            lblerror.Text = "Modificacion con Exito";
            lblerror.Text = "";
        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            lblerror.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void FiltrarPrecio_Click(object sender, EventArgs e)
    {
        try
        {
            
            XmlDocument _documento = (XmlDocument)Session["XML"];
            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

           
            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Articulo[Precio > " + txtfiltro.Text + " ]");

            if (_Resultado.Count > 0)
            {
               
                while (_Resultado.MoveNext())
                {

                    XmlElement codigo = _DocumentoFiltrado.CreateElement("Codigo");
                    codigo.InnerText = _Resultado.Current.SelectSingleNode("Codigo").ToString();

                    XmlElement nombre = _DocumentoFiltrado.CreateElement("Nombre");
                    nombre.InnerText = _Resultado.Current.SelectSingleNode("Nombre").ToString();

                    XmlElement precio = _DocumentoFiltrado.CreateElement("Precio");
                    precio.InnerText = _Resultado.Current.SelectSingleNode("Precio").ToString();
                    XmlElement _Nodo = _DocumentoFiltrado.CreateElement("Articulo");
                    _Nodo.AppendChild(codigo);
                    _Nodo.AppendChild(nombre);
                    _Nodo.AppendChild(precio);
                    _raiz.AppendChild(_Nodo);

                }

              
                Xml1.DocumentContent = _DocumentoFiltrado.OuterXml;

            }
            else
                lblerror.Text = "No tiene Articulos precio mayor a" +txtfiltro.Text;
        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            lblerror.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}