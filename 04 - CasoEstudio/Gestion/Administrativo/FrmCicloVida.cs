using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion
{
    public partial class FrmCicloVida : Form
    {
        public FrmCicloVida()
        {
            InitializeComponent();
        }

        private void FrmCicloVida_Activated(object sender, EventArgs e)//ser provoca cuando tenes el form, se puede ejecutar muchas veces
            //en el ciclo de vida de un formulario, ya que cuando resiva el foco de windows se provoca el Paint y el Activated
            //en este evento si se captura no se puede poner codigo, que interactue directamente con el usuario en la nueva forma,
            //cuando el mensaje se muestra yo pierdo el foco, y cuando se cierra, vuelve a tener el foco, y vuelve a ejecutar el formulario
        {
            // se produce cuando el formulario vuelve a obtener el foco - se activa
            //lugar ideal para refrescar informacion, pero jamas se debera tener interaccion con el usuario
            LblActivated.Text = DateTime.Now.ToString("dd - MM - yy   HH:mm:ss");

            //si saco comentarios de la siguiente linea queda en loop
           MessageBox.Show("Quedo en loop");//Esta clase permite mostrar, mensasje Postback mediante la operacion Show, y siempre 
            //son mensajes de forma MODAL, a su vez esa operacion devuelve, un valor numerico, que representa el boton que presiono
            //para que desaparesca el mensaje, ese valor lo podemos captar mediante el enumerado,DialogResult , lo unico que tiene
            //de constante son los botones que puede aparecer en un MessageBox,
            //Los respecto a los parametros de la operacion Show, el primero es el unico obligatorio, y representa el mensaje que vamos 
            // a desplegar,el segundo parametro es opcional, y representa el titulo de la barra de titulo de la barra del mensaje
            //si no se pone este parametro automaticamente se despliega el nombre de la aplicacion
            //TERCER Parametros no obligatorio, representa la combinacion de botones que se quiere mostrar en el mensajesito,
            //si no se pone por defecto aparece el boton OK(Aceptar)
            //Para eso tenemos el enumerado, nos dice los botones individuales o la combinacion de botones que podemos mostrar
            //CUARTO PARAMETROS,Es opcional, repsresenta al icono que muestra el mensaje, si no se pone nada no hay ninguno por Defecto,
            //si queremos poner icono , ponemos el MessageIcon, y nos da las opciones de los iconos por defecto que hay

        }

        private void FrmCicloVida_Load(object sender, EventArgs e)
        {
            //lugar ideal para iniciallizar datos
            LblLoad.Text = "Entro en el Load";
        }

        private void FrmCicloVida_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cuando se le indica al formulario que se cierre mediante la operacion CLOSE()
            //se genera este evento.
            if ((MessageBox.Show("Esta Seguro que desea Cerrar","Cancelar salida", MessageBoxButtons.YesNo)) == DialogResult.No)
                e.Cancel = true;
        }

    }
}
//EVENTO FORM CLOSE EN FORMULARIO
//PRIMERO QUE NADA LOS ARGUMENTOS DEL EVENTO(SEGUNDO PARAMETRO) ME PERMITE CANCELAR LA SALIDA,DETENER EL CLOSE DEL FORMULARIO
//LA PROPIEDAD SE LLAMA CANCEL, Y POR DEFECTO VIENE CON VALOR QUE ES FALSO, NO SE CANCELA SE SIGUE DE LARGO, SI LO QUE NOSOTROS
//QUEREMOS DETENER EL CIERRE, A UN FORMULARIO TENEMOS QUE PONERLE TRUE A DICHA PROPIEDAD

