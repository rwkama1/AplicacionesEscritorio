using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaUsuario:IPersistenciaUsuario
    {
         //Singleton
        private static PersistenciaUsuario _miInstancia;
        private PersistenciaUsuario() { }
        public static PersistenciaUsuario GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new PersistenciaUsuario();
            return _miInstancia;
        }

        //Operaciones
       public Usuario BuscarUsuario(String pNombre)
        {
           //variables para crear usuario
            String _nombre;
            String _password;
            Usuario u = null;

           //variables para comunicacion ADO
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BuscoUsuario '" + pNombre + "' ", oConexion);
            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    _nombre = (String)oReader["NomUsu"];
                    _password = (String)oReader["PassUsu"];
                    u = new Usuario(_nombre,_password);
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return u;
        }

    }
}
