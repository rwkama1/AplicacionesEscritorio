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
    public partial class FrmPrinciaplA : Form
    {
        public FrmPrinciaplA()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmAcercaDe _unForm = new FrmAcercaDe();
            _unForm.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutores _unForm = new FrmAutores();
            _unForm.ShowDialog();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibros _unForm = new FrmLibros();
            _unForm.ShowDialog();
        }

        private void cicloDeVidaDelFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCicloVida _unForm = new FrmCicloVida();
            _unForm.Show();
        }

        private void manejoDelMauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManejoMouse _unForm = new FrmManejoMouse();
            _unForm.ShowDialog();
        }

        private void winControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMuestraControles _unForm = new FrmMuestraControles();
            _unForm.ShowDialog();
        }

    }
}
