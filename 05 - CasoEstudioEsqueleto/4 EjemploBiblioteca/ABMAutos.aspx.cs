using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Xml;

public partial class ABMAutos : System.Web.UI.Page
{
    private int seleccion = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            
            CargoDatos();

            seleccion = 0;
            ViewState["Seleccion"] = seleccion;

            this.Botones();
        }
        else
        {
           
            seleccion = (int)ViewState["Seleccion"];
        }
    }
    private void CargoDatos()
    {
        try
        {
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlAutos"]);
          
            DataSet _ds = new DataSet();
            _ds.ReadXml(camino);
           GridView1.DataSource = _ds;
           GridView1.DataBind();
            _ds.ReadXml(Server.MapPath("~/XML/Dueños.xml"), XmlReadMode.InferSchema);
           DdlDueños.DataSource = _ds.Tables["Dueño"];
           DdlDueños.DataTextField ="Nombre";
           DdlDueños.DataValueField ="Cedula";
           DdlDueños.DataBind();
        }
        catch (Exception ex)
        {
           lblerror.Text = ex.Message;
        }
    }
    private void Botones()
    {
       btnalta.Enabled = true;
       btnbaja.Enabled = false;
       btnmodificar.Enabled = false;
    }
    private void BotonesSiExistelobuscado()
    {
        btnalta.Enabled = false;
        btnbaja.Enabled = true;
        btnmodificar.Enabled = true;
    }
    private void Limpiar()
    {
       txtmatricula.Text = "";
       txtmarca.Text = "";
        txtprecio.Text = "";
        txtmodelo.Text = "";
       DdlDueños.SelectedIndex = 0;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        {
            try
            {
               
                string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlAutos"]);
               
                XmlDocument Documentoxml = new XmlDocument();
                Documentoxml.Load(camino);

                XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[GridView1.SelectedIndex];

                ViewState["Seleccion"] = GridView1.SelectedIndex;

                txtmatricula.Text = nodol["Matricula"].InnerText;
                txtmodelo.Text = nodol["Modelo"].InnerText;
                txtmarca.Text = nodol["Marca"].InnerText;
                txtprecio.Text = nodol["Precio"].InnerText;
             
                foreach (ListItem unitem in DdlDueños.Items)
                {
                    if (unitem.Value == nodol["Dueño"].InnerText)
                        unitem.Selected = true;
                    else
                        unitem.Selected = false;
                }
                
                this.BotonesSiExistelobuscado();
            }
            catch (Exception ex)
            {
               lblerror.Text = ex.Message;
            }
        }
    }
    protected void btnalta_Click(object sender, EventArgs e)
    {
        try
        {
            
            if (txtmatricula.Text.Length == 6)
            {
                string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlAutos"]);

                XmlDocument Documentoxml = new XmlDocument();
                Documentoxml.Load(camino);


                XmlNode nodol = Documentoxml.CreateNode(XmlNodeType.Element, "Auto", "");

                XmlNode nodoi = Documentoxml.CreateNode(XmlNodeType.Element, "Matricula", "");
                nodoi.InnerXml = txtmatricula.Text.Trim();
                nodol.AppendChild(nodoi);
                XmlNode nodot = Documentoxml.CreateNode(XmlNodeType.Element, "Modelo", "");
                nodot.InnerXml = txtmodelo.Text.Trim();
                nodol.AppendChild(nodot);

                XmlNode nodop = Documentoxml.CreateNode(XmlNodeType.Element, "Precio", "");
                nodop.InnerXml = txtprecio.Text.Trim();
                nodol.AppendChild(nodop);
                XmlNode nodom = Documentoxml.CreateNode(XmlNodeType.Element, "Marca", "");
                nodom.InnerXml = txtmarca.Text.Trim();
                nodol.AppendChild(nodom);

                XmlNode nodoa = Documentoxml.CreateNode(XmlNodeType.Element, "Dueño", "");
                nodoa.InnerXml = DdlDueños.SelectedValue;
                nodol.AppendChild(nodoa);

                Documentoxml.DocumentElement.AppendChild(nodol);

                Documentoxml.Save(camino);

                this.CargoDatos();
                Limpiar();
                Botones();

                lblerror.Text = "Alta con Exito";
            }
            else
                lblerror.Text = "La matricula debe tener 6 caracteres";


        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        Botones();
        Limpiar();
    }
    protected void btnbaja_Click(object sender, EventArgs e)
    {

      
           
            try
            {
                
                string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlAutos"]);
               
                XmlDocument Documentoxml = new XmlDocument();
                Documentoxml.Load(camino);

                XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[(int)ViewState["Seleccion"]];
                if (nodol == null)
                {
                    lblerror.Text = "No se puede eliminar, porque no se selecciono nada";
                    return;
                }
              
                Documentoxml.DocumentElement.RemoveChild(nodol);
              
                Documentoxml.Save(camino);
                
                ViewState["Seleccion"] = 0;

              
                this.CargoDatos();
                this.Limpiar();
                this.Botones();
           
                lblerror.Text = "Eliminar con exito";
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
            
            string camino = Server.MapPath(ConfigurationManager.AppSettings["XmlAutos"]);
           
            XmlDocument Documentoxml = new XmlDocument();
            Documentoxml.Load(camino);
            
            XmlNode nodol = Documentoxml.DocumentElement.ChildNodes[(int)ViewState["Seleccion"]];
            if (nodol == null)
            {
                lblerror.Text = "No se puede mod, porque no se selecciono nada";
                return;
            }
         
            nodol["Matricula"].InnerText = txtmatricula.Text.Trim();
            nodol["Marca"].InnerText = txtmarca.Text.Trim();
            nodol["Modelo"].InnerText = txtmodelo.Text.Trim();
            nodol["Precio"].InnerText = txtprecio.Text.Trim();
            nodol["Dueño"].InnerText =DdlDueños.SelectedValue;
          
            Documentoxml.Save(camino);
         
            ViewState["Seleccion"] = 0;

           
            this.CargoDatos();
            this.Limpiar();
            this.Botones();
            
            lblerror.Text = "Modificar con exito";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}