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


//agrego referencia 
using EntidadesCompartidas;
using Logica;
using System.Messaging;



public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        Articulo _unArticulo = null;
        try
        {

           
            _unArticulo = FabricaLogica.getLogicaArticulo().BuscarArticulo(Convert.ToInt32(txtArticulo.Text));

            //si existe lo muesto
            if (_unArticulo != null)
            {
                //existe, cargo y permito agregar pedido
                LblArticulo.Text = _unArticulo.Codigo.ToString() + " - " + _unArticulo.Nombre;
                txtNombre.Text = "";
                txtDir.Text = "";

                BtnEnviar.Enabled = true;

                //lo guardo en la maemoria para signarlo al pedido cuando se envie
                ViewState["UnArticulo"] = _unArticulo;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected void BtnEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            //creo el objeto de pedido
            Pedido _unpedido = new Pedido(0, txtNombre.Text.Trim(), txtDir.Text.Trim(), (Articulo)ViewState["UnArticulo"]);
            //defino la cola de mensaje a donde lo voy a mandar -Cola de Pedido
            MessageQueue _Coladepedido = new MessageQueue("FormatName:DIRECT=OS:PC31\\Private$\\ColaDePedido");//tenemos que usar el que esta en SYSTEM.MESSAGING en Messageque
            //STRING DE CONEXION PARA UNA COLA DE MENSAJES
            //El string de conexion tiene que decir en donde esta el servidor MSMQ como se va a comunicar con ese servidor y por supuesto
            //a que cola se va a conectar,
            //Aca siempre necesitamos la sentencia de escape
            //El string de conexion se usa cuando se configura la cola de mensaje y en el caso de SQLSERVER,se usa en el momento en el que creo
            //el objeto que va a manejar la cola de mensajes aparte de crear el objeto que me genera la cola de mensajes tengo que definir
            //si vamos a filtrar o no los mensajes a leer para lo cual tenemos la propiedad,MessageReadPropertyFilter, del objeto
            //que maneja a mi cola de mensajes
            //seteo los filtros para mensajes que manejara la cola
            _Coladepedido.MessageReadPropertyFilter.SetAll();//setea todo, 
            //Saber como se van a serializar los datos con ese servidor
            //determino quien serializara y desializara los mensajes de la cola
            ((XmlMessageFormatter)_Coladepedido.Formatter).TargetTypes=new Type[] {typeof(Pedido)};//la propiedad Formatter permite establecer
            //quien es el que se encarga o deserealizar los objetos que van en los cuerpos de los mensajes
            //XMLMESSAGEFORMATTER, es una clase que ultiliza la definicion XSD de una clase,para serilalizar o deserializar objetos
            //RECORDAR  SI TENGO UNA CLASE Y LA MANDA PARA SERIALIZAR CUANDO SE COMPILA EN LA BIBLIOTECA SE GUARDA EL ESQUEMA XSD DE DICHA CLASE
            //ESO ES LO QUE USA EL XMLMESSAGEFORMATTER,El problema es que ha dicha clase hay que indicarle que tipos tienen que investigar para serializar
            //TargetTypes: Es un vector de tipos de datos y le tenemos que pasar el tipo de datos no la clase, un TYPE lo que representa es una declaracion de tipo
            //Y eso puede estar sustentado en una clase en una interfaz en muchas cosas,nosotros tenemos pedidos declarado como Clase
            //la operacion Typeof me devuelve la definicion Type de la clase, puedo poner todo lo que se me den la gana,
            
            //creo el mensaje a enviar a la cola
            Message mensajeenviar = new Message(_unpedido);//EL OBJETO MESSAGE: es el objeto donde yo puedo enviar a una cola de mensajes, este tipo de objetos tiene una propiedad
            //llamada BODY la cual puede contener cualquier tipo de objeto pero uno solo,
            //envio el mensaje
            MessageQueueTransaction transaccion = new MessageQueueTransaction();//
            transaccion.Begin();
            _Coladepedido.Send(mensajeenviar, transaccion);//Send, Envia un objeto hacia la cola de mensajes
            //1)Si nosotros definimos una cola como transaccional, obligatoriamente cuando vallamos a enviar informacion debemos de hacerlo por medio de una transaccion sino nos va a dar ERROR
            //2)El Send tiene sintaxis en funcion, de si trabajamos o no con colas transaccional, sino trabajamos con una cola transaccional entonces en el SEND tenemos que mandar una parametro
            //que es el objeto MESSAGE que quiero enviar, en caso de usar una cola transaccional, debemos ademas como segundo parametro determinar la transaccion en la cual se envia el objeto

            transaccion.Commit();
            //si llego aca no hubo errores
            lblError.Text = "Pedido Enviado a la cola de pedidos";
            txtArticulo.Text = "";
            LblArticulo.Text = "";
            txtNombre.Text = "";
            txtDir.Text = "";
            BtnEnviar.Enabled = false;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }

}
