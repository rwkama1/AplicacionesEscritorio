using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using EntidadesCompartidas;
using Logica;
using System.Messaging;





namespace PresentacionWin
{
    //delegado necesario para poder desplegar al pedido recibido
    delegate void ArriboDeMensaje(Pedido _pPedido);
    public partial class FrmInicio : Form
    {
        //atributos
        private MessageQueue _coladepedido; 
        public FrmInicio()
        {
            InitializeComponent();
            //creo el objeto que me permitira manejar la cola de pedidos del MSMQ Server
            _coladepedido = new MessageQueue("FormatName:DIRECT=OS:PC31\\Private$\\ColaDePedido");
            //seteo los filtros para mensajes que manejara la cola
            _coladepedido.MessageReadPropertyFilter.SetAll();
            //determino quien serializara y deserializara los mensajes de la cola
            ((XmlMessageFormatter)_coladepedido.Formatter).TargetTypes = new Type[] { typeof(Pedido) };
            //El objeto que representa la cola de mensajes,tiene que estar definido a nivel del formulario asi se ve todo el tiempo
            //La definicion de la cola(no uso) ya lo hacemos en el contructor del formulario asi ya se contruye el momento que empieza a 
            //funcionar el formulario
            

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            //determino el controlador del evento que procesa los mensaje de la cola
            _coladepedido.ReceiveCompleted += new ReceiveCompletedEventHandler(Recepcion);
            //se determina que se comienzan a recibir pedidos,con un tiempo espera de hasta 1 dia-Asincrionico
            _coladepedido.BeginReceive(new TimeSpan(1, 0, 0, 0));
            //CICLO DE RECEPCION ASICRONICA DE UNA COLA DE MENSAJE
            //El ciclo comienza con el metodo BeginReceive o BeginPeek,
            //si uso el ciclo con Receive signfica que cuando se consulte el objeto con la cola de mensaje
            //y se lea este automaticamente va ser eliminado de la cola, mientras que hacemos el ciclo con pick,al consultar el objeto
            //este no se quita de la cola queda ahi, lo que hace el meotodo Begin es crear un nuevo hilo de ejecucion
            //en este caso paralelo al formulario, y va a qedar a la escucha del que el servidor le avise que hay un nuevo mensaje para leer
            //Por parametro a este metodo hay que indicarle cuanto tiempo se queda a la espera,
            //El hilo se corta de dos formas, 1) El aviso que hay un mensaje de la cola disponible
                                            //2) O cuando el tiempo que le indique de existencia del nuevo hilo termine
            //Cualquiera de las dos cosas pone fin al hilo de ejecucion
            //Para avisar si hay un mensaje en la cola hay un segundo evento , que es el evento ReceiveCompleted, esto provoca el evento en el formulario
            //Este evento para enterarme lo tengo que capturar y poner un controlador y termina la ejecucion del ciclo 
            //El tercer elemento del ciclo es la operacion EndReceive o EndPick que lo que hace es permitirme acceder al objeto Message que llego a la cola de mensajes
            
            

        }
        //controlador del evento de final de captura de nuevo mensaje en la cola de recepcion
        private void Recepcion(object sender, ReceiveCompletedEventArgs args)
        {
            try
            {
                //obtengo el mensaje que esta en la cola de mensajes
                System.Messaging.Message unmensaje = _coladepedido.EndReceive(args.AsyncResult);
                Pedido unpedido = (Pedido)unmensaje.Body;
                //Muestro los datos del Pedido en Pantalla
                //para ellos fuerzo a que se invoque el metodo que me permite desplegar programaticamente
                //estoy provocando el evento, por ello no solo debo indicar cual controlador llamar,sino que tambien debo indicar los objetos
                //que este espera por parametro(lo que hasta ahora genero automaticamente siempre .NET por)
                TxtPedido.Invoke(new ArriboDeMensaje(DespliegoMensaje), unpedido);
                //grabo el pedido en la bd
                FabricaLogica.getLogicaPedido().AltaPedido(unpedido);
                //si llegue aca todo ok
                MessageBox.Show("Pedido Agregado a la BD Correctamente");
                //vuelvo a la escucha Asincronica
                _coladepedido.BeginReceive(new TimeSpan(1, 0, 0, 0));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Cuando estamos trabajando con ciclos asincronicos,que a su vez son paralelos a la interfaz grafica, tenemos que recordar
            //que el primer problema que tenemos es que los hilos de ejecucion Asincronicos por mas que esten definidos en el mismo archivo
            //no se pueden comunicar uno con el otro, la unica forma que tengo que comunicar elementos entre 2 hilos de ejecucion paralelos
            //es mediante la provocacion de un evento, es decir un hilo le puede provocar un evento al otro , esto es posible porque los objetos
            //a atraves de los cuales manejo ambos hilos de ejecucion en nuestro caso estan definidos en el mismo archivo, Una variable ve a la otra
            //Para eso lo q tenemos la operacion Invoke,que recibe minimo 2 parametros,
            //el primero parametro tiene que ser un delegado
            //el cual debe apuntarme al controlador que quiero ejecutar con ese evento,
            //el segundo parametro,que puede ser 2 o mas parametros son los datos que hay que pasarle a los delegados para que se pueda ejecutar
            //en nuestro caso el delegado solo recibe un parametro por eso le paso solo uno
            //Cuando se termina el tiempo de escucha porque cayoo un mensaje,si no comienzo nuevamente el ciclo de vida nunca mas me entero que cayo el mensaje
            
        }
        private void DespliegoMensaje(Pedido _pPedido)
        {
            TxtPedido.Text = _pPedido.ToString();
        }
  
        private void aBMArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMArticulos().Show();
        }

        private void listarArticulosEnBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarArticulos().Show();
        }

        private void listarPedidosEnLaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarPedidos().Show();
        }

    }
}
