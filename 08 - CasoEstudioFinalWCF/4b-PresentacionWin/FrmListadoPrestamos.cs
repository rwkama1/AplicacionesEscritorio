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
    public partial class FrmListadoPrestamos : Form
    {
        public FrmListadoPrestamos()
        {
            InitializeComponent();
        }

        private void FrmListadoPrestamos_Load(object sender, EventArgs e)
        {
            try
            {

                DGVPrestamos.AutoGenerateColumns = false;
                IWcfService spres = new WcfServiceClient();
                //cargo todos los prestamos del sistema
                DGVPrestamos.DataSource = spres.ListoTodosPrestamos();
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
    }
}
