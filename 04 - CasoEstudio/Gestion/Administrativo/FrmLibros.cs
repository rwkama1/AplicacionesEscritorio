using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntidadesCompartidas;

namespace Gestion
{
    public partial class FrmLibros : Form
    {
        //primero hay que utilizar elementos windows , hay algunos botones que van a desaparecer ,por que no puedo capturar,
        //el primero que desaparece es el boton buscar, ya que la cajita de texto del identificador,
        //puedo capturar el evento Validating,cuando se trate de salir de esa cajita ya puedo utilizar la busqeda, y ver si es baja alta etc
        //Apartir del validating se ven las demas cajitas, se ven los demas controles qe sean correctos y ahi cargas datos
        //Seria util colocar los botones de abm basicas,en una barra de tareas ya que por lo general , el usuario va buscar eso,
        //a un menu o a una barra de tareas
        //
       

        //creo atributo que mantiene en memoria el objeto Libro con el cual se esta trabajando
        private Libro _objLibro = null;//UN OBJETO PUEDE TENER ATRIBUTOS PROPIOS, LOS FORMULARIOS SON  OBJETOS 

        public FrmLibros()
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

            //cargo libro en pantalla
            Isbn.Ingreso = "0";
            TxtNombre.Text = "";
            RTxtReseña.Text = "";
            Autores.SelectedIndex = -1;
            TipoLibros.SelectedIndex = -1;

            //determino q no hay libro
            _objLibro = null;
        }

        //metodo que activa los botones para actualizacion
        private void ActivoActualizacion()
        {
            //verifico botones activos
            BtnAlta.Enabled = false;
            BtnBaja.Enabled = true;
            BtnModificar.Enabled = true;

            //cargo libro en pantalla
            Isbn.Ingreso = _objLibro.Codigo.ToString();
            TxtNombre.Text = _objLibro.Nombre;
            RTxtReseña.Text = _objLibro.Reseña;
            Autores.SeleccionarAutor(_objLibro.UnAutor);
            TipoLibros.SeleccionarTipo(_objLibro.UnTipo);
        }

        //metodo que activa los botones para agregar
        private void ActivoAgregar()
        {
            //verifico botones activos
            BtnAlta.Enabled = true;
            BtnBaja.Enabled = false;
            BtnModificar.Enabled = false;

            //limpio ingreso
            TxtNombre.Text = "";
            RTxtReseña.Text = "";
            Autores.SelectedIndex = -1;
            TipoLibros.SelectedIndex = -1;
        }
        
        //se ejecuta cuando el usuaro intenta salir de la caja de texto del ISBN
        private void Isbn_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //busco si existe libro con este isbn
                _objLibro = Logica.FabricaLogica.getLogicaLibro().BuscarLibro(Convert.ToInt32(Isbn.Ingreso));
            
                //verifico accion en funcion de si se encuentra o no
                if (_objLibro == null)
                    this.ActivoAgregar();
                else
                    this.ActivoActualizacion();

            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            try
            {
                //cargo las listas de autores y tipo de libro
                Autores.MisAutores = Logica.FabricaLogica.getLogicaAutor().ListarAutor();
                TipoLibros.MisTipos = Logica.FabricaLogica.getLogicaTipo().ListarTipo();
               
                //determino como queda la pantalla por defecto
                this.ActivoPorDefecto();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                //creo objeto 
                Libro _unLibro = new Libro(Convert.ToInt32(Isbn.Ingreso), TxtNombre.Text.Trim(), RTxtReseña.Text.Trim(), Autores.SeleccionAutor, TipoLibros.SeleccionTipo);

                //doy alta
                Logica.FabricaLogica.getLogicaLibro().AltaLibro(_unLibro);
                LblError.Text = "Alta con exito";

                //defino pantalla
                this.ActivoPorDefecto();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                //doy baja
                Logica.FabricaLogica.getLogicaLibro().BajaLibro(_objLibro);
                LblError.Text = "Baja con exito";
                
                //determino pantalla
                this.ActivoPorDefecto();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //modifico el libro seleccionado
                _objLibro.Nombre = TxtNombre.Text.Trim();
                _objLibro.Reseña = RTxtReseña.Text.Trim();
                _objLibro.UnAutor = Autores.SeleccionAutor;
                _objLibro.UnTipo = TipoLibros.SeleccionTipo;

                //mando a modificar
                Logica.FabricaLogica.getLogicaLibro().ModificaLibro(_objLibro);
                LblError.Text = "Modificacion con exito";
                
                //determino pantalla
                this.ActivoPorDefecto();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            this.ActivoPorDefecto();
        }

    }
}
