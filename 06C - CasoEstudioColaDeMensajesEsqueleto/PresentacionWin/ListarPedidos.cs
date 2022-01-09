using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentacionWin
{
    public partial class ListarPedidos : Form
    {
        public ListarPedidos()
        {
            InitializeComponent();
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            DGVListado.DataSource = Logica.FabricaLogica.getLogicaPedido().ListarPedidos();
        }

    }
}
