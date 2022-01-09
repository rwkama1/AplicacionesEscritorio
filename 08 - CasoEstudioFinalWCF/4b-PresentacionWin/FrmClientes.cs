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
    public partial class FrmClientes : Form
    {
        //atributo de formulario
        private Empleado _EmpLogueado;
        private Cliente _objCliente;


        public FrmClientes(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void DesActivoBotones()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void LimpioControles()
        {
            TxtNumero.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtUsuario.Text = "";
            TxtPassword.Text = "";
            LblError.Text = "";

            TxtNumero.Enabled = false;
            TxtNumero.ReadOnly = true;
        }

        private void TxtNumero_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToInt32(TxtNumero.Text);
                EPNumeros.Clear();
            }
            catch (Exception ex)
            {
                EPNumeros.SetError(TxtNumero, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

            //busqueda del cliente
            try
            {
                Cliente _unCliente = null;
                _unCliente = new PresentacionWin.ServicioWeb.WcfServiceClient().BuscarCliente(Convert.ToInt32(TxtNumero.Text));
                this.LimpioControles();
                ManejoTelefonosCliente.LimpiarTodo();


                if (_unCliente == null)
                {
                    BtnAlta.Enabled = true;
                }
                else
                {
                    BtnModificar.Enabled = true;
                    BtnBaja.Enabled = true;
                    _objCliente = _unCliente;
                    TxtNumero.Text = _unCliente.NumCli.ToString();
                    TxtNombre.Text = _unCliente.NomCli;
                    TxtDireccion.Text = _unCliente.DirCli;
                    TxtUsuario.Text = _unCliente.UsuCli;
                    TxtPassword.Text = _unCliente.PassCli;
                    ManejoTelefonosCliente.ListaTelefonos = _unCliente.ListaTelefonos.ToList(); ;
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

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente _unCliente = new Cliente();
                _unCliente.NomCli=TxtNombre.Text.Trim();
                _unCliente.DirCli = TxtDireccion.Text.Trim();
                _unCliente.UsuCli=TxtUsuario.Text.Trim();
                _unCliente.PassCli = TxtPassword.Text.Trim();
                _unCliente.ListaTelefonos = ManejoTelefonosCliente.ListaTelefonos.ToArray();

                new PresentacionWin.ServicioWeb.WcfServiceClient().AltaCliente(_unCliente);
                this.DesActivoBotones();
                this.LimpioControles();
                ManejoTelefonosCliente.LimpiarTodo();
                TxtNumero.Enabled = true;
                TxtNumero.ReadOnly = false;

                LblError.Text = "Alta con Exito";
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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                new PresentacionWin.ServicioWeb.WcfServiceClient().BajaCliente(_objCliente);
                this.DesActivoBotones();
                this.LimpioControles();
                ManejoTelefonosCliente.LimpiarTodo();
                TxtNumero.Enabled = true;
                TxtNumero.ReadOnly = false;

                LblError.Text = "Baja con Exito";
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                _objCliente.NomCli = TxtNombre.Text.Trim();
                _objCliente.DirCli = TxtDireccion.Text.Trim();
                _objCliente.UsuCli = TxtUsuario.Text.Trim();
                _objCliente.PassCli = TxtPassword.Text.Trim();
                _objCliente.ListaTelefonos = ManejoTelefonosCliente.ListaTelefonos.ToArray();
                new PresentacionWin.ServicioWeb.WcfServiceClient().ModificarCliente(_objCliente);
                this.DesActivoBotones();
                this.LimpioControles();
                ManejoTelefonosCliente.LimpiarTodo();
                TxtNumero.Enabled = true;
                TxtNumero.ReadOnly = false;

                LblError.Text = "Modificacion con Exito";
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

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            _objCliente = null;
            this.DesActivoBotones();
            this.LimpioControles();
            ManejoTelefonosCliente.LimpiarTodo();
            TxtNumero.Enabled = true;
            TxtNumero.ReadOnly = false;

        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            LblError.Text = "";
        }
    }
}
