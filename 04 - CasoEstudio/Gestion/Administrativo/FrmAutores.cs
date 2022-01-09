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
    public partial class FrmAutores : Form
    {
        //creo atributo de instancia en el formulario para mantener el adpatador y  los datos
        private System.Data.SqlClient.SqlDataAdapter _DAautor;
        private System.Data.DataSet _DS;

        public FrmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            //trabaja en forma desconectada
            System.Data.SqlClient.SqlConnection _cnn = new System.Data.SqlClient.SqlConnection("Data Source= .; Initial Catalog = Biblioteca; Integrated Security = true");
            
            try
            {
                //obtengo info a desplegar
                _DAautor = new System.Data.SqlClient.SqlDataAdapter("Exec ListoAutor", _cnn);
                _DS = new DataSet();
                _DAautor.FillSchema(_DS, SchemaType.Source, "Autor");
                _DAautor.Fill(_DS, "Autor");

                //muestro informacion en pantalla
                DGVAutores.DataSource = _DS.Tables["Autor"];
                
                //manipulo desde codigo el despliegue de la grilla
                DGVAutores.Columns[0].Visible = false;
                DGVAutores.Columns[1].HeaderText = "Nombre";
                DGVAutores.Columns[2].HeaderText = "Nacionalidad";
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //creo commnad builder para generar automaticamente comandos de actualizacion
                System.Data.SqlClient.SqlCommandBuilder _comando = new System.Data.SqlClient.SqlCommandBuilder(_DAautor);
               
                //actualizar informacion
                _DAautor.Update(_DS.Tables["Autor"]);
                _DS.AcceptChanges();

                //si llego aca, todo ok
                LblError.Text = "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

    }
}
