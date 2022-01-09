using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class TextBoxSoloNumeros : UserControl
    {
        public TextBoxSoloNumeros()
        {
            InitializeComponent();
        }

        //creo propiedad publica para obtener lo que el usuario ingreso en la caja de texto
        public String Ingreso
        {
            get { return TxtIngreso.Text; }
            set
            {
                try
                {
                    Convert.ToInt64(value);
                    TxtIngreso.Text = value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Solo se puede asignar numeros al control" + ex.Message);
                }
            }
        }

        //capturo evento de cuando se digita una tecla
        private void TxtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifico si lo que se digito no es un numero o una tecla de edicion tipo backspace
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                //no dejo que se escriba la tecla en la caja de texto
                e.Handled = true;
            }
        }

    }
}
