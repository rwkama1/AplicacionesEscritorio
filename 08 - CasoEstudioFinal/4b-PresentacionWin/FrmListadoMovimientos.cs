using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentacionWin
{
    public partial class FrmListadoMovimientos : Form
    {
        //atributos delñ formulario
        List<ServicioWeb.Movimiento> _listaTotal;

        public FrmListadoMovimientos()
        {
            InitializeComponent();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                //en funcion de la seleccion del combo, se filtra y despliegan los datos
                if (CBTipoBusqueda.SelectedIndex == -1)
                {
                    LblError.Text = "Debe seleccionar algo en la lista de seleccion";
                }
                else if (CBTipoBusqueda.SelectedIndex == 0)
                {
                    //se muestra todo
                    DGVListar.DataSource = _listaTotal;
                }
                else if (CBTipoBusqueda.SelectedIndex == 1)
                {
                    //se filtra por el numero de cuenta ingresado en la caja de texto

                    //verifico ingreso en la caja
                    if (TxtFiltro.Text.Trim().Length == 0)
                    {
                        DGVListar.DataSource = null;
                        throw new Exception("No se ingreso el numero de cuenta en la caja de texto");
                    }

                    try { Convert.ToInt32(TxtFiltro.Text); }
                    catch
                    {
                        DGVListar.DataSource = null;
                        throw new Exception("EL dato digitado no es numerico, no se filtra");
                    }


                    //si llego aca tengo datos para filtros.
                    List<ServicioWeb.Movimiento> _Resultado = (from UnMov in _listaTotal
                                                               where UnMov.UnaCuenta.NumCta == Convert.ToInt32(TxtFiltro.Text)
                                                               select UnMov).ToList<ServicioWeb.Movimiento>();
                    DGVListar.DataSource = _Resultado;

                }
                else if (CBTipoBusqueda.SelectedIndex == 3)
                {
                    //se filtra por la fecha ingresada en la caja de texto

                    //verifico ingreso en la caja
                    try { Convert.ToDateTime(TxtFiltro.Text); }
                    catch
                    {
                        DGVListar.DataSource = null;
                        throw new Exception("EL dato digitado no es una fecha valida, no se filtra");
                    }


                    //si llego aca tengo datos para filtros.
                    List<ServicioWeb.Movimiento> _Resultado = (from UnMov in _listaTotal
                                                               where UnMov.FechaMov == Convert.ToDateTime(TxtFiltro.Text)
                                                               select UnMov).ToList<ServicioWeb.Movimiento>();
                    DGVListar.DataSource = _Resultado;
                }
                else if (CBTipoBusqueda.SelectedIndex == 2)
                {
                    //se filtra por el tipo de movimiento ingresado en la caja de texto
 
                    //verifico ingreso en la caja
                    if (TxtFiltro.Text.Trim().ToUpper() != "R" && TxtFiltro.Text.Trim().ToUpper() != "D")
                    {
                        DGVListar.DataSource = null;
                        throw new Exception("No se ingreso un tipo de Movimiento Correcto - No se filtra");
                    }

                    //si llego aca tengo datos para filtros.
                    List<ServicioWeb.Movimiento> _Resultado = (from UnMov in _listaTotal
                                                               where UnMov.TipoMov == TxtFiltro.Text.Trim().ToUpper()
                                                               select UnMov).ToList<ServicioWeb.Movimiento>();
                    DGVListar.DataSource = _Resultado;
                }
                else if (CBTipoBusqueda.SelectedIndex == 4)
                {
                    //se despliega la cantidad de movimientos por cuenta 

                     var _ResultadoLinQ = from UnMov in _listaTotal
                                            group UnMov by UnMov.UnaCuenta.NumCta
                                            into Auxiliar
                                            select new {
                                                Cuenta = Auxiliar.First().UnaCuenta.NumCta,
                                                Cantidad = Auxiliar.Count()
                                            };

                    ArrayList _ResultadoFinal = new ArrayList();

                    foreach(var unObj in _ResultadoLinQ)
                        _ResultadoFinal.Add(unObj);
                                            
                    DGVListar.DataSource = _ResultadoFinal;
                }
                else if (CBTipoBusqueda.SelectedIndex == 5)
                {
                    //se muestran ordenado por numero de cuenta y fecha
                    List<ServicioWeb.Movimiento> _Resultado = (from UnMov in _listaTotal
                                                               orderby UnMov.UnaCuenta.NumCta, UnMov.FechaMov
                                                               select UnMov).ToList<ServicioWeb.Movimiento>();
                    DGVListar.DataSource = _Resultado;
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

        private void FrmListadoMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                //obtengo toda los movimientos sin filtrar de la base de datos
                _listaTotal = new PresentacionWin.ServicioWeb.MiServicio().ListarTodosMovimientos().ToList();
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

        private void Cronometro_Tick_1(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void CBTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBTipoBusqueda.SelectedIndex == 0)
                LblDatoFiltro.Text = "Dato para Filtro";
            else if (CBTipoBusqueda.SelectedIndex == 1)
                LblDatoFiltro.Text = "Ingrese Nro. Cuenta:";
            else if (CBTipoBusqueda.SelectedIndex == 2)
                LblDatoFiltro.Text = "Ingrese Tipo Movimiento:";
            else if (CBTipoBusqueda.SelectedIndex == 3)
                LblDatoFiltro.Text = "Ingrese Fecha Movimiento:";
            else if (CBTipoBusqueda.SelectedIndex == 4)
                LblDatoFiltro.Text = "Dato para Filtro";
            else if (CBTipoBusqueda.SelectedIndex == 5)
                LblDatoFiltro.Text = "Dato para Filtro";
        }
    }
}
