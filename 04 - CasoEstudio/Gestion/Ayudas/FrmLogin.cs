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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CkUsuAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            //determino si se quiere ingresar como usuario anonimo, asi limpio y deshabilito las cajas de usuario registrado
            if (CkUsuAnonimo.Checked)
            {
                TxtUsuario.Text = "";
                TxtUsuario.Enabled = false;
                TxtPassword.Text = "";
                TxtPassword.Enabled = false;

            }
            else
            {
                TxtUsuario.Enabled = true;
                TxtPassword.Enabled = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CkUsuAnonimo.Checked)
            {
                //oculto a la vista del usuario formulario actual - no se elimina de la memoria
                this.Hide();//Ocultar mostrar el prox y cerrar solo se hace en forma sincronica

                //hago que se muestre el siguiente formulario
                FrmPrincipalC _unForm = new FrmPrincipalC();
                _unForm.ShowDialog();

                //cierro el formulario actual
                this.Close();
            }
            else
            {
                try
                {
                    //determino intento de ingreso de usuario registrado
                    EntidadesCompartidas.Usuario _unUsuario = Logica.FabricaLogica.getLogicaUsuario().BuscarUsuario(TxtUsuario.Text.Trim());
                    if (_unUsuario == null)
                        LblError.Text = "No existe el usuario";
                    else if (_unUsuario.Password.ToUpper() == TxtPassword.Text.Trim().ToUpper())//diferencia en comparar la pasword en la base de datos  y en c#, en base de datos 
                        //la comparaciones
                        //no son Case Sensitive por defecto,sin embargo lo hace con C# tenemos el Case Sensitive, por defecto
                    {
                        //oculto a la vista del usuario formulario actual - no se elimina de la memoria
                        this.Hide();

                        //hago que se muestre el siguiente formulario
                        FrmPrinciaplA _unForm = new FrmPrinciaplA();
                        _unForm.ShowDialog();

                        //cierro el formulario actual
                        this.Close();
                    }
                    else
                        LblError.Text = "Password incorrecta";
                }
                catch (Exception ex)
                {
                    LblError.Text = ex.Message;
                }
            }
        }

    }
}
