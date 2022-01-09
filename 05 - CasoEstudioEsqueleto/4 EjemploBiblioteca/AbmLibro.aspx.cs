using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Xml;

public partial class AbmLibro : System.Web.UI.Page
{
    //atributos del formulario
    private int _haySeleccion = 0;//la idea es que entre postback voy a mantener la posicion de un nodo primario seleccionado
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //mando a cargar la grilla con los datos que ya contenga dicho archivo
            CargoDatos();
            //por defecto no tenemos nada seleccionado
            _haySeleccion = 0;
            ViewState["_haySeleccion"] = _haySeleccion;
            //determino botones por defecto
            this.BotonesporDefecto();
        }
        else
        {
            //mantengo el estado de si hubo seleccion o no para modificar y eliminar
            _haySeleccion = (int)ViewState["_haySeleccion"];
        }
    }

    private void CargoDatos()
    {
        try
        {
            string camino=Server.MapPath(ConfigurationManager.AppSettings["XmlLibros"]);//Es obtener desde el archivo WebConfig,
            //el valor de una constante que me va a representar en este caso , que me representa el nombre del archivo XML que quiero levantar
            //Recordar, que yo puedo guardar Pares Clave valor en el archivo de Configuracion y despues buscando con el valor de la clave obtener el 
            //valor asosciado
            DataSet _ds = new DataSet();
            _ds.ReadXml(camino);
            GVLibros.DataSource = _ds;
            GVLibros.DataBind();
            _ds.ReadXml(Server.MapPath("~/XML/Autores.xml"),XmlReadMode.InferSchema);
            DdlAutor.DataSource=_ds.Tables["Autor"];
            DdlAutor.DataTextField="Nombre";
            DdlAutor.DataValueField="Codigo";
            DdlAutor.DataBind();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
 
    }
    private void BotonesporDefecto()
    {
        BtnAlta.Enabled = true;
        BtnBaja.Enabled = false;
        BtnModificar.Enabled = false;
    }
    private void BotonesBM()
    {
        BtnAlta.Enabled = false;
        BtnBaja.Enabled = true;
        BtnModificar.Enabled = true;
    }
    private void Limpiar()
    {
        TxtIsbn.Text = "";
        TxtTitulo.Text = "";
        TxtCategoria.Text = "";
        DdlAutor.SelectedIndex = 0;
    }
    protected void GVLibros_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            //determino el origen de datos
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlLibros"]);
            //recupero el documento xml, para elminiar el nodo libro
            XmlDocument Documentoxml = new XmlDocument();
            Documentoxml.Load(camino);
            //obtengo nodo seleccionado
            XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[GVLibros.SelectedIndex];
            //determino que hay nodo seleccionado
            ViewState["_haySeleccion"] = GVLibros.SelectedIndex;
            //cargo datos en pantalla
            TxtIsbn.Text = nodol["ISBN"].InnerText;//cuando estamos frente a un XMLNODE de tipo Nodo (etiqueta que contiene a otras etiquetas)......
 //tenemos dos formas de acceder a las etiquetas hijas , la primera es mediante la propiedad ChildNode y la dada la posicion de la etiqueta
            //obtener la etiqueta, y la segunda es usar el Indexer con el Nodo, dada el nombre de la etiqueta que queremos acceder
            //Esto se hace a las etiquetas no a los atributos, 
            //El XML es CaseSensitive lo que significa, que si no busco la etiqueta tal cual nombre se puede partir
            TxtTitulo.Text = nodol["Titulo"].InnerText;
            TxtCategoria.Text = nodol.Attributes["Categoria"].InnerText;
            //determino el autor - recordar que solo puede haber un elemento seleccionado
            //HAY QUE RECORDAR QUE SOLO SE PUEDE TENER UNO SELECCIONADO POR VEZ,un elemento Item por DropDownList, pero el seleccionar un elemento
            //no implica, que se deseleccione otro que no este seleccionado y como no se puede tener 2 al mismo tiempo seleccionado
            //tengo que recordar de deseleccionar todo lo demas
            foreach (ListItem unitem in DdlAutor.Items)
            {
                if (unitem.Value == nodol["Autor"].InnerText)
                    unitem.Selected = true;
                else
                    unitem.Selected = false;
            }
            //determino acciones
            this.BotonesBM();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnAlta_Click(object sender, EventArgs e)
    {
        try
        {
            //PARA DAR DE ALTA TENGO QUE CREARME UN NODO PRIMARIO,que va ser libro de nombre y a ese mismo nodo le tengo que agregar un atributo
            //
            //determino el archivo de origen de datos
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlLibros"]);
            //recupero el documento xml, para agregar nuevo nodo de libro
            XmlDocument Documentoxml = new XmlDocument();
            Documentoxml.Load(camino);

            //creo nodo libro con su atributo
            XmlNode nodol = Documentoxml.CreateNode(XmlNodeType.Element, "Libro", "");
            XmlAttribute _atributocategoria = Documentoxml.CreateAttribute("Categoria");
            _atributocategoria.InnerText = TxtCategoria.Text.Trim();
            nodol.Attributes.Append(_atributocategoria);
            //creo el nodo ISbn
            XmlNode nodoi = Documentoxml.CreateNode(XmlNodeType.Element, "ISBN", "");
            nodoi.InnerXml = TxtIsbn.Text.Trim();
            nodol.AppendChild(nodoi);
            //creo el subnodo titulo
            XmlNode nodot = Documentoxml.CreateNode(XmlNodeType.Element, "Titulo", "");
            nodoi.InnerXml = TxtTitulo.Text.Trim() ;
            nodol.AppendChild(nodot);
            //creo el nodo Autor
            XmlNode nodoa = Documentoxml.CreateNode(XmlNodeType.Element, "Autor", "");
            nodoi.InnerXml = DdlAutor.SelectedValue;
            nodol.AppendChild(nodoa);
            //agrego el nodolibro al documento XML
            Documentoxml.DocumentElement.AppendChild(nodol);
            //gravo el archivo con la nueva informacion
            Documentoxml.Save(camino);
            //actualizo la pantalla
            this.CargoDatos();
            Limpiar();
            BotonesporDefecto();
            //si llegue aca es porque todo ok
            LblError.Text = "Alta con Exito";


        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnBaja_Click(object sender, EventArgs e)
    {
        //REMOVECHILD: PERMITE BORRAR UN SUB NODO EN XML NODE,moviendo  todos los nodos que este despues de el un lugar hacia arriba
        //por parametro tiene que recibir, un apuntador al que quiere eliminar, no provoca error en caso de no encontrar el nodo
        // a eliminar
        //Sirve para cualquier nivel, o puedo en un nodo raiz eliminar las etiquetas contenidas
        try
        {
            //determino archivo de origen de datos
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlLibros"]);
            //recupero el documento xml, para agregar nuevo nodo de libro
            XmlDocument Documentoxml = new XmlDocument();
            Documentoxml.Load(camino);
            //primero verifico si se selecciono algun libro desde la grilla
            XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[(int)ViewState["_haySeleccion"]];
            if (nodol == null)
            {
                LblError.Text = "No se puede eliminar, porque no se selecciono nada";
                return;
            }
            //elimino el nodo seleccionado
            Documentoxml.DocumentElement.RemoveChild(nodol);
            //salvo los cambios
            Documentoxml.Save(camino);
            //determino que ya no hay seleccion
            ViewState["_haySeleccion"] = 0;

            //actualizo la pantalla
            this.CargoDatos();
            this.Limpiar();
            this.BotonesporDefecto();
            //si llegue aca es porque todo ok
            LblError.Text = "Eliminar con exito";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            //determino el archivo de origen de datos
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlLibros"]);
            //recupero el documento xml, para agregar nuevo nodo de libro
            XmlDocument Documentoxml = new XmlDocument();
            Documentoxml.Load(camino);
            //primero verifico si se selecciono algun libro desde la grilla
            XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[(int)ViewState["_haySeleccion"]];
            if (nodol == null)
            {
                LblError.Text = "No se puede mod, porque no se selecciono nada";
                return;
            }
            //modifico el nodo seleccionado
            nodol["ISBN"].InnerText = TxtIsbn.Text.Trim();
            nodol["Titulo"].InnerText =TxtTitulo.Text.Trim();
            nodol.Attributes["Categoria"].InnerText = TxtCategoria.Text.Trim();
            nodol["Autor"].InnerText = DdlAutor.SelectedValue;
            //salvo los cambios
            Documentoxml.Save(camino);
            //determino que ya no hay seleccion
            ViewState["_haySeleccion"] = 0;

            //actualizo la pantalla
            this.CargoDatos();
            this.Limpiar();
            this.BotonesporDefecto();
            //si llegue aca es porque todo ok
            LblError.Text = "Modificar con exito";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

}