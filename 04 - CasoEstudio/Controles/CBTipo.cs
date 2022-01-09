using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntidadesCompartidas;

namespace Controles
{
    public partial class CBTipo : ComboBox
    {
        public CBTipo()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        //creo un atributo para almacenar una coleccion de tipo de libros
        private List<TipoLibro> _misTipos;

        //creo propiedad para asignar la coleccion
        public List<TipoLibro> MisTipos
        {
            set
            {
                //primero guardo coleccion en atributo interno
                _misTipos = value;
                //luego ordeno la coleccion
                _misTipos.Sort();
                //luego asigno coleccion al listbox para despliegue
                this.DataSource = null;
                this.Items.Clear();
                this.DataSource = _misTipos;
                this.DisplayMember = "Nombre";
            }
        }

        //creo propiedad que devuelve el tipo seleccionado, o null en caso contrario
        public TipoLibro SeleccionTipo
        {
            get
            {
                if (this.SelectedIndex >= 0)
                {
                    return (_misTipos[this.SelectedIndex]);
                }
                else
                    return null;
            }
        }

        //creo metodo que permite dejar un objeto seleccionado dentro de la lista
        public void SeleccionarTipo(TipoLibro unTipo)
        {
            int _indiceUnTipo = _misTipos.BinarySearch(unTipo);
            this.SelectedIndex = _indiceUnTipo;
        }

    }
}
