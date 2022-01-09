using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;

namespace WebService1
{
    /// <summary>
    /// Descripción breve de ServicioArticulos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioArticulos : System.Web.Services.WebService
    {
        //[WebMethod]
        [WebMethod]
        public Produccion serializarh(Produccion pro)
        {
            return pro;
        }
        [WebMethod]
        public Articulo BuscarArticulo(int pCodigo)
        {
            try
            {
                ILogicaArticulo LArticulo = FabricaLogica.getLogicaArticulo();
                return (LArticulo.BuscarArticulo(pCodigo));
            }
            catch (Exception ex)
            {
                //generacion manual de expepsion SOAP, para poder obtener
                // solo el mensaje enviado por alguna de las capas
                //1. se debe crear un nodo xml(NodoError) el cual sera ultilizado para cargar el atributo Details de la Exception SOAP

                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                //2 Se crea un nodo xml(Nodo Detalle ) que contendra el texto del error
                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;
                //4, Creacion manual de la expection SOAP
                //parametro 1  mensaje basico de la excepcion
                //parametro 2 determina codigo de error para la excepcion
                //Parametro 3 se obtiene la URL de la solicitud actual
                //parametro 4 informacion especifica sobre la excepcion generada
                //carga automaticamente la propiedad details
                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;
            }//COMO HACER LAS OPERACIONES EN WEB SERVICE
            //1) las operaciones web service no llevan logica ya que la idea del web service es simplemente exponer un servicio de forma publica
            //que esta generada en mi sistema
            //2) Recordar que no se mantiene en un estado el web service(SESSION , APLICATION ETC)
            //3) hay que recordar.... que si yo no capturo una expcepcion el web service va  a generar automaticamente el SOAPEXCEPTION
            //y que por lo tanto no va qedar informacion clara como nosotros queremos, entonces como es recomendable que nosotros creemos 
            //el SOAP exception necesitamos poner un TRY
            //Se puede hacer una operacion privada para la generacion de SOAP EXCEPTION, para despues llamar en cada catch en cada operacion
            //publica
            //Esa operacion no debe tener la operacion WEB METHOD, porque no es una operacion publica, y tiene que ser acceso Private
        }
        [WebMethod]
        public void AgregarArticulo(Articulo A)
        {
            try
            {
                FabricaLogica.getLogicaArticulo().AgregarArticulo(A);
            }
            catch (Exception ex)
            {
                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;

                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;
            }
        }
        [WebMethod]
        public List<Articulo> Listar()
        {
            List<Articulo> _lista = null;
            try
            {
                _lista = FabricaLogica.getLogicaArticulo().ListarArticulo();
            }
            catch (Exception ex)
            {


                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                //2 Se crea un nodo xml(Nodo Detalle ) que contendra el texto del error
                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;
                //4, Creacion manual de la expection SOAP
                //parametro 1  mensaje basico de la excepcion
                //parametro 2 determina codigo de error para la excepcion
                //Parametro 3 se obtiene la URL de la solicitud actual
                //parametro 4 informacion especifica sobre la excepcion generada
                //carga automaticamente la propiedad details
                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;

            }

            return _lista;
        }
        [WebMethod]
        public void EliminarArticulo(Articulo A)
        {
            try
            {
                FabricaLogica.getLogicaArticulo().EliminarArticulo(A);
            }
            catch (Exception ex)
            {
                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;

                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;
            }
        }
        [WebMethod]
        public void ModificarArticulo(Articulo A)
        {
            try
            {
                FabricaLogica.getLogicaArticulo().ModificarArticulo(A);
            }
            catch (Exception ex)
            {
                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;

                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;
            }
        }
        [WebMethod]
        public XmlDocument ListadoArticulosXML()
        {
            XmlDocument _Documento = new XmlDocument();
            try
            {
                List<Articulo> _lista = FabricaLogica.getLogicaArticulo().ListarArticulo();
                _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
                XmlNode raiz = _Documento.DocumentElement;

               
                foreach (Articulo art in _lista)
                {
                    XmlElement codigo = _Documento.CreateElement("Codigo");
                    codigo.InnerText = art.Codigo.ToString();

                    XmlElement nombre = _Documento.CreateElement("Nombre");
                    nombre.InnerText = art.Nombre.ToString();

                    XmlElement precio = _Documento.CreateElement("Precio");
                    precio.InnerText = Convert.ToInt32(art.Precio).ToString();


                    XmlElement _Nodo = _Documento.CreateElement("Articulo");
                    _Nodo.AppendChild(codigo);
                    _Nodo.AppendChild(nombre);
                    _Nodo.AppendChild(precio);
                    raiz.AppendChild(_Nodo);

                }
                
              

            }
            catch (Exception ex)
            {
                XmlDocument undoc = new XmlDocument();
                XmlNode nodoerror = undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

                XmlNode nododetalle = undoc.CreateNode(XmlNodeType.Element, "Error", "");
                nododetalle.InnerText = ex.Message;

                nodoerror.AppendChild(nododetalle);
                SoapException miex = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, nodoerror);
                throw miex;
            }

            return _Documento;


        }//fin web method

    }

}