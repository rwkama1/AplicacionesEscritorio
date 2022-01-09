using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//personalizado
using EntidadesCompartidas;

namespace Controles
{
    public partial class CbAutor : ComboBox
    {
        public CbAutor()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        //creo un atributo para almacenar una coleccion de autores
        private List<Autor> _misAutores;

        //creo propiedad para asignar la coleccion
        public List<Autor> MisAutores
        {
            set
            {
                //primero guardo coleccion en atributo interno
                _misAutores = value;
                //luego ordeno la coleccion
                _misAutores.Sort();
                //luego asigno coleccion al listbox para despliegue
                this.DataSource = null;
                this.Items.Clear();
                this.DataSource = _misAutores;
                this.DisplayMember = "Nombre";
            }
        }

        //creo propiedad que devuelve el autor seleccionado, o null en caso contrario
        public Autor SeleccionAutor
        {
            get
            {
                if (this.SelectedIndex >= 0)
                {
                    return (_misAutores[this.SelectedIndex]);
                }
                else
                    return null;
            }
        }

        //creo metodo que permite dejar un objeto seleccionado dentro de la lista
        public void SeleccionarAutor(Autor unAutor)
        {
            int _indiceUnAutor = _misAutores.BinarySearch(unAutor);
            this.SelectedIndex = _indiceUnAutor; 
        }

    }
}
