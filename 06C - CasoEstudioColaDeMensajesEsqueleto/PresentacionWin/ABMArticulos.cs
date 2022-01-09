using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//referencias
using EntidadesCompartidas;
using Logica;


namespace PresentacionWin
{
    public partial class ABMArticulos : Form
    {
        //creo atributo que mantiene en memoria el objeto Articulo con el cual se esta trabajando
        private Articulo _objArticulo = null;

        public ABMArticulos()
        {
            InitializeComponent();
        }

        //metodo que deja botones por defecto
        private void ActivoPorDefecto()
        {
            //verifico botones activos
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            //limpio pantalla
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtPrecio.Text = "";
            //determino q no hay libro
            _objArticulo = null;
        }

        //metodo que activa los botones para actualizacion
        private void ActivoActualizacion()
        {
            //verifico botones activos
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            //cargo articulo en pantalla
            TxtCodigo.Text = _objArticulo.Codigo.ToString();
            TxtNombre.Text = _objArticulo.Nombre;
            TxtPrecio.Text = _objArticulo.Precio.ToString();
        }

        //metodo que activa los botones para agregar
        private void ActivoAgregar()
        {
            //verifico botones activos
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            //limpio pantalla
            TxtNombre.Text = "";
            TxtPrecio.Text = "";
        }

        private void ABMArticulos_Load(object sender, EventArgs e)
        {
            //determino como queda la pantalla por defecto
            this.ActivoPorDefecto();
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //busco si existe articulo con este codigo
                _objArticulo = FabricaLogica.getLogicaArticulo().BuscarArticulo(Convert.ToInt32(TxtCodigo.Text));

                //verifico accion en funcion de si se encuentra o no
                if (_objArticulo == null)
                    this.ActivoAgregar();
                else
                    this.ActivoActualizacion();

            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }

        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo acepto numeros y teclas de control
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) 
                e.Handled = true;

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                //creo objeto 
                Articulo _unArticulo = new Articulo();
                _unArticulo.Codigo = Convert.ToInt32(TxtCodigo.Text); 
                _unArticulo.Nombre = TxtNombre.Text.Trim();
                _unArticulo.Precio = Convert.ToDecimal(TxtPrecio.Text);

                //doy alta
                FabricaLogica.getLogicaArticulo().AgregarArticulo(_unArticulo);
                LblError.Text = "Alta con exito";

                //defino pantalla
                this.ActivoPorDefecto();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            //determino como queda la pantalla por defecto
            this.ActivoPorDefecto();
        }

       
    }
}
