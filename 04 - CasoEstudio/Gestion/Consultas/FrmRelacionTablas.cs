using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion
{
    public partial class FrmRelacionTablas : Form
    {

        public FrmRelacionTablas()
        {
            InitializeComponent();
        }

        private void FrmRelacionTablas_Load(object sender, EventArgs e)
        {
            //variables para obtener datos en forma Desconectada
            String _connString = "Data Source = .; Initial Catalog = Biblioteca; Integrated Security = true";
            DataSet _ds = new DataSet();
            System.Data.SqlClient.SqlDataAdapter _daAutores = new System.Data.SqlClient.SqlDataAdapter("Select * from Autor", _connString);
            System.Data.SqlClient.SqlDataAdapter _daLibros = new System.Data.SqlClient.SqlDataAdapter("Select * from Libro",_connString);

            try
            {
                //Cargo datos desde la bd 
                _daAutores.Fill(_ds, "Autor");
                _daLibros.Fill(_ds,"Libro");

                //Genero la relacion entre dos DataTables - 
                //DataRelation es un objeto q permite relacionar dos tablas por medio de campos
                //las unicas restrincciones son:
                // 1) q las tablas a relacionar pertenezcan al mismo DataSet
                // 2) q ambos campos sean del mismo tipo de datos. No puede controlar semantica
                //('NombreRelacion', tablaMaestro.Columns(x), tablaHija.Columns(x) )
                _ds.Relations.Add("RelAutorLibro", _ds.Tables["Autor"].Columns["CodAut"], _ds.Tables["Libro"].Columns["CodAut"]);
                
                //Cargo la grilla de autores
                DGVAutores.DataSource = _ds;
                DGVAutores.DataMember = "Autor";

                //cargo la segunda grilla con la relacion. Cada vez q se seleccione un autor, se filtraran automaticamente
                //los libros asociados
                DGVLibros.DataSource = _ds;
                DGVLibros.DataMember = "Autor.RelAutorLibro";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
