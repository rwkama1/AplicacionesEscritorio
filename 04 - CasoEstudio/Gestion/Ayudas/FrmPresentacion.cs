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
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }
          
        private void Conometro_Tick(object sender, EventArgs e)
        {
            //deshabilito el coronometro
            Conometro.Enabled = false;
            //oculto a la vista del usuario formulario actual - no se elimina de la memoria
            this.Hide();
            //hago que se muestre el siguiente formulario
            FrmLogin _unForm = new FrmLogin();
            _unForm.ShowDialog();
            //cierro el formulario actual
            this.Close();
        }
 
    }
}
