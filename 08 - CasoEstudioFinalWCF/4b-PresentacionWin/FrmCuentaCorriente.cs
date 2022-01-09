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
    public partial class FrmCuentaCorriente : Form
    {

        //atributo de formulario
        private Empleado _EmpLogueado;
        private Cliente _objCliente;

        public FrmCuentaCorriente(Empleado pEmp)
        {
            InitializeComponent();
            _EmpLogueado = pEmp;
        }

        private void LimpioControles()
        {
            TxtCliente.Text = "";
            TxtMinimo.Text = "";
            LblCliente.Text = "";
            LblError.Text = "";
        }

        private void ActualizoGrilla()
        {
            DGVCuentas.AutoGenerateColumns = false;
            DGVCuentas.DataSource = new PresentacionWin.ServicioWeb.WcfServiceClient().ListarCuentaCorriente().ToList();
        }

        private void DesactivoBotones()
        {
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
            //    //verifico que tenga cliente
                if (_objCliente == null)
                    throw new Exception("No hay Cliente Seleccionado - No se crea la cuenta");

                //doy de alta a la cuenta
                ServicioWeb.CuentaCorriente _cuenta = new ServicioWeb.CuentaCorriente();
                _cuenta.UnCliente=_objCliente;
                 _cuenta.MinimoCta= Convert.ToInt32(TxtMinimo.Text);
                 new PresentacionWin.ServicioWeb.WcfServiceClient().AltaCuenta(_cuenta);
                this.LimpioControles();
                this.ActualizoGrilla();
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
                //if (ex.Message.Length > 40)
                //    LblError.Text = ex.Message.Substring(0, 40);
                //else
                LblError.Text = ex.Message;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //invoco formulario de busqueda.
                FrmListadoClientes unForm = new FrmListadoClientes(_EmpLogueado);
                unForm.ShowDialog();

                //verifico si hay seleccion
                if (unForm.SalirConSeleccion)
                {
                    TxtCliente.Text = unForm.NumClienteSeleccionado.ToString();
                    TxtCliente_Validating(TxtCliente, new CancelEventArgs());
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
            this.ActualizoGrilla();
            this.DesactivoBotones();
            _objCliente = null;
        }

        private void FrmCuentaCorriente_Load(object sender, EventArgs e)
        {
            try
            {
               //primer acceso a la pagina - cargo grilla con las cuentas corrientes que hay para que se puedan eliminar
                    this.LimpioControles();
                    this.ActualizoGrilla();
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

        private void TxtCliente_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToInt32(TxtCliente.Text);
                EPNumeros.Clear();
            }

            catch (Exception ex)
            {
                EPNumeros.SetError(TxtCliente, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

            try
            {
                //verifico si se ingreso algo
                if (TxtCliente.Text.Trim().Length == 0)
                    return;

                //busco al cliente
                _objCliente = null;
                _objCliente = new PresentacionWin.ServicioWeb.WcfServiceClient().BuscarCliente(Convert.ToInt32(TxtCliente.Text));
                if (_objCliente == null)
                    throw new Exception("No se encontro al cliente");
                else
                {
                    LblCliente.Text = _objCliente.NomCli;
                    BtnAlta.Enabled = true;
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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                //verifico que se hay seleccion en la grilla
                if (DGVCuentas.SelectedRows.Count == 0)
                    LblError.Text = "Debe seleccionar la cuenta a eliminar";

                //determino la cuenta a eliminar
                ServicioWeb.Cuenta _unaCuenta = new PresentacionWin.ServicioWeb.WcfServiceClient().BuscarCuenta(Convert.ToInt32(DGVCuentas.SelectedRows[0].Cells[0].Value));

                //trato de eliminar la cuenta
                if (_unaCuenta == null)
                    throw new Exception("No se encontro la Cuenta para Eliminarla");
                else
                    new PresentacionWin.ServicioWeb.WcfServiceClient().BajaCuenta(_unaCuenta);

                //si llego aca, todo ok
                this.LimpioControles();
                this.ActualizoGrilla();
                this.DesactivoBotones();
                LblError.Text = "Se elimino Exitosamente";
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

        private void DGVCuentas_SelectionChanged(object sender, EventArgs e)
        {
            //determino si hay seleccion, que se pueda eliminar
            if (DGVCuentas.SelectedRows.Count > 0)
                BtnBaja.Enabled = true;
        }

        private void TxtMinimo_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToDouble(TxtMinimo.Text);
                EPNumeros.Clear();
            }

            catch (Exception ex)
            {
                EPNumeros.SetError(TxtMinimo, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

        }

 
    }
}
