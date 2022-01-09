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
    public partial class FrmPrincipalC : Form
    {
        public FrmPrincipalC()
        {
            InitializeComponent();
        }

        private void librosDeUnAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelacionTablas _unForm = new FrmRelacionTablas();
            _unForm.ShowDialog();
        }

        private void librosXAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta _unForm = new FrmConsulta();
            _unForm.ShowDialog();
        }
    }
}
