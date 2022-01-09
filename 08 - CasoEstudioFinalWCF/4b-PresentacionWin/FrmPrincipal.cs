using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using PresentacionWin.ServicioWeb;


namespace PresentacionWin
{
    public partial class FrmPrincipal : Form
    {
        //atributo de formulario
        private Empleado _EmpLogueado;


        public FrmPrincipal(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void aBMDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes _unForm = new FrmClientes(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void aBDeCuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuentaCorriente _unForm = new FrmCuentaCorriente(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimientos _unForm = new FrmMovimientos(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoClientes _unForm = new FrmListadoClientes(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCuenta _unForm = new FrmListadoCuenta(_EmpLogueado);
            _unForm.ShowDialog();
        }

        private void movimientosConFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoMovimientos _unForm = new FrmListadoMovimientos();
            _unForm.ShowDialog();
        }

        private void solicitudesDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamos _unForm = new FrmPrestamos();
            _unForm.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPrestamos _unForm = new FrmListadoPrestamos();
            _unForm.ShowDialog();
        }

    }
}
