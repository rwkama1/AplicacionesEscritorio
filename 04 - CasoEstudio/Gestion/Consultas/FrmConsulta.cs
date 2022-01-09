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
    public partial class FrmConsulta : Form
    {

        public FrmConsulta()
        {
            InitializeComponent();
        }


        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            TipoLibros.MisTipos = Logica.FabricaLogica.getLogicaTipo().ListarTipo();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            //obtengo dato de parametrizacion
            EntidadesCompartidas.TipoLibro _unTipo = TipoLibros.SeleccionTipo;

            //genero listado
            List<EntidadesCompartidas.Libro> _Consulta;
            if (_unTipo != null)
            {
                 _Consulta= Logica.FabricaLogica.getLogicaLibro().ListarLibroPorTipo(_unTipo);
                 DgvLibros.DataSource = _Consulta;
            }
        }

    }
}
