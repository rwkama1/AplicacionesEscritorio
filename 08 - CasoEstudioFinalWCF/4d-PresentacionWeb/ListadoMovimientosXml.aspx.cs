using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Xml;
using System.Xml.XPath;
using ServicioWeb;



public partial class ListadoMovimientosXml : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            //la primera vez que se ingresa a la pagina se obtiene la info en XML
            if (!IsPostBack)
            {
                //   XmlNode _MiDoc = new ServicioWeb.MiServicio().ListaMovsDeCliente((Cliente)Session["Usuario"]);
 
                ////creo y cargo con los datos el documento q me devolvio el WS
                //XmlDocument _documento = new XmlDocument();
                //_documento.LoadXml(_MiDoc.OuterXml); 
                //Session["Documento"] = _documento;
                //XmlDocument _MiDoc = new XmlDocument();
                //obtengo el xml desde el WS
                IWcfService wcfxml = new WcfServiceClient();
                XmlDocument _MiDoc = new XmlDocument();
               _MiDoc.LoadXml(wcfxml.ListaMovsDeCliente((Cliente)Session["Usuario"]));
                 
                //creo y cargo con los datos el documento q me devolvio el WS
                XmlDocument _documento = new XmlDocument();
                _documento.LoadXml(_MiDoc.OuterXml); 
                Session["Documento"] = _documento;
            }
        //}
        //catch (Exception ex)
        //{
        //    LblError.Text = ex.Message;
        //}
    }

    protected void BtnTodos_Click(object sender, EventArgs e)
    {
        try
        {
            XmlDocument _documento = (XmlDocument)Session["Documento"];

            //asigno al control de despliegue el documento completo
            XmlListar.DocumentContent = _documento.OuterXml;
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnRetiros_Click(object sender, EventArgs e)
    {
        try
        {
            //obtengo documento con todos los movimientos
            XmlDocument _documento = (XmlDocument)Session["Documento"];

            //creo documento xml para guardar el resultado de la busqueda
            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

            //filtro
            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Movimiento[TipoMov = 'R']");
            
            if (_Resultado.Count > 0)
            {
                //si hay resultados, creo los nodos para cargar el documento del resultado
                while (_Resultado.MoveNext())
                {

                    XmlElement _IdMov = _DocumentoFiltrado.CreateElement("IdMov");
                    _IdMov.InnerText = _Resultado.Current.SelectSingleNode("IdMov").ToString();

                    XmlElement _NumCta = _DocumentoFiltrado.CreateElement("NumCta");
                    _NumCta.InnerText = _Resultado.Current.SelectSingleNode("NumCta").ToString();

                    XmlElement _FechaMov = _DocumentoFiltrado.CreateElement("FechaMov");
                    _FechaMov.InnerText = _Resultado.Current.SelectSingleNode("FechaMov").ToString();

                    XmlElement _MontoMov = _DocumentoFiltrado.CreateElement("MontoMov");
                    _MontoMov.InnerText = _Resultado.Current.SelectSingleNode("MontoMov").ToString();

                    XmlElement _TipoMov = _DocumentoFiltrado.CreateElement("TipoMov");
                    _TipoMov.InnerText = _Resultado.Current.SelectSingleNode("TipoMov").ToString();

                    XmlElement _Nodo = _DocumentoFiltrado.CreateElement("Movimiento");
                    _Nodo.AppendChild(_IdMov);
                    _Nodo.AppendChild(_NumCta);
                    _Nodo.AppendChild(_FechaMov);
                    _Nodo.AppendChild(_MontoMov);
                    _Nodo.AppendChild(_TipoMov);

                    _raiz.AppendChild(_Nodo);

                   }

                //asigno al control de despliegue el documento filtrado
                XmlListar.DocumentContent = _DocumentoFiltrado.OuterXml;

            }
            else
                LblError.Text = "No tiene movimientos del tipo Retiro";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }

    }

    protected void BtnMonto_Click(object sender, EventArgs e)
    {
        try
        {
            //obtengo documento con todos los movimientos
            XmlDocument _documento = (XmlDocument)Session["Documento"];

            //creo documento xml para guardar el resultado de la busqueda
            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

            //filtro
            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Movimiento[MontoMov > 10000]");

            if (_Resultado.Count > 0)
            {
                //si hay resultados, creo los nodos para cargar el documento del resultado
                while (_Resultado.MoveNext())
                {

                    XmlElement _IdMov = _DocumentoFiltrado.CreateElement("IdMov");
                    _IdMov.InnerText = _Resultado.Current.SelectSingleNode("IdMov").ToString();

                    XmlElement _NumCta = _DocumentoFiltrado.CreateElement("NumCta");
                    _NumCta.InnerText = _Resultado.Current.SelectSingleNode("NumCta").ToString();

                    XmlElement _FechaMov = _DocumentoFiltrado.CreateElement("FechaMov");
                    _FechaMov.InnerText = _Resultado.Current.SelectSingleNode("FechaMov").ToString();

                    XmlElement _MontoMov = _DocumentoFiltrado.CreateElement("MontoMov");
                    _MontoMov.InnerText = _Resultado.Current.SelectSingleNode("MontoMov").ToString();

                    XmlElement _TipoMov = _DocumentoFiltrado.CreateElement("TipoMov");
                    _TipoMov.InnerText = _Resultado.Current.SelectSingleNode("TipoMov").ToString();

                    XmlElement _Nodo = _DocumentoFiltrado.CreateElement("Movimiento");
                    _Nodo.AppendChild(_IdMov);
                    _Nodo.AppendChild(_NumCta);
                    _Nodo.AppendChild(_FechaMov);
                    _Nodo.AppendChild(_MontoMov);
                    _Nodo.AppendChild(_TipoMov);

                    _raiz.AppendChild(_Nodo);

                }

                //asigno al control de despliegue el documento filtrado
                XmlListar.DocumentContent = _DocumentoFiltrado.OuterXml;

            }
            else
                LblError.Text = "No tiene movimientos cuyo monto supere los 10000";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
}