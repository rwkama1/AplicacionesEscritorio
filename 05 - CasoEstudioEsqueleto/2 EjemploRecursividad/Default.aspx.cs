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
using System.Xml;

public partial class _Default : System.Web.UI.Page 
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void BtnProcesar_Click(object sender, EventArgs e)
    {
        //LIMPIO caja de despliegue
        TxtMostrar.Text = "";
        //levanto el archivo XML que voy a mostrar en la pagina
        XmlDocument _XmlAlumnos = new XmlDocument();
        _XmlAlumnos.Load(Server.MapPath("~/XML/Alumnos.xml"));
        //obtengo el nodo raiz
        XmlNode _NodoRaiz = _XmlAlumnos.DocumentElement;
        //muestro el nodo raiz en el listbox
        TxtMostrar.Text += "Nombre Nodo Raiz: " + _NodoRaiz.Name + "\n";
        //invoco el metodo recursivo para mostrar todo el contenido
        MostrarNodoRecursivo(_NodoRaiz);
        
    }
    private void MostrarNodoRecursivo(XmlNode pNodo)//me sirve un nodo y no importa de que nivel
        //ese nodo se fija si tiene hijos (XMLNODE)
        //Tipo de XMLNODE:
        //Element: representaba una etiqueta con hijos o  con texto contenido
        //Atribute: representa un atributo de etiqueta, 
        //Text: que representaba el texto contenido de una etiqueta
    {
        //recorro todos los nodos hijos directos del nodo que viene
        //por parametro
        for (int indice = 0; indice < pNodo.ChildNodes.Count; indice++)
        {
            if (pNodo.ChildNodes[indice].NodeType == XmlNodeType.Element)//lo que me fijo es que si estoy frente  a un nodo que tiene nodos para recorrer
            //o texto para mostrar(IGNORO LA PARTE DE ATRIBUTO)
            {
                //agrego el nombre de la etiqueta si estoy ante un elemento
                //del tipo <elemento>
                //pregunto si tiene elementos hijos, asi no intento
                //(por eso pregunto por la cantidad de hijos mayor a 1,
                //ya que el texto contenido se considera un hijo mas
                
                if (pNodo.ChildNodes[indice].ChildNodes.Count > 1)
                    TxtMostrar.Text += pNodo.ChildNodes[indice].Name + "\n";
                else
                    TxtMostrar.Text += "\t" + pNodo.ChildNodes[indice].Name;
                //si no tiene hijos para recorrer, pongo la etiqueta con texto contenido
            }
            else//lo que viene es el nodo que representa el texto contenido de otro
            {
                //agrego el texto si estoy ante el contenido de un elemento
                //<elemento> contenido </elemento>
                TxtMostrar.Text += ": " + pNodo.ChildNodes[indice].InnerText + "\n";
            }//esto se hace por cada hijo
            //si hay nodos hijos,mando cada uno a mostrarse
                if(pNodo.ChildNodes.Count>0)
                    MostrarNodoRecursivo(pNodo.ChildNodes[indice]);
        }
    }
    private void MostrarNodoRecursivoAlreves(XmlNode nodo)
    {
        for(int indice=0;indice<nodo.ChildNodes.Count;indice++)
        {
            if (nodo.ChildNodes[indice].NodeType == XmlNodeType.Element)
            {

                if (nodo.ChildNodes[indice].ChildNodes.Count > 1)
                    TxtMostrar.Text += nodo.ChildNodes[indice].Name + "\n";
                else
                    TxtMostrar.Text += "\t" + nodo.ChildNodes[indice].Name;
                
            }
            else
            {

                TxtMostrar.Text += ": " + nodo.ChildNodes[indice].InnerText + "\n";
            }
            if (nodo.ChildNodes.Count > 0)
                MostrarNodoRecursivoAlreves(nodo.ChildNodes[indice]);
        }
    }
    protected void BtnAlReves_Click(object sender, EventArgs e)
    {
        TxtMostrar.Text = "";
        //levanto el archivo XML que voy a mostrar en la pagina
        XmlDocument _XmlAlumnos = new XmlDocument();
        _XmlAlumnos.Load(Server.MapPath("~/XML/Alumnos.xml"));
        //obtengo el nodo raiz
        XmlNode _NodoRaiz = _XmlAlumnos.DocumentElement;
        //muestro el nodo raiz en el listbox
        TxtMostrar.Text += "Nombre Nodo Raiz: " + _NodoRaiz.Name + "\n";
        //invoco el metodo recursivo para mostrar todo el contenido
        MostrarNodoRecursivoAlreves(_NodoRaiz);
       
    }

}
