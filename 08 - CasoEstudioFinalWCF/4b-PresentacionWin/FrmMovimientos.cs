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
    public partial class FrmMovimientos : Form
    {
        //atributo de formulario
        private Empleado _EmpLogueado;
        private Cuenta _objCuenta;

        public FrmMovimientos(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void LimpioControles()
        {
            TxtCuenta.Text = "";
            TxtMonto.Text = "";
            RBtnDep.Checked = true;
            RBtnRet.Checked = false;

            LblCuenta.Text = "";
            LblError.Text = "";
        }

         private void DesactivoBotones()
        {
            BtnAlta.Enabled = false;
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioWeb.Movimiento _movimiento = null;

                //verifico que tenga cuenta
                if (_objCuenta == null)
                    throw new Exception("No hay Cuenta Seleccionada - No se Realiza el Movimiento");

                //creo objeto de movimiento
                _movimiento = new ServicioWeb.Movimiento();
                _movimiento.FechaMov = DateTime.Now;
                _movimiento.MontoMov = Convert.ToDouble(TxtMonto.Text);
                _movimiento.UnaCuenta = _objCuenta;
 
                if (RBtnDep.Checked)
                    _movimiento.TipoMov = "D";
                else
                    _movimiento.TipoMov = "R";

                //doy de alta al movimiento
                new PresentacionWin.ServicioWeb.WcfServiceClient().AltaMovimiento(_movimiento);
                this.LimpioControles();
                this.DesactivoBotones();

                //si llego aca todo ok
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //invoco formulario de busqueda.
                FrmListadoCuenta unForm = new FrmListadoCuenta(_EmpLogueado);
                unForm.ShowDialog();

                //verifico si hay seleccion
                if (unForm.SalirConSeleccion)
                {
                    TxtCuenta.Text = unForm.NumCuentaSeleccionada.ToString();
                    TxtCuenta_Validating(TxtCuenta, new CancelEventArgs());
                }
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
            this.LimpioControles();
            this.DesactivoBotones();
            _objCuenta = null;
        }

        private void TxtCuenta_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            //try
            //{
                if (TxtCuenta.Text.Trim().Length > 1)
                {
                    Convert.ToInt32(TxtCuenta.Text);
                    EPNumeros.Clear();
                }
            //}

            //catch (Exception ex)
            //{
            //    EPNumeros.SetError(TxtCuenta, "Solo se pueden ingresar numeros");
            //    e.Cancel = true;
            //}

            //try
            //{
                //verifico si se ingreso algo
                if (TxtCuenta.Text.Trim().Length == 0)
                    return;

                //busco la cuenta
                _objCuenta = null;
                _objCuenta = new PresentacionWin.ServicioWeb.WcfServiceClient().BuscarCuenta(Convert.ToInt32(TxtCuenta.Text));
                if (_objCuenta == null)
                    throw new Exception("No se encontro a la Cuenta");
                else
                {
                    LblCuenta.Text = _objCuenta.SaldoCuenta + " " + _objCuenta.UnCliente.NomCli;
                    BtnAlta.Enabled = true;
                }
            //}
            //catch (System.Web.Services.Protocols.SoapException ex)
            //{
            //    if (ex.Detail.InnerText.Length > 40)
            //        LblError.Text = ex.Detail.InnerText.Substring(0, 40);
            //    else
            //        LblError.Text = ex.Detail.InnerText;
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message.Length > 40)
            //        LblError.Text = ex.Message.Substring(0, 40);
            //    else
            //        LblError.Text = ex.Message;
            //}
        }

        private void TxtMonto_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToInt32(TxtMonto.Text);
                EPNumeros.Clear();
            }

            catch (Exception ex)
            {
                EPNumeros.SetError(TxtMonto, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

        }
    }
}
