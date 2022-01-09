using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentacionWin.Windows;
namespace PresentacionWin
{
    public partial class ABMArticulos : Form
    {
        private Articulo articulo;
        public ABMArticulos()
        {
             
            InitializeComponent();
        }
 
        private void ABMArticulos_Load(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            //verifico ingreso de solo numeros
            try
            {
                Convert.ToInt32(TxtCodigo.Text);
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(TxtCodigo, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

            //busqueda del cliente
            try
            {
                Articulo art = null;
                ServicioArticulos Larticulos = new ServicioArticulos();
                art = Larticulos.BuscarArticulo(Convert.ToInt32(TxtCodigo.Text));
                if (art == null)
                {
                    BtnAlta.Enabled = true;
                    LblError.Text = "No se encontro";
                    TxtNombre.Text = "";
                    TxtCodigo.Text = "";
                    TxtPrecio.Text = "";

                }
                else
                {
                    
                    BtnModificar.Enabled = true;
                    BtnBaja.Enabled = true;
                    articulo = art;
                    TxtCodigo.Text = art.Codigo.ToString();
                    TxtNombre.Text = art.Nombre;
                    TxtPrecio.Text = art.Precio.ToString();
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                    LblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                   LblError.Text = ex.Message;
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioArticulos Larticulos = new ServicioArticulos();
                Articulo art = new Articulo();
                art.Codigo = Convert.ToInt32(TxtCodigo.Text);
                art.Nombre = TxtNombre.Text.Trim();
                art.Precio = Convert.ToDecimal(TxtPrecio.Text);


                Larticulos.AgregarArticulo(art);
                BtnAlta.Enabled = true;
                BtnBaja.Enabled = false;
                BtnModificar.Enabled = false;
                TxtNombre.Text = "";
                TxtPrecio.Text = "";



               LblError.Text = "Alta con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                LblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
        }

       

    }
}
