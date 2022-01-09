using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Collections;

public partial class BusquedaAutosporNodo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        String consulta;
        //String linea;
        try
        {
    
            XmlDocument documentoxml = new XmlDocument();
            documentoxml.Load(Server.MapPath("~/XML/Autos.xml"));
         
            XPathNavigator navegador = documentoxml.CreateNavigator();
          
            if (DdlBuscar.SelectedIndex == 0)
                consulta = DdlBuscar.SelectedValue + ">" + txtdato.Text + "]";
            else
                consulta = DdlBuscar.SelectedValue + txtdato.Text + "]";
         
            lblerror.Text = "Tipo Busqueda" + consulta;
          
            XPathNodeIterator resultado = navegador.Select(consulta);
           
          
            if (resultado.Count > 0)
            {
               
             
                while (resultado.MoveNext())
                {

                    var objeto = new 
                     { Matricula = resultado.Current.SelectSingleNode("Matricula").ToString(),
                        Marca = resultado.Current.SelectSingleNode("Marca").ToString(), 
                        Modelo = resultado.Current.SelectSingleNode("Modelo").ToString(),
                        Precio=resultado.Current.SelectSingleNode("Precio").ToString()};

                    ArrayList lista = new ArrayList();
                    lista.Add(objeto);

                    GVBusqueda.DataSource = consulta;
                    GVBusqueda.DataBind();
                }
            }
            //else
            //    lblBusqueda.Text = "No hubo resultado en la busqueda";

        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    
    }
}