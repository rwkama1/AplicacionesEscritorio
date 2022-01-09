using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using System.Messaging;
using System.Configuration;


namespace PresentacionWin
{
    public partial class FrmPrestamos : Form
    {
        //atributos
        MessageQueue _ColaPrestamos;
        List<ServicioWeb.Prestamo> _ListaPrestamos;
        ServicioWeb.Prestamo _objPrestamo;


        public FrmPrestamos()
        {
            InitializeComponent();

            //defino la cola de mensaje de donde obtengo las solicitudes - ColaPrestamos
            string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
            _ColaPrestamos = new MessageQueue(_NombreCola);

            // seteo los filtros para mensajes que manejara la cola
            _ColaPrestamos.MessageReadPropertyFilter.SetAll();

            //determino quien serializara y desserializara los mensajes de la cola y que tipos acepta
            ((XmlMessageFormatter)_ColaPrestamos.Formatter).TargetTypes = new Type[] { typeof(ServicioWeb.Prestamo), typeof(ServicioWeb.Cliente) };  
        
            //creo la lista de prestamos pendientes
           _ListaPrestamos = new List<ServicioWeb.Prestamo>();

            //determino nada seleccionado por defecto
           _objPrestamo = null;

        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                // determino el controlador del evento que procesa los mensaje de la cola
                _ColaPrestamos.ReceiveCompleted += new ReceiveCompletedEventHandler(Recepcion);

                //se determina que se comienzan a recibir pedidos - Asincronico
                _ColaPrestamos.BeginReceive(new TimeSpan(1, 0, 0, 0));

                //determino que la grilla no se autogenere
                DGVPrestamosPendientes.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //controlador del evento d de finale captura de nuevo mensaje en la cola 
        private void Recepcion(object sender, ReceiveCompletedEventArgs args)
        {
            try
            {
                //obtengo el mensaje q esta en la cola de mensajes
                System.Messaging.Message _unMensaje = _ColaPrestamos.EndReceive(args.AsyncResult);
                ServicioWeb.Prestamo _unPrestamo = (ServicioWeb.Prestamo)_unMensaje.Body;

                //cargo el prestamo en la coleccion de prestamos pendientes de proceso en el formulario
                _ListaPrestamos.Add(_unPrestamo);

                //vuelvo a la escucha ASincronica
                _ColaPrestamos.BeginReceive(new TimeSpan(1, 0, 0, 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrestamosPendientes.DataSource = null;
                DGVPrestamosPendientes.DataSource = _ListaPrestamos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //verifico si hay solicitudes de prestamos sin procesar
                if (_ListaPrestamos.Count > 0)
                {
                    DialogResult _respuesta = MessageBox.Show("Hay Prestamos sin Evaluar. \nSi continua dichas solicitudes se perderan. \nEsta seguro que desea abandonar igual?", "PERDIDA INMINENTE DE DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (_respuesta == System.Windows.Forms.DialogResult.No)
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }

        }

        private void DGVPrestamosPendientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //obtengo el prestamo seleccionado
                _objPrestamo = _ListaPrestamos[e.RowIndex];

                //los muestro en la pantalla
                DTPFechaAprob.Value = _objPrestamo.Fecha;
                LblCliente.Text = _objPrestamo.UnCliente.NomCli;
                LblMonto.Text = _objPrestamo.Monto.ToString();

                //activo la aceptacion
                BtnGrabar.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtengo datos
                _objPrestamo.Fecha = DTPFechaAprob.Value;
                if (RBtnAceptado.Checked)
                    _objPrestamo.Aprobado = true;
                else
                    _objPrestamo.Aprobado = false;

                //mando a guardar el prestamo
                new PresentacionWin.ServicioWeb.WcfServiceClient().AltaPrestamo(_objPrestamo);

                //elimino prestamo de coleccion pendientes
                _ListaPrestamos.Remove(_objPrestamo);
                DGVPrestamosPendientes.DataSource = null;
                DGVPrestamosPendientes.DataSource = _ListaPrestamos;

                //mensaje de todo salio ok
                LblError.Text = "Prestamo Grabado Correctamente";

                //deshabilito posibilidad de aceptacion prestamos
                BtnGrabar.Enabled = false;

                //limpio el formulario
                DTPFechaAprob.Value = DateTime.Now;
                LblCliente.Text = "Datos del Cliente";
                LblMonto.Text = "0";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    LblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }
        }
    }
}
