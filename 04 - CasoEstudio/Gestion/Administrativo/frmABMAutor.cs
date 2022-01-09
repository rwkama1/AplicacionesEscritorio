using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntidadesCompartidas;

namespace Gestion.Administrativo
{
    public partial class frmABMAutor : Form
    {
        private Autor objautor = null;
        public frmABMAutor()
        {
            InitializeComponent();
        }
        private void ActivoPorDefecto()
        {
            
            btnaltados.Enabled = false;
          btnbaja.Enabled = false;
            btnmodificar.Enabled = false;

           
           txtcodigo.Text = "";
          txtnombre.Text = "";
           txtnacionalidad.Text = "";

           objautor = null;
        }
        private void ActivoActualizacion()
        {
            //verifico botones activos
            btnaltados.Enabled = false;
            btnbaja.Enabled = true;
            btnmodificar.Enabled = true;

            //cargo libro en pantalla
            txtcodigo.Text =objautor.Codigo.ToString() ;
            txtnombre.Text = objautor.Nombre;
            txtnacionalidad.Text = objautor.Nacionalidad;
        }
        private void ActivoAgregar()
        {
            //verifico botones activos
            btnaltados.Enabled = true;
            btnbaja.Enabled = false;
            btnmodificar.Enabled = false;

            //limpio ingreso
          
            txtnombre.Text = "";
            txtnacionalidad.Text = "";
        }
        private void Codigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                
                //busco si existe libro con este isbn
                objautor = Logica.FabricaLogica.getLogicaAutor().BuscarAutor(Convert.ToInt32(txtcodigo.Text));

                //verifico accion en funcion de si se encuentra o no
                if (objautor == null)
                    this.ActivoAgregar();
                else
                    this.ActivoActualizacion();

            }
            catch (Exception ex)
            {
                 = ex.Message;
            }
        }
     
       

        
    }
}
