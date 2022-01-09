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
    public partial class FrmLogueo : Form
    {

        public FrmLogueo()
        {
            InitializeComponent();

            //creo el controlador del evento de logueo del ControlLogueo
            MiControlLogin.AutenticarUsuario += new EventHandler(VerificoIngreso);
        }

        public void VerificoIngreso(object sender, EventArgs e)
        {
            try
            {
                Empleado _unEmpleado = new PresentacionWin.ServicioWeb.MiServicio().LogueoEmpleado(MiControlLogin.Usuario,MiControlLogin.Contraseña);

                if (_unEmpleado == null)
                    LblError.Text = "CI o Pass Invalidos";
                else
                {
                    this.Hide();
                    Form _unForm = new FrmPrincipal(_unEmpleado);
                    _unForm.ShowDialog();
                    this.Close();
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    LblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    LblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    LblError.Text = ex.Message.Substring(0, 40);
                else
                    LblError.Text = ex.Message;
            }

        }
    }
}
