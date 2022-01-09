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
    public partial class FrmManejoMouse : Form
    {

        public FrmManejoMouse()
        {
            InitializeComponent();
        }

        private void BtnMuestra_MouseEnter(object sender, EventArgs e)
        {
            LblOtro.Text = "El Mouse ingreso al area del boton";
        }

        private void BtnMuestra_MouseLeave(object sender, EventArgs e)
        {
            LblOtro.Text = "El Mouse salio del area del boton";
        }

        private void BtnMuestra2_MouseMove(object sender, MouseEventArgs e)
        {
            LblMove.Text = "Posicion del Mouse: X= " + e.X + " Y= " + e.Y;
        }

        private void FrmManejoMouse_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Se selecciono el boton: " + e.Button + "\n" + " En la posicion: " + "\n" + "X= " + e.X + " Y= " + e.Y);
        }

        private void FrmManejoMouse_Load(object sender, EventArgs e)
        {

        }

    }
}
