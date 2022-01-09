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
    public partial class FrmMuestraControles : Form
    {

        public FrmMuestraControles()
        {
            InitializeComponent();
        }

        private void BtnMuestra_Click(object sender, EventArgs e)
        {
            DtpFechaLarga.Value = DtpFechaLarga.Value.AddYears(-10);
        }

        private void BtnInvoco_Click(object sender, EventArgs e)
        {
            DialogResult _resultado = DialogoColor.ShowDialog();
            if (_resultado == DialogResult.OK)
            {
                BtnMuestra.BackColor = DialogoColor.Color;
                TxtMuestra.ForeColor = DialogoColor.Color;
            }
        }

        private void TxtNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TxtNumero.Text);
                EPMisErrores.Clear();
            }
            catch 
            {
                e.Cancel = true;
                EPMisErrores.SetError(TxtNumero, "No son solo Numeros");
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            //obtengo Datos a desplegar
            List<Autor> _ListaAutores = Logica.FabricaLogica.getLogicaAutor().ListarAutor();
            List<TipoLibro> _ListaTipos = Logica.FabricaLogica.getLogicaTipo().ListarTipo();

            //cargo el listbox con los autores - Por defecto aplica el to String
            LbAutores.DataSource = null;//hacer el datasource null primero y depsues hacer un Clear, no es como en la web
            LbAutores.Items.Clear();
            LbAutores.DataSource = _ListaAutores;
            LbAutores.SelectedIndex = -1;

            //Puedo determinar q se muestra
            LbAutores.DisplayMember = "Nombre";
             LbAutores.ValueMember = "Codigo";

            //cargo grilla con los tipos de libros
            DgvTipos.DataSource = _ListaTipos;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string _mensaje = "";

            //cargo seleccion de Lista autores
            if (LbAutores.SelectedIndex >= 0)
            {
                _mensaje += "          Seleccion de Control ListBox            \n";
                _mensaje += "Codigo: " + ((Autor)LbAutores.SelectedItem).Codigo + "\n";//DEVUELVE UN PUNTERO GENERICO, UN OBJECT
                _mensaje += "Nombre: " + ((Autor)LbAutores.SelectedItem).Nombre + "\n";
                _mensaje += "Nacionalidad: " + ((Autor)LbAutores.SelectedItem).Nacionalidad + "\n\n";
            }

            //cargo seleccion de Grilla de Tipos de Libro
            if (DgvTipos.SelectedRows.Count > 0)//SELECTEDROW ES EL CONJUNTO DE LINEA QUE PUEDE ESTAR SELECCIONA EN UNA GRILLA
                //ACA SI PODEMOS TENEMOS MAS DE UNA SELECCION,SI QUIERO TENER 1 SELECCIONADO,TENGO QUE TENER EL USUARIO MULTISELECT EN FALSE
            {//CONTENTCELLDOBLECLICK , ES UNA EVENTO QUE SE PUEDE CAPTURAR CUANDO UN USUARIO HACE 2 DOBLE CLICK y 
                //ahi en los argumentos del evento podemos tener la linea seleccionada



                //si hay mas de una linea selecionada igual solo muestro la primera
                _mensaje += "\n          Seleccion de DataGridView            \n";
                _mensaje += "Codigo: " + DgvTipos.SelectedRows[0].Cells[0].Value + "\n";
                _mensaje += "Nombre: " + DgvTipos.SelectedRows[0].Cells[1].Value + "\n";
                _mensaje += "Estanteria: " + DgvTipos.SelectedRows[0].Cells[2].Value + "\n";
            }

           //muestro todas las selecciones
            MessageBox.Show(_mensaje);
        }

        }
}
