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
    public partial class FrmListadoCuenta : Form
    {
        //atributo de formulario
        private Empleado _EmpLogueado;
        private bool _salirConSeleccion;
        private Int32 _NumCuenta;

        //propiedades del formulario
        public bool SalirConSeleccion
        {
            get { return _salirConSeleccion; }
        }

        public Int32 NumCuentaSeleccionada
        {
            get { return _NumCuenta; }
        }

        //constructor
        public FrmListadoCuenta(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
            _salirConSeleccion = false;
        }

        private void FrmListadoCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //verifico si hay algo seleccionado
            if (DGVCuentas.SelectedRows.Count > 0)
            {
                _salirConSeleccion = true;
                _NumCuenta = Convert.ToInt32(DGVCuentas.SelectedRows[0].Cells[0].Value);
            }    
        }

        private void FrmListadoCuenta_Load(object sender, EventArgs e)
        {
            
                //cargo todos los clientes 
                DGVCuentas.AutoGenerateColumns = false;
                DGVCuentas.DataSource = new PresentacionWin.ServicioWeb.WcfServiceClient().ListarTodasCuentas();
          
            //catch (System.Web.Services.Protocols.SoapException ex)
            //{
            //    MessageBox.Show(ex.Detail.InnerText);
            //}
          

        }


    }
}
