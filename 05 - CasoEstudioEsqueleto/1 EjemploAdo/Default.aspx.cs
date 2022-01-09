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
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page 
{
  //EL DATASET, aunque pueda manejar informacion tanto proveniente desde una base de datos, como de un archivo XML
    //no puede leer de ambos tipos de fuentes al mismo tiempo, yo puedo leer dataset de fuentes diferentes y despues combinar sus contenidos
    //PARA LA CLASE QUE VIENE COMENZAMOS CON LA OPERACION MERGE
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            //es un Postback,Obtengo la informacion de la memoria,
            _Ds = (DataSet)ViewState["_Ds"];
        }
        else
        {
            //Es el primer Ingreso a la Pagina,Genero Objeto para guardar informacion
            _Ds=new DataSet("Ventas");
                ViewState["_Ds"]=_Ds;
        }
    }
    DataSet _Ds;
    protected void BtnAccion1_Click(object sender, EventArgs e)
    {
        //creo la conexion a bd
        SqlConnection _cnn = new SqlConnection("Data Source=.;Initial Catalog=Ventas;Integrated Security=true");
        //creo adptadores
        SqlDataAdapter _daFam = new SqlDataAdapter("Select * from Familias", _cnn);
        SqlDataAdapter _daArt = new SqlDataAdapter("Select * from Articulos", _cnn);
        //cargo los datos
        _daFam.Fill(_Ds, "Familias");
        _daArt.Fill(_Ds, "Articulos");
        ViewState["_Ds"] = _Ds;
        //cargo las grillas
        GVFamilias.DataSource = _Ds.Tables["Familias"];
        GVFamilias.DataBind();
        GVArticulos.DataSource = _Ds.Tables["Articulos"];
        GVArticulos.DataBind();
    }

    protected void BtnAccion2_Click(object sender, EventArgs e)
    {
      //creo DataSet para cargar el archivo XML
        DataSet _DsAux = new DataSet();
        _DsAux.ReadXml(Server.MapPath("~/XML/DatosXml.XML"));
        //combino la informacion que viene de Bd(y que ya esta en el dataset de memoria)
        //y la informacion del archivo XML,en un solo DataSet
        _Ds.Merge(_DsAux, true, MissingSchemaAction.Ignore);//Cuando trabajamos con DataSet, este puede levantar informacion dando
        //desde una base de datos como desde un archivo XML, el inconveniente despues de haber leido uno de los 2 tipos de datos
        //el Dataset Solo puede seguir, consecuente hace que yo pueda ultilizar un DataSet, para cada tipo de fuente de datos
        //y despues combinar sus estructuras y sus datos
        //LA OPERACION MERGE,ES INVOCADA DESDE UN DATASET, EL CUAL,VA A PODER GUARDAR TODA LA INFORMACION COMBINADA, EL PRIMER PARAMETRO
        // DE LA OPERACION MERGE REPRESENTA AL CONJUNTO DE DATOS DE UN DATASET,QUE SE DESEAN COMBINAR CON LOS YA EXISTENTES INVOCABLES,
        //PARA ESTO LO PRIMERO QUE SE HACE ES REALIZAR LAS ESTRUCTURAS QUE CONTIENE EL DATASET DE ESTE PRIMER PARAMETRO
        // Y SI LAS ESTRUCTURAS COINICIDEN , EN NOMBRE, CANTIDAD Y TIPO DE COLUMNAS,SE VA A INTENTAR COMBINAR LOS DATOS DE LOS REGISTROS,
        //DENTRO DEL DATASET INVOCABLE, SI HAY ESTRUCUTRAS QUE SE LLAMAN DIFERENTES,LO QUE SE HACE ES AGREGAR A ESA ESTRUCTURA EL DATASET INVOCABLE
        //EL SEGUNDO PARAMETRO, ME DETERMINA SI LUEGO DE HACER TODI ESTE TRABAJO SI RELAMENTE SE CONSERVA LOS CAMBIOS EN EL DATASET INVOCABLE
        //DICE SI CONSERVA LOS CAMBIOS O NO,
        //EL TERCER PARAMETRO,ES QUE VA A PASAR CON LOS PROBLEMAS DEL ESQUEMA OSEA DE LA ESTRUCTURA, EN ESTE CASO ES IGNORE

        ViewState["_Ds"] = _Ds;
           //cargo las grillas
            GVFamilias.DataSource = _Ds.Tables["Familias"];
        GVFamilias.DataBind();
        GVArticulos.DataSource = _Ds.Tables["Articulos"];
        GVArticulos.DataBind();
    }

    protected void BtnAccion3_Click(object sender, EventArgs e)
    {
        _Ds.WriteXmlSchema(Server.MapPath("~/XML/EsquemaXML.xml"));//La operacion WriteSXMLSchema, lo que hace es crear un archivo Xml,
        //usando lenguaje XSD,que describe la estructura, que deberia tener si se arma nodos XML,a partir del DataSet,
        //LENGUAJE XSD
        //sirve para describir estructuras bien formadas de archivos XML, para empezar son todas etiquetas que empiezan con el prefijo XS
        //La etuqitea XS:Element describe etiquetas XML y a describirla lo que hace es nombrarla
        //La eiqueta XS:Element si es una sola linea y se le determina el tipo de dato, el atributo TYPE,representa a una etiqueta comun y corriente
        //SI la etiqueta XS:Element viene seguida de una etiqueta XS:complexType significa que es un nodo, que va a tener otras etiquetas contenidas
        //Si lo que va en ese complejo es contenener otros nodos, los cuales tambien se pueden repetir , entonces vamos a encontrar una etiqueta XS:Choice
        //ahi tenemos la cantidad de veces que tienen que ocurrir  de nodos contenidos
        //XS:Sequence indica que necesito tener las siguiente etiqueta contenidas, tecnicamente es lo opuesto al Choice, esto dice que tengo que encontrar bien la cantidad de nodos
        //SIRVE SI UN ARCHIVO ESTA BIEN FORMADO O NO
        _Ds.WriteXml(Server.MapPath("~/XML/DatosCompletosXml.xml"));
        _Ds.WriteXml(Server.MapPath("~/XML/DatosEsquemaXML.xml"), XmlWriteMode.WriteSchema);
        //writeXML, funciona como el XMLDocument.Save(sobreescribia el archivo con lo que habia en memoria)
        //Si lo uso como un solo parametro, lo unico que se hace es grabar los datos en el archivo,y un segundo parametro me puede ayudar a indicar
        //que quiero aparte de guardar los datos tambien el esquema,en caso de que guarde datos y esquemas en un mismo archivo, primero 
        //se guarda el esquema, y luego se guardan los nodos primarios con los datos en ese orden si o si, 
        //siendo el nodo raiz el nombre del DataSet

    }
 
}
