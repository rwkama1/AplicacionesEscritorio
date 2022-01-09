using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//espacio de nombres necesarios para generar la interfaz grafica
using System.Windows.Forms;


namespace ControlesWin
{
    //generacion de un CustomControl
    public class ManejoTelefonos : ContainerControl
    {
        //atributos
        private Label UnTitulo;
        private ListBox LbTelefonos;
        private Button BtnAgregarTel;
        private TextBox UnTel;
        private Button BtnBorrarTel;
        private Label LblErrorCC;
 

        //propiedades
        public List<string> ListaTelefonos
        {
            get
            {
                List<string> _lista = new List<string>();

                foreach (Object unTel in LbTelefonos.Items)
                   _lista.Add(unTel.ToString());

                return _lista;
            }

            set
            {
                LbTelefonos.Items.Clear();

                if (value != null)
                {
                    foreach (string _unTel in value)
                        LbTelefonos.Items.Add(_unTel);
                }
            }
        }

        //constructor
        public ManejoTelefonos()
        {
            //agrego titulo
            UnTitulo = new Label();
            UnTitulo.Text = "TELEFONOS";
            UnTitulo.ForeColor = System.Drawing.Color.Red;
            this.Controls.Add(UnTitulo);

            //agrego el listbox
            LbTelefonos = new ListBox();
            LbTelefonos.Width = 150;
            this.Controls.Add(LbTelefonos);

            //agrego caja de texto para ingreso telefono
            UnTel = new TextBox();
            UnTel.Text = "";
            UnTel.Width = 150;
            this.Controls.Add(UnTel);

            BtnAgregarTel = new Button();
            BtnAgregarTel.Text = "Agregar";
            BtnAgregarTel.Click += new EventHandler(AltaTelefono);
            this.Controls.Add(BtnAgregarTel);

            //agrego  boton de borrar
            BtnBorrarTel = new Button();
            BtnBorrarTel.Text = "Borrar";
            BtnBorrarTel.Click += new EventHandler(BorrarTelefono);
            this.Controls.Add(BtnBorrarTel);

            //agrego la etiqueta de errores
            LblErrorCC = new Label();
            LblErrorCC.Text = "";
            this.Controls.Add(LblErrorCC);
        }

        //sobreescribo el metodo CreateChilCntrols
        protected override void  OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //determino despliegue de los controles en pantalla
            UnTitulo.Location= new System.Drawing.Point(40,0);
            LbTelefonos.Location = new System.Drawing.Point(5,24);
            UnTel.Location= new System.Drawing.Point(5,124);
            BtnAgregarTel.Location = new System.Drawing.Point(5,145);
            BtnBorrarTel.Location= new System.Drawing.Point(85,145);
            LblErrorCC.Location = new System.Drawing.Point(20,170);
           
        }

        protected void AltaTelefono(object sender, EventArgs e)
        {
            //verifico q se haya ingresado algo en la caja de texto de telefono
            if (UnTel.Text.Trim().Length > 0)
            {
                LbTelefonos.Items.Add(UnTel.Text.Trim());
                UnTel.Text = "";
                LblErrorCC.Text = "Se agrego Correctamente el Telefono a la Lista";
            }
            else
                LblErrorCC.Text = "No Hay nada ingresado - No se agrega Telefono a la lista";
        }

        protected void BorrarTelefono(object sender, EventArgs e)
        {
            //determino si hay una linea de la lista seleccionada
            if (LbTelefonos.SelectedIndex >= 0)
            {
                LbTelefonos.Items.RemoveAt(LbTelefonos.SelectedIndex);
                LblErrorCC.Text = "Eliminacion del Telefono de la Lista con Exito";
            }
            else
                LblErrorCC.Text = "Debe Seleccionar un telefono de la lista para eliminar";
        }

        public void LimpiarTodo()
        {
            LbTelefonos.Items.Clear();
        }

    }
}
