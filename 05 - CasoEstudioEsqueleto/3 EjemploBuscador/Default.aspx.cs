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
using System.Xml;
using System.Xml.XPath;
//BUSCACOR GENERICO SOBRE ARCHIVO XML
//La idea es que primero el usuario seleccione un archivo XML, el cual puede estar en su maquina, dicho archivo se va a llevar al servidor
//pero no se va almacenar fisicamente, se guarda en memoria para hacer las busquedas, 
//Paso siguiente vamos a recorrer esa estructura que se leyo, y vamos a detectar cuales son los nodos,que contiene texto
//para poder buscar para poder filtrar,despues de tener eso damos la opcion al usuario para que busque por esos nodos
//Cuando yo voy  a buscar, tengo que asegurarme que no busque el mismo nodo 50 veces, NO SE BUSCA EL NOMBRE DE ETIQUETA, SINO
//POR CAMINO DEL NODO RAIZ A DICHA ETIQUETA

//El control FileUpload permite, examinar la maquina del cliente,buscar un archivo ,y transferirlo en formato binario hacia el servidor
//
public partial class _Default : System.Web.UI.Page
{
    //Atributo de mi pagina-- representa la lista de nodos que hay
    //en el archivo XML que se esta procesando actualmente
    List<NodoXML> _ListaNodosXml = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        //levanto datos del ViewState segun corresponda
        if (IsPostBack)
        {
            _ListaNodosXml = (List<NodoXML>)Session["_ListaNodosXml"];
        }
        else
            Session["_ListaNodosXml"] = _ListaNodosXml;
    }

    protected void btnCargar_Click(object sender, EventArgs e)
    {
        try
        {
            //limpio los controles descriptivos del archivo en proceso,
            //para cargar la nueva informacion del nuevo archivo XML
            DdlCampo.Items.Clear();
            DdlOperacion.SelectedIndex = 0;
            txtConsulta.Text = "";
            TxtResultado.Text = "";
            _ListaNodosXml = new List<NodoXML>();
            //cargo el archivo seleccionado
            XmlDocument _DocumentoXML = new XmlDocument();
            _DocumentoXML.Load(FileUpXML.FileContent);
            //proceso el documento, cargando de la lista de memoria todos sus nodos
            XmlNode _NodoRaiz = _DocumentoXML.DocumentElement;

            CargoListaNodos(_NodoRaiz, "");
            //mando a ordenar la lista de nodos
            _ListaNodosXml.Sort();
            //cargo el archivo y la lista de nodos de la sesion
            Session["_DocumentoXML"] = _DocumentoXML;
            Session["_ListaNodosXML"] = _ListaNodosXml;
            //cargo el primer combo con los nombres de los elementos que habia en el documento
            for (int indice = 0; indice < _ListaNodosXml.Count; indice++)
            {
                DdlCampo.Items.Add(_ListaNodosXml[indice].Nombre);
            }
        }
        catch(Exception ex)
        {
            txtConsulta.Text = ex.Message;
        }
    }
    //funcion recursiva- la primera vez recibe por parametro nodo raiz del documento
    //luego va recibiendo cada nodo hijo
    private void CargoListaNodos(XmlNode unNodo, string unCamino)//BUSCAMOS ETIQUETAS CON TEXTO CONTENIDO,
    {
        //determina si el nodo recibido por parametro es un elemento asi procesa dicha
        //"etiqueta"
        if (unNodo.NodeType == XmlNodeType.Element)
        {
            //determino si una etiqueta del tipo camino/nombre similar ya existe
            //dentro de mi lista
            unCamino += "/" + unNodo.Name;
            bool _Esta = false;
            foreach (NodoXML _Nodo in _ListaNodosXml)
            {
                if (_Nodo.Ruta == unCamino)//se pregunta por el camino no por el nombre de etiqueta,nombres de etiqueta en muchos niveles
                    //comparo por las rutas de los nodos, porque el nombre de un nodo,puede repetirse en distinto niveles del archivo
                    //y si su ruta de acceso es diferente, yo los puedo discriminar 
                    _Esta = true;
            }
            //en caso que dicha etiqueta no se encuentre, la agrego a la lista de etiquetas del documento
            if (!_Esta)
            {
                //verifico que se trate de un nodo con InnerText para busqueda
                if (unNodo.ChildNodes.Count < 2)//VA TENER 1 HIJO QUE ES EL TEXTO CONTENIDO
                {
                    //creo un objeto NodoXML, con los valores de esta etiqueta nueva,
                    //incluyendo su camino completo dentro del arbol de documento XML
                    NodoXML _NodoXml = new NodoXML(unNodo.Name, unCamino);
                    //agrego el nodo a la lista de la pagina
                    _ListaNodosXml.Add(_NodoXml);
                }
                else
                {
                    for (int i = 0; i < unNodo.ChildNodes.Count; i++)
                    {
                        CargoListaNodos(unNodo.ChildNodes[i], unCamino);//ACA DONDE HAY RECURSIVIDAD

                    }
 
                }//fin if si ya esta incluida la etiqueta
            }//fin if de tipo etiqueta
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //OBTENGO Datos guardado en la session
        XmlDocument _DocumentoXML = (XmlDocument)Session["_DocumentoXML"];
        List<NodoXML> _ListaNodosXML = (List<NodoXML>) Session["_ListadoNodosXml"];
        //limpio el resultado anterior 
        TxtResultado.Text = string.Empty;
        //creo un cursor para navegar dentro de los datos del documentoXML
        XPathNavigator _NavegadorXPath = _DocumentoXML.CreateNavigator();
        //CLASE XPATHNAVIGATOR
        //Un objeto de este tipo me permite navegar dentro de una estructura de datos de XML, permitiendo hacer modficar nodos y hacer busquedas
        //todo lo necesario para poder Modificar,este tipo de objetos se debe crear a partir de un XMLDocument  que ya tenga cargados los datos de un archivo 
       //Para poder crear este objeto ultilizamos la operacion CreateNavigator de un XMLDocument
        //XpathNavigator tiene una operacion llamada Select  que puede recibir por parametro un string que representa una consulta XPATH
        //Esa operacion ejecuta la consulta,y no es que me devuelva un conjunto de resultados, lo que hace es devolverme un puntero 
        //de tipo XPathNodeIterator(ITERATOR), EL ITERADOR no crea una nueva estructura con el resultado, lo que hace es si apuntar a los nodos
        //resultante de la consulta
        //A QUE NODO APUNTA EL ITERADOR? Al ultimo mencionado en el camino del XPATH
        //MOVENEXT , ES LA OPERACION QUE PERMITE IR DE UNO A UNO EL RESULTADO DE LA OPERACION,
        //LA OPERACION MoveNext DEVUELVE FALSE SI NO HAY OTRO NODO EN EL RESULTADO,o devuelve true si se puede mover a un siguiente Nodo
        //Cuando se mueve al siguiente nodo,lo que va cambiando es la propiedad Current del Iterador,
        //Current es una estructura de XML, puede representar un conjunto de etiquetas
        //Iterador tiene una propiedad llamada Count, que me dice la cantidad de elementos que se encontraron
        //Dentro de la propiedad Current tenemos 2 datos,Name y Value,Name representa el nombre del nodo , nombre de la etiqueta 
        //Value, representa  al InnerText de la etiqueta,
        //OJO!!, que si estoy frente a un nodo, el value va ser el texto contenido del los inner text de todas las etiquetas hijas
        //concantenado sin ninguno Espacio
        //MoveToFirst(), Con esto me paso un nivel arriba,me voy a mover con la Propiedad Current, que es lo que se puede usar como puntero,
        //Para moverme entre los hijos del nivel superior, tengo una Operacion MoveToNext





        //determino la ruta de la etiqueta de la consulta
        string _Consulta = "";
        NodoXML _NodoXml = _ListaNodosXml[DdlCampo.SelectedIndex];
        //armo la consulta usando [] que aplica a modelos de filtros sobre un camino de etiquetas
        _Consulta = _NodoXml.Ruta +
            "[ . ]" + DdlOperacion.SelectedValue + "'" + txtConsulta.Text.Trim() + "' ]";
        //obtengo un iterator para manejar el conjunto de nodos que resulta de la consulta
        XPathNodeIterator _Resultado = _NavegadorXPath.Select(_Consulta);
        //muestro el resultado en la pagina
        //recorro el conjunto de nodos seleccionados por la consulta
        while (_Resultado.MoveNext())
        {
            //me muevo a la primer etiqueta del nodo
            _Resultado.Current.MoveToFirst();
            TxtResultado.Text += _Resultado.Current.Name + " = " + _Resultado.Current.Value + "\n";
            //muestro sus nodos contenidos
            while (_Resultado.Current.MoveToNext())
            {
                TxtResultado.Text += "\t" + _Resultado.Current.Name + " = " + _Resultado.Current.Value + "\n";//Saco la informacion desde la propiedad Current
            }
            //agrego sepacion de nodos
            TxtResultado.Text += "\n\n";
        }
        //determino que no hay resultados
        if (TxtResultado.Text == "")
            TxtResultado.Text = "No Hay Resultados";
    }

    protected void btnconsultados_Click(object sender, EventArgs e)
    {
        XmlDocument _DocumentoXML = (XmlDocument)Session["_DocumentoXML"];
        List<NodoXML> _ListaNodosXML = (List<NodoXML>)Session["_ListadoNodosXml"];


        //obtengo el nodo raiz
        XmlNode _NodoRaiz = _DocumentoXML.DocumentElement;
        //muestro el nodo raiz en el listbox
       
        TxtResultado.Text = string.Empty;
      
        XPathNavigator _NavegadorXPath = _DocumentoXML.CreateNavigator();
        string _Consulta = "";
        NodoXML _NodoXml = _ListaNodosXml[DdlCampo.SelectedIndex];
      
        _Consulta = _NodoXml.Ruta +
            "[.]" + DdlOperacion.SelectedValue + " ' " + txtConsulta.Text.Trim() + "']";
      
        XPathNodeIterator _Resultado = _NavegadorXPath.Select(_Consulta);
       
        while (_Resultado.MoveNext())
        {
            //_Resultado.Current.MoveToFirst();
            //TxtResultado.Text += _Resultado.Current.Name + " = " + _Resultado.Current.Value + "\n";
            
            //while (_Resultado.Current.MoveToNext())
            //{
                //TxtResultado.Text += "\t" + _Resultado.Current.Name + " = " + _Resultado.Current.Value + "\n";//Saco la informacion desde la propiedad Current
               
                XmlElement nombre = _DocumentoXML.CreateElement("Nombre");
                nombre.InnerText = _Resultado.Current.SelectSingleNode("Nombre").ToString();
                XmlElement apellido = _DocumentoXML.CreateElement("Apellido");
                apellido.InnerText = _DocumentoXML.CreateElement("Apellido").ToString();
                XmlElement nodo = _DocumentoXML.CreateElement("Consulta");
                nodo.AppendChild(nombre);
                nodo.AppendChild(apellido);
                _NodoRaiz.AppendChild(nodo);
                _DocumentoXML.Save(Server.MapPath("~/XML/XMLFile.xml"));
               
            //}
            
           
            //TxtResultado.Text += "\n\n";
        }
        
       
        if (TxtResultado.Text == "")
            TxtResultado.Text = "No Hay Resultados";
        //XmlDocument _DocumentoFiltrado = new XmlDocument();
        //_DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
        //XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

        ////filtro
        //XPathNavigator _Navegador = _documento.CreateNavigator();
        //XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Movimiento[TipoMov = 'R']");

    }
}