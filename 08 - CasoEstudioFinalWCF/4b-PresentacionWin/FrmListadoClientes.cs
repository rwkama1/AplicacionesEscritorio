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
    public partial class FrmListadoClientes : Form
    {
        //atributo de formulario
        private Empleado _EmpLogueado;
        private bool _salirConSeleccion;
        private Int32 _NumCliente;

        //propiedades del formulario
        public bool SalirConSeleccion
        {
            get { return _salirConSeleccion; }
        }

        public Int32 NumClienteSeleccionado
        {
            get { return _NumCliente; }
        }

        //constructor
        public FrmListadoClientes(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
            _salirConSeleccion = false;
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                //cargo todos los clientes 
                DGVClientes.DataSource = new PresentacionWin.ServicioWeb.WcfServiceClient().ListarTodosClientes();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                MessageBox.Show(ex.Detail.InnerText);
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmListadoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //verifico si hay algo seleccionado
            if (DGVClientes.SelectedRows.Count > 0)
            {
                _salirConSeleccion = true;
                _NumCliente = Convert.ToInt32(DGVClientes.SelectedRows[0].Cells[0].Value);
            }
        }


    }
}
