using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;



public partial class BusquedaLibros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Esta busqueda no es generica , es una busqueda especifica porque yo ya se de ante mano cual es la estructura del archivo
        //y por lo tanto que elementos tiene el texto contenido para la busqueda
        //AL ya saber la estructura , ya puedo armar la busqueda, lo que hace que el ultimo elemento del camino, sea el nodo primaro de libro
        //y por lo tanto en el resultado en el iterador no va a quedar apuntando a sub etiquetas va directamente apuntar a libros

    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        String consulta;
        String linea;
        try
        {
            //lee el documento para la busqueda
            XmlDocument documentoxml = new XmlDocument();
            documentoxml.Load(Server.MapPath("~/XML/Libros.xml"));
            //obtengo objeto para realizar la consulta
            XPathNavigator navegador = documentoxml.CreateNavigator();
            //armo la consulta
            if (DdlTipo.SelectedIndex == 0)
                consulta = DdlTipo.SelectedItem.Value + ">" + txtDato.Text + "]";
            else
                consulta = DdlTipo.SelectedItem.Value + txtDato.Text + "]";//Selecteditem.value es lo mismo que el SelectedValue
            //muestro que es lo que voy a buscar
            lblError.Text = "Tipo Busqueda" + consulta;
            //ejecuto la consulta
            XPathNodeIterator resultado = navegador.Select(consulta);
            //si hay resultado lo muestro
            if (resultado.Count > 0)
            {
                lblBusqueda.Text = "";
                //recorro cada nodo que coincidio con el criterio de busqueda
                while (resultado.MoveNext())//aca necesito un solo while ya que el iterador se va ir moviendo entre los nodos libros que hayan resultado
                    //seleccionados en la consulta//MOVENEXT: Mueve de a uno el resultado del iterador
                {
                    linea = "";
                    linea += "ISBN: " + resultado.Current.SelectSingleNode("ISBN").ToString();//SelectedSingleNOde, es una operacion que permite sub etiquetas de un nodo 
                    //apuntados por un iterador
                    linea += " - Titulo: " + resultado.Current.SelectSingleNode("Titulo").ToString();
                    linea += " - Categoria: " + resultado.Current.GetAttribute("Categoria", "").ToString();//me busca un atributo del nodo puede ser en las etiquetas o en las dependientes

                    lblBusqueda.Text += linea + "<br/>";
                    ListBox1.Items.Add(linea);
                }
            }
            else
                lblBusqueda.Text = "No hubo resultado en la busqueda";
           
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void btnconsulta_Click(object sender, EventArgs e)
    {
        String consulta;
        //String linea;
        try
        {
            //lee el documento para la busqueda
            XmlDocument documentoxml = new XmlDocument();
            documentoxml.Load(Server.MapPath("~/XML/Libros.xml"));
            //obtengo objeto para realizar la consulta
            XPathNavigator navegador = documentoxml.CreateNavigator();
            //armo la consulta
            if (DdlTipo.SelectedIndex == 0)
                consulta = DdlTipo.SelectedItem.Value + ">" + txtDato.Text + "]";
            else
                consulta = DdlTipo.SelectedItem.Value + txtDato.Text + "]";//Selecteditem.value es lo mismo que el SelectedValue
            //muestro que es lo que voy a buscar
            lblError.Text = "Tipo Busqueda" + consulta;
            //ejecuto la consulta
            XPathNodeIterator resultado = navegador.Select(consulta);
           
            //si hay resultado lo muestro
            if (resultado.Count > 0)
            {
               
                lblBusqueda.Text = "";
                //recorro cada nodo que coincidio con el criterio de busqueda
                while (resultado.MoveNext())//aca necesito un solo while ya que el iterador se va ir moviendo entre los nodos libros que hayan resultado
                //seleccionados en la consulta//MOVENEXT: Mueve de a uno el resultado del iterador
                {

                    var objeto = new { Categoria = resultado.Current.GetAttribute("Categoria", "").ToString(), ISBN = resultado.Current.SelectSingleNode("ISBN").ToString(), Titulo = resultado.Current.SelectSingleNode("Titulo").ToString() };

                    ArrayList lista = new ArrayList();
                    lista.Add(objeto);
                    ListBox1.Items.Add(objeto.ISBN);
                    ListBox1.Items.Add(objeto.Titulo);
                    ListBox1.Items.Add(objeto.Categoria);
                    GVDatos.DataSource = lista;
                    GVDatos.DataBind();
                }
            }
            else
                lblBusqueda.Text = "No hubo resultado en la busqueda";

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
//HACER UN SEGUNDO BOTON QUE HAGA LA MISMA BUSQUEDA PERO CON EL RESULTADO VOY A CREAR OBJETOS ANONMIOS CON LO MISMO DATOS QUE TIENE LA ETIQUETA ATRIBUTOS
//ISBN TITULO CATEGORIA, LO GUARDAMOS EN UNA COLECCION Y LA COLECCION LA MOSTRAMOS EN UNA GRILLA QUE VAMOS A AGREGAR