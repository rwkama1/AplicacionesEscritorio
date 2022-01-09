using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Xml;
using ServicioWeb;
using System.IO;


public partial class ListadoMovimientosLinq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //la primera vez que se ingresa a la pagina se obtiene la info en XML
            if (!IsPostBack)
            {
                //obtengo el xml desde el WS
                XmlNode _MiDoc = new ServicioWeb.MiServicio().ListaMovsDeCliente((Cliente)Session["Usuario"]);

                //creo y cargo con los datos el documento q me devolvio el WS- formato para Linq
                System.Xml.Linq.XElement _documento = System.Xml.Linq.XElement.Parse(_MiDoc.OuterXml);
                Session["Documento"] = _documento;
            }
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnTodos_Click(object sender, EventArgs e)
    {
        try
        {
            System.Xml.Linq.XElement _documento = (System.Xml.Linq.XElement)Session["Documento"];

            //asigno al control de despliegue el documento completo
            XmlListar.DocumentContent = _documento.ToString();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }

    }

    protected void BtnRetiros_Click(object sender, EventArgs e)
    {
        //1.- origen de datos
        System.Xml.Linq.XElement _documento = (System.Xml.Linq.XElement)Session["Documento"];

        //2.- consulta
        var resultado = (from unNodo in _documento.Elements("Movimiento")
                        where (string)unNodo.Element("TipoMov") == "R"
                        select unNodo);

        //3- Ejecucion
        string _resultado = "<Raiz>";
        foreach (var unNodo in resultado)
        {
            _resultado += unNodo.ToString();
        }
        _resultado += "</Raiz>";

        //4.- Despliego en pantalla
        XmlListar.DocumentContent = _resultado;

    }
    protected void BtnMonto_Click(object sender, EventArgs e)
    {

    }
}