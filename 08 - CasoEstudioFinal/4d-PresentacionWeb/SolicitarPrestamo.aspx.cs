using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Messaging;
using System.Configuration;




public partial class SolicitarPrestamo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

  
    protected void BtnRefresh_Click(object sender, EventArgs e)
    {
        //limpio la pantalla
        TxtMonto.Text = "";
        LblError.Text = "";

    }


    protected void BtnSolicitar_Click(object sender, EventArgs e)
    {
        try
        {
            //obtengo el cliente logueado
            ServicioWeb.Cliente _unCliente = (ServicioWeb.Cliente)Session["Usuario"];

            //creo objeto prestamo 
            ServicioWeb.Prestamo _unPrestamo = new ServicioWeb.Prestamo();
            _unPrestamo.UnCliente= _unCliente;
            _unPrestamo.Fecha = DateTime.Now;
            _unPrestamo.Monto = Convert.ToDouble(TxtMonto.Text);
            _unPrestamo.Aprobado = false;


            //defino la cola de mensaje a donde lo voy a mandar - ColaPrestamos
            string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
            MessageQueue _ColaPrestamos = new MessageQueue(_NombreCola);

            // seteo los filtros para mensajes que manejara la cola
            _ColaPrestamos.MessageReadPropertyFilter.SetAll();

            //determino quien serializara y desserializara los mensajes de la cola y que tipos acepta
            ((XmlMessageFormatter)_ColaPrestamos.Formatter).TargetTypes = new Type[] { typeof(ServicioWeb.Prestamo), typeof(ServicioWeb.Cliente) };

            //creo el mensaje a enviar a la cola
            Message _MensajeEnviar = new Message(_unPrestamo);

            //envio el mensaje
            MessageQueueTransaction _Transaccion = new MessageQueueTransaction();
            _Transaccion.Begin();
            _ColaPrestamos.Send(_MensajeEnviar, _Transaccion);
            _Transaccion.Commit();

            //si llego aca - no hubo errores
            LblError.Text = "Prestamos Solicitado COrrectamente";
            TxtMonto.Text = "";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }

    }


    protected void BtnConsultar_Click(object sender, EventArgs e)
    {
        try
        {

            //obtengo el cliente logueado
            ServicioWeb.Cliente _unCliente = (ServicioWeb.Cliente)Session["Usuario"];

            //realizo listado
            GVPrestamos.DataSource = new ServicioWeb.MiServicio().ListoPrestamosCliente(_unCliente);
            GVPrestamos.DataBind();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

}